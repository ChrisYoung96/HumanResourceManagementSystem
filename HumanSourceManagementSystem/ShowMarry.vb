Imports System.Data.SqlClient

Public Class ShowMarry
    Dim dataset As DataSet = New DataSet("HRMS")
    Dim dataAdapter As SqlDataAdapter
    Dim DBhelper As DBHelper = New DBHelper()
    Private Sub ShowMarry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = String.Format("select  Eno, LoverName, LoverBirthday, MarryDate, LoverWorkPlace, LoverPoliticsStatus, LoverJob from EmployeeMarriageStatus")
        dataAdapter = New SqlDataAdapter(str, DBhelper.connection)
        dataAdapter.Fill(dataset, "EmployeeMarriageStatus")
        MarryDataGrid.DataSource = dataset.Tables("EmployeeMarriageStatus")
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Dim sqr As String = String.Format("select  Eno, LoverName, LoverBirthday, MarryDate, LoverWorkPlace, LoverPoliticsStatus, LoverJob from EmployeeMarriageStatus")
        dataset.Tables("EmployeeMarriageStatus").Clear()
        dataAdapter.SelectCommand.CommandText = sqr
        dataAdapter.Fill(dataset, "EmployeeMarriageStatus")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub
End Class