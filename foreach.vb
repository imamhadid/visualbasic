Public Class foreach
    Private Sub proses_Click(sender As Object, e As EventArgs) Handles proses.Click
        For Each ctrl In Controls
            ctrl.Text = "Tombol"
        Next
    End Sub
End Class