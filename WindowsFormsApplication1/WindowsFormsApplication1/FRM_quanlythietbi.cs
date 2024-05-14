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
    public partial class FRM_quanlythietbi : Form
    {
        public FRM_quanlythietbi()
        {
            InitializeComponent();

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FRM_quanlythietbi_Load(object sender, EventArgs e)
        {
            cboloaitb.Items.Add("THIẾT BỊ CHẨN ĐOÁN HÌNH ẢNH");
            cboloaitb.Items.Add("THIẾT BỊ XÉT NGHIỆM");
            cboloaitb.Items.Add("THIẾT BỊ NỘI SOI");
            cboloaitb.Items.Add("THIẾT BỊ HỖ TRỢ");
            cboloaitb.Items.Add("Lao công");
            load();
        }
        void load()
        {
            lstthietbi.Items.Clear();
            DataTable dt = new DataTable();
            string sql = "select MaTB,TenTB,Soluong,Nhasanxuat,Dongia,TenloaiTB from Thietbi, Loaithietbi";
            dt = Database.DocDuLieu(sql);
            int SL = dt.Rows.Count;
            for (int i = 0; i < SL; i++)
            {
                lstthietbi.Items.Add(dt.Rows[i][0].ToString());
                lstthietbi.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lstthietbi.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                lstthietbi.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lstthietbi.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                lstthietbi.Items[i].SubItems.Add(dt.Rows[i][5].ToString());

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboloaitb.Items.Add("THIẾT BỊ CHẨN ĐOÁN HÌNH ẢNH");
            cboloaitb.Items.Add("THIẾT BỊ XÉT NGHIỆM");
            cboloaitb.Items.Add("THIẾT BỊ NỘI SOI");
            cboloaitb.Items.Add("THIẾT BỊ HỖ TRỢ");
            cboloaitb.Items.Add("Lao công");
            string sql = "insert into Thietbi(MaTB,Nhasanxuat,TenTB,Soluong,Dongia) values ('" + txtmatb.Text + "','" + txtnsx.Text + "','" + txttenthietbi.Text + "','" + numsoluong.Text + "','" + txtdongia.Text + "')";
            DataTable dt = new DataTable();
            Database.ThucThiTuyVan(sql);
            //MessageBox.Show(sql);
            MessageBox.Show("Thiết bị " + txttenthietbi.Text + " đã được thêm");
            load();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int vt = lstthietbi.SelectedIndices[0];
            txtdongia.Text = lstthietbi.Items[vt].SubItems[4].Text;
            txtmatb.Text= lstthietbi.Items[vt].SubItems[0].Text;
            txtnsx.Text= lstthietbi.Items[vt].SubItems[2].Text;
            txttenthietbi.Text= lstthietbi.Items[vt].SubItems[1].Text;
            numsoluong.Value= Int16.Parse(lstthietbi.Items[vt].SubItems[3].Text);
            cboloaitb.Text= lstthietbi.Items[vt].SubItems[5].Text;
            try
            {
                pictureBox1.Load(lstthietbi.Items[vt].SubItems[0].Text + ".jpg");
            }
            catch (Exception ex)
            {
                pictureBox1.Image = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmatb.Visible = true;
            txttenthietbi.Text = "";
            txtdongia.Text = "";
            txtnsx.Text = "";      
            string sql = "select MaTB from Thietbi";
            DataTable dt = new DataTable();
            dt = Database.DocDuLieu(sql);
            string manv = dt.Rows[0][0].ToString();
            int cc = dt.Rows.Count;
            cc++;
            txtmatb.Text = cc.ToString();
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
                    ws.Cells[1, 1] = "Mã TB";
                    ws.Cells[1, 2] = "Tên Thiết bị";
                    ws.Cells[1, 3] = "Nhà sản xuất";
                    ws.Cells[1, 4] = "Số lượng";
                    ws.Cells[1, 5] = "Đơn giá";
                    ws.Cells[1, 6] = "Loại Thiết bị";

                    int i = 2;
                    foreach (ListViewItem item in lstthietbi.Items)
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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "delete from Thietbi where MaTB='" + txtmatb.Text + "'";
            Database.ThucThiTuyVan(sql);
            MessageBox.Show("Xoa thanh cong");
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "update Thietbi set TenTB='" + txttenthietbi.Text + "',Nhasanxuat='" + txtnsx.Text + "',Soluong='" + numsoluong.Text + "',Dongia='" + txtdongia.Text + "' where MaTB='" + txtmatb.Text + "'";
            Database.ThucThiTuyVan(sql);

            MessageBox.Show("Cập nhật Thiết bị " + txttenthietbi.Text + " thành công");
            load();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
