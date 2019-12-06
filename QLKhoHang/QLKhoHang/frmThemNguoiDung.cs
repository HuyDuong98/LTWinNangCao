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

    }
}