
Option Strict On
Imports System.Runtime.InteropServices

Module modDisableKey

    ' provided by kshadow22
    ' https://www.youtube.com/watch?v=eTXxOK_iFlU

    Private Const KEYEVENTF_EXTENDEDKEY As Long = &H1
    Private Const KEYEVENTF_KEYUP As Long = &H2
    Private Const VK_LWIN As Byte = &H5B
    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte,
    ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)

    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYUP As Integer = &H101
    Private _proc As LowLevelKeyboardProc = AddressOf HookCallback
    Private _hookID As IntPtr = IntPtr.Zero

    Private Declare Auto Function SetWindowsHookEx _
        Lib "user32.dll" (ByVal idHook As Integer, ByVal lpfn As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr

    Private Declare Auto Function UnhookWindowsHookEx _
        Lib "user32.dll" (ByVal hhk As IntPtr) As IntPtr

    Private Declare Auto Function CallNextHookEx _
        Lib "user32.dll" (ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Declare Auto Function GetModuleHandle _
        Lib "kernel32.dll" (ByVal lpModuleName As String) As IntPtr

    Private Function SetHook(ByVal proc As LowLevelKeyboardProc) As IntPtr

        Dim curProcess As Process = Process.GetCurrentProcess()
        Dim curModule As ProcessModule = curProcess.MainModule

        Return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0)

    End Function

    Public Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Public Function HookCallback(
        ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

        If nCode >= 0 And wParam = CType(WM_KEYUP, IntPtr) Then
            Dim vkCode As Keys = CType(Marshal.ReadInt32(lParam), Keys)
            If vkCode = Keys.LWin Or vkCode = Keys.RWin Then
                keybd_event(CByte(Keys.Zoom), 0, KEYEVENTF_EXTENDEDKEY, 0)
            End If
        End If

        Return CallNextHookEx(_hookID, nCode, wParam, lParam)
    End Function

    Friend Sub StartHooking() ' Handles MyBase.Load
        _hookID = SetHook(_proc)
    End Sub

    Friend Sub UnhookWindowsHookEx() 'Handles Me.FormClosed
        UnhookWindowsHookEx(_hookID)
    End Sub


End Module
