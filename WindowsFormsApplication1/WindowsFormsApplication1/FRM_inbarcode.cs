using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApplication1
{
    public partial class FRM_inbarcode : Form
    {
        DataTable dt;
        ReportDocument cry = new ReportDocument();
        public FRM_inbarcode()
        {
            InitializeComponent();
        }

        private void FRM_inbarcode_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.TableName = "BARCODE";
            dt.Columns.Add("Hoten", typeof(string));
            dt.Columns.Add("MaBN", typeof(string));
            dt.Columns.Add("NgayXN", typeof(string));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtmabn.Text, txthoten.Text, dateTimePicker1.Text);
            cry.Load("CrystalReportINBARCODE.rpt");
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select DISTINCT MaBN,Hoten,NgayXN from BenhNhan Where MaBN like '" + txtmabn.Text + "%'";
            DataTable dt = new DataTable();
            dt = Database.DocDuLieu(sql);
            int SL = dt.Rows.Count;
            for (int i = 0; i < SL; i++)
            {
                txthoten.Text = dt.Rows[i][1].ToString();
                dateTimePicker1.Text =  dt.Rows[i][2].ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
