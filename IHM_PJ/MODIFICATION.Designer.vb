<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MODIFICATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MODIFICATION))
        Me.Bt_Annuler = New System.Windows.Forms.Button()
        Me.Bt_Modifier = New System.Windows.Forms.Button()
        Me.Bt_Supprimer = New System.Windows.Forms.Button()
        Me.Cb_Candidats = New System.Windows.Forms.ComboBox()
        Me.numCandidat = New System.Windows.Forms.TextBox()
        Me.Rb_NumCandidat = New System.Windows.Forms.RadioButton()
        Me.Rb_ListeCandidat = New System.Windows.Forms.RadioButton()
        Me.Pn_Top = New System.Windows.Forms.Panel()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Bt_quitter = New System.Windows.Forms.Button()
        Me.Bt_Minimize = New System.Windows.Forms.Button()
        Me.Gb_Selection = New System.Windows.Forms.GroupBox()
        Me.Pn_Top.SuspendLayout()
        Me.Gb_Selection.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bt_Annuler
        '
        Me.Bt_Annuler.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_Annuler.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_Annuler.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Annuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Annuler.Location = New System.Drawing.Point(240, 370)
        Me.Bt_Annuler.Name = "Bt_Annuler"
        Me.Bt_Annuler.Size = New System.Drawing.Size(139, 62)
        Me.Bt_Annuler.TabIndex = 0
        Me.Bt_Annuler.Text = "Annuler"
        Me.Bt_Annuler.UseVisualStyleBackColor = False
        '
        'Bt_Modifier
        '
        Me.Bt_Modifier.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bt_Modifier.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.Bt_Modifier.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Modifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Bt_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Modifier.Location = New System.Drawing.Point(406, 370)
        Me.Bt_Modifier.Name = "Bt_Modifier"
        Me.Bt_Modifier.Size = New System.Drawing.Size(139, 62)
        Me.Bt_Modifier.TabIndex = 1
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
        Me.Bt_Supprimer.Location = New System.Drawing.Point(573, 370)
        Me.Bt_Supprimer.Name = "Bt_Supprimer"
        Me.Bt_Supprimer.Size = New System.Drawing.Size(139, 62)
        Me.Bt_Supprimer.TabIndex = 2
        Me.Bt_Supprimer.Text = "Supprimer"
        Me.Bt_Supprimer.UseVisualStyleBackColor = False
        '
        'Cb_Candidats
        '
        Me.Cb_Candidats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Candidats.FormattingEnabled = True
        Me.Cb_Candidats.Location = New System.Drawing.Point(371, 125)
        Me.Cb_Candidats.Name = "Cb_Candidats"
        Me.Cb_Candidats.Size = New System.Drawing.Size(262, 32)
        Me.Cb_Candidats.TabIndex = 3
        '
        'numCandidat
        '
        Me.numCandidat.Location = New System.Drawing.Point(371, 65)
        Me.numCandidat.Name = "numCandidat"
        Me.numCandidat.Size = New System.Drawing.Size(262, 32)
        Me.numCandidat.TabIndex = 6
        '
        'Rb_NumCandidat
        '
        Me.Rb_NumCandidat.AutoSize = True
        Me.Rb_NumCandidat.Location = New System.Drawing.Point(57, 63)
        Me.Rb_NumCandidat.Name = "Rb_NumCandidat"
        Me.Rb_NumCandidat.Size = New System.Drawing.Size(151, 29)
        Me.Rb_NumCandidat.TabIndex = 7
        Me.Rb_NumCandidat.TabStop = True
        Me.Rb_NumCandidat.Text = "Par Numéro"
        Me.Rb_NumCandidat.UseVisualStyleBackColor = True
        '
        'Rb_ListeCandidat
        '
        Me.Rb_ListeCandidat.AutoSize = True
        Me.Rb_ListeCandidat.Location = New System.Drawing.Point(57, 127)
        Me.Rb_ListeCandidat.Name = "Rb_ListeCandidat"
        Me.Rb_ListeCandidat.Size = New System.Drawing.Size(178, 29)
        Me.Rb_ListeCandidat.TabIndex = 8
        Me.Rb_ListeCandidat.TabStop = True
        Me.Rb_ListeCandidat.Text = "Par Recherche"
        Me.Rb_ListeCandidat.UseVisualStyleBackColor = True
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
        Me.Pn_Top.Size = New System.Drawing.Size(956, 50)
        Me.Pn_Top.TabIndex = 9
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.BackColor = System.Drawing.Color.Transparent
        Me.Titre.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.ForeColor = System.Drawing.Color.White
        Me.Titre.Location = New System.Drawing.Point(12, 12)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(73, 25)
        Me.Titre.TabIndex = 16
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
        Me.Bt_quitter.Location = New System.Drawing.Point(901, 12)
        Me.Bt_quitter.Name = "Bt_quitter"
        Me.Bt_quitter.Size = New System.Drawing.Size(43, 29)
        Me.Bt_quitter.TabIndex = 18
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
        Me.Bt_Minimize.Location = New System.Drawing.Point(843, 7)
        Me.Bt_Minimize.Name = "Bt_Minimize"
        Me.Bt_Minimize.Size = New System.Drawing.Size(36, 38)
        Me.Bt_Minimize.TabIndex = 17
        Me.Bt_Minimize.UseVisualStyleBackColor = False
        '
        'Gb_Selection
        '
        Me.Gb_Selection.Controls.Add(Me.Rb_NumCandidat)
        Me.Gb_Selection.Controls.Add(Me.Cb_Candidats)
        Me.Gb_Selection.Controls.Add(Me.Rb_ListeCandidat)
        Me.Gb_Selection.Controls.Add(Me.numCandidat)
        Me.Gb_Selection.Location = New System.Drawing.Point(132, 116)
        Me.Gb_Selection.Name = "Gb_Selection"
        Me.Gb_Selection.Size = New System.Drawing.Size(700, 209)
        Me.Gb_Selection.TabIndex = 10
        Me.Gb_Selection.TabStop = False
        Me.Gb_Selection.Text = "Sélection du Candidat"
        '
        'MODIFICATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(956, 493)
        Me.Controls.Add(Me.Gb_Selection)
        Me.Controls.Add(Me.Pn_Top)
        Me.Controls.Add(Me.Bt_Supprimer)
        Me.Controls.Add(Me.Bt_Modifier)
        Me.Controls.Add(Me.Bt_Annuler)
        Me.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MODIFICATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MODIFICATION"
        Me.Pn_Top.ResumeLayout(False)
        Me.Pn_Top.PerformLayout()
        Me.Gb_Selection.ResumeLayout(False)
        Me.Gb_Selection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bt_Annuler As Button
    Friend WithEvents Bt_Modifier As Button
    Friend WithEvents Bt_Supprimer As Button
    Friend WithEvents Cb_Candidats As ComboBox
    Friend WithEvents numCandidat As TextBox
    Friend WithEvents Rb_NumCandidat As RadioButton
    Friend WithEvents Rb_ListeCandidat As RadioButton
    Friend WithEvents Pn_Top As Panel
    Friend WithEvents Bt_quitter As Button
    Friend WithEvents Bt_Minimize As Button
    Friend WithEvents Titre As Label
    Friend WithEvents Gb_Selection As GroupBox
End Class
