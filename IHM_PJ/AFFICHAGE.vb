Public Class AFFICHAGE
    Public Sub initialiser()
        Me.Text = "Etat actuel des inscriptions"
        Lb_Facultative.Visible = False
        Lb_facultative1.Visible = False
        Lb_Num.Items.Clear()
        Lb_Nom.Items.Clear()
        Lb_Prenom.Items.Clear()
        Dim inscriptions As List(Of Inscription) = getInscriptions()
        inscriptions.Sort(Comparer(Of Inscription).Create(Function(i1, i2) If(i1.Nom = i2.Nom, i1.Prénom.CompareTo(i2.Prénom), i1.Nom.CompareTo(i2.Nom))))
        For i As Integer = 0 To inscriptions.Count - 1
            Lb_Num.Items.Add(inscriptions(i).Num)
            Lb_Nom.Items.Add(inscriptions(i).Nom)
            Lb_Prenom.Items.Add(inscriptions(i).Prénom)
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
        For i As Integer = 0 To ins.Ecrits.Length - 1
            Lb_Ecrits.Items.Add(ins.Ecrits(i).Code)
        Next i
        Lb_Oraux.Items.Clear()
        For i As Integer = 0 To ins.Oraux.Length - 1
            Lb_Oraux.Items.Add(ins.Oraux(i).Code)
        Next i
        If (ins.Facultatif.Libellé = "NON") Then
            Lb_facultative1.Visible = False
            Lb_Facultative.Visible = False
        Else
            Lb_Facultative.Items.Clear()
            Lb_Facultative.Items.Add(ins.Facultatif.Code)
            Lb_facultative1.Visible = True
            Lb_Facultative.Visible = True
        End If
    End Sub

    Private Sub Bt_Retour_Click(sender As Object, e As EventArgs) Handles Bt_Retour.Click, MyBase.Closing
        Me.Hide()
        ACCUEIL.Show()
    End Sub
End Class