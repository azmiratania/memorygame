
Public Class frmSplashScreen

    Dim toggle As Byte 'animate the 4 title pictures
    Dim rnd As New Random 'animate stars in panel
    Const growAmt As Byte = 4 'animate line (width + left)
    Dim b_meter As Short 'counter for line
    Dim loadTime As Short 'counter for splashscreen (splashscreen will stay for 5 seconds) 

    Private Sub picGirl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picGirl.Click

        Me.Hide()
        My.Computer.Audio.Stop()
        frmMainMenu.Show()

    End Sub  'to skip splash screen
    Private Sub frmSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play("Starlight.wav", AudioPlayMode.BackgroundLoop)

        'picGirl

        picGirl.Image = Image.FromFile("girl.gif")


        'picTitle + tmrTitle ( refer to tmrTitle_Tick -> toggle)

        picTitle.SizeMode = PictureBoxSizeMode.StretchImage
        tmrTitle.Interval = 200
        tmrTitle.Enabled = True

        'picStar + tmrStars

        picStar1.Image = Image.FromFile("star.png")
        picStar1.SizeMode = PictureBoxSizeMode.StretchImage
        picStar2.Image = Image.FromFile("starred.png")
        picStar2.SizeMode = PictureBoxSizeMode.StretchImage
        picStar3.Image = Image.FromFile("star.png")
        picStar3.SizeMode = PictureBoxSizeMode.StretchImage
        picStar4.Image = Image.FromFile("starred.png")
        picStar4.SizeMode = PictureBoxSizeMode.StretchImage

        tmrStars.Enabled = True
        tmrStars.Interval = 500

        'picLine + tmrLine

        picLine.Image = Image.FromFile("line.png")
        picLine.SizeMode = PictureBoxSizeMode.StretchImage

        tmrLine.Enabled = True
        tmrLine.Interval = 50 '(50 miliseconds!!) 


    End Sub

    Private Sub tmrTitle_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTitle.Tick

        toggle += 1
        picTitle.Image = Image.FromFile("title" & toggle & ".png") 'title1,title2,title3,title4


        If toggle = 4 Then
            toggle = 0 'reset timer 
        End If




    End Sub

    Private Sub tmrStars_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStars.Tick

        'to animate star1
        picStar1.Left = rnd.Next(0, Panel1.Width - picStar1.Width + 1)
        picStar1.Top = rnd.Next(0, Panel1.Height - picStar1.Height + 1)

        'to animate star2
        picStar2.Left = rnd.Next(0, Panel1.Width - picStar1.Width + 1)
        picStar2.Top = rnd.Next(0, Panel1.Height - picStar1.Height + 1)

        'to animate star3
        picStar3.Left = rnd.Next(0, Panel1.Width - picStar1.Width + 1)
        picStar3.Top = rnd.Next(0, Panel1.Height - picStar1.Height + 1)

        'to animate star4
        picStar4.Left = rnd.Next(0, Panel1.Width - picStar1.Width + 1)
        picStar4.Top = rnd.Next(0, Panel1.Height - picStar1.Height + 1)




        'dtermine how long splashscreen stays before main menu (5 seconds)

        loadTime += 1

        If loadTime = (10 * 2) Then ' after 10 seconds load main menu 

            frmMainMenu.Show()
            Me.Hide()
            My.Computer.Audio.Stop()

        End If

    End Sub  'loading time is coded here

    Private Sub tmrLine_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLine.Tick

        'codes to animate line below title
        'advanced coding because line appears to shrinked from both sides
        '0000000000
        '__000000


        b_meter += 1


        If b_meter < 60 Then   'shrink line for 3 seconds
            picLine.Width -= growAmt 'compress line from RIGHT side
            picLine.Left += (growAmt / 2) 'compress line from LEFT side
        ElseIf b_meter > 60 Then 'expand line 60 times
            picLine.Width += growAmt
            picLine.Left -= (growAmt / 2)
        End If


        If b_meter = 120 Then ' when line is back to original
            b_meter = 0 'reset timer 
        End If



    End Sub


End Class
