Public Class frmCongratulation

    Dim b_meter As Byte 'counter 
    Dim growAmt As Byte = 8 'how much to move image

    Private Sub frmCongratulation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tmrClap.Enabled = True
        tmrClap.Interval = 100

        picClap.Image = Image.FromFile("clap.gif")
        My.Computer.Audio.Play("win.wav", AudioPlayMode.Background)


    End Sub

    Private Sub btnHighScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHighScore.Click

        Dim newHigh As New frmHighScore
        newHigh.Show()
        frmSynonym.Hide()
        Me.Hide()
    End Sub


    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        frmMainMenu.Show()
        Me.Hide()

    End Sub

    

    Private Sub tmrClap_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClap.Tick

        b_meter += 1


        If b_meter < 30 Then ' from 0 to 3 second 

            picClap.Top += growAmt ' increase gap from top ( go down )

        ElseIf b_meter > 30 Then ' after 3 to 6 second

            picClap.Top -= growAmt ' increase gap from botton ( go up )
        End If


        If b_meter = 60 Then
            b_meter = 0 'reset timer 
        End If


    End Sub

 
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub
End Class
