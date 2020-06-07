Imports System.IO
Imports System.Text

Module App
    Const NB_MATIERES_ECRITS = 12
    Const NB_MATIERES_ORALES = 9
    Const CHEMIN_SAUVEGARDE_INSCRIPTION = "sauv_ins"
    Const CHEMIN_SAUVEGARDE_NBINSCRITS = "sauv_nbInscrits"
    Const CHEMIN_FIN_INSCRIPTIONS = "fin_inscription"
    Public Const AGE_MIN = 18
    Public Const AGE_MAX = 55
    Public Const TEMPS_LIMITE_SAISIE = 60
    Public Const TEMPS_LIMITE_EPREUVES = 90
    'Les variables et constantes
    Dim matièresEcrit(NB_MATIERES_ECRITS - 1) As Matière
    Dim matièresOrales(NB_MATIERES_ORALES - 1) As Matière
    Dim matièreVide As Matière
    Dim régions() As String = {"Auvergne", "Bordelais", "Bourgogne",
    "Bretagne", "Corse", "Nord", "Normandie", "Paris", "Poitou",
    "Roussillon"}
    Dim inscriptions As New List(Of Inscription)
    Dim dernierNumInscrits As Integer = 0
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

        If System.IO.File.Exists(CHEMIN_SAUVEGARDE_INSCRIPTION) And System.IO.File.Exists(CHEMIN_SAUVEGARDE_NBINSCRITS) Then
            Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
            Dim fStream As New FileStream(CHEMIN_SAUVEGARDE_INSCRIPTION, FileMode.Open)
            inscriptions = bf.Deserialize(fStream)
            fStream.Close()

            fStream = New FileStream(CHEMIN_SAUVEGARDE_NBINSCRITS, FileMode.Open)
            dernierNumInscrits = bf.Deserialize(fStream)
            fStream.Close()
        End If
    End Sub
    Sub main()
        initialisation()
        Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(ACCUEIL)
    End Sub

    Sub sauvegarder()
        Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim fStream As New FileStream(CHEMIN_SAUVEGARDE_INSCRIPTION, FileMode.Create)
        bf.Serialize(fStream, inscriptions)
        fStream.Close()
        fStream = New FileStream(CHEMIN_SAUVEGARDE_NBINSCRITS, FileMode.Create)
        bf.Serialize(fStream, dernierNumInscrits)
        fStream.Close()
    End Sub

    Sub quitter()
        Application.Exit()
        End
    End Sub

    Sub générerFichiers()
        If (inscriptions.Count = 0 Or inscriptions Is Nothing) Then
            MsgBox("Aucune inscriptions!")
            Exit Sub
        End If
        If (System.IO.Directory.Exists(CHEMIN_FIN_INSCRIPTIONS)) Then
            My.Computer.FileSystem.DeleteDirectory(CHEMIN_FIN_INSCRIPTIONS, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        System.IO.Directory.CreateDirectory(CHEMIN_FIN_INSCRIPTIONS)
        sauvegarder()
        My.Computer.FileSystem.MoveFile(CHEMIN_SAUVEGARDE_INSCRIPTION, CHEMIN_FIN_INSCRIPTIONS & "/" & CHEMIN_SAUVEGARDE_INSCRIPTION)
        My.Computer.FileSystem.MoveFile(CHEMIN_SAUVEGARDE_NBINSCRITS, CHEMIN_FIN_INSCRIPTIONS & "/" & CHEMIN_SAUVEGARDE_NBINSCRITS)
        inscriptions.Sort(Comparer(Of Inscription).Create(Function(i1, i2) If(i1.Nom = i2.Nom, i1.Prénom.CompareTo(i2.Prénom), i1.Nom.CompareTo(i2.Nom))))
        Dim écrits As List(Of String) = New List(Of String)
        For Each région In régions
            For Each mat As Matière In matièresEcrit
                Dim sb As New StringBuilder("")
                For i As Integer = 0 To inscriptions.Count - 1
                    If inscriptions(i).Région = région And inscriptions(i).contientEcrit(mat) Then
                        sb.AppendLine(inscriptions(i).ToString())
                    End If
                Next i
                If Not String.IsNullOrEmpty(sb.ToString()) Then
                    Dim path As String = CHEMIN_FIN_INSCRIPTIONS & "/" & mat.ToString() & " " & région & ".txt"
                    écrits.Add(mat.ToString() & UCase(région))
                    Using sw As StreamWriter = File.AppendText(Path)
                        sw.WriteLine("ECRIT")
                        sw.Write(sb.ToString())
                    End Using
                End If
            Next
            For Each mat As Matière In matièresOrales
                Dim sb As New StringBuilder("")
                For i As Integer = 0 To inscriptions.Count - 1
                    If inscriptions(i).Région = région And (inscriptions(i).contientOral(mat) Or inscriptions(i).contientFacultatif(mat)) Then
                        sb.AppendLine(inscriptions(i).ToString())
                    End If
                Next i
                If Not String.IsNullOrEmpty(sb.ToString()) Then
                    Dim path As String = CHEMIN_FIN_INSCRIPTIONS & "/" & mat.ToString() & " " & région & ".txt"
                    Using sw As StreamWriter = File.AppendText(path)
                        If (écrits.Contains(mat.ToString() & UCase(région))) Then
                            sw.WriteLine()
                        End If
                        sw.WriteLine("ORAL")
                        sw.Write(sb.ToString())
                    End Using
                End If
            Next
        Next
        quitter()
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
        Return dernierNumInscrits
    End Function

    Function getInscriptions() As List(Of Inscription)
        Return inscriptions
    End Function

    Function getInscription(id As Integer) As Inscription
        For i As Integer = 0 To inscriptions.Count - 1
            If (inscriptions(i).Num = id) Then
                Return inscriptions(i)
            End If
        Next i
    End Function

    Function getInscriptionMatière(mat As Matière) As ArrayList
        Dim liste As ArrayList = New ArrayList()
        For i As Integer = 0 To inscriptions.Count - 1
            If inscriptions(i).contient(mat) Then
                liste.Add(inscriptions(i))
            End If
        Next
        Return liste
    End Function

    Function getMatière(nom As String) As Matière
        For i As Integer = 0 To matièresEcrit.Length - 1
            If (matièresEcrit(i).Libellé = nom) Then
                Return matièresEcrit(i)
            End If
        Next
        For i As Integer = 0 To matièresOrales.Length - 1
            If (matièresOrales(i).Libellé = nom) Then
                Return matièresOrales(i)
            End If
        Next
        Return matièreVide
    End Function

    'ENREGISTREMENT DES CANDIDATS

    Sub enregistrerInscription()
        dernierNumInscrits += 1
        Dim écrits(nbEcrits - 1) As Matière
        For i As Integer = 0 To nbEcrits - 1
            écrits(i) = getMatière(RECAPITULATIF.Ls_écrits.Items(i).Text)
        Next i
        Dim oraux(nbOraux - 1) As Matière
        For i As Integer = 0 To nbOraux - 1
            oraux(i) = getMatière(RECAPITULATIF.Ls_oraux.Items(i).Text)
        Next i
        inscriptions.Add(New Inscription(dernierNumInscrits, INS_SAISIE.Nom.Text, INS_SAISIE.Prénom.Text,
                                                   INS_SAISIE.Adresse.Text, CInt(INS_SAISIE.CodePostal.Text), INS_SAISIE.Ville.Text _
                                                   , CInt(INS_SAISIE.Age.Text), RECAPITULATIF.Lb_Région_Donnée.Text, écrits, oraux,
                                                     getMatière(RECAPITULATIF.Lb_facultative_donnée.Text)))
    End Sub

    'MODIFICATION ET SUPPRESSION DES CANDIDATS

    Function IdValide(id As Integer) As Boolean
        For i As Integer = 0 To inscriptions.Count - 1
            If (inscriptions(i).Num = id) Then
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
        ins.Nom = INS_SAISIE.Nom.Text
        ins.Prénom = INS_SAISIE.Prénom.Text
        ins.Adresse = INS_SAISIE.Adresse.Text
        ins.CodePostal = INS_SAISIE.CodePostal.Text
        ins.Ville = INS_SAISIE.Ville.Text
        ins.Age = CInt(INS_SAISIE.Age.Text)
        ins.Région = RECAPITULATIF.Lb_Région_Donnée.Text
        ins.Facultatif = getMatière(RECAPITULATIF.Lb_facultative_donnée.Text)
        Dim écrits(nbEcrits - 1) As Matière
        For i As Integer = 0 To nbEcrits - 1
            écrits(i) = getMatière(RECAPITULATIF.Ls_écrits.Items(i).Text)
        Next i
        Dim oraux(nbOraux - 1) As Matière
        For i As Integer = 0 To nbOraux - 1
            oraux(i) = getMatière(RECAPITULATIF.Ls_oraux.Items(i).Text)
        Next i
        ins.Ecrits = écrits
        ins.Oraux = oraux
    End Sub

    Public Function afficherTempsRestant(sec As Integer) As String

        Dim minutes As Integer = (Int(sec / 60))
        Dim secondes As Integer = Int(sec Mod 60)

        If secondes = 60 Then
            minutes += 1
            secondes = 0
        End If

        Return If(minutes > 0, CStr(minutes) &
            If(minutes > 1, " minutes ", " minute "), "") &
          Format(secondes, "00") &
           If(secondes > 1, " secondes", " seconde")
    End Function

    Public Sub Pn_MouseDown(sender As Object)
        sender.draggable = True
        sender.MouseX = Cursor.Position.X - sender.Left
        sender.MouseY = Cursor.Position.Y - sender.Top
    End Sub

    Public Sub Pn_MouseMove(sender As Object)
        If sender.draggable Then
            sender.Top = Cursor.Position.Y - sender.MouseY
            sender.Left = Cursor.Position.X - sender.MouseX
        End If
    End Sub
End Module
