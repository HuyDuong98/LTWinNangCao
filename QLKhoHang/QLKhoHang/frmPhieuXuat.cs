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
    public partial class frmPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        SanPham_DAL qlkho = new SanPham_DAL();
        PhieuNhap pn = new PhieuNhap();
        phieuxuat px = new phieuxuat();
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void cboNhanVien_DropDown(object sender, EventArgs e)
        {
            cboNhanVien.DataSource = qlkho.LoadcboNhanVien();
            cboNhanVien.DisplayMember = "TENNV";
            cboNhanVien.ValueMember = "MANV";
            cboNhanVien.SelectedIndex = 0;
        }

        private void dataGVDSHangXuat_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGVDSHangXuat.Rows.Count; i++)
            {
                dataGVDSHangXuat.Rows[i].HeaderCell.Value = (i + 1).ToString();

            }
        }

        private void cboSP_DropDown(object sender, EventArgs e)
        {
            cboSP.DataSource = px.LoadcboSpKho(cboKho.SelectedValue.ToString().Trim());
            cboSP.DisplayMember = "TEN_SP";
            cboSP.ValueMember = "MASP";
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboKho.Enabled = true;
            cboNhanVien.Enabled = true;
            txtMaPhieu.Text = qlkho.MaPhieuXuat();
            btnLuu.Enabled = true;
            btnThemPheu.Enabled = true;
        }

        private void btnThemPheu_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Chọn người lập phiếu");
                return;
            }
            if (cboKho.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn kho");
                return;
            }
            else
            {
                PHIEU_XUAT p = new PHIEU_XUAT();
                p.MAPX = txtMaPhieu.Text.Trim();
                p.MANV = cboNhanVien.SelectedValue.ToString();
                p.NGAYXUAT = datePhieuXuat.Value;
                p.MOTAPHIEUXUAT = txtMoTa.Text;
                p.MAKHO = cboKho.SelectedValue.ToString();
                if (px.ThemPhieuXuat(p))
                {
                    MessageBox.Show("Thêm thành công");
                    btnThemSP.Enabled = true;
                    btnThemPheu.Enabled = false;
                    cboKho.Enabled = false;
                    cboNhanVien.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }

            }
        }

        private void cboKho_DropDown(object sender, EventArgs e)
        {
            cboKho.DataSource = pn.LoadcboKho();
            cboKho.DisplayMember = "TENKHO";
            cboKho.ValueMember = "MAKHO";
            cboKho.SelectedIndex = 0;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (cboSP.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
                return;
            }
            else
            {
                DSHANGXUAT ds = new DSHANGXUAT();
                ds.SLTon = px.SLHangTonKho(cboKho.SelectedValue.ToString(), cboSP.SelectedValue.ToString());
                MessageBox.Show(ds.SLTon.ToString());
                if (px.KTTonTaiSPTrongPhieuXuat(txtMaPhieu.Text.Trim(), cboSP.SelectedValue.ToString()))
                {
                    ds.MAPX = txtMaPhieu.Text.Trim();
                    ds.MASP = cboSP.SelectedValue.ToString();
                    ds.MAKHO = cboKho.SelectedValue.ToString();
                    ds.SoLuong = 1;
                    
                    if (px.ThemSPvaoDSHangXuat(ds,cboKho.SelectedValue.ToString()))
                    {
                        dataGVDSHangXuat.DataSource = px.LoadDSHangXuat(txtMaPhieu.Text.Trim());
                    }
                    else { return; }
                }
                else
                {
                    if (px.SuaTTDSPhieuXuat(ds))
                    {
                        dataGVDSHangXuat.DataSource = px.LoadDSHangXuat(txtMaPhieu.Text.Trim());
                    }
                    else { return; }
                }
            }
        }

    }
}