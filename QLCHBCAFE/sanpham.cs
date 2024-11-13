using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanCaPhe
{
    internal class sanpham
    {
        ketnoi kn;
        public sanpham()
        {
            kn = new ketnoi();
        }
        public DataTable getdl()
        {
            string sql = "SELECT mancc FROM NhaCungCap";
            return kn.ReadData(sql);
        }
        public DataTable getallsp()
        {
            string sql = "select masp,tensp,dongia,mancc,slnhap,ngaynhap from SanPham";
            return kn.ReadData(sql);
        }
        public void addsp(string masp, string tensp, int dongia, string mancc,int slnhap,DateTime ngaynhap)
        {
            string sql = "INSERT INTO SanPham (masp,tensp,dongia,mancc,slnhap,tongtien,ngaynhap) values (@a,@b,@c,@d,@e,@f,@g)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@a",masp),
                new SqlParameter("@b",tensp),
                new SqlParameter("@c",dongia),
                new SqlParameter("@d",mancc),
                new SqlParameter("@e",slnhap),
                new SqlParameter("@f",(dongia*slnhap)),
                new SqlParameter("@g",ngaynhap)

            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void editsp(string masp, string tensp, int dongia, string mancc, int slnhap, DateTime ngaynhap)
        {
            string sql = "UPDATE SanPham SET tensp = @b, dongia = @c, mancc = @d, slnhap = @e,tongtien = @f,ngaynhap=@g WHERE masp = @a";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {               
                new SqlParameter("@b",tensp),
                new SqlParameter("@c",dongia),
                new SqlParameter("@d",mancc),
                new SqlParameter("@e",slnhap),
                new SqlParameter("@f",(dongia*slnhap)),
                new SqlParameter("@g",ngaynhap),
                new SqlParameter("@a",masp)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void deletesp(string masp)
        {
            string sql = "DELETE SanPham WHERE masp = @a";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@a",masp)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
    }
}
