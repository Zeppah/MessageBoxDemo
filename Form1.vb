Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Hello there!")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("The Last Name field must not be blank.", _
                        "Last name", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Exclamation)
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MessageBox.Show("A bad database error has occurred.", _
                        "UpdateCustomerTable", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Error)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim intResponse As DialogResult

        intResponse = MessageBox.Show("Are you sure you want to quit?", _
                                       "Quit", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question)

        If intResponse = DialogResult.Yes Then
            ' End                
            MessageBox.Show("Code to end the app would go here.")
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Dim intResponse As DialogResult

        intResponse = MessageBox.Show("Are you sure you want to delete all of the rows in the Customer table?", "Delete", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question, _
                                       MessageBoxDefaultButton.Button1)
        If intResponse = DialogResult.Yes Then
            ' delete the rows ...
            MessageBox.Show("Code to delete the rows would go here.")
        End If

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

End Class
