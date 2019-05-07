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
        
        
        private static int Getseerhwnd2()//获取窗口句柄
        {
            int hwnd = 0;
            hwnd = FindWindowExA(0, 0, "WindowsForms10.Window.8.app.0.141b42a_r10_ad1", "Form1");
            hwnd = GetWindow1(hwnd, GW_CHILD);
            hwnd = GetWindow1(hwnd, GW_HWNDNEXT);
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
        static CancellationTokenSource cts4 = new CancellationTokenSource();
        static TaskFactory Peakscript4 = new TaskFactory(cts4.Token);//无
        static CancellationTokenSource cts5 = new CancellationTokenSource();
        static TaskFactory Peakscript5 = new TaskFactory(cts5.Token);//出战界面线程
        static CancellationTokenSource cts6 = new CancellationTokenSource();
        static TaskFactory Peakscript6 = new TaskFactory(cts6.Token);//自动补pp线程

        static string Nowskill;
        static string Nowwizard;
        static string Nowwizardskill;
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
            
            if (dm.FindPic(0, 0, 1000, 1000, "操作超时.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo(489, 359);
                dm.LeftClick();
            }
            if (dm.FindPic(0, 0, 1000, 1000, "巅峰.bmp", "000000", 0.8, 0, out x, out y) == -1)
            {
                if (dm.FindPic(0, 0, 1000, 1000, "圣战图标.bmp", "000000", 0.8, 0, out x, out y) != -1)
                {
                    dm.MoveTo((int)x+5, (int)y+5);
                    dm.LeftClick();
                }
            }
            if (dm.FindPic(0, 0, 1000, 1000, "巅峰.bmp|狂野.bmp|竞技.bmp|注意.bmp", "000000",0.8,0,out x,out y) != -1)
            {
                var scripttask2=Peakscript1.StartNew(() => JudgePeak());
                cts1.Dispose();

            }
            if (dm.FindPic(0, 0, 1000, 1000, "ban.bmp", "000000", 0.8, 0,out x,out y) != -1)
            {
                var scripttask2=Peakscript2.StartNew(() => Bans());
                cts2.Dispose();

            }
            
            if (dm.FindPic(0, 0, 1000, 1000, "×.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x + 5, (int)y + 5);
                dm.LeftClick();
            }

            AutoRestraint();
            
            var scripttask3 = Peakscript3.StartNew(() => AutoRestraint());
            cts3.Dispose();

            if (dm.FindPic(0, 0, 1000, 1000, "首发.bmp|出战.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                var scripttask5 = Peakscript5.StartNew(() => SelectionWizard());
                cts5.Dispose();
            }
            
            StarlitSkill();
            Delay(1000);


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

        public static void FirstEpisode()//自动选择首发精灵
        {
            
            if (dm.FindPic(469, 12, 958, 559, "禁用.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                Delay(1000);

                if (dm.FindPic(0, 0, 600, 559, "pnsf.bmp", "000000", 0.8, 0, out x, out y) != -1)//谱尼
                {
                    dm.MoveTo((int)x + 5, (int)y + 5);
                    dm.LeftClick();
                }else if (dm.FindPic(0, 0, 600, 559, "gysf.bmp", "000000", 0.8, 0, out x, out y) != -1)//光嘤
                {
                    dm.MoveTo((int)x + 5, (int)y + 5);
                    dm.LeftClick();
                }else if (dm.FindPic(0, 0, 600, 559, "xwsf.bmp", "000000", 0.8, 0, out x, out y) != -1)//希瓦
                {
                    dm.MoveTo((int)x + 5, (int)y + 5);
                    dm.LeftClick();
                }else if (dm.FindPic(0, 0, 600, 559, "gwsf.bmp", "000000", 0.8, 0, out x, out y) != -1)//光王
                {
                    dm.MoveTo((int)x + 5, (int)y + 5);
                    dm.LeftClick();
                }else if(dm.FindPic(0, 0, 600, 559, "lh.bmp", "000000", 0.8, 0, out x, out y) != -1)//猎皇
                {
                    dm.MoveTo((int)x + 5, (int)y + 5);
                    dm.LeftClick();
                }else if (dm.FindPic(0, 0, 600, 559, "lhsf.bmp", "000000", 0.8, 0, out x, out y) != -1)//龙神哈莫
                {
                    dm.MoveTo((int)x + 5, (int)y + 5);
                    dm.LeftClick();
                }else if (dm.FindPic(0, 0, 600, 559, "pdl.bmp", "000000", 0.8, 0, out x, out y) != -1)//潘多拉
                {
                    dm.MoveTo((int)x + 5, (int)y + 5);
                    dm.LeftClick();
                }else if (dm.FindPic(0, 0, 600, 559, "sz.bmp", "000000", 0.8, 0, out x, out y) != -1)//索伦森
                {
                    dm.MoveTo((int)x + 5, (int)y + 5);
                    dm.LeftClick();
                }else if (dm.FindPic(0, 0, 600, 559, "zh.bmp", "000000", 0.8, 0, out x, out y) != -1)//战龙哈莫
                {
                    dm.MoveTo((int)x + 5, (int)y + 5);
                    dm.LeftClick();
                }

            }
        }

        public static void GotoWar()//自动选择出战精灵
        {
            if (dm.FindPic(11, 221, 112, 337, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//1
            {
                dm.MoveTo(11+25, 246);
                dm.LeftClick();
            }
            if (dm.FindPic(109, 221, 211, 337, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//2
            {
                dm.MoveTo(122 + 25, 246);
                dm.LeftClick();
            }
            if (dm.FindPic(211, 221, 307, 337, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//3
            {
                dm.MoveTo(211 + 25, 246);
                dm.LeftClick();
            }
            if (dm.FindPic(307, 221, 404, 337, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//4
            {
                dm.MoveTo(307 + 25, 246);
                dm.LeftClick();
            }
            if (dm.FindPic(11, 337, 112, 455, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//5
            {
                dm.MoveTo(11 + 25, 362);
                dm.LeftClick();
            }
            if (dm.FindPic(109, 337, 211, 455, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//6
            {
                dm.MoveTo(122 + 25, 362);
                dm.LeftClick();
            }
            if (dm.FindPic(211, 337, 307, 455, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//7
            {
                dm.MoveTo(211 + 25, 362);
                dm.LeftClick();
            }
            if (dm.FindPic(307, 337, 404, 455, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//8
            {
                dm.MoveTo(307 + 25, 362);
                dm.LeftClick();
            }
            if (dm.FindPic(11, 455, 112, 564, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//9
            {
                dm.MoveTo(11 + 25, 480);
                dm.LeftClick();
            }
            if (dm.FindPic(109, 455, 211, 564, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//10
            {
                dm.MoveTo(122 + 25, 480);
                dm.LeftClick();
            }
            if (dm.FindPic(211, 455, 307, 564, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//11
            {
                dm.MoveTo(211 + 25, 480);
                dm.LeftClick();
            }
            if (dm.FindPic(307, 455, 404, 564, "禁用.bmp|首发小图.bmp", "000000", 0.8, 0, out x, out y) == -1)//12
            {
                dm.MoveTo(307 + 25, 480);
                dm.LeftClick();
            }
        }

        public static void Fillingpp()//自动补pp
        {
            if (dm.FindPic(0, 0, 1000, 600, "道具.bmp", "000000", 0.8, 0, out x, out y) != -1 )
            {
                if (dm.FindPic(0, 300, 971, 570, "第五0.bmp", "000000", 0.8, 0, out x, out y) != -1 || dm.FindPic(14, 327, 971, 570, "0.bmp", "000000", 0.8, 0, out x, out y) != -1)
                {
                    dm.MoveTo(923, 450);
                    dm.LeftClick();
                }
                Delay(500);
                dm.MoveTo(206, 450);
                dm.LeftClick();
                for (int i = 0; i < 30; i++)
                {
                    if (dm.FindPic(0, 0, 1000, 600, "10PP药.bmp|5PP药.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x+5, (int)y+5);
                        dm.LeftClick();
                        break;
                    }
                }
            }
            
        }

        public static void Sprite()//换精灵时从克制，普通，微弱出战
        {
            if (dm.FindPic(0, 0, 1000, 600, "克制图片.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y+10);
                dm.LeftClick();
                for (int i = 0; i < 30; i++)
                {
                    if (dm.FindPic(0, 0, 1000, 600, "出战按钮.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x, (int)y);
                        dm.LeftClick();
                        break;
                    }
                }
            }else if (dm.FindPic(0, 0, 1000, 600, "普通.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y + 10);
                dm.LeftClick();
                for (int i = 0; i < 30; i++)
                {
                    if (dm.FindPic(0, 0, 1000, 600, "出战按钮.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x, (int)y);
                        dm.LeftClick();
                        break;
                    }
                }
            }else if (dm.FindPic(0, 0, 1000, 600, "微弱.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                dm.MoveTo((int)x, (int)y + 10);
                dm.LeftClick();
                for (int i = 0; i < 30; i++)
                {
                    if (dm.FindPic(0, 0, 1000, 600, "出战按钮.bmp", "000000", 0.8, 0, out x, out y) != -1)
                    {
                        dm.MoveTo((int)x, (int)y);
                        dm.LeftClick();
                        break;
                    }
                }
            }

        }

        public static void StarlitSkill()
        {
            bool iszero = false;
            if (dm.FindPic(0, 0, 1000, 600, "道具.bmp", "000000", 0.8, 0, out x, out y) != -1)
            {
                if (dm.FindPic(0, 300, 971, 570, "第五0.bmp", "000000", 0.8, 0, out x, out y) != -1 || dm.FindPic(14, 327, 971, 570, "0.bmp", "000000", 0.8, 0, out x, out y) != -1)
                {
                    iszero = true;
                    var scripttask6 = Peakscript6.StartNew(() => Fillingpp());
                    cts6.Dispose();
                }
            }
            if (iszero == false)
            {

                if (dm.FindPic(83, 9, 212, 100, "dqlh2.bmp | dqlh.bmp", "000000", 0.8, 0, out x, out y) != -1)//猎皇专属出招
                {
                    if (Nowwizard != "猎皇")
                        Nowwizardskill = "暗猎惊魂";
                    Nowwizard = "猎皇";

                    if (Nowwizardskill == "暗猎惊魂")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-aljh.bmp|jn-aljh2.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }
                    else if (Nowwizardskill == "第五")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowwizardskill = "暗猎惊魂";
                        }
                    }


                }
                else if (dm.FindPic(83, 9, 212, 100, "dpzlhm.bmp|dqzlhm.bmp", "000000", 0.8, 0, out x, out y) != -1)//战龙哈莫专属出招
                {
                    if (Nowwizard != "战龙哈莫")
                        Nowwizardskill = "龙威之姿";
                    Nowwizard = "战龙哈莫";

                    if (Nowwizardskill == "龙威之姿")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-lwzz.bmp|jn-lwzz2.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }
                    else if (Nowwizardskill == "第五")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowwizardskill = "龙威之姿";
                        }
                    }


                }
                else if (dm.FindPic(83, 9, 212, 100, "dpgwsjl.bmp|dqgw2.bmp", "000000", 0.8, 0, out x, out y) != -1)//光王斯嘉丽专属出招
                {
                    if (Nowwizard != "光王斯嘉丽")
                        Nowwizardskill = "纯白光羽";
                    Nowwizard = "光王斯嘉丽";

                    if (Nowwizardskill == "纯白光羽")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-cbgy.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }
                    else if (Nowwizardskill == "第五")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }


                }
                else if (dm.FindPic(83, 9, 212, 100, "dqpdl.bmp", "000000", 0.8, 0, out x, out y) != -1)//潘多拉专属出招
                {
                    if (Nowwizard != "潘多拉")
                        Nowwizardskill = "冥之孤傲";
                    Nowwizard = "潘多拉";

                    if (Nowwizardskill == "冥之孤傲")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-mzga.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "女王之厄";
                        }
                    }
                    else if (Nowwizardskill == "女王之厄")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-nwze.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }
                    else if (Nowwizardskill == "第五")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }


                }
                else if (dm.FindPic(83, 9, 212, 100, "dqsl.bmp|dqsl1.bmp", "000000", 0.8, 0, out x, out y) != -1)//圣霆雷伊专属出招
                {
                    if (Nowwizard != "圣霆雷伊")
                        Nowwizardskill = "电灵祝福";
                    Nowwizard = "圣霆雷伊";

                    if (Nowwizardskill == "电灵祝福")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-dlzf.bmp|jn-dlzf2.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "庇护之心";
                        }
                    }
                    else if (Nowwizardskill == "庇护之心")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-bhzx1.bmp|jn-bhzx3.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }
                    else if (Nowwizardskill == "第五")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }


                }
                else if (dm.FindPic(83, 9, 212, 100, "dqgy.bmp|dqgy1.bmp", "000000", 0.8, 0, out x, out y) != -1)//光之惩戒专属出招
                {
                    if (Nowwizard != "英卡洛斯")
                        Nowwizardskill = "光之惩戒";
                    Nowwizard = "英卡洛斯";

                    if (Nowwizardskill == "光之惩戒")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-gzcj.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "无始源光";
                        }
                    }
                    else if (Nowwizardskill == "无始源光")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-wsyg.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }
                    else if (Nowwizardskill == "第五")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }



                }else if (dm.FindPic(83, 9, 212, 100, "dqhb.bmp", "000000", 0.8, 0, out x, out y) != -1)//混沌布莱克专属出招
                {
                    if (Nowwizard != "混沌布莱克")
                        Nowwizardskill = "孑然孤梦";
                    Nowwizard = "混沌布莱克";

                    if (Nowwizardskill == "孑然孤梦")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-jrgm.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "第五1";
                        }
                    }                    
                    else if (Nowwizardskill == "第五1")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowwizardskill = "第五2";
                        }
                    }
                    else if (Nowwizardskill == "第五2")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowwizardskill = "孑然孤梦";
                        }
                    }



                }else if (dm.FindPic(83, 9, 212, 100, "dqmlw.bmp|dqmlw1.bmp", "000000", 0.8, 0, out x, out y) != -1)//魔灵王专属出招
                {
                    if (Nowwizard != "魔灵王")
                        Nowwizardskill = "荒芜之境";
                    Nowwizard = "魔灵王";

                    if (Nowwizardskill == "荒芜之境")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-hwzj.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "摄魄令";
                        }
                    }
                    else if (Nowwizardskill == "摄魄令")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-shl.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "荒芜之境";
                        }
                    }



                }else if (dm.FindPic(83, 9, 212, 100, "dqxw.bmp|dqxw2.bmp", "000000", 0.8, 0, out x, out y) != -1)//希瓦专属出招
                {
                    if (Nowwizard != "希瓦")
                        Nowwizardskill = "白日喧嚣";
                    Nowwizard = "希瓦";

                    if (Nowwizardskill == "白日喧嚣")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-brxx.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "第五1";
                        }
                    }
                    else if (Nowwizardskill == "第五1")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowwizardskill = "第五2";
                        }
                    }
                    else if (Nowwizardskill == "第五2")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowwizardskill = "白日喧嚣";
                        }
                    }



                }else if (dm.FindPic(83, 9, 212, 100, "dqhyxh.bmp|dqxh2.bmp", "000000", 0.8, 0, out x, out y) != -1)//星皇专属出招
                {
                    if (Nowwizard != "星皇")
                        Nowwizardskill = "瀚空之门";
                    Nowwizard = "星皇";

                    if (Nowwizardskill == "瀚空之门")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-hkzm.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "命宇轮回";
                        }
                    }
                    else if (Nowwizardskill == "命宇轮回")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-mylh.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "亘古星辰诀1";
                        }
                    }
                    else if (Nowwizardskill == "亘古星辰诀1")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-ggxcj.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "亘古星辰诀2";
                        }
                    }
                    else if (Nowwizardskill == "亘古星辰诀2")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-ggxcj.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "瀚空之门";
                        }


                    }
                }else if (dm.FindPic(83, 9, 212, 100, "dqqkfes.bmp|dqfw1.bmp", "000000", 0.8, 0, out x, out y) != -1)//飞王专属出招
                {
                    if (Nowwizard != "飞王")
                        Nowwizardskill = "苍鹰之眼";
                    Nowwizard = "飞王";

                    if (Nowwizardskill == "苍鹰之眼")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-cyzy.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "灵威天羽";
                        }
                    }
                    else if (Nowwizardskill == "灵威天羽")
                    {
                        if (dm.FindPic(66, 417, 836, 565, "jn-lwty.bmp", "000000", 0.8, 0, out x, out y) != -1)
                        {
                            dm.MoveTo((int)x, (int)y);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }
                    else if (Nowwizardskill == "第五")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowwizardskill = "第五";
                        }
                    }



                }
                else
                {
                    Nowwizard = "";
                }







                if (Nowwizard == "")//如果当前精灵不在默认配置内，则轮放技能
                {
                    if (Nowskill == "第一")
                    {
                        if (dm.FindColor(284, 509, 297, 518, "0388ec-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(245, 516);
                            dm.LeftClick();
                            Nowskill = "第五";
                        }
                    }
                    else if (Nowskill == "第五")
                    {
                        if (dm.FindColor(18, 476, 89, 493, "fffad4-000000", 1, 0, out x, out y) != 0)
                        {
                            dm.MoveTo(40, 506);
                            dm.LeftClick();
                            Nowskill = "第一";
                        }
                    }
                }
            }
        }
    }
   

    
}
