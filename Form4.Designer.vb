<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.rtxbTextArea = New System.Windows.Forms.RichTextBox()
        Me.btnBackButton = New System.Windows.Forms.Button()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtxbTextArea
        '
        Me.rtxbTextArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxbTextArea.Location = New System.Drawing.Point(12, 52)
        Me.rtxbTextArea.Name = "rtxbTextArea"
        Me.rtxbTextArea.Size = New System.Drawing.Size(566, 254)
        Me.rtxbTextArea.TabIndex = 0
        Me.rtxbTextArea.Text = ""
        '
        'btnBackButton
        '
        Me.btnBackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBackButton.Location = New System.Drawing.Point(471, 12)
        Me.btnBackButton.Name = "btnBackButton"
        Me.btnBackButton.Size = New System.Drawing.Size(108, 34)
        Me.btnBackButton.TabIndex = 15
        Me.btnBackButton.Text = "<="
        Me.btnBackButton.UseVisualStyleBackColor = False
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(12, 18)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(127, 20)
        Me.lblReport.TabIndex = 16
        Me.lblReport.Text = "Create Report"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(213, 316)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(176, 56)
        Me.btnSubmit.TabIndex = 17
        Me.btnSubmit.Text = "Submit Report"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(591, 391)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.btnBackButton)
        Me.Controls.Add(Me.rtxbTextArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Tracker System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtxbTextArea As RichTextBox
    Friend WithEvents btnBackButton As Button
    Friend WithEvents lblReport As Label
    Friend WithEvents btnSubmit As Button
End Class
