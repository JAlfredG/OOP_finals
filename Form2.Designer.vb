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
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.btnShowInventory = New System.Windows.Forms.Button()
        Me.btnShowWeekly = New System.Windows.Forms.Button()
        Me.btnUpdateInv = New System.Windows.Forms.Button()
        Me.btnShowSales = New System.Windows.Forms.Button()
        Me.btnCreateSales = New System.Windows.Forms.Button()
        Me.btnCreateWeekly = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(18, 21)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(601, 511)
        Me.VScrollBar1.TabIndex = 0
        '
        'btnShowInventory
        '
        Me.btnShowInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowInventory.Location = New System.Drawing.Point(637, 39)
        Me.btnShowInventory.Name = "btnShowInventory"
        Me.btnShowInventory.Size = New System.Drawing.Size(233, 62)
        Me.btnShowInventory.TabIndex = 1
        Me.btnShowInventory.Text = "Show Inventory"
        Me.btnShowInventory.UseVisualStyleBackColor = True
        '
        'btnShowWeekly
        '
        Me.btnShowWeekly.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowWeekly.Location = New System.Drawing.Point(637, 107)
        Me.btnShowWeekly.Name = "btnShowWeekly"
        Me.btnShowWeekly.Size = New System.Drawing.Size(233, 62)
        Me.btnShowWeekly.TabIndex = 2
        Me.btnShowWeekly.Text = "Show Weekly Report"
        Me.btnShowWeekly.UseVisualStyleBackColor = True
        '
        'btnUpdateInv
        '
        Me.btnUpdateInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateInv.Location = New System.Drawing.Point(637, 255)
        Me.btnUpdateInv.Name = "btnUpdateInv"
        Me.btnUpdateInv.Size = New System.Drawing.Size(233, 62)
        Me.btnUpdateInv.TabIndex = 4
        Me.btnUpdateInv.Text = "Update Inventory"
        Me.btnUpdateInv.UseVisualStyleBackColor = True
        '
        'btnShowSales
        '
        Me.btnShowSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowSales.Location = New System.Drawing.Point(637, 175)
        Me.btnShowSales.Name = "btnShowSales"
        Me.btnShowSales.Size = New System.Drawing.Size(233, 62)
        Me.btnShowSales.TabIndex = 3
        Me.btnShowSales.Text = "Show Sales Report"
        Me.btnShowSales.UseVisualStyleBackColor = True
        '
        'btnCreateSales
        '
        Me.btnCreateSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateSales.Location = New System.Drawing.Point(637, 391)
        Me.btnCreateSales.Name = "btnCreateSales"
        Me.btnCreateSales.Size = New System.Drawing.Size(233, 62)
        Me.btnCreateSales.TabIndex = 6
        Me.btnCreateSales.Text = "Create Sales Report"
        Me.btnCreateSales.UseVisualStyleBackColor = True
        '
        'btnCreateWeekly
        '
        Me.btnCreateWeekly.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateWeekly.Location = New System.Drawing.Point(637, 323)
        Me.btnCreateWeekly.Name = "btnCreateWeekly"
        Me.btnCreateWeekly.Size = New System.Drawing.Size(233, 62)
        Me.btnCreateWeekly.TabIndex = 5
        Me.btnCreateWeekly.Text = "Create Weekly Report"
        Me.btnCreateWeekly.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.LightCoral
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(637, 470)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(233, 62)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 550)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnCreateSales)
        Me.Controls.Add(Me.btnCreateWeekly)
        Me.Controls.Add(Me.btnUpdateInv)
        Me.Controls.Add(Me.btnShowSales)
        Me.Controls.Add(Me.btnShowWeekly)
        Me.Controls.Add(Me.btnShowInventory)
        Me.Controls.Add(Me.VScrollBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Tracker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents btnShowInventory As Button
    Friend WithEvents btnShowWeekly As Button
    Friend WithEvents btnUpdateInv As Button
    Friend WithEvents btnShowSales As Button
    Friend WithEvents btnCreateSales As Button
    Friend WithEvents btnCreateWeekly As Button
    Friend WithEvents btnLogout As Button
End Class
