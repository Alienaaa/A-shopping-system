using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        /// 
        //class manager
        //{
        //    public string mname;
        //    public string mpassword;
        //    public string memail;
        //    public string mtel;
        //    static int mstatu = 3;

        //}
        //class user
        //{
        //    public string uname;
        //    public string upassword;
        //    public string uemail;
        //    public string utel;
        //    static int ustatu = 2;

        //}
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
