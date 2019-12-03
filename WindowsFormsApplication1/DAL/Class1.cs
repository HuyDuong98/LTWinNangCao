using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Class1
    {
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public List<CHITIETHD> load()
        {
            return dt.CHITIETHDs.Select(t => t).ToList<CHITIETHD>();
        }
        public bool delete(string ma)
        {
            var p = dt.CHITIETHDs.Where(t => t.MAHD = ma).FirstOrDefault();

        }
    }
}
