﻿Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim salida As String
        Dim cnt As Integer
        Dim parcial As Integer

        num = CInt(TextBox1.Text())

        For cnt = 0 To 10
            parcial = cnt * num
            salida = salida + num.ToString() + " x " + cnt.ToString() + " = " + parcial.ToString() + Environment.NewLine
        Next
        MessageBox.Show(salida)

    End Sub

End Class