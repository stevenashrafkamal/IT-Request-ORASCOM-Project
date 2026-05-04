Imports RestSharp

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = "https://localhost:44365"
        loginbox.Text = "Steven@gmail.com"
        passtxt.Text = "12345@Steven"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        userid = loginbox.Text
        password = passtxt.Text

        Dim token = logins()

        If String.IsNullOrEmpty(token) Then
            MsgBox("Invalid Username & Password")
            Exit Sub
        Else

            Dim frm As New Menu()
            frm.Show()
            Me.Hide()
        End If

    End Sub
End Class
