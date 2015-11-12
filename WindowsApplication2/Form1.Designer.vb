<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1C = New System.Windows.Forms.Button()
        Me.Button1F = New System.Windows.Forms.Button()
        Me.txtbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1C
        '
        Me.Button1C.Location = New System.Drawing.Point(168, 72)
        Me.Button1C.Name = "Button1C"
        Me.Button1C.Size = New System.Drawing.Size(76, 37)
        Me.Button1C.TabIndex = 0
        Me.Button1C.Text = "攝氏"
        Me.Button1C.UseVisualStyleBackColor = True
        '
        'Button1F
        '
        Me.Button1F.Location = New System.Drawing.Point(168, 144)
        Me.Button1F.Name = "Button1F"
        Me.Button1F.Size = New System.Drawing.Size(73, 34)
        Me.Button1F.TabIndex = 1
        Me.Button1F.Text = "華氏"
        Me.Button1F.UseVisualStyleBackColor = True
        '
        'txtbox
        '
        Me.txtbox.Font = New System.Drawing.Font("微軟正黑體", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtbox.Location = New System.Drawing.Point(28, 86)
        Me.txtbox.Multiline = True
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(122, 81)
        Me.txtbox.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 273)
        Me.Controls.Add(Me.txtbox)
        Me.Controls.Add(Me.Button1F)
        Me.Controls.Add(Me.Button1C)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1C As System.Windows.Forms.Button
    Friend WithEvents Button1F As System.Windows.Forms.Button
    Friend WithEvents txtbox As System.Windows.Forms.TextBox

End Class
