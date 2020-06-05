<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BILAN_INS
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
        Me.Ls_Bilan = New System.Windows.Forms.ListView()
        Me.Bt_Annuler = New System.Windows.Forms.Button()
        Me.Bt_Arret = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ls_Bilan
        '
        Me.Ls_Bilan.BackColor = System.Drawing.SystemColors.Control
        Me.Ls_Bilan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ls_Bilan.HideSelection = False
        Me.Ls_Bilan.Location = New System.Drawing.Point(50, 32)
        Me.Ls_Bilan.Name = "Ls_Bilan"
        Me.Ls_Bilan.Size = New System.Drawing.Size(353, 447)
        Me.Ls_Bilan.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.Ls_Bilan.TabIndex = 15
        Me.Ls_Bilan.UseCompatibleStateImageBehavior = False
        Me.Ls_Bilan.View = System.Windows.Forms.View.List
        '
        'Bt_Annuler
        '
        Me.Bt_Annuler.Location = New System.Drawing.Point(25, 503)
        Me.Bt_Annuler.Name = "Bt_Annuler"
        Me.Bt_Annuler.Size = New System.Drawing.Size(159, 45)
        Me.Bt_Annuler.TabIndex = 16
        Me.Bt_Annuler.Text = "Annuler"
        Me.Bt_Annuler.UseVisualStyleBackColor = True
        '
        'Bt_Arret
        '
        Me.Bt_Arret.Location = New System.Drawing.Point(190, 503)
        Me.Bt_Arret.Name = "Bt_Arret"
        Me.Bt_Arret.Size = New System.Drawing.Size(238, 45)
        Me.Bt_Arret.TabIndex = 17
        Me.Bt_Arret.Text = "Arrêter l'Application"
        Me.Bt_Arret.UseVisualStyleBackColor = True
        '
        'BILAN_INS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 560)
        Me.Controls.Add(Me.Bt_Arret)
        Me.Controls.Add(Me.Bt_Annuler)
        Me.Controls.Add(Me.Ls_Bilan)
        Me.Name = "BILAN_INS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BILAN_INS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ls_Bilan As ListView
    Friend WithEvents Bt_Annuler As Button
    Friend WithEvents Bt_Arret As Button
End Class
