Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AboutBox1.Show()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text() = "fagget" Then
            Label1.Text = "nigger"
        End If
    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/u/17161880/1Y02052.JPG", "C:\cancer\cancer.jpg")
        Downdone.Text = "Done"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FolderBrowserDialog1.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Text = FolderBrowserDialog1.SelectedPath()
        My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/u/17161880/1Y02052.JPG", FolderBrowserDialog1.SelectedPath() & "\cancer.jpg")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Network.DownloadFile("https://qtechofficial.com/cancer.txt", FolderBrowserDialog1.SelectedPath() & "\cancer.txt")
    End Sub
End Class