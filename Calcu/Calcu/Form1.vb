Public Class Calculator
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If monitor.Text = "0" Then
            monitor.Text = "1"
        Else
            monitor.Text = monitor.Text & "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If monitor.Text = "0" Then
            monitor.Text = "2"
        Else
            monitor.Text = monitor.Text & "2"
        End If
    End Sub
End Class
