using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class DangNhap_DAL
    {

        QLKhoDataContext qlkho = new QLKhoDataContext();
        public static string UserName = string.Empty;
        public bool MaNhomPer(string id_per)
        {
            
            var id = (from a in qlkho.QL_PHANQUYENs where a.TENDANGNHAP == id_per select a.MANHOM).First();
            string ma = id.ToString();    
            if (ma == "ad")
            {
                return true; // admin
            }
            else { return false; } // nhân viên
        }
    }
}
