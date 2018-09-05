using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ZElauncher
{
    static class WIN32API
    {
        #region WinAPI
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        public static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        //消息定义;
        public const int VM_NCLBUTTONDOWN = 0XA1;//定义鼠标左键按下
        public const int HTCAPTION = 2;
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MINIMIZE = 0xF020;
        //判断进程是否存在;
        public static bool IsProcessExist(string cmp)
        {
            {
                Process[] processList = Process.GetProcesses();
                foreach (System.Diagnostics.Process process in processList)
                {
                    string a = process.ProcessName.ToUpper(), b = cmp.ToUpper();
                    if (string.Compare(a, b) == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        #endregion

    }
}
