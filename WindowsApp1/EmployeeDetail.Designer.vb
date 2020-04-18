<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeDetail
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeDetail))
        Me.EmployeeExitBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.remBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dateTxt = New System.Windows.Forms.DateTimePicker()
        Me.fNamTxt = New System.Windows.Forms.TextBox()
        Me.ConTxt = New System.Windows.Forms.TextBox()
        Me.AddTxt = New System.Windows.Forms.RichTextBox()
        Me.mailTxt = New System.Windows.Forms.TextBox()
        Me.posTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.idTxt = New System.Windows.Forms.TextBox()
        Me.intTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeExitBtn
        '
        Me.EmployeeExitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmployeeExitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeExitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EmployeeExitBtn.Location = New System.Drawing.Point(683, 397)
        Me.EmployeeExitBtn.Name = "EmployeeExitBtn"
        Me.EmployeeExitBtn.Size = New System.Drawing.Size(113, 29)
        Me.EmployeeExitBtn.TabIndex = 36
        Me.EmployeeExitBtn.Text = "Close"
        Me.EmployeeExitBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.saveBtn.Location = New System.Drawing.Point(534, 397)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(113, 29)
        Me.saveBtn.TabIndex = 34
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(123, 441)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(784, 280)
        Me.DataGridView1.TabIndex = 41
        '
        'remBtn
        '
        Me.remBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.remBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.remBtn.Location = New System.Drawing.Point(395, 397)
        Me.remBtn.Name = "remBtn"
        Me.remBtn.Size = New System.Drawing.Size(113, 29)
        Me.remBtn.TabIndex = 42
        Me.remBtn.Text = "Remove"
        Me.remBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddBtn.Location = New System.Drawing.Point(250, 397)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(113, 29)
        Me.AddBtn.TabIndex = 43
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 74)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(108, 672)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 79
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(964, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dateTxt)
        Me.Panel1.Controls.Add(Me.fNamTxt)
        Me.Panel1.Controls.Add(Me.ConTxt)
        Me.Panel1.Controls.Add(Me.AddTxt)
        Me.Panel1.Controls.Add(Me.mailTxt)
        Me.Panel1.Controls.Add(Me.posTxt)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.idTxt)
        Me.Panel1.Controls.Add(Me.intTxt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(120, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(787, 302)
        Me.Panel1.TabIndex = 80
        '
        'dateTxt
        '
        Me.dateTxt.CustomFormat = "yyyy-MM-dd"
        Me.dateTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTxt.Location = New System.Drawing.Point(169, 150)
        Me.dateTxt.Name = "dateTxt"
        Me.dateTxt.Size = New System.Drawing.Size(231, 21)
        Me.dateTxt.TabIndex = 58
        '
        'fNamTxt
        '
        Me.fNamTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fNamTxt.Location = New System.Drawing.Point(169, 55)
        Me.fNamTxt.Multiline = True
        Me.fNamTxt.Name = "fNamTxt"
        Me.fNamTxt.Size = New System.Drawing.Size(231, 29)
        Me.fNamTxt.TabIndex = 57
        '
        'ConTxt
        '
        Me.ConTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConTxt.Location = New System.Drawing.Point(532, 161)
        Me.ConTxt.Multiline = True
        Me.ConTxt.Name = "ConTxt"
        Me.ConTxt.Size = New System.Drawing.Size(231, 29)
        Me.ConTxt.TabIndex = 56
        '
        'AddTxt
        '
        Me.AddTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTxt.Location = New System.Drawing.Point(532, 51)
        Me.AddTxt.Name = "AddTxt"
        Me.AddTxt.Size = New System.Drawing.Size(231, 93)
        Me.AddTxt.TabIndex = 55
        Me.AddTxt.Text = ""
        '
        'mailTxt
        '
        Me.mailTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mailTxt.Location = New System.Drawing.Point(532, 204)
        Me.mailTxt.Multiline = True
        Me.mailTxt.Name = "mailTxt"
        Me.mailTxt.Size = New System.Drawing.Size(231, 29)
        Me.mailTxt.TabIndex = 54
        '
        'posTxt
        '
        Me.posTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.posTxt.Location = New System.Drawing.Point(169, 225)
        Me.posTxt.Multiline = True
        Me.posTxt.Name = "posTxt"
        Me.posTxt.Size = New System.Drawing.Size(231, 29)
        Me.posTxt.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(461, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 25)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Email :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(424, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 25)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Contact No. :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(436, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 25)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Address :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'idTxt
        '
        Me.idTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idTxt.Location = New System.Drawing.Point(169, 186)
        Me.idTxt.Multiline = True
        Me.idTxt.Name = "idTxt"
        Me.idTxt.Size = New System.Drawing.Size(231, 29)
        Me.idTxt.TabIndex = 49
        '
        'intTxt
        '
        Me.intTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intTxt.Location = New System.Drawing.Point(169, 97)
        Me.intTxt.Multiline = True
        Me.intTxt.Name = "intTxt"
        Me.intTxt.Size = New System.Drawing.Size(231, 29)
        Me.intTxt.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(56, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 25)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Date of Birth :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(64, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "ID Number * :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(85, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 25)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Position :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(8, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Name With  Initials* :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(68, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 25)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Full Name :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 40)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Employee Details"
        '
        'EmployeeDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(923, 733)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.remBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.EmployeeExitBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmployeeDetail"
        Me.Text = "Emloyee Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmployeeExitBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents remBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dateTxt As DateTimePicker
    Friend WithEvents fNamTxt As TextBox
    Friend WithEvents ConTxt As TextBox
    Friend WithEvents AddTxt As RichTextBox
    Friend WithEvents mailTxt As TextBox
    Friend WithEvents posTxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents idTxt As TextBox
    Friend WithEvents intTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
End Class
