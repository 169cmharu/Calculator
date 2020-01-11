Public Class Calculator
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If monitor.Text = "0" Then
            monitor.Text = "1"
        Else
            monitor.Text = monitor.Text & "1"
        End If
    End Sub
End Class
