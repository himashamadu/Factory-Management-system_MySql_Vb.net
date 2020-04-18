Public Class MaterialReport
    Dim rs As New Resizer
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    Private Sub MaterialReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim x As DialogResult
        x = MessageBox.Show("Confirm If You want to close", "TDP Construction", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        CrystalReportViewer1.ReportSource = Application.StartupPath + "/mCrystalReport2.rpt"
        CrystalReportViewer1.SelectionFormula = "{material_stock1.Supplier}= '" & searchTxt.Text.ToString() & "'"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class