<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addGraduate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addGraduate))
        Me.LanguageLevelBox = New System.Windows.Forms.ComboBox()
        Me.ForeignLanguageBox = New System.Windows.Forms.TextBox()
        Me.SchoolTypeBox = New System.Windows.Forms.ComboBox()
        Me.SchoolBox = New System.Windows.Forms.TextBox()
        Me.MajorBox = New System.Windows.Forms.TextBox()
        Me.EducationBox = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GraduateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EnoBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LanguageLevelBox
        '
        Me.LanguageLevelBox.FormattingEnabled = True
        Me.LanguageLevelBox.Items.AddRange(New Object() {"一级", "二级", "三级", "四级", "六级", "专业四级", "专业八级"})
        Me.LanguageLevelBox.Location = New System.Drawing.Point(603, 304)
        Me.LanguageLevelBox.Name = "LanguageLevelBox"
        Me.LanguageLevelBox.Size = New System.Drawing.Size(121, 26)
        Me.LanguageLevelBox.TabIndex = 81
        '
        'ForeignLanguageBox
        '
        Me.ForeignLanguageBox.Location = New System.Drawing.Point(153, 297)
        Me.ForeignLanguageBox.Name = "ForeignLanguageBox"
        Me.ForeignLanguageBox.Size = New System.Drawing.Size(159, 28)
        Me.ForeignLanguageBox.TabIndex = 80
        '
        'SchoolTypeBox
        '
        Me.SchoolTypeBox.FormattingEnabled = True
        Me.SchoolTypeBox.Items.AddRange(New Object() {"小学", "中学", "高中", "专科院校", "三本", "二本", "一本", "211", "985", "国外"})
        Me.SchoolTypeBox.Location = New System.Drawing.Point(943, 195)
        Me.SchoolTypeBox.Name = "SchoolTypeBox"
        Me.SchoolTypeBox.Size = New System.Drawing.Size(121, 26)
        Me.SchoolTypeBox.TabIndex = 79
        '
        'SchoolBox
        '
        Me.SchoolBox.Location = New System.Drawing.Point(536, 188)
        Me.SchoolBox.Name = "SchoolBox"
        Me.SchoolBox.Size = New System.Drawing.Size(263, 28)
        Me.SchoolBox.TabIndex = 78
        '
        'MajorBox
        '
        Me.MajorBox.Location = New System.Drawing.Point(813, 56)
        Me.MajorBox.Name = "MajorBox"
        Me.MajorBox.Size = New System.Drawing.Size(202, 28)
        Me.MajorBox.TabIndex = 76
        '
        'EducationBox
        '
        Me.EducationBox.FormattingEnabled = True
        Me.EducationBox.Items.AddRange(New Object() {"学龄前", "小学", "初中", "高中", "中专", "大专", "大学", "硕士", "博士", "博士后"})
        Me.EducationBox.Location = New System.Drawing.Point(523, 56)
        Me.EducationBox.Name = "EducationBox"
        Me.EducationBox.Size = New System.Drawing.Size(121, 26)
        Me.EducationBox.TabIndex = 75
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(742, 59)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(44, 18)
        Me.Label33.TabIndex = 74
        Me.Label33.Text = "专业"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(63, 188)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 18)
        Me.Label32.TabIndex = 73
        Me.Label32.Text = "毕业时间"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(423, 196)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 18)
        Me.Label31.TabIndex = 72
        Me.Label31.Text = "毕业学校"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(848, 195)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 18)
        Me.Label30.TabIndex = 71
        Me.Label30.Text = "学校类型"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(67, 300)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 18)
        Me.Label29.TabIndex = 70
        Me.Label29.Text = "外语语种"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(504, 307)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 18)
        Me.Label28.TabIndex = 69
        Me.Label28.Text = "语言等级"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(459, 59)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(44, 18)
        Me.Label27.TabIndex = 68
        Me.Label27.Text = "学历"
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(169, 407)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(89, 41)
        Me.save.TabIndex = 82
        Me.save.Text = "保存"
        Me.save.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(744, 407)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(88, 41)
        Me.Cancel.TabIndex = 83
        Me.Cancel.Text = "关闭"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "员工号"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "员工号"
        '
        'GraduateTimePicker
        '
        Me.GraduateTimePicker.Location = New System.Drawing.Point(169, 186)
        Me.GraduateTimePicker.Name = "GraduateTimePicker"
        Me.GraduateTimePicker.Size = New System.Drawing.Size(200, 28)
        Me.GraduateTimePicker.TabIndex = 93
        '
        'EnoBox
        '
        Me.EnoBox.FormattingEnabled = True
        Me.EnoBox.Location = New System.Drawing.Point(202, 56)
        Me.EnoBox.Name = "EnoBox"
        Me.EnoBox.Size = New System.Drawing.Size(151, 26)
        Me.EnoBox.TabIndex = 97
        '
        'addGraduate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 511)
        Me.Controls.Add(Me.EnoBox)
        Me.Controls.Add(Me.GraduateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.LanguageLevelBox)
        Me.Controls.Add(Me.ForeignLanguageBox)
        Me.Controls.Add(Me.SchoolTypeBox)
        Me.Controls.Add(Me.SchoolBox)
        Me.Controls.Add(Me.MajorBox)
        Me.Controls.Add(Me.EducationBox)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addGraduate"
        Me.Text = "添加员工学历状况"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LanguageLevelBox As ComboBox
    Friend WithEvents ForeignLanguageBox As TextBox
    Friend WithEvents SchoolTypeBox As ComboBox
    Friend WithEvents SchoolBox As TextBox
    Friend WithEvents MajorBox As TextBox
    Friend WithEvents EducationBox As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents save As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GraduateTimePicker As DateTimePicker
    Friend WithEvents EnoBox As ComboBox
End Class
