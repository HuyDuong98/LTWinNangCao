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
using System.Data.SqlClient;

namespace QLKhoHang
{
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        SanPham_DAL qlkho = new SanPham_DAL();
        PhieuNhap pn = new PhieuNhap();
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
           
        }


        private void dataPhieuNhap_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewSP.Rows.Count; i++)
            {
                dataGridViewSP.Rows[i].HeaderCell.Value = (i + 1).ToString();

            }
        }
        // Load combo box sản phẩm
        private void cboSP_DropDown(object sender, EventArgs e)
        {
            cboSP.DataSource = qlkho.LoadcboSanPham();
            cboSP.DisplayMember = "TEN_SP";
            cboSP.ValueMember = "MASP";
            cboSP.SelectedIndex = 0;
        }

        // Load combo box nhân viên
        private void cboNhanVien_DropDown(object sender, EventArgs e)
        {
            cboNhanVien.DataSource = qlkho.LoadcboNhanVien();
            cboNhanVien.DisplayMember = "TENNV";
            cboNhanVien.ValueMember = "MANV";
            cboNhanVien.SelectedIndex = 0;
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            panelPhieuNhap.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnThemPhieuNhap.Enabled = true;
            txtMaSoPhieu.Text = qlkho.KiemTraTrung();
            txtDienGiai.Text = string.Empty;
            btnThemSP.Enabled = false;
            btnXoaSP.Enabled = false;
            cboNhanVien.Enabled = true;
            cboKho.Enabled = true;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HANGTON ht = new HANGTON();
            int dem = dataGridViewSP.RowCount;
            MessageBox.Show(dem+"");
            if (dataGridViewSP.DataSource == null)
            {
                MessageBox.Show("Chưa có sản phẩm");
                return;
            }
            else
            {
                for (int i = 0; i < dem; i++)
                {
                    ht.MAKHO = cboKho.SelectedValue.ToString().Trim();
                    ht.MASP = dataGridViewSP.Rows[i].Cells["MASP"].Value.ToString().Trim();
                    ht.SOLUONG = int.Parse(dataGridViewSP.Rows[i].Cells["SL"].Value.ToString());
                    pn.ThemSPvaoKho(ht);
                    //MessageBox.Show(ht.MAKHO + "_" + ht.MASP + "_" + ht.SOLUONG);
                }
                MessageBox.Show("Đã lưu");
                btnThem.PerformClick();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoaSP.PerformClick();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExportToExcel p = new ExportToExcel();
            p.export2Excel(dataGridViewSP, @"D:\", "fileExcelPhieuNhap");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DSHANGNHAP ds = new DSHANGNHAP();
            int index = dataGridViewSP.CurrentCell.RowIndex;
            ds.MAPN = dataGridViewSP.Rows[index].Cells["MAPN"].Value.ToString().Trim();
            ds.MASP = dataGridViewSP.Rows[index].Cells["MASP"].Value.ToString().Trim();
            ds.SL = int.Parse(dataGridViewSP.Rows[index].Cells["SL"].Value.ToString().Trim());
            if (pn.SuaSoLuongSP(ds))
            {
                dataGridViewSP.DataSource = pn.LoadDSHangNhap(txtMaSoPhieu.Text.Trim());
                MessageBox.Show("Sửa thành công");
            }
            else { MessageBox.Show("Sửa thất bại"); }
        }
        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn người lập phiếu");
                return;
            }
            if (cboKho.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn kho");
                return;
            }
            else
            {
                PHIEU_NHAP p = new PHIEU_NHAP();
                p.MAPN = txtMaSoPhieu.Text.Trim();
                p.MANV = cboNhanVien.SelectedValue.ToString();
                p.NGAYNHAP = datePhieuNhap.Value;
                p.NOIDUNG = txtDienGiai.Text;
                p.MAKHO = cboKho.SelectedValue.ToString();
                if (pn.ThemPhieuNhap(p))
                {
                    btnThemSP.Enabled = true;
                    cboKho.Enabled = false;
                    cboNhanVien.Enabled = false;
                    btnThemPhieuNhap.Enabled = false;
                    MessageBox.Show("Bạn đã thêm phiếu " + p.MAPN);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                return;
            }  
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            //Thêm ds phiếu nhập vào table ds phiếu nhập
            if (cboSP.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
                return;
            }
            else
            {
                DSHANGNHAP ds = new DSHANGNHAP();
                ds.MAPN = txtMaSoPhieu.Text.Trim();
                ds.MASP = cboSP.SelectedValue.ToString().Trim();
                ds.ThanhTien = pn.ThanhTien(1, ds.MASP);
                if (pn.KTTonTaiSPTrongPhieuNhap(txtMaSoPhieu.Text.Trim(), cboSP.SelectedValue.ToString()))
                {
                    ds.SL = 1;
                    if (pn.ThemDSHangNhapKho(ds))
                    {
                        dataGridViewSP.DataSource = pn.LoadDSHangNhap(txtMaSoPhieu.Text.Trim());
                    }
                    else { return; }
                }
                else
                {
                    if (pn.SuaTTDSPhieuNhap(ds))
                    {
                        dataGridViewSP.DataSource = pn.LoadDSHangNhap(txtMaSoPhieu.Text.Trim());
                    }
                    else { return; }
                }
                
            }
        }

        private void dataGridViewSP_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int index = dataGridViewSP.CurrentCell.RowIndex;
                string masp = dataGridViewSP.Rows[index].Cells["MASP"].Value.ToString().Trim();
                //MessageBox.Show(txtMaSoPhieu.Text + " " + masp);
                if (pn.XoaSPTrongDSHangNhap(txtMaSoPhieu.Text.Trim(), masp))
                {
                    dataGridViewSP.DataSource = pn.LoadDSHangNhap(txtMaSoPhieu.Text.Trim());
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void dataGridViewSP_SelectionChanged(object sender, EventArgs e)
        {
            btnXoaSP.Enabled = true;
        }

        private void dataGridViewSP_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewSP.Rows.Count; i++)
            {
                dataGridViewSP.Rows[i].HeaderCell.Value = (i + 1).ToString();

            }

        }

        private void cboKho_DropDown(object sender, EventArgs e)
        {
            cboKho.DataSource = pn.LoadcboKho();
            cboKho.DisplayMember = "TENKHO";
            cboKho.ValueMember = "MAKHO";
            cboKho.SelectedIndex = 0;
        }

        private void dataGridViewSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}