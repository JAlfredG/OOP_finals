Public Class Form3

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If Double.TryParse(txbItemPrice.Text, Nothing) AndAlso Double.TryParse(txbItemQuantity.Text, Nothing) AndAlso Not String.IsNullOrWhiteSpace(txbItemName.Text) Then
            MessageBox.Show("Item Added.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txbItemName.Clear()
            txbItemPrice.Clear()
            txbItemQuantity.Clear()
        Else
            MessageBox.Show("Invalid Inputs.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnUpdatePrice_Click(sender As Object, e As EventArgs) Handles btnUpdatePrice.Click
        If Double.TryParse(txbItemPrice.Text, Nothing) AndAlso String.IsNullOrWhiteSpace(txbItemQuantity.Text) AndAlso Not String.IsNullOrWhiteSpace(txbItemName.Text) Then

            MessageBox.Show("Item Price Updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txbItemName.Clear()
            txbItemPrice.Clear()
            txbItemQuantity.Clear()

        Else
            MessageBox.Show("Invalid Inputs.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnUpdateQuantity_Click(sender As Object, e As EventArgs) Handles btnUpdateQuantity.Click
        If Double.TryParse(txbItemQuantity.Text, Nothing) AndAlso String.IsNullOrWhiteSpace(txbItemPrice.Text) AndAlso Not String.IsNullOrWhiteSpace(txbItemName.Text) Then

            MessageBox.Show("Item Quantity Updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txbItemName.Clear()
            txbItemPrice.Clear()
            txbItemQuantity.Clear()

        Else
            MessageBox.Show("Invalid Inputs.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If Not String.IsNullOrWhiteSpace(txbItemName.Text) AndAlso String.IsNullOrWhiteSpace(txbItemPrice.Text) AndAlso String.IsNullOrWhiteSpace(txbItemQuantity.Text) Then

            MessageBox.Show("Item Removed.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txbItemName.Clear()
            txbItemPrice.Clear()
            txbItemQuantity.Clear()

        Else
            MessageBox.Show("Invalid Inputs.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New Form2()
        dashboard.Show()

        Me.Hide()
    End Sub
End Class