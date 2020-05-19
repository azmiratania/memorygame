'*********************************
'  Azmira Tania          (0839408) 
'  Nur Shahirah Roslan   (0955829)
'  VISUAL BASIC PROGRAMMING  
'  ASSIGNMENT (2009/2010 S2)
'  Class:DIT/FT/1B01 
'*********************************


Public Class frmTimeUp

    Const growAmt As Byte = 1 'to animate the bomb
    Dim b_meter As Short 'counter


    Private Sub frmTimeUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        picBomb.Image = Image.FromFile("bomb.png")
        picBomb.SizeMode = PictureBoxSizeMode.StretchImage

        picBomb.Height = 10
        picBomb.Width = 10



        tmrIncrease.Enabled = True
        tmrIncrease.Interval = 40

        My.Computer.Audio.Play("ticktock.wav", AudioPlayMode.Background)

        'counter runs (1000 / interval) =  number of times then timer ticks !!!



    End Sub

    Private Sub tmrIncrease_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrIncrease.Tick

        b_meter += 1

        picBomb.Height += growAmt 'increase the picBomb height by growAmt
        picBomb.Width += growAmt   'increase the picBomb width by growAmt



        If b_meter > (10 * 10) Then 'after 10 seconds
            lblGameOver.Text = "Game Over!"
        End If

        If b_meter = 145 Then ' after 14.5 seconds 
            Me.BackColor = Color.Red
            My.Computer.Audio.Play("boom.wav", AudioPlayMode.Background) 'a boom sound will play


        End If


        If b_meter > 150 Then ' after 15 seconds 

            tmrIncrease.Enabled = False
            Me.Hide()
            frmMainMenu.Show()
        End If



    End Sub
End Class