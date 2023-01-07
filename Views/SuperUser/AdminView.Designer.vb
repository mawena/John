<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminView
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminView))
        Me.LBL_DESCRIPTION = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.P_MAIN = New Guna.UI2.WinForms.Guna2Panel()
        Me.LBL_EMAIL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_FIRST_NAME = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_GENDER = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_LAST_NAME = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_FUNCTION = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_PHONE_NUMBER = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BT_EMPLOYEES_MENU = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_UES_MENU = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_ECUES_MENU = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_USERS_MENU = New Guna.UI2.WinForms.Guna2Button()
        Me.PB_GESTION_ILLUSTRATION = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PB_ADMIN_ILLUSTRATION = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BT_INSTITUTES_MENU = New Guna.UI2.WinForms.Guna2Button()
        Me.P_TOP = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.COB_MAXIMAZE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.COB_MINIMIZE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.COB_CLOSE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.BT_CAREERS_MENU = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.PB_GESTION_ILLUSTRATION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ADMIN_ILLUSTRATION, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_TOP.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_DESCRIPTION
        '
        Me.LBL_DESCRIPTION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_DESCRIPTION.BackColor = System.Drawing.Color.Transparent
        Me.LBL_DESCRIPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DESCRIPTION.ForeColor = System.Drawing.Color.White
        Me.LBL_DESCRIPTION.Location = New System.Drawing.Point(653, 3)
        Me.LBL_DESCRIPTION.Name = "LBL_DESCRIPTION"
        Me.LBL_DESCRIPTION.Size = New System.Drawing.Size(143, 27)
        Me.LBL_DESCRIPTION.TabIndex = 3
        Me.LBL_DESCRIPTION.Text = "EMPLOYEES"
        '
        'P_MAIN
        '
        Me.P_MAIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_MAIN.BackColor = System.Drawing.Color.White
        Me.P_MAIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P_MAIN.Location = New System.Drawing.Point(192, 30)
        Me.P_MAIN.Name = "P_MAIN"
        Me.P_MAIN.Size = New System.Drawing.Size(1039, 619)
        Me.P_MAIN.TabIndex = 20
        '
        'LBL_EMAIL
        '
        Me.LBL_EMAIL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_EMAIL.BackColor = System.Drawing.Color.Transparent
        Me.LBL_EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EMAIL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_EMAIL.Location = New System.Drawing.Point(429, 45)
        Me.LBL_EMAIL.Name = "LBL_EMAIL"
        Me.LBL_EMAIL.Size = New System.Drawing.Size(50, 26)
        Me.LBL_EMAIL.TabIndex = 9
        Me.LBL_EMAIL.Text = "Email"
        '
        'LBL_FIRST_NAME
        '
        Me.LBL_FIRST_NAME.BackColor = System.Drawing.Color.Transparent
        Me.LBL_FIRST_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FIRST_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_FIRST_NAME.Location = New System.Drawing.Point(400, 4)
        Me.LBL_FIRST_NAME.Name = "LBL_FIRST_NAME"
        Me.LBL_FIRST_NAME.Size = New System.Drawing.Size(79, 26)
        Me.LBL_FIRST_NAME.TabIndex = 5
        Me.LBL_FIRST_NAME.Text = "Prénoms"
        '
        'LBL_GENDER
        '
        Me.LBL_GENDER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_GENDER.BackColor = System.Drawing.Color.Transparent
        Me.LBL_GENDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GENDER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_GENDER.Location = New System.Drawing.Point(844, 45)
        Me.LBL_GENDER.Name = "LBL_GENDER"
        Me.LBL_GENDER.Size = New System.Drawing.Size(56, 26)
        Me.LBL_GENDER.TabIndex = 11
        Me.LBL_GENDER.Text = "Genre"
        '
        'LBL_LAST_NAME
        '
        Me.LBL_LAST_NAME.BackColor = System.Drawing.Color.Transparent
        Me.LBL_LAST_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LAST_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_LAST_NAME.Location = New System.Drawing.Point(38, 4)
        Me.LBL_LAST_NAME.Name = "LBL_LAST_NAME"
        Me.LBL_LAST_NAME.Size = New System.Drawing.Size(44, 26)
        Me.LBL_LAST_NAME.TabIndex = 2
        Me.LBL_LAST_NAME.Text = "Nom"
        '
        'LBL_FUNCTION
        '
        Me.LBL_FUNCTION.BackColor = System.Drawing.Color.Transparent
        Me.LBL_FUNCTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FUNCTION.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_FUNCTION.Location = New System.Drawing.Point(15, 45)
        Me.LBL_FUNCTION.Name = "LBL_FUNCTION"
        Me.LBL_FUNCTION.Size = New System.Drawing.Size(67, 26)
        Me.LBL_FUNCTION.TabIndex = 13
        Me.LBL_FUNCTION.Text = "Fontion"
        '
        'LBL_PHONE_NUMBER
        '
        Me.LBL_PHONE_NUMBER.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_PHONE_NUMBER.BackColor = System.Drawing.Color.Transparent
        Me.LBL_PHONE_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PHONE_NUMBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_PHONE_NUMBER.Location = New System.Drawing.Point(804, 4)
        Me.LBL_PHONE_NUMBER.Name = "LBL_PHONE_NUMBER"
        Me.LBL_PHONE_NUMBER.Size = New System.Drawing.Size(96, 26)
        Me.LBL_PHONE_NUMBER.TabIndex = 7
        Me.LBL_PHONE_NUMBER.Text = "Téléphone"
        '
        'BT_EMPLOYEES_MENU
        '
        Me.BT_EMPLOYEES_MENU.BackColor = System.Drawing.Color.DimGray
        Me.BT_EMPLOYEES_MENU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_EMPLOYEES_MENU.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_EMPLOYEES_MENU.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_EMPLOYEES_MENU.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_EMPLOYEES_MENU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_EMPLOYEES_MENU.FillColor = System.Drawing.Color.DimGray
        Me.BT_EMPLOYEES_MENU.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_EMPLOYEES_MENU.ForeColor = System.Drawing.Color.White
        Me.BT_EMPLOYEES_MENU.Image = CType(resources.GetObject("BT_EMPLOYEES_MENU.Image"), System.Drawing.Image)
        Me.BT_EMPLOYEES_MENU.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_EMPLOYEES_MENU.Location = New System.Drawing.Point(4, 201)
        Me.BT_EMPLOYEES_MENU.Name = "BT_EMPLOYEES_MENU"
        Me.BT_EMPLOYEES_MENU.Size = New System.Drawing.Size(182, 45)
        Me.BT_EMPLOYEES_MENU.TabIndex = 21
        Me.BT_EMPLOYEES_MENU.Text = "Employées"
        '
        'BT_UES_MENU
        '
        Me.BT_UES_MENU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_UES_MENU.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_UES_MENU.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_UES_MENU.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_UES_MENU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_UES_MENU.FillColor = System.Drawing.Color.DimGray
        Me.BT_UES_MENU.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_UES_MENU.ForeColor = System.Drawing.Color.White
        Me.BT_UES_MENU.Image = CType(resources.GetObject("BT_UES_MENU.Image"), System.Drawing.Image)
        Me.BT_UES_MENU.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_UES_MENU.Location = New System.Drawing.Point(4, 354)
        Me.BT_UES_MENU.Name = "BT_UES_MENU"
        Me.BT_UES_MENU.Size = New System.Drawing.Size(182, 45)
        Me.BT_UES_MENU.TabIndex = 23
        Me.BT_UES_MENU.Text = "UEs"
        '
        'BT_ECUES_MENU
        '
        Me.BT_ECUES_MENU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_ECUES_MENU.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_ECUES_MENU.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_ECUES_MENU.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_ECUES_MENU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_ECUES_MENU.FillColor = System.Drawing.Color.DimGray
        Me.BT_ECUES_MENU.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_ECUES_MENU.ForeColor = System.Drawing.Color.White
        Me.BT_ECUES_MENU.Image = CType(resources.GetObject("BT_ECUES_MENU.Image"), System.Drawing.Image)
        Me.BT_ECUES_MENU.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_ECUES_MENU.Location = New System.Drawing.Point(4, 405)
        Me.BT_ECUES_MENU.Name = "BT_ECUES_MENU"
        Me.BT_ECUES_MENU.Size = New System.Drawing.Size(182, 45)
        Me.BT_ECUES_MENU.TabIndex = 24
        Me.BT_ECUES_MENU.Text = "ECUEs"
        '
        'BT_USERS_MENU
        '
        Me.BT_USERS_MENU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_USERS_MENU.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_USERS_MENU.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_USERS_MENU.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_USERS_MENU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_USERS_MENU.FillColor = System.Drawing.Color.DimGray
        Me.BT_USERS_MENU.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_USERS_MENU.ForeColor = System.Drawing.Color.White
        Me.BT_USERS_MENU.Image = CType(resources.GetObject("BT_USERS_MENU.Image"), System.Drawing.Image)
        Me.BT_USERS_MENU.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_USERS_MENU.Location = New System.Drawing.Point(4, 456)
        Me.BT_USERS_MENU.Name = "BT_USERS_MENU"
        Me.BT_USERS_MENU.Size = New System.Drawing.Size(182, 45)
        Me.BT_USERS_MENU.TabIndex = 25
        Me.BT_USERS_MENU.Text = "Utilisateurs"
        '
        'PB_GESTION_ILLUSTRATION
        '
        Me.PB_GESTION_ILLUSTRATION.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PB_GESTION_ILLUSTRATION.Image = CType(resources.GetObject("PB_GESTION_ILLUSTRATION.Image"), System.Drawing.Image)
        Me.PB_GESTION_ILLUSTRATION.ImageRotate = 0!
        Me.PB_GESTION_ILLUSTRATION.Location = New System.Drawing.Point(1, 518)
        Me.PB_GESTION_ILLUSTRATION.Name = "PB_GESTION_ILLUSTRATION"
        Me.PB_GESTION_ILLUSTRATION.Size = New System.Drawing.Size(185, 143)
        Me.PB_GESTION_ILLUSTRATION.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_GESTION_ILLUSTRATION.TabIndex = 26
        Me.PB_GESTION_ILLUSTRATION.TabStop = False
        '
        'PB_ADMIN_ILLUSTRATION
        '
        Me.PB_ADMIN_ILLUSTRATION.BackColor = System.Drawing.Color.Transparent
        Me.PB_ADMIN_ILLUSTRATION.Image = CType(resources.GetObject("PB_ADMIN_ILLUSTRATION.Image"), System.Drawing.Image)
        Me.PB_ADMIN_ILLUSTRATION.ImageRotate = 0!
        Me.PB_ADMIN_ILLUSTRATION.Location = New System.Drawing.Point(4, 37)
        Me.PB_ADMIN_ILLUSTRATION.Name = "PB_ADMIN_ILLUSTRATION"
        Me.PB_ADMIN_ILLUSTRATION.Size = New System.Drawing.Size(182, 143)
        Me.PB_ADMIN_ILLUSTRATION.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_ADMIN_ILLUSTRATION.TabIndex = 27
        Me.PB_ADMIN_ILLUSTRATION.TabStop = False
        '
        'BT_INSTITUTES_MENU
        '
        Me.BT_INSTITUTES_MENU.BackColor = System.Drawing.Color.DimGray
        Me.BT_INSTITUTES_MENU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_INSTITUTES_MENU.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_INSTITUTES_MENU.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_INSTITUTES_MENU.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_INSTITUTES_MENU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_INSTITUTES_MENU.FillColor = System.Drawing.Color.DimGray
        Me.BT_INSTITUTES_MENU.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_INSTITUTES_MENU.ForeColor = System.Drawing.Color.White
        Me.BT_INSTITUTES_MENU.Image = CType(resources.GetObject("BT_INSTITUTES_MENU.Image"), System.Drawing.Image)
        Me.BT_INSTITUTES_MENU.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_INSTITUTES_MENU.Location = New System.Drawing.Point(4, 252)
        Me.BT_INSTITUTES_MENU.Name = "BT_INSTITUTES_MENU"
        Me.BT_INSTITUTES_MENU.Size = New System.Drawing.Size(182, 45)
        Me.BT_INSTITUTES_MENU.TabIndex = 28
        Me.BT_INSTITUTES_MENU.Text = "Insituts"
        '
        'P_TOP
        '
        Me.P_TOP.Controls.Add(Me.Guna2HtmlLabel1)
        Me.P_TOP.Controls.Add(Me.COB_MAXIMAZE)
        Me.P_TOP.Controls.Add(Me.COB_MINIMIZE)
        Me.P_TOP.Controls.Add(Me.COB_CLOSE)
        Me.P_TOP.Controls.Add(Me.LBL_DESCRIPTION)
        Me.P_TOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_TOP.Location = New System.Drawing.Point(0, 0)
        Me.P_TOP.Name = "P_TOP"
        Me.P_TOP.Size = New System.Drawing.Size(1243, 31)
        Me.P_TOP.TabIndex = 105
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 1)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(194, 27)
        Me.Guna2HtmlLabel1.TabIndex = 106
        Me.Guna2HtmlLabel1.Text = "ADMINISTRATION"
        '
        'COB_MAXIMAZE
        '
        Me.COB_MAXIMAZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.COB_MAXIMAZE.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.COB_MAXIMAZE.FillColor = System.Drawing.Color.DimGray
        Me.COB_MAXIMAZE.IconColor = System.Drawing.Color.White
        Me.COB_MAXIMAZE.Location = New System.Drawing.Point(1189, 0)
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
        Me.COB_MINIMIZE.Location = New System.Drawing.Point(1159, 0)
        Me.COB_MINIMIZE.Name = "COB_MINIMIZE"
        Me.COB_MINIMIZE.Size = New System.Drawing.Size(24, 24)
        Me.COB_MINIMIZE.TabIndex = 1
        '
        'COB_CLOSE
        '
        Me.COB_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.COB_CLOSE.FillColor = System.Drawing.Color.Red
        Me.COB_CLOSE.IconColor = System.Drawing.Color.White
        Me.COB_CLOSE.Location = New System.Drawing.Point(1219, 0)
        Me.COB_CLOSE.Name = "COB_CLOSE"
        Me.COB_CLOSE.Size = New System.Drawing.Size(24, 24)
        Me.COB_CLOSE.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.P_TOP
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'BT_CAREERS_MENU
        '
        Me.BT_CAREERS_MENU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_CAREERS_MENU.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_CAREERS_MENU.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_CAREERS_MENU.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_CAREERS_MENU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_CAREERS_MENU.FillColor = System.Drawing.Color.DimGray
        Me.BT_CAREERS_MENU.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_CAREERS_MENU.ForeColor = System.Drawing.Color.White
        Me.BT_CAREERS_MENU.Image = CType(resources.GetObject("BT_CAREERS_MENU.Image"), System.Drawing.Image)
        Me.BT_CAREERS_MENU.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_CAREERS_MENU.Location = New System.Drawing.Point(4, 303)
        Me.BT_CAREERS_MENU.Name = "BT_CAREERS_MENU"
        Me.BT_CAREERS_MENU.Size = New System.Drawing.Size(182, 45)
        Me.BT_CAREERS_MENU.TabIndex = 106
        Me.BT_CAREERS_MENU.Text = "Parcours"
        '
        'AdminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1243, 661)
        Me.Controls.Add(Me.BT_CAREERS_MENU)
        Me.Controls.Add(Me.P_TOP)
        Me.Controls.Add(Me.BT_INSTITUTES_MENU)
        Me.Controls.Add(Me.PB_ADMIN_ILLUSTRATION)
        Me.Controls.Add(Me.PB_GESTION_ILLUSTRATION)
        Me.Controls.Add(Me.BT_USERS_MENU)
        Me.Controls.Add(Me.BT_ECUES_MENU)
        Me.Controls.Add(Me.BT_UES_MENU)
        Me.Controls.Add(Me.BT_EMPLOYEES_MENU)
        Me.Controls.Add(Me.P_MAIN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminView"
        Me.ShowIcon = False
        Me.Text = "  "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PB_GESTION_ILLUSTRATION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ADMIN_ILLUSTRATION, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_TOP.ResumeLayout(False)
        Me.P_TOP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LBL_DESCRIPTION As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents P_MAIN As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LBL_EMAIL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_FIRST_NAME As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_GENDER As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_LAST_NAME As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_FUNCTION As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_PHONE_NUMBER As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BT_EMPLOYEES_MENU As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_UES_MENU As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_ECUES_MENU As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_USERS_MENU As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PB_GESTION_ILLUSTRATION As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PB_ADMIN_ILLUSTRATION As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BT_INSTITUTES_MENU As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents P_TOP As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents COB_MAXIMAZE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents COB_MINIMIZE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents COB_CLOSE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BT_CAREERS_MENU As Guna.UI2.WinForms.Guna2Button
End Class
