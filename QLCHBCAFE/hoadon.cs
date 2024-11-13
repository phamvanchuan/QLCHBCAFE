using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanCaPhe
{
    internal class hoadon
    {
        ketnoi kn;
        public hoadon()
        {
            kn = new ketnoi();
        }
        public DataTable getdlnv()
        {
            string sql = "SELECT manv FROM NhanVien";
            return kn.ReadData(sql);
        }
        public DataTable getdlb()
        {
            string sql = "SELECT maban FROM KhachDatBan";
            return kn.ReadData(sql);
        }
        public DataTable getdlsp()
        {
            string sql = "SELECT masp FROM SanPham";
            return kn.ReadData(sql);
        }
        public DataTable getallhd()
        {
            string sql = "select mahd,maban,masp,manv,ngayxuat,soluongmua,dongiaban from HoaDon";
            return kn.ReadData(sql);
        }
        public void addhd(string mahd,string maban,string masp,string manv,DateTime ngayxuat,int soluongmua,int dongiaban)
        {
            string sql = "INSERT INTO HoaDon (mahd,maban,masp,manv,ngayxuat,soluongmua,dongiaban,thanhtien) values (@a,@b,@c,@d,@e,@f,@g,@h)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@a",mahd),
                new SqlParameter("@b",maban),
                new SqlParameter("@c",masp),
                new SqlParameter("@d",manv),
                new SqlParameter("@e",ngayxuat),
                new SqlParameter("@f",soluongmua),
                new SqlParameter("@g",dongiaban),
                new SqlParameter("@h",(soluongmua*dongiaban))

            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void edithd(string mahd, string maban, string masp, string manv, DateTime ngayxuat, int soluongmua, int dongiaban)
        {
            string sql = "UPDATE HoaDon SET maban=@b,masp=@c,manv=@d,ngayxuat=@e,soluongmua=@f,dongiaban=@g,thanhtien=@h WHERE mahd = @a";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                
                new SqlParameter("@b",maban),
                new SqlParameter("@c",masp),
                new SqlParameter("@d",manv),
                new SqlParameter("@e",ngayxuat),
                new SqlParameter("@f",soluongmua),
                new SqlParameter("@g",dongiaban),
                new SqlParameter("@h",(soluongmua*dongiaban)),
                new SqlParameter("@a",mahd)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void deletehd(string mahd)
        {
            string sql = "DELETE HoaDon WHERE mahd = @a";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@a",mahd)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
    }
}
