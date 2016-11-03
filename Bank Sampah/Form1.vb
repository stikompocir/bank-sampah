Public Class Form1

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        'Masuk.MdiParent = Me
        Masuk.Show()
        Masuk.BringToFront()
        Masuk.Focus()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("yakin mau logout ?", "Konfirmasi",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            MenuToolStripMenuItem.Enabled = False
            LogoutToolStripMenuItem.Enabled = False
            LoginToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        MasterNasabah.Show()
        MasterNasabah.BringToFront()

    End Sub
End Class
