Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click, BtnLogin.Enter


        If TxtPassword.Text = "" And TxtUserName.Text = "" Then
            MessageBox.Show("User name dan Password harus diisi", "Konfirmasi", MessageBoxButtons.OK,
           MessageBoxIcon.Question)
            TxtUserName.Focus()
        ElseIf TxtPassword.Text = "" Then
            MessageBox.Show("Password harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Question)
            TxtPassword.Focus()
        ElseIf TxtUserName.Text = "" Then
            MessageBox.Show("User name harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Question)
            TxtUserName.Focus()
        ElseIf TxtUserName.Text = "admin" And TxtPassword.Text = "admin" Then
            MessageBox.Show("Password dan User Name Benar", "Konfirmasi", MessageBoxButtons.OK,
           MessageBoxIcon.Question)
            Home.TextToolStripMenuItem.Text = TxtUserName.Text
            Hide()
            Home.Show()
        Else
            MessageBox.Show("Password dan User Name Anda Salah, ulangi lagi", "Konfirmasi", MessageBoxButtons.OK,
           MessageBoxIcon.Question)
            TxtUserName.Text = ""
            TxtUserName.Text = ""
            TxtUserName.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Home.TextToolStripMenuItem.Text = "Guest"
        MessageBox.Show("Limited Access", "Guest Role", MessageBoxButtons.OK)
        Home.Show()
    End Sub
End Class