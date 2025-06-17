<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txbItemName = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblItemPrice = New System.Windows.Forms.Label()
        Me.txbItemPrice = New System.Windows.Forms.TextBox()
        Me.lblItemQuantity = New System.Windows.Forms.Label()
        Me.txbItemQuantity = New System.Windows.Forms.TextBox()
        Me.btnUpdatePrice = New System.Windows.Forms.Button()
        Me.btnUpdateQuantity = New System.Windows.Forms.Button()
        Me.btnBackButton = New System.Windows.Forms.Button()
        Me.lblUpdateInventory = New System.Windows.Forms.Label()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txbItemName
        '
        Me.txbItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbItemName.Location = New System.Drawing.Point(24, 79)
        Me.txbItemName.Name = "txbItemName"
        Me.txbItemName.Size = New System.Drawing.Size(353, 30)
        Me.txbItemName.TabIndex = 0
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(422, 70)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(108, 53)
        Me.btnAddItem.TabIndex = 1
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(25, 112)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(90, 20)
        Me.lblItemName.TabIndex = 4
        Me.lblItemName.Text = "Item Name"
        '
        'lblItemPrice
        '
        Me.lblItemPrice.AutoSize = True
        Me.lblItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.Location = New System.Drawing.Point(25, 209)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(85, 20)
        Me.lblItemPrice.TabIndex = 6
        Me.lblItemPrice.Text = "Item Price"
        '
        'txbItemPrice
        '
        Me.txbItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbItemPrice.Location = New System.Drawing.Point(24, 176)
        Me.txbItemPrice.Name = "txbItemPrice"
        Me.txbItemPrice.Size = New System.Drawing.Size(353, 30)
        Me.txbItemPrice.TabIndex = 5
        '
        'lblItemQuantity
        '
        Me.lblItemQuantity.AutoSize = True
        Me.lblItemQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemQuantity.Location = New System.Drawing.Point(25, 304)
        Me.lblItemQuantity.Name = "lblItemQuantity"
        Me.lblItemQuantity.Size = New System.Drawing.Size(108, 20)
        Me.lblItemQuantity.TabIndex = 8
        Me.lblItemQuantity.Text = "Item Quantity"
        '
        'txbItemQuantity
        '
        Me.txbItemQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbItemQuantity.Location = New System.Drawing.Point(24, 271)
        Me.txbItemQuantity.Name = "txbItemQuantity"
        Me.txbItemQuantity.Size = New System.Drawing.Size(353, 30)
        Me.txbItemQuantity.TabIndex = 7
        '
        'btnUpdatePrice
        '
        Me.btnUpdatePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePrice.Location = New System.Drawing.Point(422, 138)
        Me.btnUpdatePrice.Name = "btnUpdatePrice"
        Me.btnUpdatePrice.Size = New System.Drawing.Size(108, 53)
        Me.btnUpdatePrice.TabIndex = 10
        Me.btnUpdatePrice.Text = "Update Price"
        Me.btnUpdatePrice.UseVisualStyleBackColor = True
        '
        'btnUpdateQuantity
        '
        Me.btnUpdateQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateQuantity.Location = New System.Drawing.Point(422, 203)
        Me.btnUpdateQuantity.Name = "btnUpdateQuantity"
        Me.btnUpdateQuantity.Size = New System.Drawing.Size(108, 53)
        Me.btnUpdateQuantity.TabIndex = 13
        Me.btnUpdateQuantity.Text = "Update Quantity"
        Me.btnUpdateQuantity.UseVisualStyleBackColor = True
        '
        'btnBackButton
        '
        Me.btnBackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBackButton.Location = New System.Drawing.Point(422, 12)
        Me.btnBackButton.Name = "btnBackButton"
        Me.btnBackButton.Size = New System.Drawing.Size(108, 34)
        Me.btnBackButton.TabIndex = 14
        Me.btnBackButton.Text = "<="
        Me.btnBackButton.UseVisualStyleBackColor = False
        '
        'lblUpdateInventory
        '
        Me.lblUpdateInventory.AutoSize = True
        Me.lblUpdateInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateInventory.Location = New System.Drawing.Point(20, 18)
        Me.lblUpdateInventory.Name = "lblUpdateInventory"
        Me.lblUpdateInventory.Size = New System.Drawing.Size(150, 20)
        Me.lblUpdateInventory.TabIndex = 15
        Me.lblUpdateInventory.Text = "Update Inventory"
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.Location = New System.Drawing.Point(422, 271)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(108, 53)
        Me.btnRemoveItem.TabIndex = 16
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(551, 347)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.lblUpdateInventory)
        Me.Controls.Add(Me.btnBackButton)
        Me.Controls.Add(Me.btnUpdateQuantity)
        Me.Controls.Add(Me.btnUpdatePrice)
        Me.Controls.Add(Me.lblItemQuantity)
        Me.Controls.Add(Me.txbItemQuantity)
        Me.Controls.Add(Me.lblItemPrice)
        Me.Controls.Add(Me.txbItemPrice)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txbItemName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Tracker System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbItemName As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblItemPrice As Label
    Friend WithEvents txbItemPrice As TextBox
    Friend WithEvents lblItemQuantity As Label
    Friend WithEvents txbItemQuantity As TextBox
    Friend WithEvents btnUpdatePrice As Button
    Friend WithEvents btnUpdateQuantity As Button
    Friend WithEvents btnBackButton As Button
    Friend WithEvents lblUpdateInventory As Label
    Friend WithEvents btnRemoveItem As Button
End Class
