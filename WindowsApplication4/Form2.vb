Public Class Form2
    Dim Op1 As Integer
    Dim Op2 As Integer
    Dim Result As Integer
    Dim Op3 As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Op1 = CInt(TextBox1.Text())
        Op2 = CInt(TextBox2.Text())
        Op3 = CInt(TextBox3.Text())

        If Op1 < Op2 And Op1 < Op3 Then
            Result = Op1
        ElseIf Op2 < Op1 And Op2 < Op3
            Result = Op2
        Else
            Result = Op3
        End If

        Label1.Text = Result.ToString()
    End Sub
End Class