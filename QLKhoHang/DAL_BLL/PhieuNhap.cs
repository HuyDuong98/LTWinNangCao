﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class PhieuNhap
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();

        public bool ThemPhieuNhap(PHIEU_NHAP pn)
        {
            try
            {
                qlkho.PHIEU_NHAPs.InsertOnSubmit(pn);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool ThemDSHangNhapKho(DSHANGNHAP ds)
        {
            try
            {
                qlkho.DSHANGNHAPs.InsertOnSubmit(ds);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public float ThanhTien(int sl, string ma)
        {
            SAN_PHAM a = qlkho.SAN_PHAMs.Where(t => t.MASP == ma).FirstOrDefault();
            //var dg = from a in qlkho.SAN_PHAMs where a.MASP == ma select a.GIANHAP;
            float tt =  float.Parse(a.GIANHAP.ToString())*sl;
            return tt;
        }
        public List<DSHANGNHAP> LoadDSHangNhap(string ma)
        {
            var ds = (from pn in qlkho.PHIEU_NHAPs
                      join q in qlkho.DSHANGNHAPs on pn.MAPN equals q.MAPN
                      select new
                      {
                          MAPN = q.MAPN,
                          MASP = q.MASP,
                          TEN_SP = q.SAN_PHAM.TEN_SP,
                          MAUSAC = q.SAN_PHAM.MAUSAC,
                          DVT = q.SAN_PHAM.DVT,
                          GIANHAP = q.SAN_PHAM.GIANHAP,
                          SL = q.SL,
                          ThanhTien = q.ThanhTien,
                          MOTASP = q.SAN_PHAM.MOTASP
                      });
            var kq = ds.ToList().ConvertAll(t => new DSHANGNHAP()
            {
                MAPN = t.MAPN,
                MASP = t.MASP,
                TEN_SP = t.TEN_SP,
                MAUSAC = t.MAUSAC,
                DVT = t.DVT,
                GIANHAP = (float)t.GIANHAP,
                SL = t.SL,
                ThanhTien = t.ThanhTien,
                MOTASP = t.MOTASP
            });
            return kq.Where(t=>t.MAPN == ma).ToList<DSHANGNHAP>();
        }
        public bool KTTonTaiSPTrongPhieuNhap(string mapn, string masp )
        {
            var a = qlkho.DSHANGNHAPs.Where(t => t.MAPN == mapn).ToList<DSHANGNHAP>();
            var b = a.Where(t => t.MASP == masp).FirstOrDefault();
            if (b == null)
            {
                return true;
            }
            else return false;
        }
        public bool SuaTTPhieuNhap(PHIEU_NHAP p)
        {
            try
            {
                PHIEU_NHAP k = qlkho.PHIEU_NHAPs.Where(t => t.MAPN == p.MAPN).FirstOrDefault();
                k = p;
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool SuaTTDSPhieuNhap(DSHANGNHAP ds)
        {
            try
            {

                DSHANGNHAP k = qlkho.DSHANGNHAPs.Where(t => t.MAPN == ds.MAPN).Where(t=>t.MASP== ds.MASP).FirstOrDefault();
                ds.SL = k.SL + 1;
                int n = (int)ds.SL;
                string ma = ds.MASP.ToString();
                ds.ThanhTien = ThanhTien(n,ma);
                qlkho.DSHANGNHAPs.DeleteOnSubmit(k);
                qlkho.DSHANGNHAPs.InsertOnSubmit(ds);
                qlkho.SubmitChanges();
                return true;
            }catch{return false;}
        }

    }
}
