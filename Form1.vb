Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Convert.ToBoolean(txbUsername.Text = "admin") AndAlso Convert.ToBoolean(txbPassword.Text = "admin") Then
            Dim dashboard As New Form2()
            dashboard.Show()

            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txbUsername.Clear()
            txbPassword.Clear()
        End If
    End Sub

    Private Sub txbUsername_TextChanged(sender As Object, e As EventArgs) Handles txbUsername.TextChanged

    End Sub
End Class
