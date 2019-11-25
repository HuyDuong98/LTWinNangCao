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
    public partial class frmThongTinCTy : DevExpress.XtraEditors.XtraForm
    {
        CongTycs cty = new CongTycs();
        CONG_TY ct = new CONG_TY();
        public frmThongTinCTy()
        {
            InitializeComponent();
        }

        private void frmThongTinCTy_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show(ct.TENCTY);
            txtTenCongTy.Text = ct.TENCTY;
            txtDienThoai.Text = ct.SDTCT;
            txtDiaChi.Text = ct.DIACHICT;
            txtEmail.Text = ct.EMAILCT;
            txtFax.Text = ct.FAX;
            txtGhiChu.Text = ct.MOTACT;
            txtLinhVuc.Text = ct.LINHVUC;
            txtMaSoThue.Text = ct.MASOTHUE;
            txtWebsite.Text = ct.WEBSITECT;
        }
    }
}