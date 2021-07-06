Public Class vlokal
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim tutup As String
        tutup = MessageBox.Show("Anda Yakin ingin menutup ini?", "Lokal Variabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
        Else

        End If
    End Sub
End Class