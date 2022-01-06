using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_LOAIXE
    {
        DAL_LOAIXE loai = new DAL_LOAIXE();
        public DataTable getLoai()
        {
            return loai.getLoai();
        }
        public bool ThemLoai(string name)
        {
            return loai.ThemLoai(name);
        }

        public bool SuaLoai(int id, string name)
        {
            return loai.SuaLoai(id, name);
        }
        public bool XoaLoai(int id)
        {
            return loai.XoaLoai(id);
        }
        public DataTable TimLoai(string ten)
        {
            return loai.TimLoai(ten);
        }
    }
}
