Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click

        If (String.IsNullOrEmpty(txtusername.Text)) Then
            txtusername.BackColor = Color.MistyRose
            txtpassword.BackColor = Color.MistyRose
        End If
        If txtusername.Text = "login" Then
            txtusername.BackColor = Color.White
        Else
            txtusername.BackColor = Color.MistyRose
        End If
        If txtpassword.Text = "abc123" Then
            txtpassword.BackColor = Color.White
        Else
            txtpassword.BackColor = Color.MistyRose
        End If
        If txtusername.Text = "login" Then
        End If
        If txtpassword.Text = "abc123" Then
            MessageBox.Show("帳號密碼輸入正確！")
        End If
    End Sub


    Private Sub out_Click(sender As Object, e As EventArgs) Handles out.Click
        End
    End Sub
End Class
