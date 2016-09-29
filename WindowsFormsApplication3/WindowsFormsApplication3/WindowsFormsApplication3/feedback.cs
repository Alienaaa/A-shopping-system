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
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void feedback_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string strPath = Application.StartupPath + "\\Database.accdb";
             string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
             OleDbConnection conn = new OleDbConnection(ConStr);
            if (Global.statu == 2)
            {
               

                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("insert into Feedback(userName,feedbacktxt)");
                strSQL.Append("values('" + Global.Name + "','" + feed.Text.Trim() +  "')");
            
                using (OleDbCommand cmd = new OleDbCommand(strSQL.ToString(), conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("发送成功！");
                    conn.Close();
                    cmd.Dispose();
                }
                this.Close();

            }
            else if (Global.statu == 1)
            {
                
                StringBuilder strSQL = new StringBuilder();
                strSQL.Append("insert into Feedback(userName,feedbacktxt)");
                strSQL.Append("values('" + "匿名" + "','" + feed.Text.Trim() +  "')");
            
                using (OleDbCommand cmd = new OleDbCommand(strSQL.ToString(), conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("发送成功！");
                    conn.Close();
                    cmd.Dispose();
                }
                this.Close();
            }
                
            else if (Global.statu == 3)
                MessageBox.Show("您是管理员，不可发送反馈！"); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                    feed.Text = string.Empty;
                
            
        }
    }
}
