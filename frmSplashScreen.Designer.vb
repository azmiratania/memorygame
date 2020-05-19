<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.tmrTitle = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStars = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.picStar4 = New System.Windows.Forms.PictureBox
        Me.picLine = New System.Windows.Forms.PictureBox
        Me.picStar3 = New System.Windows.Forms.PictureBox
        Me.picStar2 = New System.Windows.Forms.PictureBox
        Me.picStar1 = New System.Windows.Forms.PictureBox
        Me.picTitle = New System.Windows.Forms.PictureBox
        Me.picGirl = New System.Windows.Forms.PictureBox
        Me.tmrLine = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.picStar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGirl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrTitle
        '
        '
        'tmrStars
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.picStar4)
        Me.Panel1.Controls.Add(Me.picLine)
        Me.Panel1.Controls.Add(Me.picStar3)
        Me.Panel1.Controls.Add(Me.picStar2)
        Me.Panel1.Controls.Add(Me.picStar1)
        Me.Panel1.Controls.Add(Me.picTitle)
        Me.Panel1.Controls.Add(Me.picGirl)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 412)
        Me.Panel1.TabIndex = 0
        '
        'picStar4
        '
        Me.picStar4.Location = New System.Drawing.Point(619, 18)
        Me.picStar4.Name = "picStar4"
        Me.picStar4.Size = New System.Drawing.Size(15, 15)
        Me.picStar4.TabIndex = 6
        Me.picStar4.TabStop = False
        '
        'picLine
        '
        Me.picLine.Location = New System.Drawing.Point(167, 139)
        Me.picLine.Name = "picLine"
        Me.picLine.Size = New System.Drawing.Size(282, 10)
        Me.picLine.TabIndex = 5
        Me.picLine.TabStop = False
        '
        'picStar3
        '
        Me.picStar3.Location = New System.Drawing.Point(619, 372)
        Me.picStar3.Name = "picStar3"
        Me.picStar3.Size = New System.Drawing.Size(15, 15)
        Me.picStar3.TabIndex = 4
        Me.picStar3.TabStop = False
        '
        'picStar2
        '
        Me.picStar2.Location = New System.Drawing.Point(22, 372)
        Me.picStar2.Name = "picStar2"
        Me.picStar2.Size = New System.Drawing.Size(15, 15)
        Me.picStar2.TabIndex = 3
        Me.picStar2.TabStop = False
        '
        'picStar1
        '
        Me.picStar1.Location = New System.Drawing.Point(22, 18)
        Me.picStar1.Name = "picStar1"
        Me.picStar1.Size = New System.Drawing.Size(15, 15)
        Me.picStar1.TabIndex = 2
        Me.picStar1.TabStop = False
        '
        'picTitle
        '
        Me.picTitle.Location = New System.Drawing.Point(167, 92)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(282, 41)
        Me.picTitle.TabIndex = 1
        Me.picTitle.TabStop = False
        '
        'picGirl
        '
        Me.picGirl.Location = New System.Drawing.Point(5, 3)
        Me.picGirl.Name = "picGirl"
        Me.picGirl.Size = New System.Drawing.Size(659, 408)
        Me.picGirl.TabIndex = 0
        Me.picGirl.TabStop = False
        '
        'tmrLine
        '
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(675, 421)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.picStar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGirl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrTitle As System.Windows.Forms.Timer
    Friend WithEvents tmrStars As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picStar1 As System.Windows.Forms.PictureBox
    Friend WithEvents picTitle As System.Windows.Forms.PictureBox
    Friend WithEvents picGirl As System.Windows.Forms.PictureBox
    Friend WithEvents picStar3 As System.Windows.Forms.PictureBox
    Friend WithEvents picStar2 As System.Windows.Forms.PictureBox
    Friend WithEvents picLine As System.Windows.Forms.PictureBox
    Friend WithEvents tmrLine As System.Windows.Forms.Timer
    Friend WithEvents picStar4 As System.Windows.Forms.PictureBox
End Class
