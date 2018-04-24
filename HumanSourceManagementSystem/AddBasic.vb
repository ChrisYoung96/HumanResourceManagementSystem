Imports System.Data.SqlClient

Public Class AddBasic
    Dim DBHelper As DBHelper = New DBHelper()

    Private Sub save_Click_1(sender As Object, e As EventArgs) Handles save.Click
        Dim Eno As String = EnoBox.Text
        Dim Ename As String = EnameBox.Text
        Dim Esex As String = EsexBox.Text
        Dim Enation As String = NationBox.Text
        Dim Ehome As String = HomeBox.Text
        Dim Ebirthday As Date = DateTimePicker.Value
        Dim Eid As String = IdBox.Text
        Dim Epolitic_status As String = PoliticsBox.Text
        Dim Ejointime As String = JionDate.Value
        Dim Estatus As String = StatusBox.Text
        Dim Eaddress As String = AddressBox.Text
        Dim EjobCode As String = JobCodeBox.Text
        Dim Ephone As String = PhonBox.Text
        Dim Dno As String = DnoBox.Text



        Dim sqr As String = String.Format("insert into EmployeeBasicInformation(Eno,Ename,Esex,Enation,Ephone,Dno,Ehome,Ebirthday,Eid,Epolitic_status,Ejointime,Estatus,Eaddress,EjobCode) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", Eno, Ename, Esex, Enation, Ephone, Dno, Ehome, Ebirthday, Eid, Epolitic_status, Ejointime, Estatus, Eaddress, EjobCode)

        Try

            Dim com As SqlCommand = New SqlCommand(sqr, DBHelper.connection)
            DBHelper.connection.Open()
            Dim result As Integer = com.ExecuteNonQuery()
            If result < 1 Then
                MessageBox.Show("添加失败")
            Else
                MessageBox.Show("保存成功！")
                EnoBox.Text = ""
                AddressBox.Text = ""
                EnameBox.Text = ""
                EsexBox.Text = ""
                NationBox.Text = ""
                PoliticsBox.Text = ""
                StatusBox.Text = ""
                PhonBox.Text = ""
                DnoBox.Text = ""
                IdBox.Text = ""
                HomeBox.Text = ""
                JobCodeBox.Text = ""
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBHelper.connection.Close()
        End Try
    End Sub

    Private Sub Cancel_Click_1(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub AddBasic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = String.Format("select Dno from Department")
        Dim com As SqlCommand = New SqlCommand(str, DBHelper.connection)
        Try
            Dim DataReader As SqlDataReader
            DBHelper.connection.Open()
            DataReader = com.ExecuteReader()
            Do While DataReader.Read()
                DnoBox.Items.Add(DataReader("Dno"))

            Loop
            DataReader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            DBHelper.connection.Close()
        End Try

        Dim str1 As String = String.Format("select Pno from Position")
        Dim com1 As SqlCommand = New SqlCommand(str1, DBHelper.connection)
        Try
            Dim DataReader As SqlDataReader
            DBHelper.connection.Open()
            DataReader = com1.ExecuteReader()
            Do While DataReader.Read()
                JobCodeBox.Items.Add(DataReader("Pno"))

            Loop
            DataReader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            DBHelper.connection.Close()
        End Try
    End Sub
End Class