<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarDetail
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
        Me.lblMerkMobil = New System.Windows.Forms.Label()
        Me.lblDeskripsiMobil = New System.Windows.Forms.Label()
        Me.lblHargaMobil = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblMinimizeApp = New System.Windows.Forms.Label()
        Me.lblCloseApp = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbMobil = New System.Windows.Forms.PictureBox()
        Me.btnBuy = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMerkMobil
        '
        Me.lblMerkMobil.AutoSize = True
        Me.lblMerkMobil.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMerkMobil.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMerkMobil.Location = New System.Drawing.Point(403, 88)
        Me.lblMerkMobil.Name = "lblMerkMobil"
        Me.lblMerkMobil.Size = New System.Drawing.Size(201, 50)
        Me.lblMerkMobil.TabIndex = 0
        Me.lblMerkMobil.Text = "Merk Mobil"
        '
        'lblDeskripsiMobil
        '
        Me.lblDeskripsiMobil.AllowDrop = True
        Me.lblDeskripsiMobil.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblDeskripsiMobil.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeskripsiMobil.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDeskripsiMobil.Location = New System.Drawing.Point(403, 302)
        Me.lblDeskripsiMobil.Name = "lblDeskripsiMobil"
        Me.lblDeskripsiMobil.Size = New System.Drawing.Size(980, 368)
        Me.lblDeskripsiMobil.TabIndex = 2
        Me.lblDeskripsiMobil.Text = "Deskripsi Mobil"
        '
        'lblHargaMobil
        '
        Me.lblHargaMobil.AutoSize = True
        Me.lblHargaMobil.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHargaMobil.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHargaMobil.Location = New System.Drawing.Point(403, 203)
        Me.lblHargaMobil.Name = "lblHargaMobil"
        Me.lblHargaMobil.Size = New System.Drawing.Size(74, 50)
        Me.lblHargaMobil.TabIndex = 4
        Me.lblHargaMobil.Text = "Rp "
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DimGray
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(764, 635)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 32)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblMinimizeApp
        '
        Me.lblMinimizeApp.AutoSize = True
        Me.lblMinimizeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizeApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizeApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMinimizeApp.Location = New System.Drawing.Point(1376, -2)
        Me.lblMinimizeApp.Name = "lblMinimizeApp"
        Me.lblMinimizeApp.Size = New System.Drawing.Size(20, 22)
        Me.lblMinimizeApp.TabIndex = 9
        Me.lblMinimizeApp.Text = "-"
        '
        'lblCloseApp
        '
        Me.lblCloseApp.AutoSize = True
        Me.lblCloseApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCloseApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCloseApp.Location = New System.Drawing.Point(1402, -2)
        Me.lblCloseApp.Name = "lblCloseApp"
        Me.lblCloseApp.Size = New System.Drawing.Size(20, 22)
        Me.lblCloseApp.TabIndex = 8
        Me.lblCloseApp.Text = "x"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ShowRoomMobilUAS.My.Resources.Resources.logoshowroom
        Me.PictureBox1.Location = New System.Drawing.Point(1023, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pbMobil
        '
        Me.pbMobil.Location = New System.Drawing.Point(63, 102)
        Me.pbMobil.Name = "pbMobil"
        Me.pbMobil.Size = New System.Drawing.Size(300, 250)
        Me.pbMobil.TabIndex = 3
        Me.pbMobil.TabStop = False
        '
        'btnBuy
        '
        Me.btnBuy.BackColor = System.Drawing.Color.DimGray
        Me.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuy.Location = New System.Drawing.Point(656, 635)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(88, 32)
        Me.btnBuy.TabIndex = 6
        Me.btnBuy.Text = "Buy"
        Me.btnBuy.UseVisualStyleBackColor = False
        '
        'CarDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1421, 679)
        Me.Controls.Add(Me.lblMinimizeApp)
        Me.Controls.Add(Me.lblCloseApp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblHargaMobil)
        Me.Controls.Add(Me.pbMobil)
        Me.Controls.Add(Me.lblDeskripsiMobil)
        Me.Controls.Add(Me.lblMerkMobil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CarDetail"
        Me.Text = "Car Detail"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMobil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMerkMobil As Label
    Friend WithEvents lblDeskripsiMobil As Label
    Friend WithEvents pbMobil As PictureBox
    Friend WithEvents lblHargaMobil As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMinimizeApp As Label
    Friend WithEvents lblCloseApp As Label
    Friend WithEvents btnBuy As Button
End Class
