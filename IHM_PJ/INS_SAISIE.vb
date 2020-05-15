Public Class INS_SAISIE
    Private Sub INS_SAISIE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
        CodePostal.MaxLength = 5
        Nom.MaxLength = 15
        Prénom.MaxLength = 20
        Adresse.MaxLength = 30
        Ville.MaxLength = 15
        Sb_Age.Minimum = 18
        Sb_Age.Maximum = 55
        Sb_Age.SmallChange = 1
        Sb_Age.LargeChange = 1
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
            Me.Hide()
            'Initialiser INS_EPREUVES
            INS_EPREUVES.Show()
        End If
    End Sub

    Private Sub Bt_AnnulerIns_Click(sender As Object, e As EventArgs) Handles Bt_AnnulerIns.Click
        Me.Hide()
        ACCUEIL.Show()
    End Sub

    Private Sub INS_SAISIE_LostFocus(sender As Object, e As EventArgs) Handles Nom.LostFocus, Prénom.LostFocus, Ville.LostFocus
        If String.IsNullOrEmpty(sender.Text) Then Exit Sub
        Dim tab() As Char = sender.Text
        tab(0) = UCase(tab(0))
        For i As Integer = 1 To tab.Length - 1
            tab(i) = LCase(tab(i))
        Next i
        sender.Text = New String(tab)
    End Sub

    Private Sub INS_SAISIE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CodePostal.KeyPress, CodePostal.KeyPress, Nom.KeyPress, Prénom.KeyPress, Ville.KeyPress
        If e.KeyChar = vbBack Or Char.IsControl(e.KeyChar) Then Exit Sub
        If sender.Equals(CodePostal) Or sender.Equals(Sb_Age) Then
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
End Class