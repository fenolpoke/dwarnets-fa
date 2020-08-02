Imports System.ComponentModel

Public Class BookingBox
    <Description("Check box name")>
    Public Property CheckBoxName As String
        Set(value As String)
            CheckBox.Text = value
        End Set
        Get

            Return CheckBox.Text

        End Get
    End Property
End Class
