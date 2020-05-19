<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSynonym
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSynonym))
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblScore = New System.Windows.Forms.Label
        Me.lblTries = New System.Windows.Forms.Label
        Me.picMatch = New System.Windows.Forms.PictureBox
        Me.tmrMatch = New System.Windows.Forms.Timer(Me.components)
        Me.btnNewGame = New System.Windows.Forms.Button
        Me.btnMainMenu = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HighScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutMakeAMatchGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.picMatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrCheck
        '
        '
        'Timer1
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(9, 26)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(76, 15)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Time : 0 : 0 : 0"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(9, 59)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(101, 15)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "Score : 0 out of 18"
        '
        'lblTries
        '
        Me.lblTries.AutoSize = True
        Me.lblTries.Location = New System.Drawing.Point(9, 92)
        Me.lblTries.Name = "lblTries"
        Me.lblTries.Size = New System.Drawing.Size(95, 15)
        Me.lblTries.TabIndex = 2
        Me.lblTries.Text = "Enjoy the game !"
        '
        'picMatch
        '
        Me.picMatch.Location = New System.Drawing.Point(507, 158)
        Me.picMatch.Name = "picMatch"
        Me.picMatch.Size = New System.Drawing.Size(126, 105)
        Me.picMatch.TabIndex = 3
        Me.picMatch.TabStop = False
        '
        'tmrMatch
        '
        '
        'btnNewGame
        '
        Me.btnNewGame.BackColor = System.Drawing.Color.GreenYellow
        Me.btnNewGame.BackgroundImage = CType(resources.GetObject("btnNewGame.BackgroundImage"), System.Drawing.Image)
        Me.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewGame.Location = New System.Drawing.Point(505, 315)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(148, 38)
        Me.btnNewGame.TabIndex = 4
        Me.btnNewGame.Text = "Play Again"
        Me.btnNewGame.UseVisualStyleBackColor = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.GreenYellow
        Me.btnMainMenu.BackgroundImage = CType(resources.GetObject("btnMainMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Location = New System.Drawing.Point(505, 359)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(148, 39)
        Me.btnMainMenu.TabIndex = 5
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblTries)
        Me.GroupBox1.Controls.Add(Me.lblScore)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(495, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 126)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Challenge Mode"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(678, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.HighScoreToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Game"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game           F2"
        '
        'HighScoreToolStripMenuItem
        '
        Me.HighScoreToolStripMenuItem.Name = "HighScoreToolStripMenuItem"
        Me.HighScoreToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.HighScoreToolStripMenuItem.Text = "High Score "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutMakeAMatchGameToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'AboutMakeAMatchGameToolStripMenuItem
        '
        Me.AboutMakeAMatchGameToolStripMenuItem.Name = "AboutMakeAMatchGameToolStripMenuItem"
        Me.AboutMakeAMatchGameToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.AboutMakeAMatchGameToolStripMenuItem.Text = "About Make-A-Match Game"
        '
        'frmSynonym
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(678, 448)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.picMatch)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSynonym"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make-A-Match Game"
        CType(Me.picMatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrCheck As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblTries As System.Windows.Forms.Label
    Friend WithEvents picMatch As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMatch As System.Windows.Forms.Timer
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighScoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMakeAMatchGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
