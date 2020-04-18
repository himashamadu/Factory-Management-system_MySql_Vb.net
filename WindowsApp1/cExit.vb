Public Class cExit
    Public Shared Function ExitSystem()
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm If You Want to Exit", "TDP Thermoline",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths


End Class
