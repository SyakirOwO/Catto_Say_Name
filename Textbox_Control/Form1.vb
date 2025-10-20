Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        Dim userInput As String
        userInput = txtName.Text
        lblGreetings.Text = "Hello " & userInput & "."
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub picCatto_Click(sender As Object, e As EventArgs) Handles picCatto.Click
        lblGreetings.Text = "Meow ! !"
    End Sub

    Private Sub picSun_Click(sender As Object, e As EventArgs) Handles picSun.Click
        lblGreetings.Text = "Panasnya harini..."
    End Sub


End Class
