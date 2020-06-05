<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ACCUEIL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_EnregistrerIns = New System.Windows.Forms.Button()
        Me.Btn_ModificationIns = New System.Windows.Forms.Button()
        Me.Btn_AfficherIns = New System.Windows.Forms.Button()
        Me.Btn_BilanProvisoire = New System.Windows.Forms.Button()
        Me.Bt_FinIns = New System.Windows.Forms.Button()
        Me.Bt_quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_EnregistrerIns
        '
        Me.Btn_EnregistrerIns.Location = New System.Drawing.Point(51, 50)
        Me.Btn_EnregistrerIns.Name = "Btn_EnregistrerIns"
        Me.Btn_EnregistrerIns.Size = New System.Drawing.Size(268, 97)
        Me.Btn_EnregistrerIns.TabIndex = 0
        Me.Btn_EnregistrerIns.Text = "Enregistrer Inscription"
        Me.Btn_EnregistrerIns.UseVisualStyleBackColor = True
        '
        'Btn_ModificationIns
        '
        Me.Btn_ModificationIns.Location = New System.Drawing.Point(357, 50)
        Me.Btn_ModificationIns.Name = "Btn_ModificationIns"
        Me.Btn_ModificationIns.Size = New System.Drawing.Size(281, 97)
        Me.Btn_ModificationIns.TabIndex = 1
        Me.Btn_ModificationIns.Text = "Modifier-Supprimer Inscriptions"
        Me.Btn_ModificationIns.UseVisualStyleBackColor = True
        '
        'Btn_AfficherIns
        '
        Me.Btn_AfficherIns.Location = New System.Drawing.Point(671, 50)
        Me.Btn_AfficherIns.Name = "Btn_AfficherIns"
        Me.Btn_AfficherIns.Size = New System.Drawing.Size(281, 97)
        Me.Btn_AfficherIns.TabIndex = 2
        Me.Btn_AfficherIns.Text = "Afficher Inscriptions"
        Me.Btn_AfficherIns.UseVisualStyleBackColor = True
        '
        'Btn_BilanProvisoire
        '
        Me.Btn_BilanProvisoire.Location = New System.Drawing.Point(198, 182)
        Me.Btn_BilanProvisoire.Name = "Btn_BilanProvisoire"
        Me.Btn_BilanProvisoire.Size = New System.Drawing.Size(281, 97)
        Me.Btn_BilanProvisoire.TabIndex = 3
        Me.Btn_BilanProvisoire.Text = "Etablir bilan provisoire"
        Me.Btn_BilanProvisoire.UseVisualStyleBackColor = True
        '
        'Bt_FinIns
        '
        Me.Bt_FinIns.Location = New System.Drawing.Point(523, 182)
        Me.Bt_FinIns.Name = "Bt_FinIns"
        Me.Bt_FinIns.Size = New System.Drawing.Size(281, 97)
        Me.Bt_FinIns.TabIndex = 4
        Me.Bt_FinIns.Text = "Mettre fin aux inscriptions"
        Me.Bt_FinIns.UseVisualStyleBackColor = True
        '
        'Bt_quitter
        '
        Me.Bt_quitter.Location = New System.Drawing.Point(444, 309)
        Me.Bt_quitter.Name = "Bt_quitter"
        Me.Bt_quitter.Size = New System.Drawing.Size(122, 37)
        Me.Bt_quitter.TabIndex = 5
        Me.Bt_quitter.Text = "Quitter"
        Me.Bt_quitter.UseVisualStyleBackColor = True
        '
        'ACCUEIL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 358)
        Me.Controls.Add(Me.Bt_quitter)
        Me.Controls.Add(Me.Bt_FinIns)
        Me.Controls.Add(Me.Btn_BilanProvisoire)
        Me.Controls.Add(Me.Btn_AfficherIns)
        Me.Controls.Add(Me.Btn_ModificationIns)
        Me.Controls.Add(Me.Btn_EnregistrerIns)
        Me.Name = "ACCUEIL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_EnregistrerIns As Button
    Friend WithEvents Btn_ModificationIns As Button
    Friend WithEvents Btn_AfficherIns As Button
    Friend WithEvents Btn_BilanProvisoire As Button
    Friend WithEvents Bt_FinIns As Button
    Friend WithEvents Bt_quitter As Button
End Class
