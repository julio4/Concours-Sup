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
        Me.Bt_Annuler = New System.Windows.Forms.Button()
        Me.Bt_Modifier = New System.Windows.Forms.Button()
        Me.Bt_Supprimer = New System.Windows.Forms.Button()
        Me.Cb_Candidats = New System.Windows.Forms.ComboBox()
        Me.numCandidat = New System.Windows.Forms.TextBox()
        Me.Rb_NumCandidat = New System.Windows.Forms.RadioButton()
        Me.Rb_ListeCandidat = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Bt_Annuler
        '
        Me.Bt_Annuler.Location = New System.Drawing.Point(229, 220)
        Me.Bt_Annuler.Name = "Bt_Annuler"
        Me.Bt_Annuler.Size = New System.Drawing.Size(139, 62)
        Me.Bt_Annuler.TabIndex = 0
        Me.Bt_Annuler.Text = "Annuler"
        Me.Bt_Annuler.UseVisualStyleBackColor = True
        '
        'Bt_Modifier
        '
        Me.Bt_Modifier.Location = New System.Drawing.Point(395, 220)
        Me.Bt_Modifier.Name = "Bt_Modifier"
        Me.Bt_Modifier.Size = New System.Drawing.Size(139, 62)
        Me.Bt_Modifier.TabIndex = 1
        Me.Bt_Modifier.Text = "Modifier"
        Me.Bt_Modifier.UseVisualStyleBackColor = True
        '
        'Bt_Supprimer
        '
        Me.Bt_Supprimer.Location = New System.Drawing.Point(562, 220)
        Me.Bt_Supprimer.Name = "Bt_Supprimer"
        Me.Bt_Supprimer.Size = New System.Drawing.Size(139, 62)
        Me.Bt_Supprimer.TabIndex = 2
        Me.Bt_Supprimer.Text = "Supprimer"
        Me.Bt_Supprimer.UseVisualStyleBackColor = True
        '
        'Cb_Candidats
        '
        Me.Cb_Candidats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Candidats.FormattingEnabled = True
        Me.Cb_Candidats.Location = New System.Drawing.Point(488, 125)
        Me.Cb_Candidats.Name = "Cb_Candidats"
        Me.Cb_Candidats.Size = New System.Drawing.Size(262, 32)
        Me.Cb_Candidats.TabIndex = 3
        '
        'numCandidat
        '
        Me.numCandidat.Location = New System.Drawing.Point(488, 74)
        Me.numCandidat.Name = "numCandidat"
        Me.numCandidat.Size = New System.Drawing.Size(262, 29)
        Me.numCandidat.TabIndex = 6
        '
        'Rb_NumCandidat
        '
        Me.Rb_NumCandidat.AutoSize = True
        Me.Rb_NumCandidat.Location = New System.Drawing.Point(174, 72)
        Me.Rb_NumCandidat.Name = "Rb_NumCandidat"
        Me.Rb_NumCandidat.Size = New System.Drawing.Size(217, 29)
        Me.Rb_NumCandidat.TabIndex = 7
        Me.Rb_NumCandidat.TabStop = True
        Me.Rb_NumCandidat.Text = "Numéro du Candidat"
        Me.Rb_NumCandidat.UseVisualStyleBackColor = True
        '
        'Rb_ListeCandidat
        '
        Me.Rb_ListeCandidat.AutoSize = True
        Me.Rb_ListeCandidat.Location = New System.Drawing.Point(174, 127)
        Me.Rb_ListeCandidat.Name = "Rb_ListeCandidat"
        Me.Rb_ListeCandidat.Size = New System.Drawing.Size(162, 29)
        Me.Rb_ListeCandidat.TabIndex = 8
        Me.Rb_ListeCandidat.TabStop = True
        Me.Rb_ListeCandidat.Text = "Liste Candidat"
        Me.Rb_ListeCandidat.UseVisualStyleBackColor = True
        '
        'MODIFICATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 327)
        Me.Controls.Add(Me.Rb_ListeCandidat)
        Me.Controls.Add(Me.Rb_NumCandidat)
        Me.Controls.Add(Me.numCandidat)
        Me.Controls.Add(Me.Cb_Candidats)
        Me.Controls.Add(Me.Bt_Supprimer)
        Me.Controls.Add(Me.Bt_Modifier)
        Me.Controls.Add(Me.Bt_Annuler)
        Me.Name = "MODIFICATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MODIFICATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bt_Annuler As Button
    Friend WithEvents Bt_Modifier As Button
    Friend WithEvents Bt_Supprimer As Button
    Friend WithEvents Cb_Candidats As ComboBox
    Friend WithEvents numCandidat As TextBox
    Friend WithEvents Rb_NumCandidat As RadioButton
    Friend WithEvents Rb_ListeCandidat As RadioButton
End Class
