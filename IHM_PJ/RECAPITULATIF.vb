Public Class RECAPITULATIF
    Dim inscription As Inscription
    Public Sub chargerInscription()
        charger()
        'Visibilité bouttons
        Bt_Enregistrer.Visible = True
        Bt_Modifier.Visible = True
        Bt_ValiderModification.Visible = False
        Bt_Supprimer.Visible = False
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

    Public Sub chargerSupprimer(ins As Inscription)
        inscription = ins
        Bt_Enregistrer.Visible = False
        Bt_Modifier.Visible = False
        Bt_ValiderModification.Visible = False
        Bt_Supprimer.Visible = True

        Lb_Nom_Donnée.Text = ins.Nom1 & " " & ins.Prénom1 & ", " _
            & ins.Age1 & " ans"
        Lb_Adresse_Donnée.Text = ins.Adresse1
        Lb_CPVille_Donnée.Text = ins.CodePostal1 & " " & ins.Ville1
        Lb_Région_Donnée.Text = ins.Région1
        Ls_écrits.Items.Clear()
        Ls_écrits.View = View.List
        For i As Integer = 0 To ins.écrits1.Length - 1
            Ls_écrits.Items.Add(ins.écrits1(i).Nom)
        Next
        Ls_oraux.Items.Clear()
        ''Ls_oraux.View = View.List
        For i As Integer = 0 To ins.oraux1.Length - 1
            Ls_oraux.Items.Add(ins.oraux1(i).Nom)
        Next
        Lb_facultative_donnée.Text = ins.facultatif1.Nom
    End Sub

    Public Sub chargerModification(ins As Inscription)
        inscription = ins
        Bt_Enregistrer.Visible = False
        Bt_Modifier.Visible = False
        Bt_ValiderModification.Visible = True
        Bt_Supprimer.Visible = False
    End Sub

    Private Sub Bt_Annuler_Click(sender As Object, e As EventArgs) Handles Bt_Annuler.Click
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub Bt_Modifier_Click(sender As Object, e As EventArgs) Handles Bt_Modifier.Click
        Me.Hide()
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
End Class