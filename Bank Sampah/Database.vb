Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Public Class Database
    Public con As MySqlConnection
    Public cmd As MySqlCommand
    Public dtr As MySqlDataReader
    Protected mydatatable As DataTable
    Protected adapter As MySqlDataAdapter
    Protected Ds As DataSet
    Protected dtgrid As DataGridView

    Property DataSetName As String

    Property SchemaSerializationMode As SchemaSerializationMode


    Public Shared Function OpenDB() As MySqlConnection
        Dim kata As String
        Dim konek As MySqlConnection = Nothing
        Try
            kata = "server=localhost;user id=root;password=;database=bank_sampah"
            konek = New MySqlConnection(kata)
            If konek.State <> ConnectionState.Closed Then konek.Close()
            konek.Open()

        Catch ex As Exception
            MsgBox("Terjadi Error : " & ex.Message)
        End Try
        Return konek
    End Function


    Public Function BindingView(ByVal sql As String, ByVal dtgrid As DataGridView) As DataGridView
        OpenDB()
        cmd = New MySqlCommand(sql, OpenDB)
        adapter = New MySqlDataAdapter
        adapter.SelectCommand = cmd
        Dim Ds As New DataSet
        Dim table As New DataTable
        adapter.Fill(Ds)
        table = Ds.Tables(0)
        dtgrid.DataSource = Ds
        dtgrid.DataMember = table.ToString()
        Return dtgrid

        adapter = Nothing
        cmd = Nothing
        dtgrid = Nothing
    End Function

    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        OpenDB()
        cmd = New MySqlCommand(Query, OpenDB)
        adapter = New MySqlDataAdapter
        adapter.SelectCommand = cmd
        Ds = New DataSet
        adapter.Fill(Ds)
        mydatatable = Ds.Tables(0)
        Return mydatatable
        mydatatable = Nothing
        Ds = Nothing
        adapter = Nothing
        cmd = Nothing
    End Function


End Class

