Public Class ProfileForm

    Private Sub ProfileForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '-	Show all data about the user into correct textbox except the password.
        UseridTextBox.Text = Helper.user.Userid
        NameTextBox.Text = Helper.user.Name
        BankComboBox.SelectedItem = Helper.user.BankName
        CCNTextBox.Text = Helper.user.CreditCardNumber
        BANTextBox.Text = Helper.user.BankAccNumber

    End Sub


    Private Sub UpdateButton_Click(sender As System.Object, e As System.EventArgs) Handles UpdateButton.Click
        If Helper.CheckTextLength(NameTextBox.Text, 6, 16) = False Then
            MsgBox("Username length must be between 6 and 16", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckTextLength(PasswordTextBox.Text, 6, 16) = False Then
            MsgBox("Password  length must be between 6 and 16", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckAlphaNumeric(NameTextBox.Text) = False Then
            MsgBox("Username must be alphanumeric", MsgBoxStyle.OkOnly, "Warning")
        ElseIf Helper.CheckAlphaNumericCapital(PasswordTextBox.Text) = False Then
            MsgBox("Password must be alphanumeric and combine capital and non-capital letter", MsgBoxStyle.OkOnly, "Warning")
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
        ElseIf Helper.IsUpdateable(BANTextBox.Text, CCNTextBox.Text) = False Then
            MsgBox("Users can only update Bank Account Number or Credit Card Number once in 30 days", MsgBoxStyle.OkOnly, "Warning")
        Else

            If Helper.UpdateMember(NameTextBox.Text, PasswordTextBox.Text, CCNTextBox.Text, BankComboBox.Text, BANTextBox.Text) Then
                MsgBox("Update Success!", MsgBoxStyle.OkOnly, "Warning")
            Else
                MsgBox("Update Failed!", MsgBoxStyle.OkOnly, "Warning")
            End If
        End If

    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class