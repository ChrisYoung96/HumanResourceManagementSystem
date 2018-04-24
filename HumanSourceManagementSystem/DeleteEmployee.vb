Imports System.Data.SqlClient

Public Class DeleteEmployee
    Dim DBHelper As DBHelper = New DBHelper()
    Dim Eno As String


    Private Sub save1_Click(sender As Object, e As EventArgs) Handles 删除.Click
        If EnoBox.Text = "" Then
            MessageBox.Show("员工号不能为空！")
        End If

        Dim w As Warning = New Warning()
        w.ShowDialog()
        If w.DialogResult = System.Windows.Forms.DialogResult.OK Then
            Try
                Eno = EnoBox.Text
                Dim sqr0 As String = String.Format("delete from EmployeeBasicInformation where Eno='{0}'", Eno)
                Dim sqr1 As String = String.Format("delete from EmployeeEducationBackground where Eno='{0}'", Eno)
                Dim sqr2 As String = String.Format("delete from EmployeeMarriageStatus where Eno='{0}'", Eno)
                Dim com As SqlCommand = New SqlCommand(sqr2, DBHelper.connection)
                DBHelper.connection.Open()
                Dim result1 As Integer = com.ExecuteNonQuery()
                If result1 > 0 Then
                    MessageBox.Show("已删除婚姻信息")
                End If
                com.CommandText = sqr1
                result1 = com.ExecuteNonQuery()
                If result1 > 0 Then
                    MessageBox.Show("已删除学历信息")
                End If
                com.CommandText = sqr0
                result1 = com.ExecuteNonQuery()
                If result1 > 0 Then
                    MessageBox.Show("已删除基本信息")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                DBHelper.connection.Close()
            End Try
        End If

    End Sub

    Private Sub DeleteEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = String.Format("select Eno from EmployeeBasicInformation")
        Dim DBHelper As DBHelper = New DBHelper()
        Dim com As SqlCommand = New SqlCommand(str, DBHelper.connection)
        Try
            Dim DataReader As SqlDataReader
            DBHelper.connection.Open()
            DataReader = com.ExecuteReader()
            Do While DataReader.Read()
                EnoBox.Items.Add(DataReader("Eno"))

            Loop
            DataReader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            DBHelper.connection.Close()
        End Try
    End Sub


End Class