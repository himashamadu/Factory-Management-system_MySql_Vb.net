Imports MySql.Data.MySqlClient
Public Class User_Adding_Deleting
    Dim rs As New Resizer
    Dim db As New DataBase()
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub User_Adding_Deleting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Public Function UsernameExist(ByVal username As String) As Boolean


        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("user", db.getConnection)
        Dim command As New MySqlCommand("SELECT * FROM `user` WHERE `Username`=@usn", db.getConnection)
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim password As String = PassTxt.Text
        Dim Cpassword As String = ConPassTxt.Text
        If Not String.Equals(password, Cpassword) Then
            MessageBox.Show("Password Not Matching", "TDP Construction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf usNamTxt.Text = "" Or usTypComTxt.Text = "" Or PassTxt.Text = "" Then
            MessageBox.Show("Empty Fields", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf UsernameExist(usNamTxt.Text) Then
            MessageBox.Show("USer Name Already Exist :" & usNamTxt.Text, "TDP Construction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter("user", db.getConnection)
            Dim command As MySqlCommand = New MySqlCommand("INSERT INTO `user`(`Username`, `Password`, `User Type`) VALUES (@usnam,@pass,@usty)", db.getConnection)
            Dim Table As DataTable = New DataTable("user")

            command.Parameters.Add("@usnam", MySqlDbType.VarChar).Value = usNamTxt.Text
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassTxt.Text
            command.Parameters.Add("@usty", MySqlDbType.VarChar).Value = usTypComTxt.Text

            Dim confirm As DialogResult
            confirm = MessageBox.Show("Confirm If You want to Add User", "TDP Construction",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                db.getConnection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("User Add", "TDP Construction",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                db.getConnection.Close()
                db.getConnection.Dispose()
            End If
        End If
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        If DelComTxt.Text = "" Or DelusTxt.Text = "" Then
            MessageBox.Show("Empty Fields", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim command As New MySqlCommand("DELETE FROM `user` WHERE `Username`=@usn AND `User Type`=@usty", db.getConnection)

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = DelusTxt.Text
            command.Parameters.Add("@usty", MySqlDbType.VarChar).Value = DelComTxt.Text

            db.getConnection.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("User Deletes", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No User", "TDP Constructions", MessageBoxButtons.OK, MessageBoxIcon.Error)
                db.getConnection.Close()
                db.getConnection.Dispose()
            End If
        End If
    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim x As DialogResult
        x = MessageBox.Show("Confirm If You want to close", "TDP Constructions", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = DialogResult.Yes Then
            Me.Close()
            Dim top_level As New Top_Level_Manager_Login
            top_level.Show()
        End If
    End Sub
End Class