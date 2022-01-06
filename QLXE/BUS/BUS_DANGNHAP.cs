using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BUS
{
    public class BUS_DANGNHAP
    {
        DAL_DANGNHAP dn = new DAL.DAL_DANGNHAP();
        public string getID(string username, string pass)
        {
            return dn.getID(username, pass);
        }
        public string getPass(string pass)
        {
            return dn.getPass(pass);
        }
        public bool CheckUser(string name)
        {
            return dn.CheckUser(name);
        }
    }
}
