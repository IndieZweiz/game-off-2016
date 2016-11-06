Imports System.ComponentModel
Imports System.Reflection

Friend Class frmMDI

    Private Declare Function SetActiveWindow Lib "user32.dll" (ByVal hwnd As Integer) As Integer
    Private Declare Function timeGetTime Lib "winmm.dll" () As Integer
    Private Declare Function timeBeginPeriod Lib "winmm.dll" (ByVal uPeriod As Integer) As Integer

    Private Declare Function GetWindowLong Lib "user32.dll" Alias "GetWindowLongA" (ByVal handle As IntPtr, ByVal nIndex As Integer) As Integer
    Private Declare Function SetWindowLong Lib "user32.dll" Alias "SetWindowLongA" (ByVal handle As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer

    Private isRunning As Boolean
    Private ProcessStartmS As Integer

    Private activeRadio As RadioButton
    Private listHandles As List(Of Integer)

    Public Sub New()
        InitializeComponent()
        StartHooking()
        hideWindows()

        Dim ass As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly
        listHandles = New List(Of Integer)

        timeBeginPeriod(1)
        refParent = Me
    End Sub

    Private Sub frmMDI_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each c As Control In Me.Controls
            If TypeOf c Is MdiClient Then
                Dim exstyle As Integer = GetWindowLong(c.Handle, -20)
                exstyle = exstyle And Not &H200
                SetWindowLong(c.Handle, -20, exstyle)
                c.BackColor = Me.BackColor
                AddHandler c.Click, AddressOf deactivateTaskbar
                Exit For
            End If
        Next

        'Me.Size = Screen.PrimaryScreen.Bounds.Size
        Me.Size = New Size(800, 600)

        Dim i As New Label()
        i.Text = "HELLO WORLD"
        i.Image = My.Resources.StairsOS.stairs

        pSysIcon.Controls.Add(i)
        pSysIcon.Width += i.Width
        pNotification.Width += i.Width
        pStairs.Size = cmMenu.Size
        pStairs.Location = New Point(0, Me.Size.Height - pStairs.Size.Height - pTaskbar.Size.Height)

        Me.Show()
        mainLoop()
    End Sub

    Private Sub BSOD()
        showDesktop(Me, Nothing)
        pTaskbar.Hide()
        Me.ContextMenuStrip = Nothing
        frmBSOD.MdiParent = Me
        frmBSOD.Dock = DockStyle.Fill
        frmBSOD.Show()
    End Sub

    Private Sub regulatedDelay(ByVal mS As Integer)
        Dim StartmS As Integer
        Dim ElapsedmS As Integer
        StartmS = timeGetTime
        If ProcessStartmS <> 0 Then
            mS = mS - (StartmS - ProcessStartmS)
            Do While (ElapsedmS < mS)
                ElapsedmS = (timeGetTime - StartmS)
                Application.DoEvents()
            Loop
        End If
        ProcessStartmS = timeGetTime()
    End Sub

    Private Sub mainLoop()
        isRunning = True
        'BSOD()
        While isRunning
            regulatedDelay(1000)

            Me.lTime.Text = Now.ToShortTimeString
            Me.lDate.Text = Now.ToShortDateString
        End While
        Me.Close()
    End Sub

    Friend Sub closeForm(form As Form, e As FormClosingEventArgs)
        form.Hide()
        form.Tag.Visible = False
        e.Cancel = True
    End Sub

    Private Sub resizeForm(form As Form, e As EventArgs)
        If form.WindowState = FormWindowState.Maximized Then
            form.WindowState = FormWindowState.Normal
            form.Size = New Size(ClientRectangle.Width, ClientRectangle.Height - pTaskbar.Height)
            form.Location = New Point(0, 0)
        ElseIf form.WindowState = FormWindowState.Minimized Then
            form.Visible = False
            form.WindowState = FormWindowState.Normal
            deactivateTaskbar()
        End If
    End Sub

    Private Sub deactivateTaskbar()
        If Not activeRadio Is Nothing Then
            activeRadio.Checked = False
            activeRadio = Nothing
        End If
    End Sub

    Friend Sub openProcess(title As String, handle As Integer)
        addNewRadio(title, handle)
        listHandles.Add(handle)
    End Sub

    Friend Sub openForm(form As Form)
        If Me.MdiChildren.Contains(form) Then
            changeActiveWindow(form, Nothing)
            form.Show()
            form.Tag.BringToFront()
            form.Tag.Visible = True
            'form.Activate()
            'changeTaskbar(form, Nothing)
        Else
            AddHandler form.Load, AddressOf preventMoveOutsideMDI
            AddHandler form.Move, AddressOf preventMoveOutsideMDI
            'AddHandler form.SizeChanged, AddressOf resizeForm
            AddHandler form.Resize, AddressOf resizeForm
            AddHandler form.FormClosing, AddressOf closeForm
            AddHandler form.Click, AddressOf changeActiveWindow
            form.MdiParent = Me
            form.Tag = addNewRadio(form.Text, form)
            form.Show()
            changeActiveWindow(form, Nothing)
        End If
    End Sub

    Private Function addNewRadio(title As Object, tag As Object) As RadioButton
        Dim rb As New RadioButton
        If TypeOf tag Is Form Then AddHandler rb.GotFocus, AddressOf changeActiveWindow _
            Else AddHandler rb.CheckedChanged, AddressOf changeActiveWindow
        rb.Tag = tag
        rb.Text = title
        rb.Appearance = Appearance.Button
        rb.Dock = DockStyle.Left

        pTaskbar.Controls.Add(rb)
        rb.BringToFront()
        Return rb
    End Function

#Region " taskbar effects "

    Private Sub preventMoveOutsideMDI(form As Form, e As EventArgs)

        If form.WindowState = FormWindowState.Maximized Then
            resizeForm(form, e)
        Else
            If form.Left < 0 Then
                form.Hide()
                form.Left = 0
                form.Show()
            ElseIf form.Left > ClientRectangle.Width - form.Width Then
                form.Hide()
                form.Left = ClientRectangle.Width - form.Width
                form.Show()
            End If
            If form.Top < 0 Then
                form.Hide()
                form.Top = 0
                form.Show()
            ElseIf form.Top > ClientRectangle.Height - form.Height - pTaskbar.Height Then
                form.Hide()
                form.Top = ClientRectangle.Height - form.Height - pTaskbar.Height
                form.Show()
            End If
        End If
    End Sub

    Private Sub changeActiveWindow(sender As Object, e As Object)
        Debug.Print(Now & "changeTaskbar fired by " & sender.Text)
        If TypeOf sender Is Form Then ' fired by form
            If Not activeRadio Is Nothing Then activeRadio.Checked = False
            activeRadio = sender.tag
            activeRadio.Checked = True
        ElseIf TypeOf sender Is RadioButton Then 'fired by radio
            If TypeOf sender.tag Is Form Then ' radio pointing to form
                Dim form As Form = sender.Tag
                form.WindowState = FormWindowState.Normal
                form.Show()
                form.Activate()
                activeRadio = sender
            Else
                If sender.checked Then
                    Try
                        Dim p As Process = getProcess(sender.tag)
                        If Not p Is Nothing Then AppActivate(sender.tag)
                    Catch ex As Exception
                        logError(ex, Reflection.MethodBase.GetCurrentMethod)
                    End Try
                End If
            End If ' radio checked
        Else
            Throw New Exception("Unknown sendeR: " & VarType(sender))
        End If ' typeof sender
        'mi.BackgroundImage = imgTaskbarActive
    End Sub

    Private Sub rbStairs_CheckedChanged(sender As Object, e As EventArgs) Handles rbStairs.CheckedChanged
        If rbStairs.Checked Then
            pStairs.Show()
            cmMenu.Show(pStairs.Location)
        Else
            pStairs.Hide()
            cmMenu.Hide()
        End If
    End Sub

    Private Sub hideStairs(sender As Object, e As ToolStripDropDownClosingEventArgs) Handles cmMenu.Closing
        rbStairs.Checked = False
        pStairs.Hide()
    End Sub

#End Region

#Region " menu items "

    Private Sub showDesktop(sender As Object, e As EventArgs) Handles miShowDesktop.Click, bShowDesktop.Click
        deactivateTaskbar()
        For Each form As Form In Me.MdiChildren
            form.Hide()
        Next
    End Sub

    Private Function getProcess(id As Integer) As Process
        Dim list() As Process = Process.GetProcesses()
        Return list.FirstOrDefault(Function(p) p.Id = id)
    End Function

    Private Sub miShutdown_Click(sender As Object, e As EventArgs) Handles miShutdown.Click
        For Each handle As Integer In listHandles
            Try
                Dim p As Process = getProcess(handle)
                If Not p Is Nothing Then p.CloseMainWindow()
            Catch ex As Exception

            End Try
        Next
        Me.Close()
    End Sub

    Private Sub miWindowsCascade_Click(sender As Object, e As EventArgs) Handles miWindowsCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub miWindowsStacked_Click(sender As Object, e As EventArgs) Handles miWindowsStacked.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub miWindowsSide_Click(sender As Object, e As EventArgs) Handles miWindowsSide.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub miRun_Click(sender As Object, e As EventArgs) Handles miRun.Click
        openForm(frmRun)
    End Sub

    Private Sub miPersonalize_Click(sender As Object, e As EventArgs) Handles miPersonalize.Click
        openForm(frmPersonalize)
    End Sub

    Private Sub miScreenResolution_Click(sender As Object, e As EventArgs) Handles miScreenResolution.Click
        openForm(frmScreenResolution)
    End Sub

    Private Sub bShowDesktop_MouseLeave(sender As Object, e As EventArgs) Handles bShowDesktop.MouseLeave
        bShowDesktop.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub bShowDesktop_MouseDown(sender As Object, e As MouseEventArgs) Handles bShowDesktop.MouseDown
        bShowDesktop.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub frmMDI_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If isRunning Then
            'Process.Start("explorer")
            UnhookWindowsHookEx()
            showWindows()
            isRunning = False
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAbout.Show()
    End Sub

    Private Sub miExplorer_Click(sender As Object, e As EventArgs) Handles miExplorer.Click
        openForm(frmExplorer)
    End Sub

#End Region

End Class