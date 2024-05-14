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

namespace WindowsFormsApplication1
{
    public partial class FRM_nhanvien : Form
    {
        private Database db = new Database();
        SqlConnection cnn = null;
        public FRM_nhanvien()
        {
            InitializeComponent();
        }

        private void FRM_nhanvien_Load(object sender, EventArgs e)
        {
            load();
            cbogioitinh.Items.Add("Nam");
            cbogioitinh.Items.Add("Nữ");
            cbochucvu.Items.Add("Bác sĩ");
            cbochucvu.Items.Add("Y tá");
            cbochucvu.Items.Add("Lao công");
        }

        void load()
        {
            listView1.Items.Clear();
            DataTable dt = new DataTable();
            string sql = "Select MaNV ,Hoten,Namsinh,Gioitinh,Dienthoai,Diachi,Chucvu from Nhanvien";
            dt = Database.DocDuLieu(sql);
            int SL = dt.Rows.Count;
            for (int i = 0; i < SL; i++)
            {
                listView1.Items.Add(dt.Rows[i][0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][5].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i][6].ToString());
            }

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int vt = listView1.SelectedIndices[0];
            txthoten.Text = listView1.Items[vt].SubItems[1].Text;
            txtnamsinh.Text = listView1.Items[vt].SubItems[2].Text;
            cbogioitinh.Text = listView1.Items[vt].SubItems[3].Text;
            txtdienthoai.Text = listView1.Items[vt].SubItems[4].Text;
            txtdiachi.Text = listView1.Items[vt].SubItems[5].Text;
            cbochucvu.Text = listView1.Items[vt].SubItems[6].Text;
            txtmanv.Text = listView1.Items[vt].SubItems[0].Text;
            try
            {
                pictureBox1.Load(listView1.Items[vt].SubItems[0].Text + ".jpg");
            }
            catch(Exception ex)
            {
                pictureBox1.Image = null;
            }
        }

        private void buttaianh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files (*.jpg;*.png;*jpeg)|*.jpg|*.png|*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);

                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butthem_Click(object sender, EventArgs e)
        {
            /* txtmanv.Visible = true;
             txthoten.Text = "";
             cbogioitinh.Text = "";
             txtnamsinh.Text = "";
             txtdiachi.Text = "";
             txtdienthoai.Text = "";
             cbochucvu.Text = "";
             DataTable dt = new DataTable();
             string sql = "select top 1 MaNV from Nhanvien order by MaNV desc";
             dt = Database.DocDuLieu(sql);
             string manv = dt.Rows[0][0].ToString();
             txtmanv.Text = "BS" + (int.Parse(manv.Substring(manv.Length - 3, 3)) + 1).ToString("000");*/
            txtmanv.Visible = true;
            txthoten.Text = "";
            cbogioitinh.Text = "";
            txtnamsinh.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            cbochucvu.Text = "";
            string sql = "select MaNV from Nhanvien";
            DataTable dt = new DataTable();
            dt = Database.DocDuLieu(sql);
            string manv = dt.Rows[0][0].ToString();
            int cc = dt.Rows.Count;
            cc++;
            txtmanv.Text = cc.ToString();

        }

        private void butluu_Click(object sender, EventArgs e)
        {
            
            int namsinh = Convert.ToInt32(txtnamsinh.Text);
            string sql1 = "INSERT into Nhanvien (MaNV,Hoten,Namsinh,Gioitinh,Dienthoai,Diachi,Chucvu) VALUES ('"+txtmanv.Text+"',N'"+txthoten.Text+"',"+namsinh+",N'"+cbogioitinh.Text+"','"+txtdienthoai.Text+"',N'"+txtdiachi.Text+"',N'"+cbochucvu.Text+"')";
            Database.ThucThiTuyVan(sql1);
            MessageBox.Show("Luu thanh cong");
            load(); 
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from Nhanvien where MaNV='"+txtmanv.Text+"'";
            Database.ThucThiTuyVan(sql);          
            MessageBox.Show("Xoa thanh cong");
            load();
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            int namsinh = Convert.ToInt32(txtnamsinh.Text);
            string sql = "update Nhanvien set Hoten=N'"+txthoten.Text+"', Namsinh="+namsinh+", Gioitinh=N'"+cbogioitinh.Text+"', Dienthoai='"+txtdienthoai.Text+"', Diachi=N'"+txtdiachi.Text+"', Chucvu=N'"+cbochucvu.Text+"' where MaNV='"+txtmanv.Text+"'";
            Database.ThucThiTuyVan(sql);
            MessageBox.Show("Cap nhat thanh cong");
            load();
        }

        private void butxuatexcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Mã NV";
                    ws.Cells[1, 2] = "Họ và tên";
                    ws.Cells[1, 3] = "Năm sinh";
                    ws.Cells[1, 4] = "Giới tính";
                    ws.Cells[1, 5] = "Điện thoại";
                    ws.Cells[1, 6] = "Địa chỉ";
                    ws.Cells[1, 7] = "Chức vụ";
                    int i = 2;
                    foreach(ListViewItem item in listView1.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 6] = item.SubItems[5].Text;
                        ws.Cells[i, 7] = item.SubItems[6].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Đã xuất file Excel", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
