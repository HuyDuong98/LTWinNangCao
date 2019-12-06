using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
   
    public class DoiMatKhau
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();
        public bool ThayDoiMK(QL_NGUOIDUNG p)
        {
            try
            {
                QL_NGUOIDUNG kh = qlkho.QL_NGUOIDUNGs.Where(t => t.TENDANGNHAP == p.TENDANGNHAP).FirstOrDefault();
                qlkho.QL_NGUOIDUNGs.DeleteOnSubmit(kh);
                qlkho.QL_NGUOIDUNGs.InsertOnSubmit(p);
                qlkho.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
