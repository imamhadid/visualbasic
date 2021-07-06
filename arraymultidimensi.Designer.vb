<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arraymultidimensi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNIM = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.CmbKelamin = New System.Windows.Forms.ComboBox()
        Me.CmbProdi = New System.Windows.Forms.ComboBox()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prodi"
        '
        'TxtNIM
        '
        Me.TxtNIM.Location = New System.Drawing.Point(93, 21)
        Me.TxtNIM.Name = "TxtNIM"
        Me.TxtNIM.Size = New System.Drawing.Size(121, 20)
        Me.TxtNIM.TabIndex = 4
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(93, 53)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(121, 20)
        Me.TxtNama.TabIndex = 5
        '
        'CmbKelamin
        '
        Me.CmbKelamin.FormattingEnabled = True
        Me.CmbKelamin.Location = New System.Drawing.Point(93, 88)
        Me.CmbKelamin.Name = "CmbKelamin"
        Me.CmbKelamin.Size = New System.Drawing.Size(121, 21)
        Me.CmbKelamin.TabIndex = 6
        '
        'CmbProdi
        '
        Me.CmbProdi.FormattingEnabled = True
        Me.CmbProdi.Location = New System.Drawing.Point(93, 122)
        Me.CmbProdi.Name = "CmbProdi"
        Me.CmbProdi.Size = New System.Drawing.Size(121, 21)
        Me.CmbProdi.TabIndex = 7
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(237, 120)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(134, 23)
        Me.BtnProses.TabIndex = 8
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(35, 164)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(336, 231)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'arraymultidimensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 407)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.CmbProdi)
        Me.Controls.Add(Me.CmbKelamin)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtNIM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "arraymultidimensi"
        Me.Text = "Array Multi Dimensi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNIM As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents CmbKelamin As ComboBox
    Friend WithEvents CmbProdi As ComboBox
    Friend WithEvents BtnProses As Button
    Friend WithEvents ListView1 As ListView
End Class
