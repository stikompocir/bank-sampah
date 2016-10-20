Imports System.Data
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient


Module ModulKoneksi
    Public konek As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Public DR As OdbcDataReader
    Public cmd As OdbcCommand

    Sub bukaDB()
        Try
            konek = New OdbcConnection("DSN=dblatihan; MultipleActiveResultSets=True")
            If konek.State = ConnectionState.Closed Then
                konek.Open()
            End If
        Catch ex As Exception
            MsgBox("Konek ke database bermasalah, silahkan periksa koneksi anda")
        End Try
    End Sub



End Module
