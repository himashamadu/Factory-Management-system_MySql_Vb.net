<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckConnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckConnection))
        Me.CheckBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.ConnectLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CheckBtn
        '
        Me.CheckBtn.Location = New System.Drawing.Point(67, 65)
        Me.CheckBtn.Name = "CheckBtn"
        Me.CheckBtn.Size = New System.Drawing.Size(164, 22)
        Me.CheckBtn.TabIndex = 0
        Me.CheckBtn.Text = "Checking Connection"
        Me.CheckBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(84, 179)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'ConnectLbl
        '
        Me.ConnectLbl.AutoSize = True
        Me.ConnectLbl.Location = New System.Drawing.Point(291, 74)
        Me.ConnectLbl.Name = "ConnectLbl"
        Me.ConnectLbl.Size = New System.Drawing.Size(28, 13)
        Me.ConnectLbl.TabIndex = 2
        Me.ConnectLbl.Text = "###"
        '
        'CheckConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ConnectLbl)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.CheckBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CheckConnection"
        Me.Text = "CheckConnection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents ConnectLbl As Label
End Class
