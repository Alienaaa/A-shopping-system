using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication3
{
    public partial class Home : Form
    {
        static ImageList imageList  = new ImageList();
        static public string userName;
        static public string userCode;
        public Home()
        {
            InitializeComponent();
            
            
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
        
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Register register=new Register();
            register.Show();

           
            

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginButtson.Visible = false;
            WelcomeLink.Visible = false;
            LoginButtson.Visible = true;
            RegisterButtson.Visible = true;

            
            NameText.Enabled = true;
            NameText.Visible = true;
            NameText.Text = "Name";
            PasswordText.Enabled = true;
            PasswordText.Visible = true;
            PasswordText.UseSystemPasswordChar = false;
            PasswordText.Text = "Password";
            LogoutButton.Visible = false;
        }

        private void LoginButtson_Click(object sender, EventArgs e)
        {
            if (NameText.Text == "" || PasswordText.Text == "")
                MessageBox.Show("请将信息填写完整！");
            else
            {
                string strPath = Application.StartupPath + "\\Database.accdb";
                string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
                OleDbConnection conn = new OleDbConnection(ConStr);
                conn.Open();
                string strSQL = "select userName,userCode from users where userName='" + this.NameText.Text + "'and userCode='" + this.PasswordText.Text + "'";
                OleDbCommand cmd = new OleDbCommand(strSQL,conn);
                OleDbDataReader hyw = cmd.ExecuteReader();
                if (hyw.Read())
                {
                    Global.Name = NameText.Text;
                    Global.Code = PasswordText.Text;
                    WelcomeLink.Text = "Welcome:";

                    if (Global.Name == "Manager")
                        Global.statu = 3;
                    else
                        Global.statu = 2;

                    LoginButtson.Visible = false;
                    RegisterButtson.Visible = false;
                    WelcomeLink.Text += Global.Name;
                    WelcomeLink.Visible = true;
                    LogoutButton.Visible = true;

                    NameText.Enabled = false;
                    NameText.Visible = false;
                    PasswordText.Enabled = false;
                    PasswordText.Visible = false;
                }
                else
                {
                    MessageBox.Show("输入用户密码错误！");
                }

            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Items item = new Items(imageList,0);
            item.Show();

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            PasswordText.UseSystemPasswordChar = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Items item = new Items(imageList, 1);
            item.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Items item = new Items(imageList, 2);
            item.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Items item = new Items(imageList, 3);
            item.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Items item = new Items(imageList, 4);
            item.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Global.statu = 1;
            imageList.ImageSize=new Size(256,256);
            imageList.Images.Add("Finn_10", Image.FromFile("baile_color.jpg"));
            imageList.Images.Add("Iceking_20", Image.FromFile("baile_qx.jpg"));
            imageList.Images.Add("Jack_5", Image.FromFile("baile_rubber.jpg"));
            imageList.Images.Add("Merceline_100", Image.FromFile("ertong.jpg"));
            imageList.Images.Add("Princess Bubble Gum_150", Image.FromFile("paitong_qx.jpg"));
            imageList.Images.Add("Finn_10", Image.FromFile("paitong_rubber.jpg"));
            imageList.Images.Add("Iceking_20", Image.FromFile("sanling_qx.jpg"));
            imageList.Images.Add("Jack_5", Image.FromFile("sanling_rubber.jpg"));
            imageList.Images.Add("Merceline_100", Image.FromFile("shuirong.jpg"));
            imageList.Images.Add("Princess Bubble Gum_150", Image.FromFile("youxing.jpg"));
            imageList.Tag = "Adventuretime";
            pictureBox1.BackgroundImage = imageList.Images[0];
            pictureBox2.BackgroundImage = imageList.Images[1];
            pictureBox3.BackgroundImage = imageList.Images[2];
            pictureBox4.BackgroundImage = imageList.Images[3];
            pictureBox5.BackgroundImage = imageList.Images[4];
            pictureBox6.BackgroundImage = imageList.Images[5];
            pictureBox7.BackgroundImage = imageList.Images[6];
            pictureBox8.BackgroundImage = imageList.Images[7];
            pictureBox9.BackgroundImage = imageList.Images[8];
            pictureBox10.BackgroundImage = imageList.Images[9];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WelcomeLink_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Global.statu == 3)
            {
                Manager manager = new Manager();
                manager.Show();
            }
            else if (Global.statu == 2)
            {
                User user = new User();
                user.Show();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Items item = new Items(imageList, 6);
            item.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Items item = new Items(imageList, 7);
            item.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Items item = new Items(imageList, 8);
            item.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Items item = new Items(imageList, 9);
            item.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Items item = new Items(imageList, 10);
            item.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            feedback feedback = new feedback();
            feedback.Show();
        }
    }
}
