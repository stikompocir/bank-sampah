﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Master
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CSV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Location = New System.Drawing.Point(3, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 81)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nasabah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CSV
        '
        Me.CSV.ActiveViewIndex = -1
        Me.CSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CSV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CSV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CSV.Location = New System.Drawing.Point(0, 100)
        Me.CSV.Name = "CSV"
        Me.CSV.Size = New System.Drawing.Size(657, 281)
        Me.CSV.TabIndex = 1
        Me.CSV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Laporan_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 381)
        Me.Controls.Add(Me.CSV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Laporan_Master"
        Me.Text = "Laporan_Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CSV As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
