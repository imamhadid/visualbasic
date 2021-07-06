<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class praktikum3modulbook
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
        Me.Cmb_Drive = New System.Windows.Forms.ComboBox()
        Me.LstInfo = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cmb_Drive
        '
        Me.Cmb_Drive.FormattingEnabled = True
        Me.Cmb_Drive.Location = New System.Drawing.Point(141, 12)
        Me.Cmb_Drive.Name = "Cmb_Drive"
        Me.Cmb_Drive.Size = New System.Drawing.Size(197, 21)
        Me.Cmb_Drive.TabIndex = 0
        '
        'LstInfo
        '
        Me.LstInfo.FormattingEnabled = True
        Me.LstInfo.Location = New System.Drawing.Point(141, 57)
        Me.LstInfo.Name = "LstInfo"
        Me.LstInfo.Size = New System.Drawing.Size(197, 277)
        Me.LstInfo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Drive"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Keterangan"
        '
        'praktikum3modulbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 354)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstInfo)
        Me.Controls.Add(Me.Cmb_Drive)
        Me.Name = "praktikum3modulbook"
        Me.Text = "ComboBox dan ListDrive"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmb_Drive As ComboBox
    Friend WithEvents LstInfo As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
