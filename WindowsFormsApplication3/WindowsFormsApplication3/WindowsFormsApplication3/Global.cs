using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Global
    {
        public static string Name = "";
        public static string Code = "";

        public static int statu;

        public static double  PriceInTotal = 0;

        public static string[] Itemname = { "", "", "", "", "", "", "", "", "" };

    }
    class Global_tz_Goods
    {
        public static int Wareid;
        public static int Warenum;
        public static int Warerecom;
        public static string Wareremark;
        public static string Warename;
        public static double Costprice;
        public static double Wareprice;
        public static string Waretype;
        public static string Wareintro;
        public static string Wareimagepath;
        public static int shoucang;
    }
    class Global_tz_User
    {
        public static int Userid;
        public static string Username;
        public static string Rname;
        public static string Userpass;
        public static string Email;
        public static string Address;
        public static string Tel;
        public static int Credit;
    }
    class Global_tz_Text
    {
        public static int Textid;
        public static string Username;
        public static string Email;
        public static string Datetime;
        public static string Textname;
        public static string Textgut;
    }
    class Global_tz_Sub
    {
        public static string Sub;
        public static string Username;
        public static string Rname;
        public static string Spdate;
        public static string Email;
        public static string Address;
        public static string Post;
        public static string Payment;
        public static string Phone;
        public static string Carry;
    }
    class Global_tz_Shop
    {
        public static string Subid;
        public static string Warename;
        public static double Price;
        public static double Wsum;
        public static double Wcount;
    }
    class Global_tz_Admin
    {
        public static int Aid;
        public static string Admin;
        public static string Adminpass;
    }
    class Global_tz_Affiche
    {
        public static string Test;
        public static string Datetime;

    }
    class Global_tz_Profit
    {
        public static string Warename;
        public static double Price;
        public static string Waretype;
        public static int Wareid;
        public static double OriginPrice;
        public static double Profit;
    }

    
}
