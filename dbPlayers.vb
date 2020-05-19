'*********************************
'  Azmira Tania          (0839408) 
'  Nur Shahirah Roslan   (0955829)
'  VISUAL BASIC PROGRAMMING  
'  ASSIGNMENT (2009/2010 S2)
'  Class:DIT/FT/1B01 
'*********************************


Imports System.Data.SqlClient

Public Class dbPlayers

    'info required to connect to sql server
    Private Const connstring As String = _
    "server = DIT-NB0839408\SQLEXPRESS;database =ST0110;" & _
    "user id = sa;password = 12345678"


    Private mConn As SqlClient.SqlConnection 'connect to db
    Private mCmd As SqlClient.SqlCommand ' execute sql statement

    Public Sub New()
        'create connection object 
        mConn = New SqlClient.SqlConnection
        mConn.ConnectionString = connstring

        'create command object
        mCmd = mConn.CreateCommand

    End Sub 'default constructor 

    Public Function AddNewRecord(ByVal newPlayer As MyPlayer) As Integer

        mCmd.CommandText = "INSERT INTO tblMyPlayers VALUES('" & _
        newPlayer.PName & "'," & newPlayer.Tries & "," & _
        newPlayer.Min & "," & newPlayer.Sec & "," & _
        newPlayer.MiliSec & ")"


        Dim rowaffected As Integer
        mConn.Open()
        rowaffected = mCmd.ExecuteNonQuery
        mConn.Close()


        Return rowaffected 'can be used for debugging ( if 1 then data has been added,if 0 then some error occured)

    End Function



    Public Function Retrieve() As MyPlayer() ' will return myPlayer array which is an object which stores all the information about the player

        Dim noOfPlayers As Short
        'retrieve number of records from tblMyPlayers
        mCmd.CommandText = "Select Count(*) From tblMyPlayers" ' ONLY COUNTS HOW MANY TUPLE THERE IS 


        mConn.Open() 'establish connection to sqp server database
        noOfPlayers = mCmd.ExecuteScalar 'execute sql statement
        mConn.Close() 'close connection to sql server db



        If noOfPlayers = 0 Then
            Return Nothing
        Else
            'retrieve all records from lblMyPlayers
            mCmd.CommandText = "Select * from tblMyPlayers" ' list all the tuples in the table
            Dim PlayersArr(noOfPlayers - 1) As MyPlayer ' noOfPlayers = 5 ---->PlayersArr( 5 - 1){0 To 4}


            Dim rdr As SqlClient.SqlDataReader
            mConn.Open()
            rdr = mCmd.ExecuteReader 'execute (mCmd.CommandText = "Select * from tblMyPlayers")



            Dim i As Short


            Do While rdr.Read ' while rdr contains data, data will be retrived if not it will stop
                PlayersArr(i) = New MyPlayer
                'retrieve value from first column in tblPlayer
                PlayersArr(i).PName = rdr.GetValue(0)
                'retrieve value from second column in tblPlayer
                PlayersArr(i).Tries = CInt(rdr.GetValue(1))
                'retrieve value from third column in tblPlayer
                PlayersArr(i).Min = CInt(rdr.GetValue(2))
                PlayersArr(i).Sec = CInt(rdr.GetValue(3))
                PlayersArr(i).MiliSec = CInt(rdr.GetValue(4))
                i += 1
            Loop

            rdr.Close() 'close reader object

            mConn.Close() 'close connection object 

            Return PlayersArr

        End If

    End Function





End Class
