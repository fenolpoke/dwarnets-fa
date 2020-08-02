Public Class LoginForm

    Private Sub LoginButton_Click(sender As System.Object, e As System.EventArgs) Handles LoginButton.Click

        If UsernameTextBox.TextLength = 0 Or PasswordTextBox.TextLength = 0 Then
            MsgBox("Username and password cannot be null", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckTextLength(UsernameTextBox.Text, 6, 16) = False Or Helper.CheckTextLength(PasswordTextBox.Text, 6, 16) = False Then
            MsgBox("Username and password length must be between 6 and 16", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckAlphaNumeric(UsernameTextBox.Text) = False Then
            MsgBox("Username must be alphanumeric", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckAlphaNumericCapital(PasswordTextBox.Text) = False Then
            MsgBox("Password must be alphanumeric and combine capital and non-capital letter", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckLogin(UsernameTextBox.Text, PasswordTextBox.Text) = False Then
            MsgBox("Id and password not valid", MsgBoxStyle.OkOnly, "Warning")
        Else
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            MainForm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SignupButton_Click(sender As System.Object, e As System.EventArgs) Handles SignupButton.Click
        RegisterForm.Show()
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub UsernameTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress, PasswordTextBox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            LoginButton_Click(sender, e)
        End If

    End Sub
End Class