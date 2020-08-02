<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label = New System.Windows.Forms.Label()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.Location = New System.Drawing.Point(3, 94)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox.TabIndex = 7
        Me.CheckBox.Text = "RowCol"
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(100, 85)
        Me.PictureBox.TabIndex = 6
        Me.PictureBox.TabStop = False
        '
        'Label
        '
        Me.Label.Location = New System.Drawing.Point(3, 114)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(100, 41)
        Me.Label.TabIndex = 8
        Me.Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BookingBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.CheckBox)
        Me.Controls.Add(Me.PictureBox)
        Me.Name = "BookingBox"
        Me.Size = New System.Drawing.Size(111, 159)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label As System.Windows.Forms.Label

End Class
