Public Class Data
    Inherits Database
    Public Sub DataGrid_nasabah(ByVal sql As String, ByVal dtgrid As DataGridView)
        dtgrid.Columns(0).HeaderText = "id_nasabah "
        dtgrid.Columns(1).HeaderText = "nama_nasabah"
        dtgrid.Columns(2).HeaderText = "alamat_nasabah"
        dtgrid.Columns(3).HeaderText = "saldo"
        dtgrid.Columns(4).HeaderText = "no_telpon"
        dtgrid.Columns(5).HeaderText = "status"

        dtgrid.ReadOnly = True
        dtgrid.Columns(0).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        dtgrid.Columns(1).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        dtgrid.Columns(2).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        dtgrid.Columns(3).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        dtgrid.Columns(4).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        dtgrid.Columns(5).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        dtgrid.Columns(5).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Public Sub DataGrid_LstSampah(ByVal sql As String, ByVal dtgrid As DataGridView)
        dtgrid.Columns(0).HeaderText = "id_sampah"
        dtgrid.Columns(1).HeaderText = "id_jenis_sampah"
        dtgrid.Columns(2).HeaderText = "nama_sampah"
        dtgrid.Columns(3).HeaderText = "harga_setor"
        dtgrid.Columns(4).HeaderText = "harga_jual"
        dtgrid.Columns(5).HeaderText = "stok"

        dtgrid.ReadOnly = True
        dtgrid.Columns(0).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        dtgrid.Columns(1).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        dtgrid.Columns(2).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        dtgrid.Columns(3).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        dtgrid.Columns(4).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        dtgrid.Columns(5).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        dtgrid.Columns(5).AutoSizeMode = Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    End Sub
End Class
