<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Me.lblMU = New System.Windows.Forms.Label()
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
        Me.ORDERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PURCHASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblProdNo = New System.Windows.Forms.Label()
        Me.TbProdNum = New System.Windows.Forms.TextBox()
        Me.Tbprodname = New System.Windows.Forms.TextBox()
        Me.lblProdname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbcategoryNum = New System.Windows.Forms.ComboBox()
        Me.CATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CANTONIMS_DBDataSet2 = New CANTON_IMS.CANTONIMS_DBDataSet()
        Me.TbUOM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbquantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbUP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbTP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbSuppNum = New System.Windows.Forms.ComboBox()
        Me.SUPPLIERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnProdHome = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.CATEGORYTableAdapter2 = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.CATEGORYTableAdapter()
        Me.SUPPLIERTableAdapter1 = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.SUPPLIERTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANTONIMS_DBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPPLIERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblheading)
        Me.Panel1.Controls.Add(Me.lblMU)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 100)
        Me.Panel1.TabIndex = 29
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
        'lblMU
        '
        Me.lblMU.AutoSize = True
        Me.lblMU.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMU.ForeColor = System.Drawing.Color.Transparent
        Me.lblMU.Location = New System.Drawing.Point(417, 26)
        Me.lblMU.Name = "lblMU"
        Me.lblMU.Size = New System.Drawing.Size(212, 31)
        Me.lblMU.TabIndex = 3
        Me.lblMU.Text = "Manage Product"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.UPDATEToolStripMenuItem, Me.SEARCHToolStripMenuItem, Me.DELETEToolStripMenuItem2, Me.FUNCTIONToolStripMenuItem, Me.CLEARToolStripMenuItem, Me.MOREToolStripMenuItem, Me.CLOSEToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(967, 33)
        Me.MenuStrip2.TabIndex = 28
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
        Me.MOREToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CATEGORYToolStripMenuItem, Me.SUPPLIERToolStripMenuItem, Me.ORDERToolStripMenuItem, Me.PURCHASEToolStripMenuItem, Me.USERSToolStripMenuItem})
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
        'ORDERToolStripMenuItem
        '
        Me.ORDERToolStripMenuItem.Name = "ORDERToolStripMenuItem"
        Me.ORDERToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.ORDERToolStripMenuItem.Text = "ORDER"
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
        'CLOSEToolStripMenuItem
        '
        Me.CLOSEToolStripMenuItem.Name = "CLOSEToolStripMenuItem"
        Me.CLOSEToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.CLOSEToolStripMenuItem.Text = "CLOSE"
        '
        'lblProdNo
        '
        Me.lblProdNo.AutoSize = True
        Me.lblProdNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdNo.Location = New System.Drawing.Point(58, 186)
        Me.lblProdNo.Name = "lblProdNo"
        Me.lblProdNo.Size = New System.Drawing.Size(43, 25)
        Me.lblProdNo.TabIndex = 30
        Me.lblProdNo.Text = "No:"
        '
        'TbProdNum
        '
        Me.TbProdNum.Location = New System.Drawing.Point(131, 184)
        Me.TbProdNum.Name = "TbProdNum"
        Me.TbProdNum.Size = New System.Drawing.Size(100, 22)
        Me.TbProdNum.TabIndex = 31
        '
        'Tbprodname
        '
        Me.Tbprodname.Location = New System.Drawing.Point(347, 188)
        Me.Tbprodname.Name = "Tbprodname"
        Me.Tbprodname.Size = New System.Drawing.Size(100, 22)
        Me.Tbprodname.TabIndex = 33
        '
        'lblProdname
        '
        Me.lblProdname.AutoSize = True
        Me.lblProdname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdname.Location = New System.Drawing.Point(261, 183)
        Me.lblProdname.Name = "lblProdname"
        Me.lblProdname.Size = New System.Drawing.Size(64, 25)
        Me.lblProdname.TabIndex = 32
        Me.lblProdname.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Category No:"
        '
        'CbcategoryNum
        '
        Me.CbcategoryNum.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CATEGORYBindingSource, "CatNo", True))
        Me.CbcategoryNum.DataSource = Me.CATEGORYBindingSource
        Me.CbcategoryNum.DisplayMember = "CatNo"
        Me.CbcategoryNum.FormattingEnabled = True
        Me.CbcategoryNum.Location = New System.Drawing.Point(147, 311)
        Me.CbcategoryNum.Name = "CbcategoryNum"
        Me.CbcategoryNum.Size = New System.Drawing.Size(121, 24)
        Me.CbcategoryNum.TabIndex = 35
        Me.CbcategoryNum.ValueMember = "CatNo"
        '
        'CATEGORYBindingSource
        '
        Me.CATEGORYBindingSource.DataMember = "CATEGORY"
        Me.CATEGORYBindingSource.DataSource = Me.CANTONIMS_DBDataSet2
        '
        'CANTONIMS_DBDataSet2
        '
        Me.CANTONIMS_DBDataSet2.DataSetName = "CANTONIMS_DBDataSet"
        Me.CANTONIMS_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbUOM
        '
        Me.TbUOM.Location = New System.Drawing.Point(424, 253)
        Me.TbUOM.Name = "TbUOM"
        Me.TbUOM.Size = New System.Drawing.Size(100, 22)
        Me.TbUOM.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Unit Of Measure"
        '
        'Tbquantity
        '
        Me.Tbquantity.Location = New System.Drawing.Point(594, 188)
        Me.Tbquantity.Name = "Tbquantity"
        Me.Tbquantity.Size = New System.Drawing.Size(100, 22)
        Me.Tbquantity.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(512, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Quantity"
        '
        'TbUP
        '
        Me.TbUP.Location = New System.Drawing.Point(147, 249)
        Me.TbUP.Name = "TbUP"
        Me.TbUP.Size = New System.Drawing.Size(100, 22)
        Me.TbUP.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 25)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Unit Price"
        '
        'TbTP
        '
        Me.TbTP.Location = New System.Drawing.Point(682, 305)
        Me.TbTP.Name = "TbTP"
        Me.TbTP.Size = New System.Drawing.Size(100, 22)
        Me.TbTP.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(571, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 25)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Total Price"
        '
        'CbSuppNum
        '
        Me.CbSuppNum.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SUPPLIERBindingSource, "SuppNo", True))
        Me.CbSuppNum.DataSource = Me.SUPPLIERBindingSource
        Me.CbSuppNum.DisplayMember = "SuppNo"
        Me.CbSuppNum.FormattingEnabled = True
        Me.CbSuppNum.Location = New System.Drawing.Point(403, 306)
        Me.CbSuppNum.Name = "CbSuppNum"
        Me.CbSuppNum.Size = New System.Drawing.Size(121, 24)
        Me.CbSuppNum.TabIndex = 45
        Me.CbSuppNum.ValueMember = "SuppNo"
        '
        'SUPPLIERBindingSource
        '
        Me.SUPPLIERBindingSource.DataMember = "SUPPLIER"
        Me.SUPPLIERBindingSource.DataSource = Me.CANTONIMS_DBDataSet2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(288, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 25)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Supplier No"
        '
        'btnProdHome
        '
        Me.btnProdHome.Location = New System.Drawing.Point(424, 596)
        Me.btnProdHome.Name = "btnProdHome"
        Me.btnProdHome.Size = New System.Drawing.Size(100, 32)
        Me.btnProdHome.TabIndex = 47
        Me.btnProdHome.Text = "Home"
        Me.btnProdHome.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(560, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 25)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(619, 253)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 49
        Me.DateTimePicker1.Value = New Date(2022, 11, 9, 23, 34, 43, 0)
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(2, 353)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(965, 185)
        Me.DataGridView4.TabIndex = 50
        '
        'CATEGORYTableAdapter2
        '
        Me.CATEGORYTableAdapter2.ClearBeforeFill = True
        '
        'SUPPLIERTableAdapter1
        '
        Me.SUPPLIERTableAdapter1.ClearBeforeFill = True
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(967, 671)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnProdHome)
        Me.Controls.Add(Me.CbSuppNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbTP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbUP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Tbquantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbUOM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbcategoryNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tbprodname)
        Me.Controls.Add(Me.lblProdname)
        Me.Controls.Add(Me.TbProdNum)
        Me.Controls.Add(Me.lblProdNo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANTONIMS_DBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPPLIERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblheading As Label
    Friend WithEvents lblMU As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CLEARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CATEGORYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPPLIERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ORDERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PURCHASEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLOSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblProdNo As Label
    Friend WithEvents TbProdNum As TextBox
    Friend WithEvents Tbprodname As TextBox
    Friend WithEvents lblProdname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbcategoryNum As ComboBox
    Friend WithEvents CANTONIMS_DBDataSet As CANTONIMS_DBDataSet
    Friend WithEvents CATEGORYTableAdapter As CANTONIMS_DBDataSetTableAdapters.CATEGORYTableAdapter
    Friend WithEvents TbUOM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Tbquantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbUP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbTP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbSuppNum As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnProdHome As Button
    Friend WithEvents FUNCTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CALCULATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CANTONIMS_DBDataSet1 As CANTONIMS_DBDataSet
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CATEGORYTableAdapter1 As CANTONIMS_DBDataSetTableAdapters.CATEGORYTableAdapter
    Friend WithEvents SUPPLIERTableAdapter As CANTONIMS_DBDataSetTableAdapters.SUPPLIERTableAdapter
    Friend WithEvents PRODUCTTableAdapter As CANTONIMS_DBDataSetTableAdapters.PRODUCTTableAdapter
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents CANTONIMS_DBDataSet2 As CANTONIMS_DBDataSet
    Friend WithEvents CATEGORYBindingSource As BindingSource
    Friend WithEvents CATEGORYTableAdapter2 As CANTONIMS_DBDataSetTableAdapters.CATEGORYTableAdapter
    Friend WithEvents SUPPLIERBindingSource As BindingSource
    Friend WithEvents SUPPLIERTableAdapter1 As CANTONIMS_DBDataSetTableAdapters.SUPPLIERTableAdapter
    Friend WithEvents USERSToolStripMenuItem As ToolStripMenuItem
End Class
