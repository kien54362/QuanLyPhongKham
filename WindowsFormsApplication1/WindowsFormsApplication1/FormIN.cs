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
    public partial class FormIN : Form
    {
        public FormIN()
        {
            InitializeComponent();
        }


        public string MaBN;

        private void FormIN_Load(object sender, EventArgs e)
        {
            Database db;
            db = new Database(@"DESKTOP-76E8ESQ\CLIENT4", "QLPKT");
            string sql = "select k.MaBN from Xetnghiem X, BenhNhan B, Ketqua K where B.MaBN= K.MaBN and B.MaBN='"+MaBN+"' and X.MaXN = K.MaXN";
            DataTable dt = db.Execute(sql);
            CrystalReportINKHACHHANG cry = new CrystalReportINKHACHHANG();
            cry.SetDataSource(dt);
            crystalReportViewer2.ReportSource = cry;
        }
    }
}
