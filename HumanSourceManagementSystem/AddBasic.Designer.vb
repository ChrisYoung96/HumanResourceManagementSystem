<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBasic
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBasic))
        Me.Cancel = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.StatusBox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.HomeBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PhonBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PoliticsBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.IdBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NationBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.EsexBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.EnameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EnoBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.JionDate = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DnoBox = New System.Windows.Forms.ComboBox()
        Me.JobCodeBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(770, 440)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(88, 41)
        Me.Cancel.TabIndex = 32
        Me.Cancel.Text = "关闭"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(224, 440)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(89, 41)
        Me.save.TabIndex = 31
        Me.save.Text = "保存"
        Me.save.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(591, 248)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 18)
        Me.Label26.TabIndex = 135
        Me.Label26.Text = "岗位代码"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(591, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 18)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "岗位代码"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(360, 241)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 18)
        Me.Label25.TabIndex = 131
        Me.Label25.Text = "状态"
        '
        'StatusBox
        '
        Me.StatusBox.FormattingEnabled = True
        Me.StatusBox.Items.AddRange(New Object() {"在职", "请假"})
        Me.StatusBox.Location = New System.Drawing.Point(424, 241)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.Size = New System.Drawing.Size(121, 26)
        Me.StatusBox.TabIndex = 132
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(360, 241)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 18)
        Me.Label13.TabIndex = 130
        Me.Label13.Text = "状态"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(95, 313)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 18)
        Me.Label24.TabIndex = 127
        Me.Label24.Text = "家庭住址"
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(181, 310)
        Me.AddressBox.Multiline = True
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.AddressBox.Size = New System.Drawing.Size(756, 28)
        Me.AddressBox.TabIndex = 128
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(95, 313)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "家庭住址"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(95, 242)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 18)
        Me.Label23.TabIndex = 122
        Me.Label23.Text = "籍贯"
        '
        'HomeBox
        '
        Me.HomeBox.Location = New System.Drawing.Point(158, 239)
        Me.HomeBox.Name = "HomeBox"
        Me.HomeBox.Size = New System.Drawing.Size(137, 28)
        Me.HomeBox.TabIndex = 125
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(95, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 18)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "籍贯"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(94, 183)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 18)
        Me.Label22.TabIndex = 119
        Me.Label22.Text = "联系方式"
        '
        'PhonBox
        '
        Me.PhonBox.Location = New System.Drawing.Point(180, 180)
        Me.PhonBox.Name = "PhonBox"
        Me.PhonBox.Size = New System.Drawing.Size(188, 28)
        Me.PhonBox.TabIndex = 120
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(94, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "联系方式"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(648, 188)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 18)
        Me.Label21.TabIndex = 115
        Me.Label21.Text = "参加工作时间"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(648, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 18)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "参加工作时间"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(374, 185)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 18)
        Me.Label20.TabIndex = 111
        Me.Label20.Text = "政治面貌"
        '
        'PoliticsBox
        '
        Me.PoliticsBox.FormattingEnabled = True
        Me.PoliticsBox.Items.AddRange(New Object() {"群众", "共青团员", "共产党员"})
        Me.PoliticsBox.Location = New System.Drawing.Point(474, 185)
        Me.PoliticsBox.Name = "PoliticsBox"
        Me.PoliticsBox.Size = New System.Drawing.Size(121, 26)
        Me.PoliticsBox.TabIndex = 113
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(374, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "政治面貌"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(648, 115)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 18)
        Me.Label19.TabIndex = 106
        Me.Label19.Text = "身份证号码"
        '
        'IdBox
        '
        Me.IdBox.Location = New System.Drawing.Point(770, 105)
        Me.IdBox.Name = "IdBox"
        Me.IdBox.Size = New System.Drawing.Size(275, 28)
        Me.IdBox.TabIndex = 108
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(648, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 18)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "身份证号码"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(320, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 18)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "出生年月日"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 18)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "出生年月日"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(98, 115)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 18)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "民族"
        '
        'NationBox
        '
        Me.NationBox.Location = New System.Drawing.Point(158, 115)
        Me.NationBox.Name = "NationBox"
        Me.NationBox.Size = New System.Drawing.Size(100, 28)
        Me.NationBox.TabIndex = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(98, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "民族"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(644, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 18)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "性别"
        '
        'EsexBox
        '
        Me.EsexBox.FormattingEnabled = True
        Me.EsexBox.Items.AddRange(New Object() {"男", "女"})
        Me.EsexBox.Location = New System.Drawing.Point(704, 47)
        Me.EsexBox.Name = "EsexBox"
        Me.EsexBox.Size = New System.Drawing.Size(121, 26)
        Me.EsexBox.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(644, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "性别"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(374, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 18)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "姓名"
        '
        'EnameBox
        '
        Me.EnameBox.Location = New System.Drawing.Point(438, 49)
        Me.EnameBox.Name = "EnameBox"
        Me.EnameBox.Size = New System.Drawing.Size(116, 28)
        Me.EnameBox.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "姓名"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "员工号"
        '
        'EnoBox
        '
        Me.EnoBox.Location = New System.Drawing.Point(158, 47)
        Me.EnoBox.Name = "EnoBox"
        Me.EnoBox.Size = New System.Drawing.Size(137, 28)
        Me.EnoBox.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "员工号"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(424, 108)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(170, 28)
        Me.DateTimePicker.TabIndex = 138
        '
        'JionDate
        '
        Me.JionDate.Location = New System.Drawing.Point(770, 185)
        Me.JionDate.Name = "JionDate"
        Me.JionDate.Size = New System.Drawing.Size(170, 28)
        Me.JionDate.TabIndex = 139
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(857, 244)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 18)
        Me.Label27.TabIndex = 140
        Me.Label27.Text = "部门代码"
        '
        'DnoBox
        '
        Me.DnoBox.FormattingEnabled = True
        Me.DnoBox.Location = New System.Drawing.Point(962, 239)
        Me.DnoBox.Name = "DnoBox"
        Me.DnoBox.Size = New System.Drawing.Size(121, 26)
        Me.DnoBox.TabIndex = 141
        '
        'JobCodeBox
        '
        Me.JobCodeBox.FormattingEnabled = True
        Me.JobCodeBox.Location = New System.Drawing.Point(704, 242)
        Me.JobCodeBox.Name = "JobCodeBox"
        Me.JobCodeBox.Size = New System.Drawing.Size(121, 26)
        Me.JobCodeBox.TabIndex = 142
        '
        'AddBasic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 511)
        Me.Controls.Add(Me.JobCodeBox)
        Me.Controls.Add(Me.DnoBox)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.JionDate)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.HomeBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.PhonBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.PoliticsBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.IdBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.NationBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.EsexBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.EnameBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EnoBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Cancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddBasic"
        Me.Text = "添加员工基本信息"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel As Button
    Friend WithEvents save As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents StatusBox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents HomeBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PhonBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PoliticsBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents IdBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents NationBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents EsexBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents EnameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EnoBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents JionDate As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents DnoBox As ComboBox
    Friend WithEvents JobCodeBox As ComboBox
End Class
