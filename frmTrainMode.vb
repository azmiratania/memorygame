Imports System.IO

Public Class frmTrainMode
    Dim pics(,) As PictureBox 'holds pictureboxes
    Dim cells(,) As Cell 'holds cell objects consisting of info on filename and tag
    Dim firstcell, secondcell As Cell
    Dim cellcount As Byte
    Dim first_index, second_index As String
    Dim rand As Random
    Dim score As Byte = 0
    Dim tries As Byte = 0
    Dim min, sec, msec As Integer
    Dim dimention As Byte = 5
    Dim totscore As Byte = ((dimention + 1) * (dimention + 1)) / 2
    Dim playerName As String
    Dim myDbPlayer As New dbPlayers
    Dim gameTime As Integer
    Dim cellSize As Byte = 60


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim r, c As Short
        'create the pictureboxes and
        'display the default image

        ReDim pics(dimention, dimention)
        For r = 0 To UBound(pics, 1)
            For c = 0 To UBound(pics, 2)
                pics(r, c) = New PictureBox
                pics(r, c).Width = cellSize
                pics(r, c).Height = cellSize
                pics(r, c).Left = 100 + pics(r, c).Width * c
                pics(r, c).Top = 10 + pics(r, c).Height * r
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
            For x As Short = 0 To (dimention - 1) Step 2
                strContents = objReader.ReadLine
                'cell object for first column
                cells(i, x) = New Cell
                cells(i, x).Tag = strContents.Substring(0, 3) 'holds number for matching purposes
                Dim comma As Short
                comma = strContents.IndexOf(",")
                cells(i, x).FileName = strContents.Substring(3, comma - 3)
                'cell object for second column
                cells(i, x + 1) = New Cell
                cells(i, x + 1).Tag = strContents.Substring(comma + 1, 3) 'holds number for matching purposes
                cells(i, x + 1).FileName = strContents.Substring(comma + 4)
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

        Dim rowarray(35) As Short 'temp array to hold index for checking dup
        Dim colarray(35) As Short 'temp array to hold index for checking dup

        'initialise to an unused value i.e. 99
        For q As Short = 0 To 35
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
                    For t As Short = 0 To 35
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

                Loop Until (sameindex = False) And (arr_r = 35) And (arr_c = 35)
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
            tmrCheck.Enabled = True
        End If
        cellcount += 1
        If cellcount > 1 Then
            cellcount = 0
        End If



    End Sub

    Private Sub tmrCheck_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrCheck.Tick
        'Dim r, c As Short
        Dim same As Boolean

        tries += 1
        lblTries.Text = "Tries : " & tries



        Dim tagnum1, tagnum2 As Byte

        tagnum1 = CByte(firstcell.Tag)
        tagnum2 = CByte(secondcell.Tag)


        If tagnum1 = tagnum2 + 1 Then
            same = True
            My.Computer.Audio.Play("alert.wav", AudioPlayMode.Background)
            score += 1
            lblScore.Text = "Score : " & score & " out of " & totscore

        ElseIf tagnum1 = tagnum2 - 1 Then

            same = True
            My.Computer.Audio.Play("alert.wav", AudioPlayMode.Background)
            score += 1
            lblScore.Text = "Score : " & score & " out of " & totscore

        End If


        If tries = 1 Then
            Timer1.Start()
            Timer1.Interval = 10
            msec = 0
            sec = 0
            min = 0

            gameTime = 0


        ElseIf score = totscore Then

            Timer1.Stop()


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
        End If

        firstcell = Nothing
        secondcell = Nothing
        tmrCheck.Enabled = False
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click

        frmMainMenu.Show()
        Me.Hide()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If msec = 100 Then
            sec = sec + 1
            msec = 0
        End If

        If sec = 60 Then
            min = min + 1
            sec = 0
        End If



        lblTime.Text = "Time : " & min & " : " & sec & " : " & msec

        msec = msec + 1

    


    End Sub

    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click

        Me.Hide()
        Dim startOver As New frmSynonym
        startOver.Show()


    End Sub
End Class
