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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AFFICHAGE))
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
        Me.Pn_Top = New System.Windows.Forms.Panel()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Bt_quitter = New System.Windows.Forms.Button()
        Me.Bt_Minimize = New System.Windows.Forms.Button()
        Me.Pn_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_Num
        '
        Me.Lb_Num.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Num.FormattingEnabled = True
        Me.Lb_Num.ItemHeight = 24
        Me.Lb_Num.Location = New System.Drawing.Point(35, 123)
        Me.Lb_Num.Name = "Lb_Num"
        Me.Lb_Num.Size = New System.Drawing.Size(96, 364)
        Me.Lb_Num.TabIndex = 0
        '
        'Lb_Nom
        '
        Me.Lb_Nom.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Nom.FormattingEnabled = True
        Me.Lb_Nom.ItemHeight = 24
        Me.Lb_Nom.Location = New System.Drawing.Point(160, 123)
        Me.Lb_Nom.Name = "Lb_Nom"
        Me.Lb_Nom.Size = New System.Drawing.Size(160, 364)
        Me.Lb_Nom.TabIndex = 1
        '
        'Lb_Prenom
        '
        Me.Lb_Prenom.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Prenom.FormattingEnabled = True
        Me.Lb_Prenom.ItemHeight = 24
        Me.Lb_Prenom.Location = New System.Drawing.Point(349, 123)
        Me.Lb_Prenom.Name = "Lb_Prenom"
        Me.Lb_Prenom.Size = New System.Drawing.Size(160, 364)
        Me.Lb_Prenom.TabIndex = 2
        '
        'Lb_Ecrits
        '
        Me.Lb_Ecrits.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Ecrits.FormattingEnabled = True
        Me.Lb_Ecrits.ItemHeight = 24
        Me.Lb_Ecrits.Location = New System.Drawing.Point(540, 123)
        Me.Lb_Ecrits.Name = "Lb_Ecrits"
        Me.Lb_Ecrits.Size = New System.Drawing.Size(195, 124)
        Me.Lb_Ecrits.TabIndex = 3
        '
        'Lb_Oraux
        '
        Me.Lb_Oraux.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Oraux.FormattingEnabled = True
        Me.Lb_Oraux.ItemHeight = 24
        Me.Lb_Oraux.Location = New System.Drawing.Point(540, 291)
        Me.Lb_Oraux.Name = "Lb_Oraux"
        Me.Lb_Oraux.Size = New System.Drawing.Size(195, 100)
        Me.Lb_Oraux.TabIndex = 4
        '
        'Lb_Facultative
        '
        Me.Lb_Facultative.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Facultative.FormattingEnabled = True
        Me.Lb_Facultative.ItemHeight = 24
        Me.Lb_Facultative.Location = New System.Drawing.Point(540, 435)
        Me.Lb_Facultative.Name = "Lb_Facultative"
        Me.Lb_Facultative.Size = New System.Drawing.Size(195, 52)
        Me.Lb_Facultative.TabIndex = 5
        '
        'Bt_Retour
        '
        Me.Bt_Retour.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_Retour.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_Retour.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Retour.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Retour.Location = New System.Drawing.Point(116, 514)
        Me.Bt_Retour.Name = "Bt_Retour"
        Me.Bt_Retour.Size = New System.Drawing.Size(248, 38)
        Me.Bt_Retour.TabIndex = 6
        Me.Bt_Retour.Text = "Retour"
        Me.Bt_Retour.UseVisualStyleBackColor = False
        '
        'Lb_Num1
        '
        Me.Lb_Num1.AutoSize = True
        Me.Lb_Num1.Font = New System.Drawing.Font("Euclid Circular A", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Num1.Location = New System.Drawing.Point(38, 83)
        Me.Lb_Num1.Name = "Lb_Num1"
        Me.Lb_Num1.Size = New System.Drawing.Size(93, 27)
        Me.Lb_Num1.TabIndex = 7
        Me.Lb_Num1.Text = "Numéro"
        '
        'Lb_nom1
        '
        Me.Lb_nom1.AutoSize = True
        Me.Lb_nom1.Font = New System.Drawing.Font("Euclid Circular A", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nom1.Location = New System.Drawing.Point(206, 83)
        Me.Lb_nom1.Name = "Lb_nom1"
        Me.Lb_nom1.Size = New System.Drawing.Size(61, 27)
        Me.Lb_nom1.TabIndex = 8
        Me.Lb_nom1.Text = "Nom"
        '
        'Lb_prénom1
        '
        Me.Lb_prénom1.AutoSize = True
        Me.Lb_prénom1.Font = New System.Drawing.Font("Euclid Circular A", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_prénom1.Location = New System.Drawing.Point(382, 83)
        Me.Lb_prénom1.Name = "Lb_prénom1"
        Me.Lb_prénom1.Size = New System.Drawing.Size(88, 27)
        Me.Lb_prénom1.TabIndex = 9
        Me.Lb_prénom1.Text = "Prénom"
        '
        'Lb_écrits1
        '
        Me.Lb_écrits1.AutoSize = True
        Me.Lb_écrits1.Font = New System.Drawing.Font("Euclid Circular A", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_écrits1.Location = New System.Drawing.Point(552, 83)
        Me.Lb_écrits1.Name = "Lb_écrits1"
        Me.Lb_écrits1.Size = New System.Drawing.Size(174, 27)
        Me.Lb_écrits1.TabIndex = 10
        Me.Lb_écrits1.Text = "Epreuves écrites"
        '
        'Lb_Orales1
        '
        Me.Lb_Orales1.AutoSize = True
        Me.Lb_Orales1.Font = New System.Drawing.Font("Euclid Circular A", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Orales1.Location = New System.Drawing.Point(553, 253)
        Me.Lb_Orales1.Name = "Lb_Orales1"
        Me.Lb_Orales1.Size = New System.Drawing.Size(168, 27)
        Me.Lb_Orales1.TabIndex = 11
        Me.Lb_Orales1.Text = "Epreuves orales"
        '
        'Lb_facultative1
        '
        Me.Lb_facultative1.AutoSize = True
        Me.Lb_facultative1.Font = New System.Drawing.Font("Euclid Circular A", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_facultative1.Location = New System.Drawing.Point(536, 399)
        Me.Lb_facultative1.Name = "Lb_facultative1"
        Me.Lb_facultative1.Size = New System.Drawing.Size(204, 27)
        Me.Lb_facultative1.TabIndex = 12
        Me.Lb_facultative1.Text = "Epreuve facultative"
        '
        'Bt_Fin
        '
        Me.Bt_Fin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_Fin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_Fin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Fin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Fin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Fin.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Fin.Location = New System.Drawing.Point(417, 514)
        Me.Bt_Fin.Name = "Bt_Fin"
        Me.Bt_Fin.Size = New System.Drawing.Size(248, 38)
        Me.Bt_Fin.TabIndex = 13
        Me.Bt_Fin.Text = "Cloturer les inscriptions"
        Me.Bt_Fin.UseVisualStyleBackColor = False
        '
        'Pn_Top
        '
        Me.Pn_Top.BackgroundImage = Global.Concours_Sup.My.Resources.Resources.Capture
        Me.Pn_Top.Controls.Add(Me.Titre)
        Me.Pn_Top.Controls.Add(Me.Bt_quitter)
        Me.Pn_Top.Controls.Add(Me.Bt_Minimize)
        Me.Pn_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_Top.Location = New System.Drawing.Point(0, 0)
        Me.Pn_Top.Name = "Pn_Top"
        Me.Pn_Top.Size = New System.Drawing.Size(787, 50)
        Me.Pn_Top.TabIndex = 14
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
        Me.Titre.TabIndex = 15
        Me.Titre.Text = "Label1"
        '
        'Bt_quitter
        '
        Me.Bt_quitter.BackColor = System.Drawing.Color.Transparent
        Me.Bt_quitter.BackgroundImage = Global.Concours_Sup.My.Resources.Resources.closeWhite
        Me.Bt_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_quitter.FlatAppearance.BorderSize = 0
        Me.Bt_quitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Bt_quitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Bt_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_quitter.Location = New System.Drawing.Point(733, 10)
        Me.Bt_quitter.Name = "Bt_quitter"
        Me.Bt_quitter.Size = New System.Drawing.Size(43, 29)
        Me.Bt_quitter.TabIndex = 16
        Me.Bt_quitter.UseVisualStyleBackColor = False
        '
        'Bt_Minimize
        '
        Me.Bt_Minimize.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Minimize.BackgroundImage = Global.Concours_Sup.My.Resources.Resources.MinimalizeWhite
        Me.Bt_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Minimize.FlatAppearance.BorderSize = 0
        Me.Bt_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Bt_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Bt_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Minimize.Location = New System.Drawing.Point(675, 5)
        Me.Bt_Minimize.Name = "Bt_Minimize"
        Me.Bt_Minimize.Size = New System.Drawing.Size(36, 38)
        Me.Bt_Minimize.TabIndex = 15
        Me.Bt_Minimize.UseVisualStyleBackColor = False
        '
        'AFFICHAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(787, 585)
        Me.Controls.Add(Me.Pn_Top)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AFFICHAGE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AFFICHAGE"
        Me.Pn_Top.ResumeLayout(False)
        Me.Pn_Top.PerformLayout()
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
    Friend WithEvents Pn_Top As Panel
    Friend WithEvents Bt_quitter As Button
    Friend WithEvents Bt_Minimize As Button
    Friend WithEvents Titre As Label
End Class
