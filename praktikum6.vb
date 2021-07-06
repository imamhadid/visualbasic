Public Class praktikum6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = TextBox1.Text
        Timer1.Enabled = True
        TextBox1.Text = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text > 0 Then
            Label1.Text = Label1.Text - 1
        Else
            Timer1.Enabled = False
            MessageBox.Show("Waktu Telah Habis")
        End If
    End Sub

    Private Sub praktikum6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = 0
        Height = 0
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = TimeOfDay
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Width < 500 Then
            If Height < 500 Then
                Height = Height + 1
                Width = Width + 1
            End If
        Else
            Timer3.Enabled = False
        End If
    End Sub
End Class