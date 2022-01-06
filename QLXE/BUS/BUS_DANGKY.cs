using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    
    public class BUS_DANGKY
    {
        DAL_DANGKY dk = new DAL_DANGKY();
        public bool DangKy(string ten, string mk)
        {
            return dk.DangKy(ten, mk);
        }
    }
}
