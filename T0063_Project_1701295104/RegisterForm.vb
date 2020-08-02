Public Class RegisterForm

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LoginButton_Click(sender As System.Object, e As System.EventArgs) Handles LoginButton.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub SignupButton_Click(sender As System.Object, e As System.EventArgs) Handles SignupButton.Click
        If Helper.CheckTextLength(NameTextBox.Text, 6, 16) = False Then
            MsgBox("Username length must be between 6 and 16", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckTextLength(PasswordTextBox.Text, 6, 16) = False Then
            MsgBox("Password  length must be between 6 and 16", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckAlphaNumeric(NameTextBox.Text) = False Then
            MsgBox("Username must be alphanumeric", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckAlphaNumericCapital(PasswordTextBox.Text) = False Then
            MsgBox("Password must be alphanumeric and combine capital and non-capital letter", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckSelected(MaleRadioButton, FemaleRadioButton) = False Then
            MsgBox("Select Gender", MsgBoxStyle.OkOnly, "Warning")
        ElseIf CCNTextBox.TextLength <> 16 Then
            MsgBox("Credit Card Number must be 16 digits", MsgBoxStyle.OkOnly, "Warning")
        ElseIf IsNumeric(CCNTextBox.Text) = False Then
            MsgBox("Credit Card Number must be numeric", MsgBoxStyle.OkOnly, "Warning")
        ElseIf BankComboBox.SelectedIndex < 0 Then
            MsgBox("Select Bank Name", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckTextLength(BANTextBox.Text, 6, 16) = False Then
            MsgBox("Bank Account Number must be between 10 and 16 digits", MsgBoxStyle.OkOnly, "Warning")
        ElseIf IsNumeric(BANTextBox.Text) = False Then
            MsgBox("Bank Account Number must be numeric", MsgBoxStyle.OkOnly, "Warning")
        Else
            Dim Gender, Bank As String

            If MaleRadioButton.Checked Then
                Gender = "Male"
            Else
                Gender = "Female"
            End If

            Bank = CCNTextBox.Text

            If Helper.Register(NameTextBox.Text, PasswordTextBox.Text, Gender, CCNTextBox.Text, Bank, BANTextBox.Text) Then
                MsgBox("Register Success!", MsgBoxStyle.OkOnly, "Warning")
            Else
                MsgBox("Problem registering!", MsgBoxStyle.OkOnly, "Warning")
            End If
        End If

    End Sub
End Class