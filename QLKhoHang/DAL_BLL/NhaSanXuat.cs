using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_BLL
{
    
    public class NhaSanXuat
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();
        SanPham_DAL sp = new SanPham_DAL();
        public List<NHA_SAN_XUAT> LoadDLNSX()
        {
            return qlkho.NHA_SAN_XUATs.Select(t => t).ToList<NHA_SAN_XUAT>();
        }
        public string MaNSX() {
            string ma = "NSX" + sp.BienK();
            return ma;
        }
        public bool KiemTraTrung(string ma)
        {
            
            NHA_SAN_XUAT nsx = qlkho.NHA_SAN_XUATs.Where(t => t.MANSX == ma).FirstOrDefault();
            if (nsx == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool ThemNSX(NHA_SAN_XUAT nsx)
        {
            try
            {
                qlkho.NHA_SAN_XUATs.InsertOnSubmit(nsx);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool XoaNhaSX(string ma)
        {
            try
            {
                NHA_SAN_XUAT p = qlkho.NHA_SAN_XUATs.Where(t => t.MANSX == ma).FirstOrDefault();
                qlkho.NHA_SAN_XUATs.DeleteOnSubmit(p);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
