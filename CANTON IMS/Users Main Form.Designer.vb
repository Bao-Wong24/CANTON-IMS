<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Users_Main_Form
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
        Me.lblMU = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLEARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CATEGORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPPLIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORDERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PURCHASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTINno = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lbluname = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lbljrole = New System.Windows.Forms.Label()
        Me.lblcty = New System.Windows.Forms.Label()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VbimsdbDataSet = New CANTON_IMS.vbimsdbDataSet()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.txtTin = New System.Windows.Forms.TextBox()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.UsersTableAdapter = New CANTON_IMS.vbimsdbDataSetTableAdapters.UsersTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VbimsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(845, 100)
        Me.Panel1.TabIndex = 27
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
        Me.lblMU.Size = New System.Drawing.Size(190, 31)
        Me.lblMU.TabIndex = 3
        Me.lblMU.Text = "Manage Users"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.UPDATEToolStripMenuItem, Me.SEARCHToolStripMenuItem, Me.DELETEToolStripMenuItem2, Me.CLEARToolStripMenuItem, Me.MOREToolStripMenuItem, Me.CLOSEToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(845, 33)
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
        Me.MOREToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CATEGORYToolStripMenuItem, Me.PRODUCTToolStripMenuItem, Me.SUPPLIERToolStripMenuItem, Me.ORDERToolStripMenuItem, Me.PURCHASEToolStripMenuItem})
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
        'PRODUCTToolStripMenuItem
        '
        Me.PRODUCTToolStripMenuItem.Name = "PRODUCTToolStripMenuItem"
        Me.PRODUCTToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.PRODUCTToolStripMenuItem.Text = "PRODUCT"
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
        'CLOSEToolStripMenuItem
        '
        Me.CLOSEToolStripMenuItem.Name = "CLOSEToolStripMenuItem"
        Me.CLOSEToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.CLOSEToolStripMenuItem.Text = "CLOSE"
        '
        'lblTINno
        '
        Me.lblTINno.AutoSize = True
        Me.lblTINno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTINno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTINno.Location = New System.Drawing.Point(31, 192)
        Me.lblTINno.Name = "lblTINno"
        Me.lblTINno.Size = New System.Drawing.Size(50, 25)
        Me.lblTINno.TabIndex = 29
        Me.lblTINno.Text = "TIN:"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblfname.Location = New System.Drawing.Point(248, 192)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(112, 25)
        Me.lblfname.TabIndex = 30
        Me.lblfname.Text = "First Name:"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbllname.Location = New System.Drawing.Point(530, 192)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(112, 25)
        Me.lbllname.TabIndex = 31
        Me.lbllname.Text = "Last Name:"
        '
        'lbluname
        '
        Me.lbluname.AutoSize = True
        Me.lbluname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbluname.Location = New System.Drawing.Point(31, 337)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(108, 25)
        Me.lbluname.TabIndex = 32
        Me.lbluname.Text = "Username:"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpass.Location = New System.Drawing.Point(340, 337)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(109, 25)
        Me.lblpass.TabIndex = 33
        Me.lblpass.Text = "Password: "
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblemail.Location = New System.Drawing.Point(252, 271)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(66, 25)
        Me.lblemail.TabIndex = 34
        Me.lblemail.Text = "Email:"
        '
        'lbljrole
        '
        Me.lbljrole.AutoSize = True
        Me.lbljrole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljrole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbljrole.Location = New System.Drawing.Point(31, 271)
        Me.lbljrole.Name = "lbljrole"
        Me.lbljrole.Size = New System.Drawing.Size(62, 25)
        Me.lbljrole.TabIndex = 35
        Me.lbljrole.Text = "Role: "
        '
        'lblcty
        '
        Me.lblcty.AutoSize = True
        Me.lblcty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcty.Location = New System.Drawing.Point(572, 271)
        Me.lblcty.Name = "lblcty"
        Me.lblcty.Size = New System.Drawing.Size(52, 25)
        Me.lblcty.TabIndex = 36
        Me.lblcty.Text = "City:"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.VbimsdbDataSet
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
        Me.btnhome.Location = New System.Drawing.Point(364, 586)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(108, 35)
        Me.btnhome.TabIndex = 38
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = True
        '
        'txtTin
        '
        Me.txtTin.Location = New System.Drawing.Point(87, 192)
        Me.txtTin.Multiline = True
        Me.txtTin.Name = "txtTin"
        Me.txtTin.Size = New System.Drawing.Size(82, 25)
        Me.txtTin.TabIndex = 39
        '
        'txtFN
        '
        Me.txtFN.Location = New System.Drawing.Point(364, 192)
        Me.txtFN.Multiline = True
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(125, 25)
        Me.txtFN.TabIndex = 40
        '
        'txtLN
        '
        Me.txtLN.Location = New System.Drawing.Point(648, 192)
        Me.txtLN.Multiline = True
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(133, 25)
        Me.txtLN.TabIndex = 41
        '
        'txtRole
        '
        Me.txtRole.Location = New System.Drawing.Point(87, 271)
        Me.txtRole.Multiline = True
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(102, 25)
        Me.txtRole.TabIndex = 42
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(319, 271)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(231, 25)
        Me.txtEmail.TabIndex = 43
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(648, 275)
        Me.txtcity.Multiline = True
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(135, 25)
        Me.txtcity.TabIndex = 44
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(145, 337)
        Me.txtusername.Multiline = True
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(153, 25)
        Me.txtusername.TabIndex = 45
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(455, 337)
        Me.txtpass.Multiline = True
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(130, 25)
        Me.txtpass.TabIndex = 46
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 403)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(845, 142)
        Me.DataGridView1.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(615, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Phone:"
        '
        'txtphone
        '
        Me.txtphone.Location = New System.Drawing.Point(696, 333)
        Me.txtphone.Multiline = True
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(109, 25)
        Me.txtphone.TabIndex = 51
        '
        'Users_Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(845, 643)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.txtLN)
        Me.Controls.Add(Me.txtFN)
        Me.Controls.Add(Me.txtTin)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.lblcty)
        Me.Controls.Add(Me.lbljrole)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lbluname)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.lblfname)
        Me.Controls.Add(Me.lblTINno)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Users_Main_Form"
        Me.Text = "Users_Main_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VbimsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblheading As Label
    Friend WithEvents lblMU As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CLOSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTINno As Label
    Friend WithEvents lblfname As Label
    Friend WithEvents lbllname As Label
    Friend WithEvents lbluname As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lbljrole As Label
    Friend WithEvents lblcty As Label
    Friend WithEvents btnhome As Button
    Friend WithEvents txtTin As TextBox
    Friend WithEvents txtFN As TextBox
    Friend WithEvents txtLN As TextBox
    Friend WithEvents txtRole As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtcity As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents VbimsdbDataSet As vbimsdbDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As vbimsdbDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtphone As TextBox
    Friend WithEvents CLEARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CATEGORYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUCTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPPLIERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ORDERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PURCHASEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As ToolStripMenuItem
End Class
