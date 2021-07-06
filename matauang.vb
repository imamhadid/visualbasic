Public Class matauang
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Rp. " & TextBox1.Text * 144380, "USD to IDR Conversion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class