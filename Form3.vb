Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tgl, bln, thn As Integer

        For thn = 1945 To 2021
            ListBox1.Items.Add(thn)
        Next

        bln = 1
        While bln <= 12
            ComboBox1.Items.Add(bln)
            bln = bln + 1
        End While

        For tgl = 1 To 31
            ListBox2.Items.Add(tgl)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bil1, bil2, hasil As Integer

        bil1 = InputBox("masukan perkalian berapa : ", "input", 0)

        ListBox3.Items.Clear()

        For bil2 = 1 To bil1
            hasil = bil1 * bil2
            ListBox3.Items.Add(bil1 & " x " & bil2 & " = " & hasil)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged



    End Sub
End Class