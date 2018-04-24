Imports System.Data.SqlClient
Public Class LoginForm
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim conString As String = "Data Source=.;Initial Catalog=HRMS;Integrated Security=True"
        Dim connection As SqlConnection = New SqlConnection(conString)
        Dim str As String = String.Format("select count(*) from Users  where userId='" & UsernameTextBox.Text.Trim & "' and Userpsw = '" & PasswordTextBox.Text.Trim & "' ")
        Dim com As SqlCommand = New SqlCommand(str, connection)
        Dim form1 As Form1 = New Form1()
        Dim count As Integer = 0
        Try
            connection.Open()
            count = Val(com.ExecuteScalar())
            If count = 0 Then

                MessageBox.Show("用户名或密码错误")
            Else
                form1.Show()
                connection.Close()
                Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class
