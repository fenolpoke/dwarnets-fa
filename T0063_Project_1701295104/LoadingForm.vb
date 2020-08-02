Public Class LoadingForm

    Private Sub LoadingForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer.Start()
        
    End Sub

    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick

        ProgressBar.Value += 10
        If ProgressBar.Maximum <= ProgressBar.Value Then
            Timer.Stop()
            LoginForm.Show()
            Me.Close()
        End If

    End Sub
End Class
