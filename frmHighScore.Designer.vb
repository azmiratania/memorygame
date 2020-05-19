<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHighScore))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblPName = New System.Windows.Forms.Label
        Me.lblTries = New System.Windows.Forms.Label
        Me.lblTotTime = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblHighestScore = New System.Windows.Forms.Label
        Me.btnMainMenu = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tries"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(385, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Time Taken"
        '
        'lblPName
        '
        Me.lblPName.AutoSize = True
        Me.lblPName.Location = New System.Drawing.Point(164, 120)
        Me.lblPName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPName.Name = "lblPName"
        Me.lblPName.Size = New System.Drawing.Size(61, 21)
        Me.lblPName.TabIndex = 5
        Me.lblPName.Text = "Label4"
        '
        'lblTries
        '
        Me.lblTries.AutoSize = True
        Me.lblTries.Location = New System.Drawing.Point(299, 120)
        Me.lblTries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTries.Name = "lblTries"
        Me.lblTries.Size = New System.Drawing.Size(61, 21)
        Me.lblTries.TabIndex = 6
        Me.lblTries.Text = "Label5"
        '
        'lblTotTime
        '
        Me.lblTotTime.AutoSize = True
        Me.lblTotTime.Location = New System.Drawing.Point(385, 120)
        Me.lblTotTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotTime.Name = "lblTotTime"
        Me.lblTotTime.Size = New System.Drawing.Size(61, 21)
        Me.lblTotTime.TabIndex = 7
        Me.lblTotTime.Text = "Label6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 389)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Highest Score :"
        '
        'lblHighestScore
        '
        Me.lblHighestScore.AutoSize = True
        Me.lblHighestScore.Location = New System.Drawing.Point(299, 389)
        Me.lblHighestScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHighestScore.Name = "lblHighestScore"
        Me.lblHighestScore.Size = New System.Drawing.Size(61, 21)
        Me.lblHighestScore.TabIndex = 9
        Me.lblHighestScore.Text = "Label5"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.YellowGreen
        Me.btnMainMenu.BackgroundImage = CType(resources.GetObject("btnMainMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainMenu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(487, 417)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(186, 39)
        Me.btnMainMenu.TabIndex = 10
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'frmHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(706, 460)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblHighestScore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotTime)
        Me.Controls.Add(Me.lblTries)
        Me.Controls.Add(Me.lblPName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmHighScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hall Of Fame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPName As System.Windows.Forms.Label
    Friend WithEvents lblTries As System.Windows.Forms.Label
    Friend WithEvents lblTotTime As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblHighestScore As System.Windows.Forms.Label
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
End Class
