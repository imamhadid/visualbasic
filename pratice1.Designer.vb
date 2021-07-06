<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pratice1
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
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnBuka = New System.Windows.Forms.Button()
        Me.PcbGambar = New System.Windows.Forms.PictureBox()
        Me.ofdBuka = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PcbGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(231, 303)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnBuka
        '
        Me.BtnBuka.Location = New System.Drawing.Point(12, 303)
        Me.BtnBuka.Name = "BtnBuka"
        Me.BtnBuka.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuka.TabIndex = 4
        Me.BtnBuka.Text = "Buka"
        Me.BtnBuka.UseVisualStyleBackColor = True
        '
        'PcbGambar
        '
        Me.PcbGambar.Location = New System.Drawing.Point(12, 12)
        Me.PcbGambar.Name = "PcbGambar"
        Me.PcbGambar.Size = New System.Drawing.Size(294, 259)
        Me.PcbGambar.TabIndex = 3
        Me.PcbGambar.TabStop = False
        '
        'ofdBuka
        '
        Me.ofdBuka.FileName = "OpenFileDialog1"
        '
        'pratice1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 349)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnBuka)
        Me.Controls.Add(Me.PcbGambar)
        Me.Name = "pratice1"
        Me.Text = "pratice1"
        CType(Me.PcbGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnBuka As Button
    Friend WithEvents PcbGambar As PictureBox
    Friend WithEvents ofdBuka As OpenFileDialog
End Class
