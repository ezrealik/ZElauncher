// ZEModule.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
//获取CSGO注册表目录
extern "C" BOOL _declspec(dllexport) WINAPI _GetCSGOPath(LPBYTE BufferStr, DWORD BufferLen) {
	//获取注册表
	char GamePathKey[] = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Steam App 730\\";
	//HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 730
	HKEY hKey;
	int Rkey = RegOpenKeyEx(HKEY_LOCAL_MACHINE, GamePathKey, NULL, KEY_WOW64_64KEY | KEY_READ, &hKey);
	if (Rkey != ERROR_SUCCESS) {
		return FALSE;
	}
	else {
		int Rread = RegQueryValueEx(hKey, "InstallLocation", NULL, NULL, BufferStr, &BufferLen);
		if (Rread != ERROR_SUCCESS) {
			return FALSE;
		}
		else {
			return TRUE;
		}
	}
	return FALSE;
}
//获取CSGO进程目录
extern "C" _declspec(dllexport) BOOL WINAPI _GetProcessCSGOPath(LPBYTE BufPath, DWORD Buflen) {
	HANDLE Snap = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, NULL);
	PROCESSENTRY32 ProcessEntry32 = { sizeof(ProcessEntry32) ,0 };
	if (!Process32First(Snap, &ProcessEntry32)) {
		return FALSE;
	}
	do 
	{
		if (strcmp(ProcessEntry32.szExeFile, "csgo.exe") == 0 || strcmp(ProcessEntry32.szExeFile, "CSGO.exe") == 0) {
#pragma region 提升进程权限
			//// 取得当前进程的[Token](标识)句柄
			//HANDLE hToken;
			//if (!OpenProcessToken(GetCurrentProcess(), TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, &hToken)) {
			//	if (GetLastError() == ERROR_CALL_NOT_IMPLEMENTED) {
			//		return true;
			//	}
			//	else {
			//		return false;
			//	}
			//}
			//// 取得调试的[LUID](本地唯一的标识符)值
			//TOKEN_PRIVILEGES tokenPrivilege = { 0 };
			//TOKEN_PRIVILEGES oldPrivilege = { 0 };
			//DWORD dwPrivilegeSize;
			//if (!LookupPrivilegeValue(NULL, SE_DEBUG_NAME, &tokenPrivilege.Privileges[0].Luid)) {
			//	CloseHandle(hToken);
			//	return false;
			//}
			//// 设置特权数组的元素个数
			//tokenPrivilege.PrivilegeCount = 1;
			//// 设置[LUID]的属性值
			//tokenPrivilege.Privileges[0].Attributes = SE_PRIVILEGE_ENABLED;
			//// 为当前进程取得DEBUG权限
			//if (!AdjustTokenPrivileges(hToken, FALSE, &tokenPrivilege, sizeof(TOKEN_PRIVILEGES), &oldPrivilege, &dwPrivilegeSize)) {
			//	CloseHandle(hToken);
			//	return false;
			//}
#pragma  endregion
			/* 获取程序路径,需要管理权限...
			HANDLE Pro = OpenProcess(PROCESS_ALL_ACCESS, false, ProcessEntry32.th32ProcessID);
			if (Pro == INVALID_HANDLE_VALUE) {
				CopyMemory(BufPath, "进程获取失败,请确认是否管理员运行!", 35);
				return FALSE;
			}
			char buf[1024];
			if (!GetModuleFileNameEx(Pro, NULL, buf, sizeof(buf))) {
				//程序结束时要记得释放句柄
				CloseHandle(hToken);
				CloseHandle(Pro);
				CloseHandle(Snap);
				CopyMemory(BufPath, "程序信息获取出错,请确认是否管理员运行!", 39);
				return FALSE;
			}
			if (Buflen <= sizeof(buf)) {
				CopyMemory(BufPath, buf, Buflen);
			}
			else {
				CopyMemory(BufPath, buf, sizeof(buf));
			}
			//程序结束时要记得释放句柄
			CloseHandle(hToken);
			CloseHandle(Pro);
			CloseHandle(Snap);
			*/
			HANDLE mSnap = CreateToolhelp32Snapshot(TH32CS_SNAPMODULE32 | TH32CS_SNAPMODULE, ProcessEntry32.th32ProcessID);
			MODULEENTRY32 moduleentry32 = { sizeof(moduleentry32),0 };
			if (!Module32First(mSnap, &moduleentry32)) {
				return FALSE;
			}
			int len = strlen(moduleentry32.szExePath);
			if (len <= (int)Buflen) {
				CopyMemory(BufPath, moduleentry32.szExePath, len);
			}
			else
			{
				CopyMemory(BufPath, moduleentry32.szExePath, Buflen);
			}
			char *cp = strrchr((char*)BufPath, '\\');
			if (cp) {
				ZeroMemory(cp, strlen(cp));
			}
			CloseHandle(Snap);
			CloseHandle(mSnap);
			return TRUE;
		}
	} while (Process32Next(Snap, &ProcessEntry32));
	CloseHandle(Snap);
	return FALSE;
}
//去除.exe取目录名
extern "C" _declspec(dllexport) BOOL WINAPI _DeleteSuffix(char* BufPath, char Suffix) {
	char *cp = strrchr(BufPath, Suffix);
	if (cp) {
		ZeroMemory(cp, strlen(cp));
		return true;
	}
	else {
		return false;
	}
}
