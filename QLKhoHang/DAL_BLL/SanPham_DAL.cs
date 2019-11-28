using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class SanPham_DAL
    {
        public string MaPhieuNhap() {
            string ma= "PN"+LayChuoiNgayHT()+BienK();
            return ma;
        }
        public string MaLoaiSP()
        {
            int k = BienK();
            string ma = "LSP" +k;
            var p = sp.LOAI_SAN_PHAMs.Where(t => t.MALOAI == ma).FirstOrDefault();
            if (p == null)
            {
                return ma;
            }
            else
            {
                return MaLoaiSP();
            }
        }
        public string MaSP()
        {
            int k = BienK();
            string ma = "SP" + LayChuoiNgayHT() + BienK();
            var p = sp.SAN_PHAMs.Where(t => t.MASP == ma).FirstOrDefault();
            if (p == null)
            {
                return ma;
            }
            else
            {
                return MaSP();
            }
        }
        public int BienK()
        {
            int k;
            Random ka = new Random();
            k = ka.Next(1, 1000);
            return k;
        }
        public string LayChuoiNgayHT()
        {
            int day = DateTime.Today.Day;
            int month = DateTime.Today.Month;
            int year = DateTime.Today.Year;
            string ht = ""+day+month;
            return ht;
        }
       
        QLKhoDataContext sp = new QLKhoDataContext();
        public List<SAN_PHAM> Load_DL()
        {
            return sp.SAN_PHAMs.Select(t => t).ToList<SAN_PHAM>();
        }
        public List<PHIEU_NHAP> LoadDLNhapKho()
        {
            //var PhieuNhaps = (from pn in sp.PHIEU_NHAPs
            //                  join q in sp.NHAN_VIENs on pn.MANV equals q.MANV
            //                  select new
            //                  {
            //                      MaPhieuNhap = pn.MAPN,
            //                      NgayNhap = pn.NGAYNHAP,
            //                      NoiDung = pn.NOIDUNG,
            //                      NhanVien = q.TENNV,
            //                  });
            return sp.PHIEU_NHAPs.Select(t => t).ToList<PHIEU_NHAP>();
        }
        public List<SAN_PHAM> LoadcboSanPham()
        {
            var cb = from a in sp.SAN_PHAMs select a;
            return cb.ToList<SAN_PHAM>();
            
        }
        public List<NHAN_VIEN> LoadcboNhanVien()
        {
            var cb = from a in sp.NHAN_VIENs select a;
            return cb.ToList<NHAN_VIEN>();
        }
        public string LayGiaBanSP(string ma)
        {
            var g =( from a in sp.SAN_PHAMs where a.MASP == ma select a.GIABANLE).FirstOrDefault();
            string gia = g.ToString();
            return gia;
        }
        public string KiemTraTrung() {
            string a = MaPhieuNhap();
            PHIEU_NHAP pn = sp.PHIEU_NHAPs.Where(t => t.MAPN == a).FirstOrDefault();
            if (pn == null)
            {
                return a;
            }
            else
            {
                return KiemTraTrung();
            }

        }

        public bool KTKhoaPhieuNhap(string mapn)
        {
            PHIEU_NHAP pn = sp.PHIEU_NHAPs.Where(t => t.MAPN == mapn).FirstOrDefault();
            if (pn == null)
            {
                return true;
            }
            else { return false; }
        }

        public bool ThemPhieuNhap(PHIEU_NHAP pn)
        {
            try
            {
                sp.PHIEU_NHAPs.InsertOnSubmit(pn);
                sp.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public List<LOAI_SAN_PHAM> LoadCboLoaiSP()
        {
            var loai = from a in sp.LOAI_SAN_PHAMs select a;
            return loai.ToList<LOAI_SAN_PHAM>();
        }
        public List<NHA_CUNG_CAP> LoadCboNCC()
        {
            var ncc = from a in sp.NHA_CUNG_CAPs select a;
            return ncc.ToList<NHA_CUNG_CAP>();
        }
        public List<NHA_SAN_XUAT> LoadCboNSX()
        {
            var nsx = from a in sp.NHA_SAN_XUATs select a;
            return nsx.ToList<NHA_SAN_XUAT>();
        }
        public bool ThemLoaiSP(LOAI_SAN_PHAM loai)
        {
            try
            {
                sp.LOAI_SAN_PHAMs.InsertOnSubmit(loai);
                sp.SubmitChanges();
                return true;
            }
            catch {
                return false;
            }
        }
        public List<LOAI_SAN_PHAM> LoadDLLoaiSP()
        {
            return sp.LOAI_SAN_PHAMs.Select(t => t).ToList<LOAI_SAN_PHAM>();
        }
        public bool KTKhoaLoaiSP(string ma)
        {
            LOAI_SAN_PHAM loai = sp.LOAI_SAN_PHAMs.Where(t => t.MALOAI == ma).FirstOrDefault();
            if (loai == null)
            {
                return true;
            }
            else { return false; }
        }
        public bool KTMaSP(string ma)
        {
            SAN_PHAM sanpham = sp.SAN_PHAMs.Where(t => t.MASP == ma).FirstOrDefault();
            if (sanpham == null)
            {
                return true;
            }
            else { return false; }
        }

        public bool XoaLoaiSP(string ma)
        {
            try
            {
                LOAI_SAN_PHAM p = sp.LOAI_SAN_PHAMs.Where(t => t.MALOAI == ma).FirstOrDefault();
                sp.LOAI_SAN_PHAMs.DeleteOnSubmit(p);
                sp.SubmitChanges();
                return true;
            }
            catch { return false; }
        }


        public bool ThemSanPham(SAN_PHAM a)
        {
            try
            {
                sp.SAN_PHAMs.InsertOnSubmit(a);
                sp.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool XoaSanPham(string ma)
        {
            try
            {
                SAN_PHAM p = sp.SAN_PHAMs.Where(t => t.MASP == ma).FirstOrDefault();
                sp.SAN_PHAMs.DeleteOnSubmit(p);
                sp.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool SuaTTSanPham(SAN_PHAM p)
        {
            try
            {
                SAN_PHAM k = sp.SAN_PHAMs.Where(t => t.MASP == p.MASP).FirstOrDefault();
                k = p;
                sp.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool SuaTTLoaiSanPham(LOAI_SAN_PHAM p)
        {
            try
            {
                LOAI_SAN_PHAM k = sp.LOAI_SAN_PHAMs.Where(t => t.MALOAI == p.MALOAI).FirstOrDefault();
                k = p;
                sp.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public List<SAN_PHAM> AddSanPham(string ma,List<SAN_PHAM> q)
        {
            return sp.SAN_PHAMs.Where(t => t.MASP == ma).ToList<SAN_PHAM>();
            
        }
    }
}
