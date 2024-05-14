using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FRM_quanlythanhtoan_inhoadon : Form
    {
        public FRM_quanlythanhtoan_inhoadon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MaBN = textBox1.Text;
            Database db;
            db = new Database(@"DESKTOP-76E8ESQ\CLIENT4", "QLPKT");
            string sql = "select DISTINCT k.MaBN, B.Hoten, X.TenXN, B.BSCD, B.NgayXN, X.GiaTien from Xetnghiem X, BenhNhan B, Ketqua K where B.MaBN = K.MaBN and B.MaBN = '"+textBox1.Text+"' and X.MaXN = K.MaXN";
            DataTable dt = db.Execute(sql);
            CrystalReportINKETQUAXETNGHIEM cry = new CrystalReportINKETQUAXETNGHIEM();
            cry.SetDataSource(dt);
            INKETQUAXETNGHIEM f1 = new INKETQUAXETNGHIEM();
            f1.crystalReportViewerINKETQUAXETNGHIEM.ReportSource = cry;
            cry.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"D:\" + textBox1.Text + ".pdf");
            MessageBox.Show("Đã xuất bản in ở ổ đĩa D");
        }

        private void FRM_quanlythanhtoan_inhoadon_Load(object sender, EventArgs e)
        {

        }
    }
}
