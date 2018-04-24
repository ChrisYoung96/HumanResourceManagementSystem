Imports System.Data.SqlClient

Public Class addGraduate
    Dim DBHelper As DBHelper = New DBHelper()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim EducationBackground As String = EducationBox.Text
        Dim Major As String = MajorBox.Text
        Dim GraduationTime As Date = GraduateTimePicker.Value
        Dim School As String = SchoolBox.Text
        Dim SchoolType As String = SchoolTypeBox.Text
        Dim ForeignLanguage As String = ForeignLanguageBox.Text
        Dim Languagelevel As String = LanguageLevelBox.Text
        Dim Eno As String = EnoBox.Text
        Dim sqr1 As String = String.Format("insert into EmployeeEducationBackground(Eno,EducationBackground,Major,GraduationTime,School, SchoolType, ForeignLanguage,Languagelevel ) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Eno, EducationBackground, Major, GraduationTime, School, SchoolType, ForeignLanguage, Languagelevel)

        Try
            Dim com1 As SqlCommand = New SqlCommand(sqr1, DBHelper.connection)
            DBHelper.connection.Open()
            Dim result As Integer = com1.ExecuteNonQuery()
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

    Private Sub addGraduate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim Eno As String = EnoBox.Text
        Dim sql1 As String = String.Format("select * from EmployeeEducationBackground where Eno='{0}'", Eno)
        Try
            Dim com As SqlCommand = New SqlCommand(sql1, DBHelper.connection)
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

        EducationBox.Text = ""
        LanguageLevelBox.Text = ""
        ForeignLanguageBox.Text = ""
        SchoolBox.Text = ""
        SchoolTypeBox.Text = ""
        MajorBox.Text = ""

    End Sub
End Class