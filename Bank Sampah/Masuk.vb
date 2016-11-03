Imports MySql.Data.MySqlClient

Public Class Masuk
    'Dim conn As MySqlConnection
    'Dim myCommand As New MySqlCommand
    Dim WithEvents daftar As New koneksi

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim conn As MySqlConnection
        Dim myCommand As New MySqlCommand

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root; database=bank_sampah"

        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("kesalahan koneksi")
        End Try

        Dim myAdapter As New MySqlDataAdapter
        Dim myReader As MySqlDataReader
        Dim sqlquery = "SELECT * From petugas WHERE nama_petugas = '" + txtiduser.Text + "' AND password_petugas = '" + txtpass.Text + "'"
        myCommand.Connection = conn
        myCommand.CommandText = sqlquery

        myAdapter.SelectCommand = myCommand
        myReader = myCommand.ExecuteReader()

        If myReader.HasRows = 0 Then
            MsgBox("silahkan coba kembali", MsgBoxStyle.Exclamation, "Error Login")
            txtiduser.Text = ""
            txtpass.Text = ""
            txtiduser.Focus()
        Else
            MsgBox("welcome ^.^" & " " & txtiduser.Text & "!", MsgBoxStyle.Information, "Succesful Login")
            txtiduser.Text = ""
            txtpass.Text = ""
            txtiduser.Focus()


            Form1.MenuToolStripMenuItem.Enabled = True
            Form1.LoginToolStripMenuItem.Enabled = False
            Form1.LogoutToolStripMenuItem.Enabled = True
            Me.Close()
        End If

        conn.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Masuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class