Public Class ACCUEIL

    'Au clic du bouton Enregistrer Inscription
    'Charge et réinitialise les formulaires de saisies des informations et des épreuves
    'Affiche le formulaire de saisie des informations
    Private Sub Btn_EnregistrerIns_Click(sender As Object, e As EventArgs) Handles Btn_EnregistrerIns.Click
        Me.Hide()
        If Not Application.OpenForms().OfType(Of INS_SAISIE).Any Then
            INS_SAISIE.initialiser()
        End If
        If Not Application.OpenForms().OfType(Of INS_EPREUVES).Any Then
            INS_EPREUVES.initialiser()
        End If
        INS_SAISIE.chargerInscription()
        INS_SAISIE.Show()
    End Sub

    'Au clic du bouton Modifier-Supprimer Inscriptions
    'Charge et réinitialise les formulaires de saisies des informations et des épreuves et le formulaire MODIFICATION
    'Affiche le formulaire MODIFICATION
    Private Sub Btn_ModificationIns_Click(sender As Object, e As EventArgs) Handles Btn_ModificationIns.Click
        Me.Hide()
        If Not Application.OpenForms().OfType(Of INS_SAISIE).Any Then
            INS_SAISIE.initialiser()
        End If
        If Not Application.OpenForms().OfType(Of INS_EPREUVES).Any Then
            INS_EPREUVES.initialiser()
        End If
        MODIFICATION.Show()
        MODIFICATION.initialiser()
    End Sub

    'Au clic du bouton Afficher Inscriptions
    'Charge et affiche le formulaire AFFICHAGE
    Private Sub Btn_AfficherIns_Click(sender As Object, e As EventArgs) Handles Btn_AfficherIns.Click
        Me.Hide()
        AFFICHAGE.Show()
        AFFICHAGE.initialiser()
    End Sub

    'Au clic du bouton quitter
    'Sauvegarde en mémoire les inscriptions et arrêt de l'application
    Private Sub ACCUEIL_Leave(sender As Object, e As EventArgs) Handles Bt_quitter.Click, MyBase.Closing
        sauvegarder()
        quitter()
    End Sub

    'Au clic du bouton Etablir bilan provisoire
    'Charge et affiche le formulaire BILAN_PROVISOIRE
    Private Sub Btn_BilanProvisoire_Click(sender As Object, e As EventArgs) Handles Btn_BilanProvisoire.Click
        Me.Hide()
        BILAN_PROVISOIRE.Show()
        BILAN_PROVISOIRE.initialiser()
    End Sub

    'Au clic du bouton Mettre fin aux inscriptions
    'Charge et affiche le formulaire AFFICHAGE des inscriptions en mode Bilan Final
    Private Sub Bt_FinIns_Click(sender As Object, e As EventArgs) Handles Bt_FinIns.Click
        Me.Hide()
        AFFICHAGE.Show()
        AFFICHAGE.initialiserBilan()
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
