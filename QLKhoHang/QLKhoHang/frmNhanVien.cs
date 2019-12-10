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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVien nv = new NhanVien();
        DangNhap_DAL dn = new DangNhap_DAL();
        public frmNhanVien()
        {
            InitializeComponent();
        }


        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            if (dn.MaNhomPer(DangNhap_DAL.UserName))
            {
                pnControl.Enabled = true;
            }
            else
            {
                pnControl.Enabled = false;
            }
            dataGridViewNV.DataSource = nv.LoadDLNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelNhanVien.Enabled = true;
            btnLuu.Enabled = true;
            txtMaNV.Text = nv.MaNhanVien();
            txtTenNV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text.Trim() == string.Empty)
            {
                txtTenNV.Focus();
                MessageBox.Show("Bạn chưa nhập tên nhân viên");
                return;
            }
            NHAN_VIEN p = new NHAN_VIEN();
            p.MANV = txtMaNV.Text.Trim();
            p.TENNV = txtTenNV.Text;
            p.DIACHINV = txtDiaChi.Text;
            if (radioButtonNam.Checked == true)
                p.GIOITINH = "Nam";
            else p.GIOITINH = "Nữ";
            p.SDTNV = txtSDT.Text;
            if (nv.ThemNhanVien(p))
            {
                dataGridViewNV.DataSource = nv.LoadDLNhanVien();
                panelNhanVien.Enabled = false;
                btnLuu.Enabled = false;
                txtTenNV.Text = string.Empty;
                txtSDT.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                MessageBox.Show("Thêm thành công");
            }
            else {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void LoadSTTDataGirdView()
        {
            for (int i = 0; i < dataGridViewNV.Rows.Count; i++)
            {
                dataGridViewNV.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
        private void dataGridViewNV_DataSourceChanged(object sender, EventArgs e)
        {
           // LoadSTTDataGirdView();
        }

        private void dataGridViewNV_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int index = dataGridViewNV.CurrentCell.RowIndex;
                string ma = dataGridViewNV.Rows[index].Cells[0].Value.ToString().Trim();
                nv.XoaNhanVien(ma);
                dataGridViewNV.DataSource = nv.LoadDLNhanVien();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NHAN_VIEN p = new NHAN_VIEN();
            int index = dataGridViewNV.CurrentCell.RowIndex;
            if (nv.SuaTTNhanVien(p))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại");
            }
            dataGridViewNV.DataSource = nv.LoadDLNhanVien();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExportToExcel p = new ExportToExcel();
            p.export2Excel(dataGridViewNV, @"D:\", "NhanVien");
        }





    }
}