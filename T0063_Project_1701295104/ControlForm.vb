Public Class ControlForm

    Dim controlBoxes() As ControlBox = {ControlBox1A, ControlBox1B, ControlBox1C, ControlBox1D, ControlBox1E,
                                          ControlBox2A, ControlBox2B, ControlBox2C, ControlBox2D, ControlBox2E}

    Private Sub ControlForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '-	Serving means computers are working properly and registered users can book that computers.
        '-	Offline means computer is on defect status that cause user can't book that computer.
        '-	Everytime this form called or opened, each computer status and reason will be set to current status.

        controlBoxes = {ControlBox1A, ControlBox1B, ControlBox1C, ControlBox1D, ControlBox1E,
                                          ControlBox2A, ControlBox2B, ControlBox2C, ControlBox2D, ControlBox2E}

        For index = 0 To controlBoxes.Count - 1
            Dim computer = Helper.GetComputer(controlBoxes(index).GroupBoxName)
            If computer.Status = "Serving" Then
                controlBoxes(index).ServingRadioButton.Checked = True
                controlBoxes(index).OfflineRadioButton.Checked = False
            Else
                controlBoxes(index).ServingRadioButton.Checked = False
                controlBoxes(index).OfflineRadioButton.Checked = True
                controlBoxes(index).RichTextBox.Text = computer.Reason
            End If

        Next

    End Sub

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        '-	If button save clicked, Validate that offline computer must have reason: 
        '-	If all offline computers have reason, program will show messages "Computer Update Success".
        '-	If there is an offline computer without reason, 
        'the program will update all computer status except the one that offline computer without reason. 
        'And the system will inform the user "There is an offline computer without reason".
        Dim isOfflineWithoutReason As Boolean = False

        For Each cb In controlBoxes
            If cb.OfflineRadioButton.Checked And cb.RichTextBox.Text Is String.Empty Then
                isOfflineWithoutReason = True
            Else
                Dim status As String
                If cb.ServingRadioButton.Checked Then
                    status = "Serving"
                Else
                    status = "Offline"
                End If

                Helper.UpdateComputer(cb.GroupBoxName, status, cb.RichTextBox.Text)
            End If
        Next

        If isOfflineWithoutReason Then
            MsgBox("There is an offline computer without reason", MsgBoxStyle.OkOnly, "Warning")
        Else
            MsgBox("Computer Update Success", MsgBoxStyle.OkOnly, "Warning")
        End If


    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class