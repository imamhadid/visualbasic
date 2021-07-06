<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class function10
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
        Me.TxtVar1 = New System.Windows.Forms.TextBox()
        Me.TxtVar2 = New System.Windows.Forms.TextBox()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbAkar = New System.Windows.Forms.RadioButton()
        Me.RdbPangkat = New System.Windows.Forms.RadioButton()
        Me.RdbPembagian = New System.Windows.Forms.RadioButton()
        Me.RdbPerkalian = New System.Windows.Forms.RadioButton()
        Me.RdbPenjumlahan = New System.Windows.Forms.RadioButton()
        Me.RdbPengurangan = New System.Windows.Forms.RadioButton()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtVar1
        '
        Me.TxtVar1.Location = New System.Drawing.Point(25, 12)
        Me.TxtVar1.Name = "TxtVar1"
        Me.TxtVar1.Size = New System.Drawing.Size(100, 20)
        Me.TxtVar1.TabIndex = 0
        '
        'TxtVar2
        '
        Me.TxtVar2.Location = New System.Drawing.Point(25, 49)
        Me.TxtVar2.Name = "TxtVar2"
        Me.TxtVar2.Size = New System.Drawing.Size(100, 20)
        Me.TxtVar2.TabIndex = 1
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(161, 12)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(155, 20)
        Me.TxtHasil.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbPengurangan)
        Me.GroupBox1.Controls.Add(Me.RdbPenjumlahan)
        Me.GroupBox1.Controls.Add(Me.RdbPerkalian)
        Me.GroupBox1.Controls.Add(Me.RdbPembagian)
        Me.GroupBox1.Controls.Add(Me.RdbPangkat)
        Me.GroupBox1.Controls.Add(Me.RdbAkar)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 135)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'RdbAkar
        '
        Me.RdbAkar.AutoSize = True
        Me.RdbAkar.Location = New System.Drawing.Point(10, 28)
        Me.RdbAkar.Name = "RdbAkar"
        Me.RdbAkar.Size = New System.Drawing.Size(90, 17)
        Me.RdbAkar.TabIndex = 0
        Me.RdbAkar.TabStop = True
        Me.RdbAkar.Text = "Akar Kuadrad"
        Me.RdbAkar.UseVisualStyleBackColor = True
        '
        'RdbPangkat
        '
        Me.RdbPangkat.AutoSize = True
        Me.RdbPangkat.Location = New System.Drawing.Point(10, 65)
        Me.RdbPangkat.Name = "RdbPangkat"
        Me.RdbPangkat.Size = New System.Drawing.Size(65, 17)
        Me.RdbPangkat.TabIndex = 1
        Me.RdbPangkat.TabStop = True
        Me.RdbPangkat.Text = "Pangkat"
        Me.RdbPangkat.UseVisualStyleBackColor = True
        '
        'RdbPembagian
        '
        Me.RdbPembagian.AutoSize = True
        Me.RdbPembagian.Location = New System.Drawing.Point(10, 100)
        Me.RdbPembagian.Name = "RdbPembagian"
        Me.RdbPembagian.Size = New System.Drawing.Size(78, 17)
        Me.RdbPembagian.TabIndex = 2
        Me.RdbPembagian.TabStop = True
        Me.RdbPembagian.Text = "Pembagian"
        Me.RdbPembagian.UseVisualStyleBackColor = True
        '
        'RdbPerkalian
        '
        Me.RdbPerkalian.AutoSize = True
        Me.RdbPerkalian.Location = New System.Drawing.Point(201, 28)
        Me.RdbPerkalian.Name = "RdbPerkalian"
        Me.RdbPerkalian.Size = New System.Drawing.Size(69, 17)
        Me.RdbPerkalian.TabIndex = 3
        Me.RdbPerkalian.TabStop = True
        Me.RdbPerkalian.Text = "Perkalian"
        Me.RdbPerkalian.UseVisualStyleBackColor = True
        '
        'RdbPenjumlahan
        '
        Me.RdbPenjumlahan.AutoSize = True
        Me.RdbPenjumlahan.Location = New System.Drawing.Point(201, 65)
        Me.RdbPenjumlahan.Name = "RdbPenjumlahan"
        Me.RdbPenjumlahan.Size = New System.Drawing.Size(86, 17)
        Me.RdbPenjumlahan.TabIndex = 4
        Me.RdbPenjumlahan.TabStop = True
        Me.RdbPenjumlahan.Text = "Penjumlahan"
        Me.RdbPenjumlahan.UseVisualStyleBackColor = True
        '
        'RdbPengurangan
        '
        Me.RdbPengurangan.AutoSize = True
        Me.RdbPengurangan.Location = New System.Drawing.Point(201, 100)
        Me.RdbPengurangan.Name = "RdbPengurangan"
        Me.RdbPengurangan.Size = New System.Drawing.Size(89, 17)
        Me.RdbPengurangan.TabIndex = 5
        Me.RdbPengurangan.TabStop = True
        Me.RdbPengurangan.Text = "Pengurangan"
        Me.RdbPengurangan.UseVisualStyleBackColor = True
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(161, 260)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(75, 23)
        Me.BtnHitung.TabIndex = 4
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(260, 260)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'function10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 298)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtVar2)
        Me.Controls.Add(Me.TxtVar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "function10"
        Me.Text = "Function"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtVar1 As TextBox
    Friend WithEvents TxtVar2 As TextBox
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbPengurangan As RadioButton
    Friend WithEvents RdbPenjumlahan As RadioButton
    Friend WithEvents RdbPerkalian As RadioButton
    Friend WithEvents RdbPembagian As RadioButton
    Friend WithEvents RdbPangkat As RadioButton
    Friend WithEvents RdbAkar As RadioButton
    Friend WithEvents BtnHitung As Button
    Friend WithEvents BtnExit As Button
End Class
