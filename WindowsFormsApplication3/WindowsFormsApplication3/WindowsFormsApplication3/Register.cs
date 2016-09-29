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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text.Trim() == "" || PasswordtextBox.Text.Trim() == "" || EmailtextBox.Text.Trim() == "" || TeltextBox.Text.Trim() == "" || ConfirmtextBox.Text.Trim() == "")
            {
                MessageBox.Show("请将信息输入完整！", "提示");
            }
            else if(ConfirmtextBox.Text != PasswordtextBox.Text)
            {
                MessageBox.Show("密码不一致！", "提示");
            }
            else
            {
                string strPath = Application.StartupPath + "\\Database.accdb";
                string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
                OleDbConnection conn = new OleDbConnection(ConStr);

                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("insert into Users(userName,userCode,userEmail,userTel,userCredit)");
                strSQL.Append("values('" + NametextBox.Text.Trim() + "','" + PasswordtextBox.Text.Trim() + "','");
                strSQL.Append(EmailtextBox.Text.Trim() + "','" + TeltextBox.Text.Trim() + "','" + Convert.ToInt32(0) + "')");
                using (OleDbCommand cmd = new OleDbCommand(strSQL.ToString(), conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("注册成功，感谢您注册本店！", "提示");
                    conn.Close();
                    cmd.Dispose();
                }
                this.Close();
            }
           

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
