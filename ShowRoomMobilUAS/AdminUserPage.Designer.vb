<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUserPage
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
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbIconAdmin = New System.Windows.Forms.PictureBox()
        Me.lblMinimizeApp = New System.Windows.Forms.Label()
        Me.lblCloseApp = New System.Windows.Forms.Label()
        Me.TextBoxRole = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_FIND = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.BTN_INSER = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbIconAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(185, 151)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxName.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(116, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Full Name"
        '
        'pbIconAdmin
        '
        Me.pbIconAdmin.Image = Global.ShowRoomMobilUAS.My.Resources.Resources.admin_settings_male
        Me.pbIconAdmin.Location = New System.Drawing.Point(-5, 0)
        Me.pbIconAdmin.Name = "pbIconAdmin"
        Me.pbIconAdmin.Size = New System.Drawing.Size(98, 84)
        Me.pbIconAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIconAdmin.TabIndex = 93
        Me.pbIconAdmin.TabStop = False
        '
        'lblMinimizeApp
        '
        Me.lblMinimizeApp.AutoSize = True
        Me.lblMinimizeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizeApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizeApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMinimizeApp.Location = New System.Drawing.Point(759, 0)
        Me.lblMinimizeApp.Name = "lblMinimizeApp"
        Me.lblMinimizeApp.Size = New System.Drawing.Size(20, 22)
        Me.lblMinimizeApp.TabIndex = 92
        Me.lblMinimizeApp.Text = "-"
        '
        'lblCloseApp
        '
        Me.lblCloseApp.AutoSize = True
        Me.lblCloseApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCloseApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCloseApp.Location = New System.Drawing.Point(785, 0)
        Me.lblCloseApp.Name = "lblCloseApp"
        Me.lblCloseApp.Size = New System.Drawing.Size(20, 22)
        Me.lblCloseApp.TabIndex = 91
        Me.lblCloseApp.Text = "x"
        '
        'TextBoxRole
        '
        Me.TextBoxRole.Location = New System.Drawing.Point(185, 118)
        Me.TextBoxRole.Name = "TextBoxRole"
        Me.TextBoxRole.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRole.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(115, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Role"
        '
        'Button_FIND
        '
        Me.Button_FIND.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_FIND.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_FIND.Location = New System.Drawing.Point(302, 39)
        Me.Button_FIND.Name = "Button_FIND"
        Me.Button_FIND.Size = New System.Drawing.Size(75, 23)
        Me.Button_FIND.TabIndex = 88
        Me.Button_FIND.Text = "Load Data"
        Me.Button_FIND.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(244, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Enter Value To Search:"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(381, 274)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSearch.TabIndex = 86
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.BackgroundImage = Global.ShowRoomMobilUAS.My.Resources.Resources.update_vector_icon_256
        Me.BTN_UPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_UPDATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_UPDATE.Location = New System.Drawing.Point(381, 118)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(48, 45)
        Me.BTN_UPDATE.TabIndex = 85
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.BackgroundImage = Global.ShowRoomMobilUAS.My.Resources.Resources.delete_1432400_1211078
        Me.BTN_DELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_DELETE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_DELETE.Location = New System.Drawing.Point(457, 118)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(48, 45)
        Me.BTN_DELETE.TabIndex = 84
        Me.BTN_DELETE.UseVisualStyleBackColor = True
        '
        'BTN_INSER
        '
        Me.BTN_INSER.BackgroundImage = Global.ShowRoomMobilUAS.My.Resources.Resources.insert_icon_5
        Me.BTN_INSER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INSER.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_INSER.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_INSER.Location = New System.Drawing.Point(302, 118)
        Me.BTN_INSER.Name = "BTN_INSER"
        Me.BTN_INSER.Size = New System.Drawing.Size(48, 45)
        Me.BTN_INSER.TabIndex = 83
        Me.BTN_INSER.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(739, 150)
        Me.DataGridView1.TabIndex = 82
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(185, 82)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPassword.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(115, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Password"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(185, 44)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxID.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(115, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "UserId"
        '
        'AdminUserPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbIconAdmin)
        Me.Controls.Add(Me.lblMinimizeApp)
        Me.Controls.Add(Me.lblCloseApp)
        Me.Controls.Add(Me.TextBoxRole)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button_FIND)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.BTN_UPDATE)
        Me.Controls.Add(Me.BTN_DELETE)
        Me.Controls.Add(Me.BTN_INSER)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminUserPage"
        Me.Text = "AdminUserPage"
        CType(Me.pbIconAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pbIconAdmin As PictureBox
    Friend WithEvents lblMinimizeApp As Label
    Friend WithEvents lblCloseApp As Label
    Friend WithEvents TextBoxRole As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_FIND As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents BTN_DELETE As Button
    Friend WithEvents BTN_INSER As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label1 As Label
End Class
