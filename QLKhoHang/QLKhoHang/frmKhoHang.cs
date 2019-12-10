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
    public partial class frmKhoHang : DevExpress.XtraEditors.XtraForm
    {
        Kho kho = new Kho();
        public frmKhoHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaKho.Text = kho.MaKho();
            txtTenKho.Text = string.Empty;
            txtMoTa.Text = string.Empty;
            txtDiaChiKho.Text = string.Empty;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKho.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nhập tên kho");
                txtTenKho.Focus();
                return;
            }
            else
            {
                KHOHANG k = new KHOHANG();
                k.MAKHO = txtMaKho.Text.Trim();
                k.TENKHO = txtTenKho.Text;
                k.DIACHIKHO = txtDiaChiKho.Text;
                k.MOTA = txtMoTa.Text;
                if (kho.ThemKho(k))
                {
                    dataGridViewKho.DataSource = kho.LoadKho();
                    btnLuu.Enabled = false;
                    btnThem.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thêm Kho thất bại");
                }
            }
        }

        private void dataGridViewKho_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewKho.Rows.Count; i++)
            {
                dataGridViewKho.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void dataGridViewKho_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int index = dataGridViewKho.CurrentCell.RowIndex;
                string ma = dataGridViewKho.Rows[index].Cells["MAKHO"].Value.ToString().Trim();
                if (kho.XoaKho(ma))
                {
                    dataGridViewKho.DataSource = kho.LoadKho();
                    MessageBox.Show("Xóa thành công ");
                }
                else { MessageBox.Show("Kho không được xóa"); }
            }
            else
            {
                return;
            }
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
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
            dataGridViewKho.DataSource = kho.LoadKho();
        }

    }
}