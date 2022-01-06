using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_KHACHHANG
    {
        DAL_KHACHHANG kh = new DAL_KHACHHANG();
        public DataTable getkhachhang()
        {
            return kh.getkhachhang();
        }
        public bool ThemKhachHang(string ten, string diachi, string sdt, string socmnd, string blx)
        {
            return kh.ThemKhachHang( ten, diachi, sdt, socmnd, blx);
        }
        public bool XoaKhachHang(int id)
        {
            return kh.XoaKhachHang(id);
        }
        public bool SuaKhachHang(int id, string ten, string diachi, string sdt, string socmnd, string blx)
        {
            return kh.SuaKhachHang(id, ten, diachi, sdt, socmnd, blx);
        }
        public DataTable TimKhachHang(string ten)
        {
            return kh.TimKhachHang(ten);
        }
        public int getid(string tenkh)
        {
            return kh.getid(tenkh);
        }
    }
}
