Public Class ACCUEIL
    Private Sub Btn_EnregistrerIns_Click(sender As Object, e As EventArgs) Handles Btn_EnregistrerIns.Click
        Me.Hide()
        INS_SAISIE.chargerInscription()
        INS_EPREUVES.reinitialiser()
        INS_SAISIE.Show()
    End Sub

    Private Sub Btn_ModificationIns_Click(sender As Object, e As EventArgs) Handles Btn_ModificationIns.Click
        Me.Hide()
        MODIFICATION.Show()
        MODIFICATION.reinitialiser()
    End Sub

    Private Sub ACCUEIL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INS_EPREUVES.initialiser()
        INS_SAISIE.initialiser()
    End Sub

    Private Sub Btn_AfficherIns_Click(sender As Object, e As EventArgs) Handles Btn_AfficherIns.Click
        AFFICHAGE.initialiser()
        Me.Hide()
        AFFICHAGE.Show()
    End Sub
End Class
