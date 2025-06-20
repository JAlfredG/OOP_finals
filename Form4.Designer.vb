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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.btnBackButton = New System.Windows.Forms.Button()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rtxbTextArea = New System.Windows.Forms.RichTextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBackButton
        '
        Me.btnBackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBackButton.Location = New System.Drawing.Point(323, 10)
        Me.btnBackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBackButton.Name = "btnBackButton"
        Me.btnBackButton.Size = New System.Drawing.Size(81, 28)
        Me.btnBackButton.TabIndex = 15
        Me.btnBackButton.Text = "<           Back"
        Me.btnBackButton.UseVisualStyleBackColor = False
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(9, 15)
        Me.lblReport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(110, 17)
        Me.lblReport.TabIndex = 16
        Me.lblReport.Text = "Create Report"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Cooper Black", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(140, 288)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(132, 46)
        Me.btnSubmit.TabIndex = 17
        Me.btnSubmit.Text = "Submit Report"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(418, 56)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'rtxbTextArea
        '
        Me.rtxbTextArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxbTextArea.Location = New System.Drawing.Point(9, 65)
        Me.rtxbTextArea.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxbTextArea.Name = "rtxbTextArea"
        Me.rtxbTextArea.Size = New System.Drawing.Size(396, 214)
        Me.rtxbTextArea.TabIndex = 0
        Me.rtxbTextArea.Text = ""
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Location = New System.Drawing.Point(323, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(78, 23)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "<     Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(413, 340)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.btnBackButton)
        Me.Controls.Add(Me.rtxbTextArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Tracker System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBackButton As Button
    Friend WithEvents lblReport As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rtxbTextArea As RichTextBox
    Friend WithEvents btnBack As Button
End Class
