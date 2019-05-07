using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using dmNet;


namespace 星小夜的登录器
{
    public partial class MainForm : Form
    {
        
        
        int Getseerhwnd2()//获取窗口句柄
        {
            int hwnd = 0;
            hwnd = FindWindowExA(0, 0, "WindowsForms10.Window.8.app.0.141b42a_r10_ad1", "Form1");
            hwnd = GetWindow1(hwnd, GW_CHILD);
            hwnd = GetWindow1(hwnd, GW_HWNDNEXT);
            hwnd = GetWindow1(hwnd, GW_HWNDNEXT);
            hwnd = GetWindow1(hwnd, GW_HWNDNEXT);
            hwnd = GetWindow1(hwnd, GW_HWNDNEXT);
            hwnd = GetWindow1(hwnd, GW_HWNDNEXT);
            hwnd = GetWindow1(hwnd, GW_CHILD);
            hwnd = GetWindow1(hwnd, GW_CHILD);
            hwnd = GetWindow1(hwnd, GW_CHILD);
            hwnd = GetWindow1(hwnd, GW_CHILD);
            hwnd = GetWindow1(hwnd, GW_CHILD);
            return (hwnd);



        }

        
        private static void Delay(int Millisecond) //延迟系统时间，但系统又能同时能执行其它任务；
        {
            DateTime current = DateTime.Now;
            while (current.AddMilliseconds(Millisecond) > DateTime.Now)
            {
                Application.DoEvents();//转让控制权            
            }
            return;
        }
        static CancellationTokenSource cts1 = new CancellationTokenSource();
        static TaskFactory Peakscript1 = new TaskFactory(cts1.Token);//判断进入巅峰线程
        static CancellationTokenSource cts2 = new CancellationTokenSource();
        static TaskFactory Peakscript2 = new TaskFactory(cts2.Token);//ban三黑线程
        static CancellationTokenSource cts3 = new CancellationTokenSource();
        static TaskFactory Peakscript3 = new TaskFactory(cts3.Token);//自动克制系出战线程
        public static void Confirmbutton()//自动确认按钮
        {
            if (dm.FindPic(0, 0, 1000, 700, "战败确认.bmp|奖章确认.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
            }
            if (dm.FindPic(0, 0, 1000, 700, "防沉迷提示.bmp|防沉迷提示1.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
            }
            if (dm.FindPic(0, 0, 1000, 700, "超时确认.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
            }
            if (dm.FindPic(0, 0, 1000, 700, "胜利.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
            }
            if (dm.FindPic(0, 0, 1000, 700, "战败确认.bmp|奖章确认.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
            }

            Delay(1000);


        }

        public static void ClickThekingofpet()//精灵王装置点击
        {
            if (dm.FindPic(0, 0, 1000, 700, "jlwzz.bmp|jlwksld.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
            }
            if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
            {
                dm.MoveTo(40, 506);
                dm.LeftClick();
            }
        }

        public static void PeakComScript()//巅峰竞技脚本
        {
            if (dm.FindPic(0, 0, 1000, 1000, "巅峰.bmp", "000000", 0.8, 0, out x, out y) == -1)
            {
                if (dm.FindPic(0, 0, 1000, 1000, "圣战图标.bmp", "000000", 0.8, 0, out x, out y) != -1)
                {
                    dm.MoveTo((int)x+5, (int)y+5);
                    dm.LeftClick();
                }
            }
            if (dm.FindPicEx(0, 0, 1000, 1000, "巅峰.bmp|狂野.bmp|竞技.bmp|注意.bmp", "000000", 0.8, 0) != "-1|-1|-1")
            {
                var scripttask2=Peakscript1.StartNew(() => JudgePeak());
                cts1.Cancel();

            }
            if (dm.FindPicEx(0, 0, 1000, 1000, "ban.bmp", "000000", 0.8, 0) != "-1|-1|-1")
            {
                var scripttask2=Peakscript2.StartNew(() => Bans());
                cts2.Dispose();

            }
            if (dm.FindPic(0, 0, 1000, 1000, "×.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x + 5, (int)y + 5);
                dm.LeftClick();
            }
            Application.DoEvents();


        }

        public static void JudgePeak()//判断进入巅峰
        {
            if (dm.FindPic(0, 0, 1000, 1000, "巅峰.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x + 5, (int)y + 5);
                dm.LeftClick();
                for (int i = 0; i < 30; i++)
                {
                    if (dm.FindPic(0, 0, 1000, 1000, "竞技.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x + 5, (int)y + 5);
                        dm.LeftClick();
                        break;
                    }
                    Delay(100);
                }
                for (int i = 0; i < 30; i++)
                {
                    if (dm.FindPic(0, 0, 1000, 1000, "注意.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo(826, 488);
                        dm.LeftClick();
                        break;
                    }
                    Delay(100);
                }

            }
        }

        public static void Bans()//ban三黑
        {
            int bantimes = 0;
            if (dm.FindPic(480, 0, 1000, 1000, "大葱.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
                bantimes++;
            }
            if (dm.FindPic(480, 0, 1000, 1000, "光嘤.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
                bantimes++;
            }
            if (dm.FindPic(480, 0, 1000, 1000, "帝姬.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
                bantimes++;
            }
            if (dm.FindPic(480, 0, 1000, 1000, "星皇.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
                bantimes++;
            }
            if (dm.FindPic(480, 0, 1000, 1000, "天尊.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
                bantimes++;
            }
            if (dm.FindPic(480, 0, 1000, 1000, "banchongsheng.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y);
                dm.LeftClick();
                bantimes++;
            }
            if (bantimes >= 3)
            {
                for (int i = 0; i < 60; i++)
                {
                    if (dm.FindPic(480, 0, 1000, 1000, "确认.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x, (int)y);
                        dm.LeftClick();
                        break;
                    }
                }
            }
            else
            {
                dm.MoveTo(612, 268);
                dm.LeftClick();
                dm.MoveTo(712, 268);
                dm.LeftClick();
                dm.MoveTo(812, 268);
                dm.LeftClick();
                dm.MoveTo(912, 268);
                dm.LeftClick();
                for (int i = 0; i < 30; i++)
                {
                    if (dm.FindPic(480, 0, 1000, 1000, "确认.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x, (int)y);
                        dm.LeftClick();
                        break;
                    }
                }
            }
        }

        public static void AutoRestraint()//自动克制系出战
        {
            if (dm.FindPic(0, 0, 1000, 1000, "克制图片.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x + 5, (int)y + 5);
                dm.LeftClick();
                for (int i = 0; i < 30; i++)
                {
                    if (dm.FindPic(0, 0, 1000, 1000, "出战按钮.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x + 5, (int)y + 5);
                        dm.LeftClick();
                        break;
                    }
                }

            }else if (dm.FindPic(0, 0, 1000, 1000, "普通.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x + 5, (int)y + 5);
                dm.LeftClick();
                for (int i = 0; i < 30; i++)
                {
                    if (dm.FindPic(0, 0, 1000, 1000, "出战按钮.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x + 5, (int)y + 5);
                        dm.LeftClick();
                        break;
                    }
                }

            }else if (dm.FindPic(0, 0, 1000, 1000, "微弱.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x + 5, (int)y + 5);
                dm.LeftClick();
                for (int i = 0; i < 30; i++)
                {
                    if (dm.FindPic(0, 0, 1000, 1000, "出战按钮.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x + 5, (int)y + 5);
                        dm.LeftClick();
                        break;
                    }
                }

            }
            Application.DoEvents();

        }

        public static void ThekingofPetscript()//精灵王脚本
        {
            ClickThekingofpet();//点击精灵王装置


            var scripttask3=Peakscript3.StartNew(() => AutoRestraint());//克制系出战
            cts3.Dispose();

            Application.DoEvents();
            Delay(200);
        }

        public static void SelectionWizard()//出战精灵选择
        {
            if (dm.FindPic(0, 0, 1000, 600, "首发.bmp", "000000", 0.8, 0, out x, out y) != -1 || dm.FindPic(0, 0, 1000, 600, "出战.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                FirstEpisode();
                GotoWar();
                for (int i = 0; i < 10; i++)
                {
                    if (dm.FindPic(0, 0, 1000, 1000, "确认.bmp|确认1.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x, (int)y);
                        dm.LeftClick();
                        break;
                    }
                }
            }
        }

        public static void FirstEpisode()
        {

        }
        public static void GotoWar()
        {
            //bool IsSelection = false;
            if (dm.FindPic(469, 12, 958, 559, "禁用.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                Delay(1000);
                
                    if (dm.FindPic(0, 0, 600, 559, "sz.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x+5, (int)y+5);
                        dm.LeftClick();
                        //IsSelection = true;
                    }
                
            }
        }

    }
   

    
}
