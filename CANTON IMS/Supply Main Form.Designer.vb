<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Supply_Main_Form
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblheading = New System.Windows.Forms.Label()
        Me.lblMP = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLEARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblsuppno = New System.Windows.Forms.Label()
        Me.lblsuppname = New System.Windows.Forms.Label()
        Me.lblsuppph = New System.Windows.Forms.Label()
        Me.lblsuppaddr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.txtsuppEmail = New System.Windows.Forms.TextBox()
        Me.txtsuppname = New System.Windows.Forms.TextBox()
        Me.txtsuppno = New System.Windows.Forms.TextBox()
        Me.txtsuppPh = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VbimsdbDataSet = New CANTON_IMS.vbimsdbDataSet()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.SupplierTableAdapter = New CANTON_IMS.vbimsdbDataSetTableAdapters.SupplierTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VbimsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblheading)
        Me.Panel1.Controls.Add(Me.lblMP)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 100)
        Me.Panel1.TabIndex = 27
        '
        'lblheading
        '
        Me.lblheading.AutoSize = True
        Me.lblheading.BackColor = System.Drawing.Color.Transparent
        Me.lblheading.Font = New System.Drawing.Font("Century Gothic", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheading.ForeColor = System.Drawing.Color.Black
        Me.lblheading.Location = New System.Drawing.Point(150, 20)
        Me.lblheading.Name = "lblheading"
        Me.lblheading.Size = New System.Drawing.Size(152, 114)
        Me.lblheading.TabIndex = 2
        Me.lblheading.Text = "C R I M S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblMP
        '
        Me.lblMP.AutoSize = True
        Me.lblMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMP.ForeColor = System.Drawing.Color.Transparent
        Me.lblMP.Location = New System.Drawing.Point(377, 26)
        Me.lblMP.Name = "lblMP"
        Me.lblMP.Size = New System.Drawing.Size(217, 31)
        Me.lblMP.TabIndex = 3
        Me.lblMP.Text = "Manage Supplier"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.UPDATEToolStripMenuItem, Me.SEARCHToolStripMenuItem, Me.DELETEToolStripMenuItem2, Me.CLEARToolStripMenuItem, Me.MOREToolStripMenuItem, Me.CLOSEToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(803, 33)
        Me.MenuStrip2.TabIndex = 26
        Me.MenuStrip2.Text = "MenuStrip2"
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
        'SEARCHToolStripMenuItem
        '
        Me.SEARCHToolStripMenuItem.Name = "SEARCHToolStripMenuItem"
        Me.SEARCHToolStripMenuItem.Size = New System.Drawing.Size(94, 29)
        Me.SEARCHToolStripMenuItem.Text = "SEARCH"
        '
        'DELETEToolStripMenuItem2
        '
        Me.DELETEToolStripMenuItem2.Name = "DELETEToolStripMenuItem2"
        Me.DELETEToolStripMenuItem2.Size = New System.Drawing.Size(93, 29)
        Me.DELETEToolStripMenuItem2.Text = "DELETE "
        '
        'CLEARToolStripMenuItem
        '
        Me.CLEARToolStripMenuItem.Name = "CLEARToolStripMenuItem"
        Me.CLEARToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.CLEARToolStripMenuItem.Text = "CLEAR"
        '
        'MOREToolStripMenuItem
        '
        Me.MOREToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoryToolStripMenuItem, Me.NewUsersToolStripMenuItem, Me.NewOrderToolStripMenuItem, Me.NewSupplierToolStripMenuItem, Me.NewPurchaseToolStripMenuItem})
        Me.MOREToolStripMenuItem.Name = "MOREToolStripMenuItem"
        Me.MOREToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.MOREToolStripMenuItem.Text = "MORE"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.CategoryToolStripMenuItem.Text = "CATEGORY"
        '
        'NewUsersToolStripMenuItem
        '
        Me.NewUsersToolStripMenuItem.Name = "NewUsersToolStripMenuItem"
        Me.NewUsersToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.NewUsersToolStripMenuItem.Text = "USERS"
        '
        'NewOrderToolStripMenuItem
        '
        Me.NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem"
        Me.NewOrderToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.NewOrderToolStripMenuItem.Text = "ORDERS"
        '
        'NewSupplierToolStripMenuItem
        '
        Me.NewSupplierToolStripMenuItem.Name = "NewSupplierToolStripMenuItem"
        Me.NewSupplierToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.NewSupplierToolStripMenuItem.Text = "PURCHASE"
        '
        'NewPurchaseToolStripMenuItem
        '
        Me.NewPurchaseToolStripMenuItem.Name = "NewPurchaseToolStripMenuItem"
        Me.NewPurchaseToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.NewPurchaseToolStripMenuItem.Text = "PRODUCT"
        '
        'CLOSEToolStripMenuItem
        '
        Me.CLOSEToolStripMenuItem.Name = "CLOSEToolStripMenuItem"
        Me.CLOSEToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.CLOSEToolStripMenuItem.Text = "CLOSE"
        '
        'lblsuppno
        '
        Me.lblsuppno.AutoSize = True
        Me.lblsuppno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuppno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsuppno.Location = New System.Drawing.Point(20, 164)
        Me.lblsuppno.Name = "lblsuppno"
        Me.lblsuppno.Size = New System.Drawing.Size(125, 25)
        Me.lblsuppno.TabIndex = 29
        Me.lblsuppno.Text = "Supplier No: "
        '
        'lblsuppname
        '
        Me.lblsuppname.AutoSize = True
        Me.lblsuppname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuppname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsuppname.Location = New System.Drawing.Point(312, 168)
        Me.lblsuppname.Name = "lblsuppname"
        Me.lblsuppname.Size = New System.Drawing.Size(147, 25)
        Me.lblsuppname.TabIndex = 30
        Me.lblsuppname.Text = "Supplier Name:"
        '
        'lblsuppph
        '
        Me.lblsuppph.AutoSize = True
        Me.lblsuppph.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuppph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsuppph.Location = New System.Drawing.Point(26, 236)
        Me.lblsuppph.Name = "lblsuppph"
        Me.lblsuppph.Size = New System.Drawing.Size(119, 25)
        Me.lblsuppph.TabIndex = 31
        Me.lblsuppph.Text = "Supplier Ph:"
        '
        'lblsuppaddr
        '
        Me.lblsuppaddr.AutoSize = True
        Me.lblsuppaddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuppaddr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsuppaddr.Location = New System.Drawing.Point(20, 298)
        Me.lblsuppaddr.Name = "lblsuppaddr"
        Me.lblsuppaddr.Size = New System.Drawing.Size(168, 25)
        Me.lblsuppaddr.TabIndex = 32
        Me.lblsuppaddr.Text = "Supplier Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(312, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 25)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Supplier Email:"
        '
        'txtaddr
        '
        Me.txtaddr.Location = New System.Drawing.Point(194, 298)
        Me.txtaddr.Multiline = True
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(587, 31)
        Me.txtaddr.TabIndex = 34
        '
        'txtsuppEmail
        '
        Me.txtsuppEmail.Location = New System.Drawing.Point(465, 236)
        Me.txtsuppEmail.Multiline = True
        Me.txtsuppEmail.Name = "txtsuppEmail"
        Me.txtsuppEmail.Size = New System.Drawing.Size(307, 31)
        Me.txtsuppEmail.TabIndex = 35
        '
        'txtsuppname
        '
        Me.txtsuppname.Location = New System.Drawing.Point(465, 168)
        Me.txtsuppname.Multiline = True
        Me.txtsuppname.Name = "txtsuppname"
        Me.txtsuppname.Size = New System.Drawing.Size(307, 31)
        Me.txtsuppname.TabIndex = 36
        '
        'txtsuppno
        '
        Me.txtsuppno.Location = New System.Drawing.Point(165, 164)
        Me.txtsuppno.Multiline = True
        Me.txtsuppno.Name = "txtsuppno"
        Me.txtsuppno.Size = New System.Drawing.Size(124, 31)
        Me.txtsuppno.TabIndex = 37
        '
        'txtsuppPh
        '
        Me.txtsuppPh.Location = New System.Drawing.Point(165, 236)
        Me.txtsuppPh.Multiline = True
        Me.txtsuppPh.Name = "txtsuppPh"
        Me.txtsuppPh.Size = New System.Drawing.Size(124, 31)
        Me.txtsuppPh.TabIndex = 38
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(0, 362)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(803, 150)
        Me.DataGridView2.TabIndex = 39
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.VbimsdbDataSet
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
        Me.btnhome.Location = New System.Drawing.Point(351, 578)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(108, 35)
        Me.btnhome.TabIndex = 40
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Supply_Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(803, 625)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.txtsuppPh)
        Me.Controls.Add(Me.txtsuppno)
        Me.Controls.Add(Me.txtsuppname)
        Me.Controls.Add(Me.txtsuppEmail)
        Me.Controls.Add(Me.txtaddr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblsuppaddr)
        Me.Controls.Add(Me.lblsuppph)
        Me.Controls.Add(Me.lblsuppname)
        Me.Controls.Add(Me.lblsuppno)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Supply_Main_Form"
        Me.Text = "Supply_Main_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VbimsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblheading As Label
    Friend WithEvents lblMP As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MOREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewPurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLOSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblsuppno As Label
    Friend WithEvents lblsuppname As Label
    Friend WithEvents lblsuppph As Label
    Friend WithEvents lblsuppaddr As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtaddr As TextBox
    Friend WithEvents txtsuppEmail As TextBox
    Friend WithEvents txtsuppname As TextBox
    Friend WithEvents txtsuppno As TextBox
    Friend WithEvents txtsuppPh As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnhome As Button
    Friend WithEvents VbimsdbDataSet As vbimsdbDataSet
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As vbimsdbDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents SEARCHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLEARToolStripMenuItem As ToolStripMenuItem
End Class
