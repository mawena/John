<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginViewForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginViewForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.P_TOP = New Guna.UI2.WinForms.Guna2Panel()
        Me.COB_MAXIMAZE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.COB_MINIMIZE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.COB_CLOSE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.LBL_DESCRIPTION = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.P_LOGIN = New Guna.UI2.WinForms.Guna2Panel()
        Me.PB_LOGIN = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.P_FORM = New Guna.UI2.WinForms.Guna2Panel()
        Me.LBL_DISPLAY_PASSWORD = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CTS_DISPLAY_PASSWORD = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.LBL_PASSWORD_FIELD = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_USERNAME = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TB_PASSWORD_FIELD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_USERNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BT_CONNEXION = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.P_TOP.SuspendLayout()
        Me.P_LOGIN.SuspendLayout()
        CType(Me.PB_LOGIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_FORM.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'P_TOP
        '
        Me.P_TOP.BackColor = System.Drawing.Color.Transparent
        Me.P_TOP.Controls.Add(Me.COB_MAXIMAZE)
        Me.P_TOP.Controls.Add(Me.COB_MINIMIZE)
        Me.P_TOP.Controls.Add(Me.COB_CLOSE)
        Me.P_TOP.Controls.Add(Me.LBL_DESCRIPTION)
        Me.P_TOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_TOP.Location = New System.Drawing.Point(0, 0)
        Me.P_TOP.Name = "P_TOP"
        Me.P_TOP.Size = New System.Drawing.Size(435, 31)
        Me.P_TOP.TabIndex = 106
        '
        'COB_MAXIMAZE
        '
        Me.COB_MAXIMAZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.COB_MAXIMAZE.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.COB_MAXIMAZE.FillColor = System.Drawing.Color.DimGray
        Me.COB_MAXIMAZE.IconColor = System.Drawing.Color.White
        Me.COB_MAXIMAZE.Location = New System.Drawing.Point(381, 0)
        Me.COB_MAXIMAZE.Name = "COB_MAXIMAZE"
        Me.COB_MAXIMAZE.Size = New System.Drawing.Size(24, 24)
        Me.COB_MAXIMAZE.TabIndex = 2
        '
        'COB_MINIMIZE
        '
        Me.COB_MINIMIZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.COB_MINIMIZE.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.COB_MINIMIZE.FillColor = System.Drawing.Color.DimGray
        Me.COB_MINIMIZE.IconColor = System.Drawing.Color.White
        Me.COB_MINIMIZE.Location = New System.Drawing.Point(351, 0)
        Me.COB_MINIMIZE.Name = "COB_MINIMIZE"
        Me.COB_MINIMIZE.Size = New System.Drawing.Size(24, 24)
        Me.COB_MINIMIZE.TabIndex = 1
        '
        'COB_CLOSE
        '
        Me.COB_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.COB_CLOSE.FillColor = System.Drawing.Color.Red
        Me.COB_CLOSE.IconColor = System.Drawing.Color.White
        Me.COB_CLOSE.Location = New System.Drawing.Point(411, 0)
        Me.COB_CLOSE.Name = "COB_CLOSE"
        Me.COB_CLOSE.Size = New System.Drawing.Size(24, 24)
        Me.COB_CLOSE.TabIndex = 0
        '
        'LBL_DESCRIPTION
        '
        Me.LBL_DESCRIPTION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_DESCRIPTION.AutoSize = False
        Me.LBL_DESCRIPTION.BackColor = System.Drawing.Color.Transparent
        Me.LBL_DESCRIPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DESCRIPTION.ForeColor = System.Drawing.Color.White
        Me.LBL_DESCRIPTION.Location = New System.Drawing.Point(12, 1)
        Me.LBL_DESCRIPTION.Name = "LBL_DESCRIPTION"
        Me.LBL_DESCRIPTION.Size = New System.Drawing.Size(411, 27)
        Me.LBL_DESCRIPTION.TabIndex = 3
        Me.LBL_DESCRIPTION.Text = "CONNEXION"
        Me.LBL_DESCRIPTION.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_LOGIN
        '
        Me.P_LOGIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_LOGIN.BackColor = System.Drawing.Color.DimGray
        Me.P_LOGIN.Controls.Add(Me.PB_LOGIN)
        Me.P_LOGIN.Controls.Add(Me.P_FORM)
        Me.P_LOGIN.Location = New System.Drawing.Point(12, 37)
        Me.P_LOGIN.Name = "P_LOGIN"
        Me.P_LOGIN.Size = New System.Drawing.Size(411, 601)
        Me.P_LOGIN.TabIndex = 107
        '
        'PB_LOGIN
        '
        Me.PB_LOGIN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PB_LOGIN.Image = CType(resources.GetObject("PB_LOGIN.Image"), System.Drawing.Image)
        Me.PB_LOGIN.ImageRotate = 0!
        Me.PB_LOGIN.Location = New System.Drawing.Point(3, -3)
        Me.PB_LOGIN.Name = "PB_LOGIN"
        Me.PB_LOGIN.Size = New System.Drawing.Size(400, 320)
        Me.PB_LOGIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_LOGIN.TabIndex = 24
        Me.PB_LOGIN.TabStop = False
        '
        'P_FORM
        '
        Me.P_FORM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P_FORM.BackColor = System.Drawing.Color.Transparent
        Me.P_FORM.Controls.Add(Me.LBL_DISPLAY_PASSWORD)
        Me.P_FORM.Controls.Add(Me.CTS_DISPLAY_PASSWORD)
        Me.P_FORM.Controls.Add(Me.LBL_PASSWORD_FIELD)
        Me.P_FORM.Controls.Add(Me.LBL_USERNAME)
        Me.P_FORM.Controls.Add(Me.TB_PASSWORD_FIELD)
        Me.P_FORM.Controls.Add(Me.TB_USERNAME)
        Me.P_FORM.Controls.Add(Me.BT_CONNEXION)
        Me.P_FORM.Location = New System.Drawing.Point(3, 323)
        Me.P_FORM.Name = "P_FORM"
        Me.P_FORM.Size = New System.Drawing.Size(400, 269)
        Me.P_FORM.TabIndex = 23
        '
        'LBL_DISPLAY_PASSWORD
        '
        Me.LBL_DISPLAY_PASSWORD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBL_DISPLAY_PASSWORD.BackColor = System.Drawing.Color.Transparent
        Me.LBL_DISPLAY_PASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DISPLAY_PASSWORD.ForeColor = System.Drawing.Color.White
        Me.LBL_DISPLAY_PASSWORD.Location = New System.Drawing.Point(44, 183)
        Me.LBL_DISPLAY_PASSWORD.Name = "LBL_DISPLAY_PASSWORD"
        Me.LBL_DISPLAY_PASSWORD.Size = New System.Drawing.Size(170, 18)
        Me.LBL_DISPLAY_PASSWORD.TabIndex = 89
        Me.LBL_DISPLAY_PASSWORD.Text = "Afficher le mot de passe"
        '
        'CTS_DISPLAY_PASSWORD
        '
        Me.CTS_DISPLAY_PASSWORD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CTS_DISPLAY_PASSWORD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.CTS_DISPLAY_PASSWORD.CheckedState.InnerColor = System.Drawing.Color.White
        Me.CTS_DISPLAY_PASSWORD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CTS_DISPLAY_PASSWORD.Location = New System.Drawing.Point(3, 181)
        Me.CTS_DISPLAY_PASSWORD.Name = "CTS_DISPLAY_PASSWORD"
        Me.CTS_DISPLAY_PASSWORD.Size = New System.Drawing.Size(35, 20)
        Me.CTS_DISPLAY_PASSWORD.TabIndex = 88
        Me.CTS_DISPLAY_PASSWORD.Tag = "Modifier"
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'LBL_PASSWORD_FIELD
        '
        Me.LBL_PASSWORD_FIELD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_PASSWORD_FIELD.AutoSize = False
        Me.LBL_PASSWORD_FIELD.BackColor = System.Drawing.Color.Transparent
        Me.LBL_PASSWORD_FIELD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PASSWORD_FIELD.ForeColor = System.Drawing.Color.White
        Me.LBL_PASSWORD_FIELD.Location = New System.Drawing.Point(3, 106)
        Me.LBL_PASSWORD_FIELD.Name = "LBL_PASSWORD_FIELD"
        Me.LBL_PASSWORD_FIELD.Size = New System.Drawing.Size(394, 27)
        Me.LBL_PASSWORD_FIELD.TabIndex = 81
        Me.LBL_PASSWORD_FIELD.Text = "Mot de passe"
        Me.LBL_PASSWORD_FIELD.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_USERNAME
        '
        Me.LBL_USERNAME.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_USERNAME.AutoSize = False
        Me.LBL_USERNAME.BackColor = System.Drawing.Color.Transparent
        Me.LBL_USERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_USERNAME.ForeColor = System.Drawing.Color.White
        Me.LBL_USERNAME.Location = New System.Drawing.Point(3, 31)
        Me.LBL_USERNAME.Name = "LBL_USERNAME"
        Me.LBL_USERNAME.Size = New System.Drawing.Size(394, 27)
        Me.LBL_USERNAME.TabIndex = 80
        Me.LBL_USERNAME.Text = "Utilisateur"
        Me.LBL_USERNAME.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TB_PASSWORD_FIELD
        '
        Me.TB_PASSWORD_FIELD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_PASSWORD_FIELD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_PASSWORD_FIELD.DefaultText = "albert"
        Me.TB_PASSWORD_FIELD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_PASSWORD_FIELD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_PASSWORD_FIELD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PASSWORD_FIELD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PASSWORD_FIELD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PASSWORD_FIELD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PASSWORD_FIELD.ForeColor = System.Drawing.Color.Black
        Me.TB_PASSWORD_FIELD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PASSWORD_FIELD.Location = New System.Drawing.Point(3, 139)
        Me.TB_PASSWORD_FIELD.Name = "TB_PASSWORD_FIELD"
        Me.TB_PASSWORD_FIELD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_PASSWORD_FIELD.PlaceholderText = "Ex: MLQKSD#mq?"
        Me.TB_PASSWORD_FIELD.SelectedText = ""
        Me.TB_PASSWORD_FIELD.Size = New System.Drawing.Size(394, 36)
        Me.TB_PASSWORD_FIELD.TabIndex = 79
        Me.TB_PASSWORD_FIELD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_USERNAME
        '
        Me.TB_USERNAME.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_USERNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_USERNAME.DefaultText = "Brunot"
        Me.TB_USERNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_USERNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_USERNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_USERNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_USERNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_USERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TB_USERNAME.ForeColor = System.Drawing.Color.Black
        Me.TB_USERNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_USERNAME.Location = New System.Drawing.Point(3, 64)
        Me.TB_USERNAME.Name = "TB_USERNAME"
        Me.TB_USERNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_USERNAME.PlaceholderText = "Ex: john"
        Me.TB_USERNAME.SelectedText = ""
        Me.TB_USERNAME.Size = New System.Drawing.Size(394, 36)
        Me.TB_USERNAME.TabIndex = 78
        Me.TB_USERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BT_CONNEXION
        '
        Me.BT_CONNEXION.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BT_CONNEXION.Animated = True
        Me.BT_CONNEXION.BackColor = System.Drawing.Color.Transparent
        Me.BT_CONNEXION.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_CONNEXION.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_CONNEXION.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_CONNEXION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_CONNEXION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_CONNEXION.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BT_CONNEXION.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BT_CONNEXION.ForeColor = System.Drawing.Color.White
        Me.BT_CONNEXION.Image = CType(resources.GetObject("BT_CONNEXION.Image"), System.Drawing.Image)
        Me.BT_CONNEXION.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BT_CONNEXION.IndicateFocus = True
        Me.BT_CONNEXION.Location = New System.Drawing.Point(113, 221)
        Me.BT_CONNEXION.Name = "BT_CONNEXION"
        Me.BT_CONNEXION.Size = New System.Drawing.Size(175, 45)
        Me.BT_CONNEXION.TabIndex = 22
        Me.BT_CONNEXION.Text = "Connexion"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.LBL_DESCRIPTION
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'LoginViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(435, 650)
        Me.Controls.Add(Me.P_LOGIN)
        Me.Controls.Add(Me.P_TOP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginViewForm"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.P_TOP.ResumeLayout(False)
        Me.P_LOGIN.ResumeLayout(False)
        CType(Me.PB_LOGIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_FORM.ResumeLayout(False)
        Me.P_FORM.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents P_TOP As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents COB_MAXIMAZE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents COB_MINIMIZE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents COB_CLOSE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents LBL_DESCRIPTION As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents P_LOGIN As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents PB_LOGIN As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents P_FORM As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BT_CONNEXION As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LBL_PASSWORD_FIELD As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_USERNAME As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TB_PASSWORD_FIELD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_USERNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LBL_DISPLAY_PASSWORD As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CTS_DISPLAY_PASSWORD As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
