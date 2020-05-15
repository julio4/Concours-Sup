Public Class Inscription
    Private num As Integer
    Private nom As String
    Private prénom As String
    Private adresse As String
    Private codePostal As Integer
    Private ville As String
    Private age As Integer

    Public Sub New()

    End Sub
    Public Sub New(no As Integer, n As String, p As String, ad As String, cp As Integer, v As String, a As Integer)
        num = no
        nom = n
        prénom = p
        adresse = ad
        codePostal = cp
        ville = v
        age = a
    End Sub

    Public Property Num1 As Integer
        Get
            Return num
        End Get
        Set(value As Integer)
            num = value
        End Set
    End Property

    Public Property Nom1 As String
        Get
            Return nom
        End Get
        Set(value As String)
            nom = value
        End Set
    End Property

    Public Property Prénom1 As String
        Get
            Return prénom
        End Get
        Set(value As String)
            prénom = value
        End Set
    End Property

    Public Property Adresse1 As String
        Get
            Return adresse
        End Get
        Set(value As String)
            adresse = value
        End Set
    End Property

    Public Property CodePostal1 As Integer
        Get
            Return codePostal
        End Get
        Set(value As Integer)
            codePostal = value
        End Set
    End Property

    Public Property Ville1 As String
        Get
            Return ville
        End Get
        Set(value As String)
            ville = value
        End Set
    End Property

    Public Property Age1 As Integer
        Get
            Return age
        End Get
        Set(value As Integer)
            age = value
        End Set
    End Property
End Class