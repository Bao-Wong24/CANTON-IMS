<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Purchase_Main_Form
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
        Me.txtpurchno = New System.Windows.Forms.TextBox()
        Me.lblpurchdate = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.lblpurchuser = New System.Windows.Forms.Label()
        Me.cbpurchuser = New System.Windows.Forms.ComboBox()
        Me.USERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CANTONIMS_DBDataSet = New CANTON_IMS.CANTONIMS_DBDataSet()
        Me.lblpurordno = New System.Windows.Forms.Label()
        Me.cbpurchordNum = New System.Windows.Forms.ComboBox()
        Me.ORDERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbpurprodnum = New System.Windows.Forms.ComboBox()
        Me.PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblpurprod = New System.Windows.Forms.Label()
        Me.lblpuruserph = New System.Windows.Forms.Label()
        Me.cbpurchPhone = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbpurchsuppnum = New System.Windows.Forms.ComboBox()
        Me.SUPPLIERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnhome = New System.Windows.Forms.Button()
        Me.lblpurchqty = New System.Windows.Forms.Label()
        Me.cbpurchqty = New System.Windows.Forms.ComboBox()
        Me.cbpurchordcost = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltotalcst = New System.Windows.Forms.Label()
        Me.lblpurchNo = New System.Windows.Forms.Label()
        Me.cbpurchUOM = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.USERSTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.USERSTableAdapter()
        Me.ORDERSTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.ORDERSTableAdapter()
        Me.SUPPLIERTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.SUPPLIERTableAdapter()
        Me.PRODUCTTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.PRODUCTTableAdapter()
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
        Me.CATEGORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPPLIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbpurchTotalCost = New System.Windows.Forms.ComboBox()
        Me.ORDERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANTONIMS_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPPLIERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtpurchno
        '
        Me.txtpurchno.Location = New System.Drawing.Point(126, 192)
        Me.txtpurchno.Multiline = True
        Me.txtpurchno.Name = "txtpurchno"
        Me.txtpurchno.Size = New System.Drawing.Size(100, 25)
        Me.txtpurchno.TabIndex = 49
        '
        'lblpurchdate
        '
        Me.lblpurchdate.AutoSize = True
        Me.lblpurchdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurchdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpurchdate.Location = New System.Drawing.Point(657, 338)
        Me.lblpurchdate.Name = "lblpurchdate"
        Me.lblpurchdate.Size = New System.Drawing.Size(64, 25)
        Me.lblpurchdate.TabIndex = 50
        Me.lblpurchdate.Text = "Date: "
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(739, 341)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker3.TabIndex = 59
        Me.DateTimePicker3.Value = New Date(2022, 11, 10, 0, 0, 0, 0)
        '
        'lblpurchuser
        '
        Me.lblpurchuser.AutoSize = True
        Me.lblpurchuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurchuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpurchuser.Location = New System.Drawing.Point(234, 192)
        Me.lblpurchuser.Name = "lblpurchuser"
        Me.lblpurchuser.Size = New System.Drawing.Size(96, 25)
        Me.lblpurchuser.TabIndex = 60
        Me.lblpurchuser.Text = "User TIN:"
        '
        'cbpurchuser
        '
        Me.cbpurchuser.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.USERSBindingSource, "UserTINno", True))
        Me.cbpurchuser.DataSource = Me.USERSBindingSource
        Me.cbpurchuser.DisplayMember = "UserTINno"
        Me.cbpurchuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpurchuser.FormattingEnabled = True
        Me.cbpurchuser.Location = New System.Drawing.Point(336, 192)
        Me.cbpurchuser.Name = "cbpurchuser"
        Me.cbpurchuser.Size = New System.Drawing.Size(93, 24)
        Me.cbpurchuser.TabIndex = 61
        Me.cbpurchuser.ValueMember = "UserTINno"
        '
        'USERSBindingSource
        '
        Me.USERSBindingSource.DataMember = "USERS"
        Me.USERSBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'CANTONIMS_DBDataSet
        '
        Me.CANTONIMS_DBDataSet.DataSetName = "CANTONIMS_DBDataSet"
        Me.CANTONIMS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblpurordno
        '
        Me.lblpurordno.AutoSize = True
        Me.lblpurordno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurordno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpurordno.Location = New System.Drawing.Point(698, 190)
        Me.lblpurordno.Name = "lblpurordno"
        Me.lblpurordno.Size = New System.Drawing.Size(99, 24)
        Me.lblpurordno.TabIndex = 65
        Me.lblpurordno.Text = "Order No: "
        '
        'cbpurchordNum
        '
        Me.cbpurchordNum.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ORDERSBindingSource, "OrdNo", True))
        Me.cbpurchordNum.DataSource = Me.ORDERSBindingSource
        Me.cbpurchordNum.DisplayMember = "OrdNo"
        Me.cbpurchordNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpurchordNum.FormattingEnabled = True
        Me.cbpurchordNum.Location = New System.Drawing.Point(809, 192)
        Me.cbpurchordNum.Name = "cbpurchordNum"
        Me.cbpurchordNum.Size = New System.Drawing.Size(93, 24)
        Me.cbpurchordNum.TabIndex = 74
        Me.cbpurchordNum.ValueMember = "OrdNo"
        '
        'ORDERSBindingSource
        '
        Me.ORDERSBindingSource.DataMember = "ORDERS"
        Me.ORDERSBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'cbpurprodnum
        '
        Me.cbpurprodnum.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PRODUCTBindingSource, "ProdNo", True))
        Me.cbpurprodnum.DataSource = Me.PRODUCTBindingSource
        Me.cbpurprodnum.DisplayMember = "ProdNo"
        Me.cbpurprodnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpurprodnum.FormattingEnabled = True
        Me.cbpurprodnum.Location = New System.Drawing.Point(367, 268)
        Me.cbpurprodnum.Name = "cbpurprodnum"
        Me.cbpurprodnum.Size = New System.Drawing.Size(122, 24)
        Me.cbpurprodnum.TabIndex = 76
        Me.cbpurprodnum.ValueMember = "ProdNo"
        '
        'PRODUCTBindingSource
        '
        Me.PRODUCTBindingSource.DataMember = "PRODUCT"
        Me.PRODUCTBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'lblpurprod
        '
        Me.lblpurprod.AutoSize = True
        Me.lblpurprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurprod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpurprod.Location = New System.Drawing.Point(251, 268)
        Me.lblpurprod.Name = "lblpurprod"
        Me.lblpurprod.Size = New System.Drawing.Size(110, 24)
        Me.lblpurprod.TabIndex = 75
        Me.lblpurprod.Text = "Product No:"
        '
        'lblpuruserph
        '
        Me.lblpuruserph.AutoSize = True
        Me.lblpuruserph.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpuruserph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpuruserph.Location = New System.Drawing.Point(444, 193)
        Me.lblpuruserph.Name = "lblpuruserph"
        Me.lblpuruserph.Size = New System.Drawing.Size(80, 25)
        Me.lblpuruserph.TabIndex = 78
        Me.lblpuruserph.Text = "Phone: "
        '
        'cbpurchPhone
        '
        Me.cbpurchPhone.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.USERSBindingSource, "Phone", True))
        Me.cbpurchPhone.DataSource = Me.USERSBindingSource
        Me.cbpurchPhone.DisplayMember = "Phone"
        Me.cbpurchPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpurchPhone.FormattingEnabled = True
        Me.cbpurchPhone.Location = New System.Drawing.Point(530, 193)
        Me.cbpurchPhone.Name = "cbpurchPhone"
        Me.cbpurchPhone.Size = New System.Drawing.Size(102, 24)
        Me.cbpurchPhone.TabIndex = 79
        Me.cbpurchPhone.ValueMember = "Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(38, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 24)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Supplier No:"
        '
        'cbpurchsuppnum
        '
        Me.cbpurchsuppnum.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SUPPLIERBindingSource, "SuppNo", True))
        Me.cbpurchsuppnum.DataSource = Me.SUPPLIERBindingSource
        Me.cbpurchsuppnum.DisplayMember = "SuppNo"
        Me.cbpurchsuppnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpurchsuppnum.FormattingEnabled = True
        Me.cbpurchsuppnum.Location = New System.Drawing.Point(153, 266)
        Me.cbpurchsuppnum.Name = "cbpurchsuppnum"
        Me.cbpurchsuppnum.Size = New System.Drawing.Size(92, 24)
        Me.cbpurchsuppnum.TabIndex = 89
        Me.cbpurchsuppnum.ValueMember = "SuppNo"
        '
        'SUPPLIERBindingSource
        '
        Me.SUPPLIERBindingSource.DataMember = "SUPPLIER"
        Me.SUPPLIERBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'btnhome
        '
        Me.btnhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnhome.Location = New System.Drawing.Point(464, 638)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(108, 35)
        Me.btnhome.TabIndex = 91
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'lblpurchqty
        '
        Me.lblpurchqty.AutoSize = True
        Me.lblpurchqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurchqty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpurchqty.Location = New System.Drawing.Point(771, 268)
        Me.lblpurchqty.Name = "lblpurchqty"
        Me.lblpurchqty.Size = New System.Drawing.Size(88, 24)
        Me.lblpurchqty.TabIndex = 93
        Me.lblpurchqty.Text = "Quantity: "
        '
        'cbpurchqty
        '
        Me.cbpurchqty.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ORDERSBindingSource, "OrdQty", True))
        Me.cbpurchqty.DataSource = Me.ORDERSBindingSource
        Me.cbpurchqty.DisplayMember = "OrdQty"
        Me.cbpurchqty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpurchqty.FormattingEnabled = True
        Me.cbpurchqty.Location = New System.Drawing.Point(874, 266)
        Me.cbpurchqty.Name = "cbpurchqty"
        Me.cbpurchqty.Size = New System.Drawing.Size(96, 24)
        Me.cbpurchqty.TabIndex = 94
        Me.cbpurchqty.ValueMember = "OrdQty"
        '
        'cbpurchordcost
        '
        Me.cbpurchordcost.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ORDERSBindingSource, "OrdSubTotal", True))
        Me.cbpurchordcost.DataSource = Me.ORDERSBindingSource
        Me.cbpurchordcost.DisplayMember = "OrdSubTotal"
        Me.cbpurchordcost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpurchordcost.FormattingEnabled = True
        Me.cbpurchordcost.Location = New System.Drawing.Point(133, 349)
        Me.cbpurchordcost.Name = "cbpurchordcost"
        Me.cbpurchordcost.Size = New System.Drawing.Size(93, 24)
        Me.cbpurchordcost.TabIndex = 95
        Me.cbpurchordcost.ValueMember = "OrdSubTotal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(51, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 24)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "COST:"
        '
        'lbltotalcst
        '
        Me.lbltotalcst.AutoSize = True
        Me.lbltotalcst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalcst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbltotalcst.Location = New System.Drawing.Point(253, 345)
        Me.lbltotalcst.Name = "lbltotalcst"
        Me.lbltotalcst.Size = New System.Drawing.Size(205, 24)
        Me.lbltotalcst.TabIndex = 98
        Me.lbltotalcst.Text = "TOTAL COST (+VAT): "
        '
        'lblpurchNo
        '
        Me.lblpurchNo.AutoSize = True
        Me.lblpurchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurchNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpurchNo.Location = New System.Drawing.Point(62, 192)
        Me.lblpurchNo.Name = "lblpurchNo"
        Me.lblpurchNo.Size = New System.Drawing.Size(45, 24)
        Me.lblpurchNo.TabIndex = 32
        Me.lblpurchNo.Text = "No: "
        '
        'cbpurchUOM
        '
        Me.cbpurchUOM.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PRODUCTBindingSource, "ProdUOM", True))
        Me.cbpurchUOM.DataSource = Me.PRODUCTBindingSource
        Me.cbpurchUOM.DisplayMember = "ProdUOM"
        Me.cbpurchUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpurchUOM.FormattingEnabled = True
        Me.cbpurchUOM.Location = New System.Drawing.Point(662, 264)
        Me.cbpurchUOM.Name = "cbpurchUOM"
        Me.cbpurchUOM.Size = New System.Drawing.Size(85, 24)
        Me.cbpurchUOM.TabIndex = 86
        Me.cbpurchUOM.ValueMember = "ProdUOM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(526, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 24)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Unit of Measure"
        '
        'DataGridView6
        '
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(0, 391)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.RowHeadersWidth = 51
        Me.DataGridView6.RowTemplate.Height = 24
        Me.DataGridView6.Size = New System.Drawing.Size(1022, 150)
        Me.DataGridView6.TabIndex = 100
        '
        'USERSTableAdapter
        '
        Me.USERSTableAdapter.ClearBeforeFill = True
        '
        'ORDERSTableAdapter
        '
        Me.ORDERSTableAdapter.ClearBeforeFill = True
        '
        'SUPPLIERTableAdapter
        '
        Me.SUPPLIERTableAdapter.ClearBeforeFill = True
        '
        'PRODUCTTableAdapter
        '
        Me.PRODUCTTableAdapter.ClearBeforeFill = True
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
        Me.Panel1.Size = New System.Drawing.Size(1022, 100)
        Me.Panel1.TabIndex = 102
        '
        'lblheading
        '
        Me.lblheading.AutoSize = True
        Me.lblheading.BackColor = System.Drawing.Color.Transparent
        Me.lblheading.Font = New System.Drawing.Font("Century Gothic", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheading.ForeColor = System.Drawing.Color.Black
        Me.lblheading.Location = New System.Drawing.Point(228, 20)
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
        Me.lblMP.Location = New System.Drawing.Point(417, 26)
        Me.lblMP.Name = "lblMP"
        Me.lblMP.Size = New System.Drawing.Size(247, 31)
        Me.lblMP.TabIndex = 3
        Me.lblMP.Text = "Manage Purchases"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.UPDATEToolStripMenuItem, Me.SEARCHToolStripMenuItem, Me.DELETEToolStripMenuItem2, Me.CLEARToolStripMenuItem, Me.MOREToolStripMenuItem, Me.CLOSEToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1022, 33)
        Me.MenuStrip2.TabIndex = 101
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
        Me.MOREToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CATEGORYToolStripMenuItem, Me.SUPPLIERToolStripMenuItem, Me.USERSToolStripMenuItem, Me.PRODUCTToolStripMenuItem, Me.ORDERSToolStripMenuItem})
        Me.MOREToolStripMenuItem.Name = "MOREToolStripMenuItem"
        Me.MOREToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.MOREToolStripMenuItem.Text = "MORE"
        '
        'CATEGORYToolStripMenuItem
        '
        Me.CATEGORYToolStripMenuItem.Name = "CATEGORYToolStripMenuItem"
        Me.CATEGORYToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.CATEGORYToolStripMenuItem.Text = "CATEGORY"
        '
        'SUPPLIERToolStripMenuItem
        '
        Me.SUPPLIERToolStripMenuItem.Name = "SUPPLIERToolStripMenuItem"
        Me.SUPPLIERToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.SUPPLIERToolStripMenuItem.Text = "SUPPLIER"
        '
        'USERSToolStripMenuItem
        '
        Me.USERSToolStripMenuItem.Name = "USERSToolStripMenuItem"
        Me.USERSToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.USERSToolStripMenuItem.Text = "USERS"
        '
        'PRODUCTToolStripMenuItem
        '
        Me.PRODUCTToolStripMenuItem.Name = "PRODUCTToolStripMenuItem"
        Me.PRODUCTToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.PRODUCTToolStripMenuItem.Text = "PRODUCT"
        '
        'CLOSEToolStripMenuItem
        '
        Me.CLOSEToolStripMenuItem.Name = "CLOSEToolStripMenuItem"
        Me.CLOSEToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.CLOSEToolStripMenuItem.Text = "CLOSE"
        '
        'cbpurchTotalCost
        '
        Me.cbpurchTotalCost.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ORDERSBindingSource, "OrdTotalPrice", True))
        Me.cbpurchTotalCost.DataSource = Me.ORDERSBindingSource
        Me.cbpurchTotalCost.DisplayMember = "OrdTotalPrice"
        Me.cbpurchTotalCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpurchTotalCost.FormattingEnabled = True
        Me.cbpurchTotalCost.Location = New System.Drawing.Point(464, 344)
        Me.cbpurchTotalCost.Name = "cbpurchTotalCost"
        Me.cbpurchTotalCost.Size = New System.Drawing.Size(99, 24)
        Me.cbpurchTotalCost.TabIndex = 104
        Me.cbpurchTotalCost.ValueMember = "OrdTotalPrice"
        '
        'ORDERSToolStripMenuItem
        '
        Me.ORDERSToolStripMenuItem.Name = "ORDERSToolStripMenuItem"
        Me.ORDERSToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.ORDERSToolStripMenuItem.Text = "ORDERS"
        '
        'Purchase_Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1022, 754)
        Me.Controls.Add(Me.cbpurchTotalCost)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.DataGridView6)
        Me.Controls.Add(Me.lbltotalcst)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbpurchordcost)
        Me.Controls.Add(Me.cbpurchqty)
        Me.Controls.Add(Me.lblpurchqty)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.cbpurchsuppnum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbpurchUOM)
        Me.Controls.Add(Me.cbpurchPhone)
        Me.Controls.Add(Me.lblpuruserph)
        Me.Controls.Add(Me.cbpurprodnum)
        Me.Controls.Add(Me.lblpurprod)
        Me.Controls.Add(Me.cbpurchordNum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblpurordno)
        Me.Controls.Add(Me.cbpurchuser)
        Me.Controls.Add(Me.lblpurchuser)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.lblpurchdate)
        Me.Controls.Add(Me.txtpurchno)
        Me.Controls.Add(Me.lblpurchNo)
        Me.Name = "Purchase_Main_Form"
        Me.Text = "Purchase_Main_Form"
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANTONIMS_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPPLIERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpurchno As TextBox
    Friend WithEvents lblpurchdate As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents lblpurchuser As Label
    Friend WithEvents cbpurchuser As ComboBox
    Friend WithEvents lblpurordno As Label
    Friend WithEvents cbpurchordNum As ComboBox
    Friend WithEvents cbpurprodnum As ComboBox
    Friend WithEvents lblpurprod As Label
    Friend WithEvents lblpuruserph As Label
    Friend WithEvents cbpurchPhone As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbpurchsuppnum As ComboBox
    Friend WithEvents btnhome As Button
    Friend WithEvents lblpurchqty As Label
    Friend WithEvents cbpurchqty As ComboBox
    Friend WithEvents cbpurchordcost As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbltotalcst As Label
    Friend WithEvents lblpurchNo As Label
    Friend WithEvents cbpurchUOM As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents CANTONIMS_DBDataSet As CANTONIMS_DBDataSet
    Friend WithEvents USERSBindingSource As BindingSource
    Friend WithEvents USERSTableAdapter As CANTONIMS_DBDataSetTableAdapters.USERSTableAdapter
    Friend WithEvents ORDERSBindingSource As BindingSource
    Friend WithEvents ORDERSTableAdapter As CANTONIMS_DBDataSetTableAdapters.ORDERSTableAdapter
    Friend WithEvents SUPPLIERBindingSource As BindingSource
    Friend WithEvents SUPPLIERTableAdapter As CANTONIMS_DBDataSetTableAdapters.SUPPLIERTableAdapter
    Friend WithEvents PRODUCTBindingSource As BindingSource
    Friend WithEvents PRODUCTTableAdapter As CANTONIMS_DBDataSetTableAdapters.PRODUCTTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblheading As Label
    Friend WithEvents lblMP As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CLEARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CATEGORYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPPLIERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUCTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLOSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbpurchTotalCost As ComboBox
    Friend WithEvents ORDERSToolStripMenuItem As ToolStripMenuItem
End Class
