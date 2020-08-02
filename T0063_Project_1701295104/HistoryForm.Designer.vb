<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Me.TransactionDataGridView = New System.Windows.Forms.DataGridView()
        Me.SeatDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.EditTransactionGroupBox = New System.Windows.Forms.GroupBox()
        Me.DeleteTransactionButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TransactionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BookingDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PaymentComboBox = New System.Windows.Forms.ComboBox()
        Me.TransactionDateLabel = New System.Windows.Forms.Label()
        Me.PaymentLabel = New System.Windows.Forms.Label()
        Me.BookingDateLabel = New System.Windows.Forms.Label()
        Me.TransactionIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TransactionIDLabel = New System.Windows.Forms.Label()
        Me.EditComputerGroupBox = New System.Windows.Forms.GroupBox()
        Me.DeleteSeatButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ChangeToComboBox = New System.Windows.Forms.ComboBox()
        Me.ChangeToLabel = New System.Windows.Forms.Label()
        Me.SeatNumberComboBox = New System.Windows.Forms.ComboBox()
        Me.SeatNumberLabel = New System.Windows.Forms.Label()
        CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeatDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditTransactionGroupBox.SuspendLayout()
        Me.EditComputerGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransactionDataGridView
        '
        Me.TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransactionDataGridView.Location = New System.Drawing.Point(12, 3)
        Me.TransactionDataGridView.Name = "TransactionDataGridView"
        Me.TransactionDataGridView.Size = New System.Drawing.Size(448, 211)
        Me.TransactionDataGridView.TabIndex = 0
        '
        'SeatDetailDataGridView
        '
        Me.SeatDetailDataGridView.AllowUserToAddRows = False
        Me.SeatDetailDataGridView.AllowUserToDeleteRows = False
        Me.SeatDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SeatDetailDataGridView.Location = New System.Drawing.Point(466, 3)
        Me.SeatDetailDataGridView.MultiSelect = False
        Me.SeatDetailDataGridView.Name = "SeatDetailDataGridView"
        Me.SeatDetailDataGridView.ReadOnly = True
        Me.SeatDetailDataGridView.Size = New System.Drawing.Size(273, 211)
        Me.SeatDetailDataGridView.TabIndex = 0
        '
        'EditTransactionGroupBox
        '
        Me.EditTransactionGroupBox.Controls.Add(Me.DeleteTransactionButton)
        Me.EditTransactionGroupBox.Controls.Add(Me.SaveButton)
        Me.EditTransactionGroupBox.Controls.Add(Me.TransactionDateDateTimePicker)
        Me.EditTransactionGroupBox.Controls.Add(Me.BookingDateDateTimePicker)
        Me.EditTransactionGroupBox.Controls.Add(Me.PaymentComboBox)
        Me.EditTransactionGroupBox.Controls.Add(Me.TransactionDateLabel)
        Me.EditTransactionGroupBox.Controls.Add(Me.PaymentLabel)
        Me.EditTransactionGroupBox.Controls.Add(Me.BookingDateLabel)
        Me.EditTransactionGroupBox.Controls.Add(Me.TransactionIDComboBox)
        Me.EditTransactionGroupBox.Controls.Add(Me.TransactionIDLabel)
        Me.EditTransactionGroupBox.Location = New System.Drawing.Point(12, 220)
        Me.EditTransactionGroupBox.Name = "EditTransactionGroupBox"
        Me.EditTransactionGroupBox.Size = New System.Drawing.Size(448, 159)
        Me.EditTransactionGroupBox.TabIndex = 1
        Me.EditTransactionGroupBox.TabStop = False
        Me.EditTransactionGroupBox.Text = "Edit Transaction"
        '
        'DeleteTransactionButton
        '
        Me.DeleteTransactionButton.Location = New System.Drawing.Point(302, 130)
        Me.DeleteTransactionButton.Name = "DeleteTransactionButton"
        Me.DeleteTransactionButton.Size = New System.Drawing.Size(140, 23)
        Me.DeleteTransactionButton.TabIndex = 3
        Me.DeleteTransactionButton.Text = "Delete This Transaction"
        Me.DeleteTransactionButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(221, 130)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TransactionDateDateTimePicker
        '
        Me.TransactionDateDateTimePicker.Enabled = False
        Me.TransactionDateDateTimePicker.Location = New System.Drawing.Point(288, 77)
        Me.TransactionDateDateTimePicker.Name = "TransactionDateDateTimePicker"
        Me.TransactionDateDateTimePicker.Size = New System.Drawing.Size(154, 20)
        Me.TransactionDateDateTimePicker.TabIndex = 2
        '
        'BookingDateDateTimePicker
        '
        Me.BookingDateDateTimePicker.Enabled = False
        Me.BookingDateDateTimePicker.Location = New System.Drawing.Point(288, 24)
        Me.BookingDateDateTimePicker.Name = "BookingDateDateTimePicker"
        Me.BookingDateDateTimePicker.Size = New System.Drawing.Size(154, 20)
        Me.BookingDateDateTimePicker.TabIndex = 2
        '
        'PaymentComboBox
        '
        Me.PaymentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentComboBox.FormattingEnabled = True
        Me.PaymentComboBox.Items.AddRange(New Object() {"Credit Card", "Transfer - BCA", "Transfer - Mandiri", "Transfer - Permata"})
        Me.PaymentComboBox.Location = New System.Drawing.Point(86, 77)
        Me.PaymentComboBox.Name = "PaymentComboBox"
        Me.PaymentComboBox.Size = New System.Drawing.Size(108, 21)
        Me.PaymentComboBox.TabIndex = 1
        '
        'TransactionDateLabel
        '
        Me.TransactionDateLabel.AutoSize = True
        Me.TransactionDateLabel.Location = New System.Drawing.Point(200, 83)
        Me.TransactionDateLabel.Name = "TransactionDateLabel"
        Me.TransactionDateLabel.Size = New System.Drawing.Size(89, 13)
        Me.TransactionDateLabel.TabIndex = 0
        Me.TransactionDateLabel.Text = "Transaction Date"
        '
        'PaymentLabel
        '
        Me.PaymentLabel.AutoSize = True
        Me.PaymentLabel.Location = New System.Drawing.Point(6, 80)
        Me.PaymentLabel.Name = "PaymentLabel"
        Me.PaymentLabel.Size = New System.Drawing.Size(48, 13)
        Me.PaymentLabel.TabIndex = 0
        Me.PaymentLabel.Text = "Payment"
        '
        'BookingDateLabel
        '
        Me.BookingDateLabel.AutoSize = True
        Me.BookingDateLabel.Location = New System.Drawing.Point(200, 31)
        Me.BookingDateLabel.Name = "BookingDateLabel"
        Me.BookingDateLabel.Size = New System.Drawing.Size(72, 13)
        Me.BookingDateLabel.TabIndex = 0
        Me.BookingDateLabel.Text = "Booking Date"
        '
        'TransactionIDComboBox
        '
        Me.TransactionIDComboBox.FormattingEnabled = True
        Me.TransactionIDComboBox.Location = New System.Drawing.Point(86, 22)
        Me.TransactionIDComboBox.Name = "TransactionIDComboBox"
        Me.TransactionIDComboBox.Size = New System.Drawing.Size(108, 21)
        Me.TransactionIDComboBox.TabIndex = 1
        '
        'TransactionIDLabel
        '
        Me.TransactionIDLabel.AutoSize = True
        Me.TransactionIDLabel.Location = New System.Drawing.Point(6, 26)
        Me.TransactionIDLabel.Name = "TransactionIDLabel"
        Me.TransactionIDLabel.Size = New System.Drawing.Size(74, 13)
        Me.TransactionIDLabel.TabIndex = 0
        Me.TransactionIDLabel.Text = "TransactionID"
        '
        'EditComputerGroupBox
        '
        Me.EditComputerGroupBox.Controls.Add(Me.DeleteSeatButton)
        Me.EditComputerGroupBox.Controls.Add(Me.UpdateButton)
        Me.EditComputerGroupBox.Controls.Add(Me.ChangeToComboBox)
        Me.EditComputerGroupBox.Controls.Add(Me.ChangeToLabel)
        Me.EditComputerGroupBox.Controls.Add(Me.SeatNumberComboBox)
        Me.EditComputerGroupBox.Controls.Add(Me.SeatNumberLabel)
        Me.EditComputerGroupBox.Location = New System.Drawing.Point(466, 220)
        Me.EditComputerGroupBox.Name = "EditComputerGroupBox"
        Me.EditComputerGroupBox.Size = New System.Drawing.Size(273, 159)
        Me.EditComputerGroupBox.TabIndex = 1
        Me.EditComputerGroupBox.TabStop = False
        Me.EditComputerGroupBox.Text = "Edit Computer"
        '
        'DeleteSeatButton
        '
        Me.DeleteSeatButton.Location = New System.Drawing.Point(192, 130)
        Me.DeleteSeatButton.Name = "DeleteSeatButton"
        Me.DeleteSeatButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteSeatButton.TabIndex = 3
        Me.DeleteSeatButton.Text = "Delete Seat"
        Me.DeleteSeatButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(111, 130)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "UpdateSeat"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ChangeToComboBox
        '
        Me.ChangeToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ChangeToComboBox.FormattingEnabled = True
        Me.ChangeToComboBox.Location = New System.Drawing.Point(96, 75)
        Me.ChangeToComboBox.Name = "ChangeToComboBox"
        Me.ChangeToComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ChangeToComboBox.TabIndex = 1
        '
        'ChangeToLabel
        '
        Me.ChangeToLabel.AutoSize = True
        Me.ChangeToLabel.Location = New System.Drawing.Point(13, 80)
        Me.ChangeToLabel.Name = "ChangeToLabel"
        Me.ChangeToLabel.Size = New System.Drawing.Size(60, 13)
        Me.ChangeToLabel.TabIndex = 0
        Me.ChangeToLabel.Text = "Change To"
        '
        'SeatNumberComboBox
        '
        Me.SeatNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SeatNumberComboBox.FormattingEnabled = True
        Me.SeatNumberComboBox.Location = New System.Drawing.Point(96, 22)
        Me.SeatNumberComboBox.Name = "SeatNumberComboBox"
        Me.SeatNumberComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SeatNumberComboBox.TabIndex = 1
        '
        'SeatNumberLabel
        '
        Me.SeatNumberLabel.AutoSize = True
        Me.SeatNumberLabel.Location = New System.Drawing.Point(13, 26)
        Me.SeatNumberLabel.Name = "SeatNumberLabel"
        Me.SeatNumberLabel.Size = New System.Drawing.Size(69, 13)
        Me.SeatNumberLabel.TabIndex = 0
        Me.SeatNumberLabel.Text = "Seat Number"
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 391)
        Me.Controls.Add(Me.EditComputerGroupBox)
        Me.Controls.Add(Me.EditTransactionGroupBox)
        Me.Controls.Add(Me.SeatDetailDataGridView)
        Me.Controls.Add(Me.TransactionDataGridView)
        Me.Name = "HistoryForm"
        Me.Text = "HistoryForm"
        CType(Me.TransactionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeatDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditTransactionGroupBox.ResumeLayout(False)
        Me.EditTransactionGroupBox.PerformLayout()
        Me.EditComputerGroupBox.ResumeLayout(False)
        Me.EditComputerGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TransactionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SeatDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EditTransactionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EditComputerGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DeleteTransactionButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents TransactionDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BookingDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PaymentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TransactionDateLabel As System.Windows.Forms.Label
    Friend WithEvents PaymentLabel As System.Windows.Forms.Label
    Friend WithEvents BookingDateLabel As System.Windows.Forms.Label
    Friend WithEvents TransactionIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TransactionIDLabel As System.Windows.Forms.Label
    Friend WithEvents DeleteSeatButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents ChangeToComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ChangeToLabel As System.Windows.Forms.Label
    Friend WithEvents SeatNumberComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SeatNumberLabel As System.Windows.Forms.Label
End Class
