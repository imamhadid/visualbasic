Public Class Home

    Private Sub Praktikum1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Praktikum1ToolStripMenuItem.Click
        Hadit.Show()
        Hide()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Need Permission To Perform This Action", "Error 0x00000007d",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub SpesialAttactToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Spesial.Show()
        Hide()
    End Sub

    Private Sub TextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextToolStripMenuItem.Click

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim tutup As String
        tutup = MessageBox.Show("Anda yakin ingin logout?", "Logout",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            Hide()
            Login.Show()
        Else
        End If
    End Sub

    Private Sub Praktikum2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Praktikum2ToolStripMenuItem.Click
        matauang.Show()
    End Sub

    Private Sub Tugas1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Tugas1ToolStripMenuItem.Click
        tugas1.Show()
        Hide()
    End Sub

    Private Sub Tugas2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Tugas2ToolStripMenuItem.Click
        Tugas2.Show()
        Hide()
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        MessageBox.Show("Need Permission To Perform This Action", "Error 0x00000007d",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub BantuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BantuanToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/adit_vanh/")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Praktikum4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Praktikum4ToolStripMenuItem.Click
        Form2.Show()
        Me.Show()
    End Sub

    Private Sub Praktikum5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Praktikum5ToolStripMenuItem.Click
        Form3.Show()
        Me.Show()
    End Sub

    Private Sub Praktikum6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Praktikum6ToolStripMenuItem.Click
        praktikum6.Show()
        Me.Hide()
    End Sub

    Private Sub Praktikum3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Praktikum3ToolStripMenuItem.Click
        tokobuah.Show()
    End Sub

    Private Sub GameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameToolStripMenuItem.Click

    End Sub

    Private Sub TacTicToeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TacTicToeToolStripMenuItem.Click
        Dim start
        start = MessageBox.Show("Selamat Bermain Game Tic Tac Toe", "Game Tic Tac Toe", MessageBoxButtons.OK)
        If start = DialogResult.OK Then
            Form4.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Praktikum7LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Praktikum7LoginToolStripMenuItem.Click
        pesanrahasia.Show()
        Hide()
        Login.Show()

    End Sub

    Private Sub Praktikum8ForPengulanganToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ForToolStripMenuItem_Click(sender As Object, e As EventArgs)
        prak8.Show()

    End Sub

    Private Sub WhileToolStripMenuItem_Click(sender As Object, e As EventArgs)
        prak8while.Show()

    End Sub

    Private Sub DoWhileToolStripMenuItem_Click(sender As Object, e As EventArgs)
        prak8dowhile.Show()

    End Sub

    Private Sub ForEachToolStripMenuItem_Click(sender As Object, e As EventArgs)
        foreach.Show()

    End Sub

    Private Sub ArraySatuDimensiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        array1dimensi.Show()

    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs)
        prak10.Show()

    End Sub

    Private Sub FunctionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        function10.Show()

    End Sub

    Private Sub Praktikum11ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        praktikum11db.Show()

    End Sub

    Private Sub PesanRahasiaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        pesanrahasia.Show()
    End Sub

    Private Sub Praktikum1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Praktikum1ToolStripMenuItem1.Click
        frmlatihan.Show()

    End Sub

    Private Sub Praktikum2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Praktikum2ToolStripMenuItem1.Click
        tugas1.Show()
        Hide()
    End Sub

    Private Sub TimerAndTimerPickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimerAndTimerPickerToolStripMenuItem.Click
        timer.Show()

    End Sub

    Private Sub Praktikum3ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Praktikum3ToolStripMenuItem1.Click
        praktikum3modulbook.Show()

    End Sub

    Private Sub MenusStripContextMenuStripDanRichTextBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenusStripContextMenuStripDanRichTextBoxToolStripMenuItem.Click
        Note.Show()

    End Sub

    Private Sub VariabelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VariabelToolStripMenuItem.Click
        vlokal.Show()

    End Sub

    Private Sub OpratorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpratorToolStripMenuItem.Click
        Tugas2.Show()

    End Sub

    Private Sub PencabanganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PencabanganToolStripMenuItem.Click
        pencabangan.Show()

    End Sub

    Private Sub PencabanganIFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PencabanganIFToolStripMenuItem.Click
        Login.Show()

    End Sub

    Private Sub PerulanganFORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerulanganFORToolStripMenuItem.Click
        pengulangan.Show()

    End Sub

    Private Sub PengulanganWhileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengulanganWhileToolStripMenuItem.Click
        pengulangan1.Show()

    End Sub

    Private Sub PengulanganDOWHILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengulanganDOWHILEToolStripMenuItem.Click
        pengulangan_2.Show()

    End Sub

    Private Sub PengulanganFOREACHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengulanganFOREACHToolStripMenuItem.Click
        foreach1.Show()

    End Sub

    Private Sub ArraySatuDimensiToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ArraySatuDimensiToolStripMenuItem.Click
        array1dimensi.Show()

    End Sub

    Private Sub ArrayMultiDimensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrayMultiDimensiToolStripMenuItem.Click
        arraymultidimensi.Show()

    End Sub

    Private Sub ProsedurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProsedurToolStripMenuItem.Click
        prak10.Show()

    End Sub

    Private Sub FunctionToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FunctionToolStripMenuItem.Click
        function10.Show()

    End Sub

    Private Sub Praktikum11ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Praktikum11ToolStripMenuItem.Click
        praktikum11db.Show()

    End Sub

    Private Sub Pratice1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pratice1ToolStripMenuItem.Click
        pratice1.Show()

    End Sub

    Private Sub Pratice2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pratice2ToolStripMenuItem.Click
        pratice2.Show()

    End Sub

    Private Sub IDPWAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDPWAdminToolStripMenuItem.Click
        MessageBox.Show("PW admin", "ID admin", MessageBoxButtons.OK)
    End Sub
End Class