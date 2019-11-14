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
    public partial class frmCauHinh : Form
    {
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            connect.SaveConfig(cbSeverName.Text, txtUserName.Text, txtPassword.Text, cbDatabase.Text);
            this.Close();
        }

        private void cbSeverName_DropDown(object sender, EventArgs e)
        {
            DataTable tb = connect.GetSeverName();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cbSeverName.Items.Add(tb.Rows[i][0] + "//" + tb.Rows[i][1]);
            }
            cbSeverName.SelectedIndex = 0;
        }

        private void cbDatabase_DropDown(object sender, EventArgs e)
        {
            cbDatabase.DataSource = connect.GetDBName(cbSeverName.Text, txtUserName.Text, txtPassword.Text);
            cbDatabase.DisplayMember = "name";
        }
    }
}
