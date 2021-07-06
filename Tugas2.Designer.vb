<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tugas2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tugas2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNilai1 = New System.Windows.Forms.TextBox()
        Me.TxtNilai2 = New System.Windows.Forms.TextBox()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.CmbOperator = New System.Windows.Forms.ComboBox()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'TxtNilai1
        '
        Me.TxtNilai1.Location = New System.Drawing.Point(112, 53)
        Me.TxtNilai1.Name = "TxtNilai1"
        Me.TxtNilai1.Size = New System.Drawing.Size(121, 20)
        Me.TxtNilai1.TabIndex = 4
        '
        'TxtNilai2
        '
        Me.TxtNilai2.Location = New System.Drawing.Point(112, 144)
        Me.TxtNilai2.Name = "TxtNilai2"
        Me.TxtNilai2.Size = New System.Drawing.Size(121, 20)
        Me.TxtNilai2.TabIndex = 5
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(112, 183)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(121, 20)
        Me.TxtHasil.TabIndex = 6
        '
        'CmbOperator
        '
        Me.CmbOperator.FormattingEnabled = True
        Me.CmbOperator.Location = New System.Drawing.Point(112, 100)
        Me.CmbOperator.Name = "CmbOperator"
        Me.CmbOperator.Size = New System.Drawing.Size(121, 21)
        Me.CmbOperator.TabIndex = 7
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(148, 233)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(85, 30)
        Me.BtnProses.TabIndex = 8
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(35, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Tugas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 338)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.CmbOperator)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtNilai2)
        Me.Controls.Add(Me.TxtNilai1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tugas2"
        Me.Text = "Operator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNilai1 As TextBox
    Friend WithEvents TxtNilai2 As TextBox
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents CmbOperator As ComboBox
    Friend WithEvents BtnProses As Button
    Friend WithEvents Button2 As Button
End Class
