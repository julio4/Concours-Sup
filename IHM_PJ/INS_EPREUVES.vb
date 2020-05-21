Public Class INS_EPREUVES
    Dim dernierChangement As Boolean
    Dim modification As Boolean
    Public Sub initialiser()
        Dim i As Integer = 0
        'Région
        For i = 0 To getRégions().Length - 1
            If Not Cb_Région.Items.Contains(getRégions()(i)) Then
                Cb_Région.Items.Add(getRégions()(i))
            End If
        Next i
        Cb_Région.Sorted = True
        'Epreuves
        i = 0
        For Each control In Gb_Ecrit.Controls.OfType(Of CheckBox)

            If (i < getMatièresEcrits().Length - 1) Then
                control.Text = getMatièresEcrits()(i).Nom
                control.Checked = False
            Else
                control.Visible = False
            End If
            i += 1
        Next
        i = 0
        For Each control In Gb_Oral.Controls.OfType(Of CheckBox)
            If (i < getMatièresOrales().Length - 1) Then
                control.Text = getMatièresOrales()(i).Nom
                control.Checked = False
            Else
                control.Visible = False
            End If
            i += 1
        Next
        Non.Checked = False
        Oui.Checked = False
        Gb_Facultatif.Visible = False
    End Sub

    Public Sub reinitialiser()
        For Each control In Gb_Ecrit.Controls.OfType(Of CheckBox)
            control.Checked = False
        Next
        For Each control In Gb_Oral.Controls.OfType(Of CheckBox)
            control.Checked = False
        Next
        Cb_Région.SelectedIndex = 0
        Non.Checked = False
        Oui.Checked = False
        Gb_Facultatif.Visible = False
        EcritsRestants.Text = getNbEcrits()
        OrauxRestants.Text = getNbOraux()
        dernierChangement = False
    End Sub

    Public Sub chargerModification(ins As Inscription)
        modification = True
        reinitialiser()
        For i As Integer = 0 To ins.écrits1.Length - 1
            For Each control In Gb_Ecrit.Controls.OfType(Of CheckBox)
                If (ins.écrits1(i).Nom = control.Text) Then
                    control.Checked = True
                    Exit For
                End If
            Next
        Next i
        For i As Integer = 0 To ins.oraux1.Length - 1
            For Each control In Gb_Oral.Controls.OfType(Of CheckBox)
                If (ins.oraux1(i).Nom = control.Text) Then
                    control.Checked = True
                    Exit For
                End If
            Next
        Next i
        For i As Integer = 0 To Cb_Région.Items.Count - 1
            If (ins.Région1 = Cb_Région.Items(i)) Then
                Cb_Région.SelectedIndex = i
            End If
        Next
        If (ins.facultatif1.Equals("Non")) Then
            Non.Checked = True
        Else
            Oui.Checked = True
            For i As Integer = 0 To Cb_EpreuvesFacultatives.Items.Count - 1
                If (ins.facultatif1 = Cb_EpreuvesFacultatives.Items(i)) Then
                    Cb_EpreuvesFacultatives.SelectedIndex = i
                End If
            Next
        End If
    End Sub
    Private Sub Bt_AnnulerIns_Click(sender As Object, e As EventArgs) Handles Bt_AbandonnerIns.Click
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub Bt_ValiderInsEpreuves_Click(sender As Object, e As EventArgs) Handles Bt_ValiderInsEpreuves.Click
        Dim correct As Boolean = True
        If (CInt(EcritsRestants.Text) > 0) Then
            MsgBox("Vous devez sélectionner " & getNbEcrits() & " épreuves écrites.")
            correct = False
        End If
        If (CInt(OrauxRestants.Text) > 0) Then
            MsgBox("Vous devez sélectionner " & getNbOraux() & " épreuves orales.")
            correct = False
        End If
        If (Oui.Checked And String.IsNullOrEmpty(Cb_EpreuvesFacultatives.SelectedItem)) Then
            MsgBox("Vous devez sélectionner une épreuve facultative.")
            correct = False
        End If
        If (Not Non.Checked And Not Oui.Checked) Then
            MsgBox("Veuillez indiquer si vous souhaitez participer à une épreuve facultative ou non.")
            correct = False
        End If

        If (correct) Then
            If (modification) Then
                modification = False
                RECAPITULATIF.charger()
            Else
                RECAPITULATIF.chargerInscription()
            End If
            Me.Hide()
            RECAPITULATIF.Show()
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
                If (CInt(OrauxRestants.Text) = 0) Then
                    dernierChangement = True
                    sender.checked = False
                    MsgBox("Nombre maximal d'épreuves orales atteint.")
                Else
                    OrauxRestants.Text = CInt(OrauxRestants.Text) - 1
                End If
            Else
                OrauxRestants.Text = CInt(OrauxRestants.Text) + 1
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
        If (CInt(OrauxRestants.Text) = 0 And CInt(EcritsRestants.Text) = 0) Then
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