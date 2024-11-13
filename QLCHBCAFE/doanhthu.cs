using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanCaPhe
{
    internal class doanhthu
    {
        ketnoi kn;
        public doanhthu()
        {
            kn= new ketnoi();
        }

        public DataTable getdl(string month = "", string year = "")
        {
            string query = @"
                SELECT 
                    YEAR(ngay) AS Nam, 
                    MONTH(ngay) AS Thang, 
                    ISNULL(SUM(tongtien), 0) AS TongTienNhap,
                    ISNULL(SUM(thanhtien), 0) AS TongTienXuat,
                    ISNULL(SUM(thanhtien), 0) - ISNULL(SUM(tongtien), 0) AS DoanhThu
                FROM
                (
                    SELECT ngaynhap AS ngay, SUM(tongtien) AS tongtien, 0 AS thanhtien
                    FROM SanPham
                    GROUP BY ngaynhap
                    UNION ALL
                    SELECT ngayxuat AS ngay, 0 AS tongtien, SUM(thanhtien) AS thanhtien
                    FROM HoaDon
                    GROUP BY ngayxuat
                ) AS Combined
                WHERE 1=1";

                    if (!string.IsNullOrEmpty(month))
                    {
                        query += " AND MONTH(ngay) = " + month;
                    }

                    if (!string.IsNullOrEmpty(year))
                    {
                        query += " AND YEAR(ngay) = " + year;
                    }

                    query += @"
                GROUP BY YEAR(ngay), MONTH(ngay)
                ORDER BY Nam, Thang;
            ";

            return kn.ReadData(query);
        }




    }
}
