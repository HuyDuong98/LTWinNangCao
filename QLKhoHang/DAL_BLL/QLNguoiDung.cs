using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class QLNguoiDung
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();
        public List<QL_NGUOIDUNG> LoadDTNguoiDung()
        {
            var ds = (from pn in qlkho.QL_NGUOIDUNGs
                      join q in qlkho.QL_PHANQUYENs on pn.TENDANGNHAP equals q.TENDANGNHAP
                      join p in qlkho.QL_NHOMNGUOIDUNGs on q.MANHOM equals p.MANHOM
                      select new
                      {
                          TENDANGNHAP = pn.TENDANGNHAP,
                          MATKHAU = pn.MATKHAU,
                          TENNHOM = q.QL_NHOMNGUOIDUNG.TENNHOM
                      });
            var kq = ds.ToList().ConvertAll(t => new QL_NGUOIDUNG()
            {
                TENDANGNHAP = t.TENDANGNHAP,
                MATKHAU = t.MATKHAU,
                TENNHOM = t.TENNHOM
            });
            return kq.ToList<QL_NGUOIDUNG>();
        }
        public bool ThemNguoiDung(QL_NGUOIDUNG user)
        {
            try
            {
                qlkho.QL_NGUOIDUNGs.InsertOnSubmit(user);
                qlkho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool PhanQuyenUser(QL_PHANQUYEN pq)
        {
            try
            {
                qlkho.QL_PHANQUYENs.InsertOnSubmit(pq);
                qlkho.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaPhanQuyenUser(string ma)
        {
            try
            {
                QL_PHANQUYEN p = qlkho.QL_PHANQUYENs.Where(t => t.TENDANGNHAP == ma).FirstOrDefault();
                qlkho.QL_PHANQUYENs.DeleteOnSubmit(p);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool XoaNguoiDung(string ma)
        {
            try
            {
                QL_NGUOIDUNG p = qlkho.QL_NGUOIDUNGs.Where(t => t.TENDANGNHAP == ma).FirstOrDefault();
                qlkho.QL_NGUOIDUNGs.DeleteOnSubmit(p);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
