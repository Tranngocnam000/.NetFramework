using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectDB 
    {
        public static SqlConnection con = new SqlConnection("server=DESKTOP-6J9EMM1\\SQLEXPRESS; uid=sa; pwd=123; database=QlXe");
    }
}
