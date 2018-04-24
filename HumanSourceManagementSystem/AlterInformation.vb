Imports System.Data.SqlClient

Public Class AlterInformation


    Dim DBHelper As DBHelper = New DBHelper()
    Dim Eno As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Eno = EnoBox.Text
        Dim sql As String = String.Format("select * from EmployeeBasicInformation where Eno='{0}'", Eno)
        Dim sql1 As String = String.Format("select * from EmployeeEducationBackground where Eno='{0}'", Eno)
        Dim sql2 As String = String.Format("select * from EmployeeMarriageStatus where Eno='{0}'", Eno)
        Try
            Dim com As SqlCommand = New SqlCommand(sql, DBHelper.connection)
            DBHelper.connection.Open()
            Dim datareader1 As SqlDataReader = com.ExecuteReader()
            If datareader1.Read() Then
                PoliticsBox.Text = datareader1("Epolitic_status")
                StatusBox.Text = datareader1("Estatus")
                AddressBox.Text = datareader1("Eaddress")
                JobCodeBox.Text = datareader1("EjobCode")
                PhonBox.Text = datareader1("Ephone")
                datareader1.Close()
            End If
            com.CommandText = sql1
            Dim datareader2 As SqlDataReader = com.ExecuteReader()
            If datareader2.Read() Then
                ForeignLanguageBox.Text = datareader2("ForeignLanguage")
                LanguageLevelBox.Text = datareader2("Languagelevel")
                datareader2.Close()
            End If
            com.CommandText = sql2
            Dim datareader3 As SqlDataReader = com.ExecuteReader()
            If datareader3.Read() Then
                LoverNameBox.Text = datareader3("LoverName")
                LoverBirthdate.Value = datareader3("LoverBirthday")
                MarryDatePicker.Value = datareader3("MarryDate")
                LoverWorkPlaceBox.Text = datareader3("LoverWorkPlace")
                LoverPoliticsBox.Text = datareader3("LoverPoliticsStatus")
                LoverJobBox.Text = datareader3("LoverJob")
                datareader3.Close()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBHelper.connection.Close()
        End Try
    End Sub

    Private Sub save1_Click(sender As Object, e As EventArgs) Handles save1.Click

        Try
            Dim Epolitic_status As String = PoliticsBox.Text
            Dim Estatus As String = StatusBox.Text
            Dim Eaddress As String = AddressBox.Text
            Dim EjobCode As String = JobCodeBox.Text
            Dim Ephone As String = PhonBox.Text

            ' If StatusBox.Text = "辞职" Or StatusBox.Text = "转出" Or StatusBox.Text = "退休" Then

            'End If

            ' Else
            If StatusBox.Text = "辞职" Or StatusBox.Text = "转出" Or StatusBox.Text = "退休" Then
                Dim show As Wanring1 = New Wanring1()
                show.Show()
            End If

            Dim sqr As String = String.Format("update EmployeeBasicInformation set Epolitic_status='{1}',Estatus='{2}',Eaddress='{3}',EjobCode='{4}',Ephone='{5}' where Eno='{0}'", Eno, Epolitic_status, Estatus, Eaddress, EjobCode, Ephone)
            Dim command As SqlCommand = New SqlCommand(sqr, DBHelper.connection)
            DBHelper.connection.Open()
            Dim result As Integer = command.ExecuteNonQuery()
            If (result < 1) Then
                MessageBox.Show("修改失败")
            Else
                MessageBox.Show("修改成功")
                DBHelper.connection.Close()
            End If
            '  End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub



    Private Sub Cancel1_Click(sender As Object, e As EventArgs) Handles Cancel1.Click
        Close()
    End Sub

    Private Sub save2_Click(sender As Object, e As EventArgs) Handles save2.Click
        Try
            Dim ForeignLanguage As String = ForeignLanguageBox.Text
            Dim Languagelevel As String = LanguageLevelBox.Text
            Dim sqr As String = String.Format("update EmployeeEducationBackground set ForeignLanguage='{1}',Languagelevel='{2}'where Eno='{0}'", Eno, ForeignLanguage, Languagelevel)
            Dim command As SqlCommand = New SqlCommand(sqr, DBHelper.connection)
            DBHelper.connection.Open()
            Dim result As Integer = command.ExecuteNonQuery()
            If (result < 1) Then
                MessageBox.Show("修改失败")
            Else
                MessageBox.Show("修改成功")
                DBHelper.connection.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub save3_Click(sender As Object, e As EventArgs) Handles save3.Click
        Try
            Dim LoverName As String = LoverNameBox.Text
            Dim LoverBirthday As Date = LoverBirthdate.Value
            Dim MarryDate As Date = MarryDatePicker.Value
            Dim LoverWorkPlace As String = LoverWorkPlaceBox.Text
            Dim LoverPoliticsStatus As String = LoverPoliticsBox.Text
            Dim LoverJob As String = LoverJobBox.Text
            Dim sqr As String = String.Format("update EmployeeMarriageStatus set LoverName='{1}', LoverBirthday='{2}',MarryDate='{3}', LoverWorkPlace='{4}',LoverPoliticsStatus='{5}',LoverJob='{6}' where Eno='{0}'", Eno, LoverName, LoverBirthday, MarryDate, LoverWorkPlace, LoverPoliticsStatus, LoverJob)
            Dim command As SqlCommand = New SqlCommand(sqr, DBHelper.connection)
            DBHelper.connection.Open()
            Dim result As Integer = command.ExecuteNonQuery()
            If (result < 1) Then
                MessageBox.Show("修改失败")
            Else
                MessageBox.Show("修改成功")
                DBHelper.connection.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub StatusBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusBox.SelectedIndexChanged

    End Sub

    Private Sub AlterInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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