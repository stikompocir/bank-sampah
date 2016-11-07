<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengambilan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTNTutup = New System.Windows.Forms.Button()
        Me.BTNBatal = New System.Windows.Forms.Button()
        Me.BTNSimpan = New System.Windows.Forms.Button()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.LblNomor = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNTutup
        '
        Me.BTNTutup.Location = New System.Drawing.Point(414, 108)
        Me.BTNTutup.Name = "BTNTutup"
        Me.BTNTutup.Size = New System.Drawing.Size(65, 23)
        Me.BTNTutup.TabIndex = 31
        Me.BTNTutup.Text = "Tutup"
        Me.BTNTutup.UseVisualStyleBackColor = True
        '
        'BTNBatal
        '
        Me.BTNBatal.Location = New System.Drawing.Point(345, 108)
        Me.BTNBatal.Name = "BTNBatal"
        Me.BTNBatal.Size = New System.Drawing.Size(65, 23)
        Me.BTNBatal.TabIndex = 30
        Me.BTNBatal.Text = "Batal"
        Me.BTNBatal.UseVisualStyleBackColor = True
        '
        'BTNSimpan
        '
        Me.BTNSimpan.Location = New System.Drawing.Point(274, 108)
        Me.BTNSimpan.Name = "BTNSimpan"
        Me.BTNSimpan.Size = New System.Drawing.Size(65, 23)
        Me.BTNSimpan.TabIndex = 29
        Me.BTNSimpan.Text = "Simpan"
        Me.BTNSimpan.UseVisualStyleBackColor = True
        '
        'LblSaldo
        '
        Me.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSaldo.Location = New System.Drawing.Point(167, 85)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(100, 20)
        Me.LblSaldo.TabIndex = 28
        Me.LblSaldo.Text = "LblSaldo"
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(379, 85)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(100, 20)
        Me.TxtJumlah.TabIndex = 27
        Me.TxtJumlah.Text = "TxtJumlah"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(167, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 26
        '
        'LblNama
        '
        Me.LblNama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNama.Location = New System.Drawing.Point(273, 61)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(206, 20)
        Me.LblNama.TabIndex = 25
        Me.LblNama.Text = "LblNama"
        '
        'LblTanggal
        '
        Me.LblTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTanggal.Location = New System.Drawing.Point(379, 27)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(100, 20)
        Me.LblTanggal.TabIndex = 24
        Me.LblTanggal.Text = "LblTanggal"
        '
        'LblNomor
        '
        Me.LblNomor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNomor.Location = New System.Drawing.Point(167, 27)
        Me.LblNomor.Name = "LblNomor"
        Me.LblNomor.Size = New System.Drawing.Size(100, 20)
        Me.LblNomor.TabIndex = 23
        Me.LblNomor.Text = "LblNomor"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(273, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(273, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(61, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Saldo"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(61, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nomor Anggota"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(61, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nomor Transaksi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 209)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV.Location = New System.Drawing.Point(3, 19)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(533, 187)
        Me.DGV.TabIndex = 13
        '
        'Pengambilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 348)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNTutup)
        Me.Controls.Add(Me.BTNBatal)
        Me.Controls.Add(Me.BTNSimpan)
        Me.Controls.Add(Me.LblSaldo)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.LblNomor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "Pengambilan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengambilan"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNTutup As System.Windows.Forms.Button
    Friend WithEvents BTNBatal As System.Windows.Forms.Button
    Friend WithEvents BTNSimpan As System.Windows.Forms.Button
    Friend WithEvents LblSaldo As System.Windows.Forms.Label
    Friend WithEvents TxtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents LblTanggal As System.Windows.Forms.Label
    Friend WithEvents LblNomor As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
End Class
