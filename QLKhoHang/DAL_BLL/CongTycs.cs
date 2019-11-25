using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class CongTycs
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();
        public List<CONG_TY> LoadDL()
        {
            return qlkho.CONG_Ties.Select(t => t).ToList<CONG_TY>();
        }

    }
}
