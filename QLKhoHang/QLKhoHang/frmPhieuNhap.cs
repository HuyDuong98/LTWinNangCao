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
        }

        // Load combo box nhân viên
        private void cboNhanVien_DropDown(object sender, EventArgs e)
        {
            cboNhanVien.DataSource = qlkho.LoadcboNhanVien();
            cboNhanVien.DisplayMember = "TENNV";
            cboNhanVien.ValueMember = "MANV";
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            panelPhieuNhap.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnThemPhieuNhap.Enabled = true;
            txtMaSoPhieu.Text = qlkho.KiemTraTrung();
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
            if (cboSP.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
                cboSP.Focus();
                return;
            }
            if (panelPhieuNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ngày");
                panelPhieuNhap.Focus();
                return;
            }
            if(cboNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên");
                cboNhanVien.Focus();
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExportToExcel p = new ExportToExcel();
            p.export2Excel(dataGridViewSP, @"D:\", "fileExcelPhieuNhap");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn người lập phiếu");
                return;
            }
            else
            {
                PHIEU_NHAP p = new PHIEU_NHAP();
                p.MAPN = txtMaSoPhieu.Text.Trim();
                p.MANV = cboNhanVien.SelectedValue.ToString();
                p.NGAYNHAP = datePhieuNhap.Value;
                p.NOIDUNG = txtDienGiai.Text;
                if (pn.ThemPhieuNhap(p))
                {
                    btnThemSP.Enabled = true;
                    btnThemPhieuNhap.Enabled = false;
                    MessageBox.Show("Bạn đã thêm phiếu "+p.MAPN);
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
            if (e.KeyCode == Keys.Tab && dataGridViewSP.CurrentCell.ColumnIndex == 1)
            {
                e.Handled = true;
                DataGridViewCell cell = dataGridViewSP.Rows[0].Cells[0];
                dataGridViewSP.CurrentCell = cell;
                dataGridViewSP.BeginEdit(true);
            }
        }
    }
}