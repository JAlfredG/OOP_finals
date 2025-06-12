Public Class Form2
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim dashboard As New Form1()
        dashboard.Show()

        Me.Hide()
    End Sub
End Class