﻿Public Class BILAN_PROVISOIRE
    Public Sub initialiser()
        Me.Text = "Bilan provisoire"
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

    Private Sub Rb_BilanIndividuel_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_BilanIndividuel.CheckedChanged
        If Rb_BilanIndividuel.Checked Then
            Cb_Candidats.Visible = True
            Lb_Candidat.Visible = True
        Else
            Cb_Candidats.Visible = False
            Lb_Candidat.Visible = False
        End If
    End Sub

    Private Sub Rb_BilanInscription_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_BilanInscription.CheckedChanged
        If Rb_BilanInscription.Checked Then
            Cb_Matières.Visible = True
            Lb_Matière.Visible = True
        Else
            Cb_Matières.Visible = False
            Lb_Matière.Visible = False
        End If
    End Sub

    Private Sub Bt_Annuler_Click(sender As Object, e As EventArgs) Handles Bt_Annuler.Click, MyBase.Closing
        Me.Hide()
        ACCUEIL.Show()
    End Sub

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
End Class