<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.lblusename = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtuserfield = New System.Windows.Forms.TextBox()
        Me.txtpassfield = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnlogoff = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblusename
        '
        Me.lblusename.AutoSize = True
        Me.lblusename.BackColor = System.Drawing.Color.Transparent
        Me.lblusename.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusename.ForeColor = System.Drawing.Color.Transparent
        Me.lblusename.Location = New System.Drawing.Point(44, 159)
        Me.lblusename.Name = "lblusename"
        Me.lblusename.Size = New System.Drawing.Size(163, 23)
        Me.lblusename.TabIndex = 12
        Me.lblusename.Text = "Enter Username"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.BackColor = System.Drawing.Color.Transparent
        Me.lblpass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.ForeColor = System.Drawing.Color.Transparent
        Me.lblpass.Location = New System.Drawing.Point(44, 205)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(158, 23)
        Me.lblpass.TabIndex = 13
        Me.lblpass.Text = "Enter Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CANTON_IMS.My.Resources.Resources.user_login_icon_14
        Me.PictureBox1.Location = New System.Drawing.Point(197, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.BackColor = System.Drawing.Color.Transparent
        Me.lbllogin.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.ForeColor = System.Drawing.Color.Transparent
        Me.lbllogin.Location = New System.Drawing.Point(193, 9)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(131, 22)
        Me.lbllogin.TabIndex = 17
        Me.lbllogin.Text = "LOGON FORM"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.Black
        Me.btnlogin.Location = New System.Drawing.Point(90, 312)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(117, 30)
        Me.btnlogin.TabIndex = 18
        Me.btnlogin.Text = "LOGIN"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txtuserfield
        '
        Me.txtuserfield.ForeColor = System.Drawing.Color.Black
        Me.txtuserfield.Location = New System.Drawing.Point(226, 159)
        Me.txtuserfield.Multiline = True
        Me.txtuserfield.Name = "txtuserfield"
        Me.txtuserfield.Size = New System.Drawing.Size(269, 31)
        Me.txtuserfield.TabIndex = 19
        '
        'txtpassfield
        '
        Me.txtpassfield.Location = New System.Drawing.Point(226, 208)
        Me.txtpassfield.Multiline = True
        Me.txtpassfield.Name = "txtpassfield"
        Me.txtpassfield.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassfield.Size = New System.Drawing.Size(269, 31)
        Me.txtpassfield.TabIndex = 20
        Me.txtpassfield.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(226, 254)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 20)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'btnlogoff
        '
        Me.btnlogoff.BackColor = System.Drawing.Color.Transparent
        Me.btnlogoff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogoff.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogoff.ForeColor = System.Drawing.Color.Black
        Me.btnlogoff.Location = New System.Drawing.Point(361, 312)
        Me.btnlogoff.Name = "btnlogoff"
        Me.btnlogoff.Size = New System.Drawing.Size(117, 30)
        Me.btnlogoff.TabIndex = 22
        Me.btnlogoff.Text = "LOGOFF"
        Me.btnlogoff.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.CANTON_IMS.My.Resources.Resources.main_qimg_4effe3ae863d563f8cf6bb4e66658040_pjlq
        Me.ClientSize = New System.Drawing.Size(534, 372)
        Me.Controls.Add(Me.btnlogoff)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtpassfield)
        Me.Controls.Add(Me.txtuserfield)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lbllogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lblusename)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblusename As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbllogin As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents txtuserfield As TextBox
    Friend WithEvents txtpassfield As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnlogoff As Button
End Class
