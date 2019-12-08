using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class Kho
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();
        SanPham_DAL sp = new SanPham_DAL();
        public string MaKho()
        {
            int k = sp.BienK();
            string ma = "KHO" + k;
            var p = qlkho.KHOHANGs.Where(t=>t.MAKHO == ma).FirstOrDefault();
            if (p == null)
            {
                return ma;
            }
            else return MaKho();
        }
        public bool ThemKho(KHOHANG kho)
        {
            try
            {
                qlkho.KHOHANGs.InsertOnSubmit(kho);
                qlkho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<KHOHANG> LoadKho()
        {
            return qlkho.KHOHANGs.Select(t => t).ToList<KHOHANG>();
        }
        public bool XoaKho(string ma)
        {
            try
            {
                KHOHANG p = qlkho.KHOHANGs.Where(t => t.MAKHO == ma).FirstOrDefault();
                qlkho.KHOHANGs.DeleteOnSubmit(p);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

    }
}
