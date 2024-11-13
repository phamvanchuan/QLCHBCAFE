using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBCAFE
{
    internal class ketnoi
    {
        public SqlConnection conn;
        public void openConnection()
        {
            conn = new SqlConnection("Data Source=DESKTOP-CDSNGVK\\MAY1;Initial Catalog=QuanCaPhe;Integrated Security=True");
            conn.Open();
        }
        public void closeConnection()
        {
            conn.Close();
        }
        //Thực hiện lệnh ExecuteReader
        public DataTable ReadData(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public void CreateUpdateDelete(string sql, SqlParameter[] sqlParameters = null)
        {
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (sqlParameters != null) cmd.Parameters.AddRange(sqlParameters);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
