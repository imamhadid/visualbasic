Module main
    Public Sub MententukanPemain()
        If game.pemain.Text = game.Label2.Text Then
            game.PictureBox10.Image = Form4.PictureBox1.Image
        ElseIf game.pemain.Text = game.Label3.Text Then
            game.PictureBox10.Image = Form4.PictureBox2.Image
        Else
            game.PictureBox10.Image = Image.FromFile("img\z.png")
        End If
    End Sub

    Public Sub MerubahGiliran()
        If game.pemain.Text = game.Label2.Text Then
            game.pemain.Text = game.Label3.Text
        ElseIf game.pemain.Text = game.Label3.Text Then
            game.pemain.Text = game.Label2.Text
        Else
            game.pemain.Text = game.Label2.Text
        End If
        If game.pemain1.Text = "1" Then
            win()
            game.pemain1.Text = "2"
        ElseIf game.pemain1.Text = "2" Then
            win()
            game.pemain1.Text = "1"
        Else
            game.pemain1.Text = "1"
        End If
        MententukanPemain()
    End Sub

    Public Sub reset()

        Form4.Show()
        game.Hide()

    End Sub

    Public Sub win()
        If game.kotak1.Text = "1" And game.kotak2.Text = "1" And game.kotak3.Text = "1" Then
            winner()
        ElseIf game.kotak4.Text = "1" And game.kotak5.Text = "1" And game.kotak6.Text = "1" Then
            winner()
        ElseIf game.kotak7.Text = "1" And game.kotak8.Text = "1" And game.kotak9.Text = "1" Then
            winner()
        ElseIf game.kotak1.Text = "1" And game.kotak4.Text = "1" And game.kotak7.Text = "1" Then
            winner()
        ElseIf game.kotak2.Text = "1" And game.kotak5.Text = "1" And game.kotak8.Text = "1" Then
            winner()
        ElseIf game.kotak3.Text = "1" And game.kotak6.Text = "1" And game.kotak9.Text = "1" Then
            winner()
        ElseIf game.kotak1.Text = "1" And game.kotak5.Text = "1" And game.kotak9.Text = "1" Then
            winner()
        ElseIf game.kotak3.Text = "1" And game.kotak5.Text = "1" And game.kotak7.Text = "1" Then
            winner()
        End If

        If game.kotak1.Text = "2" And game.kotak2.Text = "2" And game.kotak3.Text = "2" Then
            winner()
        ElseIf game.kotak4.Text = "2" And game.kotak5.Text = "2" And game.kotak6.Text = "2" Then
            winner()
        ElseIf game.kotak7.Text = "2" And game.kotak8.Text = "2" And game.kotak9.Text = "2" Then
            winner()
        ElseIf game.kotak1.Text = "2" And game.kotak4.Text = "2" And game.kotak7.Text = "2" Then
            winner()
        ElseIf game.kotak2.Text = "2" And game.kotak5.Text = "2" And game.kotak8.Text = "2" Then
            winner()
        ElseIf game.kotak3.Text = "2" And game.kotak6.Text = "2" And game.kotak9.Text = "2" Then
            winner()
        ElseIf game.kotak1.Text = "2" And game.kotak5.Text = "2" And game.kotak9.Text = "2" Then
            winner()
        ElseIf game.kotak3.Text = "2" And game.kotak5.Text = "2" And game.kotak7.Text = "2" Then
            winner()
        End If
    End Sub

    Public Sub winner()
        Dim menang
        If game.pemain1.Text = "1" Then
            menang = game.Label2.Text
        ElseIf game.pemain1.Text = "2" Then
            menang = game.Label3.Text
        End If

        MessageBox.Show("Selamat " & menang & " menang", "Menang")
        reset()
    End Sub

End Module
