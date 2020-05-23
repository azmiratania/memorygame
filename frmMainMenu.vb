Public Class frmMainMenu

    Dim volume As Byte = 1

    Private Sub btnStartGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartGame.Click


        My.Computer.Audio.Stop()
        Dim startOver As New frmSynonym
        startOver.Show()
        Me.Hide()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub btnInstruction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstruction.Click

        frmInstructions.Show()
        Me.Hide()

    End Sub

    Private Sub btnHighScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHighScores.Click

        Dim newHigh As New frmHighScore
        newHigh.Show()

        Me.Hide()

    End Sub

    Private Sub btnTrainMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrainMode.Click

        Dim newTrainMode As New frmTrainMode
        newTrainMode.Show()

        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub


    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play("Starlight.wav", AudioPlayMode.BackgroundLoop)
        picVolume.Image = Image.FromFile("mute.png")
        picVolume.SizeMode = PictureBoxSizeMode.StretchImage



    End Sub

    Private Sub picMute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picVolume.Click

        If volume = 1 Then ' when music is playing 
            My.Computer.Audio.Stop() 'music stops
            volume = 0 ' the value of volume is 0 
            picVolume.Image = Image.FromFile("unmute.png")
            picVolume.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf volume = 0 Then ' music is not playing
            My.Computer.Audio.Play("Starlight.wav", AudioPlayMode.BackgroundLoop) 'music will start to play
            volume = 1
            picVolume.Image = Image.FromFile("mute.png")
            picVolume.SizeMode = PictureBoxSizeMode.StretchImage
        End If


    End Sub
End Class
