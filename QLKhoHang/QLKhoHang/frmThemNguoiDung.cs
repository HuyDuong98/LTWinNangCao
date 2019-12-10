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
    public partial class frmThemNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        QLNguoiDung qlnd = new QLNguoiDung();
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
            dataGridViewNguoiDung.DataSource = qlnd.LoadDTNguoiDung();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int index = dataGridViewNguoiDung.CurrentCell.RowIndex;
                string ma = dataGridViewNguoiDung.Rows[index].Cells["User"].Value.ToString().Trim();
                if (qlnd.XoaPhanQuyenUser(ma))
                {
                    if (qlnd.XoaNguoiDung(ma))
                    {
                        dataGridViewNguoiDung.DataSource = qlnd.LoadDTNguoiDung();
                        MessageBox.Show("Xóa thành công ");
                    }
                }
                else { MessageBox.Show("Xóa thất bại"); }
            }
            else
            {
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản");
                txtTenTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtMatKhau.Focus();
                return;
            }
            else 
            {
                QL_NGUOIDUNG user = new QL_NGUOIDUNG();
                user.TENDANGNHAP = txtTenTaiKhoan.Text.Trim();
                user.MATKHAU = txtMatKhau.Text.Trim();
                if (qlnd.ThemNguoiDung(user))
                {
                    QL_PHANQUYEN pq = new QL_PHANQUYEN();
                    pq.TENDANGNHAP = user.TENDANGNHAP;
                    if (radiobtAdmin.Checked == true)
                    {
                        pq.MANHOM = "ad";
                    }
                    else { pq.MANHOM = "nv"; }
                    if (qlnd.PhanQuyenUser(pq))
                    {
                        MessageBox.Show("Bạn đã thêm người dùng " + user.TENDANGNHAP);
                        txtTenTaiKhoan.Text = string.Empty;
                        txtMatKhau.Text = string.Empty;
                        txtTenTaiKhoan.Focus();
                    }
                    else { MessageBox.Show("Thêm thất bại"); }
                }
                else { MessageBox.Show("Đã có tài khoản"); }
            }

        }

        private void dataGridViewNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
        }

    }
}