''' <summary>
''' Formulaire d'Affichage récapitulatif de toutes les inscriptions / Bilan Final
''' Hélène TE, Jules DOUMECHE, 2020
''' </summary>
''' 
Public Class AFFICHAGE

    'Initialise et charge les données et contraintes du formulaire
    Public Sub initialiser()
        Titre.Text = "Etat actuel des inscriptions"
        Lb_Facultative.Visible = False
        Lb_facultative1.Visible = False
        Lb_Num.Items.Clear()
        Lb_Nom.Items.Clear()
        Lb_Prenom.Items.Clear()
        Dim inscriptions As List(Of Inscription) = getInscriptions()
        inscriptions.Sort(Comparer(Of Inscription).Create(Function(i1, i2) If(i1.Nom = i2.Nom, i1.Prénom.CompareTo(i2.Prénom), i1.Nom.CompareTo(i2.Nom))))
        For i As Integer = 0 To inscriptions.Count - 1
            Lb_Num.Items.Add(inscriptions(i).Num)
            Lb_Nom.Items.Add(inscriptions(i).Nom)
            Lb_Prenom.Items.Add(inscriptions(i).Prénom)
        Next i
        Lb_Ecrits.Sorted = True
        Lb_Oraux.Sorted = True
        Bt_Fin.Visible = False
    End Sub

    'Initialise et charge les données et contraintes du formulaire en mode Bilan Final
    Public Sub initialiserBilan()
        initialiser()
        Titre.Text = "Bilan Final"
        Bt_Fin.Visible = True
    End Sub

    'Au clic d'un des champs d'une inscription (nom/prénom/numéro)
    'Affiche les codes des matières sélectionnées de l'inscription sélectionnée
    Private Sub chargerMatières(sender As Object, e As EventArgs) Handles Lb_Prenom.SelectedIndexChanged,
            Lb_Nom.SelectedIndexChanged, Lb_Num.SelectedIndexChanged
        If (sender.Equals(Lb_Num)) Then
            Lb_Nom.SelectedIndex = Lb_Num.SelectedIndex
            Lb_Prenom.SelectedIndex = Lb_Num.SelectedIndex
        ElseIf (sender.Equals(Lb_Nom)) Then
            Lb_Num.SelectedIndex = Lb_Nom.SelectedIndex
            Lb_Prenom.SelectedIndex = Lb_Nom.SelectedIndex
        Else
            Lb_Num.SelectedIndex = Lb_Prenom.SelectedIndex
            Lb_Nom.SelectedIndex = Lb_Prenom.SelectedIndex
        End If
        Dim ins As Inscription = getInscription(CInt(Lb_Num.SelectedItem))
        Lb_Ecrits.Items.Clear()
        For i As Integer = 0 To ins.Ecrits.Length - 1
            Lb_Ecrits.Items.Add(ins.Ecrits(i).Code)
        Next i
        Lb_Oraux.Items.Clear()
        For i As Integer = 0 To ins.Oraux.Length - 1
            Lb_Oraux.Items.Add(ins.Oraux(i).Code)
        Next i
        If (ins.Facultatif.Libellé = "NON") Then
            Lb_facultative1.Visible = False
            Lb_Facultative.Visible = False
        Else
            Lb_Facultative.Items.Clear()
            Lb_Facultative.Items.Add(ins.Facultatif.Code)
            Lb_facultative1.Visible = True
            Lb_Facultative.Visible = True
        End If
    End Sub

    'Au clic du bouton retour ou quitter
    'Retour à l'accueil
    Private Sub Bt_Retour_Click(sender As Object, e As EventArgs) Handles Bt_Retour.Click, Bt_quitter.Click, MyBase.Closing
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    'Au clic du bouton Cloturer les inscriptions
    'génère les fichiers textes des inscriptions
    Private Sub Bt_Fin_Click(sender As Object, e As EventArgs) Handles Bt_Fin.Click
        générerFichiers()
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