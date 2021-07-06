Public Class vglobal
    Dim tutup As String
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        tutup = MessageBox.Show("Anda Yakin ingin menutup ini?", "Global Variabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
        Else

        End If
    End Sub
End Class