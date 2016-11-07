<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class example
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtIdSampah = New System.Windows.Forms.TextBox()
        Me.CmbJenisSampah = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode, Me.nama, Me.harga, Me.jumlah, Me.total})
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV.Location = New System.Drawing.Point(0, 138)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(767, 150)
        Me.DGV.TabIndex = 0
        '
        'kode
        '
        Me.kode.HeaderText = "id barang"
        Me.kode.Name = "kode"
        '
        'nama
        '
        Me.nama.HeaderText = "nama barang"
        Me.nama.Name = "nama"
        '
        'harga
        '
        Me.harga.HeaderText = "harga barang"
        Me.harga.Name = "harga"
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'total
        '
        Me.total.HeaderText = "total"
        Me.total.Name = "total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(446, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Buat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtIdSampah
        '
        Me.TxtIdSampah.Location = New System.Drawing.Point(213, 28)
        Me.TxtIdSampah.Name = "TxtIdSampah"
        Me.TxtIdSampah.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdSampah.TabIndex = 2
        Me.TxtIdSampah.Text = " "
        '
        'CmbJenisSampah
        '
        Me.CmbJenisSampah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbJenisSampah.FormattingEnabled = True
        Me.CmbJenisSampah.Items.AddRange(New Object() {"Kertas", "Plastik", "Besi", "Alumunium", "Kaleng"})
        Me.CmbJenisSampah.Location = New System.Drawing.Point(319, 27)
        Me.CmbJenisSampah.Name = "CmbJenisSampah"
        Me.CmbJenisSampah.Size = New System.Drawing.Size(121, 21)
        Me.CmbJenisSampah.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(446, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Lagi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DGV2
        '
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(213, 55)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.Size = New System.Drawing.Size(227, 77)
        Me.DGV2.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(446, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(302, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Jenis Sampah"
        '
        'example
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 288)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CmbJenisSampah)
        Me.Controls.Add(Me.TxtIdSampah)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "example"
        Me.Text = "example"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtIdSampah As System.Windows.Forms.TextBox
    Friend WithEvents CmbJenisSampah As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
