Imports MySql.Data.MySqlClient
Public Class Tender_Search
    Dim db As New DataBase()
    Dim table As New DataTable("tender_order")
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
            Query = "SELECT * FROM tdp.tender_order"
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
    Private Sub Tender_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Load_table()

        table.Columns.Add("Request No", Type.GetType("System.String"))
        table.Columns.Add("Purchase Order No", Type.GetType("System.String"))
        table.Columns.Add("Item No", Type.GetType("System.String"))
        table.Columns.Add("Client Name", Type.GetType("System.String"))
        table.Columns.Add("Date", Type.GetType("System.String"))
        table.Columns.Add("Quantity white", Type.GetType("System.String"))
        table.Columns.Add("Quantity yellow", Type.GetType("System.String"))
        table.Columns.Add("Unit Price white", Type.GetType("System.String"))
        table.Columns.Add("Unit Price yellow", Type.GetType("System.String"))
        table.Columns.Add("Total white", Type.GetType("System.String"))
        table.Columns.Add("Total yellow", Type.GetType("System.String"))
        table.Columns.Add("Total Price", Type.GetType("System.String"))
        table.Columns.Add("Description", Type.GetType("System.String"))

        DataGridView1.DataSource = table
    End Sub

    Private Sub FilterData(ValueToSearch As String)
        If SearchTxt.Text = "" Then
            MessageBox.Show("Enter Value", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim searchQuery As String = "SELECT * FROM `tender_order` WHERE `RequestNo` like '%" & ValueToSearch & "%' OR 
                                      `ClientName` like '%" & ValueToSearch & "%'"

            Dim Command = New MySqlCommand(searchQuery, db.getConnection)
            Dim adapter As New MySqlDataAdapter(Command)
            Dim table As New DataTable

            adapter.Fill(table)

            DataGridView1.DataSource = table
        End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        FilterData(SearchTxt.Text)
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Dim x As DialogResult
        x = MessageBox.Show("Confirm If You want to close", "TDP Constructions", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = DialogResult.Yes Then
            Me.Close()
            Dim manager As New Factory_Manager_Login
            manager.Show()
        End If
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class