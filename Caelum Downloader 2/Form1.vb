﻿Public Class Form1
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "your screwed"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            If ProgressBar2.Value < 100 Then
                Label1.Text = "Extracting..."
                Threading.Thread.Sleep(500)
                ProgressBar2.Increment(10)
            End If

        End If
        If ProgressBar2.Value = 100 Then
            Label1.Text = "Complete!"
        End If
    End Sub

    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs) Handles ProgressBar2.Click
        Form3.Show()
    End Sub

    Private Sub aboutbut_Click(sender As Object, e As EventArgs) Handles Aboutbut.Click
        If ProgressBar2.Value < 100 Then
            Aboutbut.Text = "No"
        End If
        If ProgressBar2.Value = 100 Then
            Aboutbut.Text = "About"
            AboutBox1.Show()
        End If
    End Sub

End Class
