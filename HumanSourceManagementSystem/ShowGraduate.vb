Imports System.Data.SqlClient

Public Class ShowGraduate
    Dim dataset As DataSet = New DataSet("HRMS")
    Dim dataAdapter As SqlDataAdapter
    Dim DBhelper As DBHelper = New DBHelper()
    Private Sub ShowGraduate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = String.Format("select  Eno, EducationBackground, Major, GraduationTime, School, SchoolType, ForeignLanguage, Languagelevel from EmployeeEducationBackground")
        dataAdapter = New SqlDataAdapter(str, DBhelper.connection)
        dataAdapter.Fill(dataset, "EmployeeEducationBackground")
        GraduateDataGrid.DataSource = dataset.Tables("EmployeeEducationBackground")

    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Dim sqr As String = String.Format("select  Eno, EducationBackground, Major, GraduationTime, School, SchoolType, ForeignLanguage, Languagelevel from EmployeeEducationBackground")
        dataset.Tables("EmployeeEducationBackground").Clear()
        dataAdapter.SelectCommand.CommandText = sqr
        dataAdapter.Fill(dataset, "EmployeeEducationBackground")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub ChooseBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChooseBox.SelectedIndexChanged
        If ChooseBox.Text = "按专业" Then
            ChooseTextBox.Text = "请输入专业"
        End If
        If ChooseBox.Text = "按学历" Then
            ChooseTextBox.Text = "请输入学历"
        End If
    End Sub
    Private Sub ChooseTextBox_Click(sender As Object, e As EventArgs) Handles ChooseTextBox.Click
        ChooseTextBox.Text = ""
    End Sub

    Private Sub Choose_Click(sender As Object, e As EventArgs) Handles Choose.Click
        Dim a As String
        Dim sql As String
        Try
            Select Case ChooseBox.Text
                Case "按专业"
                    a = ChooseTextBox.Text
                    sql = String.Format("select * from  EmployeeEducationBackground where Major='{0}'", a)
                Case "按学历"
                    a = ChooseTextBox.Text
                    sql = String.Format("select * from EmployeeEducationBackground where EducationBackground='{0}'", a)
                Case Else
                    MessageBox.Show("输入有误")
            End Select
            dataset.Tables("EmployeeEducationBackground").Clear()
            dataAdapter.SelectCommand.CommandText = sql
            dataAdapter.Fill(dataset, "EmployeeEducationBackground")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class