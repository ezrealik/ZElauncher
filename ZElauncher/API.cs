using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Net;

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
        [DllImport("ZEModule.dll")]
        public static extern bool _GetCSGOPath(StringBuilder Bufferstr,int strlen);
        [DllImport("ZEModule.dll")]
        public static extern bool _GetProcessCSGOPath(StringBuilder Bufferstr, int strlen);
        [DllImport("ZEModule.dll")]
        public static extern bool _DeleteSuffix(StringBuilder Bufferstr, char str);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookie(string lpszUrlName, string lbszCookieName, string lpszCookieData);
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
        public static string GetContentFromUrl(string url)
        {
            try
            {
                WebClient client = new WebClient();
                client.Credentials = CredentialCache.DefaultCredentials;//获取或设置请求凭据
                Byte[] pageData = client.DownloadData(url); //下载数据
                string pageHtml = System.Text.Encoding.UTF8.GetString(pageData);
                return pageHtml;
            }
            catch (WebException ex)
            {
                return ex.Message;
            }
        }
        public static string UnixToDateTime(string Unix)
        {
            long unixTimeStamp;
            long.TryParse(Unix, out unixTimeStamp);
            if (unixTimeStamp > 0x7FFF)
            {
                System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
                DateTime dt = startTime.AddSeconds(unixTimeStamp);
                return dt.ToString("yyyy/MM/dd HH:mm");
            }
            return "";
        }
        public static string GetSizeKB(string Size)
        {
            long DataSize;
            long.TryParse(Size, out DataSize);
            string SizeKb;
            int cout = 0;
            while (DataSize > 1024)
            {
                DataSize /= 1024;
                cout++;
            }
            switch (cout)
            {
                case 1:
                    SizeKb = string.Format("{0}/KB", DataSize);
                    break;
                case 2:
                    SizeKb = string.Format("{0}/MB", DataSize);
                    break;
                case 3:
                    SizeKb = string.Format("{0}/GB", DataSize);
                    break;
                case 4:
                    SizeKb = string.Format("{0}/TB", DataSize);
                    break;
                default:
                    SizeKb = string.Format("{0}/B", DataSize);
                    break;
            }
            return SizeKb;
        }
        #endregion

    }
}
