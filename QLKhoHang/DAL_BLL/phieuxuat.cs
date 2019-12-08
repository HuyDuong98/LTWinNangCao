using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class phieuxuat
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();
        PhieuNhap pn = new PhieuNhap();
        public bool ThemPhieuXuat(PHIEU_XUAT p)
        {
            try
            {
                qlkho.PHIEU_XUATs.InsertOnSubmit(p);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public List<DSHANGXUAT> LoadDSHangXuat(string ma)
        {
            var ds = (from px in qlkho.DSHANGXUATs
                      select new
                      {
                           MAPX = px.MAPX,
                           MASP = px.MASP,
                           TEN_SP= px.SAN_PHAM.TEN_SP,
                           MAUSAC = px.SAN_PHAM.MAUSAC,
                           DVT = px.SAN_PHAM.DVT,
                           ThanhTien = px.ThanhTien,
                           SoLuong = px.SoLuong,
                           GIABANLE = px.SAN_PHAM.GIABANLE
                      });
            var kq = ds.ToList().ConvertAll(t => new DSHANGXUAT()
            {
                MAPX = t.MAPX,
                MASP = t.MASP,
                TEN_SP = t.TEN_SP,
                MAUSAC = t.MAUSAC,
                DVT = t.DVT,
                ThanhTien = t.ThanhTien,
                SoLuong = t.SoLuong,
                GIABANLE = (float)t.GIABANLE
            });
            return kq.Where(t => t.MAPX == ma).ToList<DSHANGXUAT>();
        }
        public bool KTTonTaiSPTrongPhieuXuat(string mapx, string masp)
        {
            var a = qlkho.DSHANGXUATs.Where(t => t.MAPX == mapx).Where(t=>t.MASP == masp).FirstOrDefault();
            if (a == null)
            {
                return true;
            }
            else return false;
        }
        public List<HANGTON> LoadcboSpKho(string makho)
        {
            var ds = (from px in qlkho.HANGTONs
                      select new
                      {
                          MAKHO = px.MAKHO,
                          MASP = px.MASP,
                          TEN_SP = px.SAN_PHAM.TEN_SP,
                      });
            var kq = ds.ToList().ConvertAll(t => new HANGTON()
            { 
                MAKHO = t.MAKHO,
                MASP = t.MASP,
                TEN_SP = t.TEN_SP,
            });
            return kq.Where(t=>t.MAKHO == makho).ToList<HANGTON>();
        }
        public bool ThemSPvaoDSHangXuat(DSHANGXUAT ds)
        {
            try
            {
                HANGTON p = qlkho.HANGTONs.Where(t => t.MASP == ds.MASP).FirstOrDefault();
                if (p.SOLUONG > 0)
                {
                    ds.ThanhTien = pn.ThanhTien(1, ds.MASP);
                    qlkho.DSHANGXUATs.InsertOnSubmit(ds);
                    qlkho.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool SuaTTDSPhieuXuat(DSHANGXUAT ds)
        {
            try
            {

                DSHANGXUAT k = qlkho.DSHANGXUATs.Where(t => t.MAPX == ds.MAPX).Where(t => t.MASP == ds.MASP).FirstOrDefault();
                ds.SoLuong = k.SoLuong + 1;
                int n = (int)ds.SoLuong;
                string ma = ds.MASP.ToString();
                ds.ThanhTien = pn.ThanhTien(n, ma);
                k.SoLuong = ds.SoLuong;
                k.ThanhTien = ds.ThanhTien;
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

    }
}
