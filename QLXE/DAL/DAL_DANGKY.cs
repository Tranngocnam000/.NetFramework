using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_DANGKY: ConnectDB
    {
        public bool DangKy(string ten, string mk)
        {
            string sql = string.Format("insert into Admin(username, password) values" +
                "('{0}','{1}')", ten, mk);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }

            con.Close();
            return true;
        }
    }
}
