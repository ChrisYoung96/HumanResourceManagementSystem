Imports System.Data.SqlClient

Public Class ShowPosition
    Dim dataSet As DataSet = New DataSet("HRMS")
    Dim dataAdapter As SqlDataAdapter
    Dim DBHelper As DBHelper = New DBHelper()

    Private Sub ShowPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqr As String = String.Format("select * from Position")
        dataAdapter = New SqlDataAdapter(sqr, DBHelper.connection)
        dataAdapter.Fill(dataSet, "Position")
        DataGridView1.DataSource = dataSet.Tables("Position")

    End Sub
    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Dim sqr As String = String.Format("select  * from Position")
        dataSet.Tables("Position").Clear()
        dataAdapter.SelectCommand.CommandText = sqr
        dataAdapter.Fill(dataSet, "Position")
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub
End Class