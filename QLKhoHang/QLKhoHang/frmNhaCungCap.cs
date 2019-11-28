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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {

        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        NhaCungCap ncc = new NhaCungCap();
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridViewNCC.DataSource = ncc.LoadDLNCC();
            //LoadSTTDataGirdView();
         
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            panelNCC.Enabled = true;
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = string.Empty;
                }
            }
            txtMaNCC.Text = ncc.MaNCC();
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboKhuVuc.SelectedValue == null)
            {
                cboKhuVuc.Focus();
                MessageBox.Show("Bạn chưa chọn khu vực");
                return;
            }
            if (txtTenNCC.Text.Trim() == string.Empty)
            {
                txtTenNCC.Focus();
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp");
                return;
            }
            NHA_CUNG_CAP p = new NHA_CUNG_CAP();
            p.MANCC= txtMaNCC.Text.Trim();
            p.MAKV= cboKhuVuc.SelectedValue.ToString().Trim();
            p.TENNCC = txtTenNCC.Text;
            p.DIACHINCC = txtDiaChi.Text;
            p.NGUOILIENHE = txtNguoiLH.Text;
            p.SDTNCC = txtSDT.Text;
            p.EMAILNCC = txtEmail.Text;
            p.WEBSITENCC = txtWebsite.Text;
            p.MOTANCC = txtMota.Text;
            if (ncc.ThemNhaCungCap(p))
            {
                dataGridViewNCC.DataSource = ncc.LoadDLNCC();
                btnLuu.Enabled = false;
                panelNCC.Enabled = false;
                ResetControlValues(panelNCC);
                MessageBox.Show("Thêm thành công");
            }
            else { MessageBox.Show("Thêm thất bại"); }
        }

        private void cboKhuVuc_DropDown(object sender, EventArgs e)
        {
            cboKhuVuc.DataSource = ncc.LoadMaKhuVuc();
            cboKhuVuc.DisplayMember = "TENKV";
            cboKhuVuc.ValueMember = "MAKV";
        }
        public static void ResetControlValues(Control Parent)
        {

            foreach (Control mycontrols in Parent.Controls)
                if (mycontrols is TextBox)
                {

                    (mycontrols as TextBox).Text = string.Empty;

                }
                else if (mycontrols is TextEdit)
                {
                    (mycontrols as TextEdit).Text = string.Empty;
                }
                else if (mycontrols is DevExpress.XtraEditors.ComboBox)
                {

                    (mycontrols as DevExpress.XtraEditors.ComboBox).SelectedIndex = 0;

                }
        }

        private void dataGridViewNCC_DataSourceChanged(object sender, EventArgs e)
        {
            //LoadSTTDataGirdView();
        }
        public void LoadSTTDataGirdView()
        {
            for (int i = 0; i < dataGridViewNCC.Rows.Count; i++)
            {
                dataGridViewNCC.Rows[i].HeaderCell.Value = (i + 1).ToString();

            } 
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int index = dataGridViewNCC.CurrentCell.RowIndex;
                string ma = dataGridViewNCC.Rows[index].Cells[0].Value.ToString().Trim();
                ncc.XoaNhaCC(ma);
                dataGridViewNCC.DataSource = ncc.LoadDLNCC(); 
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }
        }

        private void dataGridViewNCC_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NHA_CUNG_CAP p = new NHA_CUNG_CAP();
            int index = dataGridViewNCC.CurrentCell.RowIndex;
            //if (kh.IsNumber(p.SDTKH))
            //{
            if (ncc.SuaTTNhaCungCap(p))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại");
            }
            dataGridViewNCC.DataSource = ncc.LoadDLNCC();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExportToExcel p = new ExportToExcel();
            p.export2Excel(dataGridViewNCC, @"D:\", "NhaCungCap");
        }
    }
}
