using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_LOAIXE:ConnectDB
    {
        public DataTable getLoai()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Loai", con);
            DataTable loai = new DataTable();
            da.Fill(loai);
            loai.Columns.Add("Ord");
            for (int i = 1; i <= loai.Rows.Count; i++)
                loai.Rows[i - 1]["Ord"] = i.ToString();
            return loai;
        }

        public bool ThemLoai(string name)
        {
            string sql = string.Format("insert into Loai(TenLoai) values('{0}')", name);
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

        public bool SuaLoai(int id, string name)
        {
            string sql = string.Format("update Loai set TenLoai = '{0}' where MaLoai = '{1}'", name, id);
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

        public bool XoaLoai(int id)
        {
            string sql = string.Format("delete Loai where MaLoai ='{0}'", id);
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
        public DataTable TimLoai(string ten)
        {
            string str = string.Format(" SELECT * FROM Loai WHERE TenLoai like '%{0}%'", ten);
            SqlDataAdapter loai = new SqlDataAdapter(str, con);
            DataTable dtblXe = new DataTable();
            loai.Fill(dtblXe);
            dtblXe.Columns.Add("Ord");
            for (int i = 1; i <= dtblXe.Rows.Count; i++)
                dtblXe.Rows[i - 1]["Ord"] = i.ToString();
            return dtblXe;
        }
    }
}
