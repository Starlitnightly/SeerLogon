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
        [DllImport("user32.dll", EntryPoint = "MessageBoxA")]
        static extern int MsgBox(int hWnd, string msg, string caption, int type);
        [DllImport("user32.dll", EntryPoint = "GetDlgItem")]
        static extern int GetDlgItem(int hDlg, int nlDDlgltem);
        [DllImport("user32.dll", EntryPoint = "GetWindow")]
        static extern int GetWindow1(int hwnd, int wCmd);
        [DllImport("user32.dll", EntryPoint = "FindWindowExA")]
        static extern int FindWindowExA(int hWndParent, int hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("dmregNet.dll", EntryPoint = "SetDllPathA")]
        static extern void SetDllPathA(string path, int mode);
       
    }
   

    
}
