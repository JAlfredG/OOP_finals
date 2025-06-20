<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.txbItemName = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblItemPrice = New System.Windows.Forms.Label()
        Me.txbItemPrice = New System.Windows.Forms.TextBox()
        Me.lblItemQuantity = New System.Windows.Forms.Label()
        Me.txbItemQuantity = New System.Windows.Forms.TextBox()
        Me.btnUpdatePrice = New System.Windows.Forms.Button()
        Me.btnUpdateQuantity = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbItemName
        '
        Me.txbItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbItemName.Location = New System.Drawing.Point(18, 67)
        Me.txbItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.txbItemName.Name = "txbItemName"
        Me.txbItemName.Size = New System.Drawing.Size(290, 26)
        Me.txbItemName.TabIndex = 0
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnAddItem.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(323, 61)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(81, 43)
        Me.btnAddItem.TabIndex = 1
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemName.Location = New System.Drawing.Point(19, 94)
        Me.lblItemName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(84, 17)
        Me.lblItemName.TabIndex = 4
        Me.lblItemName.Text = "Item Name"
        '
        'lblItemPrice
        '
        Me.lblItemPrice.AutoSize = True
        Me.lblItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemPrice.Location = New System.Drawing.Point(19, 173)
        Me.lblItemPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(80, 17)
        Me.lblItemPrice.TabIndex = 6
        Me.lblItemPrice.Text = "Item Price"
        '
        'txbItemPrice
        '
        Me.txbItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbItemPrice.Location = New System.Drawing.Point(18, 146)
        Me.txbItemPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txbItemPrice.Name = "txbItemPrice"
        Me.txbItemPrice.Size = New System.Drawing.Size(290, 26)
        Me.txbItemPrice.TabIndex = 5
        '
        'lblItemQuantity
        '
        Me.lblItemQuantity.AutoSize = True
        Me.lblItemQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblItemQuantity.Location = New System.Drawing.Point(19, 250)
        Me.lblItemQuantity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblItemQuantity.Name = "lblItemQuantity"
        Me.lblItemQuantity.Size = New System.Drawing.Size(104, 17)
        Me.lblItemQuantity.TabIndex = 8
        Me.lblItemQuantity.Text = "Item Quantity"
        '
        'txbItemQuantity
        '
        Me.txbItemQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbItemQuantity.Location = New System.Drawing.Point(18, 223)
        Me.txbItemQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txbItemQuantity.Name = "txbItemQuantity"
        Me.txbItemQuantity.Size = New System.Drawing.Size(290, 26)
        Me.txbItemQuantity.TabIndex = 7
        '
        'btnUpdatePrice
        '
        Me.btnUpdatePrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnUpdatePrice.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePrice.Location = New System.Drawing.Point(323, 116)
        Me.btnUpdatePrice.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdatePrice.Name = "btnUpdatePrice"
        Me.btnUpdatePrice.Size = New System.Drawing.Size(81, 43)
        Me.btnUpdatePrice.TabIndex = 10
        Me.btnUpdatePrice.Text = "Update Price"
        Me.btnUpdatePrice.UseVisualStyleBackColor = False
        '
        'btnUpdateQuantity
        '
        Me.btnUpdateQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnUpdateQuantity.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btnUpdateQuantity.Location = New System.Drawing.Point(323, 169)
        Me.btnUpdateQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateQuantity.Name = "btnUpdateQuantity"
        Me.btnUpdateQuantity.Size = New System.Drawing.Size(81, 43)
        Me.btnUpdateQuantity.TabIndex = 13
        Me.btnUpdateQuantity.Text = "Update Quantity"
        Me.btnUpdateQuantity.UseVisualStyleBackColor = False
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnRemoveItem.Font = New System.Drawing.Font("Cooper Black", 9.0!)
        Me.btnRemoveItem.Location = New System.Drawing.Point(323, 224)
        Me.btnRemoveItem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(81, 43)
        Me.btnRemoveItem.TabIndex = 16
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(418, 56)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Location = New System.Drawing.Point(323, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(78, 23)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "<     Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(413, 282)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRemoveItem)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Tracker System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
