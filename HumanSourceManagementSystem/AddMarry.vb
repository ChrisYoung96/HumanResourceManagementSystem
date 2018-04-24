Imports System.Data.SqlClient

Public Class AddMarry
    Dim DBHelper As DBHelper = New DBHelper()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim Eno As String = EnoBox.Text
        Dim LoverName As String = LoverNameBox.Text
        Dim LoverBirthday As Date = LoverBirthdate.Value
        Dim MarryDate As Date = MarryDatePicker.Value
        Dim LoverWorkPlace As String = LoverWorkPlaceBox.Text
        Dim LoverPoliticsStatus As String = LoverPoliticsBox.Text
        Dim LoverJob As String = LoverJobBox.Text
        Dim sqr2 As String = String.Format("insert into EmployeeMarriageStatus(Eno, LoverName, LoverBirthday,MarryDate, LoverWorkPlace,LoverPoliticsStatus,LoverJob)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Eno, LoverName, LoverBirthday, MarryDate, LoverWorkPlace, LoverPoliticsStatus, LoverJob)


        Try
            Dim com2 As SqlCommand = New SqlCommand(sqr2, DBHelper.connection)
            DBHelper.connection.Open()
            Dim result As Integer = com2.ExecuteNonQuery()
            If result < 1 Then
                MessageBox.Show("添加失败")
            Else
                MessageBox.Show("保存成功！")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBHelper.connection.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub AddMarry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = String.Format("select Eno from EmployeeBasicInformation")

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

    Private Sub EnoBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EnoBox.SelectedIndexChanged
        Dim Eno = EnoBox.Text
        Dim sql2 As String = String.Format("select * from EmployeeMarriageStatus where Eno='{0}'", Eno)
        Try
            Dim com As SqlCommand = New SqlCommand(sql2, DBHelper.connection)
            DBHelper.connection.Open()
            Dim datareader As SqlDataReader = com.ExecuteReader()
            If datareader.Read() Then
                MessageBox.Show("该员工信息已存在，请添加其他员工信息")
            End If
            datareader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBHelper.connection.Close()
        End Try
        LoverPoliticsBox.Text = ""
        LoverJobBox.Text = ""
        LoverNameBox.Text = ""
        LoverWorkPlaceBox.Text = ""


    End Sub
End Class