Public Class BILAN_INS
    Public Sub initialiser(mat As Matière)
        Titre.Text = "Bilan " & mat.ToString()
        Dim inscriptions As ArrayList = getInscriptionMatière(mat)
        inscriptions.Sort(Comparer(Of Inscription).Create(Function(i1, i2) If(i1.Région = i2.Région, If(i1.Nom = i2.Nom, i1.Prénom.CompareTo(i2.Prénom), i1.Nom.CompareTo(i2.Nom)), i1.Région.CompareTo(i2.Région))))
        Ls_Bilan.Items.Clear()
        For i = 0 To inscriptions.Count - 1
            Ls_Bilan.Items.Add(inscriptions(i).région & " " & inscriptions(i).ToString())
        Next i
    End Sub

    Private Sub Bt_Annuler_Click(sender As Object, e As EventArgs) Handles Bt_Annuler.Click, Bt_quitter.Click, MyBase.Closing
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub Bt_Arret_Click(sender As Object, e As EventArgs) Handles Bt_Arret.Click
        sauvegarder()
        quitter()
    End Sub

    Dim draggable As Boolean
    Dim MouseX As Integer
    Dim MouseY As Integer
    Private Sub Pn_Top_MouseDown(sender As Object, e As MouseEventArgs) Handles Pn_Top.MouseDown
        draggable = True
        MouseX = Cursor.Position.X - Me.Left
        MouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Pn_Top_MouseMove(sender As Object, e As MouseEventArgs) Handles Pn_Top.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - MouseY
            Me.Left = Cursor.Position.X - MouseX
        End If
    End Sub

    Private Sub Pn_Top_MouseUp(sender As Object, e As MouseEventArgs) Handles Pn_Top.MouseUp
        draggable = False
    End Sub
    Private Sub Bt_Minimize_Click(sender As Object, e As EventArgs) Handles Bt_Minimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class