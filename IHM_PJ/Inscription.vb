
<Serializable()>
Public Class Inscription

    Private numIns As Integer
    Private nomIns As String
    Private prénomIns As String
    Private adresseIns As String
    Private codePostalIns As Integer
    Private villeIns As String
    Private ageIns As Integer
    Private régionIns As String
    Private écritsIns() As Matière
    Private orauxIns() As Matière
    Private facultatifIns As Matière

    Public Sub New()

    End Sub
    Public Sub New(num As Integer, nom As String, prénom As String, adresse As String,
            codePostal As Integer, ville As String, age As Integer, région As String,
                   écrits As Matière(), oraux As Matière(), facultatif As Matière)
        numIns = num
        nomIns = nom
        prénomIns = prénom
        adresseIns = adresse
        codePostalIns = codePostal
        villeIns = ville
        ageIns = age
        régionIns = région
        écritsIns = écrits
        orauxIns = oraux
        facultatifIns = facultatif
    End Sub
    Public Overrides Function ToString() As String
        Return nomIns & " " & prénomIns & " " & numIns
    End Function

    Public Function contientEcrit(mat As Matière) As Boolean
        For i As Integer = 0 To écritsIns.Count - 1
            If écritsIns(i).ToString() = mat.ToString() Then
                Return True
            End If
        Next i
        Return False
    End Function

    Public Function contientOral(mat As Matière) As Boolean
        For i As Integer = 0 To orauxIns.Count - 1
            If orauxIns(i).ToString() = mat.ToString() Then
                Return True
            End If
        Next i
        Return False
    End Function
    Public Function contient(mat As Matière) As Boolean
        Return facultatifIns.ToString() = mat.ToString() Or contientEcrit(mat) Or contientOral(mat)
    End Function

    Public Property Num As Integer
        Get
            Return numIns
        End Get
        Set(value As Integer)
            numIns = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return nomIns
        End Get
        Set(value As String)
            nomIns = value
        End Set
    End Property

    Public Property Prénom As String
        Get
            Return prénomIns
        End Get
        Set(value As String)
            prénomIns = value
        End Set
    End Property

    Public Property Adresse As String
        Get
            Return adresseIns
        End Get
        Set(value As String)
            adresseIns = value
        End Set
    End Property

    Public Property CodePostal As Integer
        Get
            Return codePostalIns
        End Get
        Set(value As Integer)
            codePostalIns = value
        End Set
    End Property

    Public Property Ville As String
        Get
            Return villeIns
        End Get
        Set(value As String)
            villeIns = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return ageIns
        End Get
        Set(value As Integer)
            ageIns = value
        End Set
    End Property

    Public Property Région As String
        Get
            Return régionIns
        End Get
        Set(value As String)
            régionIns = value
        End Set
    End Property

    Public Property Ecrits As Matière()
        Get
            Return écritsIns
        End Get
        Set(value As Matière())
            écritsIns = value
        End Set
    End Property

    Public Property Oraux As Matière()
        Get
            Return orauxIns
        End Get
        Set(value As Matière())
            orauxIns = value
        End Set
    End Property

    Public Property Facultatif As Matière
        Get
            Return facultatifIns
        End Get
        Set(value As Matière)
            facultatifIns = value
        End Set
    End Property
End Class