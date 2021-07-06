Public Class game

    Private Sub game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = PictureBox10.Image
        kotak1.Text = pemain1.Text
        Label7.Show()
        Label7.Text = pemain.Text
        MerubahGiliran()
        PictureBox1.Enabled = False

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Image = PictureBox10.Image
        kotak2.Text = pemain1.Text
        Label8.Show()
        Label8.Text = pemain.Text
        MerubahGiliran()
        PictureBox2.Enabled = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.Image = PictureBox10.Image
        kotak3.Text = pemain1.Text
        Label9.Show()
        Label9.Text = pemain.Text
        MerubahGiliran()
        PictureBox3.Enabled = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox4.Image = PictureBox10.Image
        kotak4.Text = pemain1.Text
        Label10.Show()
        Label10.Text = pemain.Text
        MerubahGiliran()
        PictureBox4.Enabled = False
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox5.Image = PictureBox10.Image
        kotak5.Text = pemain1.Text
        Label11.Show()
        Label11.Text = pemain.Text
        MerubahGiliran()
        PictureBox5.Enabled = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox6.Image = PictureBox10.Image
        kotak6.Text = pemain1.Text
        Label12.Show()
        Label12.Text = pemain.Text
        MerubahGiliran()
        PictureBox6.Enabled = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox7.Image = PictureBox10.Image
        kotak7.Text = pemain1.Text
        Label13.Show()
        Label13.Text = pemain.Text
        MerubahGiliran()
        PictureBox7.Enabled = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox8.Image = PictureBox10.Image
        kotak8.Text = pemain1.Text
        Label14.Show()
        Label14.Text = pemain.Text
        MerubahGiliran()
        PictureBox8.Enabled = False
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        PictureBox9.Image = PictureBox10.Image
        kotak9.Text = pemain1.Text
        Label15.Show()
        Label15.Text = pemain.Text
        MerubahGiliran()
        PictureBox9.Enabled = False
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click

        Dim pesan = MessageBox.Show("Yakin Ingin Mengulang", "New Game", MessageBoxButtons.YesNo)
        If pesan = DialogResult.Yes Then
            reset()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Home.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub pemain_Click(sender As Object, e As EventArgs) Handles pemain.Click

    End Sub
End Class