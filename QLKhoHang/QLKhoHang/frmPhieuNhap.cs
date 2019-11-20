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
    
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        SanPham_DAL qlkho = new SanPham_DAL();
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dataPhieuNhap.DataSource = qlkho.LoadDLNhapKho();
        }

        private void lblMST_Click(object sender, EventArgs e)
        {

        }
    }
}