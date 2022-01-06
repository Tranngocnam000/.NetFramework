using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_KHACHHANG:ConnectDB
    {
        public DataTable getkhachhang()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang", con);
            DataTable kh = new DataTable();
            da.Fill(kh);
            kh.Columns.Add("Ord");
            for (int i = 1; i <= kh.Rows.Count; i++)
               kh.Rows[i - 1]["Ord"] = i.ToString();
            return kh;
        }
        public bool ThemKhachHang(string ten, string diachi, string sdt, string socmnd, string blx)
        {
            string sql = string.Format("insert into KhachHang(TenKhachHang, DiaChi, SoDienThoai, SoCMND, BangLaiXe) values" +
                "('{0}','{1}','{2}','{3}','{4}')", ten, diachi, sdt, socmnd, blx);
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
       public bool XoaKhachHang(int id)
        {
            string sql = string.Format("delete KhachHang where MaKhachHang = '{0}'", id);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            } catch
            {
                return false;
            }
            con.Close();
            return true;
        }
        public bool SuaKhachHang(int id, string ten, string diachi, string sdt, string socmnd, string blx)
        {
            string sql = string.Format("update KhachHang set TenKhachHang = '{0}', DiaChi='{1}', SoDienThoai = '{2}', SoCMND='{3}', BangLaiXe='{4}'where MaKhachHang = '{5}'", ten, diachi, sdt, socmnd, blx, id);
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
        public DataTable TimKhachHang(string ten)
        {
            string str = string.Format(" SELECT * FROM KhachHang WHERE TenKhachHang like '%{0}%'", ten);
            SqlDataAdapter kh = new SqlDataAdapter(str, con);
            DataTable dtbKH = new DataTable();
            kh.Fill(dtbKH);
            dtbKH.Columns.Add("Ord");
            for (int i = 1; i <= dtbKH.Rows.Count; i++)
                dtbKH.Rows[i - 1]["Ord"] = i.ToString();
            return dtbKH;
        }
        public int getid(string tenkh)
        {
            int id;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaKhachHang FROM KhachHang WHERE TenKhachHang ='" + tenkh + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = (int)dr["MaKhachHang"];
                        return id;
                    }

                }
            }
            catch (Exception)
            {
                //return "Error";
            }
            finally
            {
                con.Close();
            }
            return -1;
        }
    }
}
