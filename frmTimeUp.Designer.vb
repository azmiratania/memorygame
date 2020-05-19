<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeUp))
        Me.tmrIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.picBomb = New System.Windows.Forms.PictureBox
        Me.lblGameOver = New System.Windows.Forms.Label
        CType(Me.picBomb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrIncrease
        '
        '
        'picBomb
        '
        Me.picBomb.Location = New System.Drawing.Point(125, 60)
        Me.picBomb.Name = "picBomb"
        Me.picBomb.Size = New System.Drawing.Size(194, 160)
        Me.picBomb.TabIndex = 3
        Me.picBomb.TabStop = False
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Location = New System.Drawing.Point(250, 223)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(0, 13)
        Me.lblGameOver.TabIndex = 4
        '
        'frmTimeUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(422, 345)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.picBomb)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTimeUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Over "
        CType(Me.picBomb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrIncrease As System.Windows.Forms.Timer
    Friend WithEvents picBomb As System.Windows.Forms.PictureBox
    Friend WithEvents lblGameOver As System.Windows.Forms.Label
End Class
