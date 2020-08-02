Public Class HistoryForm

    Private Sub HistoryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '-	TransactionID contain all ID of transactions that user did in the past
        '-	The "Seat Number" combo box only contain the row and column of computers thats user booked on the selected TransactionID.
        '-	The "Change to" combo box only contain the row and column of computers thats no one booked on the booking date of the selected TransactionID.

        TransactionDataGridView.DataSource = Helper.GetTransactionHistoryByUser()

        For index = 0 To TransactionDataGridView.Rows.Count - 1
            TransactionIDComboBox.Items.Add(TransactionDataGridView.Rows(index).Cells(0).Value)
        Next


    End Sub


    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        '-	If Save button clicked, update the payment of chosen TransactionID. 
        If Helper.SaveTransaction(TransactionIDComboBox.SelectedItem, PaymentComboBox.SelectedItem) Then
            MsgBox("Save Transaction Success!", MsgBoxStyle.OkOnly, "Warning")
        Else
            MsgBox("Save Transaction Failed!", MsgBoxStyle.OkOnly, "Warning")
        End If

        TransactionDataGridView.DataSource = Helper.GetTransactionHistoryByUser()
    End Sub

    Private Sub DeleteTransactionButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteTransactionButton.Click
        '-	If Delete button clicked, delete the payment of chosen TransactionID.
        If Helper.DeleteTransaction(TransactionIDComboBox.SelectedItem) Then
            MsgBox("Delete Transaction Success!", MsgBoxStyle.OkOnly, "Warning")
        Else
            MsgBox("Delete Transaction Failed!", MsgBoxStyle.OkOnly, "Warning")
        End If

        TransactionDataGridView.DataSource = Helper.GetTransactionHistoryByUser()
    End Sub

    Private Sub UpdateButton_Click(sender As System.Object, e As System.EventArgs) Handles UpdateButton.Click
        '-	If Update Seat button clicked, update the seat in the database based on "Seat Number" and "Change To" the combobox. 
        If Helper.UpdateSeat(TransactionIDComboBox.SelectedItem, SeatNumberComboBox.Text, ChangeToComboBox.Text) Then
            MsgBox("Update Seat Success!", MsgBoxStyle.OkOnly, "Warning")
        Else
            MsgBox("Update Seat Failed!", MsgBoxStyle.OkOnly, "Warning")
        End If

        Dim computers = Helper.GetComputerByTransaction(TransactionIDComboBox.SelectedItem)

        SeatDetailDataGridView.DataSource = computers
        For index = 0 To SeatDetailDataGridView.Columns.Count - 1
            If SeatDetailDataGridView.Columns(index).Name <> "RowCol" And SeatDetailDataGridView.Columns(index).Name <> "Status" Then
                SeatDetailDataGridView.Columns(index).Visible = False
            End If
        Next

        SeatNumberComboBox.Items.Clear()
        ChangeToComboBox.Items.Clear()

        For index = 0 To SeatDetailDataGridView.Rows.Count - 1
            SeatNumberComboBox.Items.Add(SeatDetailDataGridView.Rows(index).Cells(1).Value)
        Next


        ChangeToComboBox.Items.AddRange(Helper.GetAvailableSeat(BookingDateDateTimePicker.Value))
        ChangeToComboBox.DisplayMember = "RowCol"

    End Sub

    Private Sub DeleteSeatButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteSeatButton.Click
        '-	If Delete Seat button clicked, delete the selected seat  number of the TransactionID in the database.
        If Helper.DeleteSeat(TransactionIDComboBox.SelectedItem, SeatNumberComboBox.Text) Then
            MsgBox("Delete Seat Success!", MsgBoxStyle.OkOnly, "Warning")
        Else
            MsgBox("Delete Seat Failed!", MsgBoxStyle.OkOnly, "Warning")
        End If

        Dim computers = Helper.GetComputerByTransaction(TransactionIDComboBox.SelectedItem)

        SeatDetailDataGridView.DataSource = computers
        For index = 0 To SeatDetailDataGridView.Columns.Count - 1
            If SeatDetailDataGridView.Columns(index).Name <> "RowCol" And SeatDetailDataGridView.Columns(index).Name <> "Status" Then
                SeatDetailDataGridView.Columns(index).Visible = False
            End If
        Next

        SeatNumberComboBox.Items.Clear()
        ChangeToComboBox.Items.Clear()

        For index = 0 To SeatDetailDataGridView.Rows.Count - 1
            SeatNumberComboBox.Items.Add(SeatDetailDataGridView.Rows(index).Cells(1).Value)
        Next


        ChangeToComboBox.Items.AddRange(Helper.GetAvailableSeat(BookingDateDateTimePicker.Value))
        ChangeToComboBox.DisplayMember = "RowCol"

    End Sub

    Private Sub TransactionDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TransactionDataGridView.CellClick
        '-	If DataGridView of Transaction is clicked, then show all information to the existing fields based on clicked TransactionID, and update DataGridView of seat detail.

        If e.RowIndex < 0 Then
            Return
        End If


        TransactionIDComboBox.SelectedItem = TransactionDataGridView.Rows(e.RowIndex).Cells(0).Value
        TransactionDateDateTimePicker.Value = TransactionDataGridView.Rows(e.RowIndex).Cells(1).Value
        BookingDateDateTimePicker.Value = TransactionDataGridView.Rows(e.RowIndex).Cells(2).Value
        PaymentComboBox.SelectedItem = Helper.GetPaymentMethod(TransactionDataGridView.Rows(e.RowIndex).Cells(3).Value)

        Dim computers = Helper.GetComputerByTransaction(TransactionIDComboBox.SelectedItem)

        SeatDetailDataGridView.DataSource = computers
        For index = 0 To SeatDetailDataGridView.Columns.Count - 1
            If SeatDetailDataGridView.Columns(index).Name <> "RowCol" And SeatDetailDataGridView.Columns(index).Name <> "Status" Then
                SeatDetailDataGridView.Columns(index).Visible = False
            End If
        Next

        SeatNumberComboBox.Items.Clear()
        ChangeToComboBox.Items.Clear()

        For index = 0 To SeatDetailDataGridView.Rows.Count - 1
            SeatNumberComboBox.Items.Add(SeatDetailDataGridView.Rows(index).Cells(1).Value)
        Next


        ChangeToComboBox.Items.AddRange(Helper.GetAvailableSeat(BookingDateDateTimePicker.Value))
        ChangeToComboBox.DisplayMember = "RowCol"

    End Sub


End Class