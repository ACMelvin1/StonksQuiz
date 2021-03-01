Public Class Creditsform
    Private Sub ButtonNo_Click(sender As Object, e As EventArgs) Handles ButtonNo.Click
        MessageBox.Show("Wrong Answer, try again")
    End Sub

    Private Sub ButtonYes_Click(sender As Object, e As EventArgs) Handles ButtonYes.Click
        MessageBox.Show("Thank you, goodbye")
        Application.Exit()
    End Sub
End Class