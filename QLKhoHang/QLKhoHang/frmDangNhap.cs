﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhoHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lblTaiKhoan.Text.ToLower());
                this.txtTaiKhoan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống" + lblMatKhau.Text.ToLower());
                this.txtMatKhau.Focus();
                return;
            }
            int kq = connect.Check_Config();
            if (kq == 0)
            {
                ProcessLogin();
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                frmCauHinh f = new frmCauHinh();
                f.Show();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                frmCauHinh f = new frmCauHinh();
                f.Show();
            }
        }

        public void ProcessLogin()
        {
            connect.LoginResult result;
            result = connect.Check_User(txtTaiKhoan.Text, txtMatKhau.Text);
            if (result == connect.LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + lblTaiKhoan.Text + " hoặc " + lblMatKhau.Text);
                return;
            }

            else if (result == connect.LoginResult.Disabled)
            {
                MessageBox.Show("Tài Khoản bị khóa");
                return;
            }
            if (Program.mainForm == null || Program.mainForm.IsDisposed)
            {
                Program.mainForm = new FrmMain();
            }
            this.Visible = false;
            Program.mainForm.Show();
            
        }

       
    }
}