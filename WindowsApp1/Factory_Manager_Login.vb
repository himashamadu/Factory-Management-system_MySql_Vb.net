Public Class Factory_Manager_Login
    Dim rs As New Resizer
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cExit.ExitSystem()

    End Sub
    Private Sub EmployeeBtn_Click(sender As Object, e As EventArgs) Handles EmployeeBtn.Click
        Me.Hide()
        Dim EmployeeDet As EmployeeDetail = New EmployeeDetail
        EmployeeDet.Show()
    End Sub
    Private Sub DailyProductBtn_Click(sender As Object, e As EventArgs) Handles DailyProductBtn.Click
        Me.Hide()
        Dim DailyProduct As Daily_Production = New Daily_Production
        DailyProduct.Show()
    End Sub

    Private Sub TenderOrderBtn_Click(sender As Object, e As EventArgs) Handles TenderOrderBtn.Click
        Me.Hide()
        Dim TenderOrdersSearch As Tender_Search = New Tender_Search
        TenderOrdersSearch.Show()
    End Sub
    Private Sub MaterialStockBtn_Click(sender As Object, e As EventArgs) Handles MaterialStockBtn.Click
        Me.Hide()
        Dim MaterialStockSearch As Material_Search = New Material_Search
        MaterialStockSearch.Show()
    End Sub
    Private Sub Factory_Manager_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub matRepBtn_Click(sender As Object, e As EventArgs) Handles matRepBtn.Click
        Me.Hide()
        Dim rMaterial As New MaterialReport
        rMaterial.Show()
    End Sub
    Private Sub tenRepBtn_Click(sender As Object, e As EventArgs) Handles tenRepBtn.Click
        Me.Hide()
        Dim rTender As New TenderReport
        rTender.Show()
    End Sub
End Class