<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileForm))
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.BankComboBox = New System.Windows.Forms.ComboBox()
        Me.BANTextBox = New System.Windows.Forms.TextBox()
        Me.CCNTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.UseridTextBox = New System.Windows.Forms.TextBox()
        Me.BANLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.CCNLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.BankLabel = New System.Windows.Forms.Label()
        Me.UseridLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox
        '
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(179, 159)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 2
        Me.PictureBox.TabStop = False
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(331, 98)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(151, 30)
        Me.DescriptionLabel.TabIndex = 5
        Me.DescriptionLabel.Text = "Member Detail"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Magneto", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(245, 21)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(327, 58)
        Me.TitleLabel.TabIndex = 4
        Me.TitleLabel.Text = "D'WarneTS"
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.BankComboBox)
        Me.GroupBox.Controls.Add(Me.BANTextBox)
        Me.GroupBox.Controls.Add(Me.CCNTextBox)
        Me.GroupBox.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox.Controls.Add(Me.NameTextBox)
        Me.GroupBox.Controls.Add(Me.UseridTextBox)
        Me.GroupBox.Controls.Add(Me.BANLabel)
        Me.GroupBox.Controls.Add(Me.PasswordLabel)
        Me.GroupBox.Controls.Add(Me.CCNLabel)
        Me.GroupBox.Controls.Add(Me.NameLabel)
        Me.GroupBox.Controls.Add(Me.BankLabel)
        Me.GroupBox.Controls.Add(Me.UseridLabel)
        Me.GroupBox.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(614, 125)
        Me.GroupBox.TabIndex = 6
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Detail"
        '
        'BankComboBox
        '
        Me.BankComboBox.AutoCompleteCustomSource.AddRange(New String() {"BCA", "Mandiri", "Permata"})
        Me.BankComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BankComboBox.FormattingEnabled = True
        Me.BankComboBox.Items.AddRange(New Object() {"BCA", "Mandiri", "Permata"})
        Me.BankComboBox.Location = New System.Drawing.Point(412, 26)
        Me.BankComboBox.Name = "BankComboBox"
        Me.BankComboBox.Size = New System.Drawing.Size(175, 21)
        Me.BankComboBox.TabIndex = 2
        '
        'BANTextBox
        '
        Me.BANTextBox.Location = New System.Drawing.Point(412, 75)
        Me.BANTextBox.Name = "BANTextBox"
        Me.BANTextBox.Size = New System.Drawing.Size(175, 20)
        Me.BANTextBox.TabIndex = 1
        '
        'CCNTextBox
        '
        Me.CCNTextBox.Location = New System.Drawing.Point(412, 50)
        Me.CCNTextBox.Name = "CCNTextBox"
        Me.CCNTextBox.Size = New System.Drawing.Size(175, 20)
        Me.CCNTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(115, 75)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(170, 20)
        Me.PasswordTextBox.TabIndex = 1
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(115, 50)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(170, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'UseridTextBox
        '
        Me.UseridTextBox.Enabled = False
        Me.UseridTextBox.Location = New System.Drawing.Point(115, 26)
        Me.UseridTextBox.Name = "UseridTextBox"
        Me.UseridTextBox.Size = New System.Drawing.Size(170, 20)
        Me.UseridTextBox.TabIndex = 1
        '
        'BANLabel
        '
        Me.BANLabel.AutoSize = True
        Me.BANLabel.Location = New System.Drawing.Point(291, 78)
        Me.BANLabel.Name = "BANLabel"
        Me.BANLabel.Size = New System.Drawing.Size(115, 13)
        Me.BANLabel.TabIndex = 0
        Me.BANLabel.Text = "Bank Account Number"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(6, 78)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 0
        Me.PasswordLabel.Text = "Password"
        '
        'CCNLabel
        '
        Me.CCNLabel.AutoSize = True
        Me.CCNLabel.Location = New System.Drawing.Point(291, 53)
        Me.CCNLabel.Name = "CCNLabel"
        Me.CCNLabel.Size = New System.Drawing.Size(99, 13)
        Me.CCNLabel.TabIndex = 0
        Me.CCNLabel.Text = "Credit Card Number"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 53)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'BankLabel
        '
        Me.BankLabel.AutoSize = True
        Me.BankLabel.Location = New System.Drawing.Point(291, 29)
        Me.BankLabel.Name = "BankLabel"
        Me.BankLabel.Size = New System.Drawing.Size(63, 13)
        Me.BankLabel.TabIndex = 0
        Me.BankLabel.Text = "Bank Name"
        '
        'UseridLabel
        '
        Me.UseridLabel.AutoSize = True
        Me.UseridLabel.Location = New System.Drawing.Point(6, 29)
        Me.UseridLabel.Name = "UseridLabel"
        Me.UseridLabel.Size = New System.Drawing.Size(37, 13)
        Me.UseridLabel.TabIndex = 0
        Me.UseridLabel.Text = "Userid"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(551, 318)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(470, 318)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 7
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(638, 353)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProfileForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProfileForm"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BankComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UseridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BANLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents CCNLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents BankLabel As System.Windows.Forms.Label
    Friend WithEvents UseridLabel As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
End Class
