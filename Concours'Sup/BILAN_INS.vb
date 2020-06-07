''' <summary>
''' Formulaire Bilan des Inscriptions dans une matière
''' Hélène TE, Jules DOUMECHE, 2020
''' </summary>
''' 
Public Class BILAN_INS

    'Initialisation du formulaire de BILAN_INS de la matière mat
    Public Sub initialiser(mat As Matière)
        Titre.Text = "Bilan " & mat.ToString()
        Dim inscriptions As List(Of Inscription) = getInscriptionMatière(mat)
        inscriptions.Sort(Comparer(Of Inscription).Create(Function(i1, i2) If(i1.Région = i2.Région, If(i1.Nom = i2.Nom, i1.Prénom.CompareTo(i2.Prénom), i1.Nom.CompareTo(i2.Nom)), i1.Région.CompareTo(i2.Région))))
        Ls_Bilan.Items.Clear()
        For i = 0 To inscriptions.Count - 1
            Ls_Bilan.Items.Add(inscriptions(i).région & " " & inscriptions(i).ToString())
        Next i
    End Sub

    'Au clic du bouton annuler ou quitter
    'Retour à l'accueil
    Private Sub Bt_Annuler_Click(sender As Object, e As EventArgs) Handles Bt_Annuler.Click, Bt_quitter.Click, MyBase.Closing
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    'Au clic du bouton arrêt
    'Sauvegarde des inscriptions en mémoire et arrêt de l'application
    Private Sub Bt_Arret_Click(sender As Object, e As EventArgs) Handles Bt_Arret.Click
        sauvegarder()
        quitter()
    End Sub

    ''''
    'Procédures pour gérer la barre de haut et les mouvements de la fenêtre du formulaire
    Public draggable As Boolean
    Public MouseX As Integer
    Public MouseY As Integer
    Private Sub Pn_Top_MouseDown(sender As Object, e As MouseEventArgs) Handles Pn_Top.MouseDown
        Pn_MouseDown(Me)
    End Sub
    Private Sub Pn_Top_MouseMove(sender As Object, e As MouseEventArgs) Handles Pn_Top.MouseMove
        Pn_MouseMove(Me)
    End Sub
    Private Sub Pn_Top_MouseUp(sender As Object, e As MouseEventArgs) Handles Pn_Top.MouseUp
        draggable = False
    End Sub
    Private Sub Bt_Minimize_Click(sender As Object, e As EventArgs) Handles Bt_Minimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
    ''''
End Class