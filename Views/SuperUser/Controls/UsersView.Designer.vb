<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersView
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersView))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LBL_SEARCH = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_PASSWORD_FIELD = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_USERNAME = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TB_PASSWORD_FIELD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BT_REFRESH = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_USERNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BT_ADD = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_DELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_SEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BT_UPDATE = New Guna.UI2.WinForms.Guna2Button()
        Me.DGV_USERS = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.functionField = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTS_UPDATE_PASSWORD = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.LBL_UPDATE_PASSWORD = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CB_EMPLOYEE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_EMPLOYEE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_DISPLAY_PASSWORD = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CTS_DISPLAY_PASSWORD = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        CType(Me.DGV_USERS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_SEARCH
        '
        Me.LBL_SEARCH.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_SEARCH.Location = New System.Drawing.Point(24, 149)
        Me.LBL_SEARCH.Name = "LBL_SEARCH"
        Me.LBL_SEARCH.Size = New System.Drawing.Size(124, 27)
        Me.LBL_SEARCH.TabIndex = 78
        Me.LBL_SEARCH.Text = "Rechercher"
        '
        'LBL_PASSWORD_FIELD
        '
        Me.LBL_PASSWORD_FIELD.BackColor = System.Drawing.Color.Transparent
        Me.LBL_PASSWORD_FIELD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PASSWORD_FIELD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_PASSWORD_FIELD.Location = New System.Drawing.Point(3, 87)
        Me.LBL_PASSWORD_FIELD.Name = "LBL_PASSWORD_FIELD"
        Me.LBL_PASSWORD_FIELD.Size = New System.Drawing.Size(145, 27)
        Me.LBL_PASSWORD_FIELD.TabIndex = 77
        Me.LBL_PASSWORD_FIELD.Text = "Mot de passe"
        '
        'LBL_USERNAME
        '
        Me.LBL_USERNAME.BackColor = System.Drawing.Color.Transparent
        Me.LBL_USERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_USERNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_USERNAME.Location = New System.Drawing.Point(38, 3)
        Me.LBL_USERNAME.Name = "LBL_USERNAME"
        Me.LBL_USERNAME.Size = New System.Drawing.Size(110, 27)
        Me.LBL_USERNAME.TabIndex = 76
        Me.LBL_USERNAME.Text = "Utilisateur"
        '
        'TB_PASSWORD_FIELD
        '
        Me.TB_PASSWORD_FIELD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_PASSWORD_FIELD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_PASSWORD_FIELD.DefaultText = ""
        Me.TB_PASSWORD_FIELD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_PASSWORD_FIELD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_PASSWORD_FIELD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PASSWORD_FIELD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PASSWORD_FIELD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PASSWORD_FIELD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PASSWORD_FIELD.ForeColor = System.Drawing.Color.Black
        Me.TB_PASSWORD_FIELD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PASSWORD_FIELD.Location = New System.Drawing.Point(154, 87)
        Me.TB_PASSWORD_FIELD.Name = "TB_PASSWORD_FIELD"
        Me.TB_PASSWORD_FIELD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_PASSWORD_FIELD.PlaceholderText = "Ex: MLQKSD#mq?"
        Me.TB_PASSWORD_FIELD.SelectedText = ""
        Me.TB_PASSWORD_FIELD.Size = New System.Drawing.Size(787, 36)
        Me.TB_PASSWORD_FIELD.TabIndex = 69
        '
        'BT_REFRESH
        '
        Me.BT_REFRESH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_REFRESH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_REFRESH.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_REFRESH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_REFRESH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_REFRESH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_REFRESH.FillColor = System.Drawing.Color.DimGray
        Me.BT_REFRESH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BT_REFRESH.ForeColor = System.Drawing.Color.White
        Me.BT_REFRESH.Image = CType(resources.GetObject("BT_REFRESH.Image"), System.Drawing.Image)
        Me.BT_REFRESH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_REFRESH.Location = New System.Drawing.Point(947, 149)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(150, 36)
        Me.BT_REFRESH.TabIndex = 74
        Me.BT_REFRESH.Text = "Recharger"
        '
        'TB_USERNAME
        '
        Me.TB_USERNAME.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_USERNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_USERNAME.DefaultText = ""
        Me.TB_USERNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_USERNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_USERNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_USERNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_USERNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_USERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_USERNAME.ForeColor = System.Drawing.Color.Black
        Me.TB_USERNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_USERNAME.Location = New System.Drawing.Point(154, 3)
        Me.TB_USERNAME.Name = "TB_USERNAME"
        Me.TB_USERNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_USERNAME.PlaceholderText = "Ex: john"
        Me.TB_USERNAME.SelectedText = ""
        Me.TB_USERNAME.Size = New System.Drawing.Size(787, 36)
        Me.TB_USERNAME.TabIndex = 68
        '
        'BT_ADD
        '
        Me.BT_ADD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_ADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_ADD.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_ADD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_ADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_ADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_ADD.FillColor = System.Drawing.Color.DimGray
        Me.BT_ADD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BT_ADD.ForeColor = System.Drawing.Color.White
        Me.BT_ADD.Image = CType(resources.GetObject("BT_ADD.Image"), System.Drawing.Image)
        Me.BT_ADD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_ADD.Location = New System.Drawing.Point(947, 87)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(150, 36)
        Me.BT_ADD.TabIndex = 70
        Me.BT_ADD.Text = "Ajouter"
        '
        'BT_DELETE
        '
        Me.BT_DELETE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_DELETE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_DELETE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_DELETE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_DELETE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_DELETE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_DELETE.FillColor = System.Drawing.Color.DimGray
        Me.BT_DELETE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BT_DELETE.ForeColor = System.Drawing.Color.White
        Me.BT_DELETE.Image = CType(resources.GetObject("BT_DELETE.Image"), System.Drawing.Image)
        Me.BT_DELETE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_DELETE.Location = New System.Drawing.Point(947, 3)
        Me.BT_DELETE.Name = "BT_DELETE"
        Me.BT_DELETE.Size = New System.Drawing.Size(150, 36)
        Me.BT_DELETE.TabIndex = 71
        Me.BT_DELETE.Text = "Supprimer"
        '
        'TB_SEARCH
        '
        Me.TB_SEARCH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_SEARCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_SEARCH.DefaultText = ""
        Me.TB_SEARCH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_SEARCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_SEARCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_SEARCH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_SEARCH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.TB_SEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_SEARCH.Location = New System.Drawing.Point(154, 149)
        Me.TB_SEARCH.Name = "TB_SEARCH"
        Me.TB_SEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_SEARCH.PlaceholderText = "Ex: John"
        Me.TB_SEARCH.SelectedText = ""
        Me.TB_SEARCH.Size = New System.Drawing.Size(787, 36)
        Me.TB_SEARCH.TabIndex = 75
        '
        'BT_UPDATE
        '
        Me.BT_UPDATE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_UPDATE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_UPDATE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_UPDATE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_UPDATE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_UPDATE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_UPDATE.FillColor = System.Drawing.Color.DimGray
        Me.BT_UPDATE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BT_UPDATE.ForeColor = System.Drawing.Color.White
        Me.BT_UPDATE.Image = CType(resources.GetObject("BT_UPDATE.Image"), System.Drawing.Image)
        Me.BT_UPDATE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_UPDATE.Location = New System.Drawing.Point(947, 45)
        Me.BT_UPDATE.Name = "BT_UPDATE"
        Me.BT_UPDATE.Size = New System.Drawing.Size(150, 36)
        Me.BT_UPDATE.TabIndex = 73
        Me.BT_UPDATE.Text = "Modifier"
        '
        'DGV_USERS
        '
        Me.DGV_USERS.AllowUserToAddRows = False
        Me.DGV_USERS.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_USERS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_USERS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_USERS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_USERS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_USERS.ColumnHeadersHeight = 30
        Me.DGV_USERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_USERS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.username, Me.functionField, Me.employee})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_USERS.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_USERS.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_USERS.Location = New System.Drawing.Point(0, 191)
        Me.DGV_USERS.Name = "DGV_USERS"
        Me.DGV_USERS.ReadOnly = True
        Me.DGV_USERS.RowHeadersVisible = False
        Me.DGV_USERS.Size = New System.Drawing.Size(1100, 306)
        Me.DGV_USERS.TabIndex = 72
        Me.DGV_USERS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.DGV_USERS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_USERS.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_USERS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_USERS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_USERS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_USERS.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_USERS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_USERS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_USERS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_USERS.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_USERS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_USERS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_USERS.ThemeStyle.HeaderStyle.Height = 30
        Me.DGV_USERS.ThemeStyle.ReadOnly = True
        Me.DGV_USERS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DGV_USERS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_USERS.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_USERS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_USERS.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_USERS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.DGV_USERS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.FillWeight = 9.0!
        Me.id.HeaderText = "Identifiant"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'username
        '
        Me.username.DataPropertyName = "username"
        Me.username.FillWeight = 20.0!
        Me.username.HeaderText = "Utilisateur"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        '
        'functionField
        '
        Me.functionField.DataPropertyName = "functionField"
        Me.functionField.FillWeight = 20.0!
        Me.functionField.HeaderText = "Fonction"
        Me.functionField.Name = "functionField"
        Me.functionField.ReadOnly = True
        '
        'employee
        '
        Me.employee.DataPropertyName = "employee"
        Me.employee.FillWeight = 50.0!
        Me.employee.HeaderText = "Employé"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        '
        'CTS_UPDATE_PASSWORD
        '
        Me.CTS_UPDATE_PASSWORD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTS_UPDATE_PASSWORD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTS_UPDATE_PASSWORD.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTS_UPDATE_PASSWORD.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.CTS_UPDATE_PASSWORD.CheckedState.InnerColor = System.Drawing.Color.White
        Me.CTS_UPDATE_PASSWORD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CTS_UPDATE_PASSWORD.Location = New System.Drawing.Point(685, 125)
        Me.CTS_UPDATE_PASSWORD.Name = "CTS_UPDATE_PASSWORD"
        Me.CTS_UPDATE_PASSWORD.Size = New System.Drawing.Size(35, 20)
        Me.CTS_UPDATE_PASSWORD.TabIndex = 82
        Me.CTS_UPDATE_PASSWORD.Tag = "Modifier"
        Me.CTS_UPDATE_PASSWORD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CTS_UPDATE_PASSWORD.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CTS_UPDATE_PASSWORD.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.CTS_UPDATE_PASSWORD.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'LBL_UPDATE_PASSWORD
        '
        Me.LBL_UPDATE_PASSWORD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_UPDATE_PASSWORD.BackColor = System.Drawing.Color.Transparent
        Me.LBL_UPDATE_PASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_UPDATE_PASSWORD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_UPDATE_PASSWORD.Location = New System.Drawing.Point(726, 125)
        Me.LBL_UPDATE_PASSWORD.Name = "LBL_UPDATE_PASSWORD"
        Me.LBL_UPDATE_PASSWORD.Size = New System.Drawing.Size(215, 18)
        Me.LBL_UPDATE_PASSWORD.TabIndex = 83
        Me.LBL_UPDATE_PASSWORD.Text = "Modifier aussi le mot de passe"
        '
        'CB_EMPLOYEE
        '
        Me.CB_EMPLOYEE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_EMPLOYEE.BackColor = System.Drawing.Color.Transparent
        Me.CB_EMPLOYEE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_EMPLOYEE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_EMPLOYEE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_EMPLOYEE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_EMPLOYEE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_EMPLOYEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CB_EMPLOYEE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_EMPLOYEE.ItemHeight = 30
        Me.CB_EMPLOYEE.Items.AddRange(New Object() {"john"})
        Me.CB_EMPLOYEE.Location = New System.Drawing.Point(154, 45)
        Me.CB_EMPLOYEE.Name = "CB_EMPLOYEE"
        Me.CB_EMPLOYEE.Size = New System.Drawing.Size(787, 36)
        Me.CB_EMPLOYEE.StartIndex = 0
        Me.CB_EMPLOYEE.TabIndex = 85
        '
        'LBL_EMPLOYEE
        '
        Me.LBL_EMPLOYEE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_EMPLOYEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EMPLOYEE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_EMPLOYEE.Location = New System.Drawing.Point(55, 45)
        Me.LBL_EMPLOYEE.Name = "LBL_EMPLOYEE"
        Me.LBL_EMPLOYEE.Size = New System.Drawing.Size(93, 27)
        Me.LBL_EMPLOYEE.TabIndex = 84
        Me.LBL_EMPLOYEE.Text = "Employé"
        '
        'LBL_DISPLAY_PASSWORD
        '
        Me.LBL_DISPLAY_PASSWORD.BackColor = System.Drawing.Color.Transparent
        Me.LBL_DISPLAY_PASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DISPLAY_PASSWORD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_DISPLAY_PASSWORD.Location = New System.Drawing.Point(195, 125)
        Me.LBL_DISPLAY_PASSWORD.Name = "LBL_DISPLAY_PASSWORD"
        Me.LBL_DISPLAY_PASSWORD.Size = New System.Drawing.Size(170, 18)
        Me.LBL_DISPLAY_PASSWORD.TabIndex = 87
        Me.LBL_DISPLAY_PASSWORD.Text = "Afficher le mot de passe"
        '
        'CTS_DISPLAY_PASSWORD
        '
        Me.CTS_DISPLAY_PASSWORD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.CTS_DISPLAY_PASSWORD.CheckedState.InnerColor = System.Drawing.Color.White
        Me.CTS_DISPLAY_PASSWORD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CTS_DISPLAY_PASSWORD.Location = New System.Drawing.Point(154, 125)
        Me.CTS_DISPLAY_PASSWORD.Name = "CTS_DISPLAY_PASSWORD"
        Me.CTS_DISPLAY_PASSWORD.Size = New System.Drawing.Size(35, 20)
        Me.CTS_DISPLAY_PASSWORD.TabIndex = 86
        Me.CTS_DISPLAY_PASSWORD.Tag = "Modifier"
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.CTS_DISPLAY_PASSWORD.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'UsersControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LBL_DISPLAY_PASSWORD)
        Me.Controls.Add(Me.CTS_DISPLAY_PASSWORD)
        Me.Controls.Add(Me.CB_EMPLOYEE)
        Me.Controls.Add(Me.LBL_EMPLOYEE)
        Me.Controls.Add(Me.LBL_UPDATE_PASSWORD)
        Me.Controls.Add(Me.CTS_UPDATE_PASSWORD)
        Me.Controls.Add(Me.LBL_SEARCH)
        Me.Controls.Add(Me.LBL_PASSWORD_FIELD)
        Me.Controls.Add(Me.LBL_USERNAME)
        Me.Controls.Add(Me.TB_PASSWORD_FIELD)
        Me.Controls.Add(Me.BT_REFRESH)
        Me.Controls.Add(Me.TB_USERNAME)
        Me.Controls.Add(Me.BT_ADD)
        Me.Controls.Add(Me.BT_DELETE)
        Me.Controls.Add(Me.TB_SEARCH)
        Me.Controls.Add(Me.BT_UPDATE)
        Me.Controls.Add(Me.DGV_USERS)
        Me.Name = "UsersControl"
        Me.Size = New System.Drawing.Size(1100, 500)
        CType(Me.DGV_USERS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_SEARCH As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_PASSWORD_FIELD As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_USERNAME As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TB_PASSWORD_FIELD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BT_REFRESH As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TB_USERNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BT_ADD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_DELETE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TB_SEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BT_UPDATE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGV_USERS As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CTS_UPDATE_PASSWORD As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents LBL_UPDATE_PASSWORD As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CB_EMPLOYEE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_EMPLOYEE As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_DISPLAY_PASSWORD As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CTS_DISPLAY_PASSWORD As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents functionField As DataGridViewTextBoxColumn
    Friend WithEvents employee As DataGridViewTextBoxColumn
End Class
