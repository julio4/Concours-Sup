<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INS_SAISIE
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
        Me.components = New System.ComponentModel.Container()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Prénom = New System.Windows.Forms.TextBox()
        Me.Adresse = New System.Windows.Forms.TextBox()
        Me.CodePostal = New System.Windows.Forms.TextBox()
        Me.Ville = New System.Windows.Forms.TextBox()
        Me.Lb_Nom = New System.Windows.Forms.Label()
        Me.Lb_Prénom = New System.Windows.Forms.Label()
        Me.Lb_Adresse = New System.Windows.Forms.Label()
        Me.Lb_CodePostal = New System.Windows.Forms.Label()
        Me.Lb_Ville = New System.Windows.Forms.Label()
        Me.Lb_Age = New System.Windows.Forms.Label()
        Me.Bt_ValiderInsSaisie = New System.Windows.Forms.Button()
        Me.Bt_AbandonnerIns = New System.Windows.Forms.Button()
        Me.Sb_Age = New System.Windows.Forms.HScrollBar()
        Me.Age = New System.Windows.Forms.Label()
        Me.TimerSaisie = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Nom
        '
        Me.Nom.ForeColor = System.Drawing.Color.Black
        Me.Nom.Location = New System.Drawing.Point(156, 22)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(341, 29)
        Me.Nom.TabIndex = 0
        '
        'Prénom
        '
        Me.Prénom.Location = New System.Drawing.Point(156, 78)
        Me.Prénom.Name = "Prénom"
        Me.Prénom.Size = New System.Drawing.Size(341, 29)
        Me.Prénom.TabIndex = 1
        '
        'Adresse
        '
        Me.Adresse.Location = New System.Drawing.Point(156, 134)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(341, 29)
        Me.Adresse.TabIndex = 2
        '
        'CodePostal
        '
        Me.CodePostal.Location = New System.Drawing.Point(156, 190)
        Me.CodePostal.Name = "CodePostal"
        Me.CodePostal.Size = New System.Drawing.Size(341, 29)
        Me.CodePostal.TabIndex = 3
        '
        'Ville
        '
        Me.Ville.Location = New System.Drawing.Point(156, 246)
        Me.Ville.Name = "Ville"
        Me.Ville.Size = New System.Drawing.Size(341, 29)
        Me.Ville.TabIndex = 4
        '
        'Lb_Nom
        '
        Me.Lb_Nom.AutoSize = True
        Me.Lb_Nom.Location = New System.Drawing.Point(29, 22)
        Me.Lb_Nom.Name = "Lb_Nom"
        Me.Lb_Nom.Size = New System.Drawing.Size(53, 25)
        Me.Lb_Nom.TabIndex = 6
        Me.Lb_Nom.Text = "Nom"
        '
        'Lb_Prénom
        '
        Me.Lb_Prénom.AutoSize = True
        Me.Lb_Prénom.Location = New System.Drawing.Point(29, 78)
        Me.Lb_Prénom.Name = "Lb_Prénom"
        Me.Lb_Prénom.Size = New System.Drawing.Size(80, 25)
        Me.Lb_Prénom.TabIndex = 7
        Me.Lb_Prénom.Text = "Prénom"
        '
        'Lb_Adresse
        '
        Me.Lb_Adresse.AutoSize = True
        Me.Lb_Adresse.Location = New System.Drawing.Point(29, 134)
        Me.Lb_Adresse.Name = "Lb_Adresse"
        Me.Lb_Adresse.Size = New System.Drawing.Size(85, 25)
        Me.Lb_Adresse.TabIndex = 8
        Me.Lb_Adresse.Text = "Adresse"
        '
        'Lb_CodePostal
        '
        Me.Lb_CodePostal.AutoSize = True
        Me.Lb_CodePostal.Location = New System.Drawing.Point(29, 190)
        Me.Lb_CodePostal.Name = "Lb_CodePostal"
        Me.Lb_CodePostal.Size = New System.Drawing.Size(119, 25)
        Me.Lb_CodePostal.TabIndex = 9
        Me.Lb_CodePostal.Text = "Code Postal"
        '
        'Lb_Ville
        '
        Me.Lb_Ville.AutoSize = True
        Me.Lb_Ville.Location = New System.Drawing.Point(29, 246)
        Me.Lb_Ville.Name = "Lb_Ville"
        Me.Lb_Ville.Size = New System.Drawing.Size(49, 25)
        Me.Lb_Ville.TabIndex = 10
        Me.Lb_Ville.Text = "Ville"
        '
        'Lb_Age
        '
        Me.Lb_Age.AutoSize = True
        Me.Lb_Age.Location = New System.Drawing.Point(29, 302)
        Me.Lb_Age.Name = "Lb_Age"
        Me.Lb_Age.Size = New System.Drawing.Size(48, 25)
        Me.Lb_Age.TabIndex = 11
        Me.Lb_Age.Text = "Age"
        '
        'Bt_ValiderInsSaisie
        '
        Me.Bt_ValiderInsSaisie.Location = New System.Drawing.Point(549, 74)
        Me.Bt_ValiderInsSaisie.Name = "Bt_ValiderInsSaisie"
        Me.Bt_ValiderInsSaisie.Size = New System.Drawing.Size(239, 85)
        Me.Bt_ValiderInsSaisie.TabIndex = 12
        Me.Bt_ValiderInsSaisie.Text = "Valider"
        Me.Bt_ValiderInsSaisie.UseVisualStyleBackColor = True
        '
        'Bt_AbandonnerIns
        '
        Me.Bt_AbandonnerIns.Location = New System.Drawing.Point(575, 190)
        Me.Bt_AbandonnerIns.Name = "Bt_AbandonnerIns"
        Me.Bt_AbandonnerIns.Size = New System.Drawing.Size(189, 43)
        Me.Bt_AbandonnerIns.TabIndex = 13
        Me.Bt_AbandonnerIns.Text = "Abandonner"
        Me.Bt_AbandonnerIns.UseVisualStyleBackColor = True
        '
        'Sb_Age
        '
        Me.Sb_Age.Location = New System.Drawing.Point(211, 302)
        Me.Sb_Age.Name = "Sb_Age"
        Me.Sb_Age.Size = New System.Drawing.Size(286, 25)
        Me.Sb_Age.TabIndex = 14
        '
        'Age
        '
        Me.Age.AutoSize = True
        Me.Age.Location = New System.Drawing.Point(156, 302)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(34, 25)
        Me.Age.TabIndex = 15
        Me.Age.Text = "18"
        '
        'TimerSaisie
        '
        '
        'INS_SAISIE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 384)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.Sb_Age)
        Me.Controls.Add(Me.Bt_AbandonnerIns)
        Me.Controls.Add(Me.Bt_ValiderInsSaisie)
        Me.Controls.Add(Me.Lb_Age)
        Me.Controls.Add(Me.Lb_Ville)
        Me.Controls.Add(Me.Lb_CodePostal)
        Me.Controls.Add(Me.Lb_Adresse)
        Me.Controls.Add(Me.Lb_Prénom)
        Me.Controls.Add(Me.Lb_Nom)
        Me.Controls.Add(Me.Ville)
        Me.Controls.Add(Me.CodePostal)
        Me.Controls.Add(Me.Adresse)
        Me.Controls.Add(Me.Prénom)
        Me.Controls.Add(Me.Nom)
        Me.Name = "INS_SAISIE"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nom As TextBox
    Friend WithEvents Prénom As TextBox
    Friend WithEvents Adresse As TextBox
    Friend WithEvents CodePostal As TextBox
    Friend WithEvents Ville As TextBox
    Friend WithEvents Lb_Nom As Label
    Friend WithEvents Lb_Prénom As Label
    Friend WithEvents Lb_Adresse As Label
    Friend WithEvents Lb_CodePostal As Label
    Friend WithEvents Lb_Ville As Label
    Friend WithEvents Lb_Age As Label
    Friend WithEvents Bt_ValiderInsSaisie As Button
    Friend WithEvents Bt_AbandonnerIns As Button
    Friend WithEvents Sb_Age As HScrollBar
    Friend WithEvents Age As Label
    Friend WithEvents TimerSaisie As Timer
End Class
