<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMarry
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
        Me.LoverPoliticsBox = New System.Windows.Forms.ComboBox()
        Me.LoverWorkPlaceBox = New System.Windows.Forms.TextBox()
        Me.LoverJobBox = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.LoverNameBox = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoverBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.MarryDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.EnoBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LoverPoliticsBox
        '
        Me.LoverPoliticsBox.FormattingEnabled = True
        Me.LoverPoliticsBox.Items.AddRange(New Object() {"群众", "共青团员", "共产党员"})
        Me.LoverPoliticsBox.Location = New System.Drawing.Point(756, 216)
        Me.LoverPoliticsBox.Name = "LoverPoliticsBox"
        Me.LoverPoliticsBox.Size = New System.Drawing.Size(121, 26)
        Me.LoverPoliticsBox.TabIndex = 23
        '
        'LoverWorkPlaceBox
        '
        Me.LoverWorkPlaceBox.Location = New System.Drawing.Point(202, 312)
        Me.LoverWorkPlaceBox.Name = "LoverWorkPlaceBox"
        Me.LoverWorkPlaceBox.Size = New System.Drawing.Size(717, 28)
        Me.LoverWorkPlaceBox.TabIndex = 21
        '
        'LoverJobBox
        '
        Me.LoverJobBox.Location = New System.Drawing.Point(223, 221)
        Me.LoverJobBox.Name = "LoverJobBox"
        Me.LoverJobBox.Size = New System.Drawing.Size(197, 28)
        Me.LoverJobBox.TabIndex = 20
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(617, 219)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(116, 18)
        Me.Label39.TabIndex = 18
        Me.Label39.Text = "爱人政治面貌"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(84, 153)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(80, 18)
        Me.Label38.TabIndex = 17
        Me.Label38.Text = "爱人生日"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(84, 224)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(80, 18)
        Me.Label37.TabIndex = 16
        Me.Label37.Text = "爱人职业"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(84, 315)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(116, 18)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "爱人工作地址"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(604, 160)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(80, 18)
        Me.Label35.TabIndex = 14
        Me.Label35.Text = "结婚时间"
        '
        'LoverNameBox
        '
        Me.LoverNameBox.Location = New System.Drawing.Point(722, 67)
        Me.LoverNameBox.Name = "LoverNameBox"
        Me.LoverNameBox.Size = New System.Drawing.Size(197, 28)
        Me.LoverNameBox.TabIndex = 13
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(604, 67)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(80, 18)
        Me.Label34.TabIndex = 12
        Me.Label34.Text = "爱人姓名"
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(162, 404)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(89, 41)
        Me.save.TabIndex = 33
        Me.save.Text = "保存"
        Me.save.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(737, 404)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(88, 41)
        Me.Cancel.TabIndex = 34
        Me.Cancel.Text = "关闭"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "员工号"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "员工号"
        '
        'LoverBirthdate
        '
        Me.LoverBirthdate.Location = New System.Drawing.Point(220, 143)
        Me.LoverBirthdate.Name = "LoverBirthdate"
        Me.LoverBirthdate.Size = New System.Drawing.Size(200, 28)
        Me.LoverBirthdate.TabIndex = 94
        '
        'MarryDatePicker
        '
        Me.MarryDatePicker.Location = New System.Drawing.Point(719, 150)
        Me.MarryDatePicker.Name = "MarryDatePicker"
        Me.MarryDatePicker.Size = New System.Drawing.Size(200, 28)
        Me.MarryDatePicker.TabIndex = 95
        '
        'EnoBox
        '
        Me.EnoBox.FormattingEnabled = True
        Me.EnoBox.Location = New System.Drawing.Point(220, 58)
        Me.EnoBox.Name = "EnoBox"
        Me.EnoBox.Size = New System.Drawing.Size(151, 26)
        Me.EnoBox.TabIndex = 96
        '
        'AddMarry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 504)
        Me.Controls.Add(Me.EnoBox)
        Me.Controls.Add(Me.MarryDatePicker)
        Me.Controls.Add(Me.LoverBirthdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.LoverPoliticsBox)
        Me.Controls.Add(Me.LoverWorkPlaceBox)
        Me.Controls.Add(Me.LoverJobBox)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.LoverNameBox)
        Me.Controls.Add(Me.Label34)
        Me.Name = "AddMarry"
        Me.Text = "AddMarry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoverPoliticsBox As ComboBox
    Friend WithEvents LoverWorkPlaceBox As TextBox
    Friend WithEvents LoverJobBox As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents LoverNameBox As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents save As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LoverBirthdate As DateTimePicker
    Friend WithEvents MarryDatePicker As DateTimePicker
    Friend WithEvents EnoBox As ComboBox
End Class
