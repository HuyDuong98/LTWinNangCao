using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public partial class DSHANGNHAP
    {
        string _TEN_SP;
        public string TEN_SP
        {
            get { return _TEN_SP; }
            set { _TEN_SP = value; }
        }
        string _MAUSAC;
        public string MAUSAC
        {
            get { return _MAUSAC; }
            set { _MAUSAC = value; }
        }
        string _DVT;
        public string DVT
        {
            get { return _DVT; }
            set { _DVT = value; }
        }
        float _GIANHAP;
        public float GIANHAP
        {
            get { return _GIANHAP; }
            set { _GIANHAP = value; }
        }
        string _MOTASP;
        public string MOTASP
        {
            get { return _MOTASP; }
            set { _MOTASP = value; }
        }
        
    }
}
