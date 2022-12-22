<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeesControl
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeesControl))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CB_FUNCTION = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_GENDER = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_SEARCH = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_PHONE_NUMBER = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_LAST_NAME = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CB_GENDER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_EMAIL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TB_PHONE_NUMBER = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BT_REFRESH = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_LAST_NAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BT_ADD = New Guna.UI2.WinForms.Guna2Button()
        Me.LBL_FIRST_NAME = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BT_DELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_SEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LBL_FUNCTION = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BT_UPDATE = New Guna.UI2.WinForms.Guna2Button()
        Me.DGV_EMPLOYEES = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TB_FIRST_NAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_EMAIL = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.DGV_EMPLOYEES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_FUNCTION
        '
        Me.CB_FUNCTION.BackColor = System.Drawing.Color.Transparent
        Me.CB_FUNCTION.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_FUNCTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_FUNCTION.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_FUNCTION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_FUNCTION.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_FUNCTION.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_FUNCTION.ItemHeight = 30
        Me.CB_FUNCTION.Items.AddRange(New Object() {"Service Scolarité", "Enseignant"})
        Me.CB_FUNCTION.Location = New System.Drawing.Point(570, 88)
        Me.CB_FUNCTION.Name = "CB_FUNCTION"
        Me.CB_FUNCTION.Size = New System.Drawing.Size(200, 36)
        Me.CB_FUNCTION.StartIndex = 0
        Me.CB_FUNCTION.TabIndex = 49
        '
        'LBL_GENDER
        '
        Me.LBL_GENDER.BackColor = System.Drawing.Color.Transparent
        Me.LBL_GENDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GENDER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_GENDER.Location = New System.Drawing.Point(57, 87)
        Me.LBL_GENDER.Name = "LBL_GENDER"
        Me.LBL_GENDER.Size = New System.Drawing.Size(67, 27)
        Me.LBL_GENDER.TabIndex = 46
        Me.LBL_GENDER.Text = "Genre"
        '
        'LBL_SEARCH
        '
        Me.LBL_SEARCH.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_SEARCH.Location = New System.Drawing.Point(0, 129)
        Me.LBL_SEARCH.Name = "LBL_SEARCH"
        Me.LBL_SEARCH.Size = New System.Drawing.Size(124, 27)
        Me.LBL_SEARCH.TabIndex = 48
        Me.LBL_SEARCH.Text = "Rechercher"
        '
        'LBL_PHONE_NUMBER
        '
        Me.LBL_PHONE_NUMBER.BackColor = System.Drawing.Color.Transparent
        Me.LBL_PHONE_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PHONE_NUMBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_PHONE_NUMBER.Location = New System.Drawing.Point(10, 45)
        Me.LBL_PHONE_NUMBER.Name = "LBL_PHONE_NUMBER"
        Me.LBL_PHONE_NUMBER.Size = New System.Drawing.Size(114, 27)
        Me.LBL_PHONE_NUMBER.TabIndex = 45
        Me.LBL_PHONE_NUMBER.Text = "Téléphone"
        '
        'LBL_LAST_NAME
        '
        Me.LBL_LAST_NAME.BackColor = System.Drawing.Color.Transparent
        Me.LBL_LAST_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LAST_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_LAST_NAME.Location = New System.Drawing.Point(74, 3)
        Me.LBL_LAST_NAME.Name = "LBL_LAST_NAME"
        Me.LBL_LAST_NAME.Size = New System.Drawing.Size(50, 27)
        Me.LBL_LAST_NAME.TabIndex = 42
        Me.LBL_LAST_NAME.Text = "Nom"
        '
        'CB_GENDER
        '
        Me.CB_GENDER.BackColor = System.Drawing.Color.Transparent
        Me.CB_GENDER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_GENDER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_GENDER.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GENDER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GENDER.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_GENDER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_GENDER.ItemHeight = 30
        Me.CB_GENDER.Items.AddRange(New Object() {"Femme", "Homme"})
        Me.CB_GENDER.Location = New System.Drawing.Point(130, 87)
        Me.CB_GENDER.Name = "CB_GENDER"
        Me.CB_GENDER.Size = New System.Drawing.Size(200, 36)
        Me.CB_GENDER.StartIndex = 1
        Me.CB_GENDER.TabIndex = 35
        '
        'LBL_EMAIL
        '
        Me.LBL_EMAIL.BackColor = System.Drawing.Color.Transparent
        Me.LBL_EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EMAIL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_EMAIL.Location = New System.Drawing.Point(503, 46)
        Me.LBL_EMAIL.Name = "LBL_EMAIL"
        Me.LBL_EMAIL.Size = New System.Drawing.Size(61, 27)
        Me.LBL_EMAIL.TabIndex = 47
        Me.LBL_EMAIL.Text = "Email"
        '
        'TB_PHONE_NUMBER
        '
        Me.TB_PHONE_NUMBER.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_PHONE_NUMBER.DefaultText = ""
        Me.TB_PHONE_NUMBER.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_PHONE_NUMBER.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_PHONE_NUMBER.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PHONE_NUMBER.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PHONE_NUMBER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PHONE_NUMBER.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_PHONE_NUMBER.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PHONE_NUMBER.Location = New System.Drawing.Point(130, 45)
        Me.TB_PHONE_NUMBER.Name = "TB_PHONE_NUMBER"
        Me.TB_PHONE_NUMBER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_PHONE_NUMBER.PlaceholderText = "Ex: +228 98 67 66 15"
        Me.TB_PHONE_NUMBER.SelectedText = ""
        Me.TB_PHONE_NUMBER.Size = New System.Drawing.Size(200, 36)
        Me.TB_PHONE_NUMBER.TabIndex = 33
        '
        'BT_REFRESH
        '
        Me.BT_REFRESH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_REFRESH.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_REFRESH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_REFRESH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_REFRESH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_REFRESH.FillColor = System.Drawing.Color.DimGray
        Me.BT_REFRESH.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_REFRESH.ForeColor = System.Drawing.Color.White
        Me.BT_REFRESH.Image = CType(resources.GetObject("BT_REFRESH.Image"), System.Drawing.Image)
        Me.BT_REFRESH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_REFRESH.Location = New System.Drawing.Point(947, 129)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(150, 36)
        Me.BT_REFRESH.TabIndex = 40
        Me.BT_REFRESH.Text = "Recharger"
        '
        'TB_LAST_NAME
        '
        Me.TB_LAST_NAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_LAST_NAME.DefaultText = ""
        Me.TB_LAST_NAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_LAST_NAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_LAST_NAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_LAST_NAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_LAST_NAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_LAST_NAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_LAST_NAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_LAST_NAME.Location = New System.Drawing.Point(130, 4)
        Me.TB_LAST_NAME.Name = "TB_LAST_NAME"
        Me.TB_LAST_NAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_LAST_NAME.PlaceholderText = "Ex: Eisntein"
        Me.TB_LAST_NAME.SelectedText = ""
        Me.TB_LAST_NAME.Size = New System.Drawing.Size(200, 36)
        Me.TB_LAST_NAME.TabIndex = 31
        '
        'BT_ADD
        '
        Me.BT_ADD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_ADD.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_ADD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_ADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_ADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_ADD.FillColor = System.Drawing.Color.DimGray
        Me.BT_ADD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_ADD.ForeColor = System.Drawing.Color.White
        Me.BT_ADD.Image = CType(resources.GetObject("BT_ADD.Image"), System.Drawing.Image)
        Me.BT_ADD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_ADD.Location = New System.Drawing.Point(947, 87)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(150, 36)
        Me.BT_ADD.TabIndex = 36
        Me.BT_ADD.Text = "Ajouter"
        '
        'LBL_FIRST_NAME
        '
        Me.LBL_FIRST_NAME.BackColor = System.Drawing.Color.Transparent
        Me.LBL_FIRST_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FIRST_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_FIRST_NAME.Location = New System.Drawing.Point(470, 5)
        Me.LBL_FIRST_NAME.Name = "LBL_FIRST_NAME"
        Me.LBL_FIRST_NAME.Size = New System.Drawing.Size(95, 27)
        Me.LBL_FIRST_NAME.TabIndex = 44
        Me.LBL_FIRST_NAME.Text = "Prénoms"
        '
        'BT_DELETE
        '
        Me.BT_DELETE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_DELETE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_DELETE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_DELETE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_DELETE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_DELETE.FillColor = System.Drawing.Color.DimGray
        Me.BT_DELETE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_DELETE.ForeColor = System.Drawing.Color.White
        Me.BT_DELETE.Image = CType(resources.GetObject("BT_DELETE.Image"), System.Drawing.Image)
        Me.BT_DELETE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_DELETE.Location = New System.Drawing.Point(947, 3)
        Me.BT_DELETE.Name = "BT_DELETE"
        Me.BT_DELETE.Size = New System.Drawing.Size(150, 36)
        Me.BT_DELETE.TabIndex = 37
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
        Me.TB_SEARCH.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_SEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_SEARCH.Location = New System.Drawing.Point(130, 129)
        Me.TB_SEARCH.Name = "TB_SEARCH"
        Me.TB_SEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_SEARCH.PlaceholderText = ""
        Me.TB_SEARCH.SelectedText = ""
        Me.TB_SEARCH.Size = New System.Drawing.Size(811, 36)
        Me.TB_SEARCH.TabIndex = 41
        '
        'LBL_FUNCTION
        '
        Me.LBL_FUNCTION.BackColor = System.Drawing.Color.Transparent
        Me.LBL_FUNCTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FUNCTION.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_FUNCTION.Location = New System.Drawing.Point(470, 88)
        Me.LBL_FUNCTION.Name = "LBL_FUNCTION"
        Me.LBL_FUNCTION.Size = New System.Drawing.Size(94, 27)
        Me.LBL_FUNCTION.TabIndex = 43
        Me.LBL_FUNCTION.Text = "Fonction"
        '
        'BT_UPDATE
        '
        Me.BT_UPDATE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_UPDATE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_UPDATE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_UPDATE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_UPDATE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_UPDATE.FillColor = System.Drawing.Color.DimGray
        Me.BT_UPDATE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BT_UPDATE.ForeColor = System.Drawing.Color.White
        Me.BT_UPDATE.Image = CType(resources.GetObject("BT_UPDATE.Image"), System.Drawing.Image)
        Me.BT_UPDATE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_UPDATE.Location = New System.Drawing.Point(947, 45)
        Me.BT_UPDATE.Name = "BT_UPDATE"
        Me.BT_UPDATE.Size = New System.Drawing.Size(150, 36)
        Me.BT_UPDATE.TabIndex = 39
        Me.BT_UPDATE.Text = "Modifier"
        '
        'DGV_EMPLOYEES
        '
        Me.DGV_EMPLOYEES.AllowUserToAddRows = False
        Me.DGV_EMPLOYEES.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_EMPLOYEES.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_EMPLOYEES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_EMPLOYEES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_EMPLOYEES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_EMPLOYEES.ColumnHeadersHeight = 30
        Me.DGV_EMPLOYEES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_EMPLOYEES.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_EMPLOYEES.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_EMPLOYEES.Location = New System.Drawing.Point(0, 171)
        Me.DGV_EMPLOYEES.Name = "DGV_EMPLOYEES"
        Me.DGV_EMPLOYEES.ReadOnly = True
        Me.DGV_EMPLOYEES.RowHeadersVisible = False
        Me.DGV_EMPLOYEES.Size = New System.Drawing.Size(1100, 326)
        Me.DGV_EMPLOYEES.TabIndex = 38
        Me.DGV_EMPLOYEES.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.DGV_EMPLOYEES.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_EMPLOYEES.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_EMPLOYEES.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_EMPLOYEES.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_EMPLOYEES.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_EMPLOYEES.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_EMPLOYEES.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_EMPLOYEES.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_EMPLOYEES.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_EMPLOYEES.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_EMPLOYEES.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_EMPLOYEES.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_EMPLOYEES.ThemeStyle.HeaderStyle.Height = 30
        Me.DGV_EMPLOYEES.ThemeStyle.ReadOnly = True
        Me.DGV_EMPLOYEES.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DGV_EMPLOYEES.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_EMPLOYEES.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_EMPLOYEES.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_EMPLOYEES.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_EMPLOYEES.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.DGV_EMPLOYEES.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'TB_FIRST_NAME
        '
        Me.TB_FIRST_NAME.AutoSize = True
        Me.TB_FIRST_NAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_FIRST_NAME.DefaultText = ""
        Me.TB_FIRST_NAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_FIRST_NAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_FIRST_NAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_FIRST_NAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_FIRST_NAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_FIRST_NAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_FIRST_NAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_FIRST_NAME.Location = New System.Drawing.Point(570, 5)
        Me.TB_FIRST_NAME.Name = "TB_FIRST_NAME"
        Me.TB_FIRST_NAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_FIRST_NAME.PlaceholderText = "Ex: Albert"
        Me.TB_FIRST_NAME.SelectedText = ""
        Me.TB_FIRST_NAME.Size = New System.Drawing.Size(200, 35)
        Me.TB_FIRST_NAME.TabIndex = 32
        '
        'TB_EMAIL
        '
        Me.TB_EMAIL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_EMAIL.DefaultText = ""
        Me.TB_EMAIL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_EMAIL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_EMAIL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_EMAIL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_EMAIL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_EMAIL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_EMAIL.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_EMAIL.Location = New System.Drawing.Point(570, 46)
        Me.TB_EMAIL.Name = "TB_EMAIL"
        Me.TB_EMAIL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_EMAIL.PlaceholderText = "Ex: albert@gmail.com"
        Me.TB_EMAIL.SelectedText = ""
        Me.TB_EMAIL.Size = New System.Drawing.Size(200, 36)
        Me.TB_EMAIL.TabIndex = 34
        '
        'EmployeesControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.CB_FUNCTION)
        Me.Controls.Add(Me.LBL_GENDER)
        Me.Controls.Add(Me.LBL_SEARCH)
        Me.Controls.Add(Me.LBL_PHONE_NUMBER)
        Me.Controls.Add(Me.LBL_LAST_NAME)
        Me.Controls.Add(Me.CB_GENDER)
        Me.Controls.Add(Me.LBL_EMAIL)
        Me.Controls.Add(Me.TB_PHONE_NUMBER)
        Me.Controls.Add(Me.BT_REFRESH)
        Me.Controls.Add(Me.TB_LAST_NAME)
        Me.Controls.Add(Me.BT_ADD)
        Me.Controls.Add(Me.LBL_FIRST_NAME)
        Me.Controls.Add(Me.BT_DELETE)
        Me.Controls.Add(Me.TB_SEARCH)
        Me.Controls.Add(Me.LBL_FUNCTION)
        Me.Controls.Add(Me.BT_UPDATE)
        Me.Controls.Add(Me.DGV_EMPLOYEES)
        Me.Controls.Add(Me.TB_FIRST_NAME)
        Me.Controls.Add(Me.TB_EMAIL)
        Me.Name = "EmployeesControl"
        Me.Size = New System.Drawing.Size(1100, 500)
        CType(Me.DGV_EMPLOYEES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_FUNCTION As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_GENDER As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_SEARCH As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_PHONE_NUMBER As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_LAST_NAME As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CB_GENDER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_EMAIL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TB_PHONE_NUMBER As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BT_REFRESH As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TB_LAST_NAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BT_ADD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LBL_FIRST_NAME As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BT_DELETE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TB_SEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LBL_FUNCTION As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BT_UPDATE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGV_EMPLOYEES As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TB_FIRST_NAME As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents TB_EMAIL As Guna.UI2.WinForms.Guna2TextBox
End Class
