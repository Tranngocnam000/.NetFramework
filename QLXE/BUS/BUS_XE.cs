using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_XE
    {
        DAL_XE xe = new DAL_XE();
        public DataTable getxe()
        {
            return xe.getxe();
        }
        public bool ThemXe(string tenxe, string bienso, string tinhtrang, int giathue, int loai, int soghe)
        {
            return xe.ThemXe(tenxe, bienso, tinhtrang, giathue, loai, soghe);
        }
        public bool XoaXe(int id)
        {
            return xe.XoaXe(id);
        }
        public bool SuaXe(int id, string tenxe, string bienso, string tinhtrang, int giathue, int loai, int soghe)
        {
            return xe.SuaXe(id, tenxe, bienso, tinhtrang, giathue, loai, soghe);
        }
        public DataTable TimXe(string tenxe)
        {
            return xe.TimXe(tenxe);
        }
    }
}
