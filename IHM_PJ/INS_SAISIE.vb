Public Class INS_SAISIE
    Private ins As Inscription
    Private modification As Boolean
    Private tempRestant As Integer
    Const TEMPSLIMITE As Integer = 60
    Public Sub initialiser()
        CodePostal.MaxLength = 5
        Nom.MaxLength = 15
        Prénom.MaxLength = 20
        Adresse.MaxLength = 30
        Ville.MaxLength = 15
        Sb_Age.Minimum = 18
        Sb_Age.Maximum = 55
        Sb_Age.SmallChange = 1
        Sb_Age.LargeChange = 1
        TimerSaisie.Interval = 1000
    End Sub

    Public Sub chargerInscription()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
        Sb_Age.Value = 18
        Age.Text = 18
        modification = False
        tempRestant = TEMPSLIMITE
        Me.Text = Me.Text = TimeString & " | Temps restant : " & afficherTempsRestant(tempRestant)
        TimerSaisie.Start()
    End Sub

    Public Sub chargerModification()
        modification = True
        ins = Nothing
    End Sub
    Public Sub chargerModification(inscription As Inscription)
        chargerModification()
        ins = inscription
        Nom.Text = ins.Nom
        Prénom.Text = ins.Prénom
        Adresse.Text = ins.Adresse
        Ville.Text = ins.Ville
        CodePostal.Text = ins.CodePostal
        Sb_Age.Value = ins.Age
        Age.Text = ins.Age
        tempRestant = TEMPSLIMITE
        Me.Text = Me.Text = TimeString & " | Temps restant : " & afficherTempsRestant(tempRestant)
        TimerSaisie.Start()
    End Sub
    Private Sub Bt_ValiderInsSaisie_Click(sender As Object, e As EventArgs) Handles Bt_ValiderInsSaisie.Click
        'Verifier valeurs
        Dim correct As Boolean = True

        If (String.IsNullOrEmpty(Nom.Text)) Then
            Lb_Nom.ForeColor = Color.Red
            Nom.Focus()
            correct = False
        Else
            Lb_Nom.ForeColor = Color.Black
        End If
        If (String.IsNullOrEmpty(Prénom.Text)) Then
            Lb_Prénom.ForeColor = Color.Red
            Prénom.Focus()
            correct = False
        Else
            Lb_Prénom.ForeColor = Color.Black
        End If
        If (String.IsNullOrEmpty(Ville.Text)) Then
            Lb_Ville.ForeColor = Color.Red
            Ville.Focus()
            correct = False
        Else
            Lb_Ville.ForeColor = Color.Black
        End If
        If (String.IsNullOrEmpty(CodePostal.Text) Or CodePostal.Text.Length < 5) Then
            Lb_CodePostal.ForeColor = Color.Red
            CodePostal.Focus()
            correct = False
        Else
            If (CodePostal.Text.Length >= 2) Then
                If (CodePostal.Text.Substring(0, 2) = "00") Then
                    Lb_CodePostal.ForeColor = Color.Red
                    CodePostal.Focus()
                    correct = False
                Else
                    Lb_CodePostal.ForeColor = Color.Black
                End If
            Else
                Lb_CodePostal.ForeColor = Color.Red
                CodePostal.Focus()
                correct = False
            End If
        End If

        If (correct) Then
            TimerSaisie.Stop()
            Me.Hide()
            'Initialiser INS_EPREUVES
            INS_EPREUVES.Lb_NOM.Text = Nom.Text & " " & Prénom.Text
            If (modification) Then
                If (ins IsNot Nothing) Then
                    INS_EPREUVES.chargerModification(ins)
                End If
            Else
                INS_EPREUVES.charger()
            End If
            INS_EPREUVES.Show()
        End If
    End Sub

    Private Sub Bt_AnnulerIns_Click(sender As Object, e As EventArgs) Handles Bt_AbandonnerIns.Click, MyBase.Closing
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub INS_SAISIE_LostFocus(sender As Object, e As EventArgs) Handles Prénom.LostFocus, Ville.LostFocus, Nom.LostFocus
        If String.IsNullOrEmpty(sender.Text) Then Exit Sub
        If (sender.Equals(Prénom)) Then
            Dim tab() As Char = sender.Text
            tab(0) = UCase(tab(0))
            For i As Integer = 1 To tab.Length - 1
                tab(i) = LCase(tab(i))
            Next i
            sender.Text = New String(tab)
        ElseIf (sender.Equals(Nom)) Then
            sender.Text = UCase(sender.Text)
        ElseIf (sender.Equals(Ville)) Then
            Dim tab() As Char = sender.Text
            tab(0) = UCase(tab(0))
            sender.Text = New String(tab)
        End If

    End Sub

    Private Sub INS_SAISIE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CodePostal.KeyPress, CodePostal.KeyPress, Nom.KeyPress, Prénom.KeyPress
        If e.KeyChar = vbBack Or Char.IsControl(e.KeyChar) Then Exit Sub
        If (sender.Equals(CodePostal)) Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        Else
            If Not Char.IsLetter(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Sb_Age_Scroll(sender As Object, e As ScrollEventArgs) Handles Sb_Age.Scroll
        Age.Text = CInt(Sb_Age.Value)
    End Sub

    Private Sub TimerSaisie_Tick(sender As Object, e As EventArgs) Handles TimerSaisie.Tick
        If tempRestant > 0 Then
            tempRestant -= 1
            Me.Text = TimeString & " | Temps restant : " & afficherTempsRestant(tempRestant)
        Else
            TimerSaisie.Stop()
            MessageBox.Show("Temps écoulé!", "Retour à l'Accueil")
            Me.Hide()
            ACCUEIL.Show()
        End If
    End Sub
End Class