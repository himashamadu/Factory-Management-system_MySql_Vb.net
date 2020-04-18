Imports MySql.Data.MySqlClient
Public Class Login_Form
    Dim rs As New Resizer
    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub StoreKCloseBtn_Click(sender As Object, e As EventArgs) Handles StoreKCloseBtn.Click
        cExit.ExitSystem()

    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim db As New DataBase()
        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter("user", db.getConnection)
        Dim command As MySqlCommand = New MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn AND `password` = @pass AND `User Type`=@usetype", db.getConnection)
        Dim Table As DataTable = New DataTable
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = StoreUserTxt.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = StorePassTxt.Text
        command.Parameters.Add("@usetype", MySqlDbType.VarChar).Value = userTypeCmb.Text


        adapter.SelectCommand = command
        adapter.Fill(Table)
        Try
            If Table.Rows.Count > 0 And userTypeCmb.Text = "Manager" Then
                Me.Hide()
                Dim Fmanager As New Factory_Manager_Login()
                Fmanager.Show()
            ElseIf Table.Rows.Count > 0 And userTypeCmb.Text = "Top-Level" Then
                Me.Hide()
                Dim topL As New Top_Level_Manager_Login()
                topL.Show()
            ElseIf Table.Rows.Count > 0 And userTypeCmb.Text = "Store-Keeper" Then
                Me.Hide()
                Dim skeep As New Material_stock()
                skeep.Show()
            Else
                MsgBox("Invalid Input", MsgBoxStyle.Critical, "Login Error")
            End If
        Catch ex As Exception
            MsgBox("Something went Wrong", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If StorePassTxt.UseSystemPasswordChar = True Then
            StorePassTxt.UseSystemPasswordChar = False

        Else
            StorePassTxt.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class
