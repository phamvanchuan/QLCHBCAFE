using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace QuanCaPhe
{
    
    internal class datban
    {
        ketnoi kn;
        public datban()
        {
            kn = new ketnoi();   
        }
        public DataTable getdl()
        {
            string sql = "SELECT tensp FROM SanPham";
            return kn.ReadData(sql);
        }
        public DataTable getalldl()
        {
            string sql = "select * from KhachDatBan";
            return kn.ReadData(sql);
        }
        public void add(string maban, string tenban, string khuvuc, string tensp, int soluong)
        {
            string sql = "INSERT INTO KhachDatBan (maban,tenban,khuvuc,tensp,soluong) values (@a,@b,@c,@d,@e)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@a",maban),
                new SqlParameter("@b",tenban),
                new SqlParameter("@c",khuvuc),
                new SqlParameter("@d",tensp),
                new SqlParameter("@e",soluong)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void edit(string maban, string tenban, string khuvuc, string tensp, int soluong)
        {
            string sql = "UPDATE KhachDatBan SET tenban = @b, khuvuc = @c, tensp = @d, soluong = @e WHERE maban = @a";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                
                new SqlParameter("@b",tenban),
                new SqlParameter("@c",khuvuc),
                new SqlParameter("@d",tensp),
                new SqlParameter("@e",soluong),
                new SqlParameter("@a",maban)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void delete(string maban)
        {
            string sql = "DELETE KhachDatBan WHERE maban = @a";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@a",maban)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
    }
}
