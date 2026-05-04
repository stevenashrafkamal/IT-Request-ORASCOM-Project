<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITReqToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(933, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ITToolStripMenuItem
        '
        Me.ITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ITReqToolStripMenuItem})
        Me.ITToolStripMenuItem.Name = "ITToolStripMenuItem"
        Me.ITToolStripMenuItem.Size = New System.Drawing.Size(35, 24)
        Me.ITToolStripMenuItem.Text = "IT"
        '
        'ITReqToolStripMenuItem
        '
        Me.ITReqToolStripMenuItem.Name = "ITReqToolStripMenuItem"
        Me.ITReqToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.ITReqToolStripMenuItem.Text = "IT Req"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 554)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ITReqToolStripMenuItem As ToolStripMenuItem
End Class
