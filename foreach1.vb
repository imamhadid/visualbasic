Public Class foreach1
    Private Sub Proses_Click(sender As Object, e As EventArgs) Handles Proses.Click
        For Each ctrl In Controls
            ctrl.Text = "Tombol"
        Next
    End Sub
End Class