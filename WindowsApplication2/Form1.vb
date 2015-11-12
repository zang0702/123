Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1C_Click(sender As Object, e As EventArgs) Handles Button1C.Click

        Dim f As Single
        txtbox.Text = f - 32 / 1.8

    End Sub


    Private Sub Button1F_Click(sender As Object, e As EventArgs) Handles Button1F.Click

        Dim c As Single
        txtbox.Text = c * 1.8 + 32

    End Sub
End Class
