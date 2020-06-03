<Serializable()>
Public Class Matière
    Private libelléMat As String
    Private codeMat As String

    Public Sub New()
        libelléMat = "NON"
    End Sub
    Public Sub New(libellé As String, code As String)
        libelléMat = libellé
        codeMat = code
    End Sub

    Public Overrides Function ToString() As String
        Return libelléMat
    End Function

    Public Property Libellé As String
        Get
            Return libelléMat
        End Get
        Set(value As String)
            libelléMat = value
        End Set
    End Property

    Public Property Code As String
        Get
            Return codeMat
        End Get
        Set(value As String)
            codeMat = value
        End Set
    End Property
End Class
