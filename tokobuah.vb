Public Class tokobuah
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim jmljeruk, jmlapel As Integer
            Dim hrgjeruk, hrgapel As Integer
            Dim total As Integer

            jmljeruk = TextBox1.Text
            jmlapel = TextBox2.Text

            hrgjeruk = 15000
            hrgapel = 25000

            total = (jmljeruk * hrgjeruk) + (jmlapel * hrgapel)

            MessageBox.Show("total belanja: " & total, "total belanja")

        Catch ex As Exception
            MessageBox.Show("anda salah input")
            TextBox1.Text = ""
            TextBox2.Text = Nothing
        End Try
    End Sub
End Class