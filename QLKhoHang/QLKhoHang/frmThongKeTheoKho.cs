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
    public partial class frmThongKeTheoKho : DevExpress.XtraEditors.XtraForm
    {
        PhieuNhap pn = new PhieuNhap();
        phieuxuat px = new phieuxuat();
        tkTheoKho tk = new tkTheoKho();
        public frmThongKeTheoKho()
        {
            InitializeComponent();
        }

        private void cboKho_DropDown(object sender, EventArgs e)
        {
            cboKho.DataSource = pn.LoadcboKho();
            cboKho.DisplayMember = "TENKHO";
            cboKho.ValueMember = "MAKHO";
        }

        private void frmThongKeTheoKho_Load(object sender, EventArgs e)
        {
            
        }

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGVThongKe.DataSource = tk.LoadDTTheoKho(cboKho.SelectedValue.ToString());
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExportToExcel p = new ExportToExcel();
            p.export2Excel(dataGVThongKe, @"D:\", "ThongKe_Kho"+cboKho.SelectedText);
        }

    }
}