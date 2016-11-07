Imports MySql.Data.MySqlClient

Public Class Penjualan
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

    Sub FakturOtomatis()
        Call Koneksi()
        myCommand = New MySqlCommand("select no_transaksi from setor_pengepul order by no_transaksi DESC", conn)
        myReader = myCommand.ExecuteReader
        myReader.Read()
        If Not myReader.HasRows Then
            LblFaktur.Text = Format(Today, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(myReader.Item("no_transaksi"), 6) = Format(Today, "yyMMdd") Then
                LblFaktur.Text = myReader.Item("no_transaksi") + 1
            Else
                LblFaktur.Text = Format(Today, "yyMMdd") + "0001"
            End If
        End If
        conn.Close()
    End Sub

    Sub Bersihkan()
        TextId.Clear()
        TextNama.Clear()
        LblFaktur.Text = ""
        LblTanggal.Text = ""
        LabelJumlah.Text = ""
        LabelTotal.Text = ""
        TextId.Focus()
        DGV.Rows.Clear()
    End Sub
    Private Sub Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        FakturOtomatis()
        LblTanggal.Text = Format(Today, "yyMMdd")
    End Sub

    Sub HitungHarga()
        Dim Hitung As Integer
        For Baris As Integer = 0 To DGV.RowCount - 1
            Try
                Hitung = Hitung + DGV.Rows(Baris).Cells(4).Value
            Catch ex As Exception
                'MsgBox(ex.Message)
                SendKeys.Send("{UP}")
                DGV.Rows(Baris).Cells(3).Value = 0
            End Try

        Next
        LabelTotal.Text = Hitung
    End Sub

    Sub HitungBanyakSampah()
        Dim Hitung As Double
        For baris As Integer = 0 To DGV.RowCount - 1
            Try
                Hitung = Hitung + DGV.Rows(baris).Cells(3).Value
            Catch ex As Exception
                'MsgBox(ex.Message)
                SendKeys.Send("{UP}")
                DGV.Rows(baris).Cells(4).Value = 0
            End Try

        Next
        LabelJumlah.Text = Hitung
    End Sub


    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If e.ColumnIndex = 0 Then
            For barisAtas As Integer = 0 To DGV.RowCount - 1
                For barisBAwah As Integer = barisAtas + 1 To DGV.RowCount - 1
                    If DGV.Rows(barisBAwah).Cells(0).Value = DGV.Rows(barisAtas).Cells(0).Value Then
                        'MsgBox("kode ini sudah di entri")
                        DGV.Rows(barisAtas).Cells(3).Value = DGV.Rows(barisAtas).Cells(3).Value + 1
                        SendKeys.Send("{UP}")
                        DGV.Rows(barisBAwah).Cells(0).Value = ""
                        DGV.Rows(barisAtas).Cells(3).Value = DGV.Rows(barisAtas).Cells(3).Value * DGV.Rows(barisAtas).Cells(4).Value
                        Call HitungBanyakSampah()
                        Call HitungHarga()
                        Exit Sub
                    End If
                Next
            Next
            Call Koneksi()
            Dim sql As String
            sql = "select * from sampah where id_sampah = '" & DGV.Rows(e.RowIndex).Cells(0).Value & "'"
            myCommand = New MySqlCommand(sql, conn)
            myReader = myCommand.ExecuteReader
            myReader.Read()
            If myReader.HasRows Then
                DGV.Rows(e.RowIndex).Cells(1).Value = myReader.Item("nama_sampah")
                DGV.Rows(e.RowIndex).Cells(2).Value = myReader.Item("harga_beli")
                'ASUMSI PENERIMAAN = 0
                DGV.Rows(e.RowIndex).Cells(3).Value = 0
                DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
            Else
                'MsgBox("kode tidak terdaftar")
                SendKeys.Send("{UP}")
                DGV.Rows(e.RowIndex).Cells(0).Value = " "

            End If
        End If
        If e.ColumnIndex = 3 Then
            Try
                DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
            Catch ex As Exception
                MsgBox("Harus angka")
                SendKeys.Send("{UP}")
                DGV.Rows(e.RowIndex).Cells(3).Value = 0
                DGV.Rows(e.RowIndex).Cells(4).Value = DGV.Rows(e.RowIndex).Cells(2).Value * DGV.Rows(e.RowIndex).Cells(3).Value
            End Try

        End If

        DGV.Columns(2).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(3).DefaultCellStyle.Format = "###,###,###"
        DGV.Columns(4).DefaultCellStyle.Format = "###,###,###"

        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        HitungBanyakSampah()
        HitungHarga()
    End Sub

    Sub IsiNama()
        Try
            Call Koneksi()
            Dim sql As String
            sql = "select * from pengepul where id_pengepul = '" & TextId.Text & "'"
            myCommand = New MySqlCommand(sql, conn)
            myReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                TextNama.Text = myReader.Item("nama_pengepul")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextId.KeyPress
        If e.KeyChar = Chr(13) Then
            Call IsiNama()
            TextNama.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Bersihkan()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub DGV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(27) Then
            DGV.Rows.Remove(DGV.CurrentRow)
            Call HitungBanyakSampah()
            Call HitungHarga()
        End If

        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub TextNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextNama.KeyPress
        If e.KeyChar = Chr(13) Then
            DGV.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Koneksi()
        If TextId.Text = "" Then
            MsgBox("Data belum lengkap")
        End If
        Dim setoran As String
        setoran = "insert into setor_pengepul values ('" & LblFaktur.Text & "','" & LblTanggal.Text & "','" & TextId.Text & "','" & Form1.panel1.Text & "','" & LabelJumlah.Text & "','" & LabelTotal.Text & "')"
        myCommand = New MySqlCommand(setoran, conn)
        myCommand.ExecuteNonQuery()

        For baris As Integer = 0 To DGV.RowCount - 2
            Call Koneksi()
            Dim simpandetail As String

            simpandetail = "insert into detail_beli values ('" & LblFaktur.Text & "','" & DGV.Rows(baris).Cells(0).Value & "'," & DGV.Rows(baris).Cells(2).Value & "," & DGV.Rows(baris).Cells(3).Value & "," & DGV.Rows(baris).Cells(4).Value & ")"
            myCommand = New MySqlCommand(simpandetail, conn)
            myCommand.ExecuteNonQuery()

            myCommand = New MySqlCommand("select * from sampah where id_sampah = '" & DGV.Rows(baris).Cells(0).Value & "'", conn)
            myReader = myCommand.ExecuteReader
            myReader.Read()
            If myReader.HasRows Then
                Call Koneksi()
                Dim kurangiStok As String
                kurangiStok = "update sampah set stok = " & myReader.Item("stok") - DGV.Rows(baris).Cells(3).Value & " where id_sampah = '" & DGV.Rows(baris).Cells(0).Value & "'"
                myCommand = New MySqlCommand(kurangiStok, conn)
                myCommand.ExecuteReader()
            End If
        Next
        Call Bersihkan()
        Call FakturOtomatis()
        LblTanggal.Text = Today
    End Sub
End Class