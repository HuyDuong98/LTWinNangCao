using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;

namespace QLKhoHang
{
    public partial class frmDSPhieuXuat : Form
    {
        PhieuNhap pn = new PhieuNhap();
        phieuxuat px = new phieuxuat();
        public frmDSPhieuXuat()
        {
            InitializeComponent();
        }

        private void cboKho_DropDown(object sender, EventArgs e)
        {
            cboKho.DataSource = pn.LoadcboKho();
            cboKho.DisplayMember = "TENKHO";
            cboKho.ValueMember = "MAKHO";
        }

        private void dataGVPhieuXuat_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGVPhieuXuat.Rows.Count; i++)
            {
                dataGVPhieuXuat.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void dataGVDSHangXuat_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGVDSHangXuat.Rows.Count; i++)
            {
                dataGVDSHangXuat.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void dataGVPhieuXuat_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            int index = dataGVPhieuXuat.CurrentCell.RowIndex;
            string ma = dataGVPhieuXuat.Rows[index].Cells["MAPX"].Value.ToString().Trim();
            dataGVDSHangXuat.DataSource = px.LoadDSHangXuat(ma);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int index = dataGVPhieuXuat.CurrentCell.RowIndex;
                string mapx = dataGVPhieuXuat.Rows[index].Cells["MAPX"].Value.ToString().Trim();
                int dem = dataGVDSHangXuat.RowCount;
                //MessageBox.Show(txtMaSoPhieu.Text + " " + masp);
                px.XoaDSPhieuXuat(mapx, dem);
                if (px.XoaPhieuXuat(mapx))
                {
                    dataGVPhieuXuat.DataSource = px.LoadPhieuXuatTheoKho(cboKho.SelectedValue.ToString());
                    MessageBox.Show("Xóa thành công");
                }
            }
            else
            {
                return;
            }
        }

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGVPhieuXuat.DataSource = px.LoadPhieuXuatTheoKho(cboKho.SelectedValue.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuXuat frm = new frmPhieuXuat();
            frm.ShowDialog();
        }
    }
}
