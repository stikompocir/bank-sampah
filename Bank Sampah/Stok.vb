Imports MySql.Data.MySqlClient


Public Class Stok

    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myReader As MySqlDataReader
    Dim ds As DataSet

    Sub Koneksi()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root; database=bank_sampah"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("kesalahan koneksi")
        End Try
    End Sub

    Private Sub Stok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilData()
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'Koneksi()
        If e.KeyChar = Chr(13) Then
            myAdapter = New MySqlDataAdapter("select id_sampah, nama_sampah, stok from sampah where nama_sampah like '%" & TextBox1.Text & "%'", conn)
            ds = New DataSet
            myAdapter.Fill(ds, "sampah")
            DataGridView1.DataSource = ds.Tables("sampah")
            DataGridView1.ReadOnly = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Sub TampilData()
        Koneksi()
        Dim ds As New DataSet
        myAdapter = New MySqlDataAdapter("select id_sampah, nama_sampah, stok from sampah order by 1", conn)
        ds = New DataSet
        ds.Clear()
        myAdapter.Fill(ds, "sampah")
        DataGridView1.DataSource = (ds.Tables("sampah"))
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class