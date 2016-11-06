Friend Class frmScreenResolution
    Public Sub New()
        InitializeComponent()

        cboResolution.Items.Add(" " & Screen.PrimaryScreen.Bounds.Width & " x " & Screen.PrimaryScreen.Bounds.Height & " (recommended)")
        cboResolution.SelectedIndex = 0
        cboDisplay.Items.Add(" 1. Display device on: " & Screen.PrimaryScreen.DeviceName)
        cboDisplay.SelectedIndex = 0
        cboOrientation.SelectedIndex = 0
    End Sub

    Friend Sub FakeClose() Handles btnOk.Click, btnCancel.Click
        Me.Hide()
        Me.Tag.Visible = False
    End Sub

End Class