<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_FIND = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxMerk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMinimizeApp = New System.Windows.Forms.Label()
        Me.lblCloseApp = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.BTN_INSER = New System.Windows.Forms.Button()
        Me.pbIconAdmin = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIconAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxPath
        '
        Me.TextBoxPath.Location = New System.Drawing.Point(174, 181)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPath.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(104, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "ImagePath"
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(174, 155)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrice.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(104, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Harga"
        '
        'TextBoxDesc
        '
        Me.TextBoxDesc.Location = New System.Drawing.Point(174, 124)
        Me.TextBoxDesc.Name = "TextBoxDesc"
        Me.TextBoxDesc.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDesc.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(104, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Deskripsi"
        '
        'Button_FIND
        '
        Me.Button_FIND.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_FIND.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_FIND.Location = New System.Drawing.Point(291, 27)
        Me.Button_FIND.Name = "Button_FIND"
        Me.Button_FIND.Size = New System.Drawing.Size(75, 23)
        Me.Button_FIND.TabIndex = 50
        Me.Button_FIND.Text = "Load Data"
        Me.Button_FIND.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(233, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Enter Value To Search:"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(370, 262)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSearch.TabIndex = 48
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.BackgroundImage = Global.ShowRoomMobilUAS.My.Resources.Resources.delete_1432400_1211078
        Me.BTN_DELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_DELETE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_DELETE.Location = New System.Drawing.Point(446, 158)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(48, 45)
        Me.BTN_DELETE.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.BTN_DELETE, "Delete")
        Me.BTN_DELETE.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 288)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(739, 150)
        Me.DataGridView1.TabIndex = 44
        '
        'TextBoxType
        '
        Me.TextBoxType.Location = New System.Drawing.Point(174, 92)
        Me.TextBoxType.Name = "TextBoxType"
        Me.TextBoxType.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxType.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(104, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Type"
        '
        'TextBoxMerk
        '
        Me.TextBoxMerk.Location = New System.Drawing.Point(174, 58)
        Me.TextBoxMerk.Name = "TextBoxMerk"
        Me.TextBoxMerk.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMerk.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(104, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Merk"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(174, 29)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxID.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(104, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "ID"
        '
        'lblMinimizeApp
        '
        Me.lblMinimizeApp.AutoSize = True
        Me.lblMinimizeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizeApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizeApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMinimizeApp.Location = New System.Drawing.Point(755, -1)
        Me.lblMinimizeApp.Name = "lblMinimizeApp"
        Me.lblMinimizeApp.Size = New System.Drawing.Size(20, 22)
        Me.lblMinimizeApp.TabIndex = 58
        Me.lblMinimizeApp.Text = "-"
        '
        'lblCloseApp
        '
        Me.lblCloseApp.AutoSize = True
        Me.lblCloseApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCloseApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCloseApp.Location = New System.Drawing.Point(781, -1)
        Me.lblCloseApp.Name = "lblCloseApp"
        Me.lblCloseApp.Size = New System.Drawing.Size(20, 22)
        Me.lblCloseApp.TabIndex = 57
        Me.lblCloseApp.Text = "x"
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.BackgroundImage = Global.ShowRoomMobilUAS.My.Resources.Resources.update_vector_icon_256
        Me.BTN_UPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_UPDATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_UPDATE.Location = New System.Drawing.Point(370, 158)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(48, 45)
        Me.BTN_UPDATE.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.BTN_UPDATE, "Update")
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'BTN_INSER
        '
        Me.BTN_INSER.BackgroundImage = Global.ShowRoomMobilUAS.My.Resources.Resources.insert_icon_5
        Me.BTN_INSER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INSER.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_INSER.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_INSER.Location = New System.Drawing.Point(291, 158)
        Me.BTN_INSER.Name = "BTN_INSER"
        Me.BTN_INSER.Size = New System.Drawing.Size(48, 45)
        Me.BTN_INSER.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.BTN_INSER, "Insert")
        Me.BTN_INSER.UseVisualStyleBackColor = True
        '
        'pbIconAdmin
        '
        Me.pbIconAdmin.Image = Global.ShowRoomMobilUAS.My.Resources.Resources.admin_settings_male
        Me.pbIconAdmin.Location = New System.Drawing.Point(-12, -6)
        Me.pbIconAdmin.Name = "pbIconAdmin"
        Me.pbIconAdmin.Size = New System.Drawing.Size(98, 84)
        Me.pbIconAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIconAdmin.TabIndex = 59
        Me.pbIconAdmin.TabStop = False
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbIconAdmin)
        Me.Controls.Add(Me.lblMinimizeApp)
        Me.Controls.Add(Me.lblCloseApp)
        Me.Controls.Add(Me.TextBoxPath)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxDesc)
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
        Me.Controls.Add(Me.TextBoxMerk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminPage"
        Me.Text = "AdminPage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIconAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxPath As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxDesc As TextBox
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
    Friend WithEvents TextBoxMerk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMinimizeApp As Label
    Friend WithEvents lblCloseApp As Label
    Friend WithEvents pbIconAdmin As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
