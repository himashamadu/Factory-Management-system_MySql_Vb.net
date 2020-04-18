Public Class EmployeeReport
    Dim rs As New Resizer
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        CrystalReportViewer1.ReportSource = Application.StartupPath + "/eCrystalReport2.rpt"
        CrystalReportViewer1.SelectionFormula = "{employee_detail1.Position}='" & searchTxt.Text.ToString() & "'"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()

    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    Private Sub EmployeeReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim x As DialogResult
        x = MessageBox.Show("Confirm If You want to close", "TDP Construction", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = DialogResult.Yes Then
            Me.Close()
            Dim top_level As New Top_Level_Manager_Login
            top_level.Show()
        End If
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class