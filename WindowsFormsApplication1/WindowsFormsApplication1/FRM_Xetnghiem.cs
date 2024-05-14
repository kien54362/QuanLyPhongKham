using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1.DAO;

namespace WindowsFormsApplication1
{
    public partial class FRM_Xetnghiem : Form
    {
        public FRM_Xetnghiem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static DataTable TTXetnghiem()
        {
            string sql = "select MaXN, TenXN,LoaiXN,Chiso,GiaTien,Donvi from Xetnghiem order by MaXN+0 asc";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }
        void loadlai()
        {
            lstthongtinxn.Items.Clear();
            DataTable dt = new DataTable();
            dt = TTXetnghiem();
            int soxn = dt.Rows.Count;
            for (int i = 0; i < soxn; i++)
            {
                lstthongtinxn.Items.Add(dt.Rows[i][0].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][5].ToString());

            }
        }
        void Loadfrom()
        {
            lstthongtinxn.Items.Clear();
            cbloaixn.Items.Add("TPTTB");
            cbloaixn.Items.Add("Nhóm máu");
            cbloaixn.Items.Add("Miễn dịch");
            cbloaixn.Items.Add("Sinh hóa");
            cbloaixn.Items.Add("ĐMTB");
            DataTable dt = new DataTable();
            dt = TTXetnghiem();
            int soxn = dt.Rows.Count;
            for (int i = 0; i < soxn; i++)
            {
                lstthongtinxn.Items.Add(dt.Rows[i][0].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][5].ToString());

            }
        }
        private void FRM_Xetnghiem_Load(object sender, EventArgs e)
        {
            cbloaixn.Items.Add("TPTTB");
            cbloaixn.Items.Add("Nhóm máu");
            cbloaixn.Items.Add("Miễn dịch");
            cbloaixn.Items.Add("Sinh hóa");
            cbloaixn.Items.Add("ĐMTB");
            DataTable dt = new DataTable();
            dt = TTXetnghiem();
            int soxn = dt.Rows.Count;
            for (int i = 0; i < soxn; i++)
            {
                lstthongtinxn.Items.Add(dt.Rows[i][0].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                lstthongtinxn.Items[i].SubItems.Add(dt.Rows[i][5].ToString());

            }

        }

        private void lstthongtinxn_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void lstthongtinxn_Click(object sender, EventArgs e)
        {
            int vt = lstthongtinxn.SelectedIndices[0];
            txtmaxn.Text=lstthongtinxn.Items[vt].SubItems[0].Text;
            txttenxn.Text=lstthongtinxn.Items[vt].SubItems[1].Text;
            txtdongia.Text = lstthongtinxn.Items[vt].SubItems[4].Text;
            cbloaixn.Text = lstthongtinxn.Items[vt].SubItems[2].Text;
            txtdvt.Text= lstthongtinxn.Items[vt].SubItems[5].Text;
            txtcsbt.Text= lstthongtinxn.Items[vt].SubItems[3].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void butthem_Click(object sender, EventArgs e)
        {
            txtmaxn.Visible = true;
            txtcsbt.Text = "";
            txtdongia.Text = "";
            txtdvt.Text = "";
            txttenxn.Text = "";
            string sql = "select MaXN from XetNghiem";
            DataTable dt = new DataTable();
            dt = Database.DocDuLieu(sql);
            string manv = dt.Rows[0][0].ToString();
            int cc = dt.Rows.Count;
            cc++;
            txtmaxn.Text = cc.ToString() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbloaixn.Items.Add("TPTTB");
            cbloaixn.Items.Add("Nhóm máu");
            cbloaixn.Items.Add("Miễn dịch");
            cbloaixn.Items.Add("Sinh hóa");
            cbloaixn.Items.Add("ĐMTB");
            string sql = "insert into Xetnghiem(MaXN,LoaiXN,TenXN,Chiso,Donvi,GiaTien) values ('"+txtmaxn.Text+"','"+cbloaixn.Text+"','"+txttenxn.Text+"','"+txtcsbt.Text+"','"+txtdvt.Text+"','"+txtdongia.Text+"')";
            DataTable dt = new DataTable();
            Database.ThucThiTuyVan(sql);
            //MessageBox.Show(sql);
            MessageBox.Show("Xét nghiệm " + txttenxn.Text + " đã được thêm");
            Loadfrom();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "update Xetnghiem set TenXN='"+txttenxn.Text+"',LoaiXN='"+cbloaixn.Text+"',Chiso='"+txtcsbt.Text+"',GiaTien='"+txtdongia.Text+"',Donvi='"+txtdvt.Text+"' where MaXN='"+txtmaxn.Text+"'";
            Database.ThucThiTuyVan(sql);
         
            MessageBox.Show("Cập nhật xét nghiệm "+txttenxn.Text+" thành công");
            loadlai();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "Delete  Xetnghiem where MaXN='"+txtmaxn.Text+"'";
            Database.ThucThiTuyVan(sql);
            MessageBox.Show("Xóa xét nghiệm " + txttenxn.Text + " thành công");
            loadlai();
            txtcsbt.Text = "";
            txtdongia.Text = "";
            txtdvt.Text = "";
            txttenxn.Text = "";
            cbloaixn.Text = "";
            txtmaxn.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Mã XN";
                    ws.Cells[1, 2] = "Tên Xét nghiệm";
                    ws.Cells[1, 3] = "Loại XN";
                    ws.Cells[1, 4] = "Chỉ số bình thường";
                    ws.Cells[1, 5] = "Đơn giá";
                    ws.Cells[1, 6] = "Đơn vị tính";
                    
                    int i = 2;
                    foreach (ListViewItem item in lstthongtinxn.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 6] = item.SubItems[5].Text;
                        
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Đã xuất file Excel", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Database db;
            db = new Database(@"DESKTOP-76E8ESQ\CLIENT4", "QLPKT");
            string sql = "select X.MaXN,LoaiXN,TenXN,Chiso,Donvi,GiaTien, MaBN, Ketqua from Xetnghiem X, Ketqua K where  X.MaXN=K.MaXN";
            DataTable dt = db.Execute(sql);
            CrystalReportTHONGKEXETNGHIEM cry = new CrystalReportTHONGKEXETNGHIEM();
            cry.SetDataSource(dt);
            FRM_thongkexetnghiem f1 = new FRM_thongkexetnghiem();
            f1.crystalReportViewer1.ReportSource = cry;
            f1.ShowDialog();
        }

        private void cbloaixn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
