Public Class RECAPITULATIF
    Dim inscription As Inscription
    Public Sub chargerInscription()
        Me.Text = "Récapitulatif de la nouvelle inscription"
        charger()
        'Visibilité bouttons
        Bt_Enregistrer.Visible = True
        Bt_Modifier.Visible = True
        Bt_ValiderModification.Visible = False
        Bt_Supprimer.Visible = False
        Bt_Arret.Visible = False
    End Sub
    Public Sub charger()

        'Information du candidat
        Lb_Nom_Donnée.Text = INS_SAISIE.Nom.Text & " " & INS_SAISIE.Prénom.Text & ", " _
            & INS_SAISIE.Age.Text & " ans"
        Lb_Adresse_Donnée.Text = INS_SAISIE.Adresse.Text
        Lb_CPVille_Donnée.Text = INS_SAISIE.CodePostal.Text & " " & INS_SAISIE.Ville.Text
        Lb_Région_Donnée.Text = INS_EPREUVES.Cb_Région.SelectedItem

        'Afficher épreuves
        Dim epreuvesEcrites(getNbEcrits() - 1) As String
        Dim epreuvesOrales(getNbOraux() - 1) As String
        Dim i As Integer = 0
        For Each control In INS_EPREUVES.Gb_Ecrit.Controls.OfType(Of CheckBox)
            If (control.Checked) Then
                epreuvesEcrites(i) = control.Text
                i += 1
            End If
        Next
        Ls_écrits.View = View.List
        Ls_écrits.Items.Clear()
        For i = 0 To epreuvesEcrites.Length - 1
            Ls_écrits.Items.Add(epreuvesEcrites(i))
        Next i
        i = 0
        For Each control In INS_EPREUVES.Gb_Oral.Controls.OfType(Of CheckBox)
            If (control.Checked) Then
                epreuvesOrales(i) = control.Text
                i += 1
            End If
        Next
        Ls_oraux.View = View.List
        Ls_oraux.Items.Clear()
        For i = 0 To epreuvesOrales.Length - 1
            Ls_oraux.Items.Add(epreuvesOrales(i))
        Next i
        Lb_facultative_donnée.Text = If(INS_EPREUVES.Oui.Checked,
            INS_EPREUVES.Cb_EpreuvesFacultatives.SelectedItem, "Non")
    End Sub

    Private Sub chargerRecapitulatif(ins As Inscription)
        Bt_Enregistrer.Visible = False
        Bt_Modifier.Visible = False
        Bt_ValiderModification.Visible = False
        Bt_Supprimer.Visible = False
        Bt_Arret.Visible = False
        Lb_Nom_Donnée.Text = ins.Nom & " " & ins.Prénom & ", " _
            & ins.Age & " ans"
        Lb_Adresse_Donnée.Text = ins.Adresse
        Lb_CPVille_Donnée.Text = ins.CodePostal & " " & ins.Ville
        Lb_Région_Donnée.Text = ins.Région
        Ls_écrits.Items.Clear()
        Ls_écrits.View = View.List
        For i As Integer = 0 To ins.Ecrits.Length - 1
            Ls_écrits.Items.Add(ins.Ecrits(i).Libellé)
        Next
        Ls_oraux.Items.Clear()
        ''Ls_oraux.View = View.List
        For i As Integer = 0 To ins.Oraux.Length - 1
            Ls_oraux.Items.Add(ins.Oraux(i).Libellé)
        Next
        Lb_facultative_donnée.Text = ins.Facultatif.Libellé
    End Sub
    Public Sub chargerSupprimer(ins As Inscription)
        chargerRecapitulatif(ins)
        Me.Text = "Récapitulatif de l'inscription à supprimer"
        inscription = ins
        Bt_Enregistrer.Visible = False
        Bt_Modifier.Visible = False
        Bt_ValiderModification.Visible = False
        Bt_Supprimer.Visible = True
        Bt_Arret.Visible = False
    End Sub

    Public Sub chargerBilan(ins As Inscription)
        chargerRecapitulatif(ins)
        Me.Text = "Bilan de l'inscription du candidat"
        inscription = ins
        Bt_Enregistrer.Visible = False
        Bt_Modifier.Visible = False
        Bt_ValiderModification.Visible = False
        Bt_Supprimer.Visible = False
        Bt_Arret.Visible = True
    End Sub

    Public Sub chargerModification(ins As Inscription)
        inscription = ins
        Bt_Enregistrer.Visible = False
        Bt_Modifier.Visible = False
        Bt_ValiderModification.Visible = True
        Bt_Supprimer.Visible = False
        Bt_Arret.Visible = False
    End Sub

    Private Sub Bt_Annuler_Click(sender As Object, e As EventArgs) Handles Bt_Annuler.Click, MyBase.Closing
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub Bt_Modifier_Click(sender As Object, e As EventArgs) Handles Bt_Modifier.Click
        Me.Hide()
        INS_SAISIE.chargerModification()
        INS_SAISIE.Show()
    End Sub

    Private Sub Bt_Enregistrer_Click(sender As Object, e As EventArgs) Handles Bt_Enregistrer.Click
        enregistrerInscription()
        MsgBox("Enregistrement réalisé. Numéro de candidat attribué : " & getNumDernierEnregistrement())
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub Bt_Supprimer_Click(sender As Object, e As EventArgs) Handles Bt_Supprimer.Click
        If (Not IsNothing(inscription)) Then
            supprimerInscription(inscription)
            MsgBox("Inscription du candidat supprimée.")
        End If
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub Bt_ValiderModification_Click(sender As Object, e As EventArgs) Handles Bt_ValiderModification.Click
        If (Not IsNothing(inscription)) Then
            modifierInscription(inscription)
            MsgBox("Modification Effectuée.")
        End If
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub Bt_Arret_Click(sender As Object, e As EventArgs) Handles Bt_Arret.Click
        sauvegarder()
        quitter()
    End Sub
End Class