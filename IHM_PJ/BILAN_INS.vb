Public Class BILAN_INS
    Public Sub initialiser(mat As Matière)
        Me.Text = "Bilan " & mat.ToString()
        Dim inscriptions As ArrayList = getInscriptionMatière(mat)
        inscriptions.Sort(Comparer(Of Inscription).Create(Function(i1, i2) If(i1.Région = i2.Région, If(i1.Nom = i2.Nom, i1.Prénom.CompareTo(i2.Prénom), i1.Nom.CompareTo(i2.Nom)), i1.Région.CompareTo(i2.Région))))
        Ls_Bilan.Items.Clear()
        For i = 0 To inscriptions.Count - 1
            Ls_Bilan.Items.Add(inscriptions(i).région1 & " " & inscriptions(i).ToString())
        Next i
    End Sub

    Private Sub Bt_Annuler_Click(sender As Object, e As EventArgs) Handles Bt_Annuler.Click
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub Bt_Arret_Click(sender As Object, e As EventArgs) Handles Bt_Arret.Click
        quitter()
    End Sub
End Class