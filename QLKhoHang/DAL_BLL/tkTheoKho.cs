using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class tkTheoKho
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();
        PhieuNhap pn = new PhieuNhap();
        public List<TKKHO_VIEW> LoadDTTheoKho(string makho)
        {
            var p = (from tk in qlkho.TKKHO_VIEWs
                    select new
                    {
                        TEN_SP = tk.TEN_SP,
                        DVT  = tk.DVT,
                        SLNHAP = tk.SLNHAP,
                        SLXUAT = tk.SLXUAT,
                        SLTON = tk.SLTON,
                        MAKHO = tk.MAKHO,
                        GIANHAP = tk.GIANHAP,
                        GIABANLE = tk.GIABANLE,
                        GIABANSI = tk.GIABANSI,
                        TONGGIANHAP = tk.GIANHAP*tk.SLNHAP,
                        TONGGIAXUAT = tk.GIABANLE*tk.SLXUAT,
                        TONGGIATON = tk.GIANHAP*tk.SLTON
                    });
            var kq = p.ToList().ConvertAll(t => new TKKHO_VIEW()
            {
                TEN_SP = t.TEN_SP,
                DVT = t.DVT,
                SLNHAP = t.SLNHAP,
                SLXUAT = t.SLXUAT,
                SLTON = t.SLTON,
                MAKHO = t.MAKHO,
                GIANHAP = t.GIANHAP,
                GIABANLE = t.GIABANLE,
                GIABANSI = t.GIABANSI,
                TONGGIANHAP = (float)t.TONGGIANHAP,
                TONGGIAXUAT = (float)t.TONGGIAXUAT,
                TONGGIATON = (float)t.TONGGIATON
            });
            return kq.Where(t => t.MAKHO == makho).ToList<TKKHO_VIEW>();
            //return qlkho.TKKHO_VIEWs.Where(t=>t.MAKHO == makho).ToList<TKKHO_VIEW>();
        }
    }
}
