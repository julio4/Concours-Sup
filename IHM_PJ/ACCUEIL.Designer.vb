<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACCUEIL
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
        Me.Btn_EnregistrerIns = New System.Windows.Forms.Button()
        Me.Btn_ModificationIns = New System.Windows.Forms.Button()
        Me.Btn_AfficherIns = New System.Windows.Forms.Button()
        Me.Btn_BilanProvisoire = New System.Windows.Forms.Button()
        Me.BTn_FinIns = New System.Windows.Forms.Button()
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
        Me.Btn_BilanProvisoire.Location = New System.Drawing.Point(193, 177)
        Me.Btn_BilanProvisoire.Name = "Btn_BilanProvisoire"
        Me.Btn_BilanProvisoire.Size = New System.Drawing.Size(281, 97)
        Me.Btn_BilanProvisoire.TabIndex = 3
        Me.Btn_BilanProvisoire.Text = "Etablir bilan - Mettre fin aux inscriptions"
        Me.Btn_BilanProvisoire.UseVisualStyleBackColor = True
        '
        'BTn_FinIns
        '
        Me.BTn_FinIns.Location = New System.Drawing.Point(508, 177)
        Me.BTn_FinIns.Name = "BTn_FinIns"
        Me.BTn_FinIns.Size = New System.Drawing.Size(281, 97)
        Me.BTn_FinIns.TabIndex = 4
        Me.BTn_FinIns.Text = "Mettre fin aux inscriptions"
        Me.BTn_FinIns.UseVisualStyleBackColor = True
        '
        'ACCUEIL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 326)
        Me.Controls.Add(Me.BTn_FinIns)
        Me.Controls.Add(Me.Btn_BilanProvisoire)
        Me.Controls.Add(Me.Btn_AfficherIns)
        Me.Controls.Add(Me.Btn_ModificationIns)
        Me.Controls.Add(Me.Btn_EnregistrerIns)
        Me.Name = "ACCUEIL"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_EnregistrerIns As Button
    Friend WithEvents Btn_ModificationIns As Button
    Friend WithEvents Btn_AfficherIns As Button
    Friend WithEvents Btn_BilanProvisoire As Button
    Friend WithEvents BTn_FinIns As Button
End Class
