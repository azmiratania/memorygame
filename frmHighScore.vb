'*********************************
'  Azmira Tania          (0839408) 
'  Nur Shahirah Roslan   (0955829)
'  VISUAL BASIC PROGRAMMING  
'  ASSIGNMENT (2009/2010 S2)
'  Class:DIT/FT/1B01 
'*********************************


Public Class frmHighScore

    Dim mydbPlayers As New dbPlayers
    Dim PlayersArr() As MyPlayer



    Private Sub frmHighScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        PlayersArr = mydbPlayers.Retrieve 'execute method to retrieve all Players record

        'clear lables
        lblPName.Text = ""
        lblTries.Text = ""
        lblTotTime.Text = ""
        lblHighestScore.Text = ""

        Dim hScore As Integer = 999999 'to compare for highest score
        Dim hName As String = ""



        For i As Integer = 0 To UBound(PlayersArr) ' reading the data from PlayerArr ()

            If hScore > CInt(PlayersArr(i).Tries) Then
                hScore = CInt(PlayersArr(i).Tries) 'to determine highest score & assign it to hScore
                hName = PlayersArr(i).PName
            End If

            lblPName.Text &= PlayersArr(i).PName & vbCrLf
            lblTries.Text &= PlayersArr(i).Tries & vbCrLf
            lblTotTime.Text &= PlayersArr(i).Min & " : " & PlayersArr(i).Sec & " : " & PlayersArr(i).MiliSec & vbCrLf
        Next

        lblHighestScore.Text = hName & " with only " & hScore & " tries!"



    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        frmMainMenu.Show()
        Me.Hide()

    End Sub
End Class