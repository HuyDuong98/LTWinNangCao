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
using DevExpress.XtraReports.UI;

namespace QLKhoHang
{
    public partial class frmReportTheoMuc : DevExpress.XtraEditors.XtraForm
    {
        public frmReportTheoMuc()
        {
            InitializeComponent();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            rpSanPham rp = new rpSanPham();
            rp.ShowPreviewDialog();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            rpDSNhap rp = new rpDSNhap();
            rp.ShowPreviewDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            rpDSHangXuat rp = new rpDSHangXuat();
            rp.ShowPreviewDialog();
        }
    }
}