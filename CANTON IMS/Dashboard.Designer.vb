<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnoverall = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.cbsupplierlist = New System.Windows.Forms.ComboBox()
        Me.SUPPLIERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CANTONIMS_DBDataSet = New CANTON_IMS.CANTONIMS_DBDataSet()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbuserlist = New System.Windows.Forms.ComboBox()
        Me.USERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbproductlist = New System.Windows.Forms.ComboBox()
        Me.PRODUCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.ProdNoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PurchNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PURCHASEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OrdNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USERSTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.USERSTableAdapter()
        Me.SUPPLIERTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.SUPPLIERTableAdapter()
        Me.PRODUCTTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.PRODUCTTableAdapter()
        Me.ORDERSTableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.ORDERSTableAdapter()
        Me.PURCHASETableAdapter = New CANTON_IMS.CANTONIMS_DBDataSetTableAdapters.PURCHASETableAdapter()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPPLIERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CANTONIMS_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PURCHASEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ORDERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnrefresh)
        Me.Panel1.Controls.Add(Me.btnoverall)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Location = New System.Drawing.Point(0, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 693)
        Me.Panel1.TabIndex = 0
        '
        'btnrefresh
        '
        Me.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnrefresh.Location = New System.Drawing.Point(0, 270)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnrefresh.Size = New System.Drawing.Size(183, 39)
        Me.btnrefresh.TabIndex = 19
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btnoverall
        '
        Me.btnoverall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnoverall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnoverall.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnoverall.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnoverall.Location = New System.Drawing.Point(0, 205)
        Me.btnoverall.Name = "btnoverall"
        Me.btnoverall.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnoverall.Size = New System.Drawing.Size(183, 39)
        Me.btnoverall.TabIndex = 18
        Me.btnoverall.Text = "Overview"
        Me.btnoverall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnoverall.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CANTON" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RESTAURANT"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Firebrick
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 72)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Location = New System.Drawing.Point(3, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 2)
        Me.Panel2.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 2)
        Me.Panel7.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.btnClean)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Chart1)
        Me.Panel3.Controls.Add(Me.ListBox3)
        Me.Panel3.Controls.Add(Me.cbsupplierlist)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.cbuserlist)
        Me.Panel3.Controls.Add(Me.ListBox2)
        Me.Panel3.Controls.Add(Me.ListBox1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.cbproductlist)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(182, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1073, 690)
        Me.Panel3.TabIndex = 1
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(38, 581)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(146, 38)
        Me.btnClean.TabIndex = 18
        Me.btnClean.Text = "Cleanse"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Teal
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(673, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label13.Size = New System.Drawing.Size(140, 40)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "PRODUCTS"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Teal
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(353, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label12.Size = New System.Drawing.Size(143, 40)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "PURCHASES"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(70, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label9.Size = New System.Drawing.Size(114, 40)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "ORDERS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(462, 267)
        Me.Chart1.Name = "Chart1"
        Series1.BorderColor = System.Drawing.Color.Red
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.Lime
        Series1.Legend = "Legend1"
        Series1.Name = "ORDERS"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "PURCHASES"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "PRODUCTS"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(593, 318)
        Me.Chart1.TabIndex = 3
        Me.Chart1.Text = "Chart1"
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.Color.Maroon
        Me.ListBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.ForeColor = System.Drawing.Color.White
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 18
        Me.ListBox3.Location = New System.Drawing.Point(258, 296)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(155, 148)
        Me.ListBox3.TabIndex = 17
        '
        'cbsupplierlist
        '
        Me.cbsupplierlist.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SUPPLIERBindingSource, "SuppName", True))
        Me.cbsupplierlist.DataSource = Me.SUPPLIERBindingSource
        Me.cbsupplierlist.DisplayMember = "SuppName"
        Me.cbsupplierlist.FormattingEnabled = True
        Me.cbsupplierlist.Location = New System.Drawing.Point(258, 256)
        Me.cbsupplierlist.Name = "cbsupplierlist"
        Me.cbsupplierlist.Size = New System.Drawing.Size(167, 24)
        Me.cbsupplierlist.TabIndex = 16
        Me.cbsupplierlist.ValueMember = "SuppName"
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(829, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(226, 22)
        Me.DateTimePicker1.TabIndex = 8
        '
        'cbuserlist
        '
        Me.cbuserlist.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.USERSBindingSource, "UserName", True))
        Me.cbuserlist.DataSource = Me.USERSBindingSource
        Me.cbuserlist.DisplayMember = "UserName"
        Me.cbuserlist.FormattingEnabled = True
        Me.cbuserlist.Location = New System.Drawing.Point(17, 296)
        Me.cbuserlist.Name = "cbuserlist"
        Me.cbuserlist.Size = New System.Drawing.Size(167, 24)
        Me.cbuserlist.TabIndex = 0
        Me.cbuserlist.ValueMember = "UserName"
        '
        'USERSBindingSource
        '
        Me.USERSBindingSource.DataMember = "USERS"
        Me.USERSBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.Maroon
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.ForeColor = System.Drawing.Color.White
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 18
        Me.ListBox2.Location = New System.Drawing.Point(252, 538)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(146, 148)
        Me.ListBox2.TabIndex = 15
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Maroon
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(25, 358)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(159, 184)
        Me.ListBox1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(639, 616)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 38)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Load Into Graph"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbproductlist
        '
        Me.cbproductlist.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PRODUCTBindingSource, "ProdName", True))
        Me.cbproductlist.DataSource = Me.PRODUCTBindingSource
        Me.cbproductlist.DisplayMember = "ProdName"
        Me.cbproductlist.FormattingEnabled = True
        Me.cbproductlist.Location = New System.Drawing.Point(246, 498)
        Me.cbproductlist.Name = "cbproductlist"
        Me.cbproductlist.Size = New System.Drawing.Size(167, 24)
        Me.cbproductlist.TabIndex = 1
        Me.cbproductlist.ValueMember = "ProdName"
        '
        'PRODUCTBindingSource
        '
        Me.PRODUCTBindingSource.DataMember = "PRODUCT"
        Me.PRODUCTBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(227, 464)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "&Lastest Products of System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(582, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "&Recent Event Activity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(218, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&Lastest Suppliers of System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Lastest Users of System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel9.Location = New System.Drawing.Point(452, 219)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(4, 471)
        Me.Panel9.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.Location = New System.Drawing.Point(0, 216)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(959, 2)
        Me.Panel8.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel6.Controls.Add(Me.DataGridView3)
        Me.Panel6.Location = New System.Drawing.Point(629, 58)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(300, 140)
        Me.Panel6.TabIndex = 2
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdNoDataGridViewTextBoxColumn2})
        Me.DataGridView3.DataSource = Me.PRODUCTBindingSource1
        Me.DataGridView3.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(294, 134)
        Me.DataGridView3.TabIndex = 25
        '
        'ProdNoDataGridViewTextBoxColumn2
        '
        Me.ProdNoDataGridViewTextBoxColumn2.DataPropertyName = "ProdNo"
        Me.ProdNoDataGridViewTextBoxColumn2.HeaderText = "ProdNo"
        Me.ProdNoDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.ProdNoDataGridViewTextBoxColumn2.Name = "ProdNoDataGridViewTextBoxColumn2"
        '
        'PRODUCTBindingSource1
        '
        Me.PRODUCTBindingSource1.DataMember = "PRODUCT"
        Me.PRODUCTBindingSource1.DataSource = Me.CANTONIMS_DBDataSet
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel5.Controls.Add(Me.DataGridView2)
        Me.Panel5.Location = New System.Drawing.Point(305, 58)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(300, 140)
        Me.Panel5.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurchNoDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.PURCHASEBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(294, 134)
        Me.DataGridView2.TabIndex = 24
        '
        'PurchNoDataGridViewTextBoxColumn
        '
        Me.PurchNoDataGridViewTextBoxColumn.DataPropertyName = "PurchNo"
        Me.PurchNoDataGridViewTextBoxColumn.HeaderText = "PurchNo"
        Me.PurchNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PurchNoDataGridViewTextBoxColumn.Name = "PurchNoDataGridViewTextBoxColumn"
        '
        'PURCHASEBindingSource
        '
        Me.PURCHASEBindingSource.DataMember = "PURCHASE"
        Me.PURCHASEBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Location = New System.Drawing.Point(17, 58)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(259, 140)
        Me.Panel4.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrdNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ORDERSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(253, 134)
        Me.DataGridView1.TabIndex = 23
        '
        'OrdNoDataGridViewTextBoxColumn
        '
        Me.OrdNoDataGridViewTextBoxColumn.DataPropertyName = "OrdNo"
        Me.OrdNoDataGridViewTextBoxColumn.HeaderText = "OrdNo"
        Me.OrdNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrdNoDataGridViewTextBoxColumn.Name = "OrdNoDataGridViewTextBoxColumn"
        '
        'ORDERSBindingSource
        '
        Me.ORDERSBindingSource.DataMember = "ORDERS"
        Me.ORDERSBindingSource.DataSource = Me.CANTONIMS_DBDataSet
        '
        'USERSTableAdapter
        '
        Me.USERSTableAdapter.ClearBeforeFill = True
        '
        'SUPPLIERTableAdapter
        '
        Me.SUPPLIERTableAdapter.ClearBeforeFill = True
        '
        'PRODUCTTableAdapter
        '
        Me.PRODUCTTableAdapter.ClearBeforeFill = True
        '
        'ORDERSTableAdapter
        '
        Me.ORDERSTableAdapter.ClearBeforeFill = True
        '
        'PURCHASETableAdapter
        '
        Me.PURCHASETableAdapter.ClearBeforeFill = True
        '
        'btnHome
        '
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHome.Location = New System.Drawing.Point(36, 541)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(90, 26)
        Me.btnHome.TabIndex = 20
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1249, 691)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPPLIERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CANTONIMS_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PURCHASEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ORDERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbproductlist As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbuserlist As ComboBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents cbsupplierlist As ComboBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnoverall As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnrefresh As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CANTONIMS_DBDataSet As CANTONIMS_DBDataSet
    Friend WithEvents USERSBindingSource As BindingSource
    Friend WithEvents USERSTableAdapter As CANTONIMS_DBDataSetTableAdapters.USERSTableAdapter
    Friend WithEvents SUPPLIERBindingSource As BindingSource
    Friend WithEvents SUPPLIERTableAdapter As CANTONIMS_DBDataSetTableAdapters.SUPPLIERTableAdapter
    Friend WithEvents PRODUCTBindingSource As BindingSource
    Friend WithEvents PRODUCTTableAdapter As CANTONIMS_DBDataSetTableAdapters.PRODUCTTableAdapter
    Friend WithEvents btnClean As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ORDERSBindingSource As BindingSource
    Friend WithEvents ORDERSTableAdapter As CANTONIMS_DBDataSetTableAdapters.ORDERSTableAdapter
    Friend WithEvents PURCHASEBindingSource As BindingSource
    Friend WithEvents PURCHASETableAdapter As CANTONIMS_DBDataSetTableAdapters.PURCHASETableAdapter
    Friend WithEvents PRODUCTBindingSource1 As BindingSource
    Friend WithEvents PurchNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrdNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProdNoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents btnHome As Button
End Class
