<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCongratulation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCongratulation))
        Me.btnHighScore = New System.Windows.Forms.Button
        Me.btnMainMenu = New System.Windows.Forms.Button
        Me.picClap = New System.Windows.Forms.PictureBox
        Me.tmrClap = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblCongratulation = New System.Windows.Forms.Label
        CType(Me.picClap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHighScore
        '
        Me.btnHighScore.BackColor = System.Drawing.SystemColors.Window
        Me.btnHighScore.BackgroundImage = CType(resources.GetObject("btnHighScore.BackgroundImage"), System.Drawing.Image)
        Me.btnHighScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHighScore.ForeColor = System.Drawing.Color.Black
        Me.btnHighScore.Location = New System.Drawing.Point(346, 268)
        Me.btnHighScore.Name = "btnHighScore"
        Me.btnHighScore.Size = New System.Drawing.Size(187, 40)
        Me.btnHighScore.TabIndex = 1
        Me.btnHighScore.Text = "View High Score"
        Me.btnHighScore.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.Window
        Me.btnMainMenu.BackgroundImage = CType(resources.GetObject("btnMainMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMainMenu.Location = New System.Drawing.Point(346, 317)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(187, 40)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'picClap
        '
        Me.picClap.Location = New System.Drawing.Point(12, 44)
        Me.picClap.Name = "picClap"
        Me.picClap.Size = New System.Drawing.Size(110, 122)
        Me.picClap.TabIndex = 4
        Me.picClap.TabStop = False
        '
        'tmrClap
        '
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Window
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Location = New System.Drawing.Point(346, 363)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(187, 43)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit Game"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblCongratulation
        '
        Me.lblCongratulation.AutoSize = True
        Me.lblCongratulation.Font = New System.Drawing.Font("Century Gothic", 34.0!, System.Drawing.FontStyle.Bold)
        Me.lblCongratulation.ForeColor = System.Drawing.Color.Crimson
        Me.lblCongratulation.Location = New System.Drawing.Point(145, 97)
        Me.lblCongratulation.Name = "lblCongratulation"
        Me.lblCongratulation.Size = New System.Drawing.Size(370, 55)
        Me.lblCongratulation.TabIndex = 7
        Me.lblCongratulation.Text = "Congratulation!"
        '
        'frmCongratulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(700, 410)
        Me.Controls.Add(Me.lblCongratulation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picClap)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnHighScore)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCongratulation"
        Me.Text = "Congratulation ! You Win !"
        CType(Me.picClap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHighScore As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents picClap As System.Windows.Forms.PictureBox
    Friend WithEvents tmrClap As System.Windows.Forms.Timer
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCongratulation As System.Windows.Forms.Label
End Class
