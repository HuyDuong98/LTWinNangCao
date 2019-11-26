using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_BLL
{
    public class NhaCungCap
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();
        SanPham_DAL sp = new SanPham_DAL();
        public List<NHA_CUNG_CAP> LoadDLNCC()
        {
            return qlkho.NHA_CUNG_CAPs.Select(t => t).ToList<NHA_CUNG_CAP>();
        }
        public string MaNCC()
        {
            int k = sp.BienK();
            string ma = "NCC" + k;
            var p = qlkho.NHA_CUNG_CAPs.Where(t => t.MANCC == ma).FirstOrDefault();
            if (p == null)
            {
                return ma;
            }
            else
            {
                return MaNCC();
            }
        }

        public List<KHU_VUC> LoadMaKhuVuc()
        {
            return qlkho.KHU_VUCs.Select(t => t).ToList<KHU_VUC>();
        }

        public bool ThemNhaCungCap(NHA_CUNG_CAP ncc)
        {
            try 
            {
                qlkho.NHA_CUNG_CAPs.InsertOnSubmit(ncc);
                qlkho.SubmitChanges();
                return true;    
            }catch{return false;}
        }

        public bool XoaNhaCC(string ma)
        {
            try
            {
                NHA_CUNG_CAP p = qlkho.NHA_CUNG_CAPs.Where(t => t.MANCC == ma).FirstOrDefault();
                qlkho.NHA_CUNG_CAPs.DeleteOnSubmit(p);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool SuaTTNhaCungCap(NHA_CUNG_CAP p)
        {
            try
            {
                NHA_CUNG_CAP ncc = qlkho.NHA_CUNG_CAPs.Where(t => t.MANCC == p.MANCC).FirstOrDefault();
                ncc = p;
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
