<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowGraduate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowGraduate))
        Me.GraduateDataGrid = New System.Windows.Forms.DataGridView()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChooseTextBox = New System.Windows.Forms.TextBox()
        Me.ChooseBox = New System.Windows.Forms.ComboBox()
        Me.Choose = New System.Windows.Forms.Button()
        CType(Me.GraduateDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GraduateDataGrid
        '
        Me.GraduateDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GraduateDataGrid.Location = New System.Drawing.Point(43, 105)
        Me.GraduateDataGrid.Name = "GraduateDataGrid"
        Me.GraduateDataGrid.RowTemplate.Height = 30
        Me.GraduateDataGrid.Size = New System.Drawing.Size(921, 434)
        Me.GraduateDataGrid.TabIndex = 0
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(97, 583)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(90, 43)
        Me.Refresh.TabIndex = 1
        Me.Refresh.Text = "刷新"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(751, 583)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(86, 43)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "关闭"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "筛选条件"
        '
        'ChooseTextBox
        '
        Me.ChooseTextBox.ForeColor = System.Drawing.Color.Black
        Me.ChooseTextBox.Location = New System.Drawing.Point(273, 46)
        Me.ChooseTextBox.Name = "ChooseTextBox"
        Me.ChooseTextBox.Size = New System.Drawing.Size(188, 28)
        Me.ChooseTextBox.TabIndex = 9
        '
        'ChooseBox
        '
        Me.ChooseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ChooseBox.FormattingEnabled = True
        Me.ChooseBox.Items.AddRange(New Object() {"按专业", "按学历"})
        Me.ChooseBox.Location = New System.Drawing.Point(135, 46)
        Me.ChooseBox.Name = "ChooseBox"
        Me.ChooseBox.Size = New System.Drawing.Size(118, 26)
        Me.ChooseBox.TabIndex = 8
        '
        'Choose
        '
        Me.Choose.Location = New System.Drawing.Point(484, 39)
        Me.Choose.Name = "Choose"
        Me.Choose.Size = New System.Drawing.Size(93, 38)
        Me.Choose.TabIndex = 7
        Me.Choose.Text = "筛选"
        Me.Choose.UseVisualStyleBackColor = True
        '
        'ShowGraduate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 679)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChooseTextBox)
        Me.Controls.Add(Me.ChooseBox)
        Me.Controls.Add(Me.Choose)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.GraduateDataGrid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShowGraduate"
        Me.Text = "显示员工学历情况"
        CType(Me.GraduateDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GraduateDataGrid As DataGridView
    Friend WithEvents Refresh As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ChooseTextBox As TextBox
    Friend WithEvents ChooseBox As ComboBox
    Friend WithEvents Choose As Button
End Class
