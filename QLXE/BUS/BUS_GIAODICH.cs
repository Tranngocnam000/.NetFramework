using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{ 
    public class BUS_GIAODICH
    {
        DAL_GIAODICH gd = new DAL_GIAODICH();
        public DataTable getgd()
        {
            return gd.getgd();
        }
        public bool Themgd(int makh, int maxe, DateTime ngaybatdau, DateTime ngaytra)
        {
            return gd.Themgd(makh, maxe, ngaybatdau, ngaytra);
        }
        public bool Xoagd(int id)
        {
            return gd.Xoagd(id);
        }
        public bool Suagd(int id, int makh, int maxe, DateTime ngaytao, DateTime ngaytra)
        {
           return gd.Suagd(id, makh, maxe, ngaytao, ngaytra);
        }

        public DataTable Timgd(string tenkh)
        {
            return gd.Timgd(tenkh);
        }
    }
}
