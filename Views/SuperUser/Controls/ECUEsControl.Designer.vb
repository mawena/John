<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ECUEsControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ECUEsControl))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LBL_UES = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_SEARCH = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_LIBELLE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BT_REFRESH = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_LIBELLE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BT_ADD = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_DELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_SEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BT_UPDATE = New Guna.UI2.WinForms.Guna2Button()
        Me.DGV_ECUES = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.CB_TEACHER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_TEACHER = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CB_NB_CREDIT = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_NB_CREDIT = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CLB_UES = New System.Windows.Forms.CheckedListBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Credits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enseignant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UEs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV_ECUES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_UES
        '
        Me.LBL_UES.BackColor = System.Drawing.Color.Transparent
        Me.LBL_UES.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_UES.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_UES.Location = New System.Drawing.Point(81, 87)
        Me.LBL_UES.Name = "LBL_UES"
        Me.LBL_UES.Size = New System.Drawing.Size(46, 27)
        Me.LBL_UES.TabIndex = 93
        Me.LBL_UES.Text = "UEs"
        '
        'LBL_SEARCH
        '
        Me.LBL_SEARCH.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_SEARCH.Location = New System.Drawing.Point(3, 129)
        Me.LBL_SEARCH.Name = "LBL_SEARCH"
        Me.LBL_SEARCH.Size = New System.Drawing.Size(124, 27)
        Me.LBL_SEARCH.TabIndex = 92
        Me.LBL_SEARCH.Text = "Rechercher"
        '
        'LBL_LIBELLE
        '
        Me.LBL_LIBELLE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_LIBELLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LIBELLE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_LIBELLE.Location = New System.Drawing.Point(54, 3)
        Me.LBL_LIBELLE.Name = "LBL_LIBELLE"
        Me.LBL_LIBELLE.Size = New System.Drawing.Size(73, 27)
        Me.LBL_LIBELLE.TabIndex = 90
        Me.LBL_LIBELLE.Text = "Libelle"
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
        Me.BT_REFRESH.Location = New System.Drawing.Point(947, 129)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(150, 36)
        Me.BT_REFRESH.TabIndex = 88
        Me.BT_REFRESH.Text = "Recharger"
        '
        'TB_LIBELLE
        '
        Me.TB_LIBELLE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_LIBELLE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_LIBELLE.DefaultText = ""
        Me.TB_LIBELLE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_LIBELLE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_LIBELLE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_LIBELLE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_LIBELLE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_LIBELLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_LIBELLE.ForeColor = System.Drawing.Color.Black
        Me.TB_LIBELLE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_LIBELLE.Location = New System.Drawing.Point(134, 3)
        Me.TB_LIBELLE.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_LIBELLE.Name = "TB_LIBELLE"
        Me.TB_LIBELLE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_LIBELLE.PlaceholderText = "Ex: RAD"
        Me.TB_LIBELLE.SelectedText = ""
        Me.TB_LIBELLE.Size = New System.Drawing.Size(275, 36)
        Me.TB_LIBELLE.TabIndex = 82
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
        Me.BT_ADD.TabIndex = 84
        Me.BT_ADD.Text = "Ajouter"
        '
        'BT_DELETE
        '
        Me.BT_DELETE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_DELETE.Animated = True
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
        Me.BT_DELETE.IndicateFocus = True
        Me.BT_DELETE.Location = New System.Drawing.Point(947, 3)
        Me.BT_DELETE.Name = "BT_DELETE"
        Me.BT_DELETE.Size = New System.Drawing.Size(150, 36)
        Me.BT_DELETE.TabIndex = 85
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
        Me.TB_SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.TB_SEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_SEARCH.Location = New System.Drawing.Point(133, 130)
        Me.TB_SEARCH.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_SEARCH.Name = "TB_SEARCH"
        Me.TB_SEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_SEARCH.PlaceholderText = "Ex: RAD"
        Me.TB_SEARCH.SelectedText = ""
        Me.TB_SEARCH.Size = New System.Drawing.Size(807, 35)
        Me.TB_SEARCH.TabIndex = 89
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
        Me.BT_UPDATE.TabIndex = 87
        Me.BT_UPDATE.Text = "Modifier"
        '
        'DGV_ECUES
        '
        Me.DGV_ECUES.AllowUserToAddRows = False
        Me.DGV_ECUES.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_ECUES.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ECUES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_ECUES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ECUES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ECUES.ColumnHeadersHeight = 30
        Me.DGV_ECUES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_ECUES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Libelle, Me.Credits, Me.Enseignant, Me.UEs})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ECUES.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ECUES.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_ECUES.Location = New System.Drawing.Point(0, 171)
        Me.DGV_ECUES.Name = "DGV_ECUES"
        Me.DGV_ECUES.ReadOnly = True
        Me.DGV_ECUES.RowHeadersVisible = False
        Me.DGV_ECUES.Size = New System.Drawing.Size(1100, 326)
        Me.DGV_ECUES.TabIndex = 86
        Me.DGV_ECUES.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.DGV_ECUES.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_ECUES.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_ECUES.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_ECUES.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_ECUES.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_ECUES.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ECUES.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_ECUES.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_ECUES.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_ECUES.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ECUES.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_ECUES.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_ECUES.ThemeStyle.HeaderStyle.Height = 30
        Me.DGV_ECUES.ThemeStyle.ReadOnly = True
        Me.DGV_ECUES.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DGV_ECUES.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_ECUES.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ECUES.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_ECUES.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_ECUES.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.DGV_ECUES.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'CB_TEACHER
        '
        Me.CB_TEACHER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_TEACHER.BackColor = System.Drawing.Color.Transparent
        Me.CB_TEACHER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_TEACHER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_TEACHER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_TEACHER.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_TEACHER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_TEACHER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_TEACHER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_TEACHER.ItemHeight = 30
        Me.CB_TEACHER.Location = New System.Drawing.Point(702, 3)
        Me.CB_TEACHER.Name = "CB_TEACHER"
        Me.CB_TEACHER.Size = New System.Drawing.Size(239, 36)
        Me.CB_TEACHER.TabIndex = 96
        '
        'LBL_TEACHER
        '
        Me.LBL_TEACHER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_TEACHER.BackColor = System.Drawing.Color.Transparent
        Me.LBL_TEACHER.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TEACHER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_TEACHER.Location = New System.Drawing.Point(575, 3)
        Me.LBL_TEACHER.Name = "LBL_TEACHER"
        Me.LBL_TEACHER.Size = New System.Drawing.Size(121, 27)
        Me.LBL_TEACHER.TabIndex = 97
        Me.LBL_TEACHER.Text = "Enseignant"
        '
        'CB_NB_CREDIT
        '
        Me.CB_NB_CREDIT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_NB_CREDIT.BackColor = System.Drawing.Color.Transparent
        Me.CB_NB_CREDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_NB_CREDIT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_NB_CREDIT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_NB_CREDIT.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_NB_CREDIT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_NB_CREDIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_NB_CREDIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_NB_CREDIT.ItemHeight = 30
        Me.CB_NB_CREDIT.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.CB_NB_CREDIT.Location = New System.Drawing.Point(500, 3)
        Me.CB_NB_CREDIT.Name = "CB_NB_CREDIT"
        Me.CB_NB_CREDIT.Size = New System.Drawing.Size(69, 36)
        Me.CB_NB_CREDIT.StartIndex = 0
        Me.CB_NB_CREDIT.TabIndex = 99
        '
        'LBL_NB_CREDIT
        '
        Me.LBL_NB_CREDIT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_NB_CREDIT.BackColor = System.Drawing.Color.Transparent
        Me.LBL_NB_CREDIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NB_CREDIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_NB_CREDIT.Location = New System.Drawing.Point(416, 3)
        Me.LBL_NB_CREDIT.Name = "LBL_NB_CREDIT"
        Me.LBL_NB_CREDIT.Size = New System.Drawing.Size(78, 27)
        Me.LBL_NB_CREDIT.TabIndex = 98
        Me.LBL_NB_CREDIT.Text = "Crédits"
        '
        'CLB_UES
        '
        Me.CLB_UES.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CLB_UES.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLB_UES.FormattingEnabled = True
        Me.CLB_UES.Items.AddRange(New Object() {"Mathématiques", "Sciences-Physique", "Chimie"})
        Me.CLB_UES.Location = New System.Drawing.Point(133, 42)
        Me.CLB_UES.Name = "CLB_UES"
        Me.CLB_UES.Size = New System.Drawing.Size(808, 72)
        Me.CLB_UES.TabIndex = 100
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.FillWeight = 12.0!
        Me.id.HeaderText = "Identifiant"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Libelle
        '
        Me.Libelle.DataPropertyName = "libelle"
        Me.Libelle.FillWeight = 15.0!
        Me.Libelle.HeaderText = "Libelle"
        Me.Libelle.Name = "Libelle"
        Me.Libelle.ReadOnly = True
        Me.Libelle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Credits
        '
        Me.Credits.DataPropertyName = "credit"
        Me.Credits.FillWeight = 10.0!
        Me.Credits.HeaderText = "Credits"
        Me.Credits.Name = "Credits"
        Me.Credits.ReadOnly = True
        '
        'Enseignant
        '
        Me.Enseignant.DataPropertyName = "teacher"
        Me.Enseignant.FillWeight = 20.0!
        Me.Enseignant.HeaderText = "Enseignant"
        Me.Enseignant.Name = "Enseignant"
        Me.Enseignant.ReadOnly = True
        '
        'UEs
        '
        Me.UEs.DataPropertyName = "ues"
        Me.UEs.FillWeight = 70.0!
        Me.UEs.HeaderText = "UEs"
        Me.UEs.Name = "UEs"
        Me.UEs.ReadOnly = True
        '
        'ECUEsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CLB_UES)
        Me.Controls.Add(Me.CB_NB_CREDIT)
        Me.Controls.Add(Me.LBL_NB_CREDIT)
        Me.Controls.Add(Me.LBL_TEACHER)
        Me.Controls.Add(Me.CB_TEACHER)
        Me.Controls.Add(Me.LBL_UES)
        Me.Controls.Add(Me.LBL_SEARCH)
        Me.Controls.Add(Me.LBL_LIBELLE)
        Me.Controls.Add(Me.BT_REFRESH)
        Me.Controls.Add(Me.TB_LIBELLE)
        Me.Controls.Add(Me.BT_ADD)
        Me.Controls.Add(Me.BT_DELETE)
        Me.Controls.Add(Me.TB_SEARCH)
        Me.Controls.Add(Me.BT_UPDATE)
        Me.Controls.Add(Me.DGV_ECUES)
        Me.Name = "ECUEsControl"
        Me.Size = New System.Drawing.Size(1100, 500)
        CType(Me.DGV_ECUES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_UES As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_SEARCH As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_LIBELLE As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BT_REFRESH As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TB_LIBELLE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BT_ADD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_DELETE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TB_SEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BT_UPDATE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGV_ECUES As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CB_TEACHER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_TEACHER As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CB_NB_CREDIT As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_NB_CREDIT As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CLB_UES As CheckedListBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Libelle As DataGridViewTextBoxColumn
    Friend WithEvents Credits As DataGridViewTextBoxColumn
    Friend WithEvents Enseignant As DataGridViewTextBoxColumn
    Friend WithEvents UEs As DataGridViewTextBoxColumn
End Class
