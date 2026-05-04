<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reqFrm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reqtype = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Create = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Req = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deatils = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Other = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(910, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(53, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(54, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'reqtype
        '
        Me.reqtype.AutoSize = True
        Me.reqtype.Location = New System.Drawing.Point(14, 80)
        Me.reqtype.Name = "reqtype"
        Me.reqtype.Size = New System.Drawing.Size(67, 17)
        Me.reqtype.TabIndex = 1
        Me.reqtype.Text = "Req Type"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "", "IT Request", "Mobile Line Request"})
        Me.ComboBox1.Location = New System.Drawing.Point(83, 76)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Site"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"", "OCT", "Suez"})
        Me.ComboBox2.Location = New System.Drawing.Point(320, 76)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(140, 24)
        Me.ComboBox2.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Create)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 119)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(882, 105)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requester details"
        '
        'Create
        '
        Me.Create.Location = New System.Drawing.Point(771, 36)
        Me.Create.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(87, 28)
        Me.Create.TabIndex = 5
        Me.Create.Text = "Create"
        Me.Create.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(349, 65)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(140, 24)
        Me.ComboBox4.TabIndex = 4
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(349, 32)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(140, 24)
        Me.ComboBox3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Manger"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User_Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 23)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(219, 57)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(108, 23)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(108, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "On behalf of:"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(14, 25)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 21)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "For me"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.ComboBox6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.ComboBox5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 234)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(881, 401)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Request Detail"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Req, Me.Deatils, Me.prv, Me.Other, Me.Remarks, Me.Status})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 145)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(852, 231)
        Me.DataGridView1.TabIndex = 10
        '
        'Req
        '
        Me.Req.HeaderText = "Req"
        Me.Req.MinimumWidth = 6
        Me.Req.Name = "Req"
        Me.Req.Width = 120
        '
        'Deatils
        '
        Me.Deatils.HeaderText = "Details"
        Me.Deatils.MinimumWidth = 6
        Me.Deatils.Name = "Deatils"
        Me.Deatils.Width = 125
        '
        'prv
        '
        Me.prv.HeaderText = "Private"
        Me.prv.MinimumWidth = 6
        Me.prv.Name = "prv"
        Me.prv.Width = 125
        '
        'Other
        '
        Me.Other.HeaderText = "Other"
        Me.Other.MinimumWidth = 6
        Me.Other.Name = "Other"
        Me.Other.Width = 125
        '
        'Remarks
        '
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.MinimumWidth = 6
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Width = 125
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.Width = 125
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(78, 76)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(779, 61)
        Me.TextBox2.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Remarks"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(771, 26)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 28)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(625, 28)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 24)
        Me.TextBox1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(577, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Other"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(486, 31)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 21)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Private"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox6
        '
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(322, 28)
        Me.ComboBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(140, 24)
        Me.ComboBox6.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(269, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Details"
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"", "Hardware", "Service", "Software"})
        Me.ComboBox5.Location = New System.Drawing.Point(78, 28)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(140, 24)
        Me.ComboBox5.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Req:"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(608, 71)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(116, 24)
        Me.TextBox3.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(560, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Other"
        '
        'reqFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 650)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.reqtype)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "reqFrm"
        Me.Text = "Req Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Create As Button
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Req As DataGridViewTextBoxColumn
    Friend WithEvents Deatils As DataGridViewTextBoxColumn
    Friend WithEvents prv As DataGridViewTextBoxColumn
    Friend WithEvents Other As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Private WithEvents reqtype As Label
End Class
