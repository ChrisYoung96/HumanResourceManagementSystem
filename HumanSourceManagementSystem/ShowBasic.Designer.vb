<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowBasic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowBasic))
        Me.Refresh = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.DataGridEmployee = New System.Windows.Forms.DataGridView()
        Me.Choose = New System.Windows.Forms.Button()
        Me.ChooseBox = New System.Windows.Forms.ComboBox()
        Me.ChooseTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(215, 677)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(101, 40)
        Me.Refresh.TabIndex = 0
        Me.Refresh.Text = "刷新"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(749, 677)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(99, 40)
        Me.Cancel.TabIndex = 1
        Me.Cancel.Text = "取消"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'DataGridEmployee
        '
        Me.DataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEmployee.Location = New System.Drawing.Point(41, 172)
        Me.DataGridEmployee.Name = "DataGridEmployee"
        Me.DataGridEmployee.RowTemplate.Height = 30
        Me.DataGridEmployee.Size = New System.Drawing.Size(1024, 499)
        Me.DataGridEmployee.TabIndex = 2
        '
        'Choose
        '
        Me.Choose.Location = New System.Drawing.Point(473, 36)
        Me.Choose.Name = "Choose"
        Me.Choose.Size = New System.Drawing.Size(93, 38)
        Me.Choose.TabIndex = 3
        Me.Choose.Text = "筛选"
        Me.Choose.UseVisualStyleBackColor = True
        '
        'ChooseBox
        '
        Me.ChooseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ChooseBox.FormattingEnabled = True
        Me.ChooseBox.Items.AddRange(New Object() {"按性别", "按民族", "按部门", "按状态", "按政治面貌"})
        Me.ChooseBox.Location = New System.Drawing.Point(124, 43)
        Me.ChooseBox.Name = "ChooseBox"
        Me.ChooseBox.Size = New System.Drawing.Size(118, 26)
        Me.ChooseBox.TabIndex = 4
        '
        'ChooseTextBox
        '
        Me.ChooseTextBox.ForeColor = System.Drawing.Color.Black
        Me.ChooseTextBox.Location = New System.Drawing.Point(262, 43)
        Me.ChooseTextBox.Name = "ChooseTextBox"
        Me.ChooseTextBox.Size = New System.Drawing.Size(188, 28)
        Me.ChooseTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "筛选条件"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(137, 112)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(105, 22)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.Text = "员工状态"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(275, 112)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 22)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "性别"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "排序方式"
        '
        'ShowBasic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 754)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChooseTextBox)
        Me.Controls.Add(Me.ChooseBox)
        Me.Controls.Add(Me.Choose)
        Me.Controls.Add(Me.DataGridEmployee)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Refresh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShowBasic"
        Me.Text = "显示员工基本信息"
        CType(Me.DataGridEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Refresh As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents DataGridEmployee As DataGridView
    Friend WithEvents Choose As Button
    Friend WithEvents ChooseBox As ComboBox
    Friend WithEvents ChooseTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label2 As Label
End Class
