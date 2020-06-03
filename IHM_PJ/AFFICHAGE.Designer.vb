<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AFFICHAGE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lb_Num = New System.Windows.Forms.ListBox()
        Me.Lb_Nom = New System.Windows.Forms.ListBox()
        Me.Lb_Prenom = New System.Windows.Forms.ListBox()
        Me.Lb_Ecrits = New System.Windows.Forms.ListBox()
        Me.Lb_Oraux = New System.Windows.Forms.ListBox()
        Me.Lb_Facultative = New System.Windows.Forms.ListBox()
        Me.Bt_Retour = New System.Windows.Forms.Button()
        Me.Lb_Num1 = New System.Windows.Forms.Label()
        Me.Lb_nom1 = New System.Windows.Forms.Label()
        Me.Lb_prénom1 = New System.Windows.Forms.Label()
        Me.Lb_écrits1 = New System.Windows.Forms.Label()
        Me.Lb_Orales1 = New System.Windows.Forms.Label()
        Me.Lb_facultative1 = New System.Windows.Forms.Label()
        Me.Bt_Fin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lb_Num
        '
        Me.Lb_Num.FormattingEnabled = True
        Me.Lb_Num.ItemHeight = 24
        Me.Lb_Num.Location = New System.Drawing.Point(35, 60)
        Me.Lb_Num.Name = "Lb_Num"
        Me.Lb_Num.Size = New System.Drawing.Size(96, 364)
        Me.Lb_Num.TabIndex = 0
        '
        'Lb_Nom
        '
        Me.Lb_Nom.FormattingEnabled = True
        Me.Lb_Nom.ItemHeight = 24
        Me.Lb_Nom.Location = New System.Drawing.Point(160, 60)
        Me.Lb_Nom.Name = "Lb_Nom"
        Me.Lb_Nom.Size = New System.Drawing.Size(160, 364)
        Me.Lb_Nom.TabIndex = 1
        '
        'Lb_Prenom
        '
        Me.Lb_Prenom.FormattingEnabled = True
        Me.Lb_Prenom.ItemHeight = 24
        Me.Lb_Prenom.Location = New System.Drawing.Point(349, 60)
        Me.Lb_Prenom.Name = "Lb_Prenom"
        Me.Lb_Prenom.Size = New System.Drawing.Size(160, 364)
        Me.Lb_Prenom.TabIndex = 2
        '
        'Lb_Ecrits
        '
        Me.Lb_Ecrits.FormattingEnabled = True
        Me.Lb_Ecrits.ItemHeight = 24
        Me.Lb_Ecrits.Location = New System.Drawing.Point(540, 60)
        Me.Lb_Ecrits.Name = "Lb_Ecrits"
        Me.Lb_Ecrits.Size = New System.Drawing.Size(195, 124)
        Me.Lb_Ecrits.TabIndex = 3
        '
        'Lb_Oraux
        '
        Me.Lb_Oraux.FormattingEnabled = True
        Me.Lb_Oraux.ItemHeight = 24
        Me.Lb_Oraux.Location = New System.Drawing.Point(540, 228)
        Me.Lb_Oraux.Name = "Lb_Oraux"
        Me.Lb_Oraux.Size = New System.Drawing.Size(195, 100)
        Me.Lb_Oraux.TabIndex = 4
        '
        'Lb_Facultative
        '
        Me.Lb_Facultative.FormattingEnabled = True
        Me.Lb_Facultative.ItemHeight = 24
        Me.Lb_Facultative.Location = New System.Drawing.Point(540, 372)
        Me.Lb_Facultative.Name = "Lb_Facultative"
        Me.Lb_Facultative.Size = New System.Drawing.Size(195, 52)
        Me.Lb_Facultative.TabIndex = 5
        '
        'Bt_Retour
        '
        Me.Bt_Retour.Location = New System.Drawing.Point(252, 445)
        Me.Bt_Retour.Name = "Bt_Retour"
        Me.Bt_Retour.Size = New System.Drawing.Size(239, 38)
        Me.Bt_Retour.TabIndex = 6
        Me.Bt_Retour.Text = "Retour"
        Me.Bt_Retour.UseVisualStyleBackColor = True
        '
        'Lb_Num1
        '
        Me.Lb_Num1.AutoSize = True
        Me.Lb_Num1.Location = New System.Drawing.Point(43, 20)
        Me.Lb_Num1.Name = "Lb_Num1"
        Me.Lb_Num1.Size = New System.Drawing.Size(81, 25)
        Me.Lb_Num1.TabIndex = 7
        Me.Lb_Num1.Text = "Numéro"
        '
        'Lb_nom1
        '
        Me.Lb_nom1.AutoSize = True
        Me.Lb_nom1.Location = New System.Drawing.Point(206, 20)
        Me.Lb_nom1.Name = "Lb_nom1"
        Me.Lb_nom1.Size = New System.Drawing.Size(53, 25)
        Me.Lb_nom1.TabIndex = 8
        Me.Lb_nom1.Text = "Nom"
        '
        'Lb_prénom1
        '
        Me.Lb_prénom1.AutoSize = True
        Me.Lb_prénom1.Location = New System.Drawing.Point(385, 20)
        Me.Lb_prénom1.Name = "Lb_prénom1"
        Me.Lb_prénom1.Size = New System.Drawing.Size(80, 25)
        Me.Lb_prénom1.TabIndex = 9
        Me.Lb_prénom1.Text = "Prénom"
        '
        'Lb_écrits1
        '
        Me.Lb_écrits1.AutoSize = True
        Me.Lb_écrits1.Location = New System.Drawing.Point(555, 20)
        Me.Lb_écrits1.Name = "Lb_écrits1"
        Me.Lb_écrits1.Size = New System.Drawing.Size(157, 25)
        Me.Lb_écrits1.TabIndex = 10
        Me.Lb_écrits1.Text = "Epreuves écrites"
        '
        'Lb_Orales1
        '
        Me.Lb_Orales1.AutoSize = True
        Me.Lb_Orales1.Location = New System.Drawing.Point(559, 194)
        Me.Lb_Orales1.Name = "Lb_Orales1"
        Me.Lb_Orales1.Size = New System.Drawing.Size(153, 25)
        Me.Lb_Orales1.TabIndex = 11
        Me.Lb_Orales1.Text = "Epreuves orales"
        '
        'Lb_facultative1
        '
        Me.Lb_facultative1.AutoSize = True
        Me.Lb_facultative1.Location = New System.Drawing.Point(552, 338)
        Me.Lb_facultative1.Name = "Lb_facultative1"
        Me.Lb_facultative1.Size = New System.Drawing.Size(177, 25)
        Me.Lb_facultative1.TabIndex = 12
        Me.Lb_facultative1.Text = "Epreuve facultative"
        '
        'Bt_Fin
        '
        Me.Bt_Fin.Location = New System.Drawing.Point(508, 445)
        Me.Bt_Fin.Name = "Bt_Fin"
        Me.Bt_Fin.Size = New System.Drawing.Size(227, 38)
        Me.Bt_Fin.TabIndex = 13
        Me.Bt_Fin.Text = "Cloturer les inscriptions"
        Me.Bt_Fin.UseVisualStyleBackColor = True
        '
        'AFFICHAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 506)
        Me.Controls.Add(Me.Bt_Fin)
        Me.Controls.Add(Me.Lb_facultative1)
        Me.Controls.Add(Me.Lb_Orales1)
        Me.Controls.Add(Me.Lb_écrits1)
        Me.Controls.Add(Me.Lb_prénom1)
        Me.Controls.Add(Me.Lb_nom1)
        Me.Controls.Add(Me.Lb_Num1)
        Me.Controls.Add(Me.Bt_Retour)
        Me.Controls.Add(Me.Lb_Facultative)
        Me.Controls.Add(Me.Lb_Oraux)
        Me.Controls.Add(Me.Lb_Ecrits)
        Me.Controls.Add(Me.Lb_Prenom)
        Me.Controls.Add(Me.Lb_Nom)
        Me.Controls.Add(Me.Lb_Num)
        Me.Name = "AFFICHAGE"
        Me.Text = "AFFICHAGE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_Num As ListBox
    Friend WithEvents Lb_Nom As ListBox
    Friend WithEvents Lb_Prenom As ListBox
    Friend WithEvents Lb_Ecrits As ListBox
    Friend WithEvents Lb_Oraux As ListBox
    Friend WithEvents Lb_Facultative As ListBox
    Friend WithEvents Bt_Retour As Button
    Friend WithEvents Lb_Num1 As Label
    Friend WithEvents Lb_nom1 As Label
    Friend WithEvents Lb_prénom1 As Label
    Friend WithEvents Lb_écrits1 As Label
    Friend WithEvents Lb_Orales1 As Label
    Friend WithEvents Lb_facultative1 As Label
    Friend WithEvents Bt_Fin As Button
End Class
