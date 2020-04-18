<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Adding_Deleting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Adding_Deleting))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.usNamTxt = New System.Windows.Forms.TextBox()
        Me.PassTxt = New System.Windows.Forms.TextBox()
        Me.ConPassTxt = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.usTypComTxt = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DelComTxt = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DelusTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm Password"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "User Type"
        '
        'usNamTxt
        '
        Me.usNamTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usNamTxt.Location = New System.Drawing.Point(198, 53)
        Me.usNamTxt.Name = "usNamTxt"
        Me.usNamTxt.Size = New System.Drawing.Size(154, 22)
        Me.usNamTxt.TabIndex = 4
        '
        'PassTxt
        '
        Me.PassTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTxt.Location = New System.Drawing.Point(198, 90)
        Me.PassTxt.Name = "PassTxt"
        Me.PassTxt.Size = New System.Drawing.Size(154, 22)
        Me.PassTxt.TabIndex = 5
        Me.PassTxt.UseSystemPasswordChar = True
        '
        'ConPassTxt
        '
        Me.ConPassTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConPassTxt.Location = New System.Drawing.Point(198, 124)
        Me.ConPassTxt.Name = "ConPassTxt"
        Me.ConPassTxt.Size = New System.Drawing.Size(154, 22)
        Me.ConPassTxt.TabIndex = 6
        Me.ConPassTxt.UseSystemPasswordChar = True
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(231, 202)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddBtn.TabIndex = 8
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'DelBtn
        '
        Me.DelBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn.Location = New System.Drawing.Point(211, 159)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(75, 23)
        Me.DelBtn.TabIndex = 9
        Me.DelBtn.Text = "Delete"
        Me.DelBtn.UseVisualStyleBackColor = False
        '
        'usTypComTxt
        '
        Me.usTypComTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usTypComTxt.FormattingEnabled = True
        Me.usTypComTxt.Items.AddRange(New Object() {"Manager", "Store-Keeper", "Top-Level"})
        Me.usTypComTxt.Location = New System.Drawing.Point(198, 161)
        Me.usTypComTxt.Name = "usTypComTxt"
        Me.usTypComTxt.Size = New System.Drawing.Size(154, 24)
        Me.usTypComTxt.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.usNamTxt)
        Me.Panel1.Controls.Add(Me.usTypComTxt)
        Me.Panel1.Controls.Add(Me.AddBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ConPassTxt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PassTxt)
        Me.Panel1.Location = New System.Drawing.Point(139, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 243)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DelComTxt)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.DelusTxt)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.DelBtn)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(547, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 203)
        Me.Panel2.TabIndex = 12
        '
        'DelComTxt
        '
        Me.DelComTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelComTxt.FormattingEnabled = True
        Me.DelComTxt.Items.AddRange(New Object() {"Manager", "Store-Keeper", "Top-Level"})
        Me.DelComTxt.Location = New System.Drawing.Point(182, 95)
        Me.DelComTxt.Name = "DelComTxt"
        Me.DelComTxt.Size = New System.Drawing.Size(154, 24)
        Me.DelComTxt.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 19)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "User Type"
        '
        'DelusTxt
        '
        Me.DelusTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelusTxt.Location = New System.Drawing.Point(182, 58)
        Me.DelusTxt.Name = "DelusTxt"
        Me.DelusTxt.Size = New System.Drawing.Size(154, 22)
        Me.DelusTxt.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "User Name"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Add"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(537, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Delete"
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-2, 75)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(108, 419)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 81
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(958, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 80
        Me.PictureBox2.TabStop = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ExitBtn.Font = New System.Drawing.Font("Myriad Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(737, 353)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(172, 31)
        Me.ExitBtn.TabIndex = 82
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'User_Adding_Deleting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 396)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "User_Adding_Deleting"
        Me.Text = "User_Adding_Deleting"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents usNamTxt As TextBox
    Friend WithEvents PassTxt As TextBox
    Friend WithEvents ConPassTxt As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents usTypComTxt As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DelComTxt As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DelusTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ExitBtn As Button
End Class
