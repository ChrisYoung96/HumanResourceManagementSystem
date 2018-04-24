<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchEmployee
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchEmployee))
        Me.EmployeeListView = New System.Windows.Forms.ListView()
        Me.Eno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Esex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ephone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Choose = New System.Windows.Forms.Button()
        Me.ChooseTextBox = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'EmployeeListView
        '
        Me.EmployeeListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Eno, Me.Ename, Me.Esex, Me.EStatus, Me.Ephone})
        Me.EmployeeListView.FullRowSelect = True
        Me.EmployeeListView.GridLines = True
        Me.EmployeeListView.Location = New System.Drawing.Point(50, 131)
        Me.EmployeeListView.Name = "EmployeeListView"
        Me.EmployeeListView.Size = New System.Drawing.Size(902, 433)
        Me.EmployeeListView.TabIndex = 0
        Me.EmployeeListView.UseCompatibleStateImageBehavior = False
        Me.EmployeeListView.View = System.Windows.Forms.View.Details
        '
        'Eno
        '
        Me.Eno.Text = "Eno"
        Me.Eno.Width = 189
        '
        'Ename
        '
        Me.Ename.Text = "Ename"
        Me.Ename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Ename.Width = 154
        '
        'Esex
        '
        Me.Esex.Text = "Esex"
        Me.Esex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EStatus
        '
        Me.EStatus.Text = "EStatus"
        Me.EStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EStatus.Width = 129
        '
        'Ephone
        '
        Me.Ephone.Text = "Ephone"
        Me.Ephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Ephone.Width = 227
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "查询条件"
        '
        'Choose
        '
        Me.Choose.Location = New System.Drawing.Point(859, 42)
        Me.Choose.Name = "Choose"
        Me.Choose.Size = New System.Drawing.Size(93, 38)
        Me.Choose.TabIndex = 11
        Me.Choose.Text = "查找"
        Me.Choose.UseVisualStyleBackColor = True
        '
        'ChooseTextBox
        '
        Me.ChooseTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ChooseTextBox.FormattingEnabled = True
        Me.ChooseTextBox.Items.AddRange(New Object() {"查询员工", "查询员工状态"})
        Me.ChooseTextBox.Location = New System.Drawing.Point(149, 49)
        Me.ChooseTextBox.Name = "ChooseTextBox"
        Me.ChooseTextBox.Size = New System.Drawing.Size(121, 26)
        Me.ChooseTextBox.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(294, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(182, 28)
        Me.TextBox1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(775, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "共计："
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox2.Location = New System.Drawing.Point(852, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 28)
        Me.TextBox2.TabIndex = 18
        '
        'SearchEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 599)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ChooseTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Choose)
        Me.Controls.Add(Me.EmployeeListView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchEmployee"
        Me.Text = "查找员工"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeeListView As ListView
    Friend WithEvents Eno As ColumnHeader
    Friend WithEvents Ename As ColumnHeader
    Friend WithEvents EStatus As ColumnHeader
    Friend WithEvents Ephone As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Choose As Button
    Friend WithEvents ChooseTextBox As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Esex As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
