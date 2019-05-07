using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace C_DM
{
    
    class C_DmSoft : IDisposable
    {
        
        #region import DLL 函数
        [DllImport("dmc.dll",CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CreateDM(string dmpath);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string Ver(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetPath(IntPtr dm,string path);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string Ocr(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  color,double sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindStr(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string color,double  sim,out object  x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetResultCount(IntPtr dm,string str);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetResultPos(IntPtr dm,string str,int  index,out object  x,out object y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int StrStr(IntPtr dm,string s,string  str);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SendCommand(IntPtr dm,string cmd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int UseDict(IntPtr dm,int index);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetBasePath(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetDictPwd(IntPtr dm,string pwd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string OcrInFile(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  pic_name,string  color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int Capture(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int KeyPress(IntPtr dm,int vk);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int KeyDown(IntPtr dm,int vk);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int KeyUp(IntPtr dm,int vk);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int LeftClick(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RightClick(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int MiddleClick(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int LeftDoubleClick(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int LeftDown(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int LeftUp(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RightDown(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RightUp(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int MoveTo(IntPtr dm,int x,int  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int MoveR(IntPtr dm,int rx,int  ry);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetColor(IntPtr dm,int x,int  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetColorBGR(IntPtr dm,int x,int  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string RGB2BGR(IntPtr dm,string rgb_color);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string BGR2RGB(IntPtr dm,string bgr_color);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int UnBindWindow(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CmpColor(IntPtr dm,int x,int  y,string  color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ClientToScreen(IntPtr dm,int hwnd,ref object  x,ref object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ScreenToClient(IntPtr dm,int hwnd,ref object  x,ref object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ShowScrMsg(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  msg,string color);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetMinRowGap(IntPtr dm,int row_gap);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetMinColGap(IntPtr dm,int col_gap);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindColor(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  color,double sim,int  dir,out object  x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindColorEx(IntPtr dm,int x1,int  y1,int  x2,int  y2,string color,double  sim,int  dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWordLineHeight(IntPtr dm,int line_height);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWordGap(IntPtr dm,int word_gap);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetRowGapNoDict(IntPtr dm,int row_gap);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetColGapNoDict(IntPtr dm,int col_gap);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWordLineHeightNoDict(IntPtr dm,int line_height);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWordGapNoDict(IntPtr dm,int word_gap);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWordResultCount(IntPtr dm,string str);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWordResultPos(IntPtr dm,string str,int  index,out object  x,out object y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetWordResultStr(IntPtr dm,string str,int  index);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetWords(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  color,double sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetWordsNoDict(IntPtr dm,int x1,int  y1,int  x2,int  y2,string color);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetShowErrorMsg(IntPtr dm,int show);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetClientSize(IntPtr dm,int hwnd,out object  width,out object  height);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int MoveWindow(IntPtr dm,int hwnd,int  x,int  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetColorHSV(IntPtr dm,int x,int  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetAveRGB(IntPtr dm,int x1,int  y1,int  x2,int  y2);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetAveHSV(IntPtr dm,int x1,int  y1,int  x2,int  y2);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetForegroundWindow(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetForegroundFocus(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetMousePointWindow(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPointWindow(IntPtr dm,int x,int  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string EnumWindow(IntPtr dm,int parent,string  title,string  class_name,int filter);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWindowState(IntPtr dm,int hwnd,int  flag);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWindow(IntPtr dm,int hwnd,int  flag);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSpecialWindow(IntPtr dm,int flag);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowText(IntPtr dm,int hwnd,string  text);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowSize(IntPtr dm,int hwnd,int  width,int  height);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWindowRect(IntPtr dm,int hwnd,out object  x1,out object  y1,out object  x2,out object  y2);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetWindowTitle(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetWindowClass(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowState(IntPtr dm,int hwnd,int  flag);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateFoobarRect(IntPtr dm,int hwnd,int  x,int  y,int  w,int  h);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateFoobarRoundRect(IntPtr dm,int hwnd,int  x,int  y,int  w,int  h,int  rw,int  rh);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateFoobarEllipse(IntPtr dm,int hwnd,int  x,int  y,int  w,int  h);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateFoobarCustom(IntPtr dm,int hwnd,int  x,int  y,string  pic,string  trans_color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarFillRect(IntPtr dm,int hwnd,int  x1,int  y1,int  x2,int  y2,string  color);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarDrawText(IntPtr dm,int hwnd,int  x,int  y,int  w,int  h,string  text,string  color,int  align);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarDrawPic(IntPtr dm,int hwnd,int  x,int  y,string  pic,string  trans_color);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarUpdate(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarLock(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarUnlock(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarSetFont(IntPtr dm,int hwnd,string  font_name,int  size,int  flag);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarTextRect(IntPtr dm,int hwnd,int  x,int  y,int  w,int  h);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarPrintText(IntPtr dm,int hwnd,string  text,string  color);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarClearText(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarTextLineGap(IntPtr dm,int hwnd,int  gap);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int Play(IntPtr dm,string file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FaqCapture(IntPtr dm,int x1,int  y1,int  x2,int  y2,int  quality,int delay,int  time);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FaqRelease(IntPtr dm,int handle);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FaqSend(IntPtr dm,string server,int  handle,int  request_type,int  time_out);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int Beep(IntPtr dm,int fre,int  delay);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarClose(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int MoveDD(IntPtr dm,int dx,int  dy);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FaqGetSize(IntPtr dm,int handle);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int LoadPic(IntPtr dm,string pic_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FreePic(IntPtr dm,string pic_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetScreenData(IntPtr dm,int x1,int  y1,int  x2,int  y2);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FreeScreenData(IntPtr dm,int handle);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int WheelUp(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int WheelDown(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetMouseDelay(IntPtr dm,string type_,int  delay);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetKeypadDelay(IntPtr dm,string type_,int  delay);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetEnv(IntPtr dm,int index,string  name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetEnv(IntPtr dm,int index,string  name,string  value);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SendString(IntPtr dm,int hwnd,string  str);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DelEnv(IntPtr dm,int index,string  name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetPath(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetDict(IntPtr dm,int index,string  dict_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindPic(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  pic_name,string  delta_color,double  sim,int  dir,out object  x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindPicEx(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  pic_name,string  delta_color,double  sim,int  dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetClientSize(IntPtr dm,int hwnd,int  width,int  height);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadInt(IntPtr dm,int hwnd,string  addr,int  type_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadFloat(IntPtr dm,int hwnd,string  addr);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ReadDouble(IntPtr dm,int hwnd,string  addr);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindInt(IntPtr dm,int hwnd,string  addr_range,int  int_value_min,int int_value_max,int  type_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindFloat(IntPtr dm,int hwnd,string  addr_range,Single  float_value_min,Single  float_value_max);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindDouble(IntPtr dm,int hwnd,string  addr_range,double  double_value_min,double  double_value_max);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindString(IntPtr dm,int hwnd,string  addr_range,string  string_value,int  type_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetModuleBaseAddr(IntPtr dm,int hwnd,string  module_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string MoveToEx(IntPtr dm,int x,int  y,int  w,int  h);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string MatchPicName(IntPtr dm,string pic_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int AddDict(IntPtr dm,int index,string  dict_info);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnterCri(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int LeaveCri(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteInt(IntPtr dm,int hwnd,string  addr,int  type_,int  v);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteFloat(IntPtr dm,int hwnd,string  addr,Single  v);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteDouble(IntPtr dm,int hwnd,string  addr,double  v);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteString(IntPtr dm,int hwnd,string  addr,int  type_,string  v);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int AsmAdd(IntPtr dm,string asm_ins);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int AsmClear(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int AsmCall(IntPtr dm,int hwnd,int  mode);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindMultiColor(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  first_color,string  offset_color,double  sim,int  dir,out object  x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindMultiColorEx(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  first_color,string  offset_color,double  sim,int  dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string AsmCode(IntPtr dm,int base_addr);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string Assemble(IntPtr dm,string asm_code,int  base_addr,int  is_upper);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowTransparent(IntPtr dm,int hwnd,int  v);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string ReadData(IntPtr dm,int hwnd,string  addr,int  len);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteData(IntPtr dm,int hwnd,string  addr,string  data);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindData(IntPtr dm,int hwnd,string  addr_range,string  data);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetPicPwd(IntPtr dm,string pwd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int Log(IntPtr dm,string info);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindStrE(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindColorE(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  color,double  sim,int  dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindPicE(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  pic_name,string  delta_color,double  sim,int  dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindMultiColorE(IntPtr dm,int x1,int  y1,int  x2,int  y2,string first_color,string  offset_color,double sim,int  dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetExactOcr(IntPtr dm,int exact_ocr);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string ReadString(IntPtr dm,int hwnd,string  addr,int  type_,int  len);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarTextPrintDir(IntPtr dm,int hwnd,int  dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string OcrEx(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetDisplayInput(IntPtr dm,string mode);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetTime(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetScreenWidth(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetScreenHeight(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int BindWindowEx(IntPtr dm,int hwnd,string  display,string  mouse,string  keypad,string  public_desc,int  mode);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetDiskSerial(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string Md5(IntPtr dm,string str);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetMac(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ActiveInputMethod(IntPtr dm,int hwnd,string  id);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CheckInputMethod(IntPtr dm,int hwnd,string  id);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindInputMethod(IntPtr dm,string id);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetCursorPos(IntPtr dm,out object x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int BindWindow(IntPtr dm,int hwnd,string  display,string  mouse,string  keypad,int  mode);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindWindow(IntPtr dm,string class_name,string  title_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetScreenDepth(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetScreen(IntPtr dm,int width,int  height,int  depth);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ExitOs(IntPtr dm,int type_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetDir(IntPtr dm,int type_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetOsType(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindWindowEx(IntPtr dm,int parent,string  class_name,string  title_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetExportDict(IntPtr dm,int index,string  dict_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetCursorShape(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DownCpu(IntPtr dm,int rate);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetCursorSpot(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SendString2(IntPtr dm,int hwnd,string  str);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FaqPost(IntPtr dm,string server,int  handle,int  request_type,int  time_out);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FaqFetch(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FetchWord(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  color,string  word);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CaptureJpg(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  file_,int  quality);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindStrWithFont(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim,string   font_name,int  font_size,int  flag,out object  x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindStrWithFontE(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim,string  font_name,int  font_size,int  flag);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindStrWithFontEx(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim,string  font_name,int  font_size,int  flag);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetDictInfo(IntPtr dm,string str,string  font_name,int  font_size,int  flag);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SaveDict(IntPtr dm,int index,string  file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWindowProcessId(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetWindowProcessPath(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int LockInput(IntPtr dm,int lock1);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetPicSize(IntPtr dm,string pic_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetID(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CapturePng(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CaptureGif(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  file_,int  delay,int  time);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ImageToBmp(IntPtr dm,string pic_name,string  bmp_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindStrFast(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim,out object  x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindStrFastEx(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindStrFastE(IntPtr dm,int x1,int  y1,int  x2,int  y2,string str,string  color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableDisplayDebug(IntPtr dm,int enable_debug);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CapturePre(IntPtr dm,string file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RegEx(IntPtr dm,string code,string  Ver,string  ip);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetMachineCode(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetClipboard(IntPtr dm,string data);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetClipboard(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetNowDict(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int Is64Bit(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetColorNum(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string EnumWindowByProcess(IntPtr dm,string process_name,string  title,string  class_name,int  filter);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetDictCount(IntPtr dm,int index);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetLastError(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetNetTime(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableGetColorByCapture(IntPtr dm,int en);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CheckUAC(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetUAC(IntPtr dm,int uac);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DisableFontSmooth(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CheckFontSmooth(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetDisplayAcceler(IntPtr dm,int level);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindWindowByProcess(IntPtr dm,string process_name,string  class_name,string  title_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindWindowByProcessId(IntPtr dm,int process_id,string  class_name,string  title_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string ReadIni(IntPtr dm,string section,string  key,string  file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteIni(IntPtr dm,string section,string  key,string  v,string  file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RunApp(IntPtr dm,string path,int  mode);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int delay(IntPtr dm,int mis);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindWindowSuper(IntPtr dm,string spec1,int  flag1,int  type1,string  spec2,int  flag2,int  type2);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string ExcludePos(IntPtr dm,string all_pos,int  type_,int  x1,int  y1,int  x2,int  y2);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindNearestPos(IntPtr dm,string all_pos,int  type_,int  x,int  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string SortPosDistance(IntPtr dm,string all_pos,int  type_,int  x,int  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindPicMem(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  pic_info,string  delta_color,double  sim,int  dir,out object  x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindPicMemEx(IntPtr dm,int x1,int  y1,int  x2,int  y2,string pic_info,string  delta_color,double  sim,int  dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindPicMemE(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  pic_info,string  delta_color,double  sim,int dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string AppendPicAddr(IntPtr dm,string pic_info,int  addr,int  size);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteFile(IntPtr dm,string file_,string  content);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int Stop(IntPtr dm,int id);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetDictMem(IntPtr dm,int index,int  addr,int  size);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetNetTimeSafe(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ForceUnBindWindow(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string ReadIniPwd(IntPtr dm,string section,string  key,string  file_,string  pwd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int WriteIniPwd(IntPtr dm,string section,string  key,string  v,string  file_,string  pwd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DecodeFile(IntPtr dm,string file_,string  pwd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int KeyDownChar(IntPtr dm,string key_str);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int KeyUpChar(IntPtr dm,string key_str);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int KeyPressChar(IntPtr dm,string key_str);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int KeyPressStr(IntPtr dm,string key_str,int  delay);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableKeypadPatch(IntPtr dm,int en);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableKeypadSync(IntPtr dm,int en,int  time_out);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableMouseSync(IntPtr dm,int en,int  time_out);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DmGuard(IntPtr dm,int en,string  type_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FaqCaptureFromFile(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  file_,int  quality);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindIntEx(IntPtr dm,int hwnd,string  addr_range,int  int_value_min,int  int_value_max,int  type_,int  step,int  multi_thread,int  mode);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindFloatEx(IntPtr dm,int hwnd,string  addr_range,Single  float_value_min,Single  float_value_max,int  step,int  multi_thread,int  mode);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindDoubleEx(IntPtr dm,int hwnd,string  addr_range,double  double_value_min,double  double_value_max,int  step,int  multi_thread,int  mode);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindStringEx(IntPtr dm,int hwnd,string  addr_range,string  string_value,int  type_,int  step,int  multi_thread,int  mode);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindDataEx(IntPtr dm,int hwnd,string  addr_range,string  data,int  step,int  multi_thread,int  mode);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableRealMouse(IntPtr dm,int en,int  mousedelay,int  mousestep);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableRealKeypad(IntPtr dm,int en);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SendStringIme(IntPtr dm,string str);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarDrawLine(IntPtr dm,int hwnd,int  x1,int  y1,int  x2,int  y2,string  color,int  style,int  width);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindStrEx(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int IsBind(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetDisplayDelay(IntPtr dm,int t);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetDmCount(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DisableScreenSave(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DisablePowerSave(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetMemoryHwndAsProcessId(IntPtr dm,int en);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindShape(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  offset_color,double  sim,int  dir,out object  x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindShapeE(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  offset_color,double  sim,int  dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindShapeEx(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  offset_color,double  sim,int  dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindStrS(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim,out object  x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindStrExS(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindStrFastS(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim,out object  x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindStrFastExS(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindPicS(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  pic_name,string  delta_color,double  sim,int  dir,out object  x,out object  y);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FindPicExS(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  pic_name,string  delta_color,double  sim,int  dir);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int ClearDict(IntPtr dm,int index);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetMachineCodeNoMac(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetClientRect(IntPtr dm,int hwnd,out object  x1,out object  y1,out object  x2,out object  y2);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableFakeActive(IntPtr dm,int en);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetScreenDataBmp(IntPtr dm,int x1,int  y1,int  x2,int  y2,out object  data,out object  size);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EncodeFile(IntPtr dm,string file_,string  pwd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetCursorShapeEx(IntPtr dm,int type_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FaqCancel(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string IntToData(IntPtr dm,int int_value,int  type_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string FloatToData(IntPtr dm,Single float_value);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string DoubleToData(IntPtr dm,double double_value);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string StringToData(IntPtr dm,string string_value,int  type_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetMemoryFindResultToFile(IntPtr dm,string file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableBind(IntPtr dm,int en);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetSimMode(IntPtr dm,int mode);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int LockMouseRect(IntPtr dm,int x1,int  y1,int  x2,int  y2);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SendPaste(IntPtr dm,int hwnd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int IsDisplayDead(IntPtr dm,int x1,int  y1,int  x2,int  y2,int  t);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetKeyState(IntPtr dm,int vk);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CopyFile(IntPtr dm,string src_file,string  dst_file,int  over);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int IsFileExist(IntPtr dm,string file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DeleteFile(IntPtr dm,string file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int MoveFile(IntPtr dm,string src_file,string  dst_file);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateFolder(IntPtr dm,string folder_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DeleteFolder(IntPtr dm,string folder_name);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetFileLength(IntPtr dm,string file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string ReadFile(IntPtr dm,string file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int WaitKey(IntPtr dm,int key_code,int  time_out);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DeleteIni(IntPtr dm,string section,string  key,string  file_);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DeleteIniPwd(IntPtr dm,string section,string  key,string  file_,string  pwd);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableSpeedDx(IntPtr dm,int en);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableIme(IntPtr dm,int en);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int Reg(IntPtr dm,string code,string  Ver);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string SelectFile(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string SelectDirectory(IntPtr dm);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int LockDisplay(IntPtr dm,int lock1);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FoobarSetSave(IntPtr dm,int hwnd,string  file_,int  en,string   header);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string EnumWindowSuper(IntPtr dm,string spec1,int  flag1,int  type1,string  spec2,int  flag2,int  type2,int  sort);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int DownloadFile(IntPtr dm,string url,string  save_file,int  timeout);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableKeypadMsg(IntPtr dm,int en);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int EnableMouseMsg(IntPtr dm,int en);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RegNoMac(IntPtr dm,string code,string  Ver);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int RegExNoMac(IntPtr dm,string code,string  Ver,string  ip);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetEnumWindowDelay(IntPtr dm,int delay);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern int FindMulColor(IntPtr dm,int x1,int  y1,int  x2,int  y2,string  color,double  sim);

        [DllImport("dmc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern string GetDict(IntPtr dm,int index,int  font_index);


        #endregion

        private IntPtr _dm = IntPtr.Zero;
        private bool disposed = false;

        public IntPtr DM
        {
            get { return _dm; }
            set { _dm = value; }
        }
      

        public C_DmSoft(string path ="dm.dll")
        {
            _dm = CreateDM(path);
        }

        public string Ver(){
           return Ver(_dm);
        }

        public int SetPath(string path)
        {
           return SetPath(_dm,path);
        }

        public string Ocr(int x1,int  y1,int  x2,int  y2,string  color,double sim)
        {
           return Ocr(_dm,x1, y1, x2, y2, color,sim);
        }

        public int FindStr(int x1,int  y1,int  x2,int  y2,string  str,string color,double  sim, out object x, out object y)
        {
           return FindStr(_dm,x1, y1, x2, y2, str,color, sim, out x, out y);
        }

        public int GetResultCount(string str)
        {
           return GetResultCount(_dm,str);
        }

        public int GetResultPos(string str,int  index, out object x,out object y)
        {
           return GetResultPos(_dm,str, index, out x,out y);
        }

        public int StrStr(string s,string  str)
        {
           return StrStr(_dm,s, str);
        }

        public int SendCommand(string cmd)
        {
           return SendCommand(_dm,cmd);
        }

        public int UseDict(int index)
        {
           return UseDict(_dm,index);
        }

        public string GetBasePath(){
           return GetBasePath(_dm);
        }

        public int SetDictPwd(string pwd)
        {
           return SetDictPwd(_dm,pwd);
        }

        public string OcrInFile(int x1,int  y1,int  x2,int  y2,string  pic_name,string  color,double  sim)
        {
           return OcrInFile(_dm,x1, y1, x2, y2, pic_name, color, sim);
        }

        public int Capture(int x1,int  y1,int  x2,int  y2,string  file_)
        {
           return Capture(_dm,x1, y1, x2, y2, file_);
        }

        public int KeyPress(int vk)
        {
           return KeyPress(_dm,vk);
        }

        public int KeyDown(int vk)
        {
           return KeyDown(_dm,vk);
        }

        public int KeyUp(int vk)
        {
           return KeyUp(_dm,vk);
        }

        public int LeftClick(){
           return LeftClick(_dm);
        }

        public int RightClick(){
           return RightClick(_dm);
        }

        public int MiddleClick(){
           return MiddleClick(_dm);
        }

        public int LeftDoubleClick(){
           return LeftDoubleClick(_dm);
        }

        public int LeftDown(){
           return LeftDown(_dm);
        }

        public int LeftUp(){
           return LeftUp(_dm);
        }

        public int RightDown(){
           return RightDown(_dm);
        }

        public int RightUp(){
           return RightUp(_dm);
        }

        public int MoveTo(int x,int  y)
        {
           return MoveTo(_dm,x, y);
        }

        public int MoveR(int rx,int  ry)
        {
           return MoveR(_dm,rx, ry);
        }

        public string GetColor(int x,int  y)
        {
           return GetColor(_dm,x, y);
        }

        public string GetColorBGR(int x,int  y)
        {
           return GetColorBGR(_dm,x, y);
        }

        public string RGB2BGR(string rgb_color)
        {
           return RGB2BGR(_dm,rgb_color);
        }

        public string BGR2RGB(string bgr_color)
        {
           return BGR2RGB(_dm,bgr_color);
        }

        public int UnBindWindow(){
           return UnBindWindow(_dm);
        }

        public int CmpColor(int x,int  y,string  color,double  sim)
        {
           return CmpColor(_dm,x, y, color, sim);
        }

        public int ClientToScreen(int hwnd, ref object x, ref object y)
        {
           return ClientToScreen(_dm,hwnd, ref x, ref y);
        }

        public int ScreenToClient(int hwnd, ref object x, ref object y)
        {
           return ScreenToClient(_dm,hwnd, ref x, ref y);
        }

        public int ShowScrMsg(int x1,int  y1,int  x2,int  y2,string  msg,string color)
        {
           return ShowScrMsg(_dm,x1, y1, x2, y2, msg,color);
        }

        public int SetMinRowGap(int row_gap)
        {
           return SetMinRowGap(_dm,row_gap);
        }

        public int SetMinColGap(int col_gap)
        {
           return SetMinColGap(_dm,col_gap);
        }

        public int FindColor(int x1,int  y1,int  x2,int  y2,string  color,double sim,int  dir, out object x, out object y)
        {
           return FindColor(_dm,x1, y1, x2, y2, color,sim, dir, out x, out y);
        }

        public string FindColorEx(int x1,int  y1,int  x2,int  y2,string color,double  sim,int  dir)
        {
           return FindColorEx(_dm,x1, y1, x2, y2,color, sim, dir);
        }

        public int SetWordLineHeight(int line_height)
        {
           return SetWordLineHeight(_dm,line_height);
        }

        public int SetWordGap(int word_gap)
        {
           return SetWordGap(_dm,word_gap);
        }

        public int SetRowGapNoDict(int row_gap)
        {
           return SetRowGapNoDict(_dm,row_gap);
        }

        public int SetColGapNoDict(int col_gap)
        {
           return SetColGapNoDict(_dm,col_gap);
        }

        public int SetWordLineHeightNoDict(int line_height)
        {
           return SetWordLineHeightNoDict(_dm,line_height);
        }

        public int SetWordGapNoDict(int word_gap)
        {
           return SetWordGapNoDict(_dm,word_gap);
        }

        public int GetWordResultCount(string str)
        {
           return GetWordResultCount(_dm,str);
        }

        public int GetWordResultPos(string str,int  index, out object x,out object y)
        {
           return GetWordResultPos(_dm,str, index, out x,out y);
        }

        public string GetWordResultStr(string str,int  index)
        {
           return GetWordResultStr(_dm,str, index);
        }

        public string GetWords(int x1,int  y1,int  x2,int  y2,string  color,double sim)
        {
           return GetWords(_dm,x1, y1, x2, y2, color,sim);
        }

        public string GetWordsNoDict(int x1,int  y1,int  x2,int  y2,string color)
        {
           return GetWordsNoDict(_dm,x1, y1, x2, y2,color);
        }

        public int SetShowErrorMsg(int show)
        {
           return SetShowErrorMsg(_dm,show);
        }

        public int GetClientSize(int hwnd, out object width, out object height)
        {
           return GetClientSize(_dm,hwnd, out width, out height);
        }

        public int MoveWindow(int hwnd,int  x,int  y)
        {
           return MoveWindow(_dm,hwnd, x, y);
        }

        public string GetColorHSV(int x,int  y)
        {
           return GetColorHSV(_dm,x, y);
        }

        public string GetAveRGB(int x1,int  y1,int  x2,int  y2)
        {
           return GetAveRGB(_dm,x1, y1, x2, y2);
        }

        public string GetAveHSV(int x1,int  y1,int  x2,int  y2)
        {
           return GetAveHSV(_dm,x1, y1, x2, y2);
        }

        public int GetForegroundWindow(){
           return GetForegroundWindow(_dm);
        }

        public int GetForegroundFocus(){
           return GetForegroundFocus(_dm);
        }

        public int GetMousePointWindow(){
           return GetMousePointWindow(_dm);
        }

        public int GetPointWindow(int x,int  y)
        {
           return GetPointWindow(_dm,x, y);
        }

        public string EnumWindow(int parent,string  title,string  class_name,int filter)
        {
           return EnumWindow(_dm,parent, title, class_name,filter);
        }

        public int GetWindowState(int hwnd,int  flag)
        {
           return GetWindowState(_dm,hwnd, flag);
        }

        public int GetWindow(int hwnd,int  flag)
        {
           return GetWindow(_dm,hwnd, flag);
        }

        public int GetSpecialWindow(int flag)
        {
           return GetSpecialWindow(_dm,flag);
        }

        public int SetWindowText(int hwnd,string  text)
        {
           return SetWindowText(_dm,hwnd, text);
        }

        public int SetWindowSize(int hwnd,int  width,int  height)
        {
           return SetWindowSize(_dm,hwnd, width, height);
        }

        public int GetWindowRect(int hwnd, out object x1, out object y1, out object x2, out object y2)
        {
           return GetWindowRect(_dm,hwnd, out x1, out y1, out x2, out y2);
        }

        public string GetWindowTitle(int hwnd)
        {
           return GetWindowTitle(_dm,hwnd);
        }

        public string GetWindowClass(int hwnd)
        {
           return GetWindowClass(_dm,hwnd);
        }

        public int SetWindowState(int hwnd,int  flag)
        {
           return SetWindowState(_dm,hwnd, flag);
        }

        public int CreateFoobarRect(int hwnd,int  x,int  y,int  w,int  h)
        {
           return CreateFoobarRect(_dm,hwnd, x, y, w, h);
        }

        public int CreateFoobarRoundRect(int hwnd,int  x,int  y,int  w,int  h,int  rw,int  rh)
        {
           return CreateFoobarRoundRect(_dm,hwnd, x, y, w, h, rw, rh);
        }

        public int CreateFoobarEllipse(int hwnd,int  x,int  y,int  w,int  h)
        {
           return CreateFoobarEllipse(_dm,hwnd, x, y, w, h);
        }

        public int CreateFoobarCustom(int hwnd,int  x,int  y,string  pic,string  trans_color,double  sim)
        {
           return CreateFoobarCustom(_dm,hwnd, x, y, pic, trans_color, sim);
        }

        public int FoobarFillRect(int hwnd,int  x1,int  y1,int  x2,int  y2,string  color)
        {
           return FoobarFillRect(_dm,hwnd, x1, y1, x2, y2, color);
        }

        public int FoobarDrawText(int hwnd,int  x,int  y,int  w,int  h,string  text,string  color,int  align)
        {
           return FoobarDrawText(_dm,hwnd, x, y, w, h, text, color, align);
        }

        public int FoobarDrawPic(int hwnd,int  x,int  y,string  pic,string  trans_color)
        {
           return FoobarDrawPic(_dm,hwnd, x, y, pic, trans_color);
        }

        public int FoobarUpdate(int hwnd)
        {
           return FoobarUpdate(_dm,hwnd);
        }

        public int FoobarLock(int hwnd)
        {
           return FoobarLock(_dm,hwnd);
        }

        public int FoobarUnlock(int hwnd)
        {
           return FoobarUnlock(_dm,hwnd);
        }

        public int FoobarSetFont(int hwnd,string  font_name,int  size,int  flag)
        {
           return FoobarSetFont(_dm,hwnd, font_name, size, flag);
        }

        public int FoobarTextRect(int hwnd,int  x,int  y,int  w,int  h)
        {
           return FoobarTextRect(_dm,hwnd, x, y, w, h);
        }

        public int FoobarPrintText(int hwnd,string  text,string  color)
        {
           return FoobarPrintText(_dm,hwnd, text, color);
        }

        public int FoobarClearText(int hwnd)
        {
           return FoobarClearText(_dm,hwnd);
        }

        public int FoobarTextLineGap(int hwnd,int  gap)
        {
           return FoobarTextLineGap(_dm,hwnd, gap);
        }

        public int Play(string file_)
        {
           return Play(_dm,file_);
        }

        public int FaqCapture(int x1,int  y1,int  x2,int  y2,int  quality,int delay,int  time)
        {
           return FaqCapture(_dm,x1, y1, x2, y2, quality,delay, time);
        }

        public int FaqRelease(int handle)
        {
           return FaqRelease(_dm,handle);
        }

        public string FaqSend(string server,int  handle,int  request_type,int  time_out)
        {
           return FaqSend(_dm,server, handle, request_type, time_out);
        }

        public int Beep(int fre,int  delay)
        {
           return Beep(_dm,fre, delay);
        }

        public int FoobarClose(int hwnd)
        {
           return FoobarClose(_dm,hwnd);
        }

        public int MoveDD(int dx,int  dy)
        {
           return MoveDD(_dm,dx, dy);
        }

        public int FaqGetSize(int handle)
        {
           return FaqGetSize(_dm,handle);
        }

        public int LoadPic(string pic_name)
        {
           return LoadPic(_dm,pic_name);
        }

        public int FreePic(string pic_name)
        {
           return FreePic(_dm,pic_name);
        }

        public int GetScreenData(int x1,int  y1,int  x2,int  y2)
        {
           return GetScreenData(_dm,x1, y1, x2, y2);
        }

        public int FreeScreenData(int handle)
        {
           return FreeScreenData(_dm,handle);
        }

        public int WheelUp(){
           return WheelUp(_dm);
        }

        public int WheelDown(){
           return WheelDown(_dm);
        }

        public int SetMouseDelay(string type_,int  delay)
        {
           return SetMouseDelay(_dm,type_, delay);
        }

        public int SetKeypadDelay(string type_,int  delay)
        {
           return SetKeypadDelay(_dm,type_, delay);
        }

        public string GetEnv(int index,string  name)
        {
           return GetEnv(_dm,index, name);
        }

        public int SetEnv(int index,string  name,string  value)
        {
           return SetEnv(_dm,index, name, value);
        }

        public int SendString(int hwnd,string  str)
        {
           return SendString(_dm,hwnd, str);
        }

        public int DelEnv(int index,string  name)
        {
           return DelEnv(_dm,index, name);
        }

        public string GetPath(){
           return GetPath(_dm);
        }

        public int SetDict(int index,string  dict_name)
        {
           return SetDict(_dm,index, dict_name);
        }

        public int FindPic(int x1,int  y1,int  x2,int  y2,string  pic_name,string  delta_color,double  sim,int  dir, out object x, out object y)
        {
           return FindPic(_dm,x1, y1, x2, y2, pic_name, delta_color, sim, dir, out x, out y);
        }

        public string FindPicEx(int x1,int  y1,int  x2,int  y2,string  pic_name,string  delta_color,double  sim,int  dir)
        {
           return FindPicEx(_dm,x1, y1, x2, y2, pic_name, delta_color, sim, dir);
        }

        public int SetClientSize(int hwnd,int  width,int  height)
        {
           return SetClientSize(_dm,hwnd, width, height);
        }

        public int ReadInt(int hwnd,string  addr,int  type_)
        {
           return ReadInt(_dm,hwnd, addr, type_);
        }

        public int ReadFloat(int hwnd,string  addr)
        {
           return ReadFloat(_dm,hwnd, addr);
        }

        public int ReadDouble(int hwnd,string  addr)
        {
           return ReadDouble(_dm,hwnd, addr);
        }

        public string FindInt(int hwnd,string  addr_range,int  int_value_min,int int_value_max,int  type_)
        {
           return FindInt(_dm,hwnd, addr_range, int_value_min,int_value_max, type_);
        }

        public string FindFloat(int hwnd,string  addr_range,Single  float_value_min,Single  float_value_max)
        {
           return FindFloat(_dm,hwnd, addr_range, float_value_min, float_value_max);
        }

        public string FindDouble(int hwnd,string  addr_range,double  double_value_min,double  double_value_max)
        {
           return FindDouble(_dm,hwnd, addr_range, double_value_min, double_value_max);
        }

        public string FindString(int hwnd,string  addr_range,string  string_value,int  type_)
        {
           return FindString(_dm,hwnd, addr_range, string_value, type_);
        }

        public int GetModuleBaseAddr(int hwnd,string  module_name)
        {
           return GetModuleBaseAddr(_dm,hwnd, module_name);
        }

        public string MoveToEx(int x,int  y,int  w,int  h)
        {
           return MoveToEx(_dm,x, y, w, h);
        }

        public string MatchPicName(string pic_name)
        {
           return MatchPicName(_dm,pic_name);
        }

        public int AddDict(int index,string  dict_info)
        {
           return AddDict(_dm,index, dict_info);
        }

        public int EnterCri(){
           return EnterCri(_dm);
        }

        public int LeaveCri(){
           return LeaveCri(_dm);
        }

        public int WriteInt(int hwnd,string  addr,int  type_,int  v)
        {
           return WriteInt(_dm,hwnd, addr, type_, v);
        }

        public int WriteFloat(int hwnd,string  addr,Single  v)
        {
           return WriteFloat(_dm,hwnd, addr, v);
        }

        public int WriteDouble(int hwnd,string  addr,double  v)
        {
           return WriteDouble(_dm,hwnd, addr, v);
        }

        public int WriteString(int hwnd,string  addr,int  type_,string  v)
        {
           return WriteString(_dm,hwnd, addr, type_, v);
        }

        public int AsmAdd(string asm_ins)
        {
           return AsmAdd(_dm,asm_ins);
        }

        public int AsmClear(){
           return AsmClear(_dm);
        }

        public int AsmCall(int hwnd,int  mode)
        {
           return AsmCall(_dm,hwnd, mode);
        }

        public int FindMultiColor(int x1,int  y1,int  x2,int  y2,string  first_color,string  offset_color,double  sim,int  dir, out object x, out object y)
        {
           return FindMultiColor(_dm,x1, y1, x2, y2, first_color, offset_color, sim, dir, out x, out y);
        }

        public string FindMultiColorEx(int x1,int  y1,int  x2,int  y2,string  first_color,string  offset_color,double  sim,int  dir)
        {
           return FindMultiColorEx(_dm,x1, y1, x2, y2, first_color, offset_color, sim, dir);
        }

        public string AsmCode(int base_addr)
        {
           return AsmCode(_dm,base_addr);
        }

        public string Assemble(string asm_code,int  base_addr,int  is_upper)
        {
           return Assemble(_dm,asm_code, base_addr, is_upper);
        }

        public int SetWindowTransparent(int hwnd,int  v)
        {
           return SetWindowTransparent(_dm,hwnd, v);
        }

        public string ReadData(int hwnd,string  addr,int  len)
        {
           return ReadData(_dm,hwnd, addr, len);
        }

        public int WriteData(int hwnd,string  addr,string  data)
        {
           return WriteData(_dm,hwnd, addr, data);
        }

        public string FindData(int hwnd,string  addr_range,string  data)
        {
           return FindData(_dm,hwnd, addr_range, data);
        }

        public int SetPicPwd(string pwd)
        {
           return SetPicPwd(_dm,pwd);
        }

        public int Log(string info)
        {
           return Log(_dm,info);
        }

        public string FindStrE(int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim)
        {
           return FindStrE(_dm,x1, y1, x2, y2, str, color, sim);
        }

        public string FindColorE(int x1,int  y1,int  x2,int  y2,string  color,double  sim,int  dir)
        {
           return FindColorE(_dm,x1, y1, x2, y2, color, sim, dir);
        }

        public string FindPicE(int x1,int  y1,int  x2,int  y2,string  pic_name,string  delta_color,double  sim,int  dir)
        {
           return FindPicE(_dm,x1, y1, x2, y2, pic_name, delta_color, sim, dir);
        }

        public string FindMultiColorE(int x1,int  y1,int  x2,int  y2,string first_color,string  offset_color,double sim,int  dir)
        {
           return FindMultiColorE(_dm,x1, y1, x2, y2,first_color, offset_color,sim, dir);
        }

        public int SetExactOcr(int exact_ocr)
        {
           return SetExactOcr(_dm,exact_ocr);
        }

        public string ReadString(int hwnd,string  addr,int  type_,int  len)
        {
           return ReadString(_dm,hwnd, addr, type_, len);
        }

        public int FoobarTextPrintDir(int hwnd,int  dir)
        {
           return FoobarTextPrintDir(_dm,hwnd, dir);
        }

        public string OcrEx(int x1,int  y1,int  x2,int  y2,string  color,double  sim)
        {
           return OcrEx(_dm,x1, y1, x2, y2, color, sim);
        }

        public int SetDisplayInput(string mode)
        {
           return SetDisplayInput(_dm,mode);
        }

        public int GetTime(){
           return GetTime(_dm);
        }

        public int GetScreenWidth(){
           return GetScreenWidth(_dm);
        }

        public int GetScreenHeight(){
           return GetScreenHeight(_dm);
        }

        public int BindWindowEx(int hwnd,string  display,string  mouse,string  keypad,string  public_desc,int  mode)
        {
           return BindWindowEx(_dm,hwnd, display, mouse, keypad, public_desc, mode);
        }

        public string GetDiskSerial(){
           return GetDiskSerial(_dm);
        }

        public string Md5(string str)
        {
           return Md5(_dm,str);
        }

        public string GetMac(){
           return GetMac(_dm);
        }

        public int ActiveInputMethod(int hwnd,string  id)
        {
           return ActiveInputMethod(_dm,hwnd, id);
        }

        public int CheckInputMethod(int hwnd,string  id)
        {
           return CheckInputMethod(_dm,hwnd, id);
        }

        public int FindInputMethod(string id)
        {
           return FindInputMethod(_dm,id);
        }

        public int GetCursorPos(out object x, out object y)
        {
           return GetCursorPos(_dm,out x, out y);
        }

        public int BindWindow(int hwnd,string  display,string  mouse,string  keypad,int  mode)
        {
           return BindWindow(_dm,hwnd, display, mouse, keypad, mode);
        }

        public int FindWindow(string class_name,string  title_name)
        {
           return FindWindow(_dm,class_name, title_name);
        }

        public int GetScreenDepth(){
           return GetScreenDepth(_dm);
        }

        public int SetScreen(int width,int  height,int  depth)
        {
           return SetScreen(_dm,width, height, depth);
        }

        public int ExitOs(int type_)
        {
           return ExitOs(_dm,type_);
        }

        public string GetDir(int type_)
        {
           return GetDir(_dm,type_);
        }

        public int GetOsType(){
           return GetOsType(_dm);
        }

        public int FindWindowEx(int parent,string  class_name,string  title_name)
        {
           return FindWindowEx(_dm,parent, class_name, title_name);
        }

        public int SetExportDict(int index,string  dict_name)
        {
           return SetExportDict(_dm,index, dict_name);
        }

        public string GetCursorShape(){
           return GetCursorShape(_dm);
        }

        public int DownCpu(int rate)
        {
           return DownCpu(_dm,rate);
        }

        public string GetCursorSpot(){
           return GetCursorSpot(_dm);
        }

        public int SendString2(int hwnd,string  str)
        {
           return SendString2(_dm,hwnd, str);
        }

        public int FaqPost(string server,int  handle,int  request_type,int  time_out)
        {
           return FaqPost(_dm,server, handle, request_type, time_out);
        }

        public string FaqFetch(){
           return FaqFetch(_dm);
        }

        public string FetchWord(int x1,int  y1,int  x2,int  y2,string  color,string  word)
        {
           return FetchWord(_dm,x1, y1, x2, y2, color, word);
        }

        public int CaptureJpg(int x1,int  y1,int  x2,int  y2,string  file_,int  quality)
        {
           return CaptureJpg(_dm,x1, y1, x2, y2, file_, quality);
        }

        public int FindStrWithFont(int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim,string   font_name,int  font_size,int  flag, out object x, out object y)
        {
           return FindStrWithFont(_dm,x1, y1, x2, y2, str, color, sim,  font_name, font_size, flag, out x, out y);
        }

        public string FindStrWithFontE(int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim,string  font_name,int  font_size,int  flag)
        {
           return FindStrWithFontE(_dm,x1, y1, x2, y2, str, color, sim, font_name, font_size, flag);
        }

        public string FindStrWithFontEx(int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim,string  font_name,int  font_size,int  flag)
        {
           return FindStrWithFontEx(_dm,x1, y1, x2, y2, str, color, sim, font_name, font_size, flag);
        }

        public string GetDictInfo(string str,string  font_name,int  font_size,int  flag)
        {
           return GetDictInfo(_dm,str, font_name, font_size, flag);
        }

        public int SaveDict(int index,string  file_)
        {
           return SaveDict(_dm,index, file_);
        }

        public int GetWindowProcessId(int hwnd)
        {
           return GetWindowProcessId(_dm,hwnd);
        }

        public string GetWindowProcessPath(int hwnd)
        {
           return GetWindowProcessPath(_dm,hwnd);
        }

        public int LockInput(int lock1)
        {
           return LockInput(_dm,lock1);
        }

        public string GetPicSize(string pic_name)
        {
           return GetPicSize(_dm,pic_name);
        }

        public int GetID(){
           return GetID(_dm);
        }

        public int CapturePng(int x1,int  y1,int  x2,int  y2,string  file_)
        {
           return CapturePng(_dm,x1, y1, x2, y2, file_);
        }

        public int CaptureGif(int x1,int  y1,int  x2,int  y2,string  file_,int  delay,int  time)
        {
           return CaptureGif(_dm,x1, y1, x2, y2, file_, delay, time);
        }

        public int ImageToBmp(string pic_name,string  bmp_name)
        {
           return ImageToBmp(_dm,pic_name, bmp_name);
        }

        public int FindStrFast(int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim, out object x, out object y)
        {
           return FindStrFast(_dm,x1, y1, x2, y2, str, color, sim, out x, out y);
        }

        public string FindStrFastEx(int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim)
        {
           return FindStrFastEx(_dm,x1, y1, x2, y2, str, color, sim);
        }

        public string FindStrFastE(int x1,int  y1,int  x2,int  y2,string str,string  color,double  sim)
        {
           return FindStrFastE(_dm,x1, y1, x2, y2,str, color, sim);
        }

        public int EnableDisplayDebug(int enable_debug)
        {
           return EnableDisplayDebug(_dm,enable_debug);
        }

        public int CapturePre(string file_)
        {
           return CapturePre(_dm,file_);
        }

        public int RegEx(string code,string  Ver,string  ip)
        {
           return RegEx(_dm,code, Ver, ip);
        }

        public string GetMachineCode(){
           return GetMachineCode(_dm);
        }

        public int SetClipboard(string data)
        {
           return SetClipboard(_dm,data);
        }

        public string GetClipboard(){
           return GetClipboard(_dm);
        }

        public int GetNowDict(){
           return GetNowDict(_dm);
        }

        public int Is64Bit(){
           return Is64Bit(_dm);
        }

        public int GetColorNum(int x1,int  y1,int  x2,int  y2,string  color,double  sim)
        {
           return GetColorNum(_dm,x1, y1, x2, y2, color, sim);
        }

        public string EnumWindowByProcess(string process_name,string  title,string  class_name,int  filter)
        {
           return EnumWindowByProcess(_dm,process_name, title, class_name, filter);
        }

        public int GetDictCount(int index)
        {
           return GetDictCount(_dm,index);
        }

        public int GetLastError(){
           return GetLastError(_dm);
        }

        public string GetNetTime(){
           return GetNetTime(_dm);
        }

        public int EnableGetColorByCapture(int en)
        {
           return EnableGetColorByCapture(_dm,en);
        }

        public int CheckUAC(){
           return CheckUAC(_dm);
        }

        public int SetUAC(int uac)
        {
           return SetUAC(_dm,uac);
        }

        public int DisableFontSmooth(){
           return DisableFontSmooth(_dm);
        }

        public int CheckFontSmooth(){
           return CheckFontSmooth(_dm);
        }

        public int SetDisplayAcceler(int level)
        {
           return SetDisplayAcceler(_dm,level);
        }

        public int FindWindowByProcess(string process_name,string  class_name,string  title_name)
        {
           return FindWindowByProcess(_dm,process_name, class_name, title_name);
        }

        public int FindWindowByProcessId(int process_id,string  class_name,string  title_name)
        {
           return FindWindowByProcessId(_dm,process_id, class_name, title_name);
        }

        public string ReadIni(string section,string  key,string  file_)
        {
           return ReadIni(_dm,section, key, file_);
        }

        public int WriteIni(string section,string  key,string  v,string  file_)
        {
           return WriteIni(_dm,section, key, v, file_);
        }

        public int RunApp(string path,int  mode)
        {
           return RunApp(_dm,path, mode);
        }

        public int delay(int mis)
        {
           return delay(_dm,mis);
        }

        public int FindWindowSuper(string spec1,int  flag1,int  type1,string  spec2,int  flag2,int  type2)
        {
           return FindWindowSuper(_dm,spec1, flag1, type1, spec2, flag2, type2);
        }

        public string ExcludePos(string all_pos,int  type_,int  x1,int  y1,int  x2,int  y2)
        {
           return ExcludePos(_dm,all_pos, type_, x1, y1, x2, y2);
        }

        public string FindNearestPos(string all_pos,int  type_,int  x,int  y)
        {
           return FindNearestPos(_dm,all_pos, type_, x, y);
        }

        public string SortPosDistance(string all_pos,int  type_,int  x,int  y)
        {
           return SortPosDistance(_dm,all_pos, type_, x, y);
        }

        public int FindPicMem(int x1,int  y1,int  x2,int  y2,string  pic_info,string  delta_color,double  sim,int  dir, out object x, out object y)
        {
           return FindPicMem(_dm,x1, y1, x2, y2, pic_info, delta_color, sim, dir, out x, out y);
        }

        public string FindPicMemEx(int x1,int  y1,int  x2,int  y2,string pic_info,string  delta_color,double  sim,int  dir)
        {
           return FindPicMemEx(_dm,x1, y1, x2, y2,pic_info, delta_color, sim, dir);
        }

        public string FindPicMemE(int x1,int  y1,int  x2,int  y2,string  pic_info,string  delta_color,double  sim,int dir)
        {
           return FindPicMemE(_dm,x1, y1, x2, y2, pic_info, delta_color, sim,dir);
        }

        public string AppendPicAddr(string pic_info,int  addr,int  size)
        {
           return AppendPicAddr(_dm,pic_info, addr, size);
        }

        public int WriteFile(string file_,string  content)
        {
           return WriteFile(_dm,file_, content);
        }

        public int Stop(int id)
        {
           return Stop(_dm,id);
        }

        public int SetDictMem(int index,int  addr,int  size)
        {
           return SetDictMem(_dm,index, addr, size);
        }

        public string GetNetTimeSafe(){
           return GetNetTimeSafe(_dm);
        }

        public int ForceUnBindWindow(int hwnd)
        {
           return ForceUnBindWindow(_dm,hwnd);
        }

        public string ReadIniPwd(string section,string  key,string  file_,string  pwd)
        {
           return ReadIniPwd(_dm,section, key, file_, pwd);
        }

        public int WriteIniPwd(string section,string  key,string  v,string  file_,string  pwd)
        {
           return WriteIniPwd(_dm,section, key, v, file_, pwd);
        }

        public int DecodeFile(string file_,string  pwd)
        {
           return DecodeFile(_dm,file_, pwd);
        }

        public int KeyDownChar(string key_str)
        {
           return KeyDownChar(_dm,key_str);
        }

        public int KeyUpChar(string key_str)
        {
           return KeyUpChar(_dm,key_str);
        }

        public int KeyPressChar(string key_str)
        {
           return KeyPressChar(_dm,key_str);
        }

        public int KeyPressStr(string key_str,int  delay)
        {
           return KeyPressStr(_dm,key_str, delay);
        }

        public int EnableKeypadPatch(int en)
        {
           return EnableKeypadPatch(_dm,en);
        }

        public int EnableKeypadSync(int en,int  time_out)
        {
           return EnableKeypadSync(_dm,en, time_out);
        }

        public int EnableMouseSync(int en,int  time_out)
        {
           return EnableMouseSync(_dm,en, time_out);
        }

        public int DmGuard(int en,string  type_)
        {
           return DmGuard(_dm,en, type_);
        }

        public int FaqCaptureFromFile(int x1,int  y1,int  x2,int  y2,string  file_,int  quality)
        {
           return FaqCaptureFromFile(_dm,x1, y1, x2, y2, file_, quality);
        }

        public string FindIntEx(int hwnd,string  addr_range,int  int_value_min,int  int_value_max,int  type_,int  step,int  multi_thread,int  mode)
        {
           return FindIntEx(_dm,hwnd, addr_range, int_value_min, int_value_max, type_, step, multi_thread, mode);
        }

        public string FindFloatEx(int hwnd,string  addr_range,Single  float_value_min,Single  float_value_max,int  step,int  multi_thread,int  mode)
        {
           return FindFloatEx(_dm,hwnd, addr_range, float_value_min, float_value_max, step, multi_thread, mode);
        }

        public string FindDoubleEx(int hwnd,string  addr_range,double  double_value_min,double  double_value_max,int  step,int  multi_thread,int  mode)
        {
           return FindDoubleEx(_dm,hwnd, addr_range, double_value_min, double_value_max, step, multi_thread, mode);
        }

        public string FindStringEx(int hwnd,string  addr_range,string  string_value,int  type_,int  step,int  multi_thread,int  mode)
        {
           return FindStringEx(_dm,hwnd, addr_range, string_value, type_, step, multi_thread, mode);
        }

        public string FindDataEx(int hwnd,string  addr_range,string  data,int  step,int  multi_thread,int  mode)
        {
           return FindDataEx(_dm,hwnd, addr_range, data, step, multi_thread, mode);
        }

        public int EnableRealMouse(int en,int  mousedelay,int  mousestep)
        {
           return EnableRealMouse(_dm,en, mousedelay, mousestep);
        }

        public int EnableRealKeypad(int en)
        {
           return EnableRealKeypad(_dm,en);
        }

        public int SendStringIme(string str)
        {
           return SendStringIme(_dm,str);
        }

        public int FoobarDrawLine(int hwnd,int  x1,int  y1,int  x2,int  y2,string  color,int  style,int  width)
        {
           return FoobarDrawLine(_dm,hwnd, x1, y1, x2, y2, color, style, width);
        }

        public string FindStrEx(int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim)
        {
           return FindStrEx(_dm,x1, y1, x2, y2, str, color, sim);
        }

        public int IsBind(int hwnd)
        {
           return IsBind(_dm,hwnd);
        }

        public int SetDisplayDelay(int t)
        {
           return SetDisplayDelay(_dm,t);
        }

        public int GetDmCount(){
           return GetDmCount(_dm);
        }

        public int DisableScreenSave(){
           return DisableScreenSave(_dm);
        }

        public int DisablePowerSave(){
           return DisablePowerSave(_dm);
        }

        public int SetMemoryHwndAsProcessId(int en)
        {
           return SetMemoryHwndAsProcessId(_dm,en);
        }

        public int FindShape(int x1,int  y1,int  x2,int  y2,string  offset_color,double  sim,int  dir, out object x, out object y)
        {
           return FindShape(_dm,x1, y1, x2, y2, offset_color, sim, dir, out x, out y);
        }

        public string FindShapeE(int x1,int  y1,int  x2,int  y2,string  offset_color,double  sim,int  dir)
        {
           return FindShapeE(_dm,x1, y1, x2, y2, offset_color, sim, dir);
        }

        public string FindShapeEx(int x1,int  y1,int  x2,int  y2,string  offset_color,double  sim,int  dir)
        {
           return FindShapeEx(_dm,x1, y1, x2, y2, offset_color, sim, dir);
        }

        public string FindStrS(int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim, out object x, out object y)
        {
           return FindStrS(_dm,x1, y1, x2, y2, str, color, sim, out x, out y);
        }

        public string FindStrExS(int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim)
        {
           return FindStrExS(_dm,x1, y1, x2, y2, str, color, sim);
        }

        public string FindStrFastS(int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim, out object x, out object y)
        {
           return FindStrFastS(_dm,x1, y1, x2, y2, str, color, sim, out x, out y);
        }

        public string FindStrFastExS(int x1,int  y1,int  x2,int  y2,string  str,string  color,double  sim)
        {
           return FindStrFastExS(_dm,x1, y1, x2, y2, str, color, sim);
        }

        public string FindPicS(int x1,int  y1,int  x2,int  y2,string  pic_name,string  delta_color,double  sim,int  dir, out object x, out object y)
        {
           return FindPicS(_dm,x1, y1, x2, y2, pic_name, delta_color, sim, dir, out x, out y);
        }

        public string FindPicExS(int x1,int  y1,int  x2,int  y2,string  pic_name,string  delta_color,double  sim,int  dir)
        {
           return FindPicExS(_dm,x1, y1, x2, y2, pic_name, delta_color, sim, dir);
        }

        public int ClearDict(int index)
        {
           return ClearDict(_dm,index);
        }

        public string GetMachineCodeNoMac(){
           return GetMachineCodeNoMac(_dm);
        }

        public int GetClientRect(int hwnd, out object x1, out object y1, out object x2, out object y2)
        {
           return GetClientRect(_dm,hwnd, out x1, out y1, out x2, out y2);
        }

        public int EnableFakeActive(int en)
        {
           return EnableFakeActive(_dm,en);
        }

        public int GetScreenDataBmp(int x1,int  y1,int  x2,int  y2, out object data, out object size)
        {
           return GetScreenDataBmp(_dm,x1, y1, x2, y2, out data, out size);
        }

        public int EncodeFile(string file_,string  pwd)
        {
           return EncodeFile(_dm,file_, pwd);
        }

        public string GetCursorShapeEx(int type_)
        {
           return GetCursorShapeEx(_dm,type_);
        }

        public int FaqCancel(){
           return FaqCancel(_dm);
        }

        public string IntToData(int int_value,int  type_)
        {
           return IntToData(_dm,int_value, type_);
        }

        public string FloatToData(Single float_value)
        {
           return FloatToData(_dm,float_value);
        }

        public string DoubleToData(double double_value)
        {
           return DoubleToData(_dm,double_value);
        }

        public string StringToData(string string_value,int  type_)
        {
           return StringToData(_dm,string_value, type_);
        }

        public int SetMemoryFindResultToFile(string file_)
        {
           return SetMemoryFindResultToFile(_dm,file_);
        }

        public int EnableBind(int en)
        {
           return EnableBind(_dm,en);
        }

        public int SetSimMode(int mode)
        {
           return SetSimMode(_dm,mode);
        }

        public int LockMouseRect(int x1,int  y1,int  x2,int  y2)
        {
           return LockMouseRect(_dm,x1, y1, x2, y2);
        }

        public int SendPaste(int hwnd)
        {
           return SendPaste(_dm,hwnd);
        }

        public int IsDisplayDead(int x1,int  y1,int  x2,int  y2,int  t)
        {
           return IsDisplayDead(_dm,x1, y1, x2, y2, t);
        }

        public int GetKeyState(int vk)
        {
           return GetKeyState(_dm,vk);
        }

        public int CopyFile(string src_file,string  dst_file,int  over)
        {
           return CopyFile(_dm,src_file, dst_file, over);
        }

        public int IsFileExist(string file_)
        {
           return IsFileExist(_dm,file_);
        }

        public int DeleteFile(string file_)
        {
           return DeleteFile(_dm,file_);
        }

        public int MoveFile(string src_file,string  dst_file)
        {
           return MoveFile(_dm,src_file, dst_file);
        }

        public int CreateFolder(string folder_name)
        {
           return CreateFolder(_dm,folder_name);
        }

        public int DeleteFolder(string folder_name)
        {
           return DeleteFolder(_dm,folder_name);
        }

        public int GetFileLength(string file_)
        {
           return GetFileLength(_dm,file_);
        }

        public string ReadFile(string file_)
        {
           return ReadFile(_dm,file_);
        }

        public int WaitKey(int key_code,int  time_out)
        {
           return WaitKey(_dm,key_code, time_out);
        }

        public int DeleteIni(string section,string  key,string  file_)
        {
           return DeleteIni(_dm,section, key, file_);
        }

        public int DeleteIniPwd(string section,string  key,string  file_,string  pwd)
        {
           return DeleteIniPwd(_dm,section, key, file_, pwd);
        }

        public int EnableSpeedDx(int en)
        {
           return EnableSpeedDx(_dm,en);
        }

        public int EnableIme(int en)
        {
           return EnableIme(_dm,en);
        }

        public int Reg(string code,string  Ver)
        {
           return Reg(_dm,code, Ver);
        }

        public string SelectFile(){
           return SelectFile(_dm);
        }

        public string SelectDirectory(){
           return SelectDirectory(_dm);
        }

        public int LockDisplay(int lock1)
        {
           return LockDisplay(_dm,lock1);
        }

        public int FoobarSetSave(int hwnd,string  file_,int  en,string   header)
        {
           return FoobarSetSave(_dm,hwnd, file_, en,  header);
        }

        public string EnumWindowSuper(string spec1,int  flag1,int  type1,string  spec2,int  flag2,int  type2,int  sort)
        {
           return EnumWindowSuper(_dm,spec1, flag1, type1, spec2, flag2, type2, sort);
        }

        public int DownloadFile(string url,string  save_file,int  timeout)
        {
           return DownloadFile(_dm,url, save_file, timeout);
        }

        public int EnableKeypadMsg(int en)
        {
           return EnableKeypadMsg(_dm,en);
        }

        public int EnableMouseMsg(int en)
        {
           return EnableMouseMsg(_dm,en);
        }

        public int RegNoMac(string code,string  Ver)
        {
           return RegNoMac(_dm,code, Ver);
        }

        public int RegExNoMac(string code,string  Ver,string  ip)
        {
           return RegExNoMac(_dm,code, Ver, ip);
        }

        public int SetEnumWindowDelay(int delay)
        {
           return SetEnumWindowDelay(_dm,delay);
        }

        public int FindMulColor(int x1,int  y1,int  x2,int  y2,string  color,double  sim)
        {
           return FindMulColor(_dm,x1, y1, x2, y2, color, sim);
        }

        public string GetDict(int index,int  font_index)
        {
           return GetDict(_dm,index, font_index);
        }





        #region 继承释放接口方法
        public void Dispose()
        {
            //必须为true
            Dispose(true);
            //通知垃圾回收机制不再调用终结器（析构器）
            GC.SuppressFinalize(this);
        }

        public void Close()
        {
            Dispose();
        }

        ~C_DmSoft()
        {
            //必须为false
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                // 清理托管资源
                //if (managedResource != null)
                //{
                //    managedResource.Dispose();
                //    managedResource = null;
                //}
            }
            // 清理非托管资源
            if (_dm != IntPtr.Zero)
            {
                UnBindWindow();
                _dm = IntPtr.Zero;
            }
            //让类型知道自己已经被释放
            disposed = true;
        }
        #endregion
    }
}
