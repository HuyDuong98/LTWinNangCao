using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL_BLL;

namespace QLKhoHang
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        
        public frmSanPham()
        {
            InitializeComponent();
        }
        SanPham_DAL spdal = new SanPham_DAL();
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dataGV_SanPham.DataSource = spdal.Load_DL();
           
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            groupControl1.Enabled = true;
            txtTenSP.Focus();
            txtMaSP.Text = spdal.MaSP();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Trim() == string.Empty)
            {
                txtTenSP.Focus();
                MessageBox.Show("bạn chưa nhập tên sản phẩm");
                return;
            }
            if (cboLoaiSP.SelectedValue.ToString() == null)
            {
                cboLoaiSP.Focus();
                MessageBox.Show("Bạn chưa chọn loại sản phẩm");
                return;
            }
            if (cboNCC.SelectedValue.ToString() == null)
            {
                cboNCC.Focus();
                MessageBox.Show("Bạn chưa chọn nhà cung cấp");
                return;
            }
            if (txtGiaNhap.Text.Trim() == string.Empty)
            {
                txtGiaNhap.Focus();
                MessageBox.Show("Bạn chưa nhập giá nhập của sản phẩm");
                return;
            }
            if (txtGiaBanLe.Text.Trim() == string.Empty)
            {
                txtGiaBanLe.Focus();
                MessageBox.Show("Bạn chưa nhập giá bán lẻ của sản phẩm");
                return;
            }
            if (txtGiaBanSi.Text.Trim() == string.Empty)
            {
                txtGiaBanSi.Focus();
                MessageBox.Show("Bạn chưa nhập giá bán sỉ của sản phẩm");
                return;
            }
            if (cboKho.SelectedValue == null)
            {
                cboKho.Focus();
                MessageBox.Show("Bạn chưa chọn kho hàng");
                return;
            }
            SAN_PHAM p = new SAN_PHAM();
            p.MASP = txtMaSP.Text.Trim();
            p.TEN_SP = txtTenSP.Text;
            p.MALOAI = cboLoaiSP.SelectedValue.ToString().Trim();
            p.MANCC = cboNCC.SelectedValue.ToString().Trim();
            p.MANSX = cboNSX.SelectedValue.ToString().Trim();
            p.MAUSAC = txtMauSac.Text;
            p.DVT = txtDVT.Text;
            p.GIANHAP = double.Parse(txtGiaNhap.Text.Trim());
            p.GIABANSI = double.Parse(txtGiaBanSi.Text.Trim());
            p.GIABANLE = double.Parse(txtGiaBanLe.Text.Trim());
            p.MOTASP = txtGhiChu.Text;
            p.MAKHO = cboKho.SelectedValue.ToString().Trim();
            if (spdal.ThemSanPham(p))
            {
                dataGV_SanPham.DataSource = spdal.Load_DL();
                groupControl1.Enabled = false;
                btnLuu.Enabled = false;
                MessageBox.Show("Thêm thành công");
            }
            else
            { 
                MessageBox.Show("Thêm thất bại");
            }
            
        }

        private void dataGV_SanPham_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int index = dataGV_SanPham.CurrentCell.RowIndex;
                string ma = dataGV_SanPham.Rows[index].Cells[0].Value.ToString().Trim();
                if (spdal.XoaSanPham(ma))
                {
                    dataGV_SanPham.DataSource = spdal.Load_DL();
                    MessageBox.Show("Xóa thành công ");
                }
                else { MessageBox.Show("Sản phẩm không được xóa"); }
            }
            else
            {
                return;
            }
        }

        private void cboLoaiSP_DropDown(object sender, EventArgs e)
        {
            cboLoaiSP.DataSource = spdal.LoadCboLoaiSP();
            cboLoaiSP.DisplayMember = "TENLOAI";
            cboLoaiSP.ValueMember = "MALOAI";
        }

        private void cboNCC_DropDown(object sender, EventArgs e)
        {
            cboNCC.DataSource = spdal.LoadCboNCC();
            cboNCC.DisplayMember = "TENNCC";
            cboNCC.ValueMember = "MANCC";
        }

        private void cboNSX_DropDown(object sender, EventArgs e)
        {
            cboNSX.DataSource = spdal.LoadCboNSX();
            cboNSX.DisplayMember = "TENNSX";
            cboNSX.ValueMember = "MANSX";
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBanLe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBanSi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnNSX_Click(object sender, EventArgs e)
        {
            frmNhaSanXuat frm = new frmNhaSanXuat();
            frm.ShowDialog();
            }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frm = new frmLoaiSanPham();
            frm.ShowDialog();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.ShowDialog();        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SAN_PHAM p = new SAN_PHAM();
            int index = dataGV_SanPham.CurrentCell.RowIndex;
            if (spdal.SuaTTSanPham(p))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại");
            }
            dataGV_SanPham.DataSource = spdal.Load_DL();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExportToExcel p = new ExportToExcel();
            p.export2Excel(dataGV_SanPham, @"D:\", "SanPham");
        }

        private void cboKho_DropDown(object sender, EventArgs e)
        {
            cboKho.DataSource = spdal.LoadcboKhoHang();
            cboKho.DisplayMember = "TENKHO";
            cboKho.ValueMember = "MAKHO";
        }

        private void dataGV_SanPham_DataSourceChanged_1(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            for (int i = 0; i < dataGV_SanPham.Rows.Count; i++)
            {
                dataGV_SanPham.Rows[i].HeaderCell.Value = (i + 1).ToString();

            }
        }

  
    }
}