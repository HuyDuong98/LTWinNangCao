using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class SanPham_DAL
    {

        QLKhoDataContext sp = new QLKhoDataContext();
        public List<SAN_PHAM> Load_DL()
        {
            return sp.SAN_PHAMs.Select(t => t).ToList<SAN_PHAM>();
        }
        public List<PHIEU_NHAP> LoadDLNhapKho()
        {
            var PhieuNhaps = (from pn in sp.PHIEU_NHAPs
                              join k in sp.SAN_PHAMs on pn.MAPN equals k.MAPN
                              select new
                              {
                                  MaPhieuNhap = pn.MAPN,
                                  NgayNhap =pn.NGAYNHAP,
                                  NoiDung = pn.NOIDUNG,
                                  DVT = k.DVT,
                                  GiaBan = k.GIABANLE
                              });
            return sp.PHIEU_NHAPs.Select(t => t).ToList<PHIEU_NHAP>();
        }

    }
}
