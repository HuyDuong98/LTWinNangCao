using System;
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
    public partial class frnCauHinh : Form
    {
        public frnCauHinh()
        {
            InitializeComponent();
        }
        connect cn = new connect();
        private void cbSeverName_DropDown(object sender, EventArgs e)
        {
            cbSeverName.DataSource = cn.GetServerName();
            cbSeverName.DisplayMember = "ServerName";
        }

        private void cbDatabase_DropDown(object sender, EventArgs e)
        {
            cbDatabase.DataSource = cn.GetDBName(cbSeverName.Text);
            cbDatabase.DisplayMember = "name";
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            cn.SaveConfig(cbSeverName.Text, cbDatabase.Text);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void frnCauHinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }
    }
}
