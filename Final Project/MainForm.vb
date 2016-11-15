Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Thank you for coming to Pateli's!")
        Close()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Dim input As String = Nothing
        input = InputBox("How many are in you party?", "Party Quantity", , , )
        MessageBox.Show("What can I get you started with?")
        MenuForm.ShowDialog()
    End Sub
End Class
