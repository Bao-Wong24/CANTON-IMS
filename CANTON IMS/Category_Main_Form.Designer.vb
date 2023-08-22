<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Category_Main_Form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblheading = New System.Windows.Forms.Label()
        Me.lblMC = New System.Windows.Forms.Label()
        Me.lblcat = New System.Windows.Forms.Label()
        Me.lblcatno = New System.Windows.Forms.Label()
        Me.CANTONIMS_DBDataSet1 = New CANTON_IMS.CANTONIMS_DBDataSet()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.VbimsdbDataSet = New CANTON_IMS.vbimsdbDataSet()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLEARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CATEGORYTableAdapter1 = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.CATEGORYTableAdapter()
        Me.cbcategorynum = New System.Windows.Forms.ComboBox()
        Me.cbcategory = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.CANTONIMS_DBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VbimsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblheading)
        Me.Panel1.Controls.Add(Me.lblMC)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 100)
        Me.Panel1.TabIndex = 27
        '
        'lblheading
        '
        Me.lblheading.AutoSize = True
        Me.lblheading.BackColor = System.Drawing.Color.Transparent
        Me.lblheading.Font = New System.Drawing.Font("Century Gothic", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheading.ForeColor = System.Drawing.Color.Black
        Me.lblheading.Location = New System.Drawing.Point(161, 20)
        Me.lblheading.Name = "lblheading"
        Me.lblheading.Size = New System.Drawing.Size(152, 114)
        Me.lblheading.TabIndex = 2
        Me.lblheading.Text = "C R I M S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblMC
        '
        Me.lblMC.AutoSize = True
        Me.lblMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMC.ForeColor = System.Drawing.Color.Transparent
        Me.lblMC.Location = New System.Drawing.Point(377, 26)
        Me.lblMC.Name = "lblMC"
        Me.lblMC.Size = New System.Drawing.Size(229, 31)
        Me.lblMC.TabIndex = 3
        Me.lblMC.Text = "Manage Category"
        '
        'lblcat
        '
        Me.lblcat.AutoSize = True
        Me.lblcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcat.Location = New System.Drawing.Point(404, 195)
        Me.lblcat.Name = "lblcat"
        Me.lblcat.Size = New System.Drawing.Size(103, 25)
        Me.lblcat.TabIndex = 29
        Me.lblcat.Text = "Category: "
        '
        'lblcatno
        '
        Me.lblcatno.AutoSize = True
        Me.lblcatno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcatno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcatno.Location = New System.Drawing.Point(52, 191)
        Me.lblcatno.Name = "lblcatno"
        Me.lblcatno.Size = New System.Drawing.Size(133, 25)
        Me.lblcatno.TabIndex = 28
        Me.lblcatno.Text = "Category No: "
        '
        'CANTONIMS_DBDataSet1
        '
        Me.CANTONIMS_DBDataSet1.DataSetName = "CANTONIMS_DBDataSet"
        Me.CANTONIMS_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(0, 263)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(767, 150)
        Me.DataGridView3.TabIndex = 33
        '
        'VbimsdbDataSet
        '
        Me.VbimsdbDataSet.DataSetName = "vbimsdbDataSet"
        Me.VbimsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnhome
        '
        Me.btnhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnhome.Location = New System.Drawing.Point(335, 463)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(108, 35)
        Me.btnhome.TabIndex = 34
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'ADDToolStripMenuItem
        '
        Me.ADDToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ADDToolStripMenuItem.Name = "ADDToolStripMenuItem"
        Me.ADDToolStripMenuItem.Size = New System.Drawing.Size(59, 29)
        Me.ADDToolStripMenuItem.Text = "ADD"
        '
        'UPDATEToolStripMenuItem
        '
        Me.UPDATEToolStripMenuItem.Name = "UPDATEToolStripMenuItem"
        Me.UPDATEToolStripMenuItem.Size = New System.Drawing.Size(94, 29)
        Me.UPDATEToolStripMenuItem.Text = "UPDATE"
        '
        'DELETEToolStripMenuItem2
        '
        Me.DELETEToolStripMenuItem2.Name = "DELETEToolStripMenuItem2"
        Me.DELETEToolStripMenuItem2.Size = New System.Drawing.Size(93, 29)
        Me.DELETEToolStripMenuItem2.Text = "DELETE "
        '
        'MOREToolStripMenuItem
        '
        Me.MOREToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUsersToolStripMenuItem, Me.NewOrderToolStripMenuItem, Me.NewSupplierToolStripMenuItem, Me.NewPurchaseToolStripMenuItem, Me.PRODUCTToolStripMenuItem})
        Me.MOREToolStripMenuItem.Name = "MOREToolStripMenuItem"
        Me.MOREToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.MOREToolStripMenuItem.Text = "MORE"
        '
        'NewUsersToolStripMenuItem
        '
        Me.NewUsersToolStripMenuItem.Name = "NewUsersToolStripMenuItem"
        Me.NewUsersToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.NewUsersToolStripMenuItem.Text = "USERS"
        '
        'NewOrderToolStripMenuItem
        '
        Me.NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem"
        Me.NewOrderToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.NewOrderToolStripMenuItem.Text = "ORDERS"
        '
        'NewSupplierToolStripMenuItem
        '
        Me.NewSupplierToolStripMenuItem.Name = "NewSupplierToolStripMenuItem"
        Me.NewSupplierToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.NewSupplierToolStripMenuItem.Text = "SUPPLIER"
        '
        'NewPurchaseToolStripMenuItem
        '
        Me.NewPurchaseToolStripMenuItem.Name = "NewPurchaseToolStripMenuItem"
        Me.NewPurchaseToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.NewPurchaseToolStripMenuItem.Text = "PURCHASE"
        '
        'PRODUCTToolStripMenuItem
        '
        Me.PRODUCTToolStripMenuItem.Name = "PRODUCTToolStripMenuItem"
        Me.PRODUCTToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.PRODUCTToolStripMenuItem.Text = "PRODUCT"
        '
        'CLOSEToolStripMenuItem
        '
        Me.CLOSEToolStripMenuItem.Name = "CLOSEToolStripMenuItem"
        Me.CLOSEToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.CLOSEToolStripMenuItem.Text = "CLOSE"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.UPDATEToolStripMenuItem, Me.SEARCHToolStripMenuItem, Me.DELETEToolStripMenuItem2, Me.CLEARToolStripMenuItem, Me.MOREToolStripMenuItem, Me.CLOSEToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(767, 33)
        Me.MenuStrip2.TabIndex = 26
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'SEARCHToolStripMenuItem
        '
        Me.SEARCHToolStripMenuItem.Name = "SEARCHToolStripMenuItem"
        Me.SEARCHToolStripMenuItem.Size = New System.Drawing.Size(94, 29)
        Me.SEARCHToolStripMenuItem.Text = "SEARCH"
        '
        'CLEARToolStripMenuItem
        '
        Me.CLEARToolStripMenuItem.Name = "CLEARToolStripMenuItem"
        Me.CLEARToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.CLEARToolStripMenuItem.Text = "CLEAR"
        '
        'CATEGORYTableAdapter1
        '
        Me.CATEGORYTableAdapter1.ClearBeforeFill = True
        '
        'cbcategorynum
        '
        Me.cbcategorynum.FormattingEnabled = True
        Me.cbcategorynum.Location = New System.Drawing.Point(191, 191)
        Me.cbcategorynum.Name = "cbcategorynum"
        Me.cbcategorynum.Size = New System.Drawing.Size(121, 24)
        Me.cbcategorynum.TabIndex = 35
        '
        'cbcategory
        '
        Me.cbcategory.FormattingEnabled = True
        Me.cbcategory.Location = New System.Drawing.Point(504, 196)
        Me.cbcategory.Name = "cbcategory"
        Me.cbcategory.Size = New System.Drawing.Size(121, 24)
        Me.cbcategory.TabIndex = 36
        '
        'Category_Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(767, 536)
        Me.Controls.Add(Me.cbcategory)
        Me.Controls.Add(Me.cbcategorynum)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.lblcat)
        Me.Controls.Add(Me.lblcatno)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Category_Main_Form"
        Me.Text = "Category_Main_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CANTONIMS_DBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VbimsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblheading As Label
    Friend WithEvents lblMC As Label
    Friend WithEvents lblcat As Label
    Friend WithEvents lblcatno As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents btnhome As Button
    Friend WithEvents VbimsdbDataSet As vbimsdbDataSet
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MOREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewPurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLOSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents SEARCHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLEARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUCTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CANTONIMS_DBDataSet As CANTONIMS_DBDataSet
    Friend WithEvents CATEGORYTableAdapter As CANTONIMS_DBDataSetTableAdapters.CATEGORYTableAdapter
    Friend WithEvents PRODUCTTableAdapter As CANTONIMS_DBDataSetTableAdapters.PRODUCTTableAdapter
    Friend WithEvents CANTONIMS_DBDataSet1 As CANTONIMS_DBDataSet
    Friend WithEvents CATEGORYTableAdapter1 As CANTONIMS_DBDataSetTableAdapters.CATEGORYTableAdapter
    Friend WithEvents cbcategorynum As ComboBox
    Friend WithEvents cbcategory As ComboBox
End Class
