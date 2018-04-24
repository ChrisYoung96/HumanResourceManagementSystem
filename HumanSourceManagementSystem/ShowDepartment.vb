Imports System.Data.SqlClient

Public Class ShowDepartment
    Dim dataset As DataSet = New DataSet("HRMS")
    Dim dataAdapter As SqlDataAdapter
    Dim DBhelper As DBHelper = New DBHelper()

    Private Sub ShowDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = String.Format("select  *  from Department")
        dataAdapter = New SqlDataAdapter(str, DBhelper.connection)
        dataAdapter.Fill(dataset, "Department")
        DataGridView1.DataSource = dataset.Tables("Department")
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Dim sqr As String = String.Format("select  * from Department")
        dataset.Tables("Department").Clear()
        dataAdapter.SelectCommand.CommandText = sqr
        dataAdapter.Fill(dataset, "Department")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub
End Class