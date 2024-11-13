using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanCaPhe
{
    internal class bcnhap
    {
        ketnoi kn;
        public bcnhap() {
            kn = new ketnoi();
        }
        public DataTable getdl()
        {
            string sql = "SELECT * FROM SanPham";
            return kn.ReadData(sql);
        }
        public DataTable searchdl(string a="",string b="")
        {
            string sql = "SELECT * FROM SanPham Where MONTH(SanPham.ngaynhap) = "+a+ " AND YEAR(SanPham.ngaynhap)=" + b;
            return kn.ReadData(sql);
        }
    }
}
