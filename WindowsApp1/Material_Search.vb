Imports MySql.Data.MySqlClient
Public Class Material_Search
    Dim table As New DataTable("material_stock")
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
            Query = "SELECT * FROM tdp.material_stock "
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

    Private Sub Material_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Load_table()

        table.Columns.Add("Supplier", Type.GetType("System.String"))
        table.Columns.Add("Raw Material", Type.GetType("System.String"))
        table.Columns.Add("Month", Type.GetType("System.String"))
        table.Columns.Add("Invoice No:", Type.GetType("System.String"))
        table.Columns.Add("Received Date", Type.GetType("System.String"))
        table.Columns.Add("Received Quantity", Type.GetType("System.String"))
        table.Columns.Add("Issued Quantity", Type.GetType("System.String"))
        table.Columns.Add("Balance", Type.GetType("System.String"))

        DataGridView1.DataSource = table
    End Sub
    Private Sub FilterData(ValueToSearch As String)
        If SearchTxt.Text = "" Then
            MessageBox.Show("Enter Value", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim searchQuery As String = "SELECT * FROM `material_stock` WHERE `Supplier` like '%" & ValueToSearch & "%' OR `RawMaterial` like '%" & ValueToSearch & "%' OR 
                                     `Month` like '%" & ValueToSearch & "%'"

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

        End If
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub


End Class