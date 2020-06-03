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
        Me.Rb_BilanIndividuel = New System.Windows.Forms.RadioButton()
        Me.Rb_BilanInscription = New System.Windows.Forms.RadioButton()
        Me.Cb_Candidats = New System.Windows.Forms.ComboBox()
        Me.AfficherBilan = New System.Windows.Forms.Button()
        Me.Lb_Candidat = New System.Windows.Forms.Label()
        Me.Lb_Matière = New System.Windows.Forms.Label()
        Me.Cb_Matières = New System.Windows.Forms.ComboBox()
        Me.Bt_Annuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Rb_BilanIndividuel
        '
        Me.Rb_BilanIndividuel.AutoSize = True
        Me.Rb_BilanIndividuel.Location = New System.Drawing.Point(38, 54)
        Me.Rb_BilanIndividuel.Name = "Rb_BilanIndividuel"
        Me.Rb_BilanIndividuel.Size = New System.Drawing.Size(167, 29)
        Me.Rb_BilanIndividuel.TabIndex = 0
        Me.Rb_BilanIndividuel.TabStop = True
        Me.Rb_BilanIndividuel.Text = "Bilan Individuel"
        Me.Rb_BilanIndividuel.UseVisualStyleBackColor = True
        '
        'Rb_BilanInscription
        '
        Me.Rb_BilanInscription.AutoSize = True
        Me.Rb_BilanInscription.Location = New System.Drawing.Point(38, 106)
        Me.Rb_BilanInscription.Name = "Rb_BilanInscription"
        Me.Rb_BilanInscription.Size = New System.Drawing.Size(220, 29)
        Me.Rb_BilanInscription.TabIndex = 1
        Me.Rb_BilanInscription.TabStop = True
        Me.Rb_BilanInscription.Text = "Bilan des Inscriptions"
        Me.Rb_BilanInscription.UseVisualStyleBackColor = True
        '
        'Cb_Candidats
        '
        Me.Cb_Candidats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Candidats.FormattingEnabled = True
        Me.Cb_Candidats.Location = New System.Drawing.Point(407, 88)
        Me.Cb_Candidats.Name = "Cb_Candidats"
        Me.Cb_Candidats.Size = New System.Drawing.Size(262, 32)
        Me.Cb_Candidats.TabIndex = 4
        '
        'AfficherBilan
        '
        Me.AfficherBilan.Location = New System.Drawing.Point(435, 171)
        Me.AfficherBilan.Name = "AfficherBilan"
        Me.AfficherBilan.Size = New System.Drawing.Size(192, 45)
        Me.AfficherBilan.TabIndex = 5
        Me.AfficherBilan.Text = "Afficher Bilan"
        Me.AfficherBilan.UseVisualStyleBackColor = True
        '
        'Lb_Candidat
        '
        Me.Lb_Candidat.AutoSize = True
        Me.Lb_Candidat.Location = New System.Drawing.Point(486, 57)
        Me.Lb_Candidat.Name = "Lb_Candidat"
        Me.Lb_Candidat.Size = New System.Drawing.Size(91, 25)
        Me.Lb_Candidat.TabIndex = 6
        Me.Lb_Candidat.Text = "Candidat"
        '
        'Lb_Matière
        '
        Me.Lb_Matière.AutoSize = True
        Me.Lb_Matière.Location = New System.Drawing.Point(486, 57)
        Me.Lb_Matière.Name = "Lb_Matière"
        Me.Lb_Matière.Size = New System.Drawing.Size(77, 25)
        Me.Lb_Matière.TabIndex = 8
        Me.Lb_Matière.Text = "Matière"
        '
        'Cb_Matières
        '
        Me.Cb_Matières.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Matières.FormattingEnabled = True
        Me.Cb_Matières.Location = New System.Drawing.Point(407, 88)
        Me.Cb_Matières.Name = "Cb_Matières"
        Me.Cb_Matières.Size = New System.Drawing.Size(262, 32)
        Me.Cb_Matières.TabIndex = 7
        '
        'Bt_Annuler
        '
        Me.Bt_Annuler.Location = New System.Drawing.Point(177, 171)
        Me.Bt_Annuler.Name = "Bt_Annuler"
        Me.Bt_Annuler.Size = New System.Drawing.Size(192, 45)
        Me.Bt_Annuler.TabIndex = 9
        Me.Bt_Annuler.Text = "Annuler"
        Me.Bt_Annuler.UseVisualStyleBackColor = True
        '
        'BILAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 283)
        Me.Controls.Add(Me.Bt_Annuler)
        Me.Controls.Add(Me.Lb_Matière)
        Me.Controls.Add(Me.Cb_Matières)
        Me.Controls.Add(Me.Lb_Candidat)
        Me.Controls.Add(Me.AfficherBilan)
        Me.Controls.Add(Me.Cb_Candidats)
        Me.Controls.Add(Me.Rb_BilanInscription)
        Me.Controls.Add(Me.Rb_BilanIndividuel)
        Me.Name = "BILAN"
        Me.Text = "BILAN"
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
End Class
