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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RECAPITULATIF))
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
        Me.Bt_Arret = New System.Windows.Forms.Button()
        Me.Pn_Top = New System.Windows.Forms.Panel()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Bt_quitter = New System.Windows.Forms.Button()
        Me.Bt_Minimize = New System.Windows.Forms.Button()
        Me.Gb_InfoCandidat.SuspendLayout()
        Me.Gb_RecapEpreuves.SuspendLayout()
        Me.Pn_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_Recap
        '
        Me.Lb_Recap.AutoSize = True
        Me.Lb_Recap.Font = New System.Drawing.Font("Euclid Circular A Medium", 20.14286!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Recap.Location = New System.Drawing.Point(231, 74)
        Me.Lb_Recap.Name = "Lb_Recap"
        Me.Lb_Recap.Size = New System.Drawing.Size(398, 61)
        Me.Lb_Recap.TabIndex = 0
        Me.Lb_Recap.Text = "RECAPITULATIF"
        '
        'Lb_Nom_Donnée
        '
        Me.Lb_Nom_Donnée.AutoSize = True
        Me.Lb_Nom_Donnée.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Nom_Donnée.Location = New System.Drawing.Point(34, 56)
        Me.Lb_Nom_Donnée.Name = "Lb_Nom_Donnée"
        Me.Lb_Nom_Donnée.Size = New System.Drawing.Size(244, 25)
        Me.Lb_Nom_Donnée.TabIndex = 1
        Me.Lb_Nom_Donnée.Text = "NOM PRENOM, AGE ans"
        '
        'Lb_Adresse_Donnée
        '
        Me.Lb_Adresse_Donnée.AutoSize = True
        Me.Lb_Adresse_Donnée.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Adresse_Donnée.Location = New System.Drawing.Point(34, 96)
        Me.Lb_Adresse_Donnée.Name = "Lb_Adresse_Donnée"
        Me.Lb_Adresse_Donnée.Size = New System.Drawing.Size(97, 25)
        Me.Lb_Adresse_Donnée.TabIndex = 2
        Me.Lb_Adresse_Donnée.Text = "ADRESSE"
        '
        'Lb_CPVille_Donnée
        '
        Me.Lb_CPVille_Donnée.AutoSize = True
        Me.Lb_CPVille_Donnée.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_CPVille_Donnée.Location = New System.Drawing.Point(34, 136)
        Me.Lb_CPVille_Donnée.Name = "Lb_CPVille_Donnée"
        Me.Lb_CPVille_Donnée.Size = New System.Drawing.Size(100, 25)
        Me.Lb_CPVille_Donnée.TabIndex = 3
        Me.Lb_CPVille_Donnée.Text = "CP, VILLE"
        '
        'Gb_InfoCandidat
        '
        Me.Gb_InfoCandidat.Controls.Add(Me.Lb_Nom_Donnée)
        Me.Gb_InfoCandidat.Controls.Add(Me.Lb_CPVille_Donnée)
        Me.Gb_InfoCandidat.Controls.Add(Me.Lb_Adresse_Donnée)
        Me.Gb_InfoCandidat.Font = New System.Drawing.Font("Euclid Circular A", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_InfoCandidat.Location = New System.Drawing.Point(78, 150)
        Me.Gb_InfoCandidat.Name = "Gb_InfoCandidat"
        Me.Gb_InfoCandidat.Size = New System.Drawing.Size(699, 191)
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
        Me.Gb_RecapEpreuves.Font = New System.Drawing.Font("Euclid Circular A", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_RecapEpreuves.Location = New System.Drawing.Point(78, 363)
        Me.Gb_RecapEpreuves.Name = "Gb_RecapEpreuves"
        Me.Gb_RecapEpreuves.Size = New System.Drawing.Size(699, 357)
        Me.Gb_RecapEpreuves.TabIndex = 5
        Me.Gb_RecapEpreuves.TabStop = False
        Me.Gb_RecapEpreuves.Text = "Epreuves sélectionnées"
        '
        'Ls_oraux
        '
        Me.Ls_oraux.BackColor = System.Drawing.Color.White
        Me.Ls_oraux.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ls_oraux.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ls_oraux.HideSelection = False
        Me.Ls_oraux.Location = New System.Drawing.Point(362, 147)
        Me.Ls_oraux.Name = "Ls_oraux"
        Me.Ls_oraux.Size = New System.Drawing.Size(236, 140)
        Me.Ls_oraux.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.Ls_oraux.TabIndex = 15
        Me.Ls_oraux.UseCompatibleStateImageBehavior = False
        Me.Ls_oraux.View = System.Windows.Forms.View.SmallIcon
        '
        'Ls_écrits
        '
        Me.Ls_écrits.BackColor = System.Drawing.Color.White
        Me.Ls_écrits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ls_écrits.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ls_écrits.HideSelection = False
        Me.Ls_écrits.Location = New System.Drawing.Point(48, 154)
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
        Me.Lb_Région_Donnée.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Région_Donnée.Location = New System.Drawing.Point(164, 56)
        Me.Lb_Région_Donnée.Name = "Lb_Région_Donnée"
        Me.Lb_Région_Donnée.Size = New System.Drawing.Size(91, 25)
        Me.Lb_Région_Donnée.TabIndex = 13
        Me.Lb_Région_Donnée.Text = "REGION"
        '
        'Lb_Région
        '
        Me.Lb_Région.AutoSize = True
        Me.Lb_Région.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Région.Location = New System.Drawing.Point(17, 56)
        Me.Lb_Région.Name = "Lb_Région"
        Me.Lb_Région.Size = New System.Drawing.Size(161, 25)
        Me.Lb_Région.TabIndex = 12
        Me.Lb_Région.Text = "Région choisie :"
        '
        'Lb_facultative_donnée
        '
        Me.Lb_facultative_donnée.AutoSize = True
        Me.Lb_facultative_donnée.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_facultative_donnée.Location = New System.Drawing.Point(480, 302)
        Me.Lb_facultative_donnée.Name = "Lb_facultative_donnée"
        Me.Lb_facultative_donnée.Size = New System.Drawing.Size(127, 25)
        Me.Lb_facultative_donnée.TabIndex = 11
        Me.Lb_facultative_donnée.Text = "FACULTATIF"
        '
        'Lb_facultative
        '
        Me.Lb_facultative.AutoSize = True
        Me.Lb_facultative.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_facultative.Location = New System.Drawing.Point(357, 302)
        Me.Lb_facultative.Name = "Lb_facultative"
        Me.Lb_facultative.Size = New System.Drawing.Size(131, 25)
        Me.Lb_facultative.TabIndex = 10
        Me.Lb_facultative.Text = "Facultative :"
        '
        'Lb_Oraux
        '
        Me.Lb_Oraux.AutoSize = True
        Me.Lb_Oraux.Font = New System.Drawing.Font("Euclid Circular A", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Oraux.Location = New System.Drawing.Point(357, 100)
        Me.Lb_Oraux.Name = "Lb_Oraux"
        Me.Lb_Oraux.Size = New System.Drawing.Size(84, 30)
        Me.Lb_Oraux.TabIndex = 1
        Me.Lb_Oraux.Text = "Oraux"
        '
        'Lb_Ecrits
        '
        Me.Lb_Ecrits.AutoSize = True
        Me.Lb_Ecrits.Font = New System.Drawing.Font("Euclid Circular A", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Ecrits.Location = New System.Drawing.Point(43, 100)
        Me.Lb_Ecrits.Name = "Lb_Ecrits"
        Me.Lb_Ecrits.Size = New System.Drawing.Size(75, 30)
        Me.Lb_Ecrits.TabIndex = 0
        Me.Lb_Ecrits.Text = "Ecrits"
        '
        'Bt_Annuler
        '
        Me.Bt_Annuler.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_Annuler.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_Annuler.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Annuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Annuler.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Annuler.Location = New System.Drawing.Point(189, 738)
        Me.Bt_Annuler.Name = "Bt_Annuler"
        Me.Bt_Annuler.Size = New System.Drawing.Size(144, 54)
        Me.Bt_Annuler.TabIndex = 6
        Me.Bt_Annuler.Text = "Annuler"
        Me.Bt_Annuler.UseVisualStyleBackColor = False
        '
        'Bt_Enregistrer
        '
        Me.Bt_Enregistrer.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_Enregistrer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_Enregistrer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Enregistrer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Enregistrer.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Enregistrer.Location = New System.Drawing.Point(349, 738)
        Me.Bt_Enregistrer.Name = "Bt_Enregistrer"
        Me.Bt_Enregistrer.Size = New System.Drawing.Size(144, 54)
        Me.Bt_Enregistrer.TabIndex = 7
        Me.Bt_Enregistrer.Text = "Enregistrer"
        Me.Bt_Enregistrer.UseVisualStyleBackColor = False
        '
        'Bt_Modifier
        '
        Me.Bt_Modifier.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_Modifier.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_Modifier.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Modifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Modifier.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Modifier.Location = New System.Drawing.Point(505, 738)
        Me.Bt_Modifier.Name = "Bt_Modifier"
        Me.Bt_Modifier.Size = New System.Drawing.Size(144, 54)
        Me.Bt_Modifier.TabIndex = 8
        Me.Bt_Modifier.Text = "Modifier"
        Me.Bt_Modifier.UseVisualStyleBackColor = False
        '
        'Bt_Supprimer
        '
        Me.Bt_Supprimer.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_Supprimer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_Supprimer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Supprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Supprimer.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Supprimer.Location = New System.Drawing.Point(349, 738)
        Me.Bt_Supprimer.Name = "Bt_Supprimer"
        Me.Bt_Supprimer.Size = New System.Drawing.Size(300, 54)
        Me.Bt_Supprimer.TabIndex = 9
        Me.Bt_Supprimer.Text = "Supprimer"
        Me.Bt_Supprimer.UseVisualStyleBackColor = False
        '
        'Bt_ValiderModification
        '
        Me.Bt_ValiderModification.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_ValiderModification.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_ValiderModification.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_ValiderModification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_ValiderModification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_ValiderModification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_ValiderModification.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_ValiderModification.Location = New System.Drawing.Point(349, 738)
        Me.Bt_ValiderModification.Name = "Bt_ValiderModification"
        Me.Bt_ValiderModification.Size = New System.Drawing.Size(300, 54)
        Me.Bt_ValiderModification.TabIndex = 10
        Me.Bt_ValiderModification.Text = "Modifier"
        Me.Bt_ValiderModification.UseVisualStyleBackColor = False
        '
        'Bt_Arret
        '
        Me.Bt_Arret.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_Arret.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_Arret.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Arret.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Arret.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Arret.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Arret.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Arret.Location = New System.Drawing.Point(349, 738)
        Me.Bt_Arret.Name = "Bt_Arret"
        Me.Bt_Arret.Size = New System.Drawing.Size(300, 54)
        Me.Bt_Arret.TabIndex = 11
        Me.Bt_Arret.Text = "Arrêter l'Application"
        Me.Bt_Arret.UseVisualStyleBackColor = False
        '
        'Pn_Top
        '
        Me.Pn_Top.BackgroundImage = Global.IHM_PJ.My.Resources.Resources.Capture
        Me.Pn_Top.Controls.Add(Me.Titre)
        Me.Pn_Top.Controls.Add(Me.Bt_quitter)
        Me.Pn_Top.Controls.Add(Me.Bt_Minimize)
        Me.Pn_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_Top.Location = New System.Drawing.Point(0, 0)
        Me.Pn_Top.Name = "Pn_Top"
        Me.Pn_Top.Size = New System.Drawing.Size(857, 50)
        Me.Pn_Top.TabIndex = 12
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.BackColor = System.Drawing.Color.Transparent
        Me.Titre.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.ForeColor = System.Drawing.Color.White
        Me.Titre.Location = New System.Drawing.Point(12, 14)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(73, 25)
        Me.Titre.TabIndex = 16
        Me.Titre.Text = "Label1"
        '
        'Bt_quitter
        '
        Me.Bt_quitter.BackColor = System.Drawing.Color.Transparent
        Me.Bt_quitter.BackgroundImage = Global.IHM_PJ.My.Resources.Resources.closeWhite
        Me.Bt_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_quitter.FlatAppearance.BorderSize = 0
        Me.Bt_quitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Bt_quitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Bt_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_quitter.Location = New System.Drawing.Point(802, 12)
        Me.Bt_quitter.Name = "Bt_quitter"
        Me.Bt_quitter.Size = New System.Drawing.Size(43, 29)
        Me.Bt_quitter.TabIndex = 15
        Me.Bt_quitter.UseVisualStyleBackColor = False
        '
        'Bt_Minimize
        '
        Me.Bt_Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Minimize.BackgroundImage = Global.IHM_PJ.My.Resources.Resources.MinimalizeWhite
        Me.Bt_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Minimize.FlatAppearance.BorderSize = 0
        Me.Bt_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Bt_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Bt_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Minimize.Location = New System.Drawing.Point(744, 7)
        Me.Bt_Minimize.Name = "Bt_Minimize"
        Me.Bt_Minimize.Size = New System.Drawing.Size(36, 38)
        Me.Bt_Minimize.TabIndex = 14
        Me.Bt_Minimize.UseVisualStyleBackColor = False
        '
        'RECAPITULATIF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(857, 808)
        Me.Controls.Add(Me.Pn_Top)
        Me.Controls.Add(Me.Bt_Supprimer)
        Me.Controls.Add(Me.Bt_Modifier)
        Me.Controls.Add(Me.Bt_Arret)
        Me.Controls.Add(Me.Bt_ValiderModification)
        Me.Controls.Add(Me.Bt_Enregistrer)
        Me.Controls.Add(Me.Bt_Annuler)
        Me.Controls.Add(Me.Gb_RecapEpreuves)
        Me.Controls.Add(Me.Gb_InfoCandidat)
        Me.Controls.Add(Me.Lb_Recap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RECAPITULATIF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECAPITULATIF"
        Me.Gb_InfoCandidat.ResumeLayout(False)
        Me.Gb_InfoCandidat.PerformLayout()
        Me.Gb_RecapEpreuves.ResumeLayout(False)
        Me.Gb_RecapEpreuves.PerformLayout()
        Me.Pn_Top.ResumeLayout(False)
        Me.Pn_Top.PerformLayout()
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
    Friend WithEvents Bt_Arret As Button
    Friend WithEvents Pn_Top As Panel
    Friend WithEvents Bt_quitter As Button
    Friend WithEvents Bt_Minimize As Button
    Friend WithEvents Titre As Label
End Class
