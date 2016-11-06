Friend Class frmRun
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Try
            Dim handle As Integer = Shell(cboRun.Text, AppWinStyle.NormalNoFocus)
            frmMDI.openProcess(cboRun.Text, handle)
            refParent.closeForm(Me, e)
        Catch ex As Exception
            MsgBox("Stairs cannot find '" & cboRun.Text & "'. Make sure you type the name correctly, then try again.", MsgBoxStyle.Critical, cboRun.Text)
        End Try
    End Sub

    Private Sub frmRun_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then Me.Location = New Point(0, frmMDI.Size.Height - frmMDI.pTaskbar.Height - Me.Height - 4)
    End Sub

    Friend Sub FakeClose() Handles btnOk.Click, btnCancel.Click
        Me.Hide()
        Me.Tag.Visible = False
    End Sub

End Class