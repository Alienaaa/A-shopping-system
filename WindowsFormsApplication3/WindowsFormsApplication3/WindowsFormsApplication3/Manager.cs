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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
           

        }

        private void fankui_Click(object sender, EventArgs e)
        {
            string strPath = Application.StartupPath + "\\Database.accdb";
            string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
            OleDbConnection conn = new OleDbConnection(ConStr);
            string sql = "select feedbackID as 反馈ID,userName as 用户名,feedbacktxt as 反馈信息" +
                " from Feedback";
           
            conn.Open();

            OleDbDataAdapter adp = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void jinhuo_Click(object sender, EventArgs e)
        {
            string strPath = Application.StartupPath + "\\Database.accdb";
            string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
            OleDbConnection conn = new OleDbConnection(ConStr);
            string sql = "select goodsID as 商品ID,goodsName as 商品名称,costPrice as 进货价, salePrice as 销售价, goodsNum as 数量" +
                " from Goods";

            conn.Open();

            OleDbDataAdapter adp = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void xiaoshou_Click(object sender, EventArgs e)
        {
            string strPath = Application.StartupPath + "\\Database.accdb";
            string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
            OleDbConnection conn = new OleDbConnection(ConStr);
            string sql = "select orderID as 商品ID,userName as 用户名称,goodsName as 商品名称,salePrice as 销售价,orderNum as 数量, Profit*orderNum as 利润" +
                " from Orders";

            conn.Open();

            OleDbDataAdapter adp = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void yonghu_Click(object sender, EventArgs e)
        {
            string strPath = Application.StartupPath + "\\Database.accdb";
            string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
            OleDbConnection conn = new OleDbConnection(ConStr);
            string sql = "select userID as 用户ID,userName as 用户名称,userEmail as 用户邮箱,userTel as 用户电话,userCredit as 用户积分" +
                " from Users";

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
