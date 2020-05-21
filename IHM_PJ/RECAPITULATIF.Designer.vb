<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RECAPITULATIF
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
        Me.Lb_Recap = New System.Windows.Forms.Label()
        Me.Lb_Nom_Donnée = New System.Windows.Forms.Label()
        Me.Lb_Adresse_Donnée = New System.Windows.Forms.Label()
        Me.Lb_CPVille_Donnée = New System.Windows.Forms.Label()
        Me.Gb_InfoCandidat = New System.Windows.Forms.GroupBox()
        Me.Gb_RecapEpreuves = New System.Windows.Forms.GroupBox()
        Me.Ls_oraux = New System.Windows.Forms.ListView()
        Me.Ls_écrits = New System.Windows.Forms.ListView()
        Me.Lb_Région_Donnée = New System.Windows.Forms.Label()
        Me.Lb_Région = New System.Windows.Forms.Label()
        Me.Lb_facultative_donnée = New System.Windows.Forms.Label()
        Me.Lb_facultative = New System.Windows.Forms.Label()
        Me.Lb_Oraux = New System.Windows.Forms.Label()
        Me.Lb_Ecrits = New System.Windows.Forms.Label()
        Me.Bt_Annuler = New System.Windows.Forms.Button()
        Me.Bt_Enregistrer = New System.Windows.Forms.Button()
        Me.Bt_Modifier = New System.Windows.Forms.Button()
        Me.Bt_Supprimer = New System.Windows.Forms.Button()
        Me.Bt_ValiderModification = New System.Windows.Forms.Button()
        Me.Gb_InfoCandidat.SuspendLayout()
        Me.Gb_RecapEpreuves.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_Recap
        '
        Me.Lb_Recap.AutoSize = True
        Me.Lb_Recap.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Recap.Location = New System.Drawing.Point(214, 34)
        Me.Lb_Recap.Name = "Lb_Recap"
        Me.Lb_Recap.Size = New System.Drawing.Size(388, 54)
        Me.Lb_Recap.TabIndex = 0
        Me.Lb_Recap.Text = "RECAPITULATIF"
        '
        'Lb_Nom_Donnée
        '
        Me.Lb_Nom_Donnée.AutoSize = True
        Me.Lb_Nom_Donnée.Location = New System.Drawing.Point(34, 53)
        Me.Lb_Nom_Donnée.Name = "Lb_Nom_Donnée"
        Me.Lb_Nom_Donnée.Size = New System.Drawing.Size(239, 25)
        Me.Lb_Nom_Donnée.TabIndex = 1
        Me.Lb_Nom_Donnée.Text = "NOM PRENOM, AGE ans"
        '
        'Lb_Adresse_Donnée
        '
        Me.Lb_Adresse_Donnée.AutoSize = True
        Me.Lb_Adresse_Donnée.Location = New System.Drawing.Point(34, 88)
        Me.Lb_Adresse_Donnée.Name = "Lb_Adresse_Donnée"
        Me.Lb_Adresse_Donnée.Size = New System.Drawing.Size(107, 25)
        Me.Lb_Adresse_Donnée.TabIndex = 2
        Me.Lb_Adresse_Donnée.Text = "ADRESSE"
        '
        'Lb_CPVille_Donnée
        '
        Me.Lb_CPVille_Donnée.AutoSize = True
        Me.Lb_CPVille_Donnée.Location = New System.Drawing.Point(34, 123)
        Me.Lb_CPVille_Donnée.Name = "Lb_CPVille_Donnée"
        Me.Lb_CPVille_Donnée.Size = New System.Drawing.Size(104, 25)
        Me.Lb_CPVille_Donnée.TabIndex = 3
        Me.Lb_CPVille_Donnée.Text = "CP, VILLE"
        '
        'Gb_InfoCandidat
        '
        Me.Gb_InfoCandidat.Controls.Add(Me.Lb_Nom_Donnée)
        Me.Gb_InfoCandidat.Controls.Add(Me.Lb_CPVille_Donnée)
        Me.Gb_InfoCandidat.Controls.Add(Me.Lb_Adresse_Donnée)
        Me.Gb_InfoCandidat.Location = New System.Drawing.Point(78, 110)
        Me.Gb_InfoCandidat.Name = "Gb_InfoCandidat"
        Me.Gb_InfoCandidat.Size = New System.Drawing.Size(699, 176)
        Me.Gb_InfoCandidat.TabIndex = 4
        Me.Gb_InfoCandidat.TabStop = False
        Me.Gb_InfoCandidat.Text = "Informations du candidat"
        '
        'Gb_RecapEpreuves
        '
        Me.Gb_RecapEpreuves.Controls.Add(Me.Ls_oraux)
        Me.Gb_RecapEpreuves.Controls.Add(Me.Ls_écrits)
        Me.Gb_RecapEpreuves.Controls.Add(Me.Lb_Région_Donnée)
        Me.Gb_RecapEpreuves.Controls.Add(Me.Lb_Région)
        Me.Gb_RecapEpreuves.Controls.Add(Me.Lb_facultative_donnée)
        Me.Gb_RecapEpreuves.Controls.Add(Me.Lb_facultative)
        Me.Gb_RecapEpreuves.Controls.Add(Me.Lb_Oraux)
        Me.Gb_RecapEpreuves.Controls.Add(Me.Lb_Ecrits)
        Me.Gb_RecapEpreuves.Location = New System.Drawing.Point(78, 313)
        Me.Gb_RecapEpreuves.Name = "Gb_RecapEpreuves"
        Me.Gb_RecapEpreuves.Size = New System.Drawing.Size(699, 320)
        Me.Gb_RecapEpreuves.TabIndex = 5
        Me.Gb_RecapEpreuves.TabStop = False
        Me.Gb_RecapEpreuves.Text = "Epreuves sélectionnées"
        '
        'Ls_oraux
        '
        Me.Ls_oraux.BackColor = System.Drawing.SystemColors.Control
        Me.Ls_oraux.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ls_oraux.HideSelection = False
        Me.Ls_oraux.Location = New System.Drawing.Point(362, 114)
        Me.Ls_oraux.Name = "Ls_oraux"
        Me.Ls_oraux.Size = New System.Drawing.Size(236, 140)
        Me.Ls_oraux.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.Ls_oraux.TabIndex = 15
        Me.Ls_oraux.UseCompatibleStateImageBehavior = False
        Me.Ls_oraux.View = System.Windows.Forms.View.SmallIcon
        '
        'Ls_écrits
        '
        Me.Ls_écrits.BackColor = System.Drawing.SystemColors.Control
        Me.Ls_écrits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ls_écrits.HideSelection = False
        Me.Ls_écrits.Location = New System.Drawing.Point(48, 121)
        Me.Ls_écrits.Name = "Ls_écrits"
        Me.Ls_écrits.Size = New System.Drawing.Size(236, 173)
        Me.Ls_écrits.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.Ls_écrits.TabIndex = 14
        Me.Ls_écrits.UseCompatibleStateImageBehavior = False
        Me.Ls_écrits.View = System.Windows.Forms.View.List
        '
        'Lb_Région_Donnée
        '
        Me.Lb_Région_Donnée.AutoSize = True
        Me.Lb_Région_Donnée.Location = New System.Drawing.Point(322, 36)
        Me.Lb_Région_Donnée.Name = "Lb_Région_Donnée"
        Me.Lb_Région_Donnée.Size = New System.Drawing.Size(88, 25)
        Me.Lb_Région_Donnée.TabIndex = 13
        Me.Lb_Région_Donnée.Text = "REGION"
        '
        'Lb_Région
        '
        Me.Lb_Région.AutoSize = True
        Me.Lb_Région.Location = New System.Drawing.Point(175, 36)
        Me.Lb_Région.Name = "Lb_Région"
        Me.Lb_Région.Size = New System.Drawing.Size(150, 25)
        Me.Lb_Région.TabIndex = 12
        Me.Lb_Région.Text = "Région choisie :"
        '
        'Lb_facultative_donnée
        '
        Me.Lb_facultative_donnée.AutoSize = True
        Me.Lb_facultative_donnée.Location = New System.Drawing.Point(436, 269)
        Me.Lb_facultative_donnée.Name = "Lb_facultative_donnée"
        Me.Lb_facultative_donnée.Size = New System.Drawing.Size(135, 25)
        Me.Lb_facultative_donnée.TabIndex = 11
        Me.Lb_facultative_donnée.Text = "FACULTATIF"
        '
        'Lb_facultative
        '
        Me.Lb_facultative.AutoSize = True
        Me.Lb_facultative.Location = New System.Drawing.Point(313, 269)
        Me.Lb_facultative.Name = "Lb_facultative"
        Me.Lb_facultative.Size = New System.Drawing.Size(117, 25)
        Me.Lb_facultative.TabIndex = 10
        Me.Lb_facultative.Text = "Facultative :"
        '
        'Lb_Oraux
        '
        Me.Lb_Oraux.AutoSize = True
        Me.Lb_Oraux.Location = New System.Drawing.Point(449, 86)
        Me.Lb_Oraux.Name = "Lb_Oraux"
        Me.Lb_Oraux.Size = New System.Drawing.Size(66, 25)
        Me.Lb_Oraux.TabIndex = 1
        Me.Lb_Oraux.Text = "Oraux"
        '
        'Lb_Ecrits
        '
        Me.Lb_Ecrits.AutoSize = True
        Me.Lb_Ecrits.Location = New System.Drawing.Point(140, 86)
        Me.Lb_Ecrits.Name = "Lb_Ecrits"
        Me.Lb_Ecrits.Size = New System.Drawing.Size(60, 25)
        Me.Lb_Ecrits.TabIndex = 0
        Me.Lb_Ecrits.Text = "Ecrits"
        '
        'Bt_Annuler
        '
        Me.Bt_Annuler.Location = New System.Drawing.Point(189, 642)
        Me.Bt_Annuler.Name = "Bt_Annuler"
        Me.Bt_Annuler.Size = New System.Drawing.Size(144, 54)
        Me.Bt_Annuler.TabIndex = 6
        Me.Bt_Annuler.Text = "Annuler"
        Me.Bt_Annuler.UseVisualStyleBackColor = True
        '
        'Bt_Enregistrer
        '
        Me.Bt_Enregistrer.Location = New System.Drawing.Point(349, 642)
        Me.Bt_Enregistrer.Name = "Bt_Enregistrer"
        Me.Bt_Enregistrer.Size = New System.Drawing.Size(144, 54)
        Me.Bt_Enregistrer.TabIndex = 7
        Me.Bt_Enregistrer.Text = "Enregistrer"
        Me.Bt_Enregistrer.UseVisualStyleBackColor = True
        '
        'Bt_Modifier
        '
        Me.Bt_Modifier.Location = New System.Drawing.Point(505, 642)
        Me.Bt_Modifier.Name = "Bt_Modifier"
        Me.Bt_Modifier.Size = New System.Drawing.Size(144, 54)
        Me.Bt_Modifier.TabIndex = 8
        Me.Bt_Modifier.Text = "Modifier"
        Me.Bt_Modifier.UseVisualStyleBackColor = True
        '
        'Bt_Supprimer
        '
        Me.Bt_Supprimer.Location = New System.Drawing.Point(349, 642)
        Me.Bt_Supprimer.Name = "Bt_Supprimer"
        Me.Bt_Supprimer.Size = New System.Drawing.Size(300, 54)
        Me.Bt_Supprimer.TabIndex = 9
        Me.Bt_Supprimer.Text = "Supprimer"
        Me.Bt_Supprimer.UseVisualStyleBackColor = True
        '
        'Bt_ValiderModification
        '
        Me.Bt_ValiderModification.Location = New System.Drawing.Point(349, 642)
        Me.Bt_ValiderModification.Name = "Bt_ValiderModification"
        Me.Bt_ValiderModification.Size = New System.Drawing.Size(300, 54)
        Me.Bt_ValiderModification.TabIndex = 10
        Me.Bt_ValiderModification.Text = "Modifier"
        Me.Bt_ValiderModification.UseVisualStyleBackColor = True
        '
        'RECAPITULATIF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 713)
        Me.Controls.Add(Me.Bt_ValiderModification)
        Me.Controls.Add(Me.Bt_Supprimer)
        Me.Controls.Add(Me.Bt_Modifier)
        Me.Controls.Add(Me.Bt_Enregistrer)
        Me.Controls.Add(Me.Bt_Annuler)
        Me.Controls.Add(Me.Gb_RecapEpreuves)
        Me.Controls.Add(Me.Gb_InfoCandidat)
        Me.Controls.Add(Me.Lb_Recap)
        Me.Name = "RECAPITULATIF"
        Me.Text = "RECAPITULATIF"
        Me.Gb_InfoCandidat.ResumeLayout(False)
        Me.Gb_InfoCandidat.PerformLayout()
        Me.Gb_RecapEpreuves.ResumeLayout(False)
        Me.Gb_RecapEpreuves.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_Recap As Label
    Friend WithEvents Lb_Nom_Donnée As Label
    Friend WithEvents Lb_Adresse_Donnée As Label
    Friend WithEvents Lb_CPVille_Donnée As Label
    Friend WithEvents Gb_InfoCandidat As GroupBox
    Friend WithEvents Gb_RecapEpreuves As GroupBox
    Friend WithEvents Lb_facultative_donnée As Label
    Friend WithEvents Lb_facultative As Label
    Friend WithEvents Lb_Oraux As Label
    Friend WithEvents Lb_Ecrits As Label
    Friend WithEvents Lb_Région_Donnée As Label
    Friend WithEvents Lb_Région As Label
    Friend WithEvents Bt_Annuler As Button
    Friend WithEvents Bt_Enregistrer As Button
    Friend WithEvents Bt_Modifier As Button
    Friend WithEvents Bt_Supprimer As Button
    Friend WithEvents Bt_ValiderModification As Button
    Friend WithEvents Ls_écrits As ListView
    Friend WithEvents Ls_oraux As ListView
End Class
