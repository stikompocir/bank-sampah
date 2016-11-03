<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master_Sampah
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIdSampah = New System.Windows.Forms.TextBox()
        Me.TxtNamaSampah = New System.Windows.Forms.TextBox()
        Me.CmbJenisSampah = New System.Windows.Forms.ComboBox()
        Me.TxtSetor = New System.Windows.Forms.TextBox()
        Me.TxtBeli = New System.Windows.Forms.TextBox()
        Me.LstSampah = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id sampah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Sampah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Sampah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(377, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Setor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(386, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga Beli"
        '
        'TxtIdSampah
        '
        Me.TxtIdSampah.Location = New System.Drawing.Point(127, 31)
        Me.TxtIdSampah.Multiline = True
        Me.TxtIdSampah.Name = "TxtIdSampah"
        Me.TxtIdSampah.Size = New System.Drawing.Size(201, 27)
        Me.TxtIdSampah.TabIndex = 6
        '
        'TxtNamaSampah
        '
        Me.TxtNamaSampah.Location = New System.Drawing.Point(127, 62)
        Me.TxtNamaSampah.Multiline = True
        Me.TxtNamaSampah.Name = "TxtNamaSampah"
        Me.TxtNamaSampah.Size = New System.Drawing.Size(201, 27)
        Me.TxtNamaSampah.TabIndex = 7
        '
        'CmbJenisSampah
        '
        Me.CmbJenisSampah.FormattingEnabled = True
        Me.CmbJenisSampah.Location = New System.Drawing.Point(127, 93)
        Me.CmbJenisSampah.Name = "CmbJenisSampah"
        Me.CmbJenisSampah.Size = New System.Drawing.Size(121, 21)
        Me.CmbJenisSampah.TabIndex = 8
        '
        'TxtSetor
        '
        Me.TxtSetor.Location = New System.Drawing.Point(475, 31)
        Me.TxtSetor.Multiline = True
        Me.TxtSetor.Name = "TxtSetor"
        Me.TxtSetor.Size = New System.Drawing.Size(201, 27)
        Me.TxtSetor.TabIndex = 10
        '
        'TxtBeli
        '
        Me.TxtBeli.Location = New System.Drawing.Point(475, 62)
        Me.TxtBeli.Multiline = True
        Me.TxtBeli.Name = "TxtBeli"
        Me.TxtBeli.Size = New System.Drawing.Size(201, 27)
        Me.TxtBeli.TabIndex = 11
        '
        'LstSampah
        '
        Me.LstSampah.Location = New System.Drawing.Point(1, 144)
        Me.LstSampah.Name = "LstSampah"
        Me.LstSampah.Size = New System.Drawing.Size(730, 219)
        Me.LstSampah.TabIndex = 12
        Me.LstSampah.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 33)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(231, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 33)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(333, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 33)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(435, 382)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 33)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(380, 110)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(201, 27)
        Me.TextBox4.TabIndex = 18
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(582, 110)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(94, 26)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Cari"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Master_Sampah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 430)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LstSampah)
        Me.Controls.Add(Me.TxtBeli)
        Me.Controls.Add(Me.TxtSetor)
        Me.Controls.Add(Me.CmbJenisSampah)
        Me.Controls.Add(Me.TxtNamaSampah)
        Me.Controls.Add(Me.TxtIdSampah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Master_Sampah"
        Me.Text = "Master_Sampah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtIdSampah As System.Windows.Forms.TextBox
    Friend WithEvents TxtNamaSampah As System.Windows.Forms.TextBox
    Friend WithEvents CmbJenisSampah As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSetor As System.Windows.Forms.TextBox
    Friend WithEvents TxtBeli As System.Windows.Forms.TextBox
    Friend WithEvents LstSampah As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
