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
    public partial class frmDSPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        PhieuNhap pn = new PhieuNhap();
        public frmDSPhieuNhap()
        {
            InitializeComponent();
        }

        private void cboKho_DropDown(object sender, EventArgs e)
        {
            cboKho.DataSource = pn.LoadcboKho();
            cboKho.ValueMember = "MAKHO";
            cboKho.DisplayMember = "TENKHO";
        }

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGVPhieuNhap.DataSource = pn.LoadPhieuNhapTheoKho(cboKho.SelectedValue.ToString());
        }

        private void dataGVPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            int index = dataGVPhieuNhap.CurrentCell.RowIndex;
            string ma = dataGVPhieuNhap.Rows[index].Cells["MAPN"].Value.ToString().Trim();
            dataGVDSHangNhap.DataSource = pn.LoadDSHangNhap(ma);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int index = dataGVPhieuNhap.CurrentCell.RowIndex;
                string mapn = dataGVPhieuNhap.Rows[index].Cells["MAPN"].Value.ToString().Trim();
                int dem = dataGVDSHangNhap.RowCount;
                //MessageBox.Show(txtMaSoPhieu.Text + " " + masp);
                pn.XoaDSPhieuNhap(mapn, dem);
                if (pn.XoaPhieuNhap(mapn))
                {
                    dataGVPhieuNhap.DataSource = pn.LoadPhieuNhapTheoKho(cboKho.SelectedValue.ToString());
                    MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                return;
            }
        }

        private void dataGVPhieuNhap_DataSourceChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGVPhieuNhap.Rows.Count; i++)
            {
                dataGVPhieuNhap.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void dataGVDSHangNhap_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGVDSHangNhap.Rows.Count; i++)
            {
                dataGVDSHangNhap.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
    }
}