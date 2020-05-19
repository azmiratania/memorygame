'*********************************
'  Azmira Tania          (0839408) 
'  Nur Shahirah Roslan   (0955829)
'  VISUAL BASIC PROGRAMMING  
'  ASSIGNMENT (2009/2010 S2)
'  Class:DIT/FT/1B01 
'*********************************

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