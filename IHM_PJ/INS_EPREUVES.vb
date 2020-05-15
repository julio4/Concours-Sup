Public Class INS_EPREUVES
    Const nbEcrits = 4
    Const nbOral = 3
    Dim dernierChangement As Boolean
    Private Sub INS_EPREUVES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lb_NOM.Text = INS_SAISIE.Nom.Text & " " & INS_SAISIE.Prénom.Text
        chargerRégions()
        Cb_Région.Sorted = True
        Cb_Région.SelectedIndex = 0
        chargerMatières()
        Gb_Facultatif.Visible = False
        EcritsRestants.Text = nbEcrits
        OralsRestants.Text = nbOral
        dernierChangement = False
    End Sub
    Private Sub Bt_AnnulerIns_Click(sender As Object, e As EventArgs) Handles Bt_AnnulerIns.Click
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub Bt_ValiderInsEpreuves_Click(sender As Object, e As EventArgs) Handles Bt_ValiderInsEpreuves.Click
        Dim correct As Boolean = True
        If (CInt(EcritsRestants.Text) > 0) Then
            MsgBox("Vous devez sélectionner " & nbEcrits & " épreuves écrites.")
            correct = False
        End If
        If (CInt(OralsRestants.Text) > 0) Then
            MsgBox("Vous devez sélectionner " & nbOral & " épreuves orales.")
            correct = False
        End If

        If (correct) Then
            'Recuperer toutes les données et enregistrer dans New Inscription, ajout de l'inscription
            enregistrerInscription()
            Me.Hide()
            ACCUEIL.Show()
        End If
    End Sub

    Private Sub Ecrit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged _
        , CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged,
        CheckBox6.CheckedChanged, CheckBox7.CheckedChanged, CheckBox8.CheckedChanged, CheckBox9.CheckedChanged,
        CheckBox10.CheckedChanged, CheckBox11.CheckedChanged, CheckBox12.CheckedChanged
        If (Not dernierChangement) Then
            If (sender.checked) Then
                If (CInt(EcritsRestants.Text) = 0) Then
                    dernierChangement = True
                    sender.checked = False
                    MsgBox("Nombre maximal d'épreuves écrites atteint.")
                Else
                    EcritsRestants.Text = CInt(EcritsRestants.Text) - 1
                End If
            Else
                EcritsRestants.Text = CInt(EcritsRestants.Text) + 1
            End If
        End If
        dernierChangement = False
        For Each control In Gb_Oral.Controls.OfType(Of CheckBox)
            If (sender.Text = control.Text) Then
                control.Enabled = If(sender.checked, False, True)
                Exit For
            End If
        Next
        chargerFacultatif()
    End Sub

    Private Sub Oral_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged _
    , CheckBox14.CheckedChanged, CheckBox15.CheckedChanged, CheckBox16.CheckedChanged, CheckBox17.CheckedChanged,
    CheckBox18.CheckedChanged, CheckBox19.CheckedChanged, CheckBox20.CheckedChanged, CheckBox21.CheckedChanged
        If (Not dernierChangement) Then
            If (sender.checked) Then
                If (CInt(OralsRestants.Text) = 0) Then
                    dernierChangement = True
                    sender.checked = False
                    MsgBox("Nombre maximal d'épreuves orales atteint.")
                Else
                    OralsRestants.Text = CInt(OralsRestants.Text) - 1
                End If
            Else
                OralsRestants.Text = CInt(OralsRestants.Text) + 1
            End If
        End If
        dernierChangement = False
        For Each control In Gb_Ecrit.Controls.OfType(Of CheckBox)
            If (sender.Text = control.Text) Then
                control.Enabled = If(sender.checked, False, True)
                Exit For
            End If
        Next
        chargerFacultatif()
    End Sub

    Private Sub chargerFacultatif()
        If (CInt(OralsRestants.Text) = 0 And CInt(EcritsRestants.Text) = 0) Then
            Gb_Facultatif.Visible = True
            Cb_EpreuvesFacultatives.Visible = False
            Dim listeFacultatif(10) As String
            Dim i As Integer = 0
            For Each control In Gb_Oral.Controls.OfType(Of CheckBox)
                If (Not control.Checked And control.Enabled And Not listeFacultatif.Contains(control.Text)) Then
                    listeFacultatif(i) = control.Text
                    i += 1
                End If
            Next
            For Each control In Gb_Ecrit.Controls.OfType(Of CheckBox)
                If (Not control.Checked And control.Enabled And Not listeFacultatif.Contains(control.Text)) Then
                    listeFacultatif(i) = control.Text
                    i += 1
                End If
            Next
            For j As Integer = 0 To i - 1
                Cb_EpreuvesFacultatives.Items.Add(listeFacultatif(j))
            Next j
        Else
            Cb_EpreuvesFacultatives.Items.Clear()
            Gb_Facultatif.Visible = False
        End If
    End Sub

    Private Sub Oui_CheckedChanged(sender As Object, e As EventArgs) Handles Oui.CheckedChanged
        If (Oui.Checked) Then
            Gb_Ecrit.Enabled = False
            Gb_Oral.Enabled = False
            Cb_EpreuvesFacultatives.Visible = True
        Else
            Gb_Ecrit.Enabled = True
            Gb_Oral.Enabled = True
            Cb_EpreuvesFacultatives.Visible = False
        End If
    End Sub
End Class