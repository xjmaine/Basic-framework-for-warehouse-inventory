Public Class dashBoard
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs)
        add.Show()
    End Sub

    Private Sub btnReleaseItem_Click(sender As Object, e As EventArgs)
        release.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        Me.Close()
        Dim shoLogin = New log_in
        shoLogin.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub picBoxAddItem_Click(sender As Object, e As EventArgs) Handles picBoxAddItem.Click
        add.Show()
    End Sub

    Private Sub picBoxExit_Click(sender As Object, e As EventArgs) Handles picBoxExit.Click
        Application.Exit()
    End Sub

    Private Sub picBoxLogout_Click(sender As Object, e As EventArgs) Handles picBoxLogout.Click
        Me.Close()
        Dim shoLogin = New log_in
        shoLogin.ShowDialog()
    End Sub

    Private Sub picBoxDispatch_Click(sender As Object, e As EventArgs) Handles picBoxDispatch.Click
        release.Show()
    End Sub

    Private Sub picBoxAddItem_MouseEnter(sender As Object, e As EventArgs) Handles picBoxAddItem.MouseEnter
        picBoxAddItem.BackColor = Color.Aqua
    End Sub

    Private Sub picBoxAddItem_MouseLeave(sender As Object, e As EventArgs) Handles picBoxAddItem.MouseLeave
        picBoxAddItem.BackColor = Color.Transparent
    End Sub

    Private Sub dashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = Date.Today
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class