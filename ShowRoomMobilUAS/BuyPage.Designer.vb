<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuyPage
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
        Me.lblKetentuan = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblMinimizeApp = New System.Windows.Forms.Label()
        Me.lblCloseApp = New System.Windows.Forms.Label()
        Me.cbTypeMobil = New System.Windows.Forms.ComboBox()
        Me.MsMobilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SHOWROOMDataSet = New ShowRoomMobilUAS.SHOWROOMDataSet()
        Me.lblType = New System.Windows.Forms.Label()
        Me.SHOWROOMDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsMobilTableAdapter = New ShowRoomMobilUAS.SHOWROOMDataSetTableAdapters.MsMobilTableAdapter()
        Me.lblWarna = New System.Windows.Forms.Label()
        Me.cbWarna = New System.Windows.Forms.ComboBox()
        Me.MsWarnaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsWarnaTableAdapter = New ShowRoomMobilUAS.SHOWROOMDataSetTableAdapters.MsWarnaTableAdapter()
        Me.MsMobilBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.MsMobilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHOWROOMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHOWROOMDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsWarnaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsMobilBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKetentuan
        '
        Me.lblKetentuan.AllowDrop = True
        Me.lblKetentuan.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblKetentuan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKetentuan.ForeColor = System.Drawing.SystemColors.Control
        Me.lblKetentuan.Location = New System.Drawing.Point(29, 23)
        Me.lblKetentuan.Name = "lblKetentuan"
        Me.lblKetentuan.Size = New System.Drawing.Size(683, 129)
        Me.lblKetentuan.TabIndex = 3
        Me.lblKetentuan.Text = "Ketentuan Membeli"
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.DimGray
        Me.btnPay.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.Location = New System.Drawing.Point(319, 539)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 4
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DimGray
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(413, 539)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblMinimizeApp
        '
        Me.lblMinimizeApp.AutoSize = True
        Me.lblMinimizeApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizeApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizeApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMinimizeApp.Location = New System.Drawing.Point(785, -1)
        Me.lblMinimizeApp.Name = "lblMinimizeApp"
        Me.lblMinimizeApp.Size = New System.Drawing.Size(20, 22)
        Me.lblMinimizeApp.TabIndex = 7
        Me.lblMinimizeApp.Text = "-"
        '
        'lblCloseApp
        '
        Me.lblCloseApp.AutoSize = True
        Me.lblCloseApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCloseApp.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCloseApp.Location = New System.Drawing.Point(811, -1)
        Me.lblCloseApp.Name = "lblCloseApp"
        Me.lblCloseApp.Size = New System.Drawing.Size(20, 22)
        Me.lblCloseApp.TabIndex = 6
        Me.lblCloseApp.Text = "x"
        '
        'cbTypeMobil
        '
        Me.cbTypeMobil.DataSource = Me.MsMobilBindingSource
        Me.cbTypeMobil.DisplayMember = "Type"
        Me.cbTypeMobil.FormattingEnabled = True
        Me.cbTypeMobil.Location = New System.Drawing.Point(33, 243)
        Me.cbTypeMobil.Name = "cbTypeMobil"
        Me.cbTypeMobil.Size = New System.Drawing.Size(202, 21)
        Me.cbTypeMobil.TabIndex = 8
        Me.cbTypeMobil.ValueMember = "Type"
        '
        'MsMobilBindingSource
        '
        Me.MsMobilBindingSource.DataMember = "MsMobil"
        Me.MsMobilBindingSource.DataSource = Me.SHOWROOMDataSet
        '
        'SHOWROOMDataSet
        '
        Me.SHOWROOMDataSet.DataSetName = "SHOWROOMDataSet"
        Me.SHOWROOMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblType
        '
        Me.lblType.AllowDrop = True
        Me.lblType.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.SystemColors.Control
        Me.lblType.Location = New System.Drawing.Point(29, 212)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(148, 27)
        Me.lblType.TabIndex = 9
        Me.lblType.Text = "Type"
        '
        'SHOWROOMDataSetBindingSource
        '
        Me.SHOWROOMDataSetBindingSource.DataSource = Me.SHOWROOMDataSet
        Me.SHOWROOMDataSetBindingSource.Position = 0
        '
        'MsMobilTableAdapter
        '
        Me.MsMobilTableAdapter.ClearBeforeFill = True
        '
        'lblWarna
        '
        Me.lblWarna.AllowDrop = True
        Me.lblWarna.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblWarna.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarna.ForeColor = System.Drawing.SystemColors.Control
        Me.lblWarna.Location = New System.Drawing.Point(29, 292)
        Me.lblWarna.Name = "lblWarna"
        Me.lblWarna.Size = New System.Drawing.Size(148, 27)
        Me.lblWarna.TabIndex = 11
        Me.lblWarna.Text = "Color"
        '
        'cbWarna
        '
        Me.cbWarna.DataSource = Me.MsWarnaBindingSource
        Me.cbWarna.DisplayMember = "Warna"
        Me.cbWarna.FormattingEnabled = True
        Me.cbWarna.Location = New System.Drawing.Point(33, 323)
        Me.cbWarna.Name = "cbWarna"
        Me.cbWarna.Size = New System.Drawing.Size(202, 21)
        Me.cbWarna.TabIndex = 10
        Me.cbWarna.ValueMember = "Warna"
        '
        'MsWarnaBindingSource
        '
        Me.MsWarnaBindingSource.DataMember = "MsWarna"
        Me.MsWarnaBindingSource.DataSource = Me.SHOWROOMDataSetBindingSource
        '
        'MsWarnaTableAdapter
        '
        Me.MsWarnaTableAdapter.ClearBeforeFill = True
        '
        'MsMobilBindingSource1
        '
        Me.MsMobilBindingSource1.DataMember = "MsMobil"
        Me.MsMobilBindingSource1.DataSource = Me.SHOWROOMDataSetBindingSource
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ShowRoomMobilUAS.My.Resources.Resources.logoshowroom
        Me.PictureBox1.Location = New System.Drawing.Point(389, 229)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'BuyPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(832, 604)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblWarna)
        Me.Controls.Add(Me.cbWarna)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.cbTypeMobil)
        Me.Controls.Add(Me.lblMinimizeApp)
        Me.Controls.Add(Me.lblCloseApp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblKetentuan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuyPage"
        Me.Text = "BuyPage"
        CType(Me.MsMobilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHOWROOMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHOWROOMDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsWarnaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsMobilBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKetentuan As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblMinimizeApp As Label
    Friend WithEvents lblCloseApp As Label
    Friend WithEvents cbTypeMobil As ComboBox
    Friend WithEvents SHOWROOMDataSetBindingSource As BindingSource
    Friend WithEvents SHOWROOMDataSet As SHOWROOMDataSet
    Friend WithEvents lblType As Label
    Friend WithEvents MsMobilBindingSource As BindingSource
    Friend WithEvents MsMobilTableAdapter As SHOWROOMDataSetTableAdapters.MsMobilTableAdapter
    Friend WithEvents lblWarna As Label
    Friend WithEvents cbWarna As ComboBox
    Friend WithEvents MsWarnaBindingSource As BindingSource
    Friend WithEvents MsWarnaTableAdapter As SHOWROOMDataSetTableAdapters.MsWarnaTableAdapter
    Friend WithEvents MsMobilBindingSource1 As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
End Class
