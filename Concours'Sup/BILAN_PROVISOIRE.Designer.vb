<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BILAN_PROVISOIRE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BILAN_PROVISOIRE))
        Me.Rb_BilanIndividuel = New System.Windows.Forms.RadioButton()
        Me.Rb_BilanInscription = New System.Windows.Forms.RadioButton()
        Me.Cb_Candidats = New System.Windows.Forms.ComboBox()
        Me.AfficherBilan = New System.Windows.Forms.Button()
        Me.Lb_Candidat = New System.Windows.Forms.Label()
        Me.Lb_Matière = New System.Windows.Forms.Label()
        Me.Cb_Matières = New System.Windows.Forms.ComboBox()
        Me.Bt_Annuler = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NbInscrits = New System.Windows.Forms.Label()
        Me.Pn_Top = New System.Windows.Forms.Panel()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Bt_quitter = New System.Windows.Forms.Button()
        Me.Bt_Minimize = New System.Windows.Forms.Button()
        Me.Pn_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rb_BilanIndividuel
        '
        Me.Rb_BilanIndividuel.AutoSize = True
        Me.Rb_BilanIndividuel.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_BilanIndividuel.Location = New System.Drawing.Point(66, 154)
        Me.Rb_BilanIndividuel.Name = "Rb_BilanIndividuel"
        Me.Rb_BilanIndividuel.Size = New System.Drawing.Size(157, 26)
        Me.Rb_BilanIndividuel.TabIndex = 0
        Me.Rb_BilanIndividuel.TabStop = True
        Me.Rb_BilanIndividuel.Text = "Bilan Individuel"
        Me.Rb_BilanIndividuel.UseVisualStyleBackColor = True
        '
        'Rb_BilanInscription
        '
        Me.Rb_BilanInscription.AutoSize = True
        Me.Rb_BilanInscription.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_BilanInscription.Location = New System.Drawing.Point(66, 199)
        Me.Rb_BilanInscription.Name = "Rb_BilanInscription"
        Me.Rb_BilanInscription.Size = New System.Drawing.Size(204, 26)
        Me.Rb_BilanInscription.TabIndex = 1
        Me.Rb_BilanInscription.TabStop = True
        Me.Rb_BilanInscription.Text = "Bilan des Inscriptions"
        Me.Rb_BilanInscription.UseVisualStyleBackColor = True
        '
        'Cb_Candidats
        '
        Me.Cb_Candidats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Candidats.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Candidats.FormattingEnabled = True
        Me.Cb_Candidats.Location = New System.Drawing.Point(382, 181)
        Me.Cb_Candidats.Name = "Cb_Candidats"
        Me.Cb_Candidats.Size = New System.Drawing.Size(225, 28)
        Me.Cb_Candidats.TabIndex = 4
        '
        'AfficherBilan
        '
        Me.AfficherBilan.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AfficherBilan.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.AfficherBilan.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.AfficherBilan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.AfficherBilan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.AfficherBilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AfficherBilan.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AfficherBilan.Location = New System.Drawing.Point(375, 261)
        Me.AfficherBilan.Name = "AfficherBilan"
        Me.AfficherBilan.Size = New System.Drawing.Size(165, 39)
        Me.AfficherBilan.TabIndex = 5
        Me.AfficherBilan.Text = "Afficher Bilan"
        Me.AfficherBilan.UseVisualStyleBackColor = False
        '
        'Lb_Candidat
        '
        Me.Lb_Candidat.AutoSize = True
        Me.Lb_Candidat.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Candidat.Location = New System.Drawing.Point(450, 154)
        Me.Lb_Candidat.Name = "Lb_Candidat"
        Me.Lb_Candidat.Size = New System.Drawing.Size(87, 22)
        Me.Lb_Candidat.TabIndex = 6
        Me.Lb_Candidat.Text = "Candidat"
        '
        'Lb_Matière
        '
        Me.Lb_Matière.AutoSize = True
        Me.Lb_Matière.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Matière.Location = New System.Drawing.Point(450, 154)
        Me.Lb_Matière.Name = "Lb_Matière"
        Me.Lb_Matière.Size = New System.Drawing.Size(72, 22)
        Me.Lb_Matière.TabIndex = 8
        Me.Lb_Matière.Text = "Matière"
        '
        'Cb_Matières
        '
        Me.Cb_Matières.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Matières.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Matières.FormattingEnabled = True
        Me.Cb_Matières.Location = New System.Drawing.Point(382, 181)
        Me.Cb_Matières.Name = "Cb_Matières"
        Me.Cb_Matières.Size = New System.Drawing.Size(225, 28)
        Me.Cb_Matières.TabIndex = 7
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
        Me.Bt_Annuler.Location = New System.Drawing.Point(154, 261)
        Me.Bt_Annuler.Name = "Bt_Annuler"
        Me.Bt_Annuler.Size = New System.Drawing.Size(165, 39)
        Me.Bt_Annuler.TabIndex = 9
        Me.Bt_Annuler.Text = "Annuler"
        Me.Bt_Annuler.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Euclid Circular A", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre d'inscrits: "
        '
        'NbInscrits
        '
        Me.NbInscrits.AutoSize = True
        Me.NbInscrits.Font = New System.Drawing.Font("Euclid Circular A Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NbInscrits.Location = New System.Drawing.Point(291, 87)
        Me.NbInscrits.Name = "NbInscrits"
        Me.NbInscrits.Size = New System.Drawing.Size(141, 30)
        Me.NbInscrits.TabIndex = 11
        Me.NbInscrits.Text = "NbInscrits"
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
        Me.Pn_Top.Size = New System.Drawing.Size(686, 43)
        Me.Pn_Top.TabIndex = 12
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.BackColor = System.Drawing.Color.Transparent
        Me.Titre.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.ForeColor = System.Drawing.Color.White
        Me.Titre.Location = New System.Drawing.Point(10, 12)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(61, 22)
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
        Me.Bt_quitter.Location = New System.Drawing.Point(639, 10)
        Me.Bt_quitter.Name = "Bt_quitter"
        Me.Bt_quitter.Size = New System.Drawing.Size(37, 25)
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
        Me.Bt_Minimize.Location = New System.Drawing.Point(589, 6)
        Me.Bt_Minimize.Name = "Bt_Minimize"
        Me.Bt_Minimize.Size = New System.Drawing.Size(31, 33)
        Me.Bt_Minimize.TabIndex = 17
        Me.Bt_Minimize.UseVisualStyleBackColor = False
        '
        'BILAN_PROVISOIRE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(686, 345)
        Me.Controls.Add(Me.Pn_Top)
        Me.Controls.Add(Me.NbInscrits)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bt_Annuler)
        Me.Controls.Add(Me.Lb_Matière)
        Me.Controls.Add(Me.Cb_Matières)
        Me.Controls.Add(Me.Lb_Candidat)
        Me.Controls.Add(Me.AfficherBilan)
        Me.Controls.Add(Me.Cb_Candidats)
        Me.Controls.Add(Me.Rb_BilanInscription)
        Me.Controls.Add(Me.Rb_BilanIndividuel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BILAN_PROVISOIRE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BILAN"
        Me.Pn_Top.ResumeLayout(False)
        Me.Pn_Top.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rb_BilanIndividuel As RadioButton
    Friend WithEvents Rb_BilanInscription As RadioButton
    Friend WithEvents Cb_Candidats As ComboBox
    Friend WithEvents AfficherBilan As Button
    Friend WithEvents Lb_Candidat As Label
    Friend WithEvents Lb_Matière As Label
    Friend WithEvents Cb_Matières As ComboBox
    Friend WithEvents Bt_Annuler As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NbInscrits As Label
    Friend WithEvents Pn_Top As Panel
    Friend WithEvents Bt_quitter As Button
    Friend WithEvents Bt_Minimize As Button
    Friend WithEvents Titre As Label
End Class
