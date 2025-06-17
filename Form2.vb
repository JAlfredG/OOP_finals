Public Class Form2
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim dashboard As New Form1()
        dashboard.Show()

        Me.Hide()
    End Sub

    Private Sub btnShowInventory_Click(sender As Object, e As EventArgs) Handles btnShowInventory.Click
        rtxbMainView.Text = "**Displaying Inventory**"
    End Sub

    Private Sub btnShowWeekly_Click(sender As Object, e As EventArgs) Handles btnShowWeekly.Click
        rtxbMainView.Text = "**Displaying Weekly Report**"
    End Sub

    Private Sub btnShowSales_Click(sender As Object, e As EventArgs) Handles btnShowSales.Click
        rtxbMainView.Text = "**Displaying Sales Report**"
    End Sub

    Private Sub btnUpdateInv_Click(sender As Object, e As EventArgs) Handles btnUpdateInv.Click
        Dim dashboard As New Form3()
        dashboard.Show()

        Me.Hide()
    End Sub

    Private Sub btnCreateWeekly_Click(sender As Object, e As EventArgs) Handles btnCreateWeekly.Click
        Dim dashboard As New Form4()
        dashboard.Show()

        Me.Hide()
    End Sub

    Private Sub btnCreateSales_Click(sender As Object, e As EventArgs) Handles btnCreateSales.Click
        Dim dashboard As New Form4()
        dashboard.Show()

        Me.Hide()
    End Sub
End Class