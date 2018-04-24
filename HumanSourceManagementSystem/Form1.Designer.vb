<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.信息录入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新增员工ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.添加基本信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.添加学历信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.添加婚姻状况ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打印ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.显示员工信息表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.显示员工学业表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.显示员工ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.部门ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.岗位信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.员工状态查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除员工ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.信息录入ToolStripMenuItem, Me.打印ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1072, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '信息录入ToolStripMenuItem
        '
        Me.信息录入ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新增员工ToolStripMenuItem, Me.修改ToolStripMenuItem, Me.删除员工ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.信息录入ToolStripMenuItem.Name = "信息录入ToolStripMenuItem"
        Me.信息录入ToolStripMenuItem.Size = New System.Drawing.Size(94, 28)
        Me.信息录入ToolStripMenuItem.Text = "员工管理"
        '
        '新增员工ToolStripMenuItem
        '
        Me.新增员工ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.添加基本信息ToolStripMenuItem, Me.添加学历信息ToolStripMenuItem, Me.添加婚姻状况ToolStripMenuItem})
        Me.新增员工ToolStripMenuItem.Name = "新增员工ToolStripMenuItem"
        Me.新增员工ToolStripMenuItem.Size = New System.Drawing.Size(233, 30)
        Me.新增员工ToolStripMenuItem.Text = "新增员工"
        '
        '添加基本信息ToolStripMenuItem
        '
        Me.添加基本信息ToolStripMenuItem.Name = "添加基本信息ToolStripMenuItem"
        Me.添加基本信息ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.添加基本信息ToolStripMenuItem.Size = New System.Drawing.Size(268, 30)
        Me.添加基本信息ToolStripMenuItem.Text = "添加基本信息"
        '
        '添加学历信息ToolStripMenuItem
        '
        Me.添加学历信息ToolStripMenuItem.Name = "添加学历信息ToolStripMenuItem"
        Me.添加学历信息ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.添加学历信息ToolStripMenuItem.Size = New System.Drawing.Size(268, 30)
        Me.添加学历信息ToolStripMenuItem.Text = "添加学历信息"
        '
        '添加婚姻状况ToolStripMenuItem
        '
        Me.添加婚姻状况ToolStripMenuItem.Name = "添加婚姻状况ToolStripMenuItem"
        Me.添加婚姻状况ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.添加婚姻状况ToolStripMenuItem.Size = New System.Drawing.Size(268, 30)
        Me.添加婚姻状况ToolStripMenuItem.Text = "添加婚姻状况"
        '
        '修改ToolStripMenuItem
        '
        Me.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem"
        Me.修改ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.修改ToolStripMenuItem.Size = New System.Drawing.Size(233, 30)
        Me.修改ToolStripMenuItem.Text = "人事变动"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(233, 30)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '打印ToolStripMenuItem
        '
        Me.打印ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.显示员工信息表ToolStripMenuItem, Me.显示员工学业表ToolStripMenuItem, Me.显示员工ToolStripMenuItem, Me.部门ToolStripMenuItem, Me.岗位信息ToolStripMenuItem, Me.员工状态查询ToolStripMenuItem})
        Me.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem"
        Me.打印ToolStripMenuItem.Size = New System.Drawing.Size(58, 28)
        Me.打印ToolStripMenuItem.Text = "显示"
        '
        '显示员工信息表ToolStripMenuItem
        '
        Me.显示员工信息表ToolStripMenuItem.Name = "显示员工信息表ToolStripMenuItem"
        Me.显示员工信息表ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.显示员工信息表ToolStripMenuItem.Size = New System.Drawing.Size(266, 30)
        Me.显示员工信息表ToolStripMenuItem.Text = "员工基本信息"
        '
        '显示员工学业表ToolStripMenuItem
        '
        Me.显示员工学业表ToolStripMenuItem.Name = "显示员工学业表ToolStripMenuItem"
        Me.显示员工学业表ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.显示员工学业表ToolStripMenuItem.Size = New System.Drawing.Size(266, 30)
        Me.显示员工学业表ToolStripMenuItem.Text = "员工学历状况"
        '
        '显示员工ToolStripMenuItem
        '
        Me.显示员工ToolStripMenuItem.Name = "显示员工ToolStripMenuItem"
        Me.显示员工ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.显示员工ToolStripMenuItem.Size = New System.Drawing.Size(266, 30)
        Me.显示员工ToolStripMenuItem.Text = "员工婚姻状况"
        '
        '部门ToolStripMenuItem
        '
        Me.部门ToolStripMenuItem.Name = "部门ToolStripMenuItem"
        Me.部门ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.部门ToolStripMenuItem.Size = New System.Drawing.Size(266, 30)
        Me.部门ToolStripMenuItem.Text = "部门信息"
        '
        '岗位信息ToolStripMenuItem
        '
        Me.岗位信息ToolStripMenuItem.Name = "岗位信息ToolStripMenuItem"
        Me.岗位信息ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.岗位信息ToolStripMenuItem.Size = New System.Drawing.Size(266, 30)
        Me.岗位信息ToolStripMenuItem.Text = "岗位信息"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.帮助ToolStripMenuItem1, Me.关于ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(58, 28)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '帮助ToolStripMenuItem1
        '
        Me.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1"
        Me.帮助ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.帮助ToolStripMenuItem1.Size = New System.Drawing.Size(204, 30)
        Me.帮助ToolStripMenuItem1.Text = "帮助"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(204, 30)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1072, 33)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(60, 30)
        Me.ToolStripButton1.Text = "添加员工基本信息"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(60, 30)
        Me.ToolStripButton2.Text = "添加员工基本信息"
        Me.ToolStripButton2.ToolTipText = "修改员工基本信息"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(60, 30)
        Me.ToolStripButton3.Text = "查找员工"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(60, 30)
        Me.ToolStripButton4.Text = "删除员工"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.AutoSize = False
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(60, 30)
        Me.ToolStripButton5.Text = "显示员工基本信息"
        '
        '员工状态查询ToolStripMenuItem
        '
        Me.员工状态查询ToolStripMenuItem.Name = "员工状态查询ToolStripMenuItem"
        Me.员工状态查询ToolStripMenuItem.Size = New System.Drawing.Size(266, 30)
        Me.员工状态查询ToolStripMenuItem.Text = "员工状态查询"
        '
        '删除员工ToolStripMenuItem
        '
        Me.删除员工ToolStripMenuItem.Name = "删除员工ToolStripMenuItem"
        Me.删除员工ToolStripMenuItem.Size = New System.Drawing.Size(233, 30)
        Me.删除员工ToolStripMenuItem.Text = "删除员工"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1072, 664)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "人事管理系统"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 信息录入ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新增员工ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打印ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 显示员工信息表ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 显示员工学业表ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 显示员工ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 添加基本信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 添加学历信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 添加婚姻状况ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 部门ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 岗位信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents 帮助ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 员工状态查询ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除员工ToolStripMenuItem As ToolStripMenuItem
End Class
