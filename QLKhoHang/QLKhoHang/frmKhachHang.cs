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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        KhachHang kh = new KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }


        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dataGridViewKH.DataSource = kh.LoadDLKhachHang();
        }

        private void dataGridViewKH_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewKH.Rows.Count; i++)
            {
                dataGridViewKH.Rows[i].HeaderCell.Value = (i + 1).ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            panelControl1.Enabled = true;
            txtMaKH.Text = kh.MaKhachHang();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Trim() == string.Empty)
            {
                txtTenKH.Focus();
                MessageBox.Show("Bạn chưa nhập tên khách hàng");
                return;
            }
            KHACH_HANG p = new KHACH_HANG();
            p.MAKH = txtMaKH.Text.Trim();
            p.TENKH = txtTenKH.Text;
            p.SDTKH = txtSDT.Text;
            p.DIACHIKH = txtDiaChi.Text;
            p.EMAILKH = txtEmail.Text;
            if (kh.ThemKhachHang(p))
            {
                dataGridViewKH.DataSource = kh.LoadDLKhachHang();
                txtTenKH.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtSDT.Text = string.Empty;
                panelControl1.Enabled = false;
                btnLuu.Enabled = false;
                MessageBox.Show("Thêm thành công");

            }
            else { MessageBox.Show("Thêm thất bại"); }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int index = dataGridViewKH.CurrentCell.RowIndex;
                string ma = dataGridViewKH.Rows[index].Cells[0].Value.ToString().Trim();
                if (kh.KTTonTaiKhoaNgoai(ma))
                {
                    kh.XoaKhachHang(ma);
                    dataGridViewKH.DataSource = kh.LoadDLKhachHang();
                    MessageBox.Show("Xóa thành công");
                }
                else { MessageBox.Show("Không thể xóa khách hàng này"); }
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }
        }

        private void dataGridViewKH_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KHACH_HANG p = new KHACH_HANG();
            int index = dataGridViewKH.CurrentCell.RowIndex;
            //if (kh.IsNumber(p.SDTKH))
            //{
            if (kh.SuaTTKhachHang(p))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại");
            }
            dataGridViewKH.DataSource = kh.LoadDLKhachHang();
           // }
            //else { MessageBox.Show("Số điện thoại không đúng"); }
        }
        
        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            string k = txtTimKiem.Text.Trim();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExportToExcel p = new ExportToExcel();
            p.export2Excel(dataGridViewKH, @"D:\", "KhachHang");
        }

    }
}