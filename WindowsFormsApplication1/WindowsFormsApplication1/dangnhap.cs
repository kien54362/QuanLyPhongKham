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
    public partial class dangnhap : Form
    {
        private Database db = new Database();
        SqlConnection cnn = null;
        public dangnhap()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked==true)
                    {
                    try
                    {
                        string tk = txttendn.Text;
                        string mk = txtmk.Text;
                        if (String.IsNullOrEmpty(tk) || String.IsNullOrEmpty(mk))
                        {
                            MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống", "Thông báo");
                            return;
                        }
                        string sql = $"Select * from DN where TENDN='{tk}'and MK='{mk}'";
                        SqlCommand cmd = new SqlCommand(sql, cnn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read() == true)
                        {
                            Hide();

                            FRM_trangchu dn = new FRM_trangchu();
                            dn.ShowDialog();
                            //dn.tk = tk;
                            Close();
                        }
                        else MessageBox.Show("Tên đăng nhập và mật khẩu chưa đúng vui lòng nhập lại", "Thông báo");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ket noi khong thanh cong!!");
                    }

                }
                if (checkBox2.Checked == true)
                {
                    try
                    {
                        string tk = txttendn.Text;
                        string mk = txtmk.Text;
                        if (String.IsNullOrEmpty(tk) || String.IsNullOrEmpty(mk))
                        {
                            MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống", "Thông báo");
                            return;
                        }
                        string sql = $"Select * from DN2 where TENDN2='{tk}'and MK2='{mk}'";
                        SqlCommand cmd = new SqlCommand(sql, cnn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read() == true)
                        {
                            Hide();

                            FRM_Trangchu2 dn = new FRM_Trangchu2();
                            dn.ShowDialog();
                            //dn.tk = tk;
                            Close();
                        }
                        else MessageBox.Show("Tên đăng nhập và mật khẩu chưa đúng vui lòng nhập lại", "Thông báo");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ket noi khong thanh cong!!");
                    }

                }

                if (checkBox3.Checked == true)
                {
                    try
                    {
                        string tk = txttendn.Text;
                        string mk = txtmk.Text;
                        if (String.IsNullOrEmpty(tk) || String.IsNullOrEmpty(mk))
                        {
                            MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống", "Thông báo");
                            return;
                        }
                        string sql = $"Select * from DN3 where TENDN3='{tk}'and MK3='{mk}'";
                        SqlCommand cmd = new SqlCommand(sql, cnn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read() == true)
                        {
                            Hide();

                            FRM_Trangchu3 dn = new FRM_Trangchu3();
                            dn.ShowDialog();
                            //dn.tk = tk;
                            Close();
                        }
                        else MessageBox.Show("Tên đăng nhập và mật khẩu chưa đúng vui lòng nhập lại", "Thông báo");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ket noi khong thanh cong!!");
                    }

                }
                else
                {
                    MessageBox.Show("vui lòng chọn vai trò để đăng nhập");
                }

            }
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            txtmk.UseSystemPasswordChar = true;
            cnn = db.Connected();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtmk.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtmk.UseSystemPasswordChar = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            if (checkBox1.Checked==false)
            {
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = false;
            checkBox3.Visible = false;
            if (checkBox2.Checked == false)
            {
                checkBox1.Visible = true;
                checkBox3.Visible = true;
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBox2.Visible = false;
            checkBox1.Visible = false;
            if (checkBox3.Checked == false)
            {
                checkBox2.Visible = true;
                checkBox1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
