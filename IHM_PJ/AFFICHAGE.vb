Public Class AFFICHAGE
    Public Sub initialiser()
        Lb_Facultative.Visible = False
        Lb_facultative1.Visible = False
        Lb_Num.Items.Clear()
        Lb_Nom.Items.Clear()
        Lb_Prenom.Items.Clear()
        Dim inscriptions As ArrayList = getInscriptions()
        inscriptions.Sort(Comparer(Of Inscription).Create(Function(i1, i2) If(i1.Nom1 = i2.Nom1, i1.Prénom1.CompareTo(i2.Prénom1), i1.Nom1.CompareTo(i2.Nom1))))
        For i As Integer = 0 To inscriptions.Count - 1
            Lb_Num.Items.Add(inscriptions(i).num1)
            Lb_Nom.Items.Add(inscriptions(i).nom1)
            Lb_Prenom.Items.Add(inscriptions(i).prénom1)
        Next i
        Lb_Ecrits.Sorted = True
        Lb_Oraux.Sorted = True
    End Sub

    Private Sub chargerMatières(sender As Object, e As EventArgs) Handles Lb_Prenom.SelectedIndexChanged,
            Lb_Nom.SelectedIndexChanged, Lb_Num.SelectedIndexChanged
        If (sender.Equals(Lb_Num)) Then
            Lb_Nom.SelectedIndex = Lb_Num.SelectedIndex
            Lb_Prenom.SelectedIndex = Lb_Num.SelectedIndex
        ElseIf (sender.Equals(Lb_Nom)) Then
            Lb_Num.SelectedIndex = Lb_Nom.SelectedIndex
            Lb_Prenom.SelectedIndex = Lb_Nom.SelectedIndex
        Else
            Lb_Num.SelectedIndex = Lb_Prenom.SelectedIndex
            Lb_Nom.SelectedIndex = Lb_Prenom.SelectedIndex
        End If
        Dim ins As Inscription = getInscription(CInt(Lb_Num.SelectedItem))
        Lb_Ecrits.Items.Clear()
        For i As Integer = 0 To ins.écrits1.Length - 1
            Lb_Ecrits.Items.Add(ins.écrits1(i).Code1)
        Next i
        Lb_Oraux.Items.Clear()
        For i As Integer = 0 To ins.oraux1.Length - 1
            Lb_Oraux.Items.Add(ins.oraux1(i).Code1)
        Next i
        If (ins.facultatif1.Nom = "NON") Then
            Lb_facultative1.Visible = False
            Lb_Facultative.Visible = False
        Else
            Lb_Facultative.Items.Clear()
            Lb_Facultative.Items.Add(ins.facultatif1.Code1)
            Lb_facultative1.Visible = True
            Lb_Facultative.Visible = True
        End If
    End Sub

    Private Sub Bt_Retour_Click(sender As Object, e As EventArgs) Handles Bt_Retour.Click
        Me.Hide()
        ACCUEIL.Show()
    End Sub
End Class