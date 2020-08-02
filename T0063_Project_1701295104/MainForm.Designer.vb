<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlComputerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ComputerToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(623, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyProfileToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'MyProfileToolStripMenuItem
        '
        Me.MyProfileToolStripMenuItem.Name = "MyProfileToolStripMenuItem"
        Me.MyProfileToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.MyProfileToolStripMenuItem.Text = "My Profile"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBookingToolStripMenuItem, Me.BookingHistoryToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'NewBookingToolStripMenuItem
        '
        Me.NewBookingToolStripMenuItem.Name = "NewBookingToolStripMenuItem"
        Me.NewBookingToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.NewBookingToolStripMenuItem.Text = "New Booking"
        '
        'BookingHistoryToolStripMenuItem
        '
        Me.BookingHistoryToolStripMenuItem.Name = "BookingHistoryToolStripMenuItem"
        Me.BookingHistoryToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BookingHistoryToolStripMenuItem.Text = "Booking History"
        '
        'ComputerToolStripMenuItem
        '
        Me.ComputerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlComputerToolStripMenuItem})
        Me.ComputerToolStripMenuItem.Name = "ComputerToolStripMenuItem"
        Me.ComputerToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ComputerToolStripMenuItem.Text = "Computer"
        '
        'ControlComputerToolStripMenuItem
        '
        Me.ControlComputerToolStripMenuItem.Name = "ControlComputerToolStripMenuItem"
        Me.ControlComputerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ControlComputerToolStripMenuItem.Text = "Control Computer"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(623, 335)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlComputerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
