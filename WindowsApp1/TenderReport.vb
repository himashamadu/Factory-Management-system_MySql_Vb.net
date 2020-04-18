Public Class TenderReport
    Dim rs As New Resizer
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        CrystalReportViewer1.ReportSource = Application.StartupPath + "/tCrystalReport2.rpt"
        CrystalReportViewer1.SelectionFormula = "{tender_order1.ClientName}= '" & searchTxt.Text.ToString() & "'"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
        '{tender_order1.ClientName}
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim x As DialogResult
        x = MessageBox.Show("Confirm If You want to close", "TDP Construction", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = DialogResult.Yes Then
            Me.Close()
            Dim fmanager As New Factory_Manager_Login
            fmanager.Show()
        End If
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub TenderReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub
End Class