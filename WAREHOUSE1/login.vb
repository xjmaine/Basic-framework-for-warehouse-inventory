Public Class log_in


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            dashBoard.Show()
            Me.Hide()
        Else
            MsgBox("Username or password not found!", MsgBoxStyle.OkOnly, "Log In Error")

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
