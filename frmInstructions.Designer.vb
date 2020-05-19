<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstructions))
        Me.lblTextInstruction = New System.Windows.Forms.Label
        Me.lblText1 = New System.Windows.Forms.Label
        Me.lblText2 = New System.Windows.Forms.Label
        Me.btnMainMenu = New System.Windows.Forms.Button
        Me.btnTrainingMode = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblTextInstruction
        '
        Me.lblTextInstruction.AutoSize = True
        Me.lblTextInstruction.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextInstruction.Location = New System.Drawing.Point(240, 43)
        Me.lblTextInstruction.Name = "lblTextInstruction"
        Me.lblTextInstruction.Size = New System.Drawing.Size(189, 38)
        Me.lblTextInstruction.TabIndex = 0
        Me.lblTextInstruction.Text = "Instructions"
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText1.Location = New System.Drawing.Point(202, 116)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(358, 60)
        Me.lblText1.TabIndex = 1
        Me.lblText1.Text = "Depending on the mode that you have chosen," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a specific number of boxes of which " & _
            "are even " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will appear."
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText2.Location = New System.Drawing.Point(204, 192)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(277, 60)
        Me.lblText2.TabIndex = 2
        Me.lblText2.Text = "Find the corresponding synonym that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "matches the word which you have " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "clicked fi" & _
            "rst."
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.YellowGreen
        Me.btnMainMenu.BackgroundImage = CType(resources.GetObject("btnMainMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMainMenu.Location = New System.Drawing.Point(385, 368)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(182, 39)
        Me.btnMainMenu.TabIndex = 3
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnTrainingMode
        '
        Me.btnTrainingMode.BackColor = System.Drawing.Color.YellowGreen
        Me.btnTrainingMode.BackgroundImage = CType(resources.GetObject("btnTrainingMode.BackgroundImage"), System.Drawing.Image)
        Me.btnTrainingMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTrainingMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTrainingMode.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrainingMode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTrainingMode.Location = New System.Drawing.Point(189, 368)
        Me.btnTrainingMode.Name = "btnTrainingMode"
        Me.btnTrainingMode.Size = New System.Drawing.Size(173, 39)
        Me.btnTrainingMode.TabIndex = 4
        Me.btnTrainingMode.Text = "Training Mode"
        Me.btnTrainingMode.UseVisualStyleBackColor = False
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(793, 448)
        Me.Controls.Add(Me.btnTrainingMode)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.lblText1)
        Me.Controls.Add(Me.lblTextInstruction)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmInstructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "How To Play "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTextInstruction As System.Windows.Forms.Label
    Friend WithEvents lblText1 As System.Windows.Forms.Label
    Friend WithEvents lblText2 As System.Windows.Forms.Label
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnTrainingMode As System.Windows.Forms.Button
End Class
