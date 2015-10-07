Public Class Form1
    Public Property Op1 As Integer
    Public Property Op2 As Integer
    Public Property x As Integer


    Private Sub SumaBtn_Click(sender As Object, e As EventArgs) Handles SumaBtn.Click
        Op1 = CInt(TextBox1.Text)
        Op2 = CInt(TextBox2.Text)
        x = Op1 + Op2
        Label1.Text = x.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Op1 = CInt(TextBox1.Text)
        Op2 = CInt(TextBox2.Text)
        x = Op1 - Op2
        Label1.Text = x.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Op1 = CInt(TextBox1.Text)
        Op2 = CInt(TextBox2.Text)
        x = Op1 / Op2
        Label1.Text = x.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Op1 = CInt(TextBox1.Text)
        Op2 = CInt(TextBox2.Text)
        x = Op1 * Op2
        Label1.Text = x.ToString()
    End Sub
End Class
