﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UEsView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UEsView))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CB_SEMESTER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_SEMESTER = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_SEARCH = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_CAREERS = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_LIBELLE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BT_REFRESH = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_LIBELLE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BT_ADD = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_DELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_SEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BT_UPDATE = New Guna.UI2.WinForms.Guna2Button()
        Me.DGV_UES = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.careers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLB_CAREERS = New System.Windows.Forms.CheckedListBox()
        Me.CB_INSTITUTE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_INSTITUTE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.DGV_UES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_SEMESTER
        '
        Me.CB_SEMESTER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_SEMESTER.BackColor = System.Drawing.Color.Transparent
        Me.CB_SEMESTER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_SEMESTER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_SEMESTER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SEMESTER.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_SEMESTER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_SEMESTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_SEMESTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_SEMESTER.ItemHeight = 30
        Me.CB_SEMESTER.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.CB_SEMESTER.Location = New System.Drawing.Point(887, 3)
        Me.CB_SEMESTER.Name = "CB_SEMESTER"
        Me.CB_SEMESTER.Size = New System.Drawing.Size(54, 36)
        Me.CB_SEMESTER.StartIndex = 0
        Me.CB_SEMESTER.TabIndex = 93
        '
        'LBL_SEMESTER
        '
        Me.LBL_SEMESTER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_SEMESTER.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SEMESTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SEMESTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_SEMESTER.Location = New System.Drawing.Point(779, 3)
        Me.LBL_SEMESTER.Name = "LBL_SEMESTER"
        Me.LBL_SEMESTER.Size = New System.Drawing.Size(102, 27)
        Me.LBL_SEMESTER.TabIndex = 92
        Me.LBL_SEMESTER.Text = "Semestre"
        '
        'LBL_SEARCH
        '
        Me.LBL_SEARCH.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_SEARCH.Location = New System.Drawing.Point(3, 184)
        Me.LBL_SEARCH.Name = "LBL_SEARCH"
        Me.LBL_SEARCH.Size = New System.Drawing.Size(124, 27)
        Me.LBL_SEARCH.TabIndex = 91
        Me.LBL_SEARCH.Text = "Rechercher"
        '
        'LBL_CAREERS
        '
        Me.LBL_CAREERS.BackColor = System.Drawing.Color.Transparent
        Me.LBL_CAREERS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CAREERS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_CAREERS.Location = New System.Drawing.Point(30, 106)
        Me.LBL_CAREERS.Name = "LBL_CAREERS"
        Me.LBL_CAREERS.Size = New System.Drawing.Size(97, 27)
        Me.LBL_CAREERS.TabIndex = 90
        Me.LBL_CAREERS.Text = "Parcours"
        '
        'LBL_LIBELLE
        '
        Me.LBL_LIBELLE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_LIBELLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LIBELLE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_LIBELLE.Location = New System.Drawing.Point(54, 3)
        Me.LBL_LIBELLE.Name = "LBL_LIBELLE"
        Me.LBL_LIBELLE.Size = New System.Drawing.Size(73, 27)
        Me.LBL_LIBELLE.TabIndex = 89
        Me.LBL_LIBELLE.Text = "Libellé"
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
        Me.BT_REFRESH.Location = New System.Drawing.Point(947, 184)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(150, 36)
        Me.BT_REFRESH.TabIndex = 87
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
        Me.TB_LIBELLE.Location = New System.Drawing.Point(133, 3)
        Me.TB_LIBELLE.Name = "TB_LIBELLE"
        Me.TB_LIBELLE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_LIBELLE.PlaceholderText = "Ex: Mathématiques"
        Me.TB_LIBELLE.SelectedText = ""
        Me.TB_LIBELLE.Size = New System.Drawing.Size(645, 36)
        Me.TB_LIBELLE.TabIndex = 81
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
        Me.BT_ADD.TabIndex = 83
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
        Me.BT_DELETE.TabIndex = 84
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
        Me.TB_SEARCH.Location = New System.Drawing.Point(133, 184)
        Me.TB_SEARCH.Name = "TB_SEARCH"
        Me.TB_SEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_SEARCH.PlaceholderText = "Ex : Mathématiques"
        Me.TB_SEARCH.SelectedText = ""
        Me.TB_SEARCH.Size = New System.Drawing.Size(808, 36)
        Me.TB_SEARCH.TabIndex = 88
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
        Me.BT_UPDATE.TabIndex = 86
        Me.BT_UPDATE.Text = "Modifier"
        '
        'DGV_UES
        '
        Me.DGV_UES.AllowUserToAddRows = False
        Me.DGV_UES.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_UES.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_UES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_UES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_UES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_UES.ColumnHeadersHeight = 30
        Me.DGV_UES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_UES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.libelle, Me.semester, Me.careers})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_UES.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_UES.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_UES.Location = New System.Drawing.Point(0, 226)
        Me.DGV_UES.Name = "DGV_UES"
        Me.DGV_UES.ReadOnly = True
        Me.DGV_UES.RowHeadersVisible = False
        Me.DGV_UES.Size = New System.Drawing.Size(1100, 271)
        Me.DGV_UES.TabIndex = 85
        Me.DGV_UES.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.DGV_UES.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_UES.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_UES.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_UES.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_UES.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_UES.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_UES.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_UES.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_UES.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_UES.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_UES.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_UES.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_UES.ThemeStyle.HeaderStyle.Height = 30
        Me.DGV_UES.ThemeStyle.ReadOnly = True
        Me.DGV_UES.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DGV_UES.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_UES.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_UES.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_UES.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_UES.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.DGV_UES.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.FillWeight = 8.0!
        Me.id.HeaderText = "Identifiant"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'libelle
        '
        Me.libelle.DataPropertyName = "libelle"
        Me.libelle.FillWeight = 40.0!
        Me.libelle.HeaderText = "Libellé"
        Me.libelle.Name = "libelle"
        Me.libelle.ReadOnly = True
        '
        'semester
        '
        Me.semester.DataPropertyName = "semester"
        Me.semester.FillWeight = 8.0!
        Me.semester.HeaderText = "Semestre"
        Me.semester.Name = "semester"
        Me.semester.ReadOnly = True
        '
        'careers
        '
        Me.careers.DataPropertyName = "careers"
        Me.careers.FillWeight = 40.0!
        Me.careers.HeaderText = "Parcours"
        Me.careers.Name = "careers"
        Me.careers.ReadOnly = True
        '
        'CLB_CAREERS
        '
        Me.CLB_CAREERS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CLB_CAREERS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLB_CAREERS.FormattingEnabled = True
        Me.CLB_CAREERS.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CLB_CAREERS.Location = New System.Drawing.Point(133, 89)
        Me.CLB_CAREERS.Name = "CLB_CAREERS"
        Me.CLB_CAREERS.Size = New System.Drawing.Size(808, 89)
        Me.CLB_CAREERS.TabIndex = 101
        '
        'CB_INSTITUTE
        '
        Me.CB_INSTITUTE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_INSTITUTE.BackColor = System.Drawing.Color.Transparent
        Me.CB_INSTITUTE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_INSTITUTE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_INSTITUTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INSTITUTE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_INSTITUTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_INSTITUTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CB_INSTITUTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_INSTITUTE.ItemHeight = 30
        Me.CB_INSTITUTE.Items.AddRange(New Object() {"1-ISTIN", "2-ISEG", "3-FDS", "4-ISSG"})
        Me.CB_INSTITUTE.Location = New System.Drawing.Point(133, 45)
        Me.CB_INSTITUTE.Name = "CB_INSTITUTE"
        Me.CB_INSTITUTE.Size = New System.Drawing.Size(808, 36)
        Me.CB_INSTITUTE.StartIndex = 0
        Me.CB_INSTITUTE.TabIndex = 102
        '
        'LBL_INSTITUTE
        '
        Me.LBL_INSTITUTE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_INSTITUTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_INSTITUTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_INSTITUTE.Location = New System.Drawing.Point(53, 45)
        Me.LBL_INSTITUTE.Name = "LBL_INSTITUTE"
        Me.LBL_INSTITUTE.Size = New System.Drawing.Size(74, 27)
        Me.LBL_INSTITUTE.TabIndex = 103
        Me.LBL_INSTITUTE.Text = "Institut"
        '
        'UEsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LBL_INSTITUTE)
        Me.Controls.Add(Me.CB_INSTITUTE)
        Me.Controls.Add(Me.CLB_CAREERS)
        Me.Controls.Add(Me.CB_SEMESTER)
        Me.Controls.Add(Me.LBL_SEMESTER)
        Me.Controls.Add(Me.LBL_SEARCH)
        Me.Controls.Add(Me.LBL_CAREERS)
        Me.Controls.Add(Me.LBL_LIBELLE)
        Me.Controls.Add(Me.BT_REFRESH)
        Me.Controls.Add(Me.TB_LIBELLE)
        Me.Controls.Add(Me.BT_ADD)
        Me.Controls.Add(Me.BT_DELETE)
        Me.Controls.Add(Me.TB_SEARCH)
        Me.Controls.Add(Me.BT_UPDATE)
        Me.Controls.Add(Me.DGV_UES)
        Me.Name = "UEsControl"
        Me.Size = New System.Drawing.Size(1100, 500)
        CType(Me.DGV_UES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_SEMESTER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_SEMESTER As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_SEARCH As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_CAREERS As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_LIBELLE As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BT_REFRESH As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TB_LIBELLE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BT_ADD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_DELETE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TB_SEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BT_UPDATE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DGV_UES As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CLB_CAREERS As CheckedListBox
    Friend WithEvents CB_INSTITUTE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_INSTITUTE As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents libelle As DataGridViewTextBoxColumn
    Friend WithEvents semester As DataGridViewTextBoxColumn
    Friend WithEvents careers As DataGridViewTextBoxColumn
End Class
