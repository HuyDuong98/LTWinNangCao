using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class SanPham_DAL
    {
        
        SanPhamDataContext sp = new SanPhamDataContext();
        public List<SAN_PHAM> Load_DL()
        {
            return sp.SAN_PHAMs.Select(t => t).ToList<SAN_PHAM>();
        }
    }
}
