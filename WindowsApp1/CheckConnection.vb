Imports MySql.Data.MySqlClient
Public Class CheckConnection
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub
    Dim MySqlConn As MySqlConnection
    Private Sub CheckBtn_Click(sender As Object, e As EventArgs) Handles CheckBtn.Click
        Try
            MySqlConn = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=tdp;")
            MySqlConn.Open()
            ConnectLbl.Text = "Connected"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


End Class