using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhoHang
{
    class connect
    {
        public static int Check_Config()
        {
            if (Properties.Settings.Default.Conn == string.Empty)
                return 1;
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.Conn);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;
            }
            catch
            { return 2; }
        }
        public enum LoginResult
        {
            Invalid,
            Disabled,
            Success
        }
        
        

        public static LoginResult Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung Where TenDangNhap ='" + pUser + "'and MatKhau = '" + pPass + "'", Properties.Settings.Default.Conn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return LoginResult.Invalid;
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return LoginResult.Disabled;
            }
            return LoginResult.Success;
        }


        public static DataTable GetSeverName()
        {
            List<string> ls = new List<string>();
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i].ItemArray[0].ToString();
                ls.Add(ten);
            }

            return dt;
        }

        public static DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + pServer + ";Initial Catalog=master; Integrated Security=True");
            da.Fill(dt);
            return dt;
        }
        public static void SaveConfig(string pSever, string pUser, string pPass, string pDBname)
        {
            Properties.Settings.Default.Conn = "Data Sourece" + pSever + ";Initial Catalog=" + pDBname + ";Integrated Security=True";
            Properties.Settings.Default.Save();
        }
    }
}
