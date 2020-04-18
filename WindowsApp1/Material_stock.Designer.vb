<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Material_stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Material_stock))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.invoiceTxt = New System.Windows.Forms.TextBox()
        Me.RecQuanTxt = New System.Windows.Forms.TextBox()
        Me.issuQuanTxt = New System.Windows.Forms.TextBox()
        Me.balaTxt = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.storeAddBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.subTxt = New System.Windows.Forms.ComboBox()
        Me.rawTxt = New System.Windows.Forms.ComboBox()
        Me.monTxt = New System.Windows.Forms.ComboBox()
        Me.EmployeeExitBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.previousBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(117, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Month"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(71, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Raw Material *"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(96, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Supplier *"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(87, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Invoice No: *"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(406, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Received Date"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(381, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Received Quantity"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(396, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Issued Quantity"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(434, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Balance*"
        '
        'invoiceTxt
        '
        Me.invoiceTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoiceTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.invoiceTxt.Location = New System.Drawing.Point(182, 121)
        Me.invoiceTxt.Multiline = True
        Me.invoiceTxt.Name = "invoiceTxt"
        Me.invoiceTxt.Size = New System.Drawing.Size(156, 20)
        Me.invoiceTxt.TabIndex = 11
        '
        'RecQuanTxt
        '
        Me.RecQuanTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecQuanTxt.Location = New System.Drawing.Point(520, 65)
        Me.RecQuanTxt.Multiline = True
        Me.RecQuanTxt.Name = "RecQuanTxt"
        Me.RecQuanTxt.Size = New System.Drawing.Size(156, 20)
        Me.RecQuanTxt.TabIndex = 12
        '
        'issuQuanTxt
        '
        Me.issuQuanTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issuQuanTxt.Location = New System.Drawing.Point(520, 93)
        Me.issuQuanTxt.Multiline = True
        Me.issuQuanTxt.Name = "issuQuanTxt"
        Me.issuQuanTxt.Size = New System.Drawing.Size(156, 20)
        Me.issuQuanTxt.TabIndex = 13
        '
        'balaTxt
        '
        Me.balaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balaTxt.Location = New System.Drawing.Point(520, 121)
        Me.balaTxt.Multiline = True
        Me.balaTxt.Name = "balaTxt"
        Me.balaTxt.Size = New System.Drawing.Size(156, 20)
        Me.balaTxt.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(520, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(156, 20)
        Me.DateTimePicker1.TabIndex = 15
        Me.DateTimePicker1.Value = New Date(2019, 7, 31, 13, 4, 1, 0)
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
        Me.DataGridView1.Location = New System.Drawing.Point(12, 213)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(738, 248)
        Me.DataGridView1.TabIndex = 16
        '
        'storeAddBtn
        '
        Me.storeAddBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.storeAddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storeAddBtn.Location = New System.Drawing.Point(146, 182)
        Me.storeAddBtn.Name = "storeAddBtn"
        Me.storeAddBtn.Size = New System.Drawing.Size(85, 25)
        Me.storeAddBtn.TabIndex = 28
        Me.storeAddBtn.Text = "Add"
        Me.storeAddBtn.UseVisualStyleBackColor = False
        '
        'updateBtn
        '
        Me.updateBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.updateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.Location = New System.Drawing.Point(371, 182)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(85, 25)
        Me.updateBtn.TabIndex = 31
        Me.updateBtn.Text = "Save"
        Me.updateBtn.UseVisualStyleBackColor = False
        '
        'RemoveBtn
        '
        Me.RemoveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RemoveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBtn.Location = New System.Drawing.Point(255, 182)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(85, 25)
        Me.RemoveBtn.TabIndex = 32
        Me.RemoveBtn.Text = "Remove"
        Me.RemoveBtn.UseVisualStyleBackColor = False
        '
        'subTxt
        '
        Me.subTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTxt.FormattingEnabled = True
        Me.subTxt.Items.AddRange(New Object() {"Maggie", "Chiye", "Big World", "Tracy", "Kevin"})
        Me.subTxt.Location = New System.Drawing.Point(182, 36)
        Me.subTxt.Name = "subTxt"
        Me.subTxt.Size = New System.Drawing.Size(156, 21)
        Me.subTxt.TabIndex = 33
        '
        'rawTxt
        '
        Me.rawTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rawTxt.FormattingEnabled = True
        Me.rawTxt.Items.AddRange(New Object() {"Glass Bead A", "Glass Bead B", "Talc", "Titanium", "Wax", "Eva", "Oil", "Dolamite", "Bags"})
        Me.rawTxt.Location = New System.Drawing.Point(182, 63)
        Me.rawTxt.Name = "rawTxt"
        Me.rawTxt.Size = New System.Drawing.Size(156, 21)
        Me.rawTxt.TabIndex = 34
        '
        'monTxt
        '
        Me.monTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monTxt.FormattingEnabled = True
        Me.monTxt.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.monTxt.Location = New System.Drawing.Point(182, 93)
        Me.monTxt.Name = "monTxt"
        Me.monTxt.Size = New System.Drawing.Size(156, 21)
        Me.monTxt.TabIndex = 35
        '
        'EmployeeExitBtn
        '
        Me.EmployeeExitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmployeeExitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeExitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EmployeeExitBtn.Location = New System.Drawing.Point(590, 182)
        Me.EmployeeExitBtn.Name = "EmployeeExitBtn"
        Me.EmployeeExitBtn.Size = New System.Drawing.Size(85, 25)
        Me.EmployeeExitBtn.TabIndex = 37
        Me.EmployeeExitBtn.Text = "Exit"
        Me.EmployeeExitBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.monTxt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.rawTxt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.subTxt)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.invoiceTxt)
        Me.Panel1.Controls.Add(Me.RecQuanTxt)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.issuQuanTxt)
        Me.Panel1.Controls.Add(Me.balaTxt)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(738, 164)
        Me.Panel1.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(219, 36)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Material Stock"
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.previousBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previousBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.previousBtn.Location = New System.Drawing.Point(484, 182)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(85, 25)
        Me.previousBtn.TabIndex = 40
        Me.previousBtn.Text = "Previous "
        Me.previousBtn.UseVisualStyleBackColor = False
        '
        'Material_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(762, 471)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EmployeeExitBtn)
        Me.Controls.Add(Me.RemoveBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.storeAddBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Material_stock"
        Me.Text = "Material_stock"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents invoiceTxt As TextBox
    Friend WithEvents RecQuanTxt As TextBox
    Friend WithEvents issuQuanTxt As TextBox
    Friend WithEvents balaTxt As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents storeAddBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents RemoveBtn As Button
    Friend WithEvents subTxt As ComboBox
    Friend WithEvents rawTxt As ComboBox
    Friend WithEvents monTxt As ComboBox
    Friend WithEvents EmployeeExitBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents previousBtn As Button
End Class
