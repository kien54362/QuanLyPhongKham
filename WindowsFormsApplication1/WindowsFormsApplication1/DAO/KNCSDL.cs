using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.DAO
{
    class KNCSDL
    {
        private static SqlConnection cnn = new SqlConnection();
        public static void moketnoi()
        {
            try
            {
                string sqlcon = @"Data Source=LAPTOP-7EHBJ4T8\SQLEXPRESS;Initial Catalog=QLPKT;Integrated Security=True";
                cnn.ConnectionString = sqlcon;
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
            }
            catch (Exception)
            {
            }
        }
        public static void dongketnoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public static DataTable docdulieu(string sql)
        {
            moketnoi();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dongketnoi();
            return dt;
        }
        public static void thucthitruyvan(string sql)
        {
            moketnoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            dongketnoi();
        }
    }
}
