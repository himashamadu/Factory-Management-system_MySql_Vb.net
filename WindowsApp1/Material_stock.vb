Imports MySql.Data.MySqlClient
Public Class Material_stock
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
    Private Sub storeAddBtn_Click(sender As Object, e As EventArgs) Handles storeAddBtn.Click
        Try
            db.getConnection.Open()

            If subTxt.Text = "" Or rawTxt.Text = "" Or balaTxt.Text = "" Then
                MessageBox.Show("Please Fill the Fields", "Notice")
            Else
                Dim Query As String = "SELECT * FROM `material_stock` WHERE `InvoiceNo:`='" & invoiceTxt.Text & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(Query, db.getConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    MessageBox.Show("You have already Entered 'Invoice Number'. Check Again", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    table.Rows.Add(subTxt.Text, rawTxt.Text, monTxt.Text, invoiceTxt.Text, DateTimePicker1.Text,
                           RecQuanTxt.Text, issuQuanTxt.Text, balaTxt.Text)
                    DataGridView1.DataSource = table
                End If
            End If
            db.getConnection.Close()
            db.getConnection.Dispose
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub updateBtnClick(sender As Object, e As EventArgs) Handles updateBtn.Click
        Try
            If DataGridView1.RowCount = 0 Then
                Dim x As DialogResult
                x = MessageBox.Show("Enter the Values", "TDP Constructions",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            Else
                Dim bolDuplicateWasFound As Boolean = False
                For x As Integer = 0 To DataGridView1.Rows.Count - 1
                    For y As Integer = 0 To DataGridView1.Rows.Count - 1
                        If y <> x AndAlso DataGridView1.Rows(x).Cells("Invoice No:").Value.ToString = DataGridView1.Rows(y).Cells("Invoice No:").Value.ToString Then
                            MessageBox.Show("Same Invoice No:  " & DataGridView1.Rows(x).Cells("Invoice No:").Value.ToString, "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    Next
                Next
                If Not bolDuplicateWasFound Then
                    Dim confirm As DialogResult
                    confirm = MessageBox.Show("Confirm If You want to Save Data", "TDP Constructions",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If confirm = DialogResult.Yes Then
                        db.getConnection.Open()
                        Dim cmd As MySqlCommand
                        For i As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1

                            cmd = New MySqlCommand("INSERT INTO `material_stock`(`Supplier`, `RawMaterial`, `Month`, `InvoiceNo:`, `ReceivedDate`, `ReceivedQuantity`, `IssuedQuantity`, `Balance`) 
                                      VALUES (@sup,@raw,@mon,@inv,@redate,@requan,@isquan,@bal)", db.getConnection)


                            cmd.Parameters.Add("@sup", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString
                            cmd.Parameters.Add("@raw", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(1).Value.ToString
                            cmd.Parameters.Add("@mon", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(2).Value.ToString
                            cmd.Parameters.Add("@inv", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(3).Value.ToString
                            cmd.Parameters.Add("@redate", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(4).Value.ToString
                            cmd.Parameters.Add("@requan", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(5).Value.ToString
                            cmd.Parameters.Add("@isquan", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(6).Value.ToString
                            cmd.Parameters.Add("@bal", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(7).Value.ToString


                            cmd.ExecuteNonQuery()

                        Next

                        MessageBox.Show("All data Inserted", "TDP Construction", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        db.getConnection.Close()
                        db.getConnection.Dispose()
                        DataGridView1.DataSource.Clear()
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
        Else
            MessageBox.Show("No Rows Selected", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub EmployeeExitBtn_Click(sender As Object, e As EventArgs) Handles EmployeeExitBtn.Click
        cExit.ExitSystem()
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        Load_table()
    End Sub
End Class