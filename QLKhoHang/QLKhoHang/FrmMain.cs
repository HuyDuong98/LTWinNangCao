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
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
           
        }
        
        DangNhap_DAL dn = new DangNhap_DAL();
        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnHeThong.PerformClick();
            this.WindowState =System.Windows.Forms.FormWindowState.Maximized;
        }
        //các btn của hệ thống
        string rdn = "Đăng nhập lại";
        string dmk = "Đổi mật khẩu";
        string pqnv = "Phân quyền nhân viên";
        string ttct = "Thông tin công ty";
        // các btn của danh mục
        string ttsp = "Thông tin sản phẩm";
        string lsp = "Loại sản phẩm";
        string nsp = "Nhóm sản phẩm";
        string nsx = "Nhà sản xuất";
        string ncc = "Nhà cung cấp";
        string ttkh = "Thông tin khách hàng";
        string nkh = "Nhóm khách hàng";
        string nv = "Nhân viên";
        // các btn của quản lý kho
        string nk = "Nhập kho";
        string xk = "Xuất kho";
        string ck = "Chuyển kho";
        string dsnk = "Danh sách nhập kho";
        string dsxk = "Danh sách xuất kho";
        string dsck = "Danh sách chuyển kho";
        // các btn của quản lý đơn hàng
        string ddh = "Đơn đặt hàng";
        // các btn của thống kê báo cáo
        string bcnk = "Báo cáo nhập kho";
        string bcxk = "Báo cáo xuất kho";
        string bctk = "Báo cáo tồn kho";
        private void ThongBaoDangNhap() {
            if (dn.MaNhomPer(DangNhap_DAL.UserName))
            {
                MessageBox.Show("Chào " + DangNhap_DAL.UserName + " .Bạn đang đăng nhập với quyền admin");
            }
            else { MessageBox.Show("Chào " + DangNhap_DAL.UserName + " .Bạn đang đăng nhập với quyền người dùng"); }
            //MessageBox.Show("Xin chào "+DangNhap_DAL.UserName);
        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            deleteArrayButton();
            grDanhMuc.Text = "Hệ thống";
            
             //Phân quyền return 1 là admin 0 là nhân viên
            if (dn.MaNhomPer(DangNhap_DAL.UserName))
            {
                string[] a = new string[] { rdn, dmk, pqnv, ttct };
                CreateArrayButton(4, a);

            }
            else
            {
                string[] a = new string[] { rdn, dmk, ttct };
                CreateArrayButton(3, a);
            }
        }
        

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            deleteArrayButton();
            grDanhMuc.Text = "Danh mục";
            string[] a = new string[] { ttsp, lsp, nsp, nsx, ncc, ttkh, nkh, nv };
            CreateArrayButton(8,a);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            deleteArrayButton();
            grDanhMuc.Text = "Quản lý kho hàng";
            string[] a = new string[] { nk, xk, ck, dsnk, dsxk, dsck};
            CreateArrayButton(6,a);
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            deleteArrayButton();
            grDanhMuc.Text = "Đơn hàng";
            string[] a = new string[] { ddh};
            CreateArrayButton(1, a);
        }

        private void btnTKBC_Click(object sender, EventArgs e)
        {
            deleteArrayButton();
            grDanhMuc.Text = "Thống kê - báo cáo";
            string[] a = new string[] { bcnk,bcxk,bctk};
            CreateArrayButton(3, a);
        }
        // tạo mảng menu con
        public void CreateArrayButton(int soHang,string[] ar)
        {
            int cR = 35;
            int top = 0;
            int j = 0;
            for (int i = 0; i < soHang; i++)
            {
                SimpleButton bt = new SimpleButton();
                bt.Name = string.Format("bt" + i);
                bt.Text = string.Format(ar[j]);
                bt.Size = new Size(207, cR);
                bt.Tag = string.Format("" + i);
                bt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                bt.AppearanceHovered.BackColor = System.Drawing.Color.PowderBlue;
                //bt.AppearanceHovered.Options.UseBackColor = true;
                j += 1;
                bt.Top = top;
                top += cR;
                grDanhMuc.Controls.Add(bt);
                pnDanhMuc.Controls.Add(bt);
                bt.Click += new EventHandler(bt_Click);
            }
            
        }
        // Khai báo form
        frmDangNhap frmDN = new frmDangNhap();
        frmDoiMatKhau frmDMK = new frmDoiMatKhau();

        // gọi các form từ menu con
        private void GoiShow(Form frm)
        {
            frm.TopLevel = false;
            panelContent.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frm.Show();
        }

        //Bắt sự kiên click cho btn trong menu con trong form main
        private void bt_Click(object sender, EventArgs e)
        {
            SimpleButton sd = new SimpleButton();
            sd = (SimpleButton)sender;
            if (sd.Text == rdn)
            {
                frmDN.ShowDialog();
                btnHeThong.PerformClick();
            }
           
            if (sd.Text == dmk)
            {
                frmDMK.ShowDialog();
                btnHeThong.PerformClick();

            }
            if (sd.Text == ttct)
            {
                frmThongTinCTy frm = new frmThongTinCTy();
                GoiShow(frm);
            }
            if (sd.Text == ttsp)
            {
                frmSanPham frm = new frmSanPham();
                GoiShow(frm);
            }
            if (sd.Text == nk)
            {
                frmPhieuNhap frm = new frmPhieuNhap();
                GoiShow(frm);
            }
            if (sd.Text == xk)
            {
                frmPhieuXuat frm = new frmPhieuXuat();
                GoiShow(frm);
            }
            if (sd.Text == ck)
            {
                frmChuyenKho frm = new frmChuyenKho();
                GoiShow(frm);
            }
        }

        public void deleteArrayButton()
        {
            pnDanhMuc.Controls.Clear();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (pnMenuButton.Visible == true)
            {
                pnMenuButton.Visible = false;
            }
            else { pnMenuButton.Visible = true; }
        }

        private void btnThoat_menu_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnDNLai_menu_Click(object sender, EventArgs e)
        {
            
            frmDN.ShowDialog();
        }

        private void btnDoiMK_menu_Click(object sender, EventArgs e)
        {
            
            frmDMK.ShowDialog();
        }

        private void PhanQuyen(object sender, EventArgs e)
        {
            
        }

    }
}