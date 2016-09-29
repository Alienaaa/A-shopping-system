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
    public partial class Items : Form
    {
        ImageList itemimglist;
        static int num;
        double  total=0;
        public Items(ImageList imglist,int i)
        {
            InitializeComponent();
            itemimglist = imglist;
            num = i;
            
            
        }

        private void Items_Load(object sender, EventArgs e)
        {
            string strPath = Application.StartupPath + "\\Database.accdb";
            string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
            OleDbConnection conn = new OleDbConnection(ConStr);
            DataTable dt = new DataTable();
            OleDbDataAdapter OleDat = new OleDbDataAdapter("select * from Goods",conn);
            OleDat.Fill(num, num + 1, dt);

            Global_tz_Goods.Wareid = Convert.ToInt32(dt.Rows[0][0]);

            Global_tz_Goods.Warename = dt.Rows[0][1].ToString();
            Global_tz_Goods.Waretype = dt.Rows[0][2].ToString();
            Global_tz_Goods.Costprice = Convert.ToDouble(dt.Rows[0][3]);
            Global_tz_Goods.Wareprice = Convert.ToDouble(dt.Rows[0][4]);
            
            Global_tz_Goods.Warenum = Convert.ToInt32(dt.Rows[0][5]);
            Global_tz_Goods.Warerecom = Convert.ToInt32(dt.Rows[0][6]);
            Global_tz_Goods.Wareremark = dt.Rows[0][7].ToString();
       
            
            if (num < itemimglist.Images.Count)
            {
                ItemNameLabel.Text += Global_tz_Goods.Warename;
                ItemClasslabel.Text += Global_tz_Goods.Waretype;
                ItemPricelabel.Text += Global_tz_Goods.Wareprice;
                recomlabel.Text += Global_tz_Goods.Warerecom;
                ItemDescriptionlabel.Text += Global_tz_Goods.Wareremark;
                axShockwaveFlash1.Movie = Application.StartupPath + @"\Flower animation.swf";
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BackgroundImage = itemimglist.Images[num];
                
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            TotalPriceLabel.Text="商品总价:";
            int itemnum=Convert.ToInt32(numericUpDown1.Value);
            double price = Global_tz_Goods.Wareprice;
            double total = itemnum*price;
            TotalPriceLabel.Text +=total;
            this.total = total;
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            Global.PriceInTotal += this.total;
           // Global.Itemname[num] =ItemNameLabel.Text;
            if (Convert.ToInt32(numericUpDown1.Value) ==0)
            {
                MessageBox.Show("不可以购买0个！", "提示");
            }
            else
            {
                if (Global.statu == 1)
                    MessageBox.Show("请先返回主页登录！", "提示");
                else
                {
                    string strPath = Application.StartupPath + "\\Database.accdb";
                    string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
                    OleDbConnection conn = new OleDbConnection(ConStr);
                    conn.Open();
                    StringBuilder strSQL = new StringBuilder();
                    strSQL.Append("insert into Orders(userName,goodsName,salePrice,Profit,categories,orderNum,orderRemark)");
                    strSQL.Append("values('" + Global.Name + "','" + Global_tz_Goods.Warename + "','" + Global_tz_Goods.Wareprice + "','" + (Global_tz_Goods.Wareprice - Global_tz_Goods.Costprice) + "','" + Global_tz_Goods.Waretype + "','");
                    strSQL.Append(Convert.ToInt32(numericUpDown1.Value) + "','" + remark.Text.Trim() + "')");
                    Global_tz_User.Credit = Convert.ToInt32(new OleDbCommand("select userCredit from Users where userName='"+Global.Name+"'", conn).ExecuteScalar());
                    Global_tz_User.Credit += Convert.ToInt32(this.total);
                    String strSQL2 = "update Users set userCredit = " + Global_tz_User.Credit + " where userName='" + Global.Name + "'";
                    new OleDbCommand(strSQL2, conn).ExecuteScalar();
                    using (OleDbCommand cmd = new OleDbCommand(strSQL.ToString(), conn))
                    {
                        

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("订购商品成功！", "提示");
                        conn.Close();
                        cmd.Dispose();
                    }
                    this.Close();
                }
                
            }

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            TotalPriceLabel.Text = "商品总价:";
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tuijian_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void tuijian_CheckedChanged(object sender, EventArgs e)
        {
            string strPath = Application.StartupPath + "\\Database.accdb";
            string ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + strPath;
            OleDbConnection conn = new OleDbConnection(ConStr);
            conn.Open();
            Global_tz_Goods.shoucang = Convert.ToInt32(new OleDbCommand("select goodsRecom from Goods where goodsName='" + Global_tz_Goods.Warename + "'", conn).ExecuteScalar());


            if (tuijian.Checked == true)
            {
                Global_tz_Goods.shoucang++;
                recomlabel.Text = "推荐：" + Global_tz_Goods.shoucang;
                MessageBox.Show("已推荐商品！", "提示");

            }
            else if (tuijian.Checked == false)
            {
                Global_tz_Goods.shoucang--;
                recomlabel.Text = "推荐：" + Global_tz_Goods.shoucang;
                MessageBox.Show("已取消推荐商品！", "提示");
            }
            String strSQL = "update Goods set goodsRecom = " + Global_tz_Goods.shoucang + " where goodsName='" + Global_tz_Goods.Warename + "'";
            new OleDbCommand(strSQL, conn).ExecuteScalar();
            conn.Close();
        }
    }
}
