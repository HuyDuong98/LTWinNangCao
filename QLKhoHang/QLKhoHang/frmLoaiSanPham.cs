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
    public partial class frmLoaiSanPham : DevExpress.XtraEditors.XtraForm
    {
        SanPham_DAL qlkho = new SanPham_DAL();
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            
            dataLoaiSP.DataSource = qlkho.LoadDLLoaiSP();   
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            pnNhapLoaiSP.Enabled = true;
            btnLuu.Enabled = true;
            txtLoaiSP.Focus();
            txtMaLoaiSP.Text = qlkho.MaLoaiSP();
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtLoaiSP.Text == "")
            {
                MessageBox.Show("bạn chưa nhập loại sản phẩm");
                txtLoaiSP.Focus();
                return;
            }
            LOAI_SAN_PHAM loai = new LOAI_SAN_PHAM();
            loai.MALOAI = txtMaLoaiSP.Text;
            loai.TENLOAI = txtLoaiSP.Text;
            loai.MOTALSP = txtMoTa.Text;

            if (qlkho.KTKhoaLoaiSP(txtMaLoaiSP.Text.Trim()))
            {
                if (qlkho.ThemLoaiSP(loai))
                {
                    dataLoaiSP.DataSource = qlkho.LoadDLLoaiSP();
                    pnNhapLoaiSP.Enabled = false;
                    btnLuu.Enabled = false;
                    txtLoaiSP.Text = string.Empty;
                    txtMoTa.Text = string.Empty;
                    MessageBox.Show("Thêm thành công");
                }
                else { MessageBox.Show("Thêm thất bại"); }
            }
            else
            {
                MessageBox.Show("Trùng mã sản phẩm");
                txtMaLoaiSP.Text = qlkho.MaLoaiSP();
            }
        }
            
        

        private void dataLoaiSP_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataLoaiSP.Rows.Count; i++)
            {
                dataLoaiSP.Rows[i].HeaderCell.Value = (i + 1).ToString();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int index = dataLoaiSP.CurrentCell.RowIndex;
                string ma = dataLoaiSP.Rows[index].Cells[0].Value.ToString().Trim();
                qlkho.XoaLoaiSP(ma);
                dataLoaiSP.DataSource = qlkho.LoadDLLoaiSP();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }
        }

        private void dataLoaiSP_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LOAI_SAN_PHAM p = new LOAI_SAN_PHAM();
            int index = dataLoaiSP.CurrentCell.RowIndex;
            //if (kh.IsNumber(p.SDTKH))
            //{
            if (qlkho.SuaTTLoaiSanPham(p))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại");
            }
            dataLoaiSP.DataSource = qlkho.LoadDLLoaiSP(); ;
        }

    }
}