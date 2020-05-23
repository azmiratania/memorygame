Public Class frmInstructions

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmMainMenu.Show()
        Me.Hide()
    End Sub
    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        frmMainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub btnTrainingMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrainingMode.Click

        Dim startTrain As New frmTrainMode
        startTrain.Show()
        Me.Hide()

    End Sub
End Class
