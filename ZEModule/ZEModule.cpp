// ZEModule.cpp : ���� DLL Ӧ�ó���ĵ���������
//

#include "stdafx.h"
//��ȡCSGOע���Ŀ¼
extern "C" BOOL _declspec(dllexport) WINAPI _GetCSGOPath(LPBYTE BufferStr, DWORD BufferLen) {
	//��ȡע���
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
//��ȡCSGO����Ŀ¼
extern "C" _declspec(dllexport) BOOL WINAPI _GetProcessCSGOPath(LPBYTE BufPath, DWORD Buflen) {
	HANDLE Snap = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, NULL);
	PROCESSENTRY32 ProcessEntry32 = { sizeof(ProcessEntry32) ,0 };
	if (!Process32First(Snap, &ProcessEntry32)) {
		return FALSE;
	}
	do 
	{
		if (strcmp(ProcessEntry32.szExeFile, "csgo.exe") == 0 || strcmp(ProcessEntry32.szExeFile, "CSGO.exe") == 0) {
#pragma region ��������Ȩ��
			//// ȡ�õ�ǰ���̵�[Token](��ʶ)���
			//HANDLE hToken;
			//if (!OpenProcessToken(GetCurrentProcess(), TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, &hToken)) {
			//	if (GetLastError() == ERROR_CALL_NOT_IMPLEMENTED) {
			//		return true;
			//	}
			//	else {
			//		return false;
			//	}
			//}
			//// ȡ�õ��Ե�[LUID](����Ψһ�ı�ʶ��)ֵ
			//TOKEN_PRIVILEGES tokenPrivilege = { 0 };
			//TOKEN_PRIVILEGES oldPrivilege = { 0 };
			//DWORD dwPrivilegeSize;
			//if (!LookupPrivilegeValue(NULL, SE_DEBUG_NAME, &tokenPrivilege.Privileges[0].Luid)) {
			//	CloseHandle(hToken);
			//	return false;
			//}
			//// ������Ȩ�����Ԫ�ظ���
			//tokenPrivilege.PrivilegeCount = 1;
			//// ����[LUID]������ֵ
			//tokenPrivilege.Privileges[0].Attributes = SE_PRIVILEGE_ENABLED;
			//// Ϊ��ǰ����ȡ��DEBUGȨ��
			//if (!AdjustTokenPrivileges(hToken, FALSE, &tokenPrivilege, sizeof(TOKEN_PRIVILEGES), &oldPrivilege, &dwPrivilegeSize)) {
			//	CloseHandle(hToken);
			//	return false;
			//}
#pragma  endregion
			/* ��ȡ����·��,��Ҫ����Ȩ��...
			HANDLE Pro = OpenProcess(PROCESS_ALL_ACCESS, false, ProcessEntry32.th32ProcessID);
			if (Pro == INVALID_HANDLE_VALUE) {
				CopyMemory(BufPath, "���̻�ȡʧ��,��ȷ���Ƿ����Ա����!", 35);
				return FALSE;
			}
			char buf[1024];
			if (!GetModuleFileNameEx(Pro, NULL, buf, sizeof(buf))) {
				//�������ʱҪ�ǵ��ͷž��
				CloseHandle(hToken);
				CloseHandle(Pro);
				CloseHandle(Snap);
				CopyMemory(BufPath, "������Ϣ��ȡ����,��ȷ���Ƿ����Ա����!", 39);
				return FALSE;
			}
			if (Buflen <= sizeof(buf)) {
				CopyMemory(BufPath, buf, Buflen);
			}
			else {
				CopyMemory(BufPath, buf, sizeof(buf));
			}
			//�������ʱҪ�ǵ��ͷž��
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
//ȥ��.exeȡĿ¼��
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
