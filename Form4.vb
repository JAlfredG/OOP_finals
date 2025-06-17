Public Class Form4
    Private Sub btnBackButton_Click(sender As Object, e As EventArgs) Handles btnBackButton.Click
        Dim dashboard As New Form2()
        dashboard.Show()

        Me.Hide()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Not String.IsNullOrWhiteSpace(rtxbTextArea.Text) Then

            MessageBox.Show("Submitted.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            rtxbTextArea.Clear()

        Else
            MessageBox.Show("Input Report.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class