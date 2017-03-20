Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub OK_button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub JobInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobInformationToolStripMenuItem.Click
        Job_info.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Job_info.Show()
    End Sub
End Class
