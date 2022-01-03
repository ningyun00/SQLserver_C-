using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 图书管理系统
{
    static partial class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        class Data
        {
            public static string Uname = "";//用户名
        }
    }
}
