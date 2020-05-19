'*********************************
'  Azmira Tania          (0839408) 
'  Nur Shahirah Roslan   (0955829)
'  VISUAL BASIC PROGRAMMING  
'  ASSIGNMENT (2009/2010 S2)
'  Class:DIT/FT/1B01 
'*********************************


Public Class MyPlayer


    Private mPName As String
    Private mTries As Integer
    Private mMin As Integer
    Private mSec As Integer
    Private mMiliSec As Integer

    Property PName() As String
        Get
            Return mPName
        End Get
        Set(ByVal Value As String)
            mPName = Value
        End Set
    End Property

    Property Tries() As Integer
        Get
            Return mTries
        End Get
        Set(ByVal Value As Integer)
            mTries = Value
        End Set
    End Property

    Property Min() As Integer
        Get
            Return mMin
        End Get
        Set(ByVal value As Integer)
            mMin = value
        End Set
    End Property

    Property Sec() As Integer
        Get
            Return mSec
        End Get
        Set(ByVal value As Integer)
            mSec = value
        End Set
    End Property

    Property MiliSec() As Integer
        Get
            Return mMiliSec
        End Get
        Set(ByVal value As Integer)
            mMiliSec = value
        End Set
    End Property

End Class