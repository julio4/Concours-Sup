''' <summary>
''' Classe Matière
''' Hélène TE, Jules DOUMECHE, 2020
''' </summary>
''' 
<Serializable()>
Public Class Matière
    Private libelléMat As String
    Private codeMat As String

    'Constructeur par défaut: matière vide (pour matière facultative)
    Public Sub New()
        libelléMat = "NON"
    End Sub

    'Constructeur: libellé pour le libellé de la matière et son code
    Public Sub New(libellé As String, code As String)
        libelléMat = libellé
        codeMat = code
    End Sub

    'Retourne le libellé de la matière
    Public Overrides Function ToString() As String
        Return libelléMat
    End Function

    'Get et Set pour les attributs
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
