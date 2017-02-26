Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "dev" Then
            Form2.Show()
        End If
        If TextBox1.Text = "about" Then
            AboutBox1.Show()
        End If
        If TextBox1.Text = "exit" Then
            Form1.Close()
        End If
        If TextBox1.Text = "close" Then
            Form1.Close()
        End If
        If TextBox1.Text = "help" Then
            TextBox2.Text = "Help: help"
        End If

    End Sub

End Class