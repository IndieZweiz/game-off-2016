Friend Class frmBSOD
    Private Sub frmBSOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(0, 0, 172)
    End Sub

    Private Sub testCloseBSOD_Click(sender As Object, e As EventArgs) Handles testCloseBSOD.Click
        Me.Close()
    End Sub

    'A problem has been detected and Stairs has been shut down to prevent damage
    'to your computer.

    'Modification of system code or a critical data structure was detected.

    'If this is the first time you've seen this Stop error screen,
    'restart your computer. If this screen appears again, follow
    'these steps:

    'Check to make sure any new hardware or software is properly installed.
    'If this is a new installation, ask your hardware or software manufacturer
    'for any Stairs updates you might need.

    'If problems continue, disable or remove any newly installed hardware
    'or software. Disable BIOS memory options such as caching or shadowing.
    'If you need to use Safe Mode to remove or disable components, restart
    'your computer, press F8 to select Advanced Startup Options, and then
    'select Safe Mode

    'Technical Information:

    '*** STOP: 0x00000109 (0x00000001, 0x00000001, 0x00000000, 0x00000000)

    'Collecting data for crash dump ...
    'Initializing disk for crash dump ...
    'Beginning dump for physical memory.
    'Dumping physical memory to disk: %%%%%%%%%%
    'Physical memory dump completed.
    'Contact your system admin or technical support group for further assistance.
End Class