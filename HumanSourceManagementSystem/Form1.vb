Public Class Form1

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub 添加基本信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加基本信息ToolStripMenuItem.Click
        Dim addBasic As AddBasic = New AddBasic()
        addBasic.Show()
    End Sub

    Private Sub 添加学历信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加学历信息ToolStripMenuItem.Click
        Dim addGraduate As addGraduate = New addGraduate()
        addGraduate.Show()
    End Sub

    Private Sub 添加婚姻状况ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加婚姻状况ToolStripMenuItem.Click
        Dim addMarry As AddMarry = New AddMarry()
        addMarry.Show()
    End Sub

    Private Sub 显示员工信息表ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示员工信息表ToolStripMenuItem.Click
        Dim ShowBasic As ShowBasic = New ShowBasic()
        ShowBasic.Show()
    End Sub

    Private Sub 显示员工学业表ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示员工学业表ToolStripMenuItem.Click
        Dim ShowGraduate As ShowGraduate = New ShowGraduate()
        ShowGraduate.Show()
    End Sub

    Private Sub 显示员工ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示员工ToolStripMenuItem.Click
        Dim ShowMarry As ShowMarry = New ShowMarry()
        ShowMarry.Show()
    End Sub

    Private Sub 修改ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改ToolStripMenuItem.Click
        Dim AlterForm As AlterInformation = New AlterInformation()
        AlterForm.Show()

    End Sub

    Private Sub 部门ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 部门ToolStripMenuItem.Click
        Dim Show As ShowDepartment = New ShowDepartment()
        Show.Show()
    End Sub

    Private Sub 岗位信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 岗位信息ToolStripMenuItem.Click
        Dim Show As ShowPosition = New ShowPosition()
        Show.Show()
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim addBasic As AddBasic = New AddBasic()
        addBasic.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim AlterForm As AlterInformation = New AlterInformation()
        AlterForm.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim SearchEmoloyee As SearchEmployee = New SearchEmployee()
        SearchEmoloyee.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim ShowBasic As ShowBasic = New ShowBasic()
        ShowBasic.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim deleteEm As DeleteEmployee = New DeleteEmployee()
        deleteEm.Show()
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        Dim show As AboutBox1 = New AboutBox1()
        show.Show()
    End Sub

    Private Sub 帮助ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 帮助ToolStripMenuItem1.Click
        Dim s As Help = New Help()
        s.Show()
    End Sub

    Private Sub 员工状态查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 员工状态查询ToolStripMenuItem.Click
        Dim s As SearchEmployee = New SearchEmployee()
        s.Show()
    End Sub

    Private Sub 删除员工ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除员工ToolStripMenuItem.Click
        Dim s As DeleteEmployee = New DeleteEmployee()
        s.Show()
    End Sub
End Class

