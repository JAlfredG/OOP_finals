<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnShowInventory = New System.Windows.Forms.Button()
        Me.btnShowWeekly = New System.Windows.Forms.Button()
        Me.btnUpdateInv = New System.Windows.Forms.Button()
        Me.btnShowSales = New System.Windows.Forms.Button()
        Me.btnCreateSales = New System.Windows.Forms.Button()
        Me.btnCreateWeekly = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.rtxbMainView = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShowInventory
        '
        Me.btnShowInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnShowInventory.Font = New System.Drawing.Font("Cooper Black", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowInventory.Location = New System.Drawing.Point(469, 74)
        Me.btnShowInventory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnShowInventory.Name = "btnShowInventory"
        Me.btnShowInventory.Size = New System.Drawing.Size(175, 50)
        Me.btnShowInventory.TabIndex = 1
        Me.btnShowInventory.Text = "Show Inventory"
        Me.btnShowInventory.UseVisualStyleBackColor = False
        '
        'btnShowWeekly
        '
        Me.btnShowWeekly.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnShowWeekly.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btnShowWeekly.Location = New System.Drawing.Point(469, 130)
        Me.btnShowWeekly.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnShowWeekly.Name = "btnShowWeekly"
        Me.btnShowWeekly.Size = New System.Drawing.Size(175, 50)
        Me.btnShowWeekly.TabIndex = 2
        Me.btnShowWeekly.Text = "Show Weekly Report"
        Me.btnShowWeekly.UseVisualStyleBackColor = False
        '
        'btnUpdateInv
        '
        Me.btnUpdateInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnUpdateInv.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btnUpdateInv.Location = New System.Drawing.Point(469, 250)
        Me.btnUpdateInv.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdateInv.Name = "btnUpdateInv"
        Me.btnUpdateInv.Size = New System.Drawing.Size(175, 50)
        Me.btnUpdateInv.TabIndex = 4
        Me.btnUpdateInv.Text = "Update Inventory"
        Me.btnUpdateInv.UseVisualStyleBackColor = False
        '
        'btnShowSales
        '
        Me.btnShowSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnShowSales.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btnShowSales.Location = New System.Drawing.Point(469, 185)
        Me.btnShowSales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnShowSales.Name = "btnShowSales"
        Me.btnShowSales.Size = New System.Drawing.Size(175, 50)
        Me.btnShowSales.TabIndex = 3
        Me.btnShowSales.Text = "Show Sales Report"
        Me.btnShowSales.UseVisualStyleBackColor = False
        '
        'btnCreateSales
        '
        Me.btnCreateSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnCreateSales.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btnCreateSales.Location = New System.Drawing.Point(469, 360)
        Me.btnCreateSales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCreateSales.Name = "btnCreateSales"
        Me.btnCreateSales.Size = New System.Drawing.Size(175, 50)
        Me.btnCreateSales.TabIndex = 6
        Me.btnCreateSales.Text = "Create Sales Report"
        Me.btnCreateSales.UseVisualStyleBackColor = False
        '
        'btnCreateWeekly
        '
        Me.btnCreateWeekly.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnCreateWeekly.Font = New System.Drawing.Font("Cooper Black", 10.2!)
        Me.btnCreateWeekly.Location = New System.Drawing.Point(469, 305)
        Me.btnCreateWeekly.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCreateWeekly.Name = "btnCreateWeekly"
        Me.btnCreateWeekly.Size = New System.Drawing.Size(175, 50)
        Me.btnCreateWeekly.TabIndex = 5
        Me.btnCreateWeekly.Text = "Create Weekly Report"
        Me.btnCreateWeekly.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.LightCoral
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(469, 425)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(175, 50)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'rtxbMainView
        '
        Me.rtxbMainView.BackColor = System.Drawing.SystemColors.Control
        Me.rtxbMainView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxbMainView.ForeColor = System.Drawing.SystemColors.Desktop
        Me.rtxbMainView.Location = New System.Drawing.Point(10, 74)
        Me.rtxbMainView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxbMainView.Name = "rtxbMainView"
        Me.rtxbMainView.ReadOnly = True
        Me.rtxbMainView.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtxbMainView.Size = New System.Drawing.Size(441, 401)
        Me.rtxbMainView.TabIndex = 8
        Me.rtxbMainView.Text = "Store Tracker System Interface"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(655, 56)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(653, 496)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rtxbMainView)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnCreateSales)
        Me.Controls.Add(Me.btnCreateWeekly)
        Me.Controls.Add(Me.btnUpdateInv)
        Me.Controls.Add(Me.btnShowSales)
        Me.Controls.Add(Me.btnShowWeekly)
        Me.Controls.Add(Me.btnShowInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Tracker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShowInventory As Button
    Friend WithEvents btnShowWeekly As Button
    Friend WithEvents btnUpdateInv As Button
    Friend WithEvents btnShowSales As Button
    Friend WithEvents btnCreateSales As Button
    Friend WithEvents btnCreateWeekly As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents rtxbMainView As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
