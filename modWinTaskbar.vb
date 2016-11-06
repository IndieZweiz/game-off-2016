Imports System.Runtime.InteropServices

Module modCopyPasta

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As SetWindowPosFlags) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Function EnableWindow(ByVal hWnd As IntPtr, ByVal bEnable As Boolean) As Boolean
    End Function

    Private Declare Function ShowWindow Lib "user32" (ByVal handle As IntPtr, ByVal nCmdShow As Integer) As Integer

    Private Declare Auto Function FindWindowEx _
        Lib "user32.dll" (ByVal hwndParent As IntPtr, ByVal hwndChildAfter As IntPtr, ByVal lpszClass As String, ByVal lpszWindow As String) As IntPtr

    <Flags>
    Private Enum SetWindowPosFlags As UInteger
        SynchronousWindowPosition = &H4000
        DeferErase = &H2000
        DrawFrame = &H20
        FrameChanged = &H20
        HideWindow = &H80
        DoNotActivate = &H10
        DoNotCopyBits = &H100
        IgnoreMove = &H2
        DoNotChangeOwnerZOrder = &H200
        DoNotRedraw = &H8
        DoNotReposition = &H200
        DoNotSendChangingEvent = &H400
        IgnoreResize = &H1
        IgnoreZOrder = &H4
        ShowWindow = &H40
    End Enum

    Dim StartButtonhWnd As Integer = 0

    Friend Sub hideWindows()
        Dim window As IntPtr = FindWindow("Shell_traywnd", "")
        SetWindowPos(window, IntPtr.Zero, 0, 0, 0, 0, SetWindowPosFlags.HideWindow)
        StartButtonhWnd = FindWindow("Button", "Start")
        ShowWindow(StartButtonhWnd, 0) 'hide start button
        EnableWindow(CType(StartButtonhWnd, IntPtr), False)
    End Sub

    Friend Sub showWindows()
        Dim window As IntPtr = FindWindow("Shell_traywnd", "")
        SetWindowPos(window, IntPtr.Zero, 0, 0, 0, 0, SetWindowPosFlags.ShowWindow)
        Dim ultimo As Integer = FindWindowEx(window, 0, "Button", vbNullString)
        ShowWindow(StartButtonhWnd, 5)
        EnableWindow(CType(StartButtonhWnd, IntPtr), True)
    End Sub

    'Disable/Enable Start button 
    'Public Sub StartButton(show As Boolean)
    '    Dim primo As Integer
    '    Dim ultimo As Integer

    '    Dim primo As Integer = FindWindow("Shell_TrayWnd", "")
    '    ultimo = FindWindowEx(primo, 0, "Button", vbNullString)
    '    If show = True Then
    '        ShowWindow(ultimo, 5) 'show start button
    '    Else
    '        ShowWindow(ultimo, 0) 'hide start button
    '    End If
    'End Sub

End Module
