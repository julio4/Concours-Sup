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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BILAN_INS))
        Me.Ls_Bilan = New System.Windows.Forms.ListView()
        Me.Bt_Annuler = New System.Windows.Forms.Button()
        Me.Bt_Arret = New System.Windows.Forms.Button()
        Me.Pn_Top = New System.Windows.Forms.Panel()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Bt_quitter = New System.Windows.Forms.Button()
        Me.Bt_Minimize = New System.Windows.Forms.Button()
        Me.Pn_Top.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ls_Bilan
        '
        Me.Ls_Bilan.BackColor = System.Drawing.Color.White
        Me.Ls_Bilan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ls_Bilan.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ls_Bilan.HideSelection = False
        Me.Ls_Bilan.Location = New System.Drawing.Point(50, 80)
        Me.Ls_Bilan.Name = "Ls_Bilan"
        Me.Ls_Bilan.Size = New System.Drawing.Size(353, 447)
        Me.Ls_Bilan.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.Ls_Bilan.TabIndex = 15
        Me.Ls_Bilan.UseCompatibleStateImageBehavior = False
        Me.Ls_Bilan.View = System.Windows.Forms.View.List
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
        Me.Bt_Annuler.Location = New System.Drawing.Point(25, 551)
        Me.Bt_Annuler.Name = "Bt_Annuler"
        Me.Bt_Annuler.Size = New System.Drawing.Size(159, 45)
        Me.Bt_Annuler.TabIndex = 16
        Me.Bt_Annuler.Text = "Annuler"
        Me.Bt_Annuler.UseVisualStyleBackColor = False
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
        Me.Bt_Arret.Location = New System.Drawing.Point(190, 551)
        Me.Bt_Arret.Name = "Bt_Arret"
        Me.Bt_Arret.Size = New System.Drawing.Size(238, 45)
        Me.Bt_Arret.TabIndex = 17
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
        Me.Pn_Top.Size = New System.Drawing.Size(454, 50)
        Me.Pn_Top.TabIndex = 18
        '
        'Titre
        '
        Me.Titre.AutoSize = True
        Me.Titre.BackColor = System.Drawing.Color.Transparent
        Me.Titre.Font = New System.Drawing.Font("Euclid Circular A", 8.142858!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.ForeColor = System.Drawing.Color.White
        Me.Titre.Location = New System.Drawing.Point(20, 14)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(73, 25)
        Me.Titre.TabIndex = 19
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
        Me.Bt_quitter.Location = New System.Drawing.Point(399, 12)
        Me.Bt_quitter.Name = "Bt_quitter"
        Me.Bt_quitter.Size = New System.Drawing.Size(43, 29)
        Me.Bt_quitter.TabIndex = 20
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
        Me.Bt_Minimize.Location = New System.Drawing.Point(341, 7)
        Me.Bt_Minimize.Name = "Bt_Minimize"
        Me.Bt_Minimize.Size = New System.Drawing.Size(36, 38)
        Me.Bt_Minimize.TabIndex = 19
        Me.Bt_Minimize.UseVisualStyleBackColor = False
        '
        'BILAN_INS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(168.0!, 168.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(454, 619)
        Me.Controls.Add(Me.Pn_Top)
        Me.Controls.Add(Me.Bt_Arret)
        Me.Controls.Add(Me.Bt_Annuler)
        Me.Controls.Add(Me.Ls_Bilan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BILAN_INS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BILAN_INS"
        Me.Pn_Top.ResumeLayout(False)
        Me.Pn_Top.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ls_Bilan As ListView
    Friend WithEvents Bt_Annuler As Button
    Friend WithEvents Bt_Arret As Button
    Friend WithEvents Pn_Top As Panel
    Friend WithEvents Bt_quitter As Button
    Friend WithEvents Bt_Minimize As Button
    Friend WithEvents Titre As Label
End Class
