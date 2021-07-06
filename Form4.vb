Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If TextBox1.Text = "" Then
            MessageBox.Show("Silahkan isi semua data yang ada", "Pesan", MessageBoxButtons.OK)
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Silahkan isi semua data yang ada", "Pesan", MessageBoxButtons.OK)
        ElseIf ComboBox1.Text = "" Then
            MessageBox.Show("Silahkan isi semua data yang ada", "Pesan", MessageBoxButtons.OK)
        ElseIf ComboBox2.Text = "" Then
            MessageBox.Show("Silahkan isi semua data yang ada", "Pesan", MessageBoxButtons.OK)
        Else

            game.Show()

            game.kotak1.Text = "0"
            game.kotak2.Text = "0"
            game.kotak3.Text = "0"
            game.kotak4.Text = "0"
            game.kotak5.Text = "0"
            game.kotak6.Text = "0"
            game.kotak7.Text = "0"
            game.kotak8.Text = "0"
            game.kotak9.Text = "0"



            game.PictureBox1.Enabled = True
            game.PictureBox2.Enabled = True
            game.PictureBox3.Enabled = True
            game.PictureBox4.Enabled = True
            game.PictureBox5.Enabled = True
            game.PictureBox6.Enabled = True
            game.PictureBox7.Enabled = True
            game.PictureBox8.Enabled = True
            game.PictureBox9.Enabled = True


            MerubahGiliran()

            game.PictureBox1.Image = Image.FromFile("img\W.png")
            game.PictureBox2.Image = Image.FromFile("img\W.png")
            game.PictureBox3.Image = Image.FromFile("img\W.png")
            game.PictureBox4.Image = Image.FromFile("img\W.png")
            game.PictureBox5.Image = Image.FromFile("img\W.png")
            game.PictureBox6.Image = Image.FromFile("img\W.png")
            game.PictureBox7.Image = Image.FromFile("img\W.png")
            game.PictureBox8.Image = Image.FromFile("img\W.png")
            game.PictureBox9.Image = Image.FromFile("img\W.png")

            Me.Hide()

            game.Label7.Hide()
            game.Label8.Hide()
            game.Label9.Hide()
            game.Label10.Hide()
            game.Label11.Hide()
            game.Label12.Hide()
            game.Label13.Hide()
            game.Label14.Hide()
            game.Label15.Hide()

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        game.Label2.Text = TextBox1.Text

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        game.Label3.Text = TextBox2.Text

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Si Tuti")
        ComboBox1.Items.Add("Risa")
        ComboBox1.Items.Add("Si Juki")
        ComboBox1.Items.Add("Si Itek")
        ComboBox1.Items.Add("Si Ghosty")
        ComboBox1.Items.Add("Tahilalats")
        ComboBox1.Items.Add("Tom")
        ComboBox1.Items.Add("Jerry")
        ComboBox1.Items.Add("Spongebob")
        ComboBox1.Items.Add("Patrick")
        ComboBox1.Items.Add("Sendy")

        ComboBox2.Items.Add("Si Tuti")
        ComboBox2.Items.Add("Risa")
        ComboBox2.Items.Add("Si Juki")
        ComboBox2.Items.Add("Si Itek")
        ComboBox2.Items.Add("Si Ghosty")
        ComboBox2.Items.Add("Tahilalats")
        ComboBox2.Items.Add("Tom")
        ComboBox2.Items.Add("Jerry")
        ComboBox2.Items.Add("Spongebob")
        ComboBox2.Items.Add("Patrick")
        ComboBox2.Items.Add("Sendy")


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedIndex = 0 Then
            PictureBox1.Image = Image.FromFile("img\tuti.png")
        ElseIf ComboBox1.SelectedIndex = 1 Then
            PictureBox1.Image = Image.FromFile("img\risa.jpg")
        ElseIf ComboBox1.SelectedIndex = 2 Then
            PictureBox1.Image = Image.FromFile("img\juki.png")
        ElseIf ComboBox1.SelectedIndex = 3 Then
            PictureBox1.Image = Image.FromFile("img\itek.png")
        ElseIf ComboBox1.SelectedIndex = 4 Then
            PictureBox1.Image = Image.FromFile("img\ghosty.png")
        ElseIf ComboBox1.SelectedIndex = 5 Then
            PictureBox1.Image = Image.FromFile("img\tahilalats.png")
        ElseIf ComboBox1.SelectedIndex = 6 Then
            PictureBox1.Image = Image.FromFile("img\tom.png")
        ElseIf ComboBox1.SelectedIndex = 7 Then
            PictureBox1.Image = Image.FromFile("img\jery.png")
        ElseIf ComboBox1.SelectedIndex = 8 Then
            PictureBox1.Image = Image.FromFile("img\spongebob.png")
        ElseIf ComboBox1.SelectedIndex = 9 Then
            PictureBox1.Image = Image.FromFile("img\patrik.png")
        ElseIf ComboBox1.SelectedIndex = 10 Then
            PictureBox1.Image = Image.FromFile("img\sendi.png")
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox2.SelectedIndex = 0 Then
            PictureBox2.Image = Image.FromFile("img\tuti.png")
        ElseIf ComboBox2.SelectedIndex = 1 Then
            PictureBox2.Image = Image.FromFile("img\risa.jpg")
        ElseIf ComboBox2.SelectedIndex = 2 Then
            PictureBox2.Image = Image.FromFile("img\juki.png")
        ElseIf ComboBox1.SelectedIndex = 3 Then
            PictureBox2.Image = Image.FromFile("img\itek.png")
        ElseIf ComboBox2.SelectedIndex = 4 Then
            PictureBox2.Image = Image.FromFile("img\ghosty.png")
        ElseIf ComboBox2.SelectedIndex = 5 Then
            PictureBox2.Image = Image.FromFile("img\tahilalats.png")
        ElseIf ComboBox2.SelectedIndex = 6 Then
            PictureBox2.Image = Image.FromFile("img\tom.png")
        ElseIf ComboBox2.SelectedIndex = 7 Then
            PictureBox2.Image = Image.FromFile("img\jery.png")
        ElseIf ComboBox2.SelectedIndex = 8 Then
            PictureBox2.Image = Image.FromFile("img\spongebob.png")
        ElseIf ComboBox2.SelectedIndex = 9 Then
            PictureBox2.Image = Image.FromFile("img\patrik.png")
        ElseIf ComboBox2.SelectedIndex = 10 Then
            PictureBox2.Image = Image.FromFile("img\sendi.png")
        End If

    End Sub
End Class