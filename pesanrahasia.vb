Public Class pesanrahasia

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.DirectoryExists("Resource") Then
        Else
            MkDir("Resource")
        End If

        SaveFileDialog1.FileName = "Pesan"
        SaveFileDialog1.Filter = "Txt File|*.txt|Lord File|*.lord;*.king|Semua File|*.*"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isipesan As New System.IO.StreamWriter(SaveFileDialog1.FileName)
            isipesan.WriteLine(TextBox1.Text)
            isipesan.Close()
            MessageBox.Show("Pesan Berhasil Disimpan", "Konfirmasi")
            TextBox1.Text = Nothing
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim isipesan As New System.IO.StreamReader(SaveFileDialog1.FileName)
            TextBox1.Text = isipesan.ReadToEnd
            isipesan.Close()
        Catch ex As Exception
            MessageBox.Show("File Gagal Dibuka", "Konfirmasi")
        End Try

    End Sub
End Class