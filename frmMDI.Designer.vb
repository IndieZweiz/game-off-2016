<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMDI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmTaskbar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.miWindowsCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.miWindowsStacked = New System.Windows.Forms.ToolStripMenuItem()
        Me.miWindowsSide = New System.Windows.Forms.ToolStripMenuItem()
        Me.miShowDesktop = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pTaskbar = New System.Windows.Forms.Panel()
        Me.pNotification = New System.Windows.Forms.Panel()
        Me.lDate = New System.Windows.Forms.Label()
        Me.lTime = New System.Windows.Forms.Label()
        Me.bShowDesktop = New System.Windows.Forms.Button()
        Me.pSysIcon = New System.Windows.Forms.Panel()
        Me.rbStairs = New System.Windows.Forms.RadioButton()
        Me.cmStairs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExplorer = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.miPrograms = New System.Windows.Forms.ToolStripMenuItem()
        Me.miDocuments = New System.Windows.Forms.ToolStripMenuItem()
        Me.miControlPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.miRun = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.miLogoff = New System.Windows.Forms.ToolStripMenuItem()
        Me.miShutdown = New System.Windows.Forms.ToolStripMenuItem()
        Me.pStairs = New System.Windows.Forms.Panel()
        Me.cmDesktop = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miScreenResolution = New System.Windows.Forms.ToolStripMenuItem()
        Me.miPersonalize = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmTaskbar.SuspendLayout()
        Me.pTaskbar.SuspendLayout()
        Me.pNotification.SuspendLayout()
        Me.cmStairs.SuspendLayout()
        Me.cmMenu.SuspendLayout()
        Me.cmDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmTaskbar
        '
        Me.cmTaskbar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmTaskbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miWindowsCascade, Me.miWindowsStacked, Me.miWindowsSide, Me.miShowDesktop, Me.ToolStripSeparator1, Me.StartToolStripMenuItem})
        Me.cmTaskbar.Name = "cmTaskbar"
        Me.cmTaskbar.Size = New System.Drawing.Size(218, 120)
        '
        'miWindowsCascade
        '
        Me.miWindowsCascade.Name = "miWindowsCascade"
        Me.miWindowsCascade.Size = New System.Drawing.Size(217, 22)
        Me.miWindowsCascade.Text = "Cascade windows"
        '
        'miWindowsStacked
        '
        Me.miWindowsStacked.Name = "miWindowsStacked"
        Me.miWindowsStacked.Size = New System.Drawing.Size(217, 22)
        Me.miWindowsStacked.Text = "Show windows stacked"
        '
        'miWindowsSide
        '
        Me.miWindowsSide.Name = "miWindowsSide"
        Me.miWindowsSide.Size = New System.Drawing.Size(217, 22)
        Me.miWindowsSide.Text = "Show windows side by side"
        '
        'miShowDesktop
        '
        Me.miShowDesktop.Name = "miShowDesktop"
        Me.miShowDesktop.Size = New System.Drawing.Size(217, 22)
        Me.miShowDesktop.Text = "Show the desktop"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.StartToolStripMenuItem.Text = "Start Task Manager"
        '
        'pTaskbar
        '
        Me.pTaskbar.BackColor = System.Drawing.SystemColors.Control
        Me.pTaskbar.ContextMenuStrip = Me.cmTaskbar
        Me.pTaskbar.Controls.Add(Me.pNotification)
        Me.pTaskbar.Controls.Add(Me.rbStairs)
        Me.pTaskbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pTaskbar.Location = New System.Drawing.Point(0, 154)
        Me.pTaskbar.Name = "pTaskbar"
        Me.pTaskbar.Size = New System.Drawing.Size(800, 39)
        Me.pTaskbar.TabIndex = 3
        '
        'pNotification
        '
        Me.pNotification.BackColor = System.Drawing.SystemColors.Control
        Me.pNotification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pNotification.Controls.Add(Me.lDate)
        Me.pNotification.Controls.Add(Me.lTime)
        Me.pNotification.Controls.Add(Me.bShowDesktop)
        Me.pNotification.Controls.Add(Me.pSysIcon)
        Me.pNotification.Dock = System.Windows.Forms.DockStyle.Right
        Me.pNotification.Location = New System.Drawing.Point(703, 0)
        Me.pNotification.Name = "pNotification"
        Me.pNotification.Size = New System.Drawing.Size(97, 39)
        Me.pNotification.TabIndex = 5
        '
        'lDate
        '
        Me.lDate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDate.Location = New System.Drawing.Point(0, 19)
        Me.lDate.Name = "lDate"
        Me.lDate.Size = New System.Drawing.Size(75, 16)
        Me.lDate.TabIndex = 1
        Me.lDate.Text = "Date"
        Me.lDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lTime
        '
        Me.lTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.lTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTime.Location = New System.Drawing.Point(0, 0)
        Me.lTime.Name = "lTime"
        Me.lTime.Size = New System.Drawing.Size(75, 16)
        Me.lTime.TabIndex = 0
        Me.lTime.Text = "Time"
        Me.lTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bShowDesktop
        '
        Me.bShowDesktop.Dock = System.Windows.Forms.DockStyle.Right
        Me.bShowDesktop.FlatAppearance.BorderSize = 0
        Me.bShowDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bShowDesktop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bShowDesktop.Location = New System.Drawing.Point(75, 0)
        Me.bShowDesktop.Name = "bShowDesktop"
        Me.bShowDesktop.Size = New System.Drawing.Size(18, 35)
        Me.bShowDesktop.TabIndex = 2
        Me.bShowDesktop.UseVisualStyleBackColor = True
        '
        'pSysIcon
        '
        Me.pSysIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.pSysIcon.Location = New System.Drawing.Point(0, 0)
        Me.pSysIcon.Name = "pSysIcon"
        Me.pSysIcon.Size = New System.Drawing.Size(0, 35)
        Me.pSysIcon.TabIndex = 3
        '
        'rbStairs
        '
        Me.rbStairs.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbStairs.BackgroundImage = Global.HelloHacker.My.Resources.StairsOS.stairs
        Me.rbStairs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rbStairs.ContextMenuStrip = Me.cmStairs
        Me.rbStairs.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbStairs.Location = New System.Drawing.Point(0, 0)
        Me.rbStairs.Name = "rbStairs"
        Me.rbStairs.Size = New System.Drawing.Size(73, 39)
        Me.rbStairs.TabIndex = 5
        Me.rbStairs.Text = "Stairs"
        Me.rbStairs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbStairs.UseVisualStyleBackColor = True
        '
        'cmStairs
        '
        Me.cmStairs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PropertiesToolStripMenuItem, Me.miExplorer})
        Me.cmStairs.Name = "cmStairs"
        Me.cmStairs.Size = New System.Drawing.Size(186, 70)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'OpenStairsExplorerToolStripMenuItem
        '
        Me.miExplorer.Name = "OpenStairsExplorerToolStripMenuItem"
        Me.miExplorer.Size = New System.Drawing.Size(185, 22)
        Me.miExplorer.Text = "Open Stairs Explorer"
        '
        'cmMenu
        '
        Me.cmMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miPrograms, Me.miDocuments, Me.miControlPanel, Me.miRun, Me.ToolStripSeparator3, Me.miLogoff, Me.miShutdown})
        Me.cmMenu.Name = "cmTaskbar"
        Me.cmMenu.Size = New System.Drawing.Size(147, 142)
        '
        'miPrograms
        '
        Me.miPrograms.Name = "miPrograms"
        Me.miPrograms.Size = New System.Drawing.Size(146, 22)
        Me.miPrograms.Text = "Programs"
        '
        'miDocuments
        '
        Me.miDocuments.Name = "miDocuments"
        Me.miDocuments.Size = New System.Drawing.Size(146, 22)
        Me.miDocuments.Text = "Documents"
        '
        'miControlPanel
        '
        Me.miControlPanel.Name = "miControlPanel"
        Me.miControlPanel.Size = New System.Drawing.Size(146, 22)
        Me.miControlPanel.Text = "Control Panel"
        '
        'miRun
        '
        Me.miRun.Name = "miRun"
        Me.miRun.Size = New System.Drawing.Size(146, 22)
        Me.miRun.Text = "Run"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(143, 6)
        '
        'miLogoff
        '
        Me.miLogoff.Name = "miLogoff"
        Me.miLogoff.Size = New System.Drawing.Size(146, 22)
        Me.miLogoff.Text = "Log off"
        '
        'miShutdown
        '
        Me.miShutdown.Name = "miShutdown"
        Me.miShutdown.Size = New System.Drawing.Size(146, 22)
        Me.miShutdown.Text = "Shut down"
        '
        'pStairs
        '
        Me.pStairs.BackColor = System.Drawing.SystemColors.Control
        Me.pStairs.ContextMenuStrip = Me.cmMenu
        Me.pStairs.Location = New System.Drawing.Point(29, 27)
        Me.pStairs.Name = "pStairs"
        Me.pStairs.Size = New System.Drawing.Size(202, 83)
        Me.pStairs.TabIndex = 1
        Me.pStairs.Visible = False
        '
        'cmDesktop
        '
        Me.cmDesktop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.miScreenResolution, Me.miPersonalize})
        Me.cmDesktop.Name = "cmOS"
        Me.cmDesktop.Size = New System.Drawing.Size(173, 70)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LargeIconsToolStripMenuItem, Me.MediumToolStripMenuItem, Me.SmallIconsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'LargeIconsToolStripMenuItem
        '
        Me.LargeIconsToolStripMenuItem.Name = "LargeIconsToolStripMenuItem"
        Me.LargeIconsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.LargeIconsToolStripMenuItem.Text = "Large Icons"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.MediumToolStripMenuItem.Text = "Medium Icons"
        '
        'SmallIconsToolStripMenuItem
        '
        Me.SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem"
        Me.SmallIconsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SmallIconsToolStripMenuItem.Text = "Small Icons"
        '
        'miScreenResolution
        '
        Me.miScreenResolution.Name = "miScreenResolution"
        Me.miScreenResolution.Size = New System.Drawing.Size(172, 22)
        Me.miScreenResolution.Text = "Screen Resolution"
        '
        'miPersonalize
        '
        Me.miPersonalize.Name = "miPersonalize"
        Me.miPersonalize.Size = New System.Drawing.Size(172, 22)
        Me.miPersonalize.Text = "Personalize"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(589, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(800, 193)
        Me.ContextMenuStrip = Me.cmDesktop
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pStairs)
        Me.Controls.Add(Me.pTaskbar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "frmMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmMDI"
        Me.cmTaskbar.ResumeLayout(False)
        Me.pTaskbar.ResumeLayout(False)
        Me.pNotification.ResumeLayout(False)
        Me.cmStairs.ResumeLayout(False)
        Me.cmMenu.ResumeLayout(False)
        Me.cmDesktop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmTaskbar As ContextMenuStrip
    Friend WithEvents miWindowsCascade As ToolStripMenuItem
    Friend WithEvents miWindowsStacked As ToolStripMenuItem
    Friend WithEvents miWindowsSide As ToolStripMenuItem
    Friend WithEvents miShowDesktop As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pTaskbar As Panel
    Friend WithEvents cmMenu As ContextMenuStrip
    Friend WithEvents miPrograms As ToolStripMenuItem
    Friend WithEvents miDocuments As ToolStripMenuItem
    Friend WithEvents miControlPanel As ToolStripMenuItem
    Friend WithEvents miRun As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents miLogoff As ToolStripMenuItem
    Friend WithEvents miShutdown As ToolStripMenuItem
    Friend WithEvents pStairs As Panel
    Friend WithEvents rbStairs As RadioButton
    Friend WithEvents cmDesktop As ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LargeIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmallIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents miScreenResolution As ToolStripMenuItem
    Friend WithEvents miPersonalize As ToolStripMenuItem
    Friend WithEvents pNotification As Panel
    Friend WithEvents bShowDesktop As Button
    Friend WithEvents lDate As Label
    Friend WithEvents lTime As Label
    Friend WithEvents cmStairs As ContextMenuStrip
    Friend WithEvents PropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents miExplorer As ToolStripMenuItem
    Friend WithEvents pSysIcon As Panel
    Friend WithEvents Button1 As Button
End Class
