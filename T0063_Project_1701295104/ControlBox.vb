Imports System.ComponentModel

Public Class ControlBox

    <Description("Group box name")>
    Public Property GroupBoxName As String
        Set(value As String)
            GroupBox.Text = value
        End Set
        Get

            Return GroupBox.Text

        End Get
    End Property
End Class
