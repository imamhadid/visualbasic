<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pratice2
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
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.TxtAngka = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(141, 38)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(75, 23)
        Me.BtnProses.TabIndex = 3
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'TxtAngka
        '
        Me.TxtAngka.Location = New System.Drawing.Point(15, 12)
        Me.TxtAngka.Name = "TxtAngka"
        Me.TxtAngka.Size = New System.Drawing.Size(201, 20)
        Me.TxtAngka.TabIndex = 2
        '
        'pratice2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 72)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.TxtAngka)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "pratice2"
        Me.Text = "pratice2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnProses As Button
    Friend WithEvents TxtAngka As TextBox
End Class
