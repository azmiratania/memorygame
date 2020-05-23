Public Class Cell

    Private mFileName As String
    Private mTag As String
    Private mStatus As Boolean

    Public Property FileName() As String
        Get
            Return mFileName
        End Get
        Set(ByVal value As String)
            mFileName = value
        End Set
    End Property

    Public Property Tag() As String
        Get
            Return mTag
        End Get
        Set(ByVal value As String)
            mTag = value
        End Set
    End Property

    Public Property Status() As Boolean
        Get
            Return mStatus
        End Get
        Set(ByVal value As Boolean)
            mStatus = value
        End Set
    End Property

End Class
