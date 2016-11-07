Imports MySql.Data.MySqlClient

Public Class Pengambilan

    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myReader As MySqlDataReader
    Dim table As DataTable

    Sub Koneksi()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root; database=bank_sampah"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("kesalahan koneksi")
        End Try
    End Sub

    Sub Kosongkan()
        ComboBox1.Text = ""
        LblSaldo.Text = ""
        TxtJumlah.Clear()
        LblNama.Text = ""
        ComboBox1.Focus()
    End Sub

    Sub TampilGrid()
        Koneksi()
        Try
            myAdapter = New MySqlDataAdapter("select * from pengambilan", conn)
            DS = New DataSet
            DS.Clear()
            myAdapter.Fill(DS, "pengambilan")
            table = DS.Tables("pengambilan")
            DGV.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub TampilAnggota()
        Try
            Koneksi()
            myCommand = New MySqlCommand("select * from nasabah", conn)
            myReader = myCommand.ExecuteReader
            Do While myReader.Read
                ComboBox1.Items.Add(myReader.Item(0))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Otomatis()
        Call Koneksi()
        myCommand = New MySqlCommand("select * from pengambilan where id_pengambilan in (select max(ID_Pengambilan) from Pengambilan) order by ID_Pengambilan desc", conn)
        Dim urutan As String
        Dim hitung As Long
        myReader = myCommand.ExecuteReader
        myReader.Read()
        If Not myReader.HasRows Then
            urutan = "ABL" + Format(Today, "yyMMdd") + "001"
        Else
            If Microsoft.VisualBasic.Mid(myReader.GetString(0), 4, 6) <> Format(Now, "yyMMdd") Then
                urutan = "ABL" + Format(Now, "yyMMdd") + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(myReader.GetString(0), 9) + 1
                urutan = "ABL" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
        End If
        LblNomor.Text = urutan
    End Sub

    Private Sub Pengambilan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Otomatis()
        LblTanggal.Text = Format(Today, "yyMMdd")
    End Sub

    Private Sub Pengambilan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Call Kosongkan()
        End Select
    End Sub

    Private Sub Pengambilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call Kosongkan()
        TampilAnggota()
    End Sub


    Private Sub BTNBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBatal.Click
        Call Kosongkan()
    End Sub

    Private Sub BTNTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub

    Private Sub BTNSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSimpan.Click
        Koneksi()
        If ComboBox1.Text = "" Or TxtJumlah.Text = "" Then
            MsgBox("Data Belum lengkap")
            Exit Sub
        Else
            'Simpan ke table pinjam
            Dim simpan As String
            simpan = "insert into pengambilan values ('" & LblNomor.Text & "'," & LblTanggal.Text & ",'" & ComboBox1.Text & "'," & TxtJumlah.Text & ",'" & Form1.panel1.Text & "')"
            myCommand = New MySqlCommand(simpan, conn)
            myCommand.ExecuteNonQuery()

            'Kurangi saldo nasabah dengan pengambilan yang baru saja dilakukan
            myCommand = New MySqlCommand("select * from nasabah where id_nasabah = '" & ComboBox1.Text & "'", conn)
            myReader = myCommand.ExecuteReader
            myReader.Read()
            If myReader.HasRows Then
                Call Koneksi()
                Dim editSaldo As String = "update nasabah set saldo ='" & Val(LblSaldo.Text) - Val(TxtJumlah.Text) & "' where id_nasabah ='" & ComboBox1.Text & "'"
                myCommand = New MySqlCommand(editSaldo, conn)
                myCommand.ExecuteReader()
            End If
            Otomatis()
            TampilGrid()
            TampilAnggota()
        End If
    End Sub

    Private Sub TxtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TxtJumlah.Text) < Val(LblSaldo.Text) Then
                MsgBox("Saldo anda " & LblSaldo.Text)
                TxtJumlah.Clear()
            Else
                BTNSimpan.Focus()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Koneksi()
        myCommand = New MySqlCommand("select * from nasabah where id_nasabah ='" & ComboBox1.Text & "'", conn)
        myReader = myCommand.ExecuteReader
        myReader.Read()
        If myReader.HasRows Then
            LblNama.Text = myReader.Item(1)
            LblSaldo.Text = myReader.Item(3)
        End If
    End Sub
End Class