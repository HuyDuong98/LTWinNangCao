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
    public partial class frmNhaSanXuat : DevExpress.XtraEditors.XtraForm
    {
        NhaSanXuat nsx = new NhaSanXuat();
        public frmNhaSanXuat()
        {
            InitializeComponent();
        }



        private void frmNhaSanXuat_Load(object sender, EventArgs e)
        {
            DangNhap_DAL dn = new DangNhap_DAL();
            if (dn.MaNhomPer(DangNhap_DAL.UserName))
            {
                pnControl.Enabled = true;
            }
            else
            {
                pnControl.Enabled = false;
            }
            dataGridViewNSX.DataSource = nsx.LoadDLNSX();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelNhaSanXuat.Enabled = true;
            btnLuu.Enabled = true;
            ResetControlValues(this);
            //foreach (Control ct in this.Controls)
            //{
            //    if (ct is DevExpress.XtraEditors.TextEdit || ct is TextBox)
            //    {
            //        ct.Text = "";
            //    }
            //}
            txtMa.Text = nsx.MaNSX();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                txtMa.Focus();
                MessageBox.Show("Bạn chưa nhập mã");
                return;
            }
            if(txtTen.Text == "")
            {
                txtTen.Focus();
                MessageBox.Show("Bạn chưa nhập tên nhà sản xuất");
                return;
            }
            
            if (nsx.KiemTraTrung(txtMa.Text.Trim()))
            {
                NHA_SAN_XUAT p = new NHA_SAN_XUAT();
                p.MANSX = txtMa.Text.Trim();
                p.TENNSX = txtTen.Text.Trim();
                p.EMAILNSX = txtEmail.Text;
                p.WEBSITENSX = txtWebsite.Text;
                p.MOTANSX = txtMoTa.Text;
                if (nsx.ThemNSX(p))
                {
                    dataGridViewNSX.DataSource = nsx.LoadDLNSX();
                    panelNhaSanXuat.Enabled = false;
                    btnLuu.Enabled = false;
                    MessageBox.Show("Thêm thành công");
                }
                else {
                    MessageBox.Show("Thêm thất bại");
                }
              
            }
            else {
                MessageBox.Show("Mã đã tồn tại");
                txtMa.Text = nsx.MaNSX();
                return;
            }
        }

        public static void ResetControlValues(Control Parent)
        {

            foreach (Control mycontrols in Parent.Controls)
                if (mycontrols is TextBox)
                {

                    (mycontrols as TextBox).Text = string.Empty;

                }
                else if(mycontrols is TextEdit)
                {
                    (mycontrols as TextEdit).Text = string.Empty;
                }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int index = dataGridViewNSX.CurrentCell.RowIndex;
                string ma = dataGridViewNSX.Rows[index].Cells[0].Value.ToString().Trim();
                nsx.XoaNhaSX(ma);
                dataGridViewNSX.DataSource = nsx.LoadDLNSX();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }
        }


        private void dataGridViewNSX_DataSourceChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewNSX.Rows.Count; i++)
            {
                dataGridViewNSX.Rows[i].HeaderCell.Value = (i + 1).ToString();

            }
        }

        private void dataGridViewNSX_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NHA_SAN_XUAT p = new NHA_SAN_XUAT();
            int index = dataGridViewNSX.CurrentCell.RowIndex;

            if (nsx.SuaTTNhaSanXuat(p))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại");
            }
            dataGridViewNSX.DataSource = nsx.LoadDLNSX();

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExportToExcel p = new ExportToExcel();
            p.export2Excel(dataGridViewNSX, @"D:\", "NhaSanXuat");
        }
    }
}