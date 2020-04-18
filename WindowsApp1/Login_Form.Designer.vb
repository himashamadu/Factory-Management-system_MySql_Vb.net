<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.StoreUserTxt = New System.Windows.Forms.TextBox()
        Me.StoreKCloseBtn = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.StorePassTxt = New System.Windows.Forms.TextBox()
        Me.StorePassLbl = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.StoreUserLbl = New System.Windows.Forms.Label()
        Me.userTypeCmb = New System.Windows.Forms.ComboBox()
        Me.UserType = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Login = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 76)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(94, 342)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 71
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(666, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 70
        Me.PictureBox2.TabStop = False
        '
        'StoreUserTxt
        '
        Me.StoreUserTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreUserTxt.Location = New System.Drawing.Point(310, 46)
        Me.StoreUserTxt.Name = "StoreUserTxt"
        Me.StoreUserTxt.Size = New System.Drawing.Size(170, 21)
        Me.StoreUserTxt.TabIndex = 27
        '
        'StoreKCloseBtn
        '
        Me.StoreKCloseBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StoreKCloseBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreKCloseBtn.ForeColor = System.Drawing.Color.Black
        Me.StoreKCloseBtn.Location = New System.Drawing.Point(407, 190)
        Me.StoreKCloseBtn.Name = "StoreKCloseBtn"
        Me.StoreKCloseBtn.Size = New System.Drawing.Size(83, 31)
        Me.StoreKCloseBtn.TabIndex = 30
        Me.StoreKCloseBtn.Text = "Close"
        Me.StoreKCloseBtn.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBox1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(321, 152)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(146, 21)
        Me.CheckBox1.TabIndex = 31
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'StorePassTxt
        '
        Me.StorePassTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StorePassTxt.Location = New System.Drawing.Point(310, 118)
        Me.StorePassTxt.Name = "StorePassTxt"
        Me.StorePassTxt.Size = New System.Drawing.Size(170, 21)
        Me.StorePassTxt.TabIndex = 28
        Me.StorePassTxt.UseSystemPasswordChar = True
        '
        'StorePassLbl
        '
        Me.StorePassLbl.BackColor = System.Drawing.SystemColors.ControlLight
        Me.StorePassLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StorePassLbl.ForeColor = System.Drawing.Color.Black
        Me.StorePassLbl.Location = New System.Drawing.Point(195, 118)
        Me.StorePassLbl.Name = "StorePassLbl"
        Me.StorePassLbl.Size = New System.Drawing.Size(109, 22)
        Me.StorePassLbl.TabIndex = 26
        Me.StorePassLbl.Text = "Password :"
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.loginBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.Black
        Me.loginBtn.Location = New System.Drawing.Point(309, 190)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(83, 31)
        Me.loginBtn.TabIndex = 29
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'StoreUserLbl
        '
        Me.StoreUserLbl.BackColor = System.Drawing.SystemColors.ControlLight
        Me.StoreUserLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreUserLbl.ForeColor = System.Drawing.Color.Black
        Me.StoreUserLbl.Location = New System.Drawing.Point(191, 46)
        Me.StoreUserLbl.Name = "StoreUserLbl"
        Me.StoreUserLbl.Size = New System.Drawing.Size(113, 22)
        Me.StoreUserLbl.TabIndex = 25
        Me.StoreUserLbl.Text = "Username :"
        '
        'userTypeCmb
        '
        Me.userTypeCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userTypeCmb.FormattingEnabled = True
        Me.userTypeCmb.Items.AddRange(New Object() {"Top-Level", "Manager", "Store-Keeper"})
        Me.userTypeCmb.Location = New System.Drawing.Point(310, 81)
        Me.userTypeCmb.Name = "userTypeCmb"
        Me.userTypeCmb.Size = New System.Drawing.Size(170, 23)
        Me.userTypeCmb.TabIndex = 33
        '
        'UserType
        '
        Me.UserType.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UserType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserType.ForeColor = System.Drawing.Color.Black
        Me.UserType.Location = New System.Drawing.Point(191, 82)
        Me.UserType.Name = "UserType"
        Me.UserType.Size = New System.Drawing.Size(113, 23)
        Me.UserType.TabIndex = 34
        Me.UserType.Text = "User Type :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.StoreUserTxt)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.StoreKCloseBtn)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.UserType)
        Me.Panel1.Controls.Add(Me.StorePassTxt)
        Me.Panel1.Controls.Add(Me.StorePassLbl)
        Me.Panel1.Controls.Add(Me.userTypeCmb)
        Me.Panel1.Controls.Add(Me.loginBtn)
        Me.Panel1.Controls.Add(Me.StoreUserLbl)
        Me.Panel1.Location = New System.Drawing.Point(114, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 262)
        Me.Panel1.TabIndex = 72
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(100, 93)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(99, 36)
        Me.Login.TabIndex = 73
        Me.Login.Text = "Login"
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(659, 379)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login_Form"
        Me.Text = "Login_Form"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents StoreUserTxt As TextBox
    Friend WithEvents StoreKCloseBtn As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents StorePassTxt As TextBox
    Friend WithEvents StorePassLbl As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents StoreUserLbl As Label
    Friend WithEvents userTypeCmb As ComboBox
    Friend WithEvents UserType As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Login As Label
End Class
