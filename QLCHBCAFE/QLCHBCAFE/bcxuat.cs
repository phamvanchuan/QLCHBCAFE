using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanCaPhe
{
    internal class bcxuat
    {
        ketnoi kn;
        public bcxuat() 
        {
            kn = new ketnoi();
        }
        public DataTable getdl()
        {
            string sql = "SELECT * FROM HoaDon";
            return kn.ReadData(sql);
        }
        public DataTable searchdl(string a="",string b="")
        {
            string sql = "SELECT * FROM HoaDon WHERE MONTH(HoaDon.ngayxuat) = " + a + " AND YEAR(HoaDon.ngayxuat)=" + b;
            return kn.ReadData(sql);
        }
    }
}
