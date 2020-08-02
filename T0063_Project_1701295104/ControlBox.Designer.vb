<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlBox
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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ReasonLabel = New System.Windows.Forms.Label()
        Me.OfflineRadioButton = New System.Windows.Forms.RadioButton()
        Me.ServingRadioButton = New System.Windows.Forms.RadioButton()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.RichTextBox)
        Me.GroupBox.Controls.Add(Me.ReasonLabel)
        Me.GroupBox.Controls.Add(Me.OfflineRadioButton)
        Me.GroupBox.Controls.Add(Me.ServingRadioButton)
        Me.GroupBox.Controls.Add(Me.PictureBox)
        Me.GroupBox.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(166, 224)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "1A"
        '
        'RichTextBox
        '
        Me.RichTextBox.Location = New System.Drawing.Point(56, 160)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.Size = New System.Drawing.Size(101, 58)
        Me.RichTextBox.TabIndex = 1
        Me.RichTextBox.Text = ""
        '
        'ReasonLabel
        '
        Me.ReasonLabel.AutoSize = True
        Me.ReasonLabel.Location = New System.Drawing.Point(6, 160)
        Me.ReasonLabel.Name = "ReasonLabel"
        Me.ReasonLabel.Size = New System.Drawing.Size(44, 13)
        Me.ReasonLabel.TabIndex = 1
        Me.ReasonLabel.Text = "Reason"
        '
        'OfflineRadioButton
        '
        Me.OfflineRadioButton.AutoSize = True
        Me.OfflineRadioButton.Location = New System.Drawing.Point(6, 140)
        Me.OfflineRadioButton.Name = "OfflineRadioButton"
        Me.OfflineRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.OfflineRadioButton.TabIndex = 1
        Me.OfflineRadioButton.TabStop = True
        Me.OfflineRadioButton.Text = "Offline"
        Me.OfflineRadioButton.UseVisualStyleBackColor = True
        '
        'ServingRadioButton
        '
        Me.ServingRadioButton.AutoSize = True
        Me.ServingRadioButton.Location = New System.Drawing.Point(6, 117)
        Me.ServingRadioButton.Name = "ServingRadioButton"
        Me.ServingRadioButton.Size = New System.Drawing.Size(61, 17)
        Me.ServingRadioButton.TabIndex = 1
        Me.ServingRadioButton.TabStop = True
        Me.ServingRadioButton.Text = "Serving"
        Me.ServingRadioButton.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(102, 92)
        Me.PictureBox.TabIndex = 1
        Me.PictureBox.TabStop = False
        '
        'ControlBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "ControlBox"
        Me.Size = New System.Drawing.Size(172, 232)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents ReasonLabel As System.Windows.Forms.Label
    Friend WithEvents OfflineRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ServingRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox

End Class
