using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WindowsScreenLock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.MaximizeBox = false;//使最大化窗口失效
            this.MinimizeBox = false;//使最大化窗口失效
                                     //下一句用来禁止对窗口大小进行拖拽
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            InitializeComponent();
            //透明背景
            TouMingBg();
        }

        private bool lockScreen = false;


        [DllImport("user32 ")]//引入API函数  
        public static extern bool LockWorkStation();//调用windows的系统锁定 

        private void button1_Click(object sender, EventArgs e)
        {
            if (lockScreen == false)
            {
                LockWorkStation();
                QuitGameObject();
            }
            lockScreen = true;
        }



        private void QuitGameObject()
        {
            Thread.Sleep(1000);
            Application.ExitThread();

        }
        private void TouMingBg()
        {
            ///设置透明
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Blue;
            this.TransparencyKey = BackColor;

        }

    }
}
