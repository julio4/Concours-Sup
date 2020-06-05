<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INS_EPREUVES
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
        Me.Lb_NomCandidat = New System.Windows.Forms.Label()
        Me.Cb_Région = New System.Windows.Forms.ComboBox()
        Me.Lb_Région = New System.Windows.Forms.Label()
        Me.Gb_Ecrit = New System.Windows.Forms.GroupBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Lb_EcritsRestants = New System.Windows.Forms.Label()
        Me.EcritsRestants = New System.Windows.Forms.Label()
        Me.OrauxRestants = New System.Windows.Forms.Label()
        Me.Lb_OralsRestants = New System.Windows.Forms.Label()
        Me.Bt_ValiderInsEpreuves = New System.Windows.Forms.Button()
        Me.Bt_AbandonnerIns = New System.Windows.Forms.Button()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.Gb_Facultatif = New System.Windows.Forms.GroupBox()
        Me.Cb_EpreuvesFacultatives = New System.Windows.Forms.ComboBox()
        Me.Non = New System.Windows.Forms.RadioButton()
        Me.Oui = New System.Windows.Forms.RadioButton()
        Me.Gb_Oral = New System.Windows.Forms.GroupBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.Lb_NOM = New System.Windows.Forms.Label()
        Me.TimerEpreuves = New System.Windows.Forms.Timer(Me.components)
        Me.Gb_Ecrit.SuspendLayout()
        Me.Gb_Facultatif.SuspendLayout()
        Me.Gb_Oral.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_NomCandidat
        '
        Me.Lb_NomCandidat.AutoSize = True
        Me.Lb_NomCandidat.Location = New System.Drawing.Point(12, 9)
        Me.Lb_NomCandidat.Name = "Lb_NomCandidat"
        Me.Lb_NomCandidat.Size = New System.Drawing.Size(165, 25)
        Me.Lb_NomCandidat.TabIndex = 0
        Me.Lb_NomCandidat.Text = "Nom du candidat:"
        '
        'Cb_Région
        '
        Me.Cb_Région.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Région.FormattingEnabled = True
        Me.Cb_Région.Location = New System.Drawing.Point(155, 52)
        Me.Cb_Région.Name = "Cb_Région"
        Me.Cb_Région.Size = New System.Drawing.Size(142, 32)
        Me.Cb_Région.TabIndex = 1
        '
        'Lb_Région
        '
        Me.Lb_Région.AutoSize = True
        Me.Lb_Région.Location = New System.Drawing.Point(43, 55)
        Me.Lb_Région.Name = "Lb_Région"
        Me.Lb_Région.Size = New System.Drawing.Size(73, 25)
        Me.Lb_Région.TabIndex = 2
        Me.Lb_Région.Text = "Région"
        '
        'Gb_Ecrit
        '
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox7)
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox8)
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox9)
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox10)
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox11)
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox12)
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox6)
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox5)
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox4)
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox3)
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox2)
        Me.Gb_Ecrit.Controls.Add(Me.CheckBox1)
        Me.Gb_Ecrit.Location = New System.Drawing.Point(50, 113)
        Me.Gb_Ecrit.Name = "Gb_Ecrit"
        Me.Gb_Ecrit.Size = New System.Drawing.Size(495, 328)
        Me.Gb_Ecrit.TabIndex = 3
        Me.Gb_Ecrit.TabStop = False
        Me.Gb_Ecrit.Text = "Ecrit"
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(233, 40)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(140, 29)
        Me.CheckBox7.TabIndex = 11
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(233, 87)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(140, 29)
        Me.CheckBox8.TabIndex = 10
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(233, 134)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(140, 29)
        Me.CheckBox9.TabIndex = 9
        Me.CheckBox9.Text = "CheckBox9"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(233, 181)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox10.TabIndex = 8
        Me.CheckBox10.Text = "CheckBox10"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(233, 228)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox11.TabIndex = 7
        Me.CheckBox11.Text = "CheckBox11"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(233, 275)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox12.TabIndex = 6
        Me.CheckBox12.Text = "CheckBox12"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(47, 275)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(140, 29)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(47, 228)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(140, 29)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(47, 181)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(140, 29)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(47, 134)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(140, 29)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(47, 87)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(140, 29)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(47, 40)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(140, 29)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Lb_EcritsRestants
        '
        Me.Lb_EcritsRestants.AutoSize = True
        Me.Lb_EcritsRestants.Location = New System.Drawing.Point(130, 476)
        Me.Lb_EcritsRestants.Name = "Lb_EcritsRestants"
        Me.Lb_EcritsRestants.Size = New System.Drawing.Size(228, 25)
        Me.Lb_EcritsRestants.TabIndex = 5
        Me.Lb_EcritsRestants.Text = "Epreuves Ecrits restants:"
        '
        'EcritsRestants
        '
        Me.EcritsRestants.AutoSize = True
        Me.EcritsRestants.Location = New System.Drawing.Point(364, 476)
        Me.EcritsRestants.Name = "EcritsRestants"
        Me.EcritsRestants.Size = New System.Drawing.Size(23, 25)
        Me.EcritsRestants.TabIndex = 6
        Me.EcritsRestants.Text = "4"
        '
        'OrauxRestants
        '
        Me.OrauxRestants.AutoSize = True
        Me.OrauxRestants.Location = New System.Drawing.Point(670, 476)
        Me.OrauxRestants.Name = "OrauxRestants"
        Me.OrauxRestants.Size = New System.Drawing.Size(23, 25)
        Me.OrauxRestants.TabIndex = 8
        Me.OrauxRestants.Text = "3"
        '
        'Lb_OralsRestants
        '
        Me.Lb_OralsRestants.AutoSize = True
        Me.Lb_OralsRestants.Location = New System.Drawing.Point(436, 476)
        Me.Lb_OralsRestants.Name = "Lb_OralsRestants"
        Me.Lb_OralsRestants.Size = New System.Drawing.Size(227, 25)
        Me.Lb_OralsRestants.TabIndex = 7
        Me.Lb_OralsRestants.Text = "Epreuves Orals restants:"
        '
        'Bt_ValiderInsEpreuves
        '
        Me.Bt_ValiderInsEpreuves.Location = New System.Drawing.Point(804, 476)
        Me.Bt_ValiderInsEpreuves.Name = "Bt_ValiderInsEpreuves"
        Me.Bt_ValiderInsEpreuves.Size = New System.Drawing.Size(327, 87)
        Me.Bt_ValiderInsEpreuves.TabIndex = 9
        Me.Bt_ValiderInsEpreuves.Text = "Valider"
        Me.Bt_ValiderInsEpreuves.UseVisualStyleBackColor = True
        '
        'Bt_AbandonnerIns
        '
        Me.Bt_AbandonnerIns.Location = New System.Drawing.Point(333, 513)
        Me.Bt_AbandonnerIns.Name = "Bt_AbandonnerIns"
        Me.Bt_AbandonnerIns.Size = New System.Drawing.Size(189, 43)
        Me.Bt_AbandonnerIns.TabIndex = 14
        Me.Bt_AbandonnerIns.Text = "Abandonner"
        Me.Bt_AbandonnerIns.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Location = New System.Drawing.Point(40, 228)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox17.TabIndex = 13
        Me.CheckBox17.Text = "CheckBox17"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Location = New System.Drawing.Point(40, 134)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox15.TabIndex = 15
        Me.CheckBox15.Text = "CheckBox15"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Location = New System.Drawing.Point(40, 275)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox18.TabIndex = 12
        Me.CheckBox18.Text = "CheckBox18"
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(40, 87)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox14.TabIndex = 16
        Me.CheckBox14.Text = "CheckBox14"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(40, 181)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox16.TabIndex = 14
        Me.CheckBox16.Text = "CheckBox16"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(40, 40)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox13.TabIndex = 17
        Me.CheckBox13.Text = "CheckBox13"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'Gb_Facultatif
        '
        Me.Gb_Facultatif.Controls.Add(Me.Cb_EpreuvesFacultatives)
        Me.Gb_Facultatif.Controls.Add(Me.Non)
        Me.Gb_Facultatif.Controls.Add(Me.Oui)
        Me.Gb_Facultatif.Location = New System.Drawing.Point(1031, 113)
        Me.Gb_Facultatif.Name = "Gb_Facultatif"
        Me.Gb_Facultatif.Size = New System.Drawing.Size(262, 192)
        Me.Gb_Facultatif.TabIndex = 4
        Me.Gb_Facultatif.TabStop = False
        Me.Gb_Facultatif.Text = "Epreuve facultative"
        '
        'Cb_EpreuvesFacultatives
        '
        Me.Cb_EpreuvesFacultatives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_EpreuvesFacultatives.FormattingEnabled = True
        Me.Cb_EpreuvesFacultatives.Location = New System.Drawing.Point(39, 134)
        Me.Cb_EpreuvesFacultatives.Name = "Cb_EpreuvesFacultatives"
        Me.Cb_EpreuvesFacultatives.Size = New System.Drawing.Size(180, 32)
        Me.Cb_EpreuvesFacultatives.TabIndex = 16
        '
        'Non
        '
        Me.Non.AutoSize = True
        Me.Non.Location = New System.Drawing.Point(39, 87)
        Me.Non.Name = "Non"
        Me.Non.Size = New System.Drawing.Size(73, 29)
        Me.Non.TabIndex = 1
        Me.Non.TabStop = True
        Me.Non.Text = "Non"
        Me.Non.UseVisualStyleBackColor = True
        '
        'Oui
        '
        Me.Oui.AutoSize = True
        Me.Oui.Location = New System.Drawing.Point(39, 40)
        Me.Oui.Name = "Oui"
        Me.Oui.Size = New System.Drawing.Size(68, 29)
        Me.Oui.TabIndex = 0
        Me.Oui.TabStop = True
        Me.Oui.Text = "Oui"
        Me.Oui.UseVisualStyleBackColor = True
        '
        'Gb_Oral
        '
        Me.Gb_Oral.Controls.Add(Me.CheckBox20)
        Me.Gb_Oral.Controls.Add(Me.CheckBox21)
        Me.Gb_Oral.Controls.Add(Me.CheckBox19)
        Me.Gb_Oral.Controls.Add(Me.CheckBox18)
        Me.Gb_Oral.Controls.Add(Me.CheckBox16)
        Me.Gb_Oral.Controls.Add(Me.CheckBox17)
        Me.Gb_Oral.Controls.Add(Me.CheckBox13)
        Me.Gb_Oral.Controls.Add(Me.CheckBox14)
        Me.Gb_Oral.Controls.Add(Me.CheckBox15)
        Me.Gb_Oral.Location = New System.Drawing.Point(570, 113)
        Me.Gb_Oral.Name = "Gb_Oral"
        Me.Gb_Oral.Size = New System.Drawing.Size(441, 328)
        Me.Gb_Oral.TabIndex = 12
        Me.Gb_Oral.TabStop = False
        Me.Gb_Oral.Text = "Oral"
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Location = New System.Drawing.Point(234, 87)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox20.TabIndex = 10
        Me.CheckBox20.Text = "CheckBox20"
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Location = New System.Drawing.Point(234, 134)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox21.TabIndex = 9
        Me.CheckBox21.Text = "CheckBox21"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Location = New System.Drawing.Point(234, 40)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox19.TabIndex = 11
        Me.CheckBox19.Text = "CheckBox19"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'Lb_NOM
        '
        Me.Lb_NOM.AutoSize = True
        Me.Lb_NOM.Location = New System.Drawing.Point(183, 9)
        Me.Lb_NOM.Name = "Lb_NOM"
        Me.Lb_NOM.Size = New System.Drawing.Size(59, 25)
        Me.Lb_NOM.TabIndex = 15
        Me.Lb_NOM.Text = "NOM"
        '
        'TimerEpreuves
        '
        '
        'INS_EPREUVES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1337, 591)
        Me.Controls.Add(Me.Lb_NOM)
        Me.Controls.Add(Me.Gb_Oral)
        Me.Controls.Add(Me.Bt_AbandonnerIns)
        Me.Controls.Add(Me.Bt_ValiderInsEpreuves)
        Me.Controls.Add(Me.OrauxRestants)
        Me.Controls.Add(Me.Lb_OralsRestants)
        Me.Controls.Add(Me.EcritsRestants)
        Me.Controls.Add(Me.Lb_EcritsRestants)
        Me.Controls.Add(Me.Gb_Facultatif)
        Me.Controls.Add(Me.Gb_Ecrit)
        Me.Controls.Add(Me.Lb_Région)
        Me.Controls.Add(Me.Cb_Région)
        Me.Controls.Add(Me.Lb_NomCandidat)
        Me.Name = "INS_EPREUVES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Gb_Ecrit.ResumeLayout(False)
        Me.Gb_Ecrit.PerformLayout()
        Me.Gb_Facultatif.ResumeLayout(False)
        Me.Gb_Facultatif.PerformLayout()
        Me.Gb_Oral.ResumeLayout(False)
        Me.Gb_Oral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_NomCandidat As Label
    Friend WithEvents Cb_Région As ComboBox
    Friend WithEvents Lb_Région As Label
    Friend WithEvents Gb_Ecrit As GroupBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Lb_EcritsRestants As Label
    Friend WithEvents EcritsRestants As Label
    Friend WithEvents OrauxRestants As Label
    Friend WithEvents Lb_OralsRestants As Label
    Friend WithEvents Bt_ValiderInsEpreuves As Button
    Friend WithEvents Bt_AbandonnerIns As Button
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox18 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents Gb_Facultatif As GroupBox
    Friend WithEvents Gb_Oral As GroupBox
    Friend WithEvents CheckBox19 As CheckBox
    Friend WithEvents CheckBox20 As CheckBox
    Friend WithEvents CheckBox21 As CheckBox
    Friend WithEvents Lb_NOM As Label
    Friend WithEvents Non As RadioButton
    Friend WithEvents Oui As RadioButton
    Friend WithEvents Cb_EpreuvesFacultatives As ComboBox
    Friend WithEvents TimerEpreuves As Timer
End Class
