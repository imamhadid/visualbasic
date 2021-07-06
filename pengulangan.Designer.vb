<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pengulangan
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
        Me.CmbThn = New System.Windows.Forms.ComboBox()
        Me.CmbBln = New System.Windows.Forms.ComboBox()
        Me.CmbTgl = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmbThn
        '
        Me.CmbThn.FormattingEnabled = True
        Me.CmbThn.Location = New System.Drawing.Point(217, 12)
        Me.CmbThn.Name = "CmbThn"
        Me.CmbThn.Size = New System.Drawing.Size(48, 21)
        Me.CmbThn.TabIndex = 7
        '
        'CmbBln
        '
        Me.CmbBln.FormattingEnabled = True
        Me.CmbBln.Location = New System.Drawing.Point(163, 12)
        Me.CmbBln.Name = "CmbBln"
        Me.CmbBln.Size = New System.Drawing.Size(48, 21)
        Me.CmbBln.TabIndex = 6
        '
        'CmbTgl
        '
        Me.CmbTgl.FormattingEnabled = True
        Me.CmbTgl.Location = New System.Drawing.Point(109, 12)
        Me.CmbTgl.Name = "CmbTgl"
        Me.CmbTgl.Size = New System.Drawing.Size(48, 21)
        Me.CmbTgl.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tgl/Bln/Thn"
        '
        'pengulangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 48)
        Me.Controls.Add(Me.CmbThn)
        Me.Controls.Add(Me.CmbBln)
        Me.Controls.Add(Me.CmbTgl)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "pengulangan"
        Me.Text = "Date"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbThn As ComboBox
    Friend WithEvents CmbBln As ComboBox
    Friend WithEvents CmbTgl As ComboBox
    Friend WithEvents Label1 As Label
End Class
