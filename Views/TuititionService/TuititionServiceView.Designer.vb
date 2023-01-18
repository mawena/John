<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TuititionServiceView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TuititionServiceView))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LBL_PHONE_NUMBER = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_LAST_NAME = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CB_GENDER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_EMAIL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TB_PHONE_NUMBER = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_LAST_NAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LBL_FIRST_NAME = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TB_FIRST_NAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_EMAIL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ComboBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ComboBox3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ComboBox4 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ComboBox5 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.PIC_STUDENT = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.P_TOP = New Guna.UI2.WinForms.Guna2Panel()
        Me.BT_LOGOUT = New Guna.UI2.WinForms.Guna2Button()
        Me.COB_MAXIMAZE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.COB_MINIMIZE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.COB_CLOSE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.LBL_DESCRIPTION = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BT_REFRESH = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_ADD = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_DELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_UPDATE = New Guna.UI2.WinForms.Guna2Button()
        Me.P_MAIN = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGV_STUDENTS = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ecueName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateField = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typeField = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.weightField = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PIC_STUDENT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_TOP.SuspendLayout()
        Me.P_MAIN.SuspendLayout()
        CType(Me.DGV_STUDENTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_PHONE_NUMBER
        '
        Me.LBL_PHONE_NUMBER.BackColor = System.Drawing.Color.Transparent
        Me.LBL_PHONE_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PHONE_NUMBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_PHONE_NUMBER.Location = New System.Drawing.Point(631, 88)
        Me.LBL_PHONE_NUMBER.Name = "LBL_PHONE_NUMBER"
        Me.LBL_PHONE_NUMBER.Size = New System.Drawing.Size(114, 27)
        Me.LBL_PHONE_NUMBER.TabIndex = 81
        Me.LBL_PHONE_NUMBER.Text = "Téléphone"
        '
        'LBL_LAST_NAME
        '
        Me.LBL_LAST_NAME.BackColor = System.Drawing.Color.Transparent
        Me.LBL_LAST_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LAST_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_LAST_NAME.Location = New System.Drawing.Point(279, 4)
        Me.LBL_LAST_NAME.Name = "LBL_LAST_NAME"
        Me.LBL_LAST_NAME.Size = New System.Drawing.Size(50, 27)
        Me.LBL_LAST_NAME.TabIndex = 79
        Me.LBL_LAST_NAME.Text = "Nom"
        '
        'CB_GENDER
        '
        Me.CB_GENDER.BackColor = System.Drawing.Color.Transparent
        Me.CB_GENDER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_GENDER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_GENDER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_GENDER.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GENDER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GENDER.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_GENDER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_GENDER.ItemHeight = 30
        Me.CB_GENDER.Items.AddRange(New Object() {"Féminin", "Masculin"})
        Me.CB_GENDER.Location = New System.Drawing.Point(751, 46)
        Me.CB_GENDER.Name = "CB_GENDER"
        Me.CB_GENDER.Size = New System.Drawing.Size(266, 36)
        Me.CB_GENDER.StartIndex = 1
        Me.CB_GENDER.TabIndex = 78
        '
        'LBL_EMAIL
        '
        Me.LBL_EMAIL.BackColor = System.Drawing.Color.Transparent
        Me.LBL_EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EMAIL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_EMAIL.Location = New System.Drawing.Point(268, 87)
        Me.LBL_EMAIL.Name = "LBL_EMAIL"
        Me.LBL_EMAIL.Size = New System.Drawing.Size(61, 27)
        Me.LBL_EMAIL.TabIndex = 83
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
        Me.TB_PHONE_NUMBER.Location = New System.Drawing.Point(751, 88)
        Me.TB_PHONE_NUMBER.Name = "TB_PHONE_NUMBER"
        Me.TB_PHONE_NUMBER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_PHONE_NUMBER.PlaceholderText = "Ex: +228 98 67 66 15"
        Me.TB_PHONE_NUMBER.SelectedText = ""
        Me.TB_PHONE_NUMBER.Size = New System.Drawing.Size(266, 36)
        Me.TB_PHONE_NUMBER.TabIndex = 76
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
        Me.TB_LAST_NAME.Location = New System.Drawing.Point(335, 0)
        Me.TB_LAST_NAME.Name = "TB_LAST_NAME"
        Me.TB_LAST_NAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_LAST_NAME.PlaceholderText = "Ex: Eisntein"
        Me.TB_LAST_NAME.SelectedText = ""
        Me.TB_LAST_NAME.Size = New System.Drawing.Size(265, 36)
        Me.TB_LAST_NAME.TabIndex = 74
        '
        'LBL_FIRST_NAME
        '
        Me.LBL_FIRST_NAME.BackColor = System.Drawing.Color.Transparent
        Me.LBL_FIRST_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FIRST_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_FIRST_NAME.Location = New System.Drawing.Point(650, 4)
        Me.LBL_FIRST_NAME.Name = "LBL_FIRST_NAME"
        Me.LBL_FIRST_NAME.Size = New System.Drawing.Size(95, 27)
        Me.LBL_FIRST_NAME.TabIndex = 80
        Me.LBL_FIRST_NAME.Text = "Prénoms"
        '
        'TB_FIRST_NAME
        '
        Me.TB_FIRST_NAME.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.TB_FIRST_NAME.Location = New System.Drawing.Point(751, 4)
        Me.TB_FIRST_NAME.Name = "TB_FIRST_NAME"
        Me.TB_FIRST_NAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_FIRST_NAME.PlaceholderText = "Ex: Albert"
        Me.TB_FIRST_NAME.SelectedText = ""
        Me.TB_FIRST_NAME.Size = New System.Drawing.Size(266, 35)
        Me.TB_FIRST_NAME.TabIndex = 75
        '
        'TB_EMAIL
        '
        Me.TB_EMAIL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_EMAIL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_EMAIL.DefaultText = ""
        Me.TB_EMAIL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_EMAIL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_EMAIL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_EMAIL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_EMAIL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_EMAIL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_EMAIL.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_EMAIL.Location = New System.Drawing.Point(335, 88)
        Me.TB_EMAIL.Name = "TB_EMAIL"
        Me.TB_EMAIL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_EMAIL.PlaceholderText = "Ex: albert@gmail.com"
        Me.TB_EMAIL.SelectedText = ""
        Me.TB_EMAIL.Size = New System.Drawing.Size(265, 36)
        Me.TB_EMAIL.TabIndex = 77
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(678, 46)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(67, 27)
        Me.Guna2HtmlLabel1.TabIndex = 89
        Me.Guna2HtmlLabel1.Text = "Genre"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(660, 130)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(85, 27)
        Me.Guna2HtmlLabel2.TabIndex = 91
        Me.Guna2HtmlLabel2.Text = "Parcour"
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"Féminin", "Masculin"})
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(751, 130)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(266, 36)
        Me.Guna2ComboBox1.StartIndex = 1
        Me.Guna2ComboBox1.TabIndex = 90
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(216, 46)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(113, 27)
        Me.Guna2HtmlLabel3.TabIndex = 93
        Me.Guna2HtmlLabel3.Text = "Naissance"
        '
        'Guna2ComboBox2
        '
        Me.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox2.ItemHeight = 30
        Me.Guna2ComboBox2.Items.AddRange(New Object() {"Féminin", "Masculin"})
        Me.Guna2ComboBox2.Location = New System.Drawing.Point(335, 46)
        Me.Guna2ComboBox2.Name = "Guna2ComboBox2"
        Me.Guna2ComboBox2.Size = New System.Drawing.Size(265, 36)
        Me.Guna2ComboBox2.StartIndex = 1
        Me.Guna2ComboBox2.TabIndex = 92
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(133, 239)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(1040, 36)
        Me.Guna2TextBox1.TabIndex = 94
        '
        'Guna2ComboBox3
        '
        Me.Guna2ComboBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox3.ItemHeight = 30
        Me.Guna2ComboBox3.Items.AddRange(New Object() {"Féminin", "Masculin"})
        Me.Guna2ComboBox3.Location = New System.Drawing.Point(133, 197)
        Me.Guna2ComboBox3.Name = "Guna2ComboBox3"
        Me.Guna2ComboBox3.Size = New System.Drawing.Size(234, 36)
        Me.Guna2ComboBox3.StartIndex = 1
        Me.Guna2ComboBox3.TabIndex = 96
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(3, 163)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(1170, 28)
        Me.Guna2HtmlLabel5.TabIndex = 97
        Me.Guna2HtmlLabel5.Text = "Filtres"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(53, 197)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(74, 27)
        Me.Guna2HtmlLabel6.TabIndex = 98
        Me.Guna2HtmlLabel6.Text = "Institut"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(373, 197)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(97, 27)
        Me.Guna2HtmlLabel7.TabIndex = 100
        Me.Guna2HtmlLabel7.Text = "Parcours"
        '
        'Guna2ComboBox4
        '
        Me.Guna2ComboBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ComboBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox4.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox4.ItemHeight = 30
        Me.Guna2ComboBox4.Items.AddRange(New Object() {"Féminin", "Masculin"})
        Me.Guna2ComboBox4.Location = New System.Drawing.Point(476, 197)
        Me.Guna2ComboBox4.Name = "Guna2ComboBox4"
        Me.Guna2ComboBox4.Size = New System.Drawing.Size(349, 36)
        Me.Guna2ComboBox4.StartIndex = 1
        Me.Guna2ComboBox4.TabIndex = 99
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(3, 239)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(124, 27)
        Me.Guna2HtmlLabel4.TabIndex = 95
        Me.Guna2HtmlLabel4.Text = "Rechercher"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(831, 197)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(102, 27)
        Me.Guna2HtmlLabel8.TabIndex = 102
        Me.Guna2HtmlLabel8.Text = "Semestre"
        '
        'Guna2ComboBox5
        '
        Me.Guna2ComboBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ComboBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox5.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox5.ItemHeight = 30
        Me.Guna2ComboBox5.Items.AddRange(New Object() {"Féminin", "Masculin"})
        Me.Guna2ComboBox5.Location = New System.Drawing.Point(939, 197)
        Me.Guna2ComboBox5.Name = "Guna2ComboBox5"
        Me.Guna2ComboBox5.Size = New System.Drawing.Size(234, 36)
        Me.Guna2ComboBox5.StartIndex = 1
        Me.Guna2ComboBox5.TabIndex = 101
        '
        'PIC_STUDENT
        '
        Me.PIC_STUDENT.BackColor = System.Drawing.Color.DimGray
        Me.PIC_STUDENT.FillColor = System.Drawing.Color.DimGray
        Me.PIC_STUDENT.ImageRotate = 0!
        Me.PIC_STUDENT.Location = New System.Drawing.Point(3, 4)
        Me.PIC_STUDENT.Name = "PIC_STUDENT"
        Me.PIC_STUDENT.Size = New System.Drawing.Size(172, 162)
        Me.PIC_STUDENT.TabIndex = 103
        Me.PIC_STUDENT.TabStop = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 0
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorColor = System.Drawing.Color.Black
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'P_TOP
        '
        Me.P_TOP.BackColor = System.Drawing.Color.Transparent
        Me.P_TOP.Controls.Add(Me.BT_LOGOUT)
        Me.P_TOP.Controls.Add(Me.COB_MAXIMAZE)
        Me.P_TOP.Controls.Add(Me.COB_MINIMIZE)
        Me.P_TOP.Controls.Add(Me.COB_CLOSE)
        Me.P_TOP.Controls.Add(Me.LBL_DESCRIPTION)
        Me.P_TOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_TOP.Location = New System.Drawing.Point(0, 0)
        Me.P_TOP.Name = "P_TOP"
        Me.P_TOP.Size = New System.Drawing.Size(1200, 31)
        Me.P_TOP.TabIndex = 106
        '
        'BT_LOGOUT
        '
        Me.BT_LOGOUT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_LOGOUT.Animated = True
        Me.BT_LOGOUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_LOGOUT.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_LOGOUT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_LOGOUT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_LOGOUT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_LOGOUT.FillColor = System.Drawing.Color.DimGray
        Me.BT_LOGOUT.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BT_LOGOUT.ForeColor = System.Drawing.Color.White
        Me.BT_LOGOUT.Image = CType(resources.GetObject("BT_LOGOUT.Image"), System.Drawing.Image)
        Me.BT_LOGOUT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BT_LOGOUT.IndicateFocus = True
        Me.BT_LOGOUT.Location = New System.Drawing.Point(978, 0)
        Me.BT_LOGOUT.Name = "BT_LOGOUT"
        Me.BT_LOGOUT.Size = New System.Drawing.Size(132, 24)
        Me.BT_LOGOUT.TabIndex = 108
        Me.BT_LOGOUT.Text = "Deconnexion"
        '
        'COB_MAXIMAZE
        '
        Me.COB_MAXIMAZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.COB_MAXIMAZE.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.COB_MAXIMAZE.FillColor = System.Drawing.Color.DimGray
        Me.COB_MAXIMAZE.IconColor = System.Drawing.Color.White
        Me.COB_MAXIMAZE.Location = New System.Drawing.Point(1146, 0)
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
        Me.COB_MINIMIZE.Location = New System.Drawing.Point(1116, 0)
        Me.COB_MINIMIZE.Name = "COB_MINIMIZE"
        Me.COB_MINIMIZE.Size = New System.Drawing.Size(24, 24)
        Me.COB_MINIMIZE.TabIndex = 1
        '
        'COB_CLOSE
        '
        Me.COB_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.COB_CLOSE.FillColor = System.Drawing.Color.Red
        Me.COB_CLOSE.IconColor = System.Drawing.Color.White
        Me.COB_CLOSE.Location = New System.Drawing.Point(1176, 0)
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
        Me.LBL_DESCRIPTION.Location = New System.Drawing.Point(0, 0)
        Me.LBL_DESCRIPTION.Name = "LBL_DESCRIPTION"
        Me.LBL_DESCRIPTION.Size = New System.Drawing.Size(1200, 27)
        Me.LBL_DESCRIPTION.TabIndex = 4
        Me.LBL_DESCRIPTION.Text = "Gestions Des étudiants"
        Me.LBL_DESCRIPTION.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BT_REFRESH.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_REFRESH.ForeColor = System.Drawing.Color.White
        Me.BT_REFRESH.Image = CType(resources.GetObject("BT_REFRESH.Image"), System.Drawing.Image)
        Me.BT_REFRESH.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_REFRESH.Location = New System.Drawing.Point(1023, 130)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(150, 36)
        Me.BT_REFRESH.TabIndex = 110
        Me.BT_REFRESH.Text = "Recharger"
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
        Me.BT_ADD.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ADD.ForeColor = System.Drawing.Color.White
        Me.BT_ADD.Image = CType(resources.GetObject("BT_ADD.Image"), System.Drawing.Image)
        Me.BT_ADD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_ADD.Location = New System.Drawing.Point(1023, 88)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(150, 36)
        Me.BT_ADD.TabIndex = 107
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
        Me.BT_DELETE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_DELETE.ForeColor = System.Drawing.Color.White
        Me.BT_DELETE.Image = CType(resources.GetObject("BT_DELETE.Image"), System.Drawing.Image)
        Me.BT_DELETE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_DELETE.Location = New System.Drawing.Point(1023, 4)
        Me.BT_DELETE.Name = "BT_DELETE"
        Me.BT_DELETE.Size = New System.Drawing.Size(150, 36)
        Me.BT_DELETE.TabIndex = 108
        Me.BT_DELETE.Text = "Supprimer"
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
        Me.BT_UPDATE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_UPDATE.ForeColor = System.Drawing.Color.White
        Me.BT_UPDATE.Image = CType(resources.GetObject("BT_UPDATE.Image"), System.Drawing.Image)
        Me.BT_UPDATE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_UPDATE.Location = New System.Drawing.Point(1023, 46)
        Me.BT_UPDATE.Name = "BT_UPDATE"
        Me.BT_UPDATE.Size = New System.Drawing.Size(150, 36)
        Me.BT_UPDATE.TabIndex = 109
        Me.BT_UPDATE.Text = "Modifier"
        '
        'P_MAIN
        '
        Me.P_MAIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_MAIN.BackColor = System.Drawing.Color.White
        Me.P_MAIN.Controls.Add(Me.DGV_STUDENTS)
        Me.P_MAIN.Controls.Add(Me.TB_EMAIL)
        Me.P_MAIN.Controls.Add(Me.TB_FIRST_NAME)
        Me.P_MAIN.Controls.Add(Me.LBL_FIRST_NAME)
        Me.P_MAIN.Controls.Add(Me.TB_LAST_NAME)
        Me.P_MAIN.Controls.Add(Me.TB_PHONE_NUMBER)
        Me.P_MAIN.Controls.Add(Me.LBL_EMAIL)
        Me.P_MAIN.Controls.Add(Me.CB_GENDER)
        Me.P_MAIN.Controls.Add(Me.LBL_LAST_NAME)
        Me.P_MAIN.Controls.Add(Me.LBL_PHONE_NUMBER)
        Me.P_MAIN.Controls.Add(Me.Guna2HtmlLabel1)
        Me.P_MAIN.Controls.Add(Me.Guna2ComboBox1)
        Me.P_MAIN.Controls.Add(Me.Guna2HtmlLabel2)
        Me.P_MAIN.Controls.Add(Me.Guna2ComboBox2)
        Me.P_MAIN.Controls.Add(Me.Guna2HtmlLabel3)
        Me.P_MAIN.Controls.Add(Me.Guna2TextBox1)
        Me.P_MAIN.Controls.Add(Me.Guna2HtmlLabel4)
        Me.P_MAIN.Controls.Add(Me.Guna2ComboBox3)
        Me.P_MAIN.Controls.Add(Me.Guna2HtmlLabel5)
        Me.P_MAIN.Controls.Add(Me.Guna2ComboBox4)
        Me.P_MAIN.Controls.Add(Me.Guna2HtmlLabel6)
        Me.P_MAIN.Controls.Add(Me.Guna2HtmlLabel7)
        Me.P_MAIN.Controls.Add(Me.Guna2ComboBox5)
        Me.P_MAIN.Controls.Add(Me.Guna2HtmlLabel8)
        Me.P_MAIN.Controls.Add(Me.PIC_STUDENT)
        Me.P_MAIN.Controls.Add(Me.BT_UPDATE)
        Me.P_MAIN.Controls.Add(Me.BT_DELETE)
        Me.P_MAIN.Controls.Add(Me.BT_ADD)
        Me.P_MAIN.Controls.Add(Me.BT_REFRESH)
        Me.P_MAIN.Location = New System.Drawing.Point(12, 33)
        Me.P_MAIN.Name = "P_MAIN"
        Me.P_MAIN.Size = New System.Drawing.Size(1176, 505)
        Me.P_MAIN.TabIndex = 111
        '
        'DGV_STUDENTS
        '
        Me.DGV_STUDENTS.AllowUserToAddRows = False
        Me.DGV_STUDENTS.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_STUDENTS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_STUDENTS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_STUDENTS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_STUDENTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_STUDENTS.ColumnHeadersHeight = 30
        Me.DGV_STUDENTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_STUDENTS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.studentName, Me.grade, Me.ecueName, Me.dateField, Me.typeField, Me.weightField})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_STUDENTS.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_STUDENTS.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_STUDENTS.Location = New System.Drawing.Point(3, 281)
        Me.DGV_STUDENTS.Name = "DGV_STUDENTS"
        Me.DGV_STUDENTS.ReadOnly = True
        Me.DGV_STUDENTS.RowHeadersVisible = False
        Me.DGV_STUDENTS.Size = New System.Drawing.Size(1170, 221)
        Me.DGV_STUDENTS.TabIndex = 111
        Me.DGV_STUDENTS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.DGV_STUDENTS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_STUDENTS.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_STUDENTS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_STUDENTS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_STUDENTS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_STUDENTS.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_STUDENTS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_STUDENTS.ThemeStyle.HeaderStyle.Height = 30
        Me.DGV_STUDENTS.ThemeStyle.ReadOnly = True
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.DGV_STUDENTS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.FillWeight = 8.0!
        Me.id.HeaderText = "Identifiant"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'studentName
        '
        Me.studentName.DataPropertyName = "studentName"
        Me.studentName.FillWeight = 25.0!
        Me.studentName.HeaderText = "Etudiant"
        Me.studentName.Name = "studentName"
        Me.studentName.ReadOnly = True
        '
        'grade
        '
        Me.grade.DataPropertyName = "grade"
        Me.grade.FillWeight = 8.0!
        Me.grade.HeaderText = "Note"
        Me.grade.Name = "grade"
        Me.grade.ReadOnly = True
        '
        'ecueName
        '
        Me.ecueName.DataPropertyName = "ecueName"
        Me.ecueName.FillWeight = 25.0!
        Me.ecueName.HeaderText = "ECUE"
        Me.ecueName.Name = "ecueName"
        Me.ecueName.ReadOnly = True
        '
        'dateField
        '
        Me.dateField.DataPropertyName = "dateField"
        Me.dateField.FillWeight = 10.0!
        Me.dateField.HeaderText = "Date"
        Me.dateField.Name = "dateField"
        Me.dateField.ReadOnly = True
        '
        'typeField
        '
        Me.typeField.DataPropertyName = "typeField"
        Me.typeField.FillWeight = 8.0!
        Me.typeField.HeaderText = "Type"
        Me.typeField.Name = "typeField"
        Me.typeField.ReadOnly = True
        '
        'weightField
        '
        Me.weightField.DataPropertyName = "weightField"
        Me.weightField.FillWeight = 5.0!
        Me.weightField.HeaderText = "Poids"
        Me.weightField.Name = "weightField"
        Me.weightField.ReadOnly = True
        '
        'TuititionServiceView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 550)
        Me.Controls.Add(Me.P_MAIN)
        Me.Controls.Add(Me.P_TOP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TuititionServiceView"
        Me.Text = "TuititionServiceView"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PIC_STUDENT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_TOP.ResumeLayout(False)
        Me.P_MAIN.ResumeLayout(False)
        Me.P_MAIN.PerformLayout()
        CType(Me.DGV_STUDENTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LBL_PHONE_NUMBER As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_LAST_NAME As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CB_GENDER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_EMAIL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TB_PHONE_NUMBER As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_LAST_NAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LBL_FIRST_NAME As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TB_FIRST_NAME As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents TB_EMAIL As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ComboBox2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ComboBox3 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ComboBox4 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ComboBox5 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents PIC_STUDENT As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents P_TOP As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BT_LOGOUT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents COB_MAXIMAZE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents COB_MINIMIZE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents COB_CLOSE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents LBL_DESCRIPTION As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BT_REFRESH As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_ADD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_DELETE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_UPDATE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents P_MAIN As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGV_STUDENTS As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents studentName As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents ecueName As DataGridViewTextBoxColumn
    Friend WithEvents dateField As DataGridViewTextBoxColumn
    Friend WithEvents typeField As DataGridViewTextBoxColumn
    Friend WithEvents weightField As DataGridViewTextBoxColumn
End Class
