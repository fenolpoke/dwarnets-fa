<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.CCNLabel = New System.Windows.Forms.Label()
        Me.BankLabel = New System.Windows.Forms.Label()
        Me.BANLabel = New System.Windows.Forms.Label()
        Me.SignupButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CCNTextBox = New System.Windows.Forms.TextBox()
        Me.BankComboBox = New System.Windows.Forms.ComboBox()
        Me.BANTextBox = New System.Windows.Forms.TextBox()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(12, 72)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(12, 103)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 0
        Me.PasswordLabel.Text = "Password"
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.Location = New System.Drawing.Point(12, 135)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(42, 13)
        Me.GenderLabel.TabIndex = 0
        Me.GenderLabel.Text = "Gender"
        '
        'CCNLabel
        '
        Me.CCNLabel.AutoSize = True
        Me.CCNLabel.Location = New System.Drawing.Point(252, 72)
        Me.CCNLabel.Name = "CCNLabel"
        Me.CCNLabel.Size = New System.Drawing.Size(99, 13)
        Me.CCNLabel.TabIndex = 0
        Me.CCNLabel.Text = "Credit Card Number"
        '
        'BankLabel
        '
        Me.BankLabel.AutoSize = True
        Me.BankLabel.Location = New System.Drawing.Point(252, 103)
        Me.BankLabel.Name = "BankLabel"
        Me.BankLabel.Size = New System.Drawing.Size(63, 13)
        Me.BankLabel.TabIndex = 0
        Me.BankLabel.Text = "Bank Name"
        '
        'BANLabel
        '
        Me.BANLabel.AutoSize = True
        Me.BANLabel.Location = New System.Drawing.Point(252, 135)
        Me.BANLabel.Name = "BANLabel"
        Me.BANLabel.Size = New System.Drawing.Size(115, 13)
        Me.BANLabel.TabIndex = 0
        Me.BANLabel.Text = "Bank Account Number"
        '
        'SignupButton
        '
        Me.SignupButton.Location = New System.Drawing.Point(585, 67)
        Me.SignupButton.Name = "SignupButton"
        Me.SignupButton.Size = New System.Drawing.Size(75, 23)
        Me.SignupButton.TabIndex = 7
        Me.SignupButton.Text = "Signup !"
        Me.SignupButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(585, 96)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 23)
        Me.LoginButton.TabIndex = 8
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(585, 125)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(78, 69)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(168, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(78, 100)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(168, 20)
        Me.PasswordTextBox.TabIndex = 2
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'CCNTextBox
        '
        Me.CCNTextBox.Location = New System.Drawing.Point(378, 69)
        Me.CCNTextBox.Name = "CCNTextBox"
        Me.CCNTextBox.Size = New System.Drawing.Size(168, 20)
        Me.CCNTextBox.TabIndex = 4
        '
        'BankComboBox
        '
        Me.BankComboBox.AutoCompleteCustomSource.AddRange(New String() {"BCA", "Mandiri", "Permata"})
        Me.BankComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BankComboBox.FormattingEnabled = True
        Me.BankComboBox.Items.AddRange(New Object() {"BCA", "Mandiri", "Permata"})
        Me.BankComboBox.Location = New System.Drawing.Point(378, 98)
        Me.BankComboBox.Name = "BankComboBox"
        Me.BankComboBox.Size = New System.Drawing.Size(168, 21)
        Me.BankComboBox.TabIndex = 5
        '
        'BANTextBox
        '
        Me.BANTextBox.Location = New System.Drawing.Point(378, 132)
        Me.BANTextBox.Name = "BANTextBox"
        Me.BANTextBox.Size = New System.Drawing.Size(168, 20)
        Me.BANTextBox.TabIndex = 6
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(78, 133)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.MaleRadioButton.TabIndex = 3
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(187, 133)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.FemaleRadioButton.TabIndex = 3
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(695, 236)
        Me.Controls.Add(Me.FemaleRadioButton)
        Me.Controls.Add(Me.MaleRadioButton)
        Me.Controls.Add(Me.BankComboBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.BANTextBox)
        Me.Controls.Add(Me.CCNTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.SignupButton)
        Me.Controls.Add(Me.BANLabel)
        Me.Controls.Add(Me.BankLabel)
        Me.Controls.Add(Me.GenderLabel)
        Me.Controls.Add(Me.CCNLabel)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents GenderLabel As System.Windows.Forms.Label
    Friend WithEvents CCNLabel As System.Windows.Forms.Label
    Friend WithEvents BankLabel As System.Windows.Forms.Label
    Friend WithEvents BANLabel As System.Windows.Forms.Label
    Friend WithEvents SignupButton As System.Windows.Forms.Button
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BankComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FemaleRadioButton As System.Windows.Forms.RadioButton
End Class
