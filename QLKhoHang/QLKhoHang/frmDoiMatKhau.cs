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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        DangNhap_DAL dn = new DangNhap_DAL();
        QL_NGUOIDUNG qlnd = new QL_NGUOIDUNG();
        DoiMatKhau dmk = new DoiMatKhau();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text.Trim() != DangNhap_DAL.Pass)
            {
                MessageBox.Show("Sai mật khẩu");
                txtMatKhauCu.Text = string.Empty;
                txtMatKhauCu.Focus();
                return;
            }
            else {
                if (txtMatKhauMoi.Text == txtXacNhanMK.Text)
                {

                    QL_NGUOIDUNG p = new QL_NGUOIDUNG();
                    p.TENDANGNHAP = DangNhap_DAL.UserName;
                    p.MATKHAU = txtMatKhauMoi.Text.Trim();
                    if (dmk.ThayDoiMK(p))
                    {
                        MessageBox.Show("Cập nhật thông tin thành công");
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin thất bại");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu không trùng khớp");
                    return;
                }
            }
        }
    }
}