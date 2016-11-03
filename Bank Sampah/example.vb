Imports MySql.Data.MySqlClient
Public Class example
    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myReader As MySqlDataReader
    Dim WithEvents daftar As koneksi
    Sub Koneksi()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root; database=bank_sampah"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("kesalahan koneksi")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If e.ColumnIndex = 0 Then
            Call Koneksi()
            Dim sql As String
            sql = "select * from sampah where id_sampah = '" & DGV.Rows(e.RowIndex).Cells(0).Value & "'"
            myCommand = New MySqlCommand(sql, conn)
            myReader = myCommand.ExecuteReader
            myReader.Read()
            If myReader.HasRows Then
                DGV.Rows(e.RowIndex).Cells(1).Value = myReader.Item("nama_sampah")
                DGV.Rows(e.RowIndex).Cells(2).Value = myReader.Item("harga_setor")
            End If
        End If
    End Sub
End Class