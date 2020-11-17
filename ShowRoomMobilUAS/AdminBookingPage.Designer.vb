<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminBookingPage
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
        Me.pbIconAdmin = New System.Windows.Forms.PictureBox()
        Me.lblMinimizeApp = New System.Windows.Forms.Label()
        Me.lblCloseApp = New System.Windows.Forms.Label()
        Me.TextBoxWarna = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_FIND = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.BTN_INSER = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pbIconAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbIconAdmin
        '
        Me.pbIconAdmin.Image = Global.ShowRoomMobilUAS.My.Resources.Resources.admin_settings_male
        Me.pbIconAdmin.Location = New System.Drawing.Point(-10, -5)
        Me.pbIconAdmin.Name = "pbIconAdmin"
        Me.pbIconAdmin.Size = New System.Drawing.Size(98, 84)
        Me.pbIconAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIconAdmin.TabIndex = 75
        Me.pbIconAdmin.TabStop = False
        '
        'lblMinimizeApp
        '
        Me.lblMinimizeApp.AutoSize = True
        Me.lblMinimizeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizeApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizeApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMinimizeApp.Location = New System.Drawing.Point(754, -5)
        Me.lblMinimizeApp.Name = "lblMinimizeApp"
        Me.lblMinimizeApp.Size = New System.Drawing.Size(20, 22)
        Me.lblMinimizeApp.TabIndex = 74
        Me.lblMinimizeApp.Text = "-"
        '
        'lblCloseApp
        '
        Me.lblCloseApp.AutoSize = True
        Me.lblCloseApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCloseApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCloseApp.Location = New System.Drawing.Point(780, -5)
        Me.lblCloseApp.Name = "lblCloseApp"
        Me.lblCloseApp.Size = New System.Drawing.Size(20, 22)
        Me.lblCloseApp.TabIndex = 73
        Me.lblCloseApp.Text = "x"
        '
        'TextBoxWarna
        '
        Me.TextBoxWarna.Location = New System.Drawing.Point(180, 113)
        Me.TextBoxWarna.Name = "TextBoxWarna"
        Me.TextBoxWarna.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxWarna.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(110, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Warna"
        '
        'Button_FIND
        '
        Me.Button_FIND.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_FIND.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_FIND.Location = New System.Drawing.Point(297, 34)
        Me.Button_FIND.Name = "Button_FIND"
        Me.Button_FIND.Size = New System.Drawing.Size(75, 23)
        Me.Button_FIND.TabIndex = 70
        Me.Button_FIND.Text = "Load Data"
        Me.Button_FIND.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(239, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Enter Value To Search:"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(376, 269)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSearch.TabIndex = 68
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.BackgroundImage = Global.ShowRoomMobilUAS.My.Resources.Resources.update_vector_icon_256
        Me.BTN_UPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_UPDATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_UPDATE.Location = New System.Drawing.Point(376, 113)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(48, 45)
        Me.BTN_UPDATE.TabIndex = 67
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.BackgroundImage = Global.ShowRoomMobilUAS.My.Resources.Resources.delete_1432400_1211078
        Me.BTN_DELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_DELETE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_DELETE.Location = New System.Drawing.Point(452, 113)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(48, 45)
        Me.BTN_DELETE.TabIndex = 66
        Me.BTN_DELETE.UseVisualStyleBackColor = True
        '
        'BTN_INSER
        '
        Me.BTN_INSER.BackgroundImage = Global.ShowRoomMobilUAS.My.Resources.Resources.insert_icon_5
        Me.BTN_INSER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INSER.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_INSER.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_INSER.Location = New System.Drawing.Point(297, 113)
        Me.BTN_INSER.Name = "BTN_INSER"
        Me.BTN_INSER.Size = New System.Drawing.Size(48, 45)
        Me.BTN_INSER.TabIndex = 65
        Me.BTN_INSER.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 295)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(739, 150)
        Me.DataGridView1.TabIndex = 64
        '
        'TextBoxType
        '
        Me.TextBoxType.Location = New System.Drawing.Point(180, 77)
        Me.TextBoxType.Name = "TextBoxType"
        Me.TextBoxType.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxType.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(110, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Type"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(180, 39)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxID.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(110, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "ID"
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(180, 146)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNama.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(114, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Nama"
        '
        'AdminBookingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbIconAdmin)
        Me.Controls.Add(Me.lblMinimizeApp)
        Me.Controls.Add(Me.lblCloseApp)
        Me.Controls.Add(Me.TextBoxWarna)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button_FIND)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.BTN_UPDATE)
        Me.Controls.Add(Me.BTN_DELETE)
        Me.Controls.Add(Me.BTN_INSER)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminBookingPage"
        Me.Text = "AdminBookingPage"
        CType(Me.pbIconAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbIconAdmin As PictureBox
    Friend WithEvents lblMinimizeApp As Label
    Friend WithEvents lblCloseApp As Label
    Friend WithEvents TextBoxWarna As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_FIND As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents BTN_DELETE As Button
    Friend WithEvents BTN_INSER As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents Label2 As Label
End Class
