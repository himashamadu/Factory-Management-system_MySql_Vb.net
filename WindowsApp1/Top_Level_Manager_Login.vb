Public Class Top_Level_Manager_Login
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
        Dim EmployeeDetSearch As Employee_Search = New Employee_Search
        EmployeeDetSearch.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim DailyProdSearch As Daily_Production_Search = New Daily_Production_Search
        DailyProdSearch.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Dim TenderOrders As Tender_Purchases = New Tender_Purchases
        TenderOrders.Show()
    End Sub
    Private Sub MaterialStBtn_Click(sender As Object, e As EventArgs) Handles MaterialStBtn.Click
        Me.Hide()
        Dim MaterialSearch As Material_Search = New Material_Search
        Material_Search.Show()
    End Sub
    Private Sub Top_Level_Manager_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub userAdd_Click(sender As Object, e As EventArgs) Handles userAdd.Click
        Me.Hide()
        Dim usAdd As User_Adding_Deleting = New User_Adding_Deleting
        usAdd.Show()
    End Sub
    Private Sub repEmpBtn_Click(sender As Object, e As EventArgs) Handles repEmpBtn.Click
        Me.Hide()
        Dim rEmpolee As New EmployeeReport
        rEmpolee.Show()
    End Sub

    Private Sub RepDaiBtn_Click(sender As Object, e As EventArgs) Handles RepDaiBtn.Click
        Me.Hide()
        Dim dailyRep As New DailyReport
        dailyRep.Show()
    End Sub

    Private Sub RepMatBtn_Click(sender As Object, e As EventArgs) Handles RepMatBtn.Click
        Me.Hide()
        Dim rMaterial As New MaterialReport
        rMaterial.Show()
    End Sub
End Class