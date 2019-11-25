using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class KhachHang
    {

        QLKhoDataContext qlkho = new QLKhoDataContext();
        SanPham_DAL sp = new SanPham_DAL();
        public List<KHACH_HANG> LoadDLKhachHang()
        {
            return qlkho.KHACH_HANGs.Select(t => t).ToList<KHACH_HANG>();
        }
        public string MaKhachHang()
        {
            int k = sp.BienK();
            string ma = "KH"+ k;
            var p = qlkho.KHACH_HANGs.Where(t => t.MAKH == ma).FirstOrDefault();
            if (p == null)
            {
                return ma;
            }
            else
            {
                return MaKhachHang();
            }
        }
        public bool ThemKhachHang(KHACH_HANG kh)
        {
            try
            {
                qlkho.KHACH_HANGs.InsertOnSubmit(kh);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool XoaKhachHang(string ma)
        {
            try
            {
                KHACH_HANG p = qlkho.KHACH_HANGs.Where(t => t.MAKH == ma).FirstOrDefault();
                qlkho.KHACH_HANGs.DeleteOnSubmit(p);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
