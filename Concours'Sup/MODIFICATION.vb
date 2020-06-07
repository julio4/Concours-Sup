''' <summary>
''' Formulaire de modification d'une inscription
''' Hélène TE, Jules DOUMECHE, 2020
''' </summary>
Public Class MODIFICATION
    Dim ins As Inscription

    'Mise en place des contraintes et chargement des inscriptions
    'Si aucune inscription affichage d'un message d'erreur
    Public Sub initialiser()
        Titre.Text = "Modification des inscriptions"
        Rb_ListeCandidat.Checked = False
        Rb_NumCandidat.Checked = False
        numCandidat.Enabled = False
        Cb_Candidats.Enabled = False
        Bt_Modifier.Enabled = False
        Bt_Supprimer.Enabled = False
        numCandidat.Text = ""
        Cb_Candidats.Items.Clear()
        If (getInscriptions.Count = 0) Then
            Me.Hide()
            MsgBox("Aucune inscriptions")
            ACCUEIL.Show()
            Exit Sub
        End If
        For i As Integer = 0 To getInscriptions.Count - 1
            Cb_Candidats.Items.Add(getInscriptions(i))
        Next i
        Cb_Candidats.Sorted = True
        Cb_Candidats.SelectedIndex = 0
    End Sub

    'Contrainte de saisie du numéro du candidat: numérique
    Private Sub MODIFICATION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numCandidat.KeyPress
        If e.KeyChar = vbBack Or Char.IsControl(e.KeyChar) Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Permet d'activer la sélection de l'inscription par numéro ou par recherche dans une liste
    Private Sub Rb_NumCandidat_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_NumCandidat.CheckedChanged, Rb_ListeCandidat.CheckedChanged
        If (Rb_NumCandidat.Checked) Then
            numCandidat.Enabled = True
            Cb_Candidats.Enabled = False
            Bt_Modifier.Enabled = True
            Bt_Supprimer.Enabled = True
        ElseIf (Rb_ListeCandidat.Checked) Then
            numCandidat.Enabled = False
            Cb_Candidats.Enabled = True
            Bt_Modifier.Enabled = True
            Bt_Supprimer.Enabled = True
        End If
    End Sub

    'Au clic du bouton annuler ou quitter
    'Retour à l'accueil
    Private Sub Bt_Annuler_Click(sender As Object, e As EventArgs) Handles Bt_Annuler.Click, Bt_quitter.Click, MyBase.Closing
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    'Au clic du bouton supprimer
    'charge et affiche le formulaire récapitulatif de l'inscription en mode suppression
    Private Sub Bt_Supprimer_Click(sender As Object, e As EventArgs) Handles Bt_Supprimer.Click
        If (validation()) Then
            RECAPITULATIF.chargerSupprimer(ins)
            Me.Hide()
            RECAPITULATIF.Show()
        End If
    End Sub

    'Au clic du bouton modifier
    'Charge les formulaires de saisies en mode modification de l'inscription
    'Affiche le premier formulaire de saisie des informations
    Private Sub Bt_Modifier_Click(sender As Object, e As EventArgs) Handles Bt_Modifier.Click
        If (validation()) Then
            Me.Hide()
            INS_SAISIE.Show()
            INS_SAISIE.chargerModification(ins)
            RECAPITULATIF.chargerModification(ins)
        End If
    End Sub

    'Permet de récupérer l'inscription dans la variable ins
    'Si le numéro ne correspond à aucune inscription alors affichage d'une erreur
    'Return True si inscription existante, false sinon
    Function validation() As Boolean
        Dim correct As Boolean = True
        If (Rb_NumCandidat.Checked) Then
            Rb_ListeCandidat.ForeColor = Color.Black
            If (String.IsNullOrEmpty(numCandidat.Text)) Then
                Rb_NumCandidat.ForeColor = Color.Red
                numCandidat.Focus()
                MsgBox("Veuillez indiquer un numéro de candidat.")
            Else
                Rb_NumCandidat.ForeColor = Color.Black
                If (IdValide(CInt(numCandidat.Text))) Then
                    ins = getInscription(CInt(numCandidat.Text))
                    Return True
                Else
                    MsgBox("Inscription non trouvé pour ce numéro.")
                End If
            End If
        ElseIf (Rb_ListeCandidat.Checked) Then
            Rb_NumCandidat.ForeColor = Color.Black
            If (String.IsNullOrEmpty(Cb_Candidats.SelectedItem.ToString())) Then
                Rb_ListeCandidat.ForeColor = Color.Red
                Cb_Candidats.Focus()
                MsgBox("Veuillez choisir un candidat dans la liste.")
            Else
                Rb_ListeCandidat.ForeColor = Color.Black
                ins = Cb_Candidats.SelectedItem
                Return True
            End If
        End If
        Return False
    End Function

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