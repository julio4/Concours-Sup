''' <summary>
''' Formulaire de saisies des champs d'informations d'une inscription
''' Hélène TE, Jules DOUMECHE, 2020
''' </summary>
Public Class INS_SAISIE
    Private ins As Inscription
    Private modification As Boolean
    Private tempRestant As Integer

    'Initialise les contraintes et les valeurs
    Public Sub initialiser()
        CodePostal.MaxLength = 5
        Nom.MaxLength = 15
        Prénom.MaxLength = 20
        Adresse.MaxLength = 30
        Ville.MaxLength = 15
        Sb_Age.Minimum = AGE_MIN
        Sb_Age.Maximum = AGE_MAX
        Sb_Age.SmallChange = 1
        Sb_Age.LargeChange = 1
        TimerSaisie.Interval = 1000 'Intervalle du timer de 1 seconde
    End Sub

    'Charge le formulaire pour une nouvelle saisie dans le cadre d'une nouvelle inscription
    Public Sub chargerInscription()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
        Sb_Age.Value = AGE_MIN
        Age.Text = AGE_MIN
        modification = False
        lancer_Timer()
        réinitialiser_Champs()
    End Sub

    'Met le formulaire en mode modification (pour un chargement ultérieur d'une inscription)
    Public Sub chargerModification()
        modification = True
        ins = Nothing
    End Sub

    'Charger les données d'une inscription pour une modification
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
        lancer_Timer()
        réinitialiser_Champs()
    End Sub

    'Démarre le timer (durée limite précisée par TEMPS_LIMITE_SAISIE)
    Private Sub lancer_Timer()
        tempRestant = TEMPS_LIMITE_SAISIE
        Titre.Text = TimeString & " | Temps restant : " & afficherTempsRestant(tempRestant)
        TimerSaisie.Start()
    End Sub

    'Réinitialise les champs
    Private Sub réinitialiser_Champs()
        Lb_Nom.ForeColor = Color.Black
        Lb_Prénom.ForeColor = Color.Black
        Lb_Ville.ForeColor = Color.Black
        Lb_Adresse.ForeColor = Color.Black
        Lb_CodePostal.ForeColor = Color.Black
    End Sub

    'Au clic du boutton Valider:
    'Vérification des valeurs saisies
    'Si erreur, affichage en rouge des champs erronés
    'Sinon chargement et affichage du formulaire de choix des matières
    Private Sub Bt_ValiderInsSaisie_Click(sender As Object, e As EventArgs) Handles Bt_ValiderInsSaisie.Click
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
        If (String.IsNullOrEmpty(Adresse.Text)) Then
            Lb_Adresse.ForeColor = Color.Red
            Adresse.Focus()
            correct = False
        Else
            Lb_Adresse.ForeColor = Color.Black
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

    'Au clic du bouton Abandonner
    'Retour à l'accueil
    Private Sub Bt_AnnulerIns_Click(sender As Object, e As EventArgs) Handles Bt_AbandonnerIns.Click, Bt_quitter.Click, MyBase.Closing
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    'Mise en forme automatique des champs (Prénom, Ville: 1ère lettre en majuscule seulement, Nom: tout en majuscule)
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

    'Contraintes de saisie des champs (Nom, Prénom: alphabétique, CodePostal: numérique)
    Private Sub INS_SAISIE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CodePostal.KeyPress, Nom.KeyPress, Prénom.KeyPress
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

    'Scroll de la scrollbar d'âge: Affichage de l'âge
    Private Sub Sb_Age_Scroll(sender As Object, e As ScrollEventArgs) Handles Sb_Age.Scroll
        Age.Text = CInt(Sb_Age.Value)
    End Sub

    'Affichage de l'heure actuelle et du temps restant dans le titre
    Private Sub TimerSaisie_Tick(sender As Object, e As EventArgs) Handles TimerSaisie.Tick
        If tempRestant > 0 Then
            tempRestant -= 1
            Titre.Text = TimeString & " | Temps restant : " & afficherTempsRestant(tempRestant)
        Else
            TimerSaisie.Stop()
            MessageBox.Show("Temps écoulé!", "Retour à l'Accueil")
            Me.Hide()
            ACCUEIL.Show()
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