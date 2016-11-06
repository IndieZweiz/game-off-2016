<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lAbout = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lAbout
        '
        Me.lAbout.AutoSize = True
        Me.lAbout.Location = New System.Drawing.Point(45, 82)
        Me.lAbout.Name = "lAbout"
        Me.lAbout.Size = New System.Drawing.Size(51, 13)
        Me.lAbout.TabIndex = 0
        Me.lAbout.Text = "Stairs OS"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 272)
        Me.Controls.Add(Me.lAbout)
        Me.Name = "frmAbout"
        Me.Text = "frmAbout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lAbout As Label
End Class
