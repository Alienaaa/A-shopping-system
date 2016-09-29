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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            welcome.Text = welcome.Text+Global.Name+"，这是你的个人信息。";
            string strPath = Application.StartupPath + "\\Database.accdb";
            string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
            OleDbConnection conn = new OleDbConnection(ConStr);
            string sql = "select userID as 用户ID,userName as 用户名称,userEmail as 用户邮箱,userTel as 用户电话,userCredit as 用户积分" +
                " from Users" + " where userName='" + Global.Name + "'";

            conn.Open();

            OleDbDataAdapter adp = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button_user_Click(object sender, EventArgs e)
        {
            welcome.Text = "欢迎:" + Global.Name + "，这是你的个人信息。";
            string strPath = Application.StartupPath + "\\Database.accdb";
            string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
            OleDbConnection conn = new OleDbConnection(ConStr);
            string sql = "select userID as 用户ID,userName as 用户名称,userEmail as 用户邮箱,userTel as 用户电话,userCredit as 用户积分" +
                " from Users" + " where userName='" + Global.Name + "'";

            conn.Open();

            OleDbDataAdapter adp = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            welcome.Text = "欢迎:" + Global.Name + "，这是你已订购的商品。";
            string strPath = Application.StartupPath + "\\Database.accdb";
            string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
            OleDbConnection conn = new OleDbConnection(ConStr);
            string sql = "select goodsName as 商品名称,salePrice as 销售价,categories as 商品类别,orderNum as 订购数量,orderRemark as 备注" +
                " from Orders"+" where userName='"+Global.Name+"'";

            conn.Open();

            OleDbDataAdapter adp = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }
    }
}
