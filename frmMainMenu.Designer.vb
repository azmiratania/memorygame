<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnStartGame = New System.Windows.Forms.Button
        Me.btnInstruction = New System.Windows.Forms.Button
        Me.btnHighScores = New System.Windows.Forms.Button
        Me.btnTrainMode = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.picVolume = New System.Windows.Forms.PictureBox
        CType(Me.picVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStartGame
        '
        Me.btnStartGame.BackColor = System.Drawing.Color.YellowGreen
        Me.btnStartGame.BackgroundImage = CType(resources.GetObject("btnStartGame.BackgroundImage"), System.Drawing.Image)
        Me.btnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartGame.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.Location = New System.Drawing.Point(151, 51)
        Me.btnStartGame.Margin = New System.Windows.Forms.Padding(6)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(189, 52)
        Me.btnStartGame.TabIndex = 0
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = False
        '
        'btnInstruction
        '
        Me.btnInstruction.BackColor = System.Drawing.Color.YellowGreen
        Me.btnInstruction.BackgroundImage = CType(resources.GetObject("btnInstruction.BackgroundImage"), System.Drawing.Image)
        Me.btnInstruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstruction.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstruction.Location = New System.Drawing.Point(192, 112)
        Me.btnInstruction.Name = "btnInstruction"
        Me.btnInstruction.Size = New System.Drawing.Size(189, 49)
        Me.btnInstruction.TabIndex = 1
        Me.btnInstruction.Text = "How To Play"
        Me.btnInstruction.UseVisualStyleBackColor = False
        '
        'btnHighScores
        '
        Me.btnHighScores.BackColor = System.Drawing.Color.YellowGreen
        Me.btnHighScores.BackgroundImage = CType(resources.GetObject("btnHighScores.BackgroundImage"), System.Drawing.Image)
        Me.btnHighScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHighScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHighScores.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScores.Location = New System.Drawing.Point(259, 224)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(189, 46)
        Me.btnHighScores.TabIndex = 2
        Me.btnHighScores.Text = "Hall Of Fame"
        Me.btnHighScores.UseVisualStyleBackColor = False
        '
        'btnTrainMode
        '
        Me.btnTrainMode.BackColor = System.Drawing.Color.YellowGreen
        Me.btnTrainMode.BackgroundImage = CType(resources.GetObject("btnTrainMode.BackgroundImage"), System.Drawing.Image)
        Me.btnTrainMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTrainMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrainMode.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrainMode.Location = New System.Drawing.Point(220, 173)
        Me.btnTrainMode.Name = "btnTrainMode"
        Me.btnTrainMode.Size = New System.Drawing.Size(189, 45)
        Me.btnTrainMode.TabIndex = 4
        Me.btnTrainMode.Text = "Training Mode"
        Me.btnTrainMode.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.YellowGreen
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(292, 276)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(189, 47)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picVolume
        '
        Me.picVolume.Location = New System.Drawing.Point(632, 384)
        Me.picVolume.Name = "picVolume"
        Me.picVolume.Size = New System.Drawing.Size(25, 25)
        Me.picVolume.TabIndex = 5
        Me.picVolume.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(676, 419)
        Me.Controls.Add(Me.picVolume)
        Me.Controls.Add(Me.btnTrainMode)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.btnInstruction)
        Me.Controls.Add(Me.btnStartGame)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome To Make-A-Match"
        CType(Me.picVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStartGame As System.Windows.Forms.Button
    Friend WithEvents btnInstruction As System.Windows.Forms.Button
    Friend WithEvents btnHighScores As System.Windows.Forms.Button
    Friend WithEvents btnTrainMode As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picVolume As System.Windows.Forms.PictureBox
End Class
