<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENUS
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENUS))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewSubjectToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FindStudentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FindClassDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 395)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(786, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem, Me.InformationToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(786, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewStudentToolStripMenuItem, Me.AddNewSubjectToolStripMenuItem, Me.AddNewClassToolStripMenuItem, Me.AddNewSubjectToolStripMenuItem1})
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.AddNewToolStripMenuItem.Text = "Add New"
        '
        'AddNewStudentToolStripMenuItem
        '
        Me.AddNewStudentToolStripMenuItem.Name = "AddNewStudentToolStripMenuItem"
        Me.AddNewStudentToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AddNewStudentToolStripMenuItem.Text = "Add New Student"
        '
        'AddNewSubjectToolStripMenuItem
        '
        Me.AddNewSubjectToolStripMenuItem.Name = "AddNewSubjectToolStripMenuItem"
        Me.AddNewSubjectToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AddNewSubjectToolStripMenuItem.Text = "Add New Subject"
        '
        'AddNewClassToolStripMenuItem
        '
        Me.AddNewClassToolStripMenuItem.Name = "AddNewClassToolStripMenuItem"
        Me.AddNewClassToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AddNewClassToolStripMenuItem.Text = "Add New Class"
        '
        'AddNewSubjectToolStripMenuItem1
        '
        Me.AddNewSubjectToolStripMenuItem1.Name = "AddNewSubjectToolStripMenuItem1"
        Me.AddNewSubjectToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.AddNewSubjectToolStripMenuItem1.Text = "Add New Course"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchStudentToolStripMenuItem, Me.FindStudentDetailsToolStripMenuItem, Me.SearchSubjectToolStripMenuItem, Me.FindClassDetailsToolStripMenuItem})
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'SearchStudentToolStripMenuItem
        '
        Me.SearchStudentToolStripMenuItem.Name = "SearchStudentToolStripMenuItem"
        Me.SearchStudentToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SearchStudentToolStripMenuItem.Text = "Find Student "
        '
        'FindStudentDetailsToolStripMenuItem
        '
        Me.FindStudentDetailsToolStripMenuItem.Name = "FindStudentDetailsToolStripMenuItem"
        Me.FindStudentDetailsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.FindStudentDetailsToolStripMenuItem.Text = "Find Student Details"
        '
        'SearchSubjectToolStripMenuItem
        '
        Me.SearchSubjectToolStripMenuItem.Name = "SearchSubjectToolStripMenuItem"
        Me.SearchSubjectToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SearchSubjectToolStripMenuItem.Text = "Find Subject Details"
        '
        'FindClassDetailsToolStripMenuItem
        '
        Me.FindClassDetailsToolStripMenuItem.Name = "FindClassDetailsToolStripMenuItem"
        Me.FindClassDetailsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.FindClassDetailsToolStripMenuItem.Text = "Find Class Details"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(676, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 29)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'MENUS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(786, 417)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MENUS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENUS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewSubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindStudentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchSubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindClassDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewSubjectToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
