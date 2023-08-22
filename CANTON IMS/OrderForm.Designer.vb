<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblheading = New System.Windows.Forms.Label()
        Me.lblMO = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FUNCTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLEARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CATEGORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPPLIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PURCHASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbOrdNum = New System.Windows.Forms.TextBox()
        Me.lblOrdNo = New System.Windows.Forms.Label()
        Me.cbordsuppnum = New System.Windows.Forms.ComboBox()
        Me.SUPPLIERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CANTONIMS_DBDataSet = New CANTON_IMS.CANTONIMS_DBDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbordprodnum = New System.Windows.Forms.ComboBox()
        Me.PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbOrdQty = New System.Windows.Forms.TextBox()
        Me.lblordqty = New System.Windows.Forms.Label()
        Me.cbordcatnum = New System.Windows.Forms.ComboBox()
        Me.CATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbordprice = New System.Windows.Forms.ComboBox()
        Me.TbVat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbST = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbTP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbordPhone = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cborduseTIN = New System.Windows.Forms.ComboBox()
        Me.USERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.btnProdHome = New System.Windows.Forms.Button()
        Me.SUPPLIERTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.SUPPLIERTableAdapter()
        Me.PRODUCTTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.PRODUCTTableAdapter()
        Me.CATEGORYTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.CATEGORYTableAdapter()
        Me.USERSTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.USERSTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.SUPPLIERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANTONIMS_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblheading)
        Me.Panel1.Controls.Add(Me.lblMO)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 100)
        Me.Panel1.TabIndex = 31
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
        'lblMO
        '
        Me.lblMO.AutoSize = True
        Me.lblMO.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMO.ForeColor = System.Drawing.Color.Transparent
        Me.lblMO.Location = New System.Drawing.Point(417, 26)
        Me.lblMO.Name = "lblMO"
        Me.lblMO.Size = New System.Drawing.Size(187, 31)
        Me.lblMO.TabIndex = 3
        Me.lblMO.Text = "Manage Order"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.UPDATEToolStripMenuItem, Me.SEARCHToolStripMenuItem, Me.DELETEToolStripMenuItem2, Me.FUNCTIONToolStripMenuItem, Me.CLEARToolStripMenuItem, Me.MOREToolStripMenuItem, Me.CLOSEToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(981, 33)
        Me.MenuStrip2.TabIndex = 30
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
        'FUNCTIONToolStripMenuItem
        '
        Me.FUNCTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULATEToolStripMenuItem})
        Me.FUNCTIONToolStripMenuItem.Name = "FUNCTIONToolStripMenuItem"
        Me.FUNCTIONToolStripMenuItem.Size = New System.Drawing.Size(117, 29)
        Me.FUNCTIONToolStripMenuItem.Text = "FUNCTION"
        '
        'CALCULATEToolStripMenuItem
        '
        Me.CALCULATEToolStripMenuItem.Name = "CALCULATEToolStripMenuItem"
        Me.CALCULATEToolStripMenuItem.Size = New System.Drawing.Size(196, 30)
        Me.CALCULATEToolStripMenuItem.Text = "CALCULATE"
        '
        'CLEARToolStripMenuItem
        '
        Me.CLEARToolStripMenuItem.Name = "CLEARToolStripMenuItem"
        Me.CLEARToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.CLEARToolStripMenuItem.Text = "CLEAR"
        '
        'MOREToolStripMenuItem
        '
        Me.MOREToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CATEGORYToolStripMenuItem, Me.SUPPLIERToolStripMenuItem, Me.PURCHASEToolStripMenuItem, Me.USERSToolStripMenuItem, Me.PRODUCTToolStripMenuItem})
        Me.MOREToolStripMenuItem.Name = "MOREToolStripMenuItem"
        Me.MOREToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.MOREToolStripMenuItem.Text = "MORE"
        '
        'CATEGORYToolStripMenuItem
        '
        Me.CATEGORYToolStripMenuItem.Name = "CATEGORYToolStripMenuItem"
        Me.CATEGORYToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.CATEGORYToolStripMenuItem.Text = "CATEGORY"
        '
        'SUPPLIERToolStripMenuItem
        '
        Me.SUPPLIERToolStripMenuItem.Name = "SUPPLIERToolStripMenuItem"
        Me.SUPPLIERToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.SUPPLIERToolStripMenuItem.Text = "SUPPLIER"
        '
        'PURCHASEToolStripMenuItem
        '
        Me.PURCHASEToolStripMenuItem.Name = "PURCHASEToolStripMenuItem"
        Me.PURCHASEToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.PURCHASEToolStripMenuItem.Text = "PURCHASE"
        '
        'USERSToolStripMenuItem
        '
        Me.USERSToolStripMenuItem.Name = "USERSToolStripMenuItem"
        Me.USERSToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.USERSToolStripMenuItem.Text = "USERS"
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
        'TbOrdNum
        '
        Me.TbOrdNum.Location = New System.Drawing.Point(85, 181)
        Me.TbOrdNum.Name = "TbOrdNum"
        Me.TbOrdNum.Size = New System.Drawing.Size(100, 22)
        Me.TbOrdNum.TabIndex = 33
        '
        'lblOrdNo
        '
        Me.lblOrdNo.AutoSize = True
        Me.lblOrdNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdNo.Location = New System.Drawing.Point(36, 181)
        Me.lblOrdNo.Name = "lblOrdNo"
        Me.lblOrdNo.Size = New System.Drawing.Size(43, 25)
        Me.lblOrdNo.TabIndex = 32
        Me.lblOrdNo.Text = "No:"
        '
        'cbordsuppnum
        '
        Me.cbordsuppnum.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SUPPLIERBindingSource, "SuppNo", True))
        Me.cbordsuppnum.DataSource = Me.SUPPLIERBindingSource
        Me.cbordsuppnum.DisplayMember = "SuppNo"
        Me.cbordsuppnum.FormattingEnabled = True
        Me.cbordsuppnum.Location = New System.Drawing.Point(315, 178)
        Me.cbordsuppnum.Name = "cbordsuppnum"
        Me.cbordsuppnum.Size = New System.Drawing.Size(121, 24)
        Me.cbordsuppnum.TabIndex = 39
        Me.cbordsuppnum.ValueMember = "SuppNo"
        '
        'SUPPLIERBindingSource
        '
        Me.SUPPLIERBindingSource.DataMember = "SUPPLIER"
        Me.SUPPLIERBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'CANTONIMS_DBDataSet
        '
        Me.CANTONIMS_DBDataSet.DataSetName = "CANTONIMS_DBDataSet"
        Me.CANTONIMS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Supply No:"
        '
        'cbordprodnum
        '
        Me.cbordprodnum.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PRODUCTBindingSource, "ProdNo", True))
        Me.cbordprodnum.DataSource = Me.PRODUCTBindingSource
        Me.cbordprodnum.DisplayMember = "ProdNo"
        Me.cbordprodnum.FormattingEnabled = True
        Me.cbordprodnum.Location = New System.Drawing.Point(567, 177)
        Me.cbordprodnum.Name = "cbordprodnum"
        Me.cbordprodnum.Size = New System.Drawing.Size(121, 24)
        Me.cbordprodnum.TabIndex = 43
        Me.cbordprodnum.ValueMember = "ProdNo"
        '
        'PRODUCTBindingSource
        '
        Me.PRODUCTBindingSource.DataMember = "PRODUCT"
        Me.PRODUCTBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(455, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Product No:"
        '
        'TbOrdQty
        '
        Me.TbOrdQty.Location = New System.Drawing.Point(118, 250)
        Me.TbOrdQty.Name = "TbOrdQty"
        Me.TbOrdQty.Size = New System.Drawing.Size(100, 22)
        Me.TbOrdQty.TabIndex = 41
        '
        'lblordqty
        '
        Me.lblordqty.AutoSize = True
        Me.lblordqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblordqty.Location = New System.Drawing.Point(36, 250)
        Me.lblordqty.Name = "lblordqty"
        Me.lblordqty.Size = New System.Drawing.Size(85, 25)
        Me.lblordqty.TabIndex = 40
        Me.lblordqty.Text = "Quantity"
        '
        'cbordcatnum
        '
        Me.cbordcatnum.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CATEGORYBindingSource, "CatNo", True))
        Me.cbordcatnum.DataSource = Me.CATEGORYBindingSource
        Me.cbordcatnum.DisplayMember = "CatNo"
        Me.cbordcatnum.FormattingEnabled = True
        Me.cbordcatnum.Location = New System.Drawing.Point(834, 174)
        Me.cbordcatnum.Name = "cbordcatnum"
        Me.cbordcatnum.Size = New System.Drawing.Size(121, 24)
        Me.cbordcatnum.TabIndex = 47
        Me.cbordcatnum.ValueMember = "CatNo"
        '
        'CATEGORYBindingSource
        '
        Me.CATEGORYBindingSource.DataMember = "CATEGORY"
        Me.CATEGORYBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(700, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 25)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Category No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Price:"
        '
        'cbordprice
        '
        Me.cbordprice.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PRODUCTBindingSource, "ProdUnitPrice", True))
        Me.cbordprice.DataSource = Me.PRODUCTBindingSource
        Me.cbordprice.DisplayMember = "ProdUnitPrice"
        Me.cbordprice.FormattingEnabled = True
        Me.cbordprice.Location = New System.Drawing.Point(315, 248)
        Me.cbordprice.Name = "cbordprice"
        Me.cbordprice.Size = New System.Drawing.Size(121, 24)
        Me.cbordprice.TabIndex = 49
        Me.cbordprice.ValueMember = "ProdUnitPrice"
        '
        'TbVat
        '
        Me.TbVat.Location = New System.Drawing.Point(794, 250)
        Me.TbVat.Name = "TbVat"
        Me.TbVat.Size = New System.Drawing.Size(100, 22)
        Me.TbVat.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(741, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 25)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "VAT:"
        '
        'TbST
        '
        Me.TbST.Location = New System.Drawing.Point(588, 248)
        Me.TbST.Name = "TbST"
        Me.TbST.Size = New System.Drawing.Size(100, 22)
        Me.TbST.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(479, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 25)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Sub Total:"
        '
        'TbTP
        '
        Me.TbTP.Location = New System.Drawing.Point(144, 332)
        Me.TbTP.Name = "TbTP"
        Me.TbTP.Size = New System.Drawing.Size(100, 22)
        Me.TbTP.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 25)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Total Price:"
        '
        'cbordPhone
        '
        Me.cbordPhone.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SUPPLIERBindingSource, "SuppPhone", True))
        Me.cbordPhone.DataSource = Me.SUPPLIERBindingSource
        Me.cbordPhone.DisplayMember = "SuppPhone"
        Me.cbordPhone.FormattingEnabled = True
        Me.cbordPhone.Location = New System.Drawing.Point(375, 330)
        Me.cbordPhone.Name = "cbordPhone"
        Me.cbordPhone.Size = New System.Drawing.Size(121, 24)
        Me.cbordPhone.TabIndex = 57
        Me.cbordPhone.ValueMember = "SuppPhone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(283, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 25)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Contact:"
        '
        'cborduseTIN
        '
        Me.cborduseTIN.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.USERSBindingSource, "UserTINno", True))
        Me.cborduseTIN.DataSource = Me.USERSBindingSource
        Me.cborduseTIN.DisplayMember = "UserTINno"
        Me.cborduseTIN.FormattingEnabled = True
        Me.cborduseTIN.Location = New System.Drawing.Point(555, 328)
        Me.cborduseTIN.Name = "cborduseTIN"
        Me.cborduseTIN.Size = New System.Drawing.Size(121, 24)
        Me.cborduseTIN.TabIndex = 59
        Me.cborduseTIN.ValueMember = "UserTINno"
        '
        'USERSBindingSource
        '
        Me.USERSBindingSource.DataMember = "USERS"
        Me.USERSBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(513, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 25)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "TIN:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(755, 326)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 61
        Me.DateTimePicker2.Value = New Date(2022, 11, 9, 23, 34, 43, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(696, 326)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 25)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Date"
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(0, 389)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(981, 185)
        Me.DataGridView5.TabIndex = 63
        '
        'btnProdHome
        '
        Me.btnProdHome.Location = New System.Drawing.Point(424, 642)
        Me.btnProdHome.Name = "btnProdHome"
        Me.btnProdHome.Size = New System.Drawing.Size(139, 44)
        Me.btnProdHome.TabIndex = 62
        Me.btnProdHome.Text = "Home"
        Me.btnProdHome.UseVisualStyleBackColor = True
        '
        'SUPPLIERTableAdapter
        '
        Me.SUPPLIERTableAdapter.ClearBeforeFill = True
        '
        'PRODUCTTableAdapter
        '
        Me.PRODUCTTableAdapter.ClearBeforeFill = True
        '
        'CATEGORYTableAdapter
        '
        Me.CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'USERSTableAdapter
        '
        Me.USERSTableAdapter.ClearBeforeFill = True
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(981, 753)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.btnProdHome)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cborduseTIN)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbordPhone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TbTP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TbST)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbVat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbordprice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbordcatnum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbordprodnum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbOrdQty)
        Me.Controls.Add(Me.lblordqty)
        Me.Controls.Add(Me.cbordsuppnum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbOrdNum)
        Me.Controls.Add(Me.lblOrdNo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.SUPPLIERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANTONIMS_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblheading As Label
    Friend WithEvents lblMO As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FUNCTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CALCULATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLEARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CATEGORYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPPLIERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PURCHASEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLOSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbOrdNum As TextBox
    Friend WithEvents lblOrdNo As Label
    Friend WithEvents cbordsuppnum As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbordprodnum As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbOrdQty As TextBox
    Friend WithEvents lblordqty As Label
    Friend WithEvents cbordcatnum As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbordprice As ComboBox
    Friend WithEvents TbVat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbST As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbTP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbordPhone As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cborduseTIN As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents btnProdHome As Button
    Friend WithEvents CANTONIMS_DBDataSet As CANTONIMS_DBDataSet
    Friend WithEvents SUPPLIERBindingSource As BindingSource
    Friend WithEvents SUPPLIERTableAdapter As CANTONIMS_DBDataSetTableAdapters.SUPPLIERTableAdapter
    Friend WithEvents PRODUCTBindingSource As BindingSource
    Friend WithEvents PRODUCTTableAdapter As CANTONIMS_DBDataSetTableAdapters.PRODUCTTableAdapter
    Friend WithEvents CATEGORYBindingSource As BindingSource
    Friend WithEvents CATEGORYTableAdapter As CANTONIMS_DBDataSetTableAdapters.CATEGORYTableAdapter
    Friend WithEvents USERSBindingSource As BindingSource
    Friend WithEvents USERSTableAdapter As CANTONIMS_DBDataSetTableAdapters.USERSTableAdapter
    Friend WithEvents PRODUCTToolStripMenuItem As ToolStripMenuItem
End Class
