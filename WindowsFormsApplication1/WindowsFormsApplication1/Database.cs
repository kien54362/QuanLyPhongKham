using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Database
    {
        private SqlConnection conn;

        public SqlConnection Connected()
        {
            string source = @"Data Source=LAPTOP-7EHBJ4T8\SQLEXPRESS;Initial Catalog=QLPKT;Integrated Security=True";
            conn = new SqlConnection(source);
            conn.Open();
            return conn;

        }
        SqlConnection sqlconn;
        SqlDataAdapter da;
        DataSet ds;
        public Database(string srvname, string dbName)
        {
            string cnnstr = @"Data source =" + srvname + "; Initial Catalog =" + dbName + "; Integrated Security = true ";
            sqlconn = new SqlConnection(cnnstr);
        }

        public Database()
        {
        }

        public DataTable Execute(string sqlstr)
        {
            da = new SqlDataAdapter(sqlstr, sqlconn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public void ExcuteNoQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlconn);
            sqlconn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlconn.Close();
        }
        private static SqlConnection cnn = new SqlConnection();
        public static void MoKetNoi()
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
                MessageBox.Show("Ket noi khong thanh cong");
            }
        }

        public static void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public static DataTable DocDuLieu(string sql)
        {
            MoKetNoi();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }
        public static void ThucThiTuyVan(string sql)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
