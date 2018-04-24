<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowMarry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowMarry))
        Me.MarryDataGrid = New System.Windows.Forms.DataGridView()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Refresh = New System.Windows.Forms.Button()
        CType(Me.MarryDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MarryDataGrid
        '
        Me.MarryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarryDataGrid.Location = New System.Drawing.Point(50, 46)
        Me.MarryDataGrid.Name = "MarryDataGrid"
        Me.MarryDataGrid.RowTemplate.Height = 30
        Me.MarryDataGrid.Size = New System.Drawing.Size(810, 419)
        Me.MarryDataGrid.TabIndex = 5
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(648, 512)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(99, 40)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "取消"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(122, 512)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(101, 40)
        Me.Refresh.TabIndex = 3
        Me.Refresh.Text = "刷新"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'ShowMarry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 571)
        Me.Controls.Add(Me.MarryDataGrid)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Refresh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShowMarry"
        Me.Text = "显示员工婚姻状况"
        CType(Me.MarryDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MarryDataGrid As DataGridView
    Friend WithEvents Cancel As Button
    Friend WithEvents Refresh As Button
End Class
