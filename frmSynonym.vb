Imports System.IO

Public Class frmSynonym
    Dim pics(,) As PictureBox 'holds pictureboxes
    Dim cells(,) As Cell 'holds cell objects consisting of info on filename and tag
    Dim firstcell, secondcell As Cell 'needed for mathcing purposes
    Dim cellcount As Byte 'counter --> calculates how many cells are being open
    Dim first_index, second_index As String ' index of cell
    Dim rand As Random 'used in private sub 'randomise'
    Dim score As Byte = 0 'takes note of number of matches to denote when to end game
    Dim tries As Byte = 0 'takes not of number of tries player is allowed
    Dim min, sec, msec As Integer ' time
    Dim dimention As Byte = 5 ' IMPORTANT : ARRAY SIZE IS DECLARED HERE! 
    Dim rndDim As Byte = ((dimention + 1) * (dimention + 1)) - 1 ' set dimension in randomise sub method
    Dim totscore As Byte = ((dimention + 1) * (dimention + 1)) / 2 'in other words 18 for this game
    Dim playerName As String
    Dim myDbPlayer As New dbPlayers '--> ADVANCE FEATURE --> IMPORTANT : NEEDED TO UPDATE DASEBASE INFORMATION !
    Dim gameTime As Integer ' ---> ADAVANCE FEATURE ---> • time limit.( 10 minutes)
    Dim gameMode As Integer  ' ADVANCE FEATURE ---> Maximum number of attempts allowed within time limit.
    Dim chooseLevel As Integer ' user input --> allow user to choose they level they wish to play
    Dim modeInput As String 'user's input for choose level
    Dim cellSize As Byte = 65 'declare size of cell (default)
    Dim toggle As Byte 'counter
    Dim appear As Byte = 0 'counter 


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        playerName = InputBox("Please enter your name.", "Memory Game")

        If playerName = "" Then
            playerName = "Anonymous" ' player can play as Anonymous
            MessageBox.Show("You are playing the game as Anonymous!", "Information", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If

        'promt user to choose difficulty level
        modeInput = InputBox("Choose a level." & vbCrLf & _
                                       "0 : Beginner Mode" & vbCrLf & _
                                       "1 : Intermediate Mode" & vbCrLf & _
                                       "2 : Expert Mode" & vbCrLf & _
                                       "3 : Master Mode " & vbCrLf & _
                                       "4 : Game God ", "Choose level")


        If IsNumeric(modeInput) Then 'no alpabets allowed,only numeric values!
            If CInt(modeInput) >= 0 And CInt(modeInput) <= 4 Then 'checks if user input is between 0 & 4
                chooseLevel = CInt(modeInput) ' assigns user input to chooseLevel
            End If
        Else 'defaults back to beginner mode 
            MessageBox.Show("This game will run in the beginner mode by default.", "Default Mode (Beginner Mode)", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' match chooseLevel with gameMode
        Select Case chooseLevel
            Case 0
                gameMode = 200
            Case 1
                gameMode = 150
            Case 2
                gameMode = 100
            Case 3
                gameMode = 50
            Case 4
                gameMode = 36
            Case Else
                gameMode = 200
        End Select





        Dim r, c As Short
        'create the pictureboxes and
        'display the default image

        ReDim pics(dimention, dimention) 'global dimention is 5
        For r = 0 To UBound(pics, 1)
            For c = 0 To UBound(pics, 2)
                pics(r, c) = New PictureBox
                pics(r, c).Width = cellSize 'global cellSize is 65
                pics(r, c).Height = cellSize
                pics(r, c).Left = 75 + pics(r, c).Width * c
                pics(r, c).Top = 35 + pics(r, c).Height * r
                pics(r, c).Image = Image.FromFile("exit.bmp")
                pics(r, c).SizeMode = PictureBoxSizeMode.StretchImage
                pics(r, c).BorderStyle = BorderStyle.Fixed3D
                pics(r, c).Tag = r & "," & c
                AddHandler pics(r, c).Click, AddressOf pics_Click
                Me.Controls.Add(pics(r, c))
            Next
        Next

        LoadArray() 'load the data into the cells array

        tmrCheck.Interval = 500
        tmrCheck.Enabled = False



    End Sub

    Private Sub frmSynonym_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.F2 Then

            Dim reply As DialogResult

            reply = MessageBox.Show("Are you sure you want to play a new game?", _
                                     "Confirm New Game", _
                                     MessageBoxButtons.YesNo, _
                                     MessageBoxIcon.Question)

            If reply = Windows.Forms.DialogResult.Yes Then

                Me.Hide()

                Dim startOver As New frmSynonym

                startOver.Show()

            End If


        End If


    End Sub


    
    Private Sub LoadArray()
        'This method reads data from the source and store them in
        'a 2-Dimensional array.
        'Reads the data from a text file.

        ReDim cells(dimention, dimention)
        Dim strContents As String
        Dim objReader As StreamReader
        'Try
        Dim i As Short
        objReader = New StreamReader("data.txt")

        Do While Not objReader.EndOfStream
            'For loop to read a pair of synonyms; x & x + 1
            'Step 2 to read the next pair

            '(dimention -1 ) -- > always 1 less than index ( 0 - 4 ) 
            'Step 2 because two mathching cells checked at once

            For x As Short = 0 To (dimention - 1) Step 2
                strContents = objReader.ReadLine
                'cell object for first column
                cells(i, x) = New Cell
                cells(i, x).Tag = strContents.Substring(0, 3) 'holds number for matching purposes 
                '( 011 -- therefore hold 3 characters !!)

                Dim comma As Short
                comma = strContents.IndexOf(",")

                'substring (starting index  ,  no of characters to be taken) 
                '011enormous.bmp,  
                cells(i, x).FileName = strContents.Substring(3, comma - 3)




                'cell object for second column
                cells(i, x + 1) = New Cell
                cells(i, x + 1).Tag = strContents.Substring(comma + 1, 3)

                'holds number for matching purposes --> .bmp,012 so we need 012 there (comma + 1,3)

                cells(i, x + 1).FileName = strContents.Substring(comma + 4) ' comma + 1 + 3
            Next
            i += 1
        Loop
        objReader.Close()

        randomise() 'call sub procedure to randomise positions of cells

        'Catch Ex As Exception

        'End Try
    End Sub

    Private Sub randomise()
        Dim x, y, r, c As Short

        Dim lastr, lastc As Short
        lastr = UBound(cells, 1)
        lastc = UBound(cells, 2)

        Dim rowarray(rndDim) As Short 'temp array to hold index for checking dup
        Dim colarray(rndDim) As Short 'temp array to hold index for checking dup

        'initialise to an unused value i.e. 99
        For q As Short = 0 To rndDim
            rowarray(q) = 99
            colarray(q) = 99
        Next

        Dim tempcells(lastr, lastc) As Cell
        'copy all cell objects into a temporary array called newcells
        'because array cells is going to store the randomly assigned
        'cells
        For x = 0 To UBound(cells, 1)
            For y = 0 To UBound(cells, 2)
                tempcells(x, y) = cells(x, y)
                cells(x, y) = New Cell
            Next
        Next

        'randomly assign cell object to array
        Dim startvalue, min, sec As Integer
        sec = Now.Second
        min = Now.Minute
        startvalue = min + sec

        rand = New Random(startvalue)

        Dim arr_r, arr_c As Short
        For x = 0 To lastr
            For y = 0 To lastc
                Dim sameindex As Boolean
                arr_r = 0
                arr_c = 0
                Do 'repeat this loop until unique value found
                    r = rand.Next(0, lastr + 1)
                    c = rand.Next(0, lastc + 1)
                    Dim tmpcell As Cell
                    tmpcell = tempcells(r, c)

                    sameindex = False
                    For t As Short = 0 To rndDim
                        If (r = rowarray(t)) And (c = colarray(t)) Then
                            sameindex = True 'if same indexes found
                        End If
                    Next
                    'if indexes are unique do the following:
                    'i. store row & col indexes in temp arrays,
                    'ii. store new cell (rep a word) in cells array,
                    'iii. increment indexes of temp arrays
                    If sameindex = False Then 'if indexes are unique
                        rowarray(arr_r) = r
                        colarray(arr_c) = c
                        cells(x, y) = tmpcell
                        arr_r += 1
                        arr_c += 1
                    End If

                Loop Until (sameindex = False) And (arr_r = rndDim) And (arr_c = rndDim)
            Next y
        Next x

    End Sub

    Private Sub pics_Click(ByVal Sender As Object, ByVal e As EventArgs)
        Dim curr_row, curr_col As Short
        curr_row = CShort(Sender.tag.ToString.Substring(0, 1).ToString)
        curr_col = CShort(Sender.tag.ToString.Substring(2, 1).ToString)
        Sender.image = Image.FromFile(cells(curr_row, curr_col).FileName)


        If cellcount = 0 Then 'first picturebox clicked
            firstcell = cells(curr_row, curr_col)
            first_index = pics(curr_row, curr_col).Tag
        Else 'second picturebox clicked
            secondcell = cells(curr_row, curr_col)
            second_index = pics(curr_row, curr_col).Tag


            '# VERY IMPORTANT because it makes sure when cliked twice on same cell, it doesn't stay open.

            If firstcell.Tag = secondcell.Tag Then
                cellcount -= 1 ' to prevent cellcount from increasing when clicked on the same cell
            Else
                tmrCheck.Enabled = True
            End If

        End If
        cellcount += 1
        If cellcount > 1 Then
            cellcount = 0
        End If



    End Sub

    Private Sub tmrCheck_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrCheck.Tick

        '#codes to match the cells + increase score ( sound is played when same )

        'Dim r, c As Short
        Dim same As Boolean

        tries += 1 'counter & also how many ties user tries 


        Dim tagnum1, tagnum2 As Byte ' # NOT TEACHER'S CODE!DONE BY ME !!!! ( hold tag for mathcing purposes)

        tagnum1 = CByte(firstcell.Tag)
        tagnum2 = CByte(secondcell.Tag)


        If tagnum1 = tagnum2 + 1 Then 'matching 011 with 012 or 051 with 052 etc.....
            same = True
            My.Computer.Audio.Play("alert.wav", AudioPlayMode.Background) 'sound if played 
            score += 1 'match found,increment score by 1
            lblScore.Text = "Score : " & score & " out of " & totscore


            picMatch.Image = Image.FromFile("yes.gif") 'ADVANCE FEATURE --> yes animation is displayed 
            picMatch.SizeMode = PictureBoxSizeMode.StretchImage

            tmrMatch.Interval = 100
            tmrMatch.Enabled = True

        ElseIf tagnum1 = tagnum2 - 1 Then 'matching 012 with 011 or 052 with 051 etc.....

            same = True
            My.Computer.Audio.Play("alert.wav", AudioPlayMode.Background)
            score += 1
            lblScore.Text = "Score : " & score & " out of " & totscore

            picMatch.Image = Image.FromFile("yes.gif") 'ADVANCE FEATURE --> yes animation is displayed
            picMatch.SizeMode = PictureBoxSizeMode.StretchImage

            tmrMatch.Interval = 100
            tmrMatch.Enabled = True


        ElseIf tagnum1 = tagnum2 Then '011 = 011 (clicking on same image) - will NOT increase tries.

            same = True
            tries = tries - 1

        End If


        lblTries.Text = "Tries left : " & (gameMode - tries)

        '# codes for limiting the number of tries the player is allowed ( game over form)

        If tries = 1 Then 'if tries = 1 --> GAME STARTS !
            Timer1.Start()
            Timer1.Interval = 10 '10 miliseconds
            msec = 0
            sec = 0
            min = 0

            gameTime = 0


        ElseIf score = totscore Then ' when user completes game 

            Timer1.Stop()

            'ADVANCE FEATURE !!! 
            Dim tmpPlayer As New MyPlayer
            tmpPlayer.PName = playerName
            tmpPlayer.Tries = CInt(tries)
            tmpPlayer.Min = min
            tmpPlayer.Sec = sec
            tmpPlayer.MiliSec = msec


            Dim rowaffected As Integer ' advance feature - used db to store high scores
            rowaffected = myDbPlayer.AddNewRecord(tmpPlayer)

            frmCongratulation.Show() ' A CONGRATULATION FORM WILL BE DISPLAYED! 
            Me.Hide()

        ElseIf tries = gameMode Then 'advance feature -- > when player reaches maximum no.of tries,timer stops & fmrTimeUp is shown 

            Timer1.Stop()
            frmTimeUp.Show()
            Me.Hide()


        End If



        'if the second word is not synonym of first close both cells
        If Not same Then
            Dim f_r, f_c, s_r, s_c, comma As Short
            f_r = CShort(first_index.Substring(0, 2).ToString)
            comma = first_index.IndexOf(",")
            f_c = CShort(first_index.Substring(comma + 1).ToString)
            s_r = CShort(second_index.Substring(0, 2).ToString)
            comma = first_index.IndexOf(",")
            s_c = CShort(second_index.Substring(comma + 1).ToString)
            pics(f_r, f_c).Image = Image.FromFile("exit.bmp")
            pics(s_r, s_c).Image = Image.FromFile("exit.bmp")


            picMatch.Image = Image.FromFile("no.gif") ' a no animation is diplayed when cells don't match 
            picMatch.SizeMode = PictureBoxSizeMode.StretchImage

            tmrMatch.Interval = 100
            tmrMatch.Enabled = True





        End If

        firstcell = Nothing
        secondcell = Nothing
        tmrCheck.Enabled = False

    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmMainMenu.Show()
        Me.Hide()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'This sub - method contains codes to update how long the game is being played.

        If msec = 100 Then ' miliseconds goes from 0 to 99 then second increases
            sec = sec + 1
            msec = 0
        End If

        If sec = 60 Then 'second goes from 0 to 59 then minutes increase
            min = min + 1
            sec = 0
        End If



        lblTime.Text = "Time : " & min & " : " & sec & " : " & msec

        msec += 1

        gameTime += 1

        '#codes to allow user to play for 10 minutes !
        If gameTime > (10 * 60 * 100) Then ' allow the user to play for 10 minutes ( 10 * 60 * 100 )

            Timer1.Stop()
            frmTimeUp.Show()
            Me.Hide()
        End If



    End Sub

    Private Sub tmrMatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMatch.Tick

        'This sub method (timer) to control the yes + no animation.

        picMatch.Visible = True 'picMatch is visible for 1.5 second 
        appear += 1


        If appear >= 15 Then 'after 1.5 second 
            picMatch.Visible = False
            tmrMatch.Enabled = False
            appear = 0
        End If


    End Sub


    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click

        'This sub method allows user to play new game without closing the application. (ADVANCE FEATURE)

        Dim reply As DialogResult

        reply = MessageBox.Show("Are you sure you want to play a new game?", _
                                 "Confirm New Game", _
                                 MessageBoxButtons.YesNo, _
                                 MessageBoxIcon.Question)

        If reply = Windows.Forms.DialogResult.Yes Then

            Me.Hide()

            Dim startOver As New frmSynonym

            startOver.Show()

        End If


       

    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click

        frmMainMenu.Show()
        Me.Hide()

    End Sub


    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click

        'This sub method allows user to play new game without closing the application. (ADVANCE FEATURE)

        Dim reply As DialogResult

        reply = MessageBox.Show("Are you sure you want to play a new game?", _
                                 "Confirm New Game", _
                                 MessageBoxButtons.YesNo, _
                                 MessageBoxIcon.Question)

        If reply = Windows.Forms.DialogResult.Yes Then

            Me.Hide()

            Dim startOver As New frmSynonym

            startOver.Show()

        End If


    End Sub


    Private Sub HighScoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighScoreToolStripMenuItem.Click

        Dim newHighScore As New frmHighScore
        newHighScore.Show()
        Me.Hide()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Application.Exit()

    End Sub

    Private Sub AboutMakeAMatchGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMakeAMatchGameToolStripMenuItem.Click

        frmAbout.Show()
        Me.Hide()

    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click

        frmInstructions.Show()
        Me.Hide()


    End Sub
End Class
