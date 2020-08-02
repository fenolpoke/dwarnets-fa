Public Class BookingForm


    Dim bookingBoxes() As BookingBox = {BookingBox1A, BookingBox1B, BookingBox1C, BookingBox1D, BookingBox1E,
                                          BookingBox2A, BookingBox2B, BookingBox2C, BookingBox2D, BookingBox2E}

    Private Sub BookingForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '-	Adjust the mininum date of datetimepicker to the system time.
        DateTimePicker.MinDate = Today
        bookingBoxes = {BookingBox1A, BookingBox1B, BookingBox1C, BookingBox1D, BookingBox1E,
                                          BookingBox2A, BookingBox2B, BookingBox2C, BookingBox2D, BookingBox2E}

        For Each bb In bookingBoxes
            Dim c = Helper.GetComputer(bb.CheckBoxName)
            If c.Status = "Offline" Then
                bb.CheckBox.Enabled = False
                bb.Label.Text = c.Reason
            End If

        Next

    End Sub

    Private Sub DateTimePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker.ValueChanged
        '-	The status of every computer will be refreshed every datetimepicker value changed.
        '-	If there is any computer booked on the date on datetimepicker, the checkbox on these computers will be read only and checked.
        '-	If there is any computer on offline status, the checkbox on these computers will be read only and the reason is listed below the checkbox.
        For Each bb In bookingBoxes

            If bb.Label.Text Is String.Empty Then
                bb.CheckBox.Enabled = True
                bb.CheckBox.Checked = False
            End If
        Next

        For Each transaction In Helper.GetTransactionByDate(DateTimePicker.Value)
            For Each computer In transaction.MsComputers
                Dim box = bookingBoxes.Where(Function(x) x.CheckBoxName = computer.RowCol).First
                box.CheckBox.Checked = True
                box.CheckBox.Enabled = False
            Next
        Next

    End Sub

    Private Sub BookButton_Click(sender As System.Object, e As System.EventArgs) Handles BookButton.Click
        '-	If Booking button is clicked, the program will save the transaction to database.
        If PaymentComboBox.SelectedIndex < 0 Then
            MsgBox("Select Payment!", MsgBoxStyle.OkOnly, "Warning")
        ElseIf bookingBoxes.Where(Function(x) x.CheckBox.Enabled And x.CheckBox.Checked).Count < 1 Then
            MsgBox("Select Computer!", MsgBoxStyle.OkOnly, "Warning")
        Else
            If Helper.Book(bookingBoxes.Where(Function(x) x.CheckBox.Enabled And x.CheckBox.Checked), PaymentComboBox.Text, DateTimePicker.Value) Then
                MsgBox("Book Success!", MsgBoxStyle.OkOnly, "Warning")
            Else
                MsgBox("Book Failed!", MsgBoxStyle.OkOnly, "Warning")
            End If

        End If

    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class