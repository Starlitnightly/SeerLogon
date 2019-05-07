using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using dmNet;
using C_DM;

namespace 星小夜的登录器
{
   
    public partial class MainForm : Form
    {

        const int GW_CHILD = 5;
        const int GW_HWNDNEXT = 2;

        

        static CancellationTokenSource confirmcts = new CancellationTokenSource();
        static TaskFactory confirm = new TaskFactory(confirmcts.Token);//确认按钮线程
        static CancellationTokenSource scriptcts = new CancellationTokenSource();
        static TaskFactory script = new TaskFactory(scriptcts.Token);//脚本线程
        
       


        static object x, y;//坐标

        
        static C_DmSoft dm;//免注册调用大漠类

        public MainForm()//本窗口类初始化
        {
            InitializeComponent();
            //SetDllPathA("C:\\Users\\FernandoZeng\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\bin\\Debug\\dm.dll", 0);//注册大漠插件
            dm = new C_DmSoft();
            dm.SetPath(Application.StartupPath + "\\dm");//设置大漠图片，字库路径

        }

        private void Form1_Load(object sender, EventArgs e)//窗口载入完成后事件
        {
            Delay(1000);//延迟1s防止大漠绑定失败
            int pid;
            pid = Getseerhwnd2();
            dm.BindWindow(pid, "dx2", "windows", "windows", 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pid;
            pid = Getseerhwnd2();
            dm.BindWindow(pid, "dx2", "windows", "windows", 0);
        }//无

        private void button2_Click(object sender, EventArgs e)//打开精灵王脚本
        {
            Kingscript.Enabled = true;
            
        }
        private void button3_Click(object sender, EventArgs e)//停止各类脚本
        {
            if (Kingscript.Enabled == true)
            {
                Kingscript.Enabled = false;
                if(scriptcts.IsCancellationRequested==false)
                    scriptcts.Dispose();
            }//如果精灵王脚本开启则停止
            if (Comscripts.Enabled == true)
            {
                Comscripts.Enabled = false;
                if (scriptcts.IsCancellationRequested == false)
                    scriptcts.Dispose();
            }//如果巅峰脚本开启则停止
            
            
        }
        private void button4_Click(object sender, EventArgs e)//刷新网页
        {
            webBrowser1.Url = new Uri("http://seer.61.com/play.shtml");
        }

       
        
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//自动确认选择框
        {
            if (checkBox1.Checked == false)
            {
                Autoconfirmation.Enabled = false;
                if (confirmcts.IsCancellationRequested == false)
                    confirmcts.Dispose();
            }

            else
            {
                Autoconfirmation.Enabled = true;
                if (confirmcts.IsCancellationRequested == false)
                    confirmcts.Dispose();
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        { }
        private void timer1_Tick(object sender, EventArgs e)//自动确认定时器
        {
            
            var confirmtask = confirm.StartNew(() => Confirmbutton());
            confirmcts.Dispose();
            Application.DoEvents();
            Delay(100);
        }
        private void Comscripts_Tick(object sender, EventArgs e)//竞技脚本定时器
        {
            //var confirmtask = confirm.StartNew(() => Confirmbutton());
            //confirmcts.Dispose();
            var clickpeaktask = script.StartNew(() => PeakComScript());
            //scriptcts.Dispose();            
            Application.DoEvents();
            Delay(500);
        }

        private void Kingscript_Tick(object sender, EventArgs e)//精灵王脚本定时器
        {
            var confirmtask = confirm.StartNew(() => Confirmbutton());
            confirmcts.Dispose();
            var Thekingtask = script.StartNew(() => ThekingofPetscript());
            scriptcts.Dispose();
            Application.DoEvents();
            Delay(500);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nowskill = "第一";
            Comscripts.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)//窗口即将销毁时
        {
            dm.UnBindWindow();
            Application.Exit();
        }

        
    }
}
