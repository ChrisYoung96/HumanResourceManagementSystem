Imports System.Data.SqlClient

Public Class ShowBasic
    Dim dataset As DataSet = New DataSet("HRMS")
    Dim dataAdapter As SqlDataAdapter
    Dim DBhelper As DBHelper = New DBHelper()
    Private Sub ShowBasic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = String.Format("select  *  from EmployeeBasicInformation order by Eno asc")
        dataAdapter = New SqlDataAdapter(str, DBHelper.connection)
        dataAdapter.Fill(dataset, "EmployeeBasicInformation")
        DataGridEmployee.DataSource = dataset.Tables("EmployeeBasicInformation")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Dim sqr As String = String.Format("select  * from EmployeeBasicInformation order by Eno asc")
        dataset.Tables("EmployeeBasicInformation").Clear()
        dataAdapter.SelectCommand.CommandText = sqr
        dataAdapter.Fill(dataset, "EmployeeBasicInformation")
    End Sub

    Private Sub ChooseBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChooseBox.SelectedIndexChanged
        If ChooseBox.Text = "按性别" Then
            ChooseTextBox.Text = "请输入性别"
        End If
        If ChooseBox.Text = "按部门" Then
            ChooseTextBox.Text = "请输入部门编号"
        End If
        If ChooseBox.Text = "按民族" Then
            ChooseTextBox.Text = "请输入民族"
        End If
        If ChooseBox.Text = "按状态" Then
            ChooseTextBox.Text = "请输入状态"
        End If
        If ChooseBox.Text = "按政治面貌" Then
            ChooseTextBox.Text = "请输入政治面貌"
        End If
    End Sub

    Private Sub Choose_Click(sender As Object, e As EventArgs) Handles Choose.Click
        Dim a As String
        Dim sql As String
        Select Case ChooseBox.Text
            Case "按性别"
                a = ChooseTextBox.Text
                sql = String.Format("select * from EmployeeBasicInformation where Esex='{0}'", a)
            Case "按部门"
                a = ChooseTextBox.Text
                sql = String.Format("select * from EmployeeBasicInformation where Dno='{0}'", a)
            Case "按民族"
                a = ChooseTextBox.Text
                sql = String.Format("select * from EmployeeBasicInformation where Enation='{0}'", a)
            Case "按状态"
                a = ChooseTextBox.Text
                sql = String.Format("select * from EmployeeBasicInformation where EStatus='{0}'", a)
            Case "按政治面貌"
                a = ChooseTextBox.Text
                sql = String.Format("select * from EmployeeBasicInformation where Epolitic_status='{0}'", a)
            Case Else
                MessageBox.Show("输入有误")
        End Select
        dataset.Tables("EmployeeBasicInformation").Clear()
        dataAdapter.SelectCommand.CommandText = sql
        dataAdapter.Fill(dataset, "EmployeeBasicInformation")
    End Sub

    Private Sub ChooseTextBox_Click(sender As Object, e As EventArgs) Handles ChooseTextBox.Click
        ChooseTextBox.Text = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim sqr As String = String.Format("select  * from EmployeeBasicInformation order by EStatus asc")
        dataset.Tables("EmployeeBasicInformation").Clear()
        dataAdapter.SelectCommand.CommandText = sqr
        dataAdapter.Fill(dataset, "EmployeeBasicInformation")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim sqr As String = String.Format("select  * from EmployeeBasicInformation order by Esex asc")
        dataset.Tables("EmployeeBasicInformation").Clear()
        dataAdapter.SelectCommand.CommandText = sqr
        dataAdapter.Fill(dataset, "EmployeeBasicInformation")
    End Sub
End Class