using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_DANGNHAP: ConnectDB
    {
        public string getID(string username, string pass)
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Admin WHERE username ='" + username + "' and password='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                return "Error";
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public string getPass(string pass)
        {
            string Pass = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Admin WHERE password='" + pass + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Pass = dr["password"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                return "Error";
            }
            finally
            {
                con.Close();
            }
            return Pass;
        }
        public bool CheckUser(string name)
        {
            string sql = string.Format("SELECT Admin.username from Admin where username = N'{0}'", name);
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
