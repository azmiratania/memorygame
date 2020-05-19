Imports System.IO

Public Class frmSynonym
    Dim pics(,) As PictureBox 'holds pictureboxes
    Dim cells(,) As Cell 'holds cell objects consisting of info on filename and tag
    Dim firstcell, secondcell As Cell
    Dim cellcount As Byte
    Dim first_index, second_index As String
    Dim rand As Random

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r, c As Short
        'create the pictureboxes and
        'display the default image

        ReDim pics(3, 3)
        For r = 0 To UBound(pics, 1)
            For c = 0 To UBound(pics, 2)
                pics(r, c) = New PictureBox
                pics(r, c).Width = 50
                pics(r, c).Height = 50
                pics(r, c).Left = 10 + pics(r, c).Width * c
                pics(r, c).Top = 10 + pics(r, c).Height * r
                pics(r, c).Image = Image.FromFile("exit.bmp")
                pics(r, c).SizeMode = PictureBoxSizeMode.StretchImage
                pics(r, c).BorderStyle = BorderStyle.FixedSingle
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

        ReDim cells(3, 3)
        Dim strContents As String
        Dim objReader As StreamReader
        Try
            Dim i As Short
            objReader = New StreamReader("data.txt")

            Do While Not objReader.EndOfStream
                'For loop to read a pair of synonyms; x & x + 1
                'Step 2 to read the next pair
                For x As Short = 0 To 2 Step 2
                    strContents = objReader.ReadLine
                    'cell object for first column
                    cells(i, x) = New Cell
                    cells(i, x).Tag = strContents.Chars(0) 'holds number for matching purposes
                    Dim comma As Short
                    comma = strContents.IndexOf(",")
                    cells(i, x).FileName = strContents.Substring(1, comma - 1)
                    'cell object for second column
                    cells(i, x + 1) = New Cell
                    cells(i, x + 1).Tag = strContents.Chars(comma + 1) 'holds number for matching purposes
                    cells(i, x + 1).FileName = strContents.Substring(comma + 2)
                Next
                i += 1
            Loop
            objReader.Close()

            randomise() 'call sub procedure to randomise positions of cells

        Catch Ex As Exception

        End Try
    End Sub

    Private Sub randomise()
        Dim x, y, r, c As Short

        Dim lastr, lastc As Short
        lastr = UBound(cells, 1)
        lastc = UBound(cells, 2)

        Dim rowarray(15) As Short 'temp array to hold index for checking dup
        Dim colarray(15) As Short 'temp array to hold index for checking dup

        'initialise to an unused value i.e. 99
        For q As Short = 0 To 15
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
                    For t As Short = 0 To 15
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

                Loop Until (sameindex = False) And (arr_r = 15) And (arr_c = 15)
            Next y
        Next x

    End Sub

    Private Sub pics_Click(ByVal Sender As Object, ByVal e As EventArgs)
        Dim curr_row, curr_col As Short
        curr_row = CShort(Sender.tag.ToString.Chars(0).ToString)
        curr_col = CShort(Sender.tag.ToString.Chars(2).ToString)
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
        'if both words are synonym keep cells open
        If firstcell.Tag = secondcell.Tag Then
            same = True
        End If
        'if the second word is not synonym of first close both cells
        If Not same Then
            Dim f_r, f_c, s_r, s_c, comma As Short
            f_r = CShort(first_index.Chars(0).ToString)
            comma = first_index.IndexOf(",")
            f_c = CShort(first_index.Chars(comma + 1).ToString)
            s_r = CShort(second_index.Chars(0).ToString)
            comma = first_index.IndexOf(",")
            s_c = CShort(second_index.Chars(comma + 1).ToString)
            pics(f_r, f_c).Image = Image.FromFile("exit.bmp")
            pics(s_r, s_c).Image = Image.FromFile("exit.bmp")
        End If

        firstcell = Nothing
        secondcell = Nothing
        tmrCheck.Enabled = False
    End Sub
End Class