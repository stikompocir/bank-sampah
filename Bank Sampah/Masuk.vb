Imports MySql.Data.MySqlClient

Public Class Masuk
    'Dim conn As MySqlConnection
    'Dim myCommand As New MySqlCommand
    Dim WithEvents daftar As New koneksi

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim conn As MySqlConnection
        Dim myCommand As New MySqlCommand
        conn = New MySqlConnection
        'Mendefinisikan server
        conn.ConnectionString = "server=localhost;user id=root; database=bank_sampah"

        'mencoba masuk kedalam server
        'dan akan mengecek apakah nilai yang ada di dalam conn.ConnectionString = "server=localhost;user id=root; database=bank_sampah" Benar
        'jika benar, maka sistem akan masuk kedalam data base
        'jika salah, maka aplikasi akan memunculkan pesan "Kesalahan Koneksi"

        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("kesalahan koneksi")
        End Try
        Dim myAdapter As New MySqlDataAdapter
        Dim myReader As MySqlDataReader

        'sqlQuery akan mengambil nama_petugas dan password_petugas di dalam database pada tabel petugas
        Dim sqlquery = "SELECT * From petugas WHERE nama_petugas = '" + txtiduser.Text + "' AND password_petugas = '" + txtpass.Text + "'"
        myCommand.Connection = conn
        myCommand.CommandText = sqlquery

        myAdapter.SelectCommand = myCommand
        myReader = myCommand.ExecuteReader()
        myReader.Read()

        'Jika isi dalam database tidak ada atau kosong dan nilai yang ada di database
        'tidak sama dengan yang diketikan oleh user maka akses kedalam aplikasi tidak bisa dilanjutkan
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
            Me.Visible = False
            Form1.Show()
            Form1.panel1.Text = myReader.GetString(0)
            Form1.panel2.Text = myReader.GetString(1)
            Form1.panel3.Text = myReader.GetString(2)
        End If

        'Me.Visible = False
        
        conn.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Aplikasi akan keluar
        Me.Close()
    End Sub

    Private Sub txtiduser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtiduser.KeyPress
        'jika tombol enter di tekan pada txtiduser maka kursor akan otomatis
        'berpindah ke txtpassword
        If e.KeyChar = Chr(13) Then txtpass.Focus()
    End Sub

    Private Sub txtpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        'jika tombol enter di tekan pada txtpassword maka kursor akan otomatis
        'berpindah ke Tombol Login
        If e.KeyChar = Chr(13) Then
            btnLogin.Focus()
        End If
    End Sub
End Class