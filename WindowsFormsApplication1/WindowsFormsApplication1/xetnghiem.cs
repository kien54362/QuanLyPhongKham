using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin;
using MaterialSkin.Controls;
using CrystalDecisions.CrystalReports.Engine;

using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    
    public partial class xetnghiem : Form
    {
        private Database db = new Database();
        public SqlConnection cnn = null;
        DataTable dtTemp = null;
        public string tk;
        SqlConnection cn = new SqlConnection();
        public static DataTable TTXetnghiem_TPTTB()
        {
            string sql = "select * from Xetnghiem where LoaiXN='TPTTB'";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
            
        }

        public static DataTable TTXetnghiem_Nhommau()
        {
            string sql = "select * from Xetnghiem where LoaiXN='Nhóm máu'";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }

        public static DataTable TTXetnghiem_Miendich()
        {
            string sql = "select * from Xetnghiem where LoaiXN=N'Miễn dịch'";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }

        public static DataTable TTXetnghiem_Sinhhoa()
        {
            string sql = "select * from Xetnghiem where LoaiXN=N'Sinh hóa'";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }
        public static DataTable TTXetnghiem_DMTB()
        {
            string sql = "select * from Xetnghiem where LoaiXN=N'ĐMTB'";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }

        public static DataTable TTnhanvientheoMaBN(int mabn)
        {
            string sql = "select * from BenhNhan where MaBN='" + mabn + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }

        public static DataTable TTKetquatheoMaBN(int mabn)
        {
            string sql = "select k.MaXN,TenXN,Ketqua,Donvi,Chiso from Ketqua k,Xetnghiem x where MaBN='" + mabn + "' and k.MaXN=x.MaXN order by k.MaXN+0 asc";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            return dt;
        }

        public void TTxetnghiem_listview()
        {
            lstxetnghiem.Items.Clear();
            DataTable dt = new DataTable();
            dt = TTXetnghiem_TPTTB();
            int soxn = dt.Rows.Count;
            for (int i = 1; i < soxn; i++)
            {
                lstxetnghiem.Items.Add(dt.Rows[i][0].ToString());
                lstxetnghiem.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lstxetnghiem.Items[i].SubItems.Add(dt.Rows[i][1].ToString());

            }
           
        }

        public xetnghiem()
        {
            InitializeComponent();
        }
        public void Load_lai()
        {
            comboBox1.Items.Add("TPTTB");
            comboBox1.Items.Add("Nhóm máu");
            comboBox1.Items.Add("Miễn dịch");
            comboBox1.Items.Add("Sinh hóa");
            comboBox1.Items.Add("ĐMTB");
            txtmabn.Text = "2713";
            txttenbn.Text = "HUỲNH THỊ BÍCH CHI";
            txtngaysinhtuoi.Text = "2000";
            txtdiachi.Text = "CHỢ GẠO - TG";
            cbbscd.Text = "BS ĐOÀN THỊ NGA";
            txtchuandoan.Text = " ";
            dtpngayxn.Text = "11/10/2022";
            DataTable dt = new DataTable();
            dt = TTKetquatheoMaBN(2713);
            int soxn = dt.Rows.Count;
            for (int i = 0; i < soxn; i++)
            {
                lstketqua.Items.Add(dt.Rows[i][0].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
            }
            DataTable dt1 = new DataTable();
            dt1 = BENHNHANDAO.TTBenhnhan();
            int sobn = dt1.Rows.Count;
            txtstt.Text = "1/" + sobn;

            //Gia tien
            int mabn1 = Int32.Parse(txtmabn.Text);
            DataTable dta = new DataTable();
            dta = BENHNHANDAO.TTGiatien(mabn1);
            int sotien = dta.Rows.Count;
            for (int i = 0; i < sotien; i++)
            {
                label11.Text = dta.Rows[i][0].ToString();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("TPTTB");
            comboBox1.Items.Add("Nhóm máu");
            comboBox1.Items.Add("Miễn dịch");
            comboBox1.Items.Add("Sinh hóa");
            comboBox1.Items.Add("ĐMTB");
            txtmabn.Text = "2713";
            txttenbn.Text = "HUỲNH THỊ BÍCH CHI";
            txtngaysinhtuoi.Text = "2000";
            txtdiachi.Text = "CHỢ GẠO - TG";
            cbbscd.Text = "BS ĐOÀN THỊ NGA";
            txtchuandoan.Text = "THAI KHỎE";
            dtpngayxn.Text = "11/10/2022";
            txtdienthoai.Text = "0335787773";
            DataTable dt = new DataTable();
            dt = TTKetquatheoMaBN(2713);
            int soxn = dt.Rows.Count;
            for (int i = 0; i < soxn; i++)
            {
                lstketqua.Items.Add(dt.Rows[i][0].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
            }
            DataTable dt1 = new DataTable();
            dt1 = BENHNHANDAO.TTBenhnhan();
            int sobn = dt1.Rows.Count;
            txtstt.Text = "1/" + sobn;

            //Gia tien
            int mabn1 = Int32.Parse(txtmabn.Text);
            DataTable dta = new DataTable();
            dta = BENHNHANDAO.TTGiatien(mabn1);
            int sotien = dta.Rows.Count;
            for (int i = 0; i < sotien; i++)
            {
                label11.Text = dta.Rows[i][0].ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dgvxetnghiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "TPTTB")
            {
                lstxetnghiem.Items.Clear();
                DataTable dt = new DataTable();
                dt = TTXetnghiem_TPTTB();
                int soxn = dt.Rows.Count;
                for (int i = 0; i < soxn; i++)
                {
                    lstxetnghiem.Items.Add(dt.Rows[i][2].ToString());
                }
            }
            if (comboBox1.Text == "Nhóm máu")
            {
                lstxetnghiem.Items.Clear();
                DataTable dt = new DataTable();
                dt = TTXetnghiem_Nhommau();
                int soxn = dt.Rows.Count;
                for (int i = 0; i < soxn; i++)
                {
                    lstxetnghiem.Items.Add(dt.Rows[i][2].ToString());
                }
            }
            if (comboBox1.Text == "Miễn dịch")
            {
                lstxetnghiem.Items.Clear();
                DataTable dt = new DataTable();
                dt = TTXetnghiem_Miendich();
                int soxn = dt.Rows.Count;
                for (int i = 0; i < soxn; i++)
                {
                    lstxetnghiem.Items.Add(dt.Rows[i][2].ToString());
                }
            }
            if (comboBox1.Text == "Sinh hóa")
            {
                lstxetnghiem.Items.Clear();
                DataTable dt = new DataTable();
                dt = TTXetnghiem_Sinhhoa();
                int soxn = dt.Rows.Count;
                for (int i = 0; i < soxn; i++)
                {
                    lstxetnghiem.Items.Add(dt.Rows[i][2].ToString());
                }
            }
            if (comboBox1.Text == "ĐMTB")
            {
                lstxetnghiem.Items.Clear();
                DataTable dt = new DataTable();
                dt = TTXetnghiem_DMTB();
                int soxn = dt.Rows.Count;
                for (int i = 0; i < soxn; i++)
                {
                    lstxetnghiem.Items.Add(dt.Rows[i][2].ToString());
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstketqua.Items.Clear();
            int mabn = Int32.Parse(txtmabn.Text);
            mabn++;
            DataTable dt = new DataTable();
            dt = TTnhanvientheoMaBN(mabn);
            DataTable dt2 = new DataTable();
            dt2 = BENHNHANDAO.TTBenhnhan();
            int sobn = dt2.Rows.Count;
            int soxn = dt.Rows.Count;
            int dem = mabn - 2712;
            for (int i = 0; i < soxn; i++)
            {
                txtmabn.Text = mabn.ToString();
                txttenbn.Text = dt.Rows[i][1].ToString();
                txtngaysinhtuoi.Text = dt.Rows[i][2].ToString(); ;
                txtdiachi.Text = dt.Rows[i][3].ToString(); ;
                cbbscd.Text = dt.Rows[i][6].ToString(); ;
                txtchuandoan.Text = dt.Rows[i][5].ToString();
                txtstt.Text = dem + "/" + sobn;
                txtdienthoai.Text = dt.Rows[i][4].ToString();
                dem++;
                dtpngayxn.Text = dt.Rows[i][7].ToString(); 
            }
            DataTable dt1 = new DataTable();
            dt1 = TTKetquatheoMaBN(mabn);
            int soxn1 = dt1.Rows.Count;
            for (int i = 0; i < soxn1; i++)
            {
                lstketqua.Items.Add(dt1.Rows[i][0].ToString());
                lstketqua.Items[i].SubItems.Add(dt1.Rows[i][1].ToString());
                lstketqua.Items[i].SubItems.Add(dt1.Rows[i][2].ToString());
                lstketqua.Items[i].SubItems.Add(dt1.Rows[i][3].ToString());
                lstketqua.Items[i].SubItems.Add(dt1.Rows[i][4].ToString());
            }
            /*int dem = 1;
            DataTable dt2 = new DataTable();
            dt2 = BENHNHANDAO.TTBenhnhan();
            int sobn = dt2.Rows.Count;
            txtstt.Text = dem + "/" + sobn;
            dem++;*/

            //Tinh tien
            int mabn1 = Int32.Parse(txtmabn.Text);
            DataTable dta = new DataTable();
            dta = BENHNHANDAO.TTGiatien(mabn1);
            int sotien = dta.Rows.Count;
            for (int i = 0; i < sotien; i++)
            {
                label11.Text = dta.Rows[i][0].ToString();
            }
        }

        private void bttrangcuoi_Click(object sender, EventArgs e)
        {
            lstketqua.Items.Clear();
            DataTable dt = new DataTable();
            dt = BENHNHANDAO.TTBNLN();
            int soxn = dt.Rows.Count;
            for (int i = 0; i < soxn; i++)
            {
                txtmabn.Text = dt.Rows[i][0].ToString();
                //txttenbn.Text = dt.Rows[i][1].ToString();
                //txtngaysinhtuoi.Text = dt.Rows[i][2].ToString(); ;
                //txtdiachi.Text = dt.Rows[i][3].ToString(); ;
                //cbbscd.Text = dt.Rows[i][4].ToString(); ;
                // txtchuandoan.Text = dt.Rows[i][5].ToString(); ;
                //txtstt.Text = dem + "/" + sobn;
                //dem++;
                //dtpngayxn.Text = dt.Rows[i][6].ToString(); 
            }
            DataTable dt2 = new DataTable();
            dt2 = BENHNHANDAO.TTBenhnhan();
            int sobn = dt2.Rows.Count;
            int mabn = Int32.Parse(txtmabn.Text);
            DataTable dt1 = new DataTable();
            dt = BENHNHANDAO.TTBNLN2(mabn);
            int soxn1 = dt.Rows.Count;
            for (int i = 0; i < soxn; i++)
            {
                txtmabn.Text = dt.Rows[i][0].ToString();
                txttenbn.Text = dt.Rows[i][1].ToString();
                txtngaysinhtuoi.Text = dt.Rows[i][2].ToString(); ;
                txtdiachi.Text = dt.Rows[i][3].ToString(); ;
                cbbscd.Text = dt.Rows[i][4].ToString(); ;
                txtchuandoan.Text = dt.Rows[i][5].ToString(); ;
                txtstt.Text = sobn + "/" + sobn;
                //dem++;
                //dtpngayxn.Text = dt.Rows[i][6].ToString(); 
            }
            int mabn11 = Int32.Parse(txtmabn.Text);
            DataTable dt5 = new DataTable();
            dt5 = TTKetquatheoMaBN(mabn11);
            int soxn5 = dt1.Rows.Count;
            for (int i = 0; i < soxn5; i++)
            {
                lstketqua.Items.Add(dt5.Rows[i][0].ToString());
                lstketqua.Items[i].SubItems.Add(dt5.Rows[i][1].ToString());
                lstketqua.Items[i].SubItems.Add(dt5.Rows[i][2].ToString());
                lstketqua.Items[i].SubItems.Add(dt5.Rows[i][3].ToString());
                lstketqua.Items[i].SubItems.Add(dt5.Rows[i][4].ToString());
            }

            //Tinh tien
            int mabn1 = Int32.Parse(txtmabn.Text);
            DataTable dta = new DataTable();
            dta = BENHNHANDAO.TTGiatien(mabn1);
            int sotien = dta.Rows.Count;
            for (int i = 0; i < sotien; i++)
            {
                label11.Text = dta.Rows[i][0].ToString();
            }

        }

        private void bttrangdau_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BENHNHANDAO.TTBNNN();
            int soxn = dt.Rows.Count;
            for (int i = 0; i < soxn; i++)
            {
                txtmabn.Text = dt.Rows[i][0].ToString();
                //txttenbn.Text = dt.Rows[i][1].ToString();
                //txtngaysinhtuoi.Text = dt.Rows[i][2].ToString(); ;
                //txtdiachi.Text = dt.Rows[i][3].ToString(); ;
                //cbbscd.Text = dt.Rows[i][4].ToString(); ;
                // txtchuandoan.Text = dt.Rows[i][5].ToString(); ;
                //txtstt.Text = dem + "/" + sobn;
                //dem++;
                //dtpngayxn.Text = dt.Rows[i][6].ToString(); 
            }
            DataTable dt2 = new DataTable();
            dt2 = BENHNHANDAO.TTBenhnhan();
            int sobn = dt2.Rows.Count;
            int mabn = Int32.Parse(txtmabn.Text);
            DataTable dt1 = new DataTable();
            dt = BENHNHANDAO.TTBNLN2(mabn);
            int soxn1 = dt.Rows.Count;
            for (int i = 0; i < soxn; i++)
            {
                txtmabn.Text = dt.Rows[i][0].ToString();
                txttenbn.Text = dt.Rows[i][1].ToString();
                txtngaysinhtuoi.Text = dt.Rows[i][2].ToString(); ;
                txtdiachi.Text = dt.Rows[i][3].ToString(); ;
                cbbscd.Text = dt.Rows[i][4].ToString(); ;
                txtchuandoan.Text = dt.Rows[i][5].ToString(); ;
                //dem++;
                //dtpngayxn.Text = dt.Rows[i][6].ToString(); 
            }
            txtstt.Text = "1/" + sobn;

            //Tinh tien
            int mabn1 = Int32.Parse(txtmabn.Text);
            DataTable dta = new DataTable();
            dta = BENHNHANDAO.TTGiatien(mabn1);
            int sotien = dta.Rows.Count;
            for (int i = 0; i < sotien; i++)
            {
                label11.Text = dta.Rows[i][0].ToString();
            }
        }

        private void bttrangsau_Click(object sender, EventArgs e)
        {
            lstketqua.Items.Clear();
            int mabn = Int32.Parse(txtmabn.Text);
            mabn--;
            DataTable dt = new DataTable();
            dt = TTnhanvientheoMaBN(mabn);
            DataTable dt2 = new DataTable();
            dt2 = BENHNHANDAO.TTBenhnhan();
            int sobn = dt2.Rows.Count;
            int soxn = dt.Rows.Count;
            int dem = mabn - 2712;
            for (int i = 0; i < soxn; i++)
            {
                txtmabn.Text = mabn.ToString();
                txttenbn.Text = dt.Rows[i][1].ToString();
                txtngaysinhtuoi.Text = dt.Rows[i][2].ToString(); ;
                txtdiachi.Text = dt.Rows[i][3].ToString(); ;
                cbbscd.Text = dt.Rows[i][4].ToString(); ;
                txtchuandoan.Text = dt.Rows[i][5].ToString(); ;
                //dtpngayxn.Text = dt.Rows[i][6].ToString(); 
                txtstt.Text = dem + "/" + sobn;
            }
            DataTable dt1 = new DataTable();
            dt1 = TTKetquatheoMaBN(mabn);
            int soxn1 = dt1.Rows.Count;
            for (int i = 0; i < soxn1; i++)
            {
                lstketqua.Items.Add(dt1.Rows[i][0].ToString());
                lstketqua.Items[i].SubItems.Add(dt1.Rows[i][1].ToString());
                lstketqua.Items[i].SubItems.Add(dt1.Rows[i][2].ToString());
                lstketqua.Items[i].SubItems.Add(dt1.Rows[i][3].ToString());
                lstketqua.Items[i].SubItems.Add(dt1.Rows[i][4].ToString());
            }

            //Tinh tien
            int mabn1 = Int32.Parse(txtmabn.Text);
            DataTable dta = new DataTable();
            dta = BENHNHANDAO.TTGiatien(mabn1);
            int sotien = dta.Rows.Count;
            for (int i = 0; i < sotien; i++)
            {
                label11.Text = dta.Rows[i][0].ToString();
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void butthem_Click(object sender, EventArgs e)
        {
            BENHNHANDTO bn = new BENHNHANDTO();
            bn.mabn = txtmabn.Text;
            bn.hoten = txttenbn.Text;
            bn.namsinh = txtngaysinhtuoi.Text;
            bn.diachi = txtdiachi.Text;
            bn.sdt = txtdienthoai.Text;
            bn.chuandoan = txtchuandoan.Text;
            bn.bscd = cbbscd.Text;
            bn.ngayxn = dtpngayxn.Value.ToString("MM/dd/yyy");
            MessageBox.Show("Thêm thành công");
            //txtdiachi.Text = BENHNHANDAO.ThemNV(bn);
            // MessageBox.Show();
            BENHNHANDAO.ThemNV(bn);
        }
        public void Loadcombobox()
        {
            DataTable dc = new DataTable();
            dc = BENHNHANDAO.TTBSCD();
            cbbscd.DataSource = dc;
            cbbscd.DisplayMember = "BSCD";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BENHNHANDAO.MaBn_LN();
            string mbn = dt.Rows[0][0].ToString();
            int a = Int32.Parse(mbn.ToString());
            a++;

            txtmabn.Text = a.ToString();
            txttenbn.Text = "";
            txtchuandoan.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtngaysinhtuoi.Text = "";
            dtpngayxn.Text = "";
            lstketqua.Items.Clear();
            Loadcombobox();
        }
        private void butin_Click(object sender, EventArgs e)
        {
            /*int vt = lstxetnghiem.SelectedIndices[0];
            string aa;
            aa = lstxetnghiem.Items[vt].SubItems[0].Text;
            string sqlma = "select MaXN from XETNGHIEM where tenXN = '" + aa + "'";
            DataTable dt1 = new DataTable();
            dt1 = KNCSDL.docdulieu(sqlma);
            MessageBox.Show(sqlma);
            string sql = "UPDATE Ketqua SET Ketqua='"+txtketqua.Text+"' where MaXN='"+dt1.Rows[0][0].ToString()+"' and MaBN='"+txtmabn.Text+"'";
            KNCSDL.thucthitruyvan(sql);
            MessageBox.Show("Cập nhật xét nghiệm cho bệnh nhân " + txttenbn.Text + " thành công");
            Load_lai();*/
            string sql = "update BenhNhan set Hoten='" + txttenbn.Text + "',Namsinh='" + txtngaysinhtuoi.Text + "',Diachi='" + txtdiachi.Text + "', Dienthoai ='" + txtdienthoai.Text + "',Chuandoan='" + txtchuandoan.Text + "' ,BSCD='" + cbbscd.Text + "'  where MaBN='" + txtmabn.Text + "'";


            
            KNCSDL.thucthitruyvan(sql);

            MessageBox.Show("Cập nhật xét nghiệm cho bệnh nhân " + txttenbn.Text + " thành công");
            Load_lai();

        }

        private void butxembanintruoc_Click(object sender, EventArgs e)
        {
            string MaBN = txtmabn.Text;
            Database db;
            db = new Database(@"DESKTOP-76E8ESQ\CLIENT4", "QLPKT");
            string sql = "select DISTINCT k.MaBN, B.Hoten, X.TenXN, K.Ketqua, B.BSCD, B.NgayXN, B.Chuandoan from Xetnghiem X, BenhNhan B, Ketqua K where B.MaBN = K.MaBN and B.MaBN = '"+MaBN+"' and X.MaXN = K.MaXN "+";"+ "Select tongtien=SUM(GiaTien) FROM  Ketqua k,Xetnghiem x where MaBN='"+MaBN+"' and k.MaXN=x.MaXN ";
            DataTable dt = db.Execute(sql);
            CrystalReportINKHACHHANG cry = new CrystalReportINKHACHHANG();
            cry.SetDataSource(dt);
            FormIN f = new FormIN();
            f.crystalReportViewer2.ReportSource = cry;
            f.ShowDialog();

            int mabn1 = Int32.Parse(txtmabn.Text);
            DataTable dta = new DataTable();
            dta = BENHNHANDAO.TTGiatien(mabn1);
            int sotien = dta.Rows.Count;
            for (int i = 0; i < sotien; i++)
            {
                label11.Text = dta.Rows[i][0].ToString();
            }
        }

        private void butxuatfilepdf_Click(object sender, EventArgs e)
        {
            string MaBN = txtmabn.Text;
            Database db;
            db = new Database(@"DESKTOP-76E8ESQ\CLIENT4", "QLPKT");
            string sql = "select DISTINCT k.MaBN, B.Hoten, X.TenXN, K.Ketqua, B.BSCD, B.NgayXN, B.Chuandoan from Xetnghiem X, BenhNhan B, Ketqua K where B.MaBN = K.MaBN and B.MaBN = '" + MaBN + "' and X.MaXN = K.MaXN " + ";" + "Select tongtien=SUM(GiaTien) FROM  Ketqua k,Xetnghiem x where MaBN='" + MaBN + "' and k.MaXN=x.MaXN ";
            DataTable dt = db.Execute(sql);
            CrystalReportINKHACHHANG cry = new CrystalReportINKHACHHANG();
            cry.SetDataSource(dt);
            FormIN f = new FormIN();
            f.crystalReportViewer2.ReportSource = cry;

            cry.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"D:\"+txtmabn.Text+".pdf");
            MessageBox.Show("Đã xuất file PDF ở ổ đĩa D");
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            lstketqua.Items.Clear();
            string sql;
            sql = "select DISTINCT MaBN,Hoten,Namsinh,Diachi,Dienthoai,Chuandoan,BSCD,NgayXN from BenhNhan where MaBN like '" + txttim.Text + "%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.docdulieu(sql);
            int SL = dt.Rows.Count;
            for (int i = 0; i < SL; i++)
            {
                lstketqua.Items.Add(dt.Rows[i][0].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][5].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][6].ToString());
                lstketqua.Items[i].SubItems.Add(dt.Rows[i][7].ToString());
            }
        }

        private void butinkqxn_Click(object sender, EventArgs e)
        {
            /*string MaBN = txtmabn.Text;
            Database db;
            db = new Database(@"DESKTOP-76E8ESQ\CLIENT4", "QLPKT");
            string sql = "select DISTINCT k.MaBN, B.Hoten, X.TenXN, B.BSCD, B.NgayXN, X.GiaTien from Xetnghiem X, BenhNhan B, Ketqua K where B.MaBN = K.MaBN and B.MaBN = '"+txtmabn.Text+"' and X.MaXN = K.MaXN";
            DataTable dt = db.Execute(sql);
            CrystalReportINKETQUAXETNGHIEM cry = new CrystalReportINKETQUAXETNGHIEM();
            cry.SetDataSource(dt);
            INKETQUAXETNGHIEM f1 = new INKETQUAXETNGHIEM();
            f1.crystalReportViewerINKETQUAXETNGHIEM.ReportSource = cry;
            

            int mabn1 = Int32.Parse(txtmabn.Text);
            DataTable dta = new DataTable();
            dta = BENHNHANDAO.TTGiatien(mabn1);
            int sotien = dta.Rows.Count;
            for (int i = 0; i < sotien; i++)
            {
                label11.Text = dta.Rows[i][0].ToString();
            }

            string MaBN = txtmabn.Text;
            Database db;
            db = new Database(@"DESKTOP-76E8ESQ\CLIENT4", "QLPKT");
            string sql = "select DISTINCT k.MaBN, B.Hoten, X.TenXN, K.Ketqua, B.BSCD, B.NgayXN, B.Chuandoan from Xetnghiem X, BenhNhan B, Ketqua K where B.MaBN = K.MaBN and B.MaBN = '" + MaBN + "' and X.MaXN = K.MaXN " + ";" + "Select tongtien=SUM(GiaTien) FROM  Ketqua k,Xetnghiem x where MaBN='" + MaBN + "' and k.MaXN=x.MaXN ";
            DataTable dt = db.Execute(sql);
            CrystalReportINKHACHHANG cry = new CrystalReportINKHACHHANG();
            cry.SetDataSource(dt);
            FormIN f = new FormIN();
            f.crystalReportViewer2.ReportSource = cry;
            
            cry.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            cry.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            cry.PrintToPrinter(4, false, 6, 1);
            FRM_inbarcode fr = new FRM_inbarcode();
            fr.Show(); */
            string sql = "Delete  BenhNhan where MaBN='" + txtmabn.Text + "'";
            Database.ThucThiTuyVan(sql);
            MessageBox.Show("Xóa bệnh nhân " + txttenbn.Text + " thành công");
            Load_lai();
            txttenbn.Text = "";
            txtngaysinhtuoi.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtchuandoan.Text = "";
            txtmabn.Text = "";
            cbbscd.Text = "";
            dtpngayxn.Text = "";


        }

        private void lstxetnghiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int vt = lstxetnghiem.SelectedIndices[0];
            string aa;
            aa = lstxetnghiem.Items[vt].SubItems[0].Text;
            string sqlma = "select MaXN from XETNGHIEM where tenXN = '" + aa + "'";
            DataTable dt1 = new DataTable();
            dt1 = KNCSDL.docdulieu(sqlma);
           string sql = "insert into Ketqua(MaBN,MaXN,Ketqua) values ('" + txtmabn.Text + "','" + dt1.Rows[0][0].ToString() +"','" + txtketqua.Text +"')";  
            KNCSDL.thucthitruyvan(sql);           
            MessageBox.Show("Thêm xét nghiệm cho bệnh nhân "+txttenbn.Text+" thành công");
            Load_lai();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "MÃ XN";
                    ws.Cells[1, 2] = "Tên XN";
                    ws.Cells[1, 3] = "KẾT QUẢ";
                    ws.Cells[1, 4] = "ĐƠN VỊ";
                    ws.Cells[1, 5] = "CHỈ SỐ";
                   

                    int i = 2;
                    foreach (ListViewItem item in lstketqua.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                       

                        i++;
                    }
                    wb.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Đã xuất '"+txttenbn.Text+"' file Excel", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstketqua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstketqua_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

