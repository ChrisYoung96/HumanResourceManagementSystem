Imports System.Data.SqlClient

Public Class SearchEmployee
    Dim DBHelper As DBHelper = New DBHelper()


    Private Sub Choose_Click(sender As Object, e As EventArgs) Handles Choose.Click
        Dim Eno As String
        Dim Ename As String
        Dim EStatus As String
        Dim Ephone As String
        Dim Esex As String


        Dim sqr As String = String.Format("Select Eno, Ename,Esex, EStatus,Ephone from EmployeeBasicInformation where Eno='{0}'", TextBox1.Text)
        Dim sql As String = String.Format("Select Eno, Ename, Esex,EStatus,Ephone from EmployeeBasicInformation where EStatus='{0}'", TextBox1.Text)
        Select Case ChooseTextBox.Text
            Case "查询员工"
                Try
                    Dim i As Integer = 0
                    Dim com As SqlCommand = New SqlCommand(sqr, DBHelper.connection)
                    DBHelper.connection.Open()
                    Dim datareader As SqlDataReader = com.ExecuteReader()
                    EmployeeListView.Items.Clear()
                    If Not datareader.HasRows Then
                        MessageBox.Show("输入错误！")
                    Else
                        Do While datareader.Read()
                            Eno = datareader("Eno")
                            Ename = datareader("Ename")
                            Esex = datareader("Esex")
                            EStatus = datareader("EStatus")
                            Ephone = datareader("Ephone")
                            Dim str() As String = {Ename, Esex, EStatus, Ephone}
                            Dim eml As ListViewItem = New ListViewItem(Eno)
                            eml.Tag = Val(datareader("Eno"))
                            EmployeeListView.Items.Add(eml)
                            eml.SubItems.AddRange(str)
                            i = i + 1
                        Loop
                        TextBox2.Text = i

                    End If
                    datareader.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                DBHelper.connection.Close()
            Case "查询员工状态"
                Try
                    Dim i As Integer = 0
                    Dim com As SqlCommand = New SqlCommand(sql, DBHelper.connection)
                    DBHelper.connection.Open()
                    Dim datareader As SqlDataReader = com.ExecuteReader()
                    EmployeeListView.Items.Clear()
                    If Not datareader.HasRows Then
                        MessageBox.Show("输入错误！")
                    Else
                        Do While datareader.Read()
                            Eno = datareader("Eno")
                            Ename = datareader("Ename")
                            EStatus = datareader("EStatus")
                            Ephone = datareader("Ephone")
                            Esex = datareader("Esex")
                            Dim str() As String = {Ename, Esex, EStatus, Ephone}
                            Dim eml As ListViewItem = New ListViewItem(Eno)
                            eml.Tag = Val(datareader("Eno"))
                            EmployeeListView.Items.Add(eml)
                            eml.SubItems.AddRange(str)
                            i = i + 1
                        Loop
                        TextBox2.Text = i

                    End If
                    datareader.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                DBHelper.connection.Close()
        End Select
    End Sub

    Private Sub ChooseTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChooseTextBox.SelectedIndexChanged
        If ChooseTextBox.Text = "查询员工" Then

            TextBox1.Text = "请输入员工号"
        End If
        If ChooseTextBox.Text = "查询员工状态" Then

            TextBox1.Text = "请输入员工状态"
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub


End Class