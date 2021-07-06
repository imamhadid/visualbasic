Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nilai As Integer
        Dim grade As String
        nilai = TextBox1.Text


        If nilai < 50 Then
            grade = "E"
        ElseIf nilai <= 66 Then
            grade = "D"
        ElseIf nilai <= 76 Then
            grade = "C"
        ElseIf nilai <= 86 Then
            grade = "B"
        ElseIf nilai <= 100 Then
            grade = "A"
        Else
            MessageBox.Show("Data Tidak Diketahui")
        End If

        If nilai >= 65 And nilai <= 100 Then
            MessageBox.Show("Selamat Anda Lulus Dengan Grade : ", "Konfrimasi")
        ElseIf nilai < 65 Then
            MessageBox.Show("Maaf Nilai Anda Belum Memenuhi Dengan Grade : ", "Konfrimasi")
        End If

    End Sub
End Class