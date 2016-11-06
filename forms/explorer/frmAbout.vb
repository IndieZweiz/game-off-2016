Friend Class frmAbout

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lAbout.Text = "Stairs OS ™" & vbNewLine &
            "Version " & Application.ProductVersion & vbNewLine &
            "Developed by Zweiz"
    End Sub

End Class