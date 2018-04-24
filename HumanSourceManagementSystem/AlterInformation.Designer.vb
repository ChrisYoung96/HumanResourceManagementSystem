<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlterInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlterInformation))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.基本信息 = New System.Windows.Forms.TabPage()
        Me.EnoBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.save1 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.JobCodeBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.StatusBox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PhonBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PoliticsBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.学历信息 = New System.Windows.Forms.TabPage()
        Me.save2 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LanguageLevelBox = New System.Windows.Forms.ComboBox()
        Me.ForeignLanguageBox = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.婚姻信息 = New System.Windows.Forms.TabPage()
        Me.save3 = New System.Windows.Forms.Button()
        Me.MarryDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.LoverWorkPlaceBox = New System.Windows.Forms.TextBox()
        Me.LoverPoliticsBox = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.LoverJobBox = New System.Windows.Forms.TextBox()
        Me.LoverBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.LoverNameBox = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Cancel1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.基本信息.SuspendLayout()
        Me.学历信息.SuspendLayout()
        Me.婚姻信息.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.基本信息)
        Me.TabControl1.Controls.Add(Me.学历信息)
        Me.TabControl1.Controls.Add(Me.婚姻信息)
        Me.TabControl1.Location = New System.Drawing.Point(34, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(983, 529)
        Me.TabControl1.TabIndex = 146
        '
        '基本信息
        '
        Me.基本信息.Controls.Add(Me.EnoBox)
        Me.基本信息.Controls.Add(Me.Button1)
        Me.基本信息.Controls.Add(Me.save1)
        Me.基本信息.Controls.Add(Me.Label24)
        Me.基本信息.Controls.Add(Me.AddressBox)
        Me.基本信息.Controls.Add(Me.Label12)
        Me.基本信息.Controls.Add(Me.Label26)
        Me.基本信息.Controls.Add(Me.JobCodeBox)
        Me.基本信息.Controls.Add(Me.Label14)
        Me.基本信息.Controls.Add(Me.Label25)
        Me.基本信息.Controls.Add(Me.StatusBox)
        Me.基本信息.Controls.Add(Me.Label13)
        Me.基本信息.Controls.Add(Me.Label22)
        Me.基本信息.Controls.Add(Me.PhonBox)
        Me.基本信息.Controls.Add(Me.Label10)
        Me.基本信息.Controls.Add(Me.Label20)
        Me.基本信息.Controls.Add(Me.PoliticsBox)
        Me.基本信息.Controls.Add(Me.Label8)
        Me.基本信息.Controls.Add(Me.Label4)
        Me.基本信息.Controls.Add(Me.Label1)
        Me.基本信息.Location = New System.Drawing.Point(4, 28)
        Me.基本信息.Name = "基本信息"
        Me.基本信息.Padding = New System.Windows.Forms.Padding(3)
        Me.基本信息.Size = New System.Drawing.Size(975, 497)
        Me.基本信息.TabIndex = 0
        Me.基本信息.Text = "基本信息"
        Me.基本信息.UseVisualStyleBackColor = True
        '
        'EnoBox
        '
        Me.EnoBox.FormattingEnabled = True
        Me.EnoBox.Location = New System.Drawing.Point(104, 58)
        Me.EnoBox.Name = "EnoBox"
        Me.EnoBox.Size = New System.Drawing.Size(143, 26)
        Me.EnoBox.TabIndex = 167
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 46)
        Me.Button1.TabIndex = 166
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'save1
        '
        Me.save1.Location = New System.Drawing.Point(400, 433)
        Me.save1.Name = "save1"
        Me.save1.Size = New System.Drawing.Size(89, 41)
        Me.save1.TabIndex = 164
        Me.save1.Text = "保存"
        Me.save1.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(40, 361)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 18)
        Me.Label24.TabIndex = 162
        Me.Label24.Text = "家庭住址"
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(126, 358)
        Me.AddressBox.Multiline = True
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.AddressBox.Size = New System.Drawing.Size(756, 28)
        Me.AddressBox.TabIndex = 163
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 361)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 161
        Me.Label12.Text = "家庭住址"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(283, 262)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 18)
        Me.Label26.TabIndex = 159
        Me.Label26.Text = "岗位代码"
        '
        'JobCodeBox
        '
        Me.JobCodeBox.Location = New System.Drawing.Point(400, 253)
        Me.JobCodeBox.Name = "JobCodeBox"
        Me.JobCodeBox.Size = New System.Drawing.Size(262, 28)
        Me.JobCodeBox.TabIndex = 160
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(283, 262)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 18)
        Me.Label14.TabIndex = 158
        Me.Label14.Text = "岗位代码"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(40, 255)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 18)
        Me.Label25.TabIndex = 156
        Me.Label25.Text = "状态"
        '
        'StatusBox
        '
        Me.StatusBox.FormattingEnabled = True
        Me.StatusBox.Items.AddRange(New Object() {"在职", "请假", "辞职", "转业", "退休"})
        Me.StatusBox.Location = New System.Drawing.Point(104, 255)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.Size = New System.Drawing.Size(121, 26)
        Me.StatusBox.TabIndex = 157
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 255)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 18)
        Me.Label13.TabIndex = 155
        Me.Label13.Text = "状态"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(40, 159)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 18)
        Me.Label22.TabIndex = 153
        Me.Label22.Text = "联系方式"
        '
        'PhonBox
        '
        Me.PhonBox.Location = New System.Drawing.Point(126, 156)
        Me.PhonBox.Name = "PhonBox"
        Me.PhonBox.Size = New System.Drawing.Size(188, 28)
        Me.PhonBox.TabIndex = 154
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 152
        Me.Label10.Text = "联系方式"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(347, 161)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 18)
        Me.Label20.TabIndex = 150
        Me.Label20.Text = "政治面貌"
        '
        'PoliticsBox
        '
        Me.PoliticsBox.FormattingEnabled = True
        Me.PoliticsBox.Items.AddRange(New Object() {"群众", "共青团员", "共产党员"})
        Me.PoliticsBox.Location = New System.Drawing.Point(447, 161)
        Me.PoliticsBox.Name = "PoliticsBox"
        Me.PoliticsBox.Size = New System.Drawing.Size(121, 26)
        Me.PoliticsBox.TabIndex = 151
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(347, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 149
        Me.Label8.Text = "政治面貌"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "员工号"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "员工号"
        '
        '学历信息
        '
        Me.学历信息.Controls.Add(Me.save2)
        Me.学历信息.Controls.Add(Me.Label28)
        Me.学历信息.Controls.Add(Me.LanguageLevelBox)
        Me.学历信息.Controls.Add(Me.ForeignLanguageBox)
        Me.学历信息.Controls.Add(Me.Label29)
        Me.学历信息.Location = New System.Drawing.Point(4, 28)
        Me.学历信息.Name = "学历信息"
        Me.学历信息.Padding = New System.Windows.Forms.Padding(3)
        Me.学历信息.Size = New System.Drawing.Size(975, 497)
        Me.学历信息.TabIndex = 1
        Me.学历信息.Text = "学历信息"
        Me.学历信息.UseVisualStyleBackColor = True
        '
        'save2
        '
        Me.save2.Location = New System.Drawing.Point(451, 429)
        Me.save2.Name = "save2"
        Me.save2.Size = New System.Drawing.Size(89, 41)
        Me.save2.TabIndex = 151
        Me.save2.Text = "保存"
        Me.save2.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(606, 151)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 18)
        Me.Label28.TabIndex = 147
        Me.Label28.Text = "语言等级"
        '
        'LanguageLevelBox
        '
        Me.LanguageLevelBox.FormattingEnabled = True
        Me.LanguageLevelBox.Items.AddRange(New Object() {"一级", "二级", "三级", "四级", "六级", "专业四级", "专业八级"})
        Me.LanguageLevelBox.Location = New System.Drawing.Point(705, 147)
        Me.LanguageLevelBox.Name = "LanguageLevelBox"
        Me.LanguageLevelBox.Size = New System.Drawing.Size(121, 26)
        Me.LanguageLevelBox.TabIndex = 150
        '
        'ForeignLanguageBox
        '
        Me.ForeignLanguageBox.Location = New System.Drawing.Point(175, 146)
        Me.ForeignLanguageBox.Name = "ForeignLanguageBox"
        Me.ForeignLanguageBox.Size = New System.Drawing.Size(159, 28)
        Me.ForeignLanguageBox.TabIndex = 149
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(111, 151)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 18)
        Me.Label29.TabIndex = 148
        Me.Label29.Text = "外语"
        '
        '婚姻信息
        '
        Me.婚姻信息.Controls.Add(Me.save3)
        Me.婚姻信息.Controls.Add(Me.MarryDatePicker)
        Me.婚姻信息.Controls.Add(Me.Label34)
        Me.婚姻信息.Controls.Add(Me.LoverWorkPlaceBox)
        Me.婚姻信息.Controls.Add(Me.LoverPoliticsBox)
        Me.婚姻信息.Controls.Add(Me.Label36)
        Me.婚姻信息.Controls.Add(Me.Label37)
        Me.婚姻信息.Controls.Add(Me.LoverJobBox)
        Me.婚姻信息.Controls.Add(Me.LoverBirthdate)
        Me.婚姻信息.Controls.Add(Me.LoverNameBox)
        Me.婚姻信息.Controls.Add(Me.Label38)
        Me.婚姻信息.Controls.Add(Me.Label39)
        Me.婚姻信息.Controls.Add(Me.Label35)
        Me.婚姻信息.Location = New System.Drawing.Point(4, 28)
        Me.婚姻信息.Name = "婚姻信息"
        Me.婚姻信息.Padding = New System.Windows.Forms.Padding(3)
        Me.婚姻信息.Size = New System.Drawing.Size(975, 497)
        Me.婚姻信息.TabIndex = 2
        Me.婚姻信息.Text = "婚姻信息"
        Me.婚姻信息.UseVisualStyleBackColor = True
        '
        'save3
        '
        Me.save3.Location = New System.Drawing.Point(471, 431)
        Me.save3.Name = "save3"
        Me.save3.Size = New System.Drawing.Size(89, 41)
        Me.save3.TabIndex = 157
        Me.save3.Text = "保存"
        Me.save3.UseVisualStyleBackColor = True
        '
        'MarryDatePicker
        '
        Me.MarryDatePicker.Location = New System.Drawing.Point(706, 177)
        Me.MarryDatePicker.Name = "MarryDatePicker"
        Me.MarryDatePicker.Size = New System.Drawing.Size(200, 28)
        Me.MarryDatePicker.TabIndex = 163
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(71, 94)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(80, 18)
        Me.Label34.TabIndex = 147
        Me.Label34.Text = "爱人姓名"
        '
        'LoverWorkPlaceBox
        '
        Me.LoverWorkPlaceBox.Location = New System.Drawing.Point(189, 339)
        Me.LoverWorkPlaceBox.Name = "LoverWorkPlaceBox"
        Me.LoverWorkPlaceBox.Size = New System.Drawing.Size(717, 28)
        Me.LoverWorkPlaceBox.TabIndex = 155
        '
        'LoverPoliticsBox
        '
        Me.LoverPoliticsBox.FormattingEnabled = True
        Me.LoverPoliticsBox.Items.AddRange(New Object() {"群众", "共青团员", "共产党员"})
        Me.LoverPoliticsBox.Location = New System.Drawing.Point(746, 243)
        Me.LoverPoliticsBox.Name = "LoverPoliticsBox"
        Me.LoverPoliticsBox.Size = New System.Drawing.Size(121, 26)
        Me.LoverPoliticsBox.TabIndex = 156
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(67, 342)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(116, 18)
        Me.Label36.TabIndex = 150
        Me.Label36.Text = "爱人工作地址"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(71, 249)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(80, 18)
        Me.Label37.TabIndex = 151
        Me.Label37.Text = "爱人职业"
        '
        'LoverJobBox
        '
        Me.LoverJobBox.Location = New System.Drawing.Point(219, 246)
        Me.LoverJobBox.Name = "LoverJobBox"
        Me.LoverJobBox.Size = New System.Drawing.Size(197, 28)
        Me.LoverJobBox.TabIndex = 154
        '
        'LoverBirthdate
        '
        Me.LoverBirthdate.Location = New System.Drawing.Point(207, 170)
        Me.LoverBirthdate.Name = "LoverBirthdate"
        Me.LoverBirthdate.Size = New System.Drawing.Size(200, 28)
        Me.LoverBirthdate.TabIndex = 162
        '
        'LoverNameBox
        '
        Me.LoverNameBox.Location = New System.Drawing.Point(210, 84)
        Me.LoverNameBox.Name = "LoverNameBox"
        Me.LoverNameBox.Size = New System.Drawing.Size(197, 28)
        Me.LoverNameBox.TabIndex = 148
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(71, 177)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(80, 18)
        Me.Label38.TabIndex = 152
        Me.Label38.Text = "爱人生日"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(604, 246)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(116, 18)
        Me.Label39.TabIndex = 153
        Me.Label39.Text = "爱人政治面貌"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(604, 184)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(80, 18)
        Me.Label35.TabIndex = 149
        Me.Label35.Text = "结婚时间"
        '
        'Cancel1
        '
        Me.Cancel1.Location = New System.Drawing.Point(904, 563)
        Me.Cancel1.Name = "Cancel1"
        Me.Cancel1.Size = New System.Drawing.Size(88, 41)
        Me.Cancel1.TabIndex = 165
        Me.Cancel1.Text = "关闭"
        Me.Cancel1.UseVisualStyleBackColor = True
        '
        'AlterInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 637)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AlterInformation"
        Me.Text = "修改员工信息"
        Me.TabControl1.ResumeLayout(False)
        Me.基本信息.ResumeLayout(False)
        Me.基本信息.PerformLayout()
        Me.学历信息.ResumeLayout(False)
        Me.学历信息.PerformLayout()
        Me.婚姻信息.ResumeLayout(False)
        Me.婚姻信息.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents 基本信息 As TabPage
    Friend WithEvents Label24 As Label
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents JobCodeBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents StatusBox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PhonBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PoliticsBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents 学历信息 As TabPage
    Friend WithEvents save1 As Button
    Friend WithEvents Cancel1 As Button
    Friend WithEvents 婚姻信息 As TabPage
    Friend WithEvents save2 As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents LanguageLevelBox As ComboBox
    Friend WithEvents ForeignLanguageBox As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents LoverNameBox As TextBox
    Friend WithEvents MarryDatePicker As DateTimePicker
    Friend WithEvents LoverBirthdate As DateTimePicker
    Friend WithEvents save3 As Button
    Friend WithEvents LoverPoliticsBox As ComboBox
    Friend WithEvents LoverWorkPlaceBox As TextBox
    Friend WithEvents LoverJobBox As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents EnoBox As ComboBox
End Class
