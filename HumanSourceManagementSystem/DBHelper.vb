Imports System.Data.SqlClient
Imports System.Data.OracleClient

Public Class DBHelper
    'Public conString As String = "Data Source=.;Initial Catalog=HRMS;Integrated Security=True"
    'Public connection As SqlConnection = New SqlConnection(conString)
    Public conString As String = "driver={microsoft odbc for oracle};server=OLRCL;uid=c##Chris;pwd=000000"
    Public connection As OracleConnection = New OracleConnection(conString)

End Class
