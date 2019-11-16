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
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        SanPham_DAL spdal = new SanPham_DAL();
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dataGV_SanPham.DataSource = spdal.Load_DL();
        }

        
    }
}