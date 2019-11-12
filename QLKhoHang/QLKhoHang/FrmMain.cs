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

namespace QLKhoHang
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();

        }
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnHeThong_Click(sender, e);
            
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
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            deleteArrayButton();
            grDanhMuc.Text = "Hệ thống";
            string[] a = new string[] { rdn, dmk, pqnv, ttct};
            CreateArrayButton(4,a);
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
            string[] a = new string[] { "Nhập kho", "Xuất kho", "Chuyển kho", "Danh sách phiếu nhập kho", "Danh sách phiếu xuất kho", "Danh sách phiếu chuyển kho"};
            CreateArrayButton(6,a);
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            deleteArrayButton();
            grDanhMuc.Text = "Đơn hàng";
            string[] a = new string[] { "Đơn đặt hàng"};
            CreateArrayButton(1, a);
        }

        private void btnTKBC_Click(object sender, EventArgs e)
        {
            deleteArrayButton();
            grDanhMuc.Text = "Thống kê - báo cáo";
            string[] a = new string[] { "Báo cáo nhập hàng", "Báo cáo xuất hàng", "Báo Tồn Kho"};
            CreateArrayButton(3, a);
        }

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
        private void bt_Click(object sender, EventArgs e)
        {
            SimpleButton sd = new SimpleButton();
            sd = (SimpleButton)sender;
            if (sd.Text == rdn)
            {
                MessageBox.Show("Bạn đang nhấn nút " + sd.Tag);
            }
            if (sd.Text == dmk)
            {
                MessageBox.Show("Bạn đang nhấn nút " + sd.Tag);
            }
        }

        public void deleteArrayButton()
        {
            pnDanhMuc.Controls.Clear();
        }

    }
}