Public Class MainForm

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'For admin, can access all form except Profile form (Hide the profile tool strip).
        'For user, can access all form except Control form (Hide the control tool strip).
        If Helper.user.Name = "admin1" Then
            ProfileToolStripMenuItem.Visible = False
            ControlComputerToolStripMenuItem.Visible = True
        Else
            ProfileToolStripMenuItem.Visible = True
            ComputerToolStripMenuItem.Visible = False
        End If

    End Sub

    Private Sub MyProfileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MyProfileToolStripMenuItem.Click
        ProfileForm.MdiParent = Me
        ProfileForm.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        'Log out and go back to Login Form
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub NewBookingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewBookingToolStripMenuItem.Click
        BookingForm.MdiParent = Me
        BookingForm.Show()
    End Sub

    Private Sub BookingHistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BookingHistoryToolStripMenuItem.Click
        HistoryForm.MdiParent = Me
        HistoryForm.Show()
       
    End Sub

    Private Sub ControlComputerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ControlComputerToolStripMenuItem.Click
        ControlForm.MdiParent = Me
        ControlForm.Show()
    End Sub

    Private Sub MainForm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.Show()
    End Sub
End Class