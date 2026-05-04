<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loginbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email"
        '
        'loginbox
        '
        Me.loginbox.Location = New System.Drawing.Point(125, 55)
        Me.loginbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.loginbox.Name = "loginbox"
        Me.loginbox.Size = New System.Drawing.Size(200, 24)
        Me.loginbox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'passtxt
        '
        Me.passtxt.Location = New System.Drawing.Point(125, 106)
        Me.passtxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(200, 24)
        Me.passtxt.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 194)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 273)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.loginbox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents loginbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents passtxt As TextBox
    Friend WithEvents Button1 As Button
End Class
