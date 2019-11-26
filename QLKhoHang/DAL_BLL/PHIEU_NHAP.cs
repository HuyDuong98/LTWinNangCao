using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public partial class PHIEU_NHAP
    {
        QLKhoDataContext qlkho = new QLKhoDataContext();
        string DVT;

        public string DVT1
        {
            get { return DVT; }
            set { DVT = value; }
        }
        string GIABANLE;

        public string GIABANLE1
        {
            get { return GIABANLE; }
            set { GIABANLE = value; }
        }
        string TEN_SAN_;

        public string TEN_SAN_1
        {
            get { return TEN_SAN_; }
            set { TEN_SAN_ = value; }
        }
        string MAUSAC;

        public string MAUSAC1
        {
            get { return MAUSAC; }
            set { MAUSAC = value; }
        }
        string TENNV;

        public string TENNV1
        {
            get { return TENNV; }
            set { TENNV = value; }
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

    }
}
