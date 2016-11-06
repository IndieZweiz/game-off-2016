Friend Class frmExplorer

    Private Sub frmExplorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each file As String In My.Computer.FileSystem.GetFiles("/")
            lvExplorer.Items.Add(New ListViewItem(file))
        Next
    End Sub

End Class