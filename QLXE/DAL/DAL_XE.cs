using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_XE:ConnectDB
    {
        public DataTable getxe()
        {
            SqlDataAdapter da = new SqlDataAdapter("select x.MaXe, x.TenXe, l.TenLoai , x.BienSo, x.TinhTrang, x.GiaThue, x.SoGhe from Xe as x join Loai as l on x.MaLoai = l.MaLoai", con);
            DataTable xe = new DataTable();
            da.Fill(xe);
            xe.Columns.Add("Ord");
            for (int i = 1; i <= xe.Rows.Count; i++)
                xe.Rows[i - 1]["Ord"] = i.ToString();
            return xe;
        }
        public bool ThemXe(string tenxe, string bienso, string tinhtrang, int giathue, int loai, int soghe)
        {
            string sql = string.Format("insert into Xe(TenXe, BienSo, TinhTrang, GiaThue, MaLoai, SoGhe) values"+ "('{0}','{1}','{2}',{3},{4},{5})", tenxe, bienso, tinhtrang, giathue, loai, soghe);
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
        public bool XoaXe(int id)
        {
            string sql = string.Format("delete Xe where MaXe = '{0}'", id);
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
        public bool SuaXe(int id, string tenxe, string bienso, string tinhtrang, int giathue, int loai, int soghe)
        {
            string sql = string.Format("update Xe set TenXe = '{0}', BienSo='{1}', TinhTrang = '{2}', GiaThue={3}, MaLoai={4}, SoGhe={5} where MaXe = '{6}'", tenxe, bienso, tinhtrang, giathue, loai, soghe, id);
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
        public DataTable TimXe(string tenxe)
        {
            string str = string.Format(" select x.MaXe, x.TenXe, l.TenLoai , x.BienSo, x.TinhTrang, x.GiaThue, x.SoGhe from Xe as x join Loai as l on x.MaLoai = l.MaLoai WHERE TenXe like '%{0}%'", tenxe);
            SqlDataAdapter xe = new SqlDataAdapter(str, con);
            DataTable dtbXe = new DataTable();
            xe.Fill(dtbXe);
            dtbXe.Columns.Add("Ord");
            for (int i = 1; i <= dtbXe.Rows.Count; i++)
                dtbXe.Rows[i - 1]["Ord"] = i.ToString();
            return dtbXe;
        }
    }
}
