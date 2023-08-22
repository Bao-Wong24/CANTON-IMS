<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomeForm
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
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.btnproduct = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnpurchase = New System.Windows.Forms.Button()
        Me.btnorder = New System.Windows.Forms.Button()
        Me.btnsupplier = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.picproduct = New System.Windows.Forms.PictureBox()
        Me.picorder = New System.Windows.Forms.PictureBox()
        Me.picpurchase = New System.Windows.Forms.PictureBox()
        Me.picuser = New System.Windows.Forms.PictureBox()
        Me.picsupplier = New System.Windows.Forms.PictureBox()
        Me.btndashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncategory = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblinvhome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblwelcome.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.ForeColor = System.Drawing.Color.Transparent
        Me.lblwelcome.Location = New System.Drawing.Point(286, 37)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(314, 23)
        Me.lblwelcome.TabIndex = 0
        Me.lblwelcome.Text = "WELCOME TO YOUR INVENTORY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnproduct
        '
        Me.btnproduct.BackColor = System.Drawing.Color.Transparent
        Me.btnproduct.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproduct.Location = New System.Drawing.Point(71, 187)
        Me.btnproduct.Name = "btnproduct"
        Me.btnproduct.Size = New System.Drawing.Size(125, 31)
        Me.btnproduct.TabIndex = 1
        Me.btnproduct.Text = "PRODUCTS"
        Me.btnproduct.UseVisualStyleBackColor = False
        '
        'btnuser
        '
        Me.btnuser.BackColor = System.Drawing.Color.Transparent
        Me.btnuser.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.Location = New System.Drawing.Point(680, 171)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(109, 31)
        Me.btnuser.TabIndex = 2
        Me.btnuser.Text = "USERS"
        Me.btnuser.UseVisualStyleBackColor = False
        '
        'btnpurchase
        '
        Me.btnpurchase.BackColor = System.Drawing.Color.Transparent
        Me.btnpurchase.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpurchase.Location = New System.Drawing.Point(376, 184)
        Me.btnpurchase.Name = "btnpurchase"
        Me.btnpurchase.Size = New System.Drawing.Size(134, 34)
        Me.btnpurchase.TabIndex = 3
        Me.btnpurchase.Text = "PURCHASES"
        Me.btnpurchase.UseVisualStyleBackColor = False
        '
        'btnorder
        '
        Me.btnorder.BackColor = System.Drawing.Color.Transparent
        Me.btnorder.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnorder.Location = New System.Drawing.Point(58, 354)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(134, 27)
        Me.btnorder.TabIndex = 4
        Me.btnorder.Text = "ORDERS"
        Me.btnorder.UseVisualStyleBackColor = False
        '
        'btnsupplier
        '
        Me.btnsupplier.BackColor = System.Drawing.Color.Transparent
        Me.btnsupplier.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsupplier.Location = New System.Drawing.Point(669, 351)
        Me.btnsupplier.Name = "btnsupplier"
        Me.btnsupplier.Size = New System.Drawing.Size(106, 35)
        Me.btnsupplier.TabIndex = 5
        Me.btnsupplier.Text = "SUPPLYS"
        Me.btnsupplier.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.Color.Transparent
        Me.btnlogout.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(86, 498)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(97, 29)
        Me.btnlogout.TabIndex = 6
        Me.btnlogout.Text = "LOGOUT"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'picproduct
        '
        Me.picproduct.BackColor = System.Drawing.Color.Transparent
        Me.picproduct.Image = Global.CANTON_IMS.My.Resources.Resources.restaurant_products
        Me.picproduct.Location = New System.Drawing.Point(71, 79)
        Me.picproduct.Name = "picproduct"
        Me.picproduct.Size = New System.Drawing.Size(112, 111)
        Me.picproduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picproduct.TabIndex = 7
        Me.picproduct.TabStop = False
        '
        'picorder
        '
        Me.picorder.BackColor = System.Drawing.Color.Transparent
        Me.picorder.Image = Global.CANTON_IMS.My.Resources.Resources.order_icon
        Me.picorder.Location = New System.Drawing.Point(58, 266)
        Me.picorder.Name = "picorder"
        Me.picorder.Size = New System.Drawing.Size(125, 92)
        Me.picorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picorder.TabIndex = 8
        Me.picorder.TabStop = False
        '
        'picpurchase
        '
        Me.picpurchase.BackColor = System.Drawing.Color.Transparent
        Me.picpurchase.Image = Global.CANTON_IMS.My.Resources.Resources.pay_15_256
        Me.picpurchase.Location = New System.Drawing.Point(382, 79)
        Me.picpurchase.Name = "picpurchase"
        Me.picpurchase.Size = New System.Drawing.Size(125, 108)
        Me.picpurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpurchase.TabIndex = 9
        Me.picpurchase.TabStop = False
        '
        'picuser
        '
        Me.picuser.BackColor = System.Drawing.Color.Transparent
        Me.picuser.Image = Global.CANTON_IMS.My.Resources.Resources.user_286
        Me.picuser.Location = New System.Drawing.Point(680, 79)
        Me.picuser.Name = "picuser"
        Me.picuser.Size = New System.Drawing.Size(109, 99)
        Me.picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picuser.TabIndex = 10
        Me.picuser.TabStop = False
        '
        'picsupplier
        '
        Me.picsupplier.BackColor = System.Drawing.Color.Transparent
        Me.picsupplier.Image = Global.CANTON_IMS.My.Resources.Resources.Product_icons_dolly_svg
        Me.picsupplier.Location = New System.Drawing.Point(669, 256)
        Me.picsupplier.Name = "picsupplier"
        Me.picsupplier.Size = New System.Drawing.Size(106, 102)
        Me.picsupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picsupplier.TabIndex = 11
        Me.picsupplier.TabStop = False
        '
        'btndashboard
        '
        Me.btndashboard.BackColor = System.Drawing.Color.Transparent
        Me.btndashboard.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashboard.Location = New System.Drawing.Point(366, 501)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Size = New System.Drawing.Size(134, 27)
        Me.btndashboard.TabIndex = 12
        Me.btndashboard.Text = "DASHBOARD"
        Me.btndashboard.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CANTON_IMS.My.Resources.Resources._2621084
        Me.PictureBox1.Location = New System.Drawing.Point(366, 437)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btncategory
        '
        Me.btncategory.BackColor = System.Drawing.Color.Transparent
        Me.btncategory.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategory.Location = New System.Drawing.Point(386, 354)
        Me.btncategory.Name = "btncategory"
        Me.btncategory.Size = New System.Drawing.Size(120, 32)
        Me.btncategory.TabIndex = 14
        Me.btncategory.Text = "CATEGORY"
        Me.btncategory.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.CANTON_IMS.My.Resources.Resources._945178
        Me.PictureBox2.Location = New System.Drawing.Point(396, 266)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(104, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Transparent
        Me.btnexit.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(727, 498)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(97, 29)
        Me.btnexit.TabIndex = 16
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'lblinvhome
        '
        Me.lblinvhome.AutoSize = True
        Me.lblinvhome.BackColor = System.Drawing.Color.Transparent
        Me.lblinvhome.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvhome.ForeColor = System.Drawing.Color.Transparent
        Me.lblinvhome.Location = New System.Drawing.Point(333, 0)
        Me.lblinvhome.Name = "lblinvhome"
        Me.lblinvhome.Size = New System.Drawing.Size(210, 27)
        Me.lblinvhome.TabIndex = 17
        Me.lblinvhome.Text = "INVENTORY HOME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(463, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 18
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CANTON_IMS.My.Resources.Resources.background_solid_line_cell_wallpaper_Welcome
        Me.ClientSize = New System.Drawing.Size(911, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblinvhome)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btncategory)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btndashboard)
        Me.Controls.Add(Me.picsupplier)
        Me.Controls.Add(Me.picuser)
        Me.Controls.Add(Me.picpurchase)
        Me.Controls.Add(Me.picorder)
        Me.Controls.Add(Me.picproduct)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnsupplier)
        Me.Controls.Add(Me.btnorder)
        Me.Controls.Add(Me.btnpurchase)
        Me.Controls.Add(Me.btnuser)
        Me.Controls.Add(Me.btnproduct)
        Me.Controls.Add(Me.lblwelcome)
        Me.Name = "WelcomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Home Form "
        CType(Me.picproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblwelcome As Label
    Friend WithEvents btnproduct As Button
    Friend WithEvents btnuser As Button
    Friend WithEvents btnpurchase As Button
    Friend WithEvents btnorder As Button
    Friend WithEvents btnsupplier As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents picproduct As PictureBox
    Friend WithEvents picorder As PictureBox
    Friend WithEvents picpurchase As PictureBox
    Friend WithEvents picuser As PictureBox
    Friend WithEvents picsupplier As PictureBox
    Friend WithEvents btndashboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btncategory As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnexit As Button
    Friend WithEvents lblinvhome As Label
    Friend WithEvents Label1 As Label
End Class
