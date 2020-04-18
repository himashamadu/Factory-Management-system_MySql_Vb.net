Imports MySql.Data.MySqlClient
Public Class Daily_Production_Search
    Dim table As New DataTable("daily_production")
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
            Query = "SELECT * FROM tdp.daily_production"
            Dim Command = New MySqlCommand(Query, db.getConnection)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)

            db.getConnection.Close()
            db.getConnection.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Daily_Production_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Load_table()

        table.Columns.Add("Year", Type.GetType("System.String"))
        table.Columns.Add("Month", Type.GetType("System.String"))
        table.Columns.Add("Date", Type.GetType("System.String"))
        table.Columns.Add("White", Type.GetType("System.String"))
        table.Columns.Add("Yellow", Type.GetType("System.String"))

        DataGridView1.DataSource = table
    End Sub
    Private Sub FilterData(ValueToSearch As String)
        If Searchtxt.Text = "" Then

            MessageBox.Show("Please Enter Value", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim searchQuery As String = "SELECT * FROM `daily_production` WHERE `Year` like '%" & ValueToSearch & "%' OR 
                                      `Month` like '%" & ValueToSearch & "%' OR `Date` like '%" & ValueToSearch & "%'"

            Dim Command = New MySqlCommand(searchQuery, db.getConnection)
            Dim adapter As New MySqlDataAdapter(Command)
            Dim table As New DataTable

            adapter.Fill(table)

            DataGridView1.DataSource = table
        End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        FilterData(Searchtxt.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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