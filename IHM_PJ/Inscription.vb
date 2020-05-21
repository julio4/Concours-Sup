Public Class Inscription
    Private num As Integer
    Private nom As String
    Private prénom As String
    Private adresse As String
    Private codePostal As Integer
    Private ville As String
    Private age As Integer
    Private région As String
    Private écrits() As Matière
    Private oraux() As Matière
    Private facultatif As Matière

    Public Sub New()

    End Sub
    Public Sub New(no As Integer, n As String, p As String, ad As String, cp As Integer, v As String, a As Integer, r As String, éc As Matière(), o As Matière(), fac As Matière)
        num = no
        nom = n
        prénom = p
        adresse = ad
        codePostal = cp
        ville = v
        age = a
        région = r
        écrits = éc
        oraux = o
        facultatif = fac
    End Sub
    Public Overrides Function ToString() As String
        Return nom & " " & prénom & " " & num
    End Function
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

    Public Property Région1 As String
        Get
            Return région
        End Get
        Set(value As String)
            région = value
        End Set
    End Property

    Public Property écrits1 As Matière()
        Get
            Return écrits
        End Get
        Set(value As Matière())
            écrits = value
        End Set
    End Property

    Public Property oraux1 As Matière()
        Get
            Return oraux
        End Get
        Set(value As Matière())
            oraux = value
        End Set
    End Property

    Public Property facultatif1 As Matière
        Get
            Return facultatif
        End Get
        Set(value As Matière)
            facultatif = value
        End Set
    End Property
End Class