Module App

    'Les variables et constantes
    Dim matièresEcrit(12) As Matière
    Dim matièresOrales(9) As Matière
    Dim matièreVide As Matière
    Dim régions() As String = {"Auvergne", "Bordelais", "Bourgogne",
    "Bretagne", "Corse", "Nord", "Normandie", "Paris", "Poitou",
    "Roussillon"}
    Dim inscriptions As ArrayList = New ArrayList()
    Dim nbInscrits As Integer = 0
    Const nbEcrits = 4
    Const nbOraux = 3

    Sub initialisation()
        Dim i As Integer = 0
        Dim j As Integer = 0
        matièreVide = New Matière()
        'Matières seulement à l'écrit
        matièresEcrit(i) = New Matière("Algorithmique", "ALG")
        i += 1
        matièresEcrit(i) = New Matière("Base de données", "BDD")
        i += 1
        matièresEcrit(i) = New Matière("Langage C", "LGC")
        i += 1
        matièresEcrit(i) = New Matière("Langage Java", "LGJ")
        i += 1
        matièresEcrit(i) = New Matière("Programmation Web", "WEB")
        i += 1
        matièresEcrit(i) = New Matière("Visual Basic .NET", "VBN")
        i += 1

        'Matières à l'écrit ET à l'oral
        matièresEcrit(i) = New Matière("Droit", "DRT")
        matièresOrales(j) = matièresEcrit(i)
        i += 1
        j += 1
        matièresEcrit(i) = New Matière("Expression", "EXP")
        matièresOrales(j) = matièresEcrit(i)
        i += 1
        j += 1
        matièresEcrit(i) = New Matière("Gestion", "GST")
        matièresOrales(j) = matièresEcrit(i)
        i += 1
        j += 1
        matièresEcrit(i) = New Matière("Mathématiques", "MAT")
        matièresOrales(j) = matièresEcrit(i)
        i += 1
        j += 1
        matièresEcrit(i) = New Matière("Réseau", "RES")
        matièresOrales(j) = matièresEcrit(i)
        i += 1
        j += 1
        matièresEcrit(i) = New Matière("Système", "SYS")
        matièresOrales(j) = matièresEcrit(i)
        j += 1

        'Matières seulement à l'oral
        matièresOrales(j) = New Matière("Anglais", "ANG")
        j += 1
        matièresOrales(j) = New Matière("Chinois", "CHN")
        j += 1
        matièresOrales(j) = New Matière("Espagnol", "ESP")

    End Sub
    Sub main()
        initialisation()
        'A ENLEVER'
        nbInscrits += 1
        inscriptions.Add(New Inscription(nbInscrits, "TE", "Hélène", "11 rue de bourges", 93160, "Noisy-Le-Grand", 18, "Paris",
                                                   {matièresEcrit(0), matièresEcrit(2), matièresEcrit(3), matièresEcrit(4)},
                                                   {matièresOrales(6), matièresOrales(7), matièresOrales(8)}, matièreVide))
        nbInscrits += 1
        inscriptions.Add(New Inscription(nbInscrits, "DOUMECHE", "Jules", "23 rue de merlan", 93130, "Noisy-Le-Sec", 18, "Auvergne",
                                                   {matièresEcrit(6), matièresEcrit(7), matièresEcrit(3), matièresEcrit(4)},
                                                   {matièresOrales(4), matièresOrales(7), matièresOrales(5)}, matièresOrales(6)))
        nbInscrits += 1
        inscriptions.Add(New Inscription(nbInscrits, "DOUMECHE", "Albert", "23 rue de merlan", 93130, "Noisy-Le-Sec", 18, "Auvergne",
                                                   {matièresEcrit(6), matièresEcrit(7), matièresEcrit(3), matièresEcrit(4)},
                                                   {matièresOrales(4), matièresOrales(7), matièresOrales(5)}, matièresOrales(6)))
        'FIN'

        Application.Run(ACCUEIL)
    End Sub

    'GET POUR LES VARIABLES ET LES CONSTANTES
    Function getNbEcrits() As Integer
        Return nbEcrits
    End Function

    Function getNbOraux() As Integer
        Return nbOraux
    End Function
    Function getRégions() As String()
        Return régions
    End Function

    Function getMatièresEcrits() As Matière()
        Return matièresEcrit
    End Function

    Function getMatièresOrales() As Matière()
        Return matièresOrales
    End Function

    Function getNumDernierEnregistrement() As Integer
        Return nbInscrits
    End Function

    Function getInscriptions() As ArrayList
        Return inscriptions
    End Function

    Function getInscription(id As Integer) As Inscription
        For i As Integer = 0 To inscriptions.Count - 1
            If (inscriptions(i).Num1 = id) Then
                Return inscriptions(i)
            End If
        Next i
    End Function

    Function getMatière(nom As String) As Matière
        For i As Integer = 0 To matièresEcrit.Length - 1
            If (matièresEcrit(i).Nom = nom) Then
                Return matièresEcrit(i)
            End If
        Next
        For i As Integer = 0 To matièresOrales.Length - 1
            If (matièresOrales(i).Nom = nom) Then
                Return matièresOrales(i)
            End If
        Next
        Return matièreVide
    End Function

    'ENREGISTREMENT DES CANDIDATS

    Sub enregistrerInscription()
        nbInscrits += 1
        Dim écrits(nbEcrits) As Matière
        For i As Integer = 0 To nbEcrits - 1
            écrits(i) = getMatière(RECAPITULATIF.Ls_écrits.Items(i).Text)
        Next i
        Dim oraux(nbOraux) As Matière
        For i As Integer = 0 To nbOraux - 1
            oraux(i) = getMatière(RECAPITULATIF.Ls_oraux.Items(i).Text)
        Next i
        inscriptions.Add(New Inscription(nbInscrits, INS_SAISIE.Nom.Text, INS_SAISIE.Prénom.Text,
                                                   INS_SAISIE.Adresse.Text, CInt(INS_SAISIE.CodePostal.Text), INS_SAISIE.Ville.Text _
                                                   , CInt(INS_SAISIE.Age.Text), RECAPITULATIF.Lb_Région_Donnée.Text, écrits, oraux,
                                                     getMatière(RECAPITULATIF.Lb_facultative_donnée.Text)))
    End Sub

    'MODIFICATION ET SUPPRESSION DES CANDIDATS

    Function IdValide(id As Integer) As Boolean
        For i As Integer = 0 To inscriptions.Count - 1
            If (inscriptions(i).Num1 = id) Then
                Return True
            End If
        Next i
        Return False
    End Function
    Sub supprimerInscription(inscription As Inscription)
        For i As Integer = 0 To inscriptions.Count - 1
            If (inscriptions(i).Equals(inscription)) Then
                inscriptions.RemoveAt(i)
                Exit For
            End If
        Next i
    End Sub

    Sub modifierInscription(ins As Inscription)
        ins.Nom1 = INS_SAISIE.Nom.Text
        ins.Prénom1 = INS_SAISIE.Prénom.Text
        ins.Adresse1 = INS_SAISIE.Adresse.Text
        ins.CodePostal1 = INS_SAISIE.CodePostal.Text
        ins.Ville1 = INS_SAISIE.Ville.Text
        ins.Age1 = CInt(INS_SAISIE.Age.Text)
        ins.Région1 = RECAPITULATIF.Lb_Région_Donnée.Text
        ins.facultatif1 = getMatière(RECAPITULATIF.Lb_facultative_donnée.Text)
        Dim écrits(nbEcrits) As Matière
        For i As Integer = 0 To nbEcrits - 1
            écrits(i) = getMatière(RECAPITULATIF.Ls_écrits.Items(i).Text)
        Next i
        Dim oraux(nbOraux) As Matière
        For i As Integer = 0 To nbOraux - 1
            oraux(i) = getMatière(RECAPITULATIF.Ls_oraux.Items(i).Text)
        Next i
        ins.écrits1 = écrits
        ins.oraux1 = oraux
    End Sub
End Module
