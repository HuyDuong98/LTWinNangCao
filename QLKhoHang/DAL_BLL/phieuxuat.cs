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
                      join p in qlkho.PHIEU_XUATs on px.MAPX equals p.MAPX
                      join t in qlkho.KHOHANGs on p.MAKHO equals t.MAKHO
                      select new
                      {
                           MAKHO = t.MAKHO,
                           MAPX = px.MAPX,
                           MASP = px.SAN_PHAM.MASP,
                           TEN_SP= px.SAN_PHAM.TEN_SP,
                           MAUSAC = px.SAN_PHAM.MAUSAC,
                           DVT = px.SAN_PHAM.DVT,
                           ThanhTien = px.ThanhTien,
                           SoLuong = px.SoLuong,
                           GIABANLE = px.SAN_PHAM.GIABANLE
                      });
            var kq = ds.ToList().ConvertAll(t => new DSHANGXUAT()
            {
                MAKHO = t.MAKHO,
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
                          TEN_SP = px.SAN_PHAM.TEN_SP
                      });
            var kq = ds.ToList().ConvertAll(t => new HANGTON()
            {
                MAKHO = t.MAKHO,
                MASP = t.MASP,
                TEN_SP =t.TEN_SP
            });
            return kq.Where(t=>t.MAKHO == makho).ToList<HANGTON>();
        }
        public bool ThemSPvaoDSHangXuat(DSHANGXUAT ds)
        {
            try
            {
                ds.ThanhTien = pn.ThanhTien(1, ds.MASP);
                qlkho.DSHANGXUATs.InsertOnSubmit(ds);
                qlkho.SubmitChanges();
                return true;
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
                var k = qlkho.DSHANGXUATs.Where(t => t.MAPX == ds.MAPX).Where(t => t.MASP == ds.MASP).FirstOrDefault();
                ds.SoLuong =k.SoLuong + 1;
                int n = (int)ds.SoLuong;
                string ma = ds.MASP.ToString();
                ds.ThanhTien = pn.ThanhTien(n, ma);
                qlkho.DSHANGXUATs.DeleteOnSubmit(k);
                qlkho.DSHANGXUATs.InsertOnSubmit(ds);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public int SLHangTonKho (string makho, string masp)
        {
            var p = qlkho.HANGTONs.Where(t => t.MAKHO == makho).Where(t => t.MASP == masp).FirstOrDefault();
            return (int)p.SOLUONG;
        }

        public void XoaDSPhieuXuat(string mapx, int dem)
        {

            for (int i = 0; i <= dem; i++)
            {

                DSHANGXUAT p = qlkho.DSHANGXUATs.Where(t => t.MAPX == mapx).FirstOrDefault();
                if (p == null)
                {
                    return;
                }
                else
                {
                    qlkho.DSHANGXUATs.DeleteOnSubmit(p);
                    qlkho.SubmitChanges();
                }

            }

        }
        public bool XoaPhieuXuat(string mapx)
        {
            try
            {
                PHIEU_XUAT p = qlkho.PHIEU_XUATs.Where(t => t.MAPX == mapx).FirstOrDefault();
                qlkho.PHIEU_XUATs.DeleteOnSubmit(p);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public List<PHIEU_XUAT> LoadPhieuXuatTheoKho(string ma)
        {
            var ds = (from px in qlkho.PHIEU_XUATs
                      select new
                      {
                          MAPX = px.MAPX,
                          MANV = px.MANV,
                          TENNV = px.NHAN_VIEN.TENNV,
                          NGAYXUAT = px.NGAYXUAT,
                          MOTAPHIEUXUAT = px.MOTAPHIEUXUAT,
                          MAKHO = px.MAKHO
                      });
            var kq = ds.ToList().ConvertAll(t => new PHIEU_XUAT()
            {
                MAPX = t.MAPX,
                MANV = t.MANV,
                TENNV = t.TENNV,
                NGAYXUAT = t.NGAYXUAT,
                MOTAPHIEUXUAT = t.MOTAPHIEUXUAT,
                MAKHO = t.MAKHO

            });
            return kq.Where(t => t.MAKHO == ma).ToList<PHIEU_XUAT>();
        }
        public bool TruSPcoTrongKho(HANGTON ht)
        {
            try
            {
                var p = qlkho.HANGTONs.Where(t => t.MAKHO == ht.MAKHO).Where(i => i.MASP == ht.MASP).FirstOrDefault();
                ht.SOLUONG = p.SOLUONG - ht.SOLUONG;
                qlkho.HANGTONs.DeleteOnSubmit(p);
                qlkho.HANGTONs.InsertOnSubmit(ht);
                return true;
            }
            catch { return false; }
        }

    }
}
