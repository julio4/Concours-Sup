''' <summary>
''' Formulaire Bilan Provisoire
''' Hélène TE, Jules DOUMECHE, 2020
''' </summary>
''' 
Public Class BILAN_PROVISOIRE

    'initialise les contraintes et données du formulaire
    Public Sub initialiser()
        Titre.Text = "Bilan provisoire"
        Lb_Candidat.Visible = False
        Cb_Candidats.Visible = False
        Lb_Matière.Visible = False
        Cb_Matières.Visible = False
        Rb_BilanIndividuel.Checked = False
        Rb_BilanInscription.Checked = False
        Cb_Candidats.Items.Clear()
        Cb_Matières.Items.Clear()
        If (getInscriptions.Count = 0) Then
            Me.Hide()
            MsgBox("Aucune inscriptions")
            ACCUEIL.Show()
            Exit Sub
        End If
        NbInscrits.Text = getInscriptions.Count
        For i As Integer = 0 To getInscriptions.Count - 1
            Cb_Candidats.Items.Add(getInscriptions(i))
        Next i
        Cb_Candidats.Sorted = True
        Cb_Candidats.SelectedIndex = 0
        For i As Integer = 0 To getMatièresEcrits.Count - 1
            Cb_Matières.Items.Add(getMatièresEcrits(i))
        Next i
        For i As Integer = 0 To getMatièresOrales.Count - 1
            If Not Cb_Matières.Items.Contains(getMatièresOrales(i)) Then
                Cb_Matières.Items.Add(getMatièresOrales(i))
            End If
        Next i
        Cb_Matières.Sorted = True
        Cb_Matières.SelectedIndex = 0
    End Sub

    'Gère l'alternance entre le bilan individuel et le bilan d'une matière
    Private Sub Rb_BilanIndividuel_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_BilanIndividuel.CheckedChanged
        If Rb_BilanIndividuel.Checked Then
            Cb_Candidats.Visible = True
            Lb_Candidat.Visible = True
        Else
            Cb_Candidats.Visible = False
            Lb_Candidat.Visible = False
        End If
    End Sub

    'Au clic du boutton annuler ou quitter
    'Retour à l'accueil
    Private Sub Bt_Annuler_Click(sender As Object, e As EventArgs) Handles Bt_Annuler.Click, Bt_quitter.Click, MyBase.Closing
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    'Au clic du boutton Afficher Bilan
    'Si bilan individuel affichage du formulaire récapitulatif de l'inscription
    'Si bilan d'une matière affichage du formulaire Bilan des Inscriptions de la matière choisie
    Private Sub AfficherBilan_Click(sender As Object, e As EventArgs) Handles AfficherBilan.Click
        If (Rb_BilanIndividuel.Checked) Then
            RECAPITULATIF.chargerBilan(Cb_Candidats.SelectedItem)
            Me.Hide()
            RECAPITULATIF.Show()
        ElseIf Rb_BilanInscription.Checked Then
            Me.Hide()
            BILAN_INS.Show()
            BILAN_INS.initialiser(Cb_Matières.SelectedItem)
        Else
            'ERREUR
        End If
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