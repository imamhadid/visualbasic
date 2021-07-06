<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class timer
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
        Me.components = New System.ComponentModel.Container()
        Me.DTtanggal = New System.Windows.Forms.DateTimePicker()
        Me.Lbl24jam = New System.Windows.Forms.Label()
        Me.Lbl12jam = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'DTtanggal
        '
        Me.DTtanggal.Location = New System.Drawing.Point(74, 215)
        Me.DTtanggal.Name = "DTtanggal"
        Me.DTtanggal.Size = New System.Drawing.Size(200, 20)
        Me.DTtanggal.TabIndex = 3
        '
        'Lbl24jam
        '
        Me.Lbl24jam.AutoSize = True
        Me.Lbl24jam.Location = New System.Drawing.Point(71, 127)
        Me.Lbl24jam.Name = "Lbl24jam"
        Me.Lbl24jam.Size = New System.Drawing.Size(39, 13)
        Me.Lbl24jam.TabIndex = 5
        Me.Lbl24jam.Text = "Label2"
        '
        'Lbl12jam
        '
        Me.Lbl12jam.AutoSize = True
        Me.Lbl12jam.Location = New System.Drawing.Point(71, 83)
        Me.Lbl12jam.Name = "Lbl12jam"
        Me.Lbl12jam.Size = New System.Drawing.Size(39, 13)
        Me.Lbl12jam.TabIndex = 4
        Me.Lbl12jam.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'timer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 262)
        Me.Controls.Add(Me.Lbl24jam)
        Me.Controls.Add(Me.Lbl12jam)
        Me.Controls.Add(Me.DTtanggal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "timer"
        Me.Text = "timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTtanggal As DateTimePicker
    Friend WithEvents Lbl24jam As Label
    Friend WithEvents Lbl12jam As Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
End Class
