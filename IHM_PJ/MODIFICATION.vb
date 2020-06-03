Public Class MODIFICATION
    Dim ins As Inscription
    Public Sub reinitialiser()
        Me.Text = "Modification des inscriptions"
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

    Private Sub MODIFICATION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numCandidat.KeyPress
        If e.KeyChar = vbBack Or Char.IsControl(e.KeyChar) Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

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

    Private Sub Bt_Annuler_Click(sender As Object, e As EventArgs) Handles Bt_Annuler.Click, MyBase.Closing
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub Bt_Supprimer_Click(sender As Object, e As EventArgs) Handles Bt_Supprimer.Click
        If (validation()) Then
            RECAPITULATIF.chargerSupprimer(ins)
            Me.Hide()
            RECAPITULATIF.Show()
        End If
    End Sub

    Private Sub Bt_Modifier_Click(sender As Object, e As EventArgs) Handles Bt_Modifier.Click
        If (validation()) Then
            'INS_SAISIE.INS_SAISIE_Load(e, e)
            'INS_EPREUVES.INS_EPREUVES_Load(e, e)
            Me.Hide()
            INS_SAISIE.Show()
            INS_SAISIE.chargerModification(ins)
            RECAPITULATIF.chargerModification(ins)
        End If
    End Sub

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
End Class