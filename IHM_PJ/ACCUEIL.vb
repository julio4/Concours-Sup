Public Class ACCUEIL
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

    Private Sub Btn_ModificationIns_Click(sender As Object, e As EventArgs) Handles Btn_ModificationIns.Click
        Me.Hide()
        MODIFICATION.Show()
        MODIFICATION.reinitialiser()
    End Sub

    Private Sub Btn_AfficherIns_Click(sender As Object, e As EventArgs) Handles Btn_AfficherIns.Click
        Me.Hide()
        AFFICHAGE.Show()
        AFFICHAGE.initialiser()
    End Sub

    Private Sub ACCUEIL_Leave(sender As Object, e As EventArgs) Handles Bt_quitter.Click, MyBase.Closing
        'ENREGISTRER LES DONNEES
        sauvegarder()
        quitter()
    End Sub

    Private Sub Btn_BilanProvisoire_Click(sender As Object, e As EventArgs) Handles Btn_BilanProvisoire.Click
        Me.Hide()
        BILAN_PROVISOIRE.Show()
        BILAN_PROVISOIRE.initialiser()
    End Sub

    Private Sub ACCUEIL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Accueil | " & DateString
    End Sub

    Private Sub Bt_FinIns_Click(sender As Object, e As EventArgs) Handles Bt_FinIns.Click
        Me.Hide()
        AFFICHAGE.Show()
        AFFICHAGE.initialiserBilan()
    End Sub
End Class
