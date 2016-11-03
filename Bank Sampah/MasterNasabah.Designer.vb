<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterNasabah
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdNsb = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtAlmt = New System.Windows.Forms.TextBox()
        Me.TxtTelp = New System.Windows.Forms.TextBox()
        Me.DataSet1 = New Bank_Sampah.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lsnsb = New System.Windows.Forms.ListView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Nasabah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Nasabah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(193, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Telp"
        '
        'TxtIdNsb
        '
        Me.TxtIdNsb.Location = New System.Drawing.Point(261, 21)
        Me.TxtIdNsb.Multiline = True
        Me.TxtIdNsb.Name = "TxtIdNsb"
        Me.TxtIdNsb.Size = New System.Drawing.Size(181, 23)
        Me.TxtIdNsb.TabIndex = 4
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(261, 50)
        Me.TxtNama.Multiline = True
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(181, 23)
        Me.TxtNama.TabIndex = 5
        '
        'TxtAlmt
        '
        Me.TxtAlmt.Location = New System.Drawing.Point(261, 77)
        Me.TxtAlmt.Multiline = True
        Me.TxtAlmt.Name = "TxtAlmt"
        Me.TxtAlmt.Size = New System.Drawing.Size(181, 23)
        Me.TxtAlmt.TabIndex = 6
        '
        'TxtTelp
        '
        Me.TxtTelp.Location = New System.Drawing.Point(261, 106)
        Me.TxtTelp.Multiline = True
        Me.TxtTelp.Name = "TxtTelp"
        Me.TxtTelp.Size = New System.Drawing.Size(181, 23)
        Me.TxtTelp.TabIndex = 7
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 34)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 366)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 34)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Baru"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(304, 366)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 34)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(417, 366)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 34)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Ubah"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lsnsb
        '
        Me.lsnsb.Location = New System.Drawing.Point(-1, 143)
        Me.lsnsb.Name = "lsnsb"
        Me.lsnsb.Size = New System.Drawing.Size(702, 209)
        Me.lsnsb.TabIndex = 13
        Me.lsnsb.UseCompatibleStateImageBehavior = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(531, 366)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 34)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TxtStatus
        '
        Me.TxtStatus.Location = New System.Drawing.Point(469, 21)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(151, 20)
        Me.TxtStatus.TabIndex = 15
        '
        'MasterNasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 411)
        Me.Controls.Add(Me.TxtStatus)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lsnsb)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtTelp)
        Me.Controls.Add(Me.TxtAlmt)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtIdNsb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MasterNasabah"
        Me.Text = "MasterNasabah"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtIdNsb As System.Windows.Forms.TextBox
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlmt As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelp As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Bank_Sampah.DataSet1
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lsnsb As System.Windows.Forms.ListView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
End Class
