using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class PhieuNhap
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();

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
    }
}
