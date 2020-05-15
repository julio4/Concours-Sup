Public Class Matière
    Private libellé As String
    Private code As String

    Public Sub New(dés As String, c As String)
        libellé = dés
        code = c
    End Sub

    Public Property Nom As String
        Get
            Return libellé
        End Get
        Set(value As String)
            libellé = value
        End Set
    End Property
End Class
