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

    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        SanPham_DAL qlkho = new SanPham_DAL();
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
           
            dataPhieuNhap.DataSource = qlkho.LoadDLNhapKho();
            txtMaSoPhieu.Text = qlkho.KiemTraTrung();
        }

        private void lblMST_Click(object sender, EventArgs e)
        {

        }

        private void dataPhieuNhap_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataPhieuNhap.Rows.Count; i++)
            {
                dataPhieuNhap.Rows[i].HeaderCell.Value = (i + 1).ToString();

            }
        }

        private void cboSP_DropDown(object sender, EventArgs e)
        {
            cboSP.DataSource = qlkho.LoadcboSanPham();
            cboSP.DisplayMember = "TEN_SAN_";
            cboSP.ValueMember = "MASP";
            
        }

        private void cboSP_SelectedValueChanged(object sender, EventArgs e)
        {
            string masp = cboSP.SelectedValue.ToString().Trim();
            txtMaSP.Text = masp;
            txtGiaBan.Text = qlkho.LayGiaBanSP(masp);

        }

        private void cboNhanVien_DropDown(object sender, EventArgs e)
        {
            cboNhanVien.DataSource = qlkho.LoadcboNhanVien();
            cboNhanVien.DisplayMember = "TENNV";
            cboNhanVien.ValueMember = "MANV";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            

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
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn số lượng");
                txtSoLuong.Focus();
                return;
            }
            if (datePhieuNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ngày");
                datePhieuNhap.Focus();
                return;
            }
            if(cboNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên");
                cboNhanVien.Focus();
                return;
            }
            PHIEU_NHAP pn = new PHIEU_NHAP();
            if(qlkho.KTKhoaPhieuNhap(txtMaSoPhieu.Text))
            {
                pn.MAPN = txtMaSoPhieu.Text;
                pn.MANV = cboNhanVien.SelectedValue.ToString().Trim();
                pn.NGAYNHAP = datePhieuNhap.DateTime;
                pn.NOIDUNG = txtDienGiai.Text;
                pn.SL = int.Parse(txtSoLuong.Text);
                MessageBox.Show("" + pn.MAPN + pn.MANV + pn.NGAYNHAP + pn.NOIDUNG + pn.SL);
                if (qlkho.ThemPhieuNhap(pn))
                {
                    dataPhieuNhap.DataSource = qlkho.LoadDLNhapKho();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            
        }




    }
}