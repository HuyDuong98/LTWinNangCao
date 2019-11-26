using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class NhanVien
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();
        SanPham_DAL sp = new SanPham_DAL();
        public List<NHAN_VIEN> LoadDLNhanVien()
        {
            return qlkho.NHAN_VIENs.Select(t => t).ToList<NHAN_VIEN>();
            //LoadSTTDataGirdView();
        }
        public string MaNhanVien()
        {
            int k = sp.BienK();
            string ma = "NV" + k;
            var p = qlkho.NHAN_VIENs.Where(t => t.MANV == ma).FirstOrDefault();
            if (p == null)
            {
                return ma;
            }
            else return MaNhanVien();
        }
        public bool ThemNhanVien(NHAN_VIEN nv)
        {
            try
            {
                qlkho.NHAN_VIENs.InsertOnSubmit(nv);
                qlkho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaNhanVien(string ma)
        {
            try
            {
                NHAN_VIEN p = qlkho.NHAN_VIENs.Where(t => t.MANV == ma).FirstOrDefault();
                qlkho.NHAN_VIENs.DeleteOnSubmit(p);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool SuaTTNhanVien(NHAN_VIEN p)
        {
            try
            {
                NHAN_VIEN k = qlkho.NHAN_VIENs.Where(t => t.MANV == p.MANV).FirstOrDefault();
                k = p;
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
