Imports MySql.Data.MySqlClient
Public Class EmployeeDetail
    Dim db As New DataBase()
    Dim table As New DataTable("employee_detail")
    Dim rs As New Resizer

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
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub EmoloyeeDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rs.FindAllControls(Me)
        Load_table()


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

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If DataGridView1.RowCount = 0 Then
            Dim x As DialogResult
            x = MessageBox.Show("Enter the Values", "TDP Constructions",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        Else
            Dim bolDuplicateWasFound As Boolean = False
            For x As Integer = 0 To DataGridView1.Rows.Count - 1
                For y As Integer = 0 To DataGridView1.Rows.Count - 1
                    If y <> x AndAlso DataGridView1.Rows(x).Cells("Id Number").Value.ToString = DataGridView1.Rows(y).Cells("Id Number").Value.ToString Then
                        MessageBox.Show("Same ID :  " & DataGridView1.Rows(x).Cells("Id Number").Value.ToString, "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                    Dim command As MySqlCommand
                    For i As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                        command = New MySqlCommand("INSERT INTO `employee_detail`( `FullName`, `NameWithInitials`, `DateOfBirth`, `IdNumber`, `Position`, `Address`, `ContactNumber`, `Email`) 
                          VALUES (@fnam,@int,@dat,@id,@pos,@add,@con,@mail)", db.getConnection)

                        command.Parameters.Add("@fnam", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString
                        command.Parameters.Add("@int", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(1).Value.ToString
                        command.Parameters.Add("@dat", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(2).Value.ToString
                        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(3).Value.ToString
                        command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(4).Value.ToString
                        command.Parameters.Add("@add", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(5).Value.ToString
                        command.Parameters.Add("@con", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(6).Value.ToString
                        command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(7).Value.ToString


                        command.ExecuteNonQuery()

                    Next

                    MessageBox.Show("Data Insert", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    db.getConnection.Close()
                    db.getConnection.Dispose()
                    DataGridView1.DataSource.Clear()
                End If
            End If
        End If




    End Sub

    Private Sub EmployeeExitBtn_Click(sender As Object, e As EventArgs) Handles EmployeeExitBtn.Click
        Dim x As DialogResult
        x = MessageBox.Show("Confirm If You want to close", "TDP Constructions", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = DialogResult.Yes Then
            Me.Close()
            Dim manager_login As New Factory_Manager_Login
            manager_login.Show()
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            db.getConnection.Open()
            If idTxt.Text = "" Or intTxt.Text = "" Then
                MessageBox.Show("Input Neseccary Fields", "TDP Constructions", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            Else
                Dim Query As String = "SELECT * FROM `employee_detail` WHERE `IdNumber`='" & idTxt.Text & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(Query, db.getConnection)
                cmd.Parameters.AddWithValue("Id Number", idTxt.Text)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    MessageBox.Show("You have already Entered 'Id Number'. Check Again", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    table.Rows.Add(fNamTxt.Text, intTxt.Text, dateTxt.Text, idTxt.Text, posTxt.Text, AddTxt.Text,
                                 ConTxt.Text, mailTxt.Text)
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
            MessageBox.Show("No Rows Selected", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub


End Class
