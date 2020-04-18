Imports MySql.Data.MySqlClient
Public Class Employee_Search
    Dim table As New DataTable("employee_detail")
    Dim db As New DataBase()
    Dim rs As New Resizer
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub Load_table()
        Try
            Dim SDA As New MySqlDataAdapter
            Dim dbDataset As New DataTable
            Dim bSource As New BindingSource

            db.getConnection.Open()
            Dim Query As String
            Query = "SELECT * FROM tdp.employee_detail"
            Dim Command = New MySqlCommand(Query, db.getConnection)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)

            db.getConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Employee_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Load_table()

        table.Columns.Add("Employee Code", Type.GetType("System.String"))
        table.Columns.Add("Full Name", Type.GetType("System.String"))
        table.Columns.Add("Name With Initials", Type.GetType("System.String"))
        table.Columns.Add("Date of Birth", Type.GetType("System.String"))
        table.Columns.Add("Id Number", Type.GetType("System.String"))
        table.Columns.Add("	Position", Type.GetType("System.String"))
        table.Columns.Add("Address", Type.GetType("System.String"))
        table.Columns.Add("Contact Number", Type.GetType("System.String"))
        table.Columns.Add("Email", Type.GetType("System.String"))

        DataGridView1.DataSource = table
    End Sub
    Private Sub FilterData(ValueToSearch As String)
        If SearchTxt.Text = "" Then
            MessageBox.Show("Enter Value", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim searchQuery As String = "SELECT * FROM `employee_detail` WHERE `EmployeeCode` like '%" & ValueToSearch & "%' OR `IdNumber` 
                                       like '%" & ValueToSearch & "%'"

            Dim Command = New MySqlCommand(searchQuery, db.getConnection)
            Dim adapter As New MySqlDataAdapter(Command)
            Dim table As New DataTable

            adapter.Fill(table)

            DataGridView1.DataSource = table
        End If
    End Sub
    Private Sub EmpSearchBtn_Click(sender As Object, e As EventArgs) Handles EmpSearchBtn.Click
        FilterData(SearchTxt.Text)
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Dim x As DialogResult
        x = MessageBox.Show("Confirm If You want to close", "TDP Constructions", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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