Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Single
        Dim num2 As Single
        Dim result As Single

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        result = num1 + num2

        TextBox3.Text = result

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Single
        Dim num2 As Single
        Dim result As Single

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        result = num1 - num2

        TextBox3.Text = result
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Single
        Dim num2 As Single
        Dim result As Single

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        result = num1 * num2

        TextBox3.Text = result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Single
        Dim num2 As Single
        Dim result As Single

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        result = num1 / num2

        TextBox3.Text = result
    End Sub
End Class