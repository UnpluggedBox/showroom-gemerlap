<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Me.lblMinimizeApp = New System.Windows.Forms.Label()
        Me.lblCloseApp = New System.Windows.Forms.Label()
        Me.iUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.iPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMinimizeApp
        '
        Me.lblMinimizeApp.AutoSize = True
        Me.lblMinimizeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizeApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizeApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMinimizeApp.Location = New System.Drawing.Point(332, 0)
        Me.lblMinimizeApp.Name = "lblMinimizeApp"
        Me.lblMinimizeApp.Size = New System.Drawing.Size(20, 22)
        Me.lblMinimizeApp.TabIndex = 4
        Me.lblMinimizeApp.Text = "-"
        '
        'lblCloseApp
        '
        Me.lblCloseApp.AutoSize = True
        Me.lblCloseApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCloseApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCloseApp.Location = New System.Drawing.Point(358, 0)
        Me.lblCloseApp.Name = "lblCloseApp"
        Me.lblCloseApp.Size = New System.Drawing.Size(20, 22)
        Me.lblCloseApp.TabIndex = 3
        Me.lblCloseApp.Text = "x"
        '
        'iUsername
        '
        Me.iUsername.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.iUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.iUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iUsername.Location = New System.Drawing.Point(58, 175)
        Me.iUsername.Name = "iUsername"
        Me.iUsername.Size = New System.Drawing.Size(266, 19)
        Me.iUsername.TabIndex = 8
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUsername.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUsername.Location = New System.Drawing.Point(54, 150)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(90, 22)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPassword.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPassword.Location = New System.Drawing.Point(54, 226)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(90, 22)
        Me.lblPassword.TabIndex = 11
        Me.lblPassword.Text = "Password"
        '
        'iPassword
        '
        Me.iPassword.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.iPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.iPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iPassword.Location = New System.Drawing.Point(58, 251)
        Me.iPassword.Name = "iPassword"
        Me.iPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.iPassword.Size = New System.Drawing.Size(266, 19)
        Me.iPassword.TabIndex = 10
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DimGray
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(58, 316)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(85, 23)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DimGray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(239, 315)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblMinimizeApp)
        Me.Panel1.Controls.Add(Me.lblCloseApp)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 115)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ShowRoomMobilUAS.My.Resources.Resources.logoshowroom
        Me.PictureBox1.Location = New System.Drawing.Point(60, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 411)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.iPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.iUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginPage"
        Me.Text = "v"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMinimizeApp As Label
    Friend WithEvents lblCloseApp As Label
    Friend WithEvents iUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents iPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
