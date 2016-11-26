<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DTP4 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DTP3 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Laporan_Harian1 = New Bank_Sampah.Laporan_Harian()
        Me.PengambilanTunai1 = New Bank_Sampah.PengambilanTunai()
        Me.CrystalReport11 = New Bank_Sampah.CrystalReport1()
        Me.Laporan_Periodik11 = New Bank_Sampah.Laporan_Periodik1()
        Me.CrystalReport21 = New Bank_Sampah.CrystalReport2()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.LaporanBulanan1 = New Bank_Sampah.LaporanBulanan()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button7)
        Me.GroupBox6.Controls.Add(Me.DTP4)
        Me.GroupBox6.Location = New System.Drawing.Point(515, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(129, 87)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Laporan Bulanan"
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button7.Location = New System.Drawing.Point(3, 61)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(123, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Tampil"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DTP4
        '
        Me.DTP4.CustomFormat = "MMMMM yyyy"
        Me.DTP4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP4.Location = New System.Drawing.Point(6, 17)
        Me.DTP4.Name = "DTP4"
        Me.DTP4.ShowUpDown = True
        Me.DTP4.Size = New System.Drawing.Size(120, 20)
        Me.DTP4.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.DTP3)
        Me.GroupBox5.Location = New System.Drawing.Point(284, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(113, 87)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Laporan Harian"
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button6.Location = New System.Drawing.Point(3, 61)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 23)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Tampil"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DTP3
        '
        Me.DTP3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP3.Location = New System.Drawing.Point(6, 17)
        Me.DTP3.Name = "DTP3"
        Me.DTP3.Size = New System.Drawing.Size(101, 20)
        Me.DTP3.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DTP2)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.DTP)
        Me.GroupBox4.Location = New System.Drawing.Point(400, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(113, 87)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Laporan Periodik"
        '
        'DTP2
        '
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP2.Location = New System.Drawing.Point(6, 38)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(101, 20)
        Me.DTP2.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button5.Location = New System.Drawing.Point(3, 61)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 23)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Tampil"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DTP
        '
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP.Location = New System.Drawing.Point(6, 17)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(101, 20)
        Me.DTP.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(184, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(94, 87)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pengambilan"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 62)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Tunai"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 87)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Master"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(87, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 62)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Stok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nasabah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = 0
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 121)
        Me.CRV.Name = "CRV"
        Me.CRV.ReportSource = Me.LaporanBulanan1
        Me.CRV.Size = New System.Drawing.Size(870, 362)
        Me.CRV.TabIndex = 1
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 483)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Laporan_Harian1 As Bank_Sampah.Laporan_Harian
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DTP3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Laporan_Periodik11 As Bank_Sampah.Laporan_Periodik1
    Friend WithEvents CrystalReport11 As Bank_Sampah.CrystalReport1
    Friend WithEvents CrystalReport21 As Bank_Sampah.CrystalReport2
    Friend WithEvents PengambilanTunai1 As Bank_Sampah.PengambilanTunai
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents DTP4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LaporanBulanan1 As Bank_Sampah.LaporanBulanan
End Class
