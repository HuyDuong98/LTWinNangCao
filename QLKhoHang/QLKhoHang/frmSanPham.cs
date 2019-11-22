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
            txtMaSP.Text = spdal.MaSP();
        }


        private void cboNCC_DropDown(object sender, EventArgs e)
        {
            cboNCC.DataSource = spdal.LoadCboNCC();
            cboNCC.DisplayMember = "TENNCC";
            cboNCC.ValueMember = "MANCC";
        }

        private void cboNSX_DropDown(object sender, EventArgs e)
        {
            cboNSX.DataSource = spdal.LoadCboNSX();
            cboNSX.DisplayMember = "TENNSX";
            cboNSX.ValueMember = "MANSX";
        }

        private void cboLoaiSP_DropDown(object sender, EventArgs e)
        {
            cboLoaiSP.DataSource = spdal.LoadCboLoaiSP();
            cboLoaiSP.DisplayMember = "TENLOAI";
            cboLoaiSP.ValueMember = "MALOAI";
        }



        
    }
}