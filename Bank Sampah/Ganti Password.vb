Imports MySql.Data.MySqlClient

Public Class Ganti_Password

    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myReader As MySqlDataReader

    Sub Koneksi()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root; database=bank_sampah"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("kesalahan koneksi")
        End Try
    End Sub

    Private Sub Ganti_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Koneksi()
            myCommand = New MySqlCommand("select * from petugas where nama_petugas ='" & TextBox1.Text & "'and password_petugas='" & TextBox2.Text & "'", conn)
            myReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                TextBox3.Enabled = True
                TextBox3.Focus()
            Else
                MsgBox("Password lama salah")
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox3.Text = "" Then
                MsgBox("Passwrod baru wajib diisi")
                TextBox3.Focus()
            Else
                TextBox4.Enabled = True
                TextBox4.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox4.Text <> TextBox3.Text Then
                MsgBox("Password konfirmasi salah")
                TextBox4.Focus()
            Else
                If MessageBox.Show("Yakin akan ganti password..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim ganti As String = "Update petugas set password_petugas='" & TextBox3.Text & "' where nama_petugas='" & TextBox1.Text & "' and id_petugas='" & Form1.panel1.Text & "'"
                    myCommand = New MySqlCommand(ganti, conn)
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    Me.Close()
                Else
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class