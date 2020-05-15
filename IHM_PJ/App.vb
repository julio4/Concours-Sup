Module App
    Dim matièresEcrit(12) As Matière
    Dim matièresOral(9) As Matière
    Dim régions() As String = {"Auvergne", "Bordelais", "Bourgogne",
    "Bretagne", "Corse", "Nord", "Normandie", "Paris", "Poitou",
    "Roussillon"}

    Sub initialisation()
        Dim i As Integer = 0
        Dim j As Integer = 0

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
        matièresOral(j) = matièresEcrit(i)
        i += 1
        j += 1
        matièresEcrit(i) = New Matière("Expression", "EXP")
        matièresOral(j) = matièresEcrit(i)
        i += 1
        j += 1
        matièresEcrit(i) = New Matière("Gestion", "GST")
        matièresOral(j) = matièresEcrit(i)
        i += 1
        j += 1
        matièresEcrit(i) = New Matière("Mathématiques", "MAT")
        matièresOral(j) = matièresEcrit(i)
        i += 1
        j += 1
        matièresEcrit(i) = New Matière("Réseau", "RES")
        matièresOral(j) = matièresEcrit(i)
        i += 1
        j += 1
        matièresEcrit(i) = New Matière("Système", "SYS")
        matièresOral(j) = matièresEcrit(i)
        j += 1

        'Matières seulement à l'oral
        matièresOral(j) = New Matière("Anglais", "ANG")
        j += 1
        matièresOral(j) = New Matière("Chinois", "CHN")
        j += 1
        matièresOral(j) = New Matière("Espagnol", "ESP")

    End Sub
    Sub main()
        initialisation()
        Application.Run(ACCUEIL)
    End Sub
    Sub chargerRégions()
        For i = 0 To régions.Length - 1
            If Not INS_EPREUVES.Cb_Région.Items.Contains(régions(i)) Then
                INS_EPREUVES.Cb_Région.Items.Add(régions(i))
            End If
        Next i
    End Sub

    Sub chargerMatières()
        Dim i As Integer = 0
        For Each control In INS_EPREUVES.Gb_Ecrit.Controls.OfType(Of CheckBox)

            If (i < matièresEcrit.Length - 1) Then
                control.Text = matièresEcrit(i).Nom
            Else
                control.Visible = False
            End If
            i += 1
        Next
        i = 0
        For Each control In INS_EPREUVES.Gb_Oral.Controls.OfType(Of CheckBox)
            If (i < matièresOral.Length - 1) Then
                control.Text = matièresOral(i).Nom
            Else
                control.Visible = False
            End If
            i += 1
        Next
    End Sub

    Sub enregistrerInscription()

    End Sub
End Module
