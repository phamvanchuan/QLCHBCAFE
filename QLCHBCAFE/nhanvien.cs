using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBCAFE
{
    internal class nhanvien
    {
        ketnoi kn;
        public nhanvien()
        {
            kn = new ketnoi();
        }
        public DataTable getallnv()
        {
            string sql = "select * from NhanVien";
            return kn.ReadData(sql);
        }
        public void addnv(string manv, string tennv, DateTime ngaysinh, string diachi, string dienthoai)
        {
            string sql = "INSERT INTO NhanVien (manv, tennv, ngaysinh, diachi, dienthoai) values (@a,@b,@c,@d,@e)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@a",manv),
                new SqlParameter("@b",tennv),
                new SqlParameter("@c",ngaysinh),
                new SqlParameter("@d",diachi),
                new SqlParameter("@e",dienthoai)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void editnv(string manv, string tennv, DateTime ngaysinh, string diachi, string dienthoai)
        {
            string sql = "UPDATE NhanVien SET tennv = @b, ngaysinh = @c, diachi = @d, dienthoai = @e WHERE manv = @a";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@b",tennv),
                new SqlParameter("@c",ngaysinh),
                new SqlParameter("@d",diachi),
                new SqlParameter("@e",dienthoai),
                new SqlParameter("@a",manv)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void deletenv(string manv)
        {
            string sql = "DELETE NhanVien WHERE manv = @a";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@a",manv)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
    }
}
