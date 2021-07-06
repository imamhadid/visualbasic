Public Class praktikum11db
    Private Sub praktikum11db_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Conn As OleDb.OleDbConnection
        Dim comm As OleDb.OleDbCommand
        Dim sql As String
        Dim ConnString As String
        Dim tampil As OleDb.OleDbDataAdapter
        Dim ds As DataSet = New DataSet
        ConnString = My.Settings.dbHadit1ConnectionString
        Conn = New OleDb.OleDbConnection(ConnString)
        sql = "select * from barang"
        Try
            Conn.Open()
            comm = New OleDb.OleDbCommand(sql, Conn)
            tampil = New OleDb.OleDbDataAdapter(comm)
            ds.Clear()
            tampil.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class