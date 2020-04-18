Imports MySql.Data.MySqlClient
Public Class Tender_Purchases
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

    Private Sub Tender_Purchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub TenderExitBtn_Click(sender As Object, e As EventArgs) Handles TenderExitBtn.Click
        Dim x As DialogResult
        x = MessageBox.Show("Confirm If You want to close", "TDP Constructions", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = DialogResult.Yes Then
            Me.Close()
            Dim top_level As New Top_Level_Manager_Login
            top_level.Show()
        End If
    End Sub

    Private Sub whiteTotalBtn_Click(sender As Object, e As EventArgs) Handles whiteTotalBtn.Click
        Try
            If Not IsNumeric(QwhitTxt.Text) And Not IsNumeric(perWhitTxt.Text) Then
                MessageBox.Show("Please enter in Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim whiteQ As Decimal = CDec(QwhitTxt.Text)
                Dim whiteP As Decimal = CDec(perWhitTxt.Text)
                Dim wtotal = whiteQ * whiteP

                TwhiTxt.Text = CDec(wtotal)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub YelTotBtn_Click(sender As Object, e As EventArgs) Handles YelTotBtn.Click
        Try
            If Not IsNumeric(QyelTxt.Text) And Not IsNumeric(PYelTxt.Text) Then
                MessageBox.Show("Please enter in Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim yellowQ As Decimal = CDec(QyelTxt.Text)
                Dim yellowP As Decimal = CDec(PYelTxt.Text)
                Dim ytotal = yellowQ * yellowP

                TyelTxt.Text = CDec(ytotal)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub totalWYbtn_Click(sender As Object, e As EventArgs) Handles totalWYbtn.Click

        If TwhiTxt.Text Is String.Empty Then
            Dim tyel As Decimal = CDec(TyelTxt.Text)
            Dim ytotal = tyel
            TwhyeTxt.Text = CDec(ytotal)
        ElseIf TyelTxt.Text Is String.Empty Then
            Dim twhi As Decimal = CDec(TwhiTxt.Text)
            Dim wtotal = twhi
            TwhyeTxt.Text = CDec(wtotal)
        Else
            Dim twhi As Decimal = CDec(TwhiTxt.Text)
            Dim tyel As Decimal = CDec(TyelTxt.Text)
            Dim wytotal = twhi + tyel
            TwhyeTxt.Text = CStr(wytotal)
        End If

    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            db.getConnection.Open()

            If ReqnoTxt.Text = "" Or PurTxt.Text = "" Or ClieTxt.Text = "" Then
                MessageBox.Show("Input Neseccary Fields", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim Query As String = "SELECT * FROM `tender_order` WHERE `RequestNo`='" & ReqnoTxt.Text & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(Query, db.getConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    MessageBox.Show("You have already Entered 'Request No'. Check Again", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    table.Rows.Add(ReqnoTxt.Text, PurTxt.Text, ItTxt.Text, ClieTxt.Text, DateTimePicker1.Text, QwhitTxt.Text,
                                       QyelTxt.Text, perWhitTxt.Text, PYelTxt.Text, TwhiTxt.Text, TyelTxt.Text,
                                       TwhyeTxt.Text, DesTxt.Text)
                    DataGridView1.DataSource = table
                End If
            End If
            db.getConnection.Close()
            db.getConnection.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub remBtn_Click(sender As Object, e As EventArgs) Handles remBtn.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
        Else
            MessageBox.Show("No Rows Selected", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If DataGridView1.RowCount = 0 Then
            Dim x As DialogResult
            x = MessageBox.Show("Click Add Button", "TDP Constructions",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        Else
            Dim bolDuplicateWasFound As Boolean = False
            For x As Integer = 0 To DataGridView1.Rows.Count - 1
                For y As Integer = 0 To DataGridView1.Rows.Count - 1
                    If y <> x AndAlso DataGridView1.Rows(x).Cells("Request No").Value.ToString = DataGridView1.Rows(y).Cells("Request No").Value.ToString Then
                        MessageBox.Show("Same Request No:  " & DataGridView1.Rows(x).Cells("Request No").Value.ToString, "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                    DataGridView1.AllowUserToAddRows = False
                    Dim cmd As MySqlCommand
                    For i As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                        cmd = New MySqlCommand("INSERT INTO `tender_order`(`RequestNo`, `PurchaseOrderNo`, `ItemNo`, `ClientName`, `Date`, `QuantityWhite`, `QuantityYellow`, `UnitPriceWhite`, 
                                         `UnitPriceYellow`, `TotalWhite`, `TotalYellow`, `TotalPrice`, `Description`)
                                         VALUES (@re,@pu,@it,@cli,@dat,@qw,@qy,@pw,@py,@tw,@ty,@tp,@des)", db.getConnection)

                        cmd.Parameters.Add("@re", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString
                        cmd.Parameters.Add("@pu", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(1).Value.ToString
                        cmd.Parameters.Add("@it", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(2).Value.ToString
                        cmd.Parameters.Add("@cli", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(3).Value.ToString
                        cmd.Parameters.Add("@dat", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(4).Value.ToString
                        cmd.Parameters.Add("@qw", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(5).Value.ToString
                        cmd.Parameters.Add("@qy", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(6).Value.ToString
                        cmd.Parameters.Add("@pw", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(7).Value.ToString
                        cmd.Parameters.Add("@py", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(8).Value.ToString
                        cmd.Parameters.Add("@tw", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(9).Value.ToString
                        cmd.Parameters.Add("@ty", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(10).Value.ToString
                        cmd.Parameters.Add("@tp", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(11).Value.ToString
                        cmd.Parameters.Add("@des", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(12).Value.ToString

                        cmd.ExecuteNonQuery()
                    Next

                    MessageBox.Show("Data Inserted", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    db.getConnection.Close()
                    db.getConnection.Dispose()
                    DataGridView1.DataSource.Clear()
                End If
            End If
        End If
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class