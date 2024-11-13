using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBCAFE
{
    internal class nhacungcap
    {
        ketnoi kn;
        public nhacungcap()
        {
            kn = new ketnoi();
        }
        public DataTable getallncc()
        {
            string sql = "select * from NhaCungCap";
            return kn.ReadData(sql);
        }
        public void addncc(string mancc, string tenncc, string diachi, string sdt, string email)
        {
            string sql = "INSERT INTO NhaCungCap (mancc, tenncc, diachi,sdt,email) values (@a,@b,@c,@d,@e)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@a",mancc),
                new SqlParameter("@b",tenncc),
                new SqlParameter("@c",diachi),
                new SqlParameter("@d",sdt),
                new SqlParameter("@e",email)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void editncc(string mancc, string tenncc, string diachi, string sdt, string email)
        {
            string sql = "UPDATE NhaCungCap SET tenncc = @b, diachi = @c, sdt = @d, email = @e WHERE mancc = @a";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@b",tenncc),
                new SqlParameter("@c",diachi),
                new SqlParameter("@d",sdt),
                new SqlParameter("@e",email),
                new SqlParameter("@a",mancc)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void deletencc(string mancc)
        {
            string sql = "DELETE NhaCungCap WHERE mancc = @a";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@a",mancc)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
    }
}
