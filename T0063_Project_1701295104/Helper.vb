Public Class Helper
    Public Shared user As MsUser

    Shared db As dWarneTSDatabaseEntities1 = New dWarneTSDatabaseEntities1


    Shared Function CheckAlphaNumeric(ByVal Text As String) As Boolean
        Dim isLetter As Boolean = False
        Dim isNumeric As Boolean = False
        For index = 0 To Text.Length - 1
            If Char.IsLetter(Text(index)) Then
                isLetter = True
            ElseIf Char.IsDigit(Text(index)) Then
                isNumeric = True
            End If
        Next
        CheckAlphaNumeric = (isLetter And isNumeric)
    End Function

    Shared Function CheckAlphaNumericCapital(ByVal Text As String) As Boolean
        Dim isLetter As Boolean = False
        Dim isCapital As Boolean = False
        Dim isNumeric As Boolean = False
        For index = 0 To Text.Length - 1
            If Char.IsLetter(Text(index)) Then
                If Char.IsUpper(Text(index)) Then
                    isCapital = True
                Else
                    isLetter = True
                End If
            ElseIf Char.IsDigit(Text(index)) Then
                isNumeric = True
            End If
        Next
        CheckAlphaNumericCapital = (isLetter And isNumeric And isCapital)
    End Function

    Shared Function CheckLogin(ByVal Username As String, ByVal Password As String) As Boolean

        Dim q = db.MsUsers.Where(Function(x) x.Name.Equals(Username) And x.Password.Equals(Password))

        If q.Count < 1 Then
            user = Nothing
            CheckLogin = False
        Else
            user = q.First
            CheckLogin = True
        End If


    End Function

    Shared Function Register(ByVal Name As String, ByVal Password As String, ByVal Gender As String, ByVal CCN As String, ByVal Bank As String, ByVal BAN As String) As Boolean
        'Userid is automatically generated from MsUser with format [USxxxx] plus by 1. 
        'For example if the last User ID is “US0002”, then the program will generate it into “US0003”.

        Try
            Dim newUser As MsUser = New MsUser
            newUser.Userid = "US" + (Int16.Parse((db.MsUsers.OrderByDescending(Function(x) x.Userid)).First.Userid.Substring(2)) + 1).ToString("0000")
            newUser.Name = Name
            newUser.Password = Password
            newUser.Gender = Gender
            newUser.CreditCardNumber = CCN
            newUser.BankName = Bank
            newUser.BankAccNumber = BAN
            newUser.LastUpdate = Today
            db.MsUsers.AddObject(newUser)
            db.SaveChanges()
            Register = True
        Catch ex As Exception
            Register = False

        End Try


    End Function

    Shared Function CheckTextLength(ByVal Text As String, ByVal MinimumLength As Integer, ByVal MaximumLength As Integer) As Boolean
        CheckTextLength = (Text.Length >= MinimumLength And Text.Length <= MaximumLength)
    End Function
    Shared Function CheckSelected(ParamArray buttons() As RadioButton) As Boolean
        CheckSelected = False
        For index = 0 To buttons.Length - 1
            If buttons(index).Checked = True Then
                CheckSelected = True
                Exit For
            End If
        Next
    End Function

    Shared Function IsUpdateable(ByVal BAN As String, ByVal CCN As String) As Boolean
        If DateDiff(DateInterval.Day, user.LastUpdate, Today) < 30 And (BAN <> user.BankAccNumber Or CCN <> user.CreditCardNumber) Then
            IsUpdateable = False
        Else
            IsUpdateable = True
        End If

    End Function

    Shared Function UpdateMember(ByVal Name As String, ByVal Password As String, ByVal CCN As String, ByVal Bank As String, ByVal BAN As String) As Boolean
        'o	Users can only update Bank Account Number or Credit Card Number once in 30 days.

        Try
            Dim dbUser = db.MsUsers.Where(Function(x) x.Userid = user.Userid).First
            dbUser.Name = Name
            dbUser.Password = Password
            dbUser.CreditCardNumber = CCN
            dbUser.BankName = Bank
            dbUser.BankAccNumber = BAN
            dbUser.LastUpdate = Today

            db.SaveChanges()
            UpdateMember = True
        Catch ex As Exception
            UpdateMember = False
        End Try

    End Function


    Shared Function GetComputer(ByVal RowCol As String) As MsComputer
        GetComputer = db.MsComputers.Where(Function(x) x.RowCol = RowCol).First
    End Function

    Shared Function UpdateComputer(ByVal RowCol As String, ByVal Status As String, ByVal Reason As String) As Boolean
        Try
            Dim c = db.MsComputers.Where(Function(x) x.RowCol = RowCol).First
            c.Status = Status
            c.Reason = Reason
            db.SaveChanges()
            UpdateComputer = True
        Catch ex As Exception
            UpdateComputer = False
        End Try
    End Function

    Shared Function GetTransactionByDate(ByVal TransactionDate As Date) As List(Of HeaderTransaction)
        GetTransactionByDate = db.HeaderTransactions.Where(Function(x) x.Transactiondate.Day = TransactionDate.Day And x.Transactiondate.Month = TransactionDate.Month And x.Transactiondate.Year = TransactionDate.Year).ToList
    End Function

    Shared Function Book(ByVal Boxes As List(Of BookingBox), ByVal PaymentMethod As String, ByVal BookDate As Date) As Boolean

        Try
            Dim newPayment = New MsPayment
            newPayment.Accountnumber = user.BankAccNumber
            newPayment.Method = PaymentMethod
            newPayment.Paymentid = "PA" + (Int16.Parse((db.MsPayments.OrderByDescending(Function(x) x.Paymentid)).First.Paymentid.Substring(2)) + 1).ToString("0000")

            db.AddToMsPayments(newPayment)

            db.SaveChanges()

            Dim newTransaction = New HeaderTransaction
            newTransaction.Transactiondate = Today
            newTransaction.Bookingdate = BookDate
            newTransaction.Userid = user.Userid
            newTransaction.Transactionid = "TR" + (Int16.Parse((db.HeaderTransactions.OrderByDescending(Function(x) x.Transactionid)).First.Transactionid.Substring(2)) + 1).ToString("0000")
            newTransaction.Paymentid = newPayment.Paymentid
            For Each box In Boxes
                newTransaction.MsComputers.Add(db.MsComputers.Where(Function(x) x.RowCol = box.CheckBoxName).First)
            Next

            db.AddToHeaderTransactions(newTransaction)

            db.SaveChanges()

            Book = True
        Catch ex As Exception
            Book = False
        End Try



    End Function

    Shared Function GetTransactionHistoryByUser()
        GetTransactionHistoryByUser = db.HeaderTransactions.Where(Function(x) x.Userid = user.Userid).Select(Function(x) New With {x.Transactionid, x.Transactiondate, x.Bookingdate, x.Paymentid})
    End Function

    Shared Function GetComputerByTransaction(ByVal TransactionId As String)
        GetComputerByTransaction = db.HeaderTransactions.Where(Function(x) x.Transactionid = TransactionId).First.MsComputers '.Select(Function(z) New With {z.RowCol, z.Status})
    End Function

    Shared Function GetPaymentMethod(ByVal PaymentId As String) As String
        GetPaymentMethod = db.MsPayments.Where(Function(x) x.Paymentid = PaymentId).First.Method
    End Function

    Shared Function SaveTransaction(ByVal TransactionId As String, ByVal PaymentMethod As String) As Boolean
        Try
            Dim newPayment = New MsPayment
            newPayment.Accountnumber = user.BankAccNumber
            newPayment.Method = PaymentMethod
            newPayment.Paymentid = "PA" + (Int16.Parse((db.MsPayments.OrderByDescending(Function(x) x.Paymentid)).First.Paymentid.Substring(2)) + 1).ToString("0000")

            db.AddToMsPayments(newPayment)

            db.SaveChanges()

            Dim oldTransaction = db.HeaderTransactions.Where(Function(x) x.Transactionid = TransactionId).First
            oldTransaction.Paymentid = newPayment.Paymentid


            db.SaveChanges()

            SaveTransaction = True
        Catch ex As Exception
            SaveTransaction = False
        End Try
    End Function


    Shared Function DeleteTransaction(ByVal TransactionId As String) As Boolean
        Try
            db.HeaderTransactions.DeleteObject(db.HeaderTransactions.Where(Function(x) x.Transactionid = TransactionId).First)

            db.SaveChanges()

            DeleteTransaction = True
        Catch ex As Exception
            DeleteTransaction = False
        End Try
    End Function

    Shared Function GetAvailableSeat(ByVal TransactionDate As Date)
        Dim allComp As List(Of MsComputer) = db.MsComputers.ToList, bookedComp As List(Of MsComputer) = New List(Of MsComputer)
        Dim transactions = GetTransactionByDate(TransactionDate)

        For Each t In transactions
            bookedComp.AddRange(t.MsComputers.ToList)
        Next

        GetAvailableSeat = allComp.Except(bookedComp).ToArray

    End Function


    Shared Function UpdateSeat(ByVal TransactionId As String, ByVal SeatNumber As String, ByVal ChangeTo As String) As Boolean
        Try

            Dim oldTransaction = db.HeaderTransactions.Where(Function(x) x.Transactionid = TransactionId).First
            oldTransaction.MsComputers.Remove(db.MsComputers.Where(Function(x) x.RowCol = SeatNumber).First)
            oldTransaction.MsComputers.Add(db.MsComputers.Where(Function(x) x.RowCol = ChangeTo).First)


            db.SaveChanges()

            UpdateSeat = True
        Catch ex As Exception
            UpdateSeat = False
        End Try
    End Function


    Shared Function DeleteSeat(ByVal TransactionId As String, ByVal SeatNumber As String) As Boolean
        Try
            Dim oldTransaction = db.HeaderTransactions.Where(Function(x) x.Transactionid = TransactionId).First
            oldTransaction.MsComputers.Remove(db.MsComputers.Where(Function(x) x.RowCol = SeatNumber).First)
            db.SaveChanges()

            DeleteSeat = True
        Catch ex As Exception
            DeleteSeat = False
        End Try
    End Function


End Class
