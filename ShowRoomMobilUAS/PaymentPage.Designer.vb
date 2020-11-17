<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentPage
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
        Me.cbCredit = New System.Windows.Forms.CheckBox()
        Me.cbCash = New System.Windows.Forms.CheckBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.iCardNumber = New System.Windows.Forms.TextBox()
        Me.lblDP = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbCredit
        '
        Me.cbCredit.AutoSize = True
        Me.cbCredit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCredit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cbCredit.Location = New System.Drawing.Point(62, 139)
        Me.cbCredit.Name = "cbCredit"
        Me.cbCredit.Size = New System.Drawing.Size(193, 30)
        Me.cbCredit.TabIndex = 0
        Me.cbCredit.Text = "Credit / Debit Card"
        Me.cbCredit.UseVisualStyleBackColor = True
        '
        'cbCash
        '
        Me.cbCash.AutoSize = True
        Me.cbCash.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCash.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cbCash.Location = New System.Drawing.Point(62, 175)
        Me.cbCash.Name = "cbCash"
        Me.cbCash.Size = New System.Drawing.Size(179, 30)
        Me.cbCash.TabIndex = 2
        Me.cbCash.Text = "Cash On the Spot"
        Me.cbCash.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.DimGray
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.Location = New System.Drawing.Point(62, 373)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(85, 23)
        Me.btnPay.TabIndex = 21
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DimGray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(170, 373)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 23)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ShowRoomMobilUAS.My.Resources.Resources.payment
        Me.PictureBox1.Location = New System.Drawing.Point(432, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 219)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'iCardNumber
        '
        Me.iCardNumber.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.iCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.iCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iCardNumber.Location = New System.Drawing.Point(62, 244)
        Me.iCardNumber.Name = "iCardNumber"
        Me.iCardNumber.Size = New System.Drawing.Size(266, 19)
        Me.iCardNumber.TabIndex = 23
        '
        'lblDP
        '
        Me.lblDP.AutoSize = True
        Me.lblDP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDP.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDP.Location = New System.Drawing.Point(58, 63)
        Me.lblDP.Name = "lblDP"
        Me.lblDP.Size = New System.Drawing.Size(150, 22)
        Me.lblDP.TabIndex = 24
        Me.lblDP.Text = "Down Payment: "
        '
        'PaymentPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDP)
        Me.Controls.Add(Me.iCardNumber)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.cbCash)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbCredit)
        Me.Name = "PaymentPage"
        Me.Text = "PaymentPage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCredit As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbCash As CheckBox
    Friend WithEvents btnPay As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents iCardNumber As TextBox
    Friend WithEvents lblDP As Label
End Class
