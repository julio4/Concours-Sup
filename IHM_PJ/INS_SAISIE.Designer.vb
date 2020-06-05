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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INS_SAISIE))
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Pn_Top = New System.Windows.Forms.Panel()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Bt_quitter = New System.Windows.Forms.Button()
        Me.Bt_Minimize = New System.Windows.Forms.Button()
        Me.Pn_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nom
        '
        Me.Nom.BackColor = System.Drawing.Color.White
        Me.Nom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nom.ForeColor = System.Drawing.Color.Black
        Me.Nom.Location = New System.Drawing.Point(39, 125)
        Me.Nom.Multiline = True
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(341, 30)
        Me.Nom.TabIndex = 0
        '
        'Prénom
        '
        Me.Prénom.BackColor = System.Drawing.Color.White
        Me.Prénom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Prénom.Location = New System.Drawing.Point(39, 228)
        Me.Prénom.Multiline = True
        Me.Prénom.Name = "Prénom"
        Me.Prénom.Size = New System.Drawing.Size(341, 29)
        Me.Prénom.TabIndex = 1
        '
        'Adresse
        '
        Me.Adresse.BackColor = System.Drawing.Color.White
        Me.Adresse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Adresse.Location = New System.Drawing.Point(449, 125)
        Me.Adresse.Multiline = True
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(424, 29)
        Me.Adresse.TabIndex = 2
        '
        'CodePostal
        '
        Me.CodePostal.BackColor = System.Drawing.Color.White
        Me.CodePostal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodePostal.Location = New System.Drawing.Point(696, 228)
        Me.CodePostal.Multiline = True
        Me.CodePostal.Name = "CodePostal"
        Me.CodePostal.Size = New System.Drawing.Size(173, 29)
        Me.CodePostal.TabIndex = 4
        '
        'Ville
        '
        Me.Ville.BackColor = System.Drawing.Color.White
        Me.Ville.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ville.Location = New System.Drawing.Point(453, 228)
        Me.Ville.Multiline = True
        Me.Ville.Name = "Ville"
        Me.Ville.Size = New System.Drawing.Size(220, 29)
        Me.Ville.TabIndex = 3
        '
        'Lb_Nom
        '
        Me.Lb_Nom.AutoSize = True
        Me.Lb_Nom.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Nom.Location = New System.Drawing.Point(29, 97)
        Me.Lb_Nom.Name = "Lb_Nom"
        Me.Lb_Nom.Size = New System.Drawing.Size(58, 25)
        Me.Lb_Nom.TabIndex = 6
        Me.Lb_Nom.Text = "Nom"
        '
        'Lb_Prénom
        '
        Me.Lb_Prénom.AutoSize = True
        Me.Lb_Prénom.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Prénom.Location = New System.Drawing.Point(34, 200)
        Me.Lb_Prénom.Name = "Lb_Prénom"
        Me.Lb_Prénom.Size = New System.Drawing.Size(85, 25)
        Me.Lb_Prénom.TabIndex = 7
        Me.Lb_Prénom.Text = "Prénom"
        '
        'Lb_Adresse
        '
        Me.Lb_Adresse.AutoSize = True
        Me.Lb_Adresse.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Adresse.Location = New System.Drawing.Point(444, 97)
        Me.Lb_Adresse.Name = "Lb_Adresse"
        Me.Lb_Adresse.Size = New System.Drawing.Size(88, 25)
        Me.Lb_Adresse.TabIndex = 8
        Me.Lb_Adresse.Text = "Adresse"
        '
        'Lb_CodePostal
        '
        Me.Lb_CodePostal.AutoSize = True
        Me.Lb_CodePostal.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_CodePostal.Location = New System.Drawing.Point(689, 200)
        Me.Lb_CodePostal.Name = "Lb_CodePostal"
        Me.Lb_CodePostal.Size = New System.Drawing.Size(129, 25)
        Me.Lb_CodePostal.TabIndex = 9
        Me.Lb_CodePostal.Text = "Code Postal"
        '
        'Lb_Ville
        '
        Me.Lb_Ville.AutoSize = True
        Me.Lb_Ville.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Ville.Location = New System.Drawing.Point(448, 200)
        Me.Lb_Ville.Name = "Lb_Ville"
        Me.Lb_Ville.Size = New System.Drawing.Size(53, 25)
        Me.Lb_Ville.TabIndex = 10
        Me.Lb_Ville.Text = "Ville"
        '
        'Lb_Age
        '
        Me.Lb_Age.AutoSize = True
        Me.Lb_Age.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Age.Location = New System.Drawing.Point(34, 297)
        Me.Lb_Age.Name = "Lb_Age"
        Me.Lb_Age.Size = New System.Drawing.Size(51, 25)
        Me.Lb_Age.TabIndex = 11
        Me.Lb_Age.Text = "Age"
        '
        'Bt_ValiderInsSaisie
        '
        Me.Bt_ValiderInsSaisie.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_ValiderInsSaisie.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_ValiderInsSaisie.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_ValiderInsSaisie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_ValiderInsSaisie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_ValiderInsSaisie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_ValiderInsSaisie.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_ValiderInsSaisie.Location = New System.Drawing.Point(453, 328)
        Me.Bt_ValiderInsSaisie.Name = "Bt_ValiderInsSaisie"
        Me.Bt_ValiderInsSaisie.Size = New System.Drawing.Size(175, 48)
        Me.Bt_ValiderInsSaisie.TabIndex = 12
        Me.Bt_ValiderInsSaisie.Text = "Valider"
        Me.Bt_ValiderInsSaisie.UseVisualStyleBackColor = False
        '
        'Bt_AbandonnerIns
        '
        Me.Bt_AbandonnerIns.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_AbandonnerIns.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bt_AbandonnerIns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_AbandonnerIns.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_AbandonnerIns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_AbandonnerIns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_AbandonnerIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_AbandonnerIns.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_AbandonnerIns.Location = New System.Drawing.Point(698, 327)
        Me.Bt_AbandonnerIns.Name = "Bt_AbandonnerIns"
        Me.Bt_AbandonnerIns.Size = New System.Drawing.Size(175, 48)
        Me.Bt_AbandonnerIns.TabIndex = 13
        Me.Bt_AbandonnerIns.Text = "Abandonner"
        Me.Bt_AbandonnerIns.UseVisualStyleBackColor = False
        '
        'Sb_Age
        '
        Me.Sb_Age.Location = New System.Drawing.Point(34, 339)
        Me.Sb_Age.Name = "Sb_Age"
        Me.Sb_Age.Size = New System.Drawing.Size(300, 26)
        Me.Sb_Age.TabIndex = 14
        '
        'Age
        '
        Me.Age.AutoSize = True
        Me.Age.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age.Location = New System.Drawing.Point(338, 339)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(30, 25)
        Me.Age.TabIndex = 15
        Me.Age.Text = "18"
        '
        'TimerSaisie
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(35, 153)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 1)
        Me.Panel1.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Location = New System.Drawing.Point(35, 256)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 1)
        Me.Panel2.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Location = New System.Drawing.Point(449, 153)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(423, 1)
        Me.Panel3.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.Location = New System.Drawing.Point(693, 256)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(176, 1)
        Me.Panel4.TabIndex = 17
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel5.Location = New System.Drawing.Point(449, 256)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(224, 1)
        Me.Panel5.TabIndex = 17
        '
        'Pn_Top
        '
        Me.Pn_Top.BackColor = System.Drawing.Color.Transparent
        Me.Pn_Top.BackgroundImage = Global.IHM_PJ.My.Resources.Resources.Capture
        Me.Pn_Top.Controls.Add(Me.Titre)
        Me.Pn_Top.Controls.Add(Me.Bt_quitter)
        Me.Pn_Top.Controls.Add(Me.Bt_Minimize)
        Me.Pn_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_Top.Location = New System.Drawing.Point(0, 0)
        Me.Pn_Top.Name = "Pn_Top"
        Me.Pn_Top.Size = New System.Drawing.Size(930, 50)
        Me.Pn_Top.TabIndex = 18
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.ForeColor = System.Drawing.Color.White
        Me.Titre.Location = New System.Drawing.Point(16, 12)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(73, 25)
        Me.Titre.TabIndex = 11
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
        Me.Bt_quitter.Location = New System.Drawing.Point(875, 12)
        Me.Bt_quitter.Name = "Bt_quitter"
        Me.Bt_quitter.Size = New System.Drawing.Size(43, 29)
        Me.Bt_quitter.TabIndex = 10
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
        Me.Bt_Minimize.Location = New System.Drawing.Point(817, 7)
        Me.Bt_Minimize.Name = "Bt_Minimize"
        Me.Bt_Minimize.Size = New System.Drawing.Size(36, 38)
        Me.Bt_Minimize.TabIndex = 9
        Me.Bt_Minimize.UseVisualStyleBackColor = False
        '
        'INS_SAISIE
        '
        Me.AcceptButton = Me.Bt_ValiderInsSaisie
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Bt_AbandonnerIns
        Me.ClientSize = New System.Drawing.Size(930, 439)
        Me.Controls.Add(Me.Pn_Top)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "INS_SAISIE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Pn_Top.ResumeLayout(False)
        Me.Pn_Top.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Pn_Top As Panel
    Friend WithEvents Bt_quitter As Button
    Friend WithEvents Bt_Minimize As Button
    Friend WithEvents Titre As Label
End Class
