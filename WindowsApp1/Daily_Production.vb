Imports MySql.Data.MySqlClient
Public Class Daily_Production
    Dim rs As New Resizer
    Dim table As New DataTable("daily_production")
    Dim db As New DataBase()
    Dim adapter As MySqlDataAdapter = New MySqlDataAdapter("daily_production", db.getConnection)
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub Load_table()
        Try

            Dim SDA As MySqlDataAdapter = New MySqlDataAdapter("daily_production", db.getConnection)
            Dim dbDataset As New DataTable
            Dim bSource As New BindingSource

            db.getConnection.Open()
            Dim Query As String
            Query = "SELECT * FROM tdp .daily_production"
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
    Private Sub Daily_Production_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Load_table()

        table.Columns.Add("Year", Type.GetType("System.String"))
        table.Columns.Add("Month", Type.GetType("System.String"))
        table.Columns.Add("Date", Type.GetType("System.String"))
        table.Columns.Add("White", Type.GetType("System.String"))
        table.Columns.Add("Yellow", Type.GetType("System.String"))

        DataGridView1.DataSource = table
    End Sub

    Private Sub DailyExitBtn_Click(sender As Object, e As EventArgs) Handles DailyExitBtn.Click
        Dim x As DialogResult
        x = MessageBox.Show("Confirm If You want to close", "TDP Construction", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = DialogResult.Yes Then
            Me.Close()
            Dim manager_login As New Factory_Manager_Login
            manager_login.Show()
        End If

    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            db.getConnection.Open()
            If yearTxt.Text = "" Or monTxt.Text = "" Or dateTxt.Text = "" Or WhiteTxt.Text = "" And YellowTxt.Text = "" Then
                MessageBox.Show("Input Neseccary Fields", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim Query As String = "SELECT * FROM `daily_production` WHERE `Date`='" & dateTxt.Text & "'"
                Dim cmd As MySqlCommand = New MySqlCommand(Query, db.getConnection)
                cmd.Parameters.AddWithValue("Date", dateTxt.Text)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    MessageBox.Show("You have already Entered 'Date'!", "Duplicate Values", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    table.Rows.Add(yearTxt.Text, monTxt.Text, dateTxt.Text, WhiteTxt.Text, YellowTxt.Text)
                    DataGridView1.DataSource = table
                End If
            End If
            db.getConnection.Close()
            db.getConnection.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RemBtn_Click(sender As Object, e As EventArgs) Handles RemBtn.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
        Else
            MessageBox.Show("No Rows Selected", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            If DataGridView1.RowCount = 0 Then
                Dim x As DialogResult
                x = MessageBox.Show("Enter the Values", "TDP Constructions",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim bolDuplicateWasFound As Boolean = False
                For x As Integer = 0 To DataGridView1.Rows.Count - 1
                    For y As Integer = 0 To DataGridView1.Rows.Count - 1
                        If y <> x AndAlso DataGridView1.Rows(x).Cells("Date").Value.ToString = DataGridView1.Rows(y).Cells("Date").Value.ToString Then
                            MessageBox.Show("Same Date:  " & DataGridView1.Rows(x).Cells("Date").Value.ToString, "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                            command = New MySqlCommand("INSERT INTO `daily_production`(`Year`, `Month`, `Date`, `White`, `Yellow`) 
                         VALUES (@yea,@mon,@dat,@whit,@yel)", db.getConnection)

                            command.Parameters.Add("@yea", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString
                            command.Parameters.Add("@mon", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(1).Value.ToString
                            command.Parameters.Add("@dat", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(2).Value.ToString
                            command.Parameters.Add("@whit", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(3).Value.ToString
                            command.Parameters.Add("@yel", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(4).Value.ToString


                            command.ExecuteNonQuery()
                        Next
                        MessageBox.Show("Data Insert", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub


End Class