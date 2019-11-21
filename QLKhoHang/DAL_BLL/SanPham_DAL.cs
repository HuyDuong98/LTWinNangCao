﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class SanPham_DAL
    {
        public string MaPhieuNhap() {
            string ma= "PN"+BienK();
            return ma;
        }
        public int BienK()
        {
            int k;
            Random ka = new Random();
            k = ka.Next(1, 10000);
            return k;
        }
       
        QLKhoDataContext sp = new QLKhoDataContext();
        public List<SAN_PHAM> Load_DL()
        {
            return sp.SAN_PHAMs.Select(t => t).ToList<SAN_PHAM>();
        }
        public List<PHIEU_NHAP> LoadDLNhapKho()
        {
            var PhieuNhaps = (from pn in sp.PHIEU_NHAPs
                              join k in sp.SAN_PHAMs on pn.MAPN equals k.MAPN 
                              join q in sp.NHAN_VIENs on pn.MANV equals q.MANV
                              select new
                              {
                                  MaPhieuNhap = pn.MAPN,
                                  NgayNhap = pn.NGAYNHAP,
                                  NoiDung = pn.NOIDUNG,
                                  DVT = k.DVT,
                                  GiaBan = k.GIABANLE,
                                  TenSanPham = k.TEN_SAN_,
                                  MauSac = k.MAUSAC,
                                  NhanVien =q.TENNV,
                                  SL= pn.SL
                              });
            return sp.PHIEU_NHAPs.Select(t => t).ToList<PHIEU_NHAP>();
            //return sp.PHIEU_NHAPs.Select(t => t).ToList<PHIEU_NHAP>();
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
    }
}
