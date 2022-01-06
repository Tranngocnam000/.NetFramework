using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_GIAODICH:ConnectDB
    {
        
        public DataTable getgd()
        {
            SqlDataAdapter da = new SqlDataAdapter("select gd.MaGD, kh.TenKhachHang, x.TenXe, gd.NgayBatDauThue,gd.NgayTra, DATEDIFF ( DAY , gd.NgayBatDauThue , gd.NgayTra )-1 as SoNgayThue, (x.GiaThue*(DATEDIFF ( DAY , gd.NgayBatDauThue , gd.NgayTra )-1)) as TongTien from KhachHang as kh join GiaoDich as gd on kh.MaKhachHang = gd.MaKhachHang join Xe as x on x.MaXe = gd.MaXe", con);
            DataTable gd = new DataTable();
            da.Fill(gd);
            gd.Columns.Add("Ord");
            for (int i = 1; i <= gd.Rows.Count; i++)
                gd.Rows[i - 1]["Ord"] = i.ToString();
            return gd;
        }
        public bool Themgd(int makh, int maxe, DateTime ngaybatdau, DateTime ngaytra)
        {
            try 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into GiaoDich values(@makh, @maxe, @ngaytao, @ngaytra)", con);
                cmd.Parameters.Add("@makh", makh);
                cmd.Parameters.Add("@maxe", maxe);
                cmd.Parameters.Add("@ngaytao", ngaybatdau);
                cmd.Parameters.Add("@ngaytra", ngaytra);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }

            con.Close();
            return true;
        }
        public bool Xoagd(int id)
        {
            string sql = string.Format("delete GiaoDich where MaGD={0}",id);
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
        public bool Suagd(int id, int makh, int maxe, DateTime ngaytao, DateTime ngaytra)
        {
            string sql = string.Format("update GiaoDich set MaKhachHang = '{0}' ,MaXe = '{1}', NgayBatDauThue = '{2}', NgayTra = '{3}' where MaGD = '{4}'", makh, maxe, ngaytao, ngaytra, id);
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
        public DataTable Timgd(string tenkh)
        {
            string str = string.Format("select gd.MaGD, kh.TenKhachHang, x.TenXe, gd.NgayBatDauThue,gd.NgayTra, DATEDIFF ( DAY , gd.NgayBatDauThue , gd.NgayTra )-1 as SoNgayThue, (x.GiaThue*(DATEDIFF ( DAY , gd.NgayBatDauThue , gd.NgayTra )-1)) as TongTien from KhachHang as kh join GiaoDich as gd on kh.MaKhachHang = gd.MaKhachHang join Xe as x on x.MaXe = gd.MaXe where TenKhachHang like '%{0}'", tenkh);
            SqlDataAdapter gd = new SqlDataAdapter(str, con);
            DataTable dtbgd = new DataTable();
            gd.Fill(dtbgd);
            dtbgd.Columns.Add("Ord");
            for (int i = 1; i <= dtbgd.Rows.Count; i++)
                dtbgd.Rows[i - 1]["Ord"] = i.ToString();
            return dtbgd;
        }
    }
}
