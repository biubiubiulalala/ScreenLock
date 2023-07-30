using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsScreenLock
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool runInstance;
            System.Threading.Mutex m = new System.Threading.Mutex(true, Application.ProductName, out runInstance);


            if (runInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

            }
            else
            {
                //MessageBox.Show(null, "已经有一个程序在跑了，不要重复运行哦。。。\n\n点击确定退出。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Application.Exit();//退出程序   
            }
        }
    }
}
