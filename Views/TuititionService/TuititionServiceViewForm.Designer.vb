<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TuititionServiceViewForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TuititionServiceViewForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LBL_PHONE_NUMBER = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_LAST_NAME = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_EMAIL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TB_PHONE_NUMBER = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_LAST_NAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LBL_FIRST_NAME = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TB_FIRST_NAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_EMAIL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_CAREER = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CB_CAREER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CB_INSTITUTE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_INSTITUTE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_SEMESTER = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CB_SEMESTER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.PB_STUDENT = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
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
        Me.BT_PRINT_STUDENT_REPORT = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_UNSCRIBE = New Guna.UI2.WinForms.Guna2Button()
        Me.B_PRINT_STUDENT_LIST = New Guna.UI2.WinForms.Guna2Button()
        Me.TB_SEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CB_GENDER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.B_ADD_PICTURE = New Guna.UI2.WinForms.Guna2Button()
        Me.DTP_DATE = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DGV_STUDENTS = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.picturePath = New System.Windows.Forms.DataGridViewImageColumn()
        Me.phoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.careerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        CType(Me.PB_STUDENT, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LBL_PHONE_NUMBER.Location = New System.Drawing.Point(711, 88)
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
        Me.LBL_LAST_NAME.Location = New System.Drawing.Point(222, 4)
        Me.LBL_LAST_NAME.Name = "LBL_LAST_NAME"
        Me.LBL_LAST_NAME.Size = New System.Drawing.Size(50, 27)
        Me.LBL_LAST_NAME.TabIndex = 79
        Me.LBL_LAST_NAME.Text = "Nom"
        '
        'LBL_EMAIL
        '
        Me.LBL_EMAIL.BackColor = System.Drawing.Color.Transparent
        Me.LBL_EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EMAIL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_EMAIL.Location = New System.Drawing.Point(211, 88)
        Me.LBL_EMAIL.Name = "LBL_EMAIL"
        Me.LBL_EMAIL.Size = New System.Drawing.Size(61, 27)
        Me.LBL_EMAIL.TabIndex = 83
        Me.LBL_EMAIL.Text = "Email"
        '
        'TB_PHONE_NUMBER
        '
        Me.TB_PHONE_NUMBER.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_PHONE_NUMBER.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_PHONE_NUMBER.DefaultText = ""
        Me.TB_PHONE_NUMBER.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_PHONE_NUMBER.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_PHONE_NUMBER.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PHONE_NUMBER.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_PHONE_NUMBER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PHONE_NUMBER.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TB_PHONE_NUMBER.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_PHONE_NUMBER.Location = New System.Drawing.Point(831, 88)
        Me.TB_PHONE_NUMBER.Name = "TB_PHONE_NUMBER"
        Me.TB_PHONE_NUMBER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_PHONE_NUMBER.PlaceholderText = "Ex: +228 98 67 66 15"
        Me.TB_PHONE_NUMBER.SelectedText = ""
        Me.TB_PHONE_NUMBER.Size = New System.Drawing.Size(186, 36)
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
        Me.TB_LAST_NAME.Location = New System.Drawing.Point(278, 4)
        Me.TB_LAST_NAME.Name = "TB_LAST_NAME"
        Me.TB_LAST_NAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_LAST_NAME.PlaceholderText = "Ex: Eisntein"
        Me.TB_LAST_NAME.SelectedText = ""
        Me.TB_LAST_NAME.Size = New System.Drawing.Size(427, 36)
        Me.TB_LAST_NAME.TabIndex = 74
        '
        'LBL_FIRST_NAME
        '
        Me.LBL_FIRST_NAME.BackColor = System.Drawing.Color.Transparent
        Me.LBL_FIRST_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FIRST_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_FIRST_NAME.Location = New System.Drawing.Point(730, 4)
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
        Me.TB_FIRST_NAME.Location = New System.Drawing.Point(831, 4)
        Me.TB_FIRST_NAME.Name = "TB_FIRST_NAME"
        Me.TB_FIRST_NAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_FIRST_NAME.PlaceholderText = "Ex: Albert"
        Me.TB_FIRST_NAME.SelectedText = ""
        Me.TB_FIRST_NAME.Size = New System.Drawing.Size(186, 35)
        Me.TB_FIRST_NAME.TabIndex = 75
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
        Me.TB_EMAIL.Location = New System.Drawing.Point(278, 88)
        Me.TB_EMAIL.Name = "TB_EMAIL"
        Me.TB_EMAIL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_EMAIL.PlaceholderText = "Ex: albert@gmail.com"
        Me.TB_EMAIL.SelectedText = ""
        Me.TB_EMAIL.Size = New System.Drawing.Size(427, 36)
        Me.TB_EMAIL.TabIndex = 77
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(758, 46)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(67, 27)
        Me.Guna2HtmlLabel1.TabIndex = 89
        Me.Guna2HtmlLabel1.Text = "Genre"
        '
        'LBL_CAREER
        '
        Me.LBL_CAREER.BackColor = System.Drawing.Color.Transparent
        Me.LBL_CAREER.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CAREER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_CAREER.Location = New System.Drawing.Point(187, 172)
        Me.LBL_CAREER.Name = "LBL_CAREER"
        Me.LBL_CAREER.Size = New System.Drawing.Size(85, 27)
        Me.LBL_CAREER.TabIndex = 91
        Me.LBL_CAREER.Text = "Parcour"
        '
        'CB_CAREER
        '
        Me.CB_CAREER.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_CAREER.BackColor = System.Drawing.Color.Transparent
        Me.CB_CAREER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_CAREER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_CAREER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CAREER.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_CAREER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_CAREER.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_CAREER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_CAREER.ItemHeight = 30
        Me.CB_CAREER.Location = New System.Drawing.Point(278, 172)
        Me.CB_CAREER.Name = "CB_CAREER"
        Me.CB_CAREER.Size = New System.Drawing.Size(739, 36)
        Me.CB_CAREER.TabIndex = 90
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(159, 46)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(113, 27)
        Me.Guna2HtmlLabel3.TabIndex = 93
        Me.Guna2HtmlLabel3.Text = "Naissance"
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
        Me.CB_INSTITUTE.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_INSTITUTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_INSTITUTE.ItemHeight = 30
        Me.CB_INSTITUTE.Location = New System.Drawing.Point(278, 130)
        Me.CB_INSTITUTE.Name = "CB_INSTITUTE"
        Me.CB_INSTITUTE.Size = New System.Drawing.Size(547, 36)
        Me.CB_INSTITUTE.TabIndex = 96
        '
        'LBL_INSTITUTE
        '
        Me.LBL_INSTITUTE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_INSTITUTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_INSTITUTE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_INSTITUTE.Location = New System.Drawing.Point(198, 130)
        Me.LBL_INSTITUTE.Name = "LBL_INSTITUTE"
        Me.LBL_INSTITUTE.Size = New System.Drawing.Size(74, 27)
        Me.LBL_INSTITUTE.TabIndex = 98
        Me.LBL_INSTITUTE.Text = "Institut"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(3, 214)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(124, 27)
        Me.Guna2HtmlLabel4.TabIndex = 95
        Me.Guna2HtmlLabel4.Text = "Rechercher"
        '
        'LBL_SEMESTER
        '
        Me.LBL_SEMESTER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_SEMESTER.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SEMESTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SEMESTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_SEMESTER.Location = New System.Drawing.Point(831, 130)
        Me.LBL_SEMESTER.Name = "LBL_SEMESTER"
        Me.LBL_SEMESTER.Size = New System.Drawing.Size(102, 27)
        Me.LBL_SEMESTER.TabIndex = 102
        Me.LBL_SEMESTER.Text = "Semestre"
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
        Me.CB_SEMESTER.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CB_SEMESTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_SEMESTER.ItemHeight = 30
        Me.CB_SEMESTER.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.CB_SEMESTER.Location = New System.Drawing.Point(939, 130)
        Me.CB_SEMESTER.Name = "CB_SEMESTER"
        Me.CB_SEMESTER.Size = New System.Drawing.Size(78, 36)
        Me.CB_SEMESTER.StartIndex = 0
        Me.CB_SEMESTER.TabIndex = 101
        '
        'PB_STUDENT
        '
        Me.PB_STUDENT.BackColor = System.Drawing.Color.DimGray
        Me.PB_STUDENT.FillColor = System.Drawing.Color.DimGray
        Me.PB_STUDENT.ImageRotate = 0!
        Me.PB_STUDENT.Location = New System.Drawing.Point(3, 4)
        Me.PB_STUDENT.Name = "PB_STUDENT"
        Me.PB_STUDENT.Size = New System.Drawing.Size(150, 153)
        Me.PB_STUDENT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_STUDENT.TabIndex = 103
        Me.PB_STUDENT.TabStop = False
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
        Me.BT_REFRESH.Location = New System.Drawing.Point(1023, 172)
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
        Me.BT_ADD.Text = "Inscrire"
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
        Me.P_MAIN.Controls.Add(Me.BT_PRINT_STUDENT_REPORT)
        Me.P_MAIN.Controls.Add(Me.BT_UNSCRIBE)
        Me.P_MAIN.Controls.Add(Me.B_PRINT_STUDENT_LIST)
        Me.P_MAIN.Controls.Add(Me.TB_SEARCH)
        Me.P_MAIN.Controls.Add(Me.CB_GENDER)
        Me.P_MAIN.Controls.Add(Me.B_ADD_PICTURE)
        Me.P_MAIN.Controls.Add(Me.DTP_DATE)
        Me.P_MAIN.Controls.Add(Me.DGV_STUDENTS)
        Me.P_MAIN.Controls.Add(Me.TB_EMAIL)
        Me.P_MAIN.Controls.Add(Me.TB_FIRST_NAME)
        Me.P_MAIN.Controls.Add(Me.LBL_FIRST_NAME)
        Me.P_MAIN.Controls.Add(Me.TB_LAST_NAME)
        Me.P_MAIN.Controls.Add(Me.TB_PHONE_NUMBER)
        Me.P_MAIN.Controls.Add(Me.LBL_EMAIL)
        Me.P_MAIN.Controls.Add(Me.LBL_LAST_NAME)
        Me.P_MAIN.Controls.Add(Me.LBL_PHONE_NUMBER)
        Me.P_MAIN.Controls.Add(Me.Guna2HtmlLabel1)
        Me.P_MAIN.Controls.Add(Me.CB_CAREER)
        Me.P_MAIN.Controls.Add(Me.LBL_CAREER)
        Me.P_MAIN.Controls.Add(Me.Guna2HtmlLabel3)
        Me.P_MAIN.Controls.Add(Me.Guna2HtmlLabel4)
        Me.P_MAIN.Controls.Add(Me.CB_INSTITUTE)
        Me.P_MAIN.Controls.Add(Me.LBL_INSTITUTE)
        Me.P_MAIN.Controls.Add(Me.CB_SEMESTER)
        Me.P_MAIN.Controls.Add(Me.LBL_SEMESTER)
        Me.P_MAIN.Controls.Add(Me.PB_STUDENT)
        Me.P_MAIN.Controls.Add(Me.BT_UPDATE)
        Me.P_MAIN.Controls.Add(Me.BT_DELETE)
        Me.P_MAIN.Controls.Add(Me.BT_ADD)
        Me.P_MAIN.Controls.Add(Me.BT_REFRESH)
        Me.P_MAIN.Location = New System.Drawing.Point(12, 33)
        Me.P_MAIN.Name = "P_MAIN"
        Me.P_MAIN.Size = New System.Drawing.Size(1176, 505)
        Me.P_MAIN.TabIndex = 111
        '
        'BT_PRINT_STUDENT_REPORT
        '
        Me.BT_PRINT_STUDENT_REPORT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_PRINT_STUDENT_REPORT.Animated = True
        Me.BT_PRINT_STUDENT_REPORT.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.BT_PRINT_STUDENT_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PRINT_STUDENT_REPORT.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_PRINT_STUDENT_REPORT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_PRINT_STUDENT_REPORT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_PRINT_STUDENT_REPORT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_PRINT_STUDENT_REPORT.FillColor = System.Drawing.Color.DimGray
        Me.BT_PRINT_STUDENT_REPORT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BT_PRINT_STUDENT_REPORT.ForeColor = System.Drawing.Color.White
        Me.BT_PRINT_STUDENT_REPORT.Image = CType(resources.GetObject("BT_PRINT_STUDENT_REPORT.Image"), System.Drawing.Image)
        Me.BT_PRINT_STUDENT_REPORT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_PRINT_STUDENT_REPORT.Location = New System.Drawing.Point(1023, 214)
        Me.BT_PRINT_STUDENT_REPORT.Name = "BT_PRINT_STUDENT_REPORT"
        Me.BT_PRINT_STUDENT_REPORT.Size = New System.Drawing.Size(150, 36)
        Me.BT_PRINT_STUDENT_REPORT.TabIndex = 120
        Me.BT_PRINT_STUDENT_REPORT.Text = "Bulletin"
        '
        'BT_UNSCRIBE
        '
        Me.BT_UNSCRIBE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_UNSCRIBE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_UNSCRIBE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BT_UNSCRIBE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BT_UNSCRIBE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BT_UNSCRIBE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BT_UNSCRIBE.FillColor = System.Drawing.Color.DimGray
        Me.BT_UNSCRIBE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_UNSCRIBE.ForeColor = System.Drawing.Color.White
        Me.BT_UNSCRIBE.Image = CType(resources.GetObject("BT_UNSCRIBE.Image"), System.Drawing.Image)
        Me.BT_UNSCRIBE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BT_UNSCRIBE.Location = New System.Drawing.Point(1023, 130)
        Me.BT_UNSCRIBE.Name = "BT_UNSCRIBE"
        Me.BT_UNSCRIBE.Size = New System.Drawing.Size(150, 36)
        Me.BT_UNSCRIBE.TabIndex = 119
        Me.BT_UNSCRIBE.Text = "Désinscrire"
        '
        'B_PRINT_STUDENT_LIST
        '
        Me.B_PRINT_STUDENT_LIST.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_PRINT_STUDENT_LIST.Animated = True
        Me.B_PRINT_STUDENT_LIST.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.B_PRINT_STUDENT_LIST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B_PRINT_STUDENT_LIST.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.B_PRINT_STUDENT_LIST.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.B_PRINT_STUDENT_LIST.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.B_PRINT_STUDENT_LIST.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.B_PRINT_STUDENT_LIST.FillColor = System.Drawing.Color.DimGray
        Me.B_PRINT_STUDENT_LIST.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.B_PRINT_STUDENT_LIST.ForeColor = System.Drawing.Color.White
        Me.B_PRINT_STUDENT_LIST.Image = CType(resources.GetObject("B_PRINT_STUDENT_LIST.Image"), System.Drawing.Image)
        Me.B_PRINT_STUDENT_LIST.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.B_PRINT_STUDENT_LIST.Location = New System.Drawing.Point(831, 214)
        Me.B_PRINT_STUDENT_LIST.Name = "B_PRINT_STUDENT_LIST"
        Me.B_PRINT_STUDENT_LIST.Size = New System.Drawing.Size(186, 36)
        Me.B_PRINT_STUDENT_LIST.TabIndex = 116
        Me.B_PRINT_STUDENT_LIST.Text = "Liste étudiants"
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
        Me.TB_SEARCH.IconRight = CType(resources.GetObject("TB_SEARCH.IconRight"), System.Drawing.Image)
        Me.TB_SEARCH.Location = New System.Drawing.Point(133, 214)
        Me.TB_SEARCH.Name = "TB_SEARCH"
        Me.TB_SEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_SEARCH.PlaceholderText = "Ex: Charles"
        Me.TB_SEARCH.SelectedText = ""
        Me.TB_SEARCH.Size = New System.Drawing.Size(692, 36)
        Me.TB_SEARCH.TabIndex = 115
        '
        'CB_GENDER
        '
        Me.CB_GENDER.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_GENDER.BackColor = System.Drawing.Color.Transparent
        Me.CB_GENDER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_GENDER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_GENDER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_GENDER.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GENDER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GENDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CB_GENDER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_GENDER.ItemHeight = 30
        Me.CB_GENDER.Items.AddRange(New Object() {"Femme", "Homme"})
        Me.CB_GENDER.Location = New System.Drawing.Point(831, 46)
        Me.CB_GENDER.Name = "CB_GENDER"
        Me.CB_GENDER.Size = New System.Drawing.Size(186, 36)
        Me.CB_GENDER.StartIndex = 0
        Me.CB_GENDER.TabIndex = 114
        '
        'B_ADD_PICTURE
        '
        Me.B_ADD_PICTURE.Animated = True
        Me.B_ADD_PICTURE.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.B_ADD_PICTURE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B_ADD_PICTURE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.B_ADD_PICTURE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.B_ADD_PICTURE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.B_ADD_PICTURE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.B_ADD_PICTURE.FillColor = System.Drawing.Color.DimGray
        Me.B_ADD_PICTURE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.B_ADD_PICTURE.ForeColor = System.Drawing.Color.White
        Me.B_ADD_PICTURE.Image = CType(resources.GetObject("B_ADD_PICTURE.Image"), System.Drawing.Image)
        Me.B_ADD_PICTURE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.B_ADD_PICTURE.Location = New System.Drawing.Point(3, 172)
        Me.B_ADD_PICTURE.Name = "B_ADD_PICTURE"
        Me.B_ADD_PICTURE.Size = New System.Drawing.Size(150, 36)
        Me.B_ADD_PICTURE.TabIndex = 113
        Me.B_ADD_PICTURE.Text = "Changer"
        '
        'DTP_DATE
        '
        Me.DTP_DATE.Checked = True
        Me.DTP_DATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_DATE.FillColor = System.Drawing.Color.White
        Me.DTP_DATE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTP_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_DATE.Location = New System.Drawing.Point(278, 46)
        Me.DTP_DATE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_DATE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_DATE.Name = "DTP_DATE"
        Me.DTP_DATE.Size = New System.Drawing.Size(427, 36)
        Me.DTP_DATE.TabIndex = 112
        Me.DTP_DATE.Value = New Date(2023, 1, 17, 0, 0, 0, 0)
        '
        'DGV_STUDENTS
        '
        Me.DGV_STUDENTS.AllowUserToAddRows = False
        Me.DGV_STUDENTS.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_STUDENTS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_STUDENTS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_STUDENTS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_STUDENTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_STUDENTS.ColumnHeadersHeight = 30
        Me.DGV_STUDENTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_STUDENTS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.lastName, Me.firstName, Me.picturePath, Me.phoneNumber, Me.gender, Me.email, Me.birthDate, Me.careerName})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_STUDENTS.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_STUDENTS.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_STUDENTS.Location = New System.Drawing.Point(3, 256)
        Me.DGV_STUDENTS.Name = "DGV_STUDENTS"
        Me.DGV_STUDENTS.ReadOnly = True
        Me.DGV_STUDENTS.RowHeadersVisible = False
        Me.DGV_STUDENTS.Size = New System.Drawing.Size(1170, 246)
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
        Me.id.FillWeight = 15.0!
        Me.id.HeaderText = "Identifiant"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'lastName
        '
        Me.lastName.DataPropertyName = "lastName"
        Me.lastName.FillWeight = 20.0!
        Me.lastName.HeaderText = "Nom"
        Me.lastName.Name = "lastName"
        Me.lastName.ReadOnly = True
        '
        'firstName
        '
        Me.firstName.DataPropertyName = "firstName"
        Me.firstName.FillWeight = 25.0!
        Me.firstName.HeaderText = "Prénoms"
        Me.firstName.Name = "firstName"
        Me.firstName.ReadOnly = True
        '
        'picturePath
        '
        Me.picturePath.DataPropertyName = "picturePath"
        Me.picturePath.FillWeight = 12.0!
        Me.picturePath.HeaderText = "Photo"
        Me.picturePath.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.picturePath.Name = "picturePath"
        Me.picturePath.ReadOnly = True
        '
        'phoneNumber
        '
        Me.phoneNumber.DataPropertyName = "phoneNumber"
        Me.phoneNumber.FillWeight = 20.0!
        Me.phoneNumber.HeaderText = "Téléphone"
        Me.phoneNumber.Name = "phoneNumber"
        Me.phoneNumber.ReadOnly = True
        '
        'gender
        '
        Me.gender.DataPropertyName = "gender"
        Me.gender.FillWeight = 10.0!
        Me.gender.HeaderText = "Genre"
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.FillWeight = 30.0!
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'birthDate
        '
        Me.birthDate.DataPropertyName = "birthDate"
        Me.birthDate.FillWeight = 15.0!
        Me.birthDate.HeaderText = "Naissance"
        Me.birthDate.Name = "birthDate"
        Me.birthDate.ReadOnly = True
        '
        'careerName
        '
        Me.careerName.DataPropertyName = "careerName"
        Me.careerName.FillWeight = 30.0!
        Me.careerName.HeaderText = "Parcours"
        Me.careerName.Name = "careerName"
        Me.careerName.ReadOnly = True
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.LBL_DESCRIPTION
        Me.Guna2DragControl1.TransparentWhileDrag = False
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
        CType(Me.PB_STUDENT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_TOP.ResumeLayout(False)
        Me.P_MAIN.ResumeLayout(False)
        Me.P_MAIN.PerformLayout()
        CType(Me.DGV_STUDENTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LBL_PHONE_NUMBER As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_LAST_NAME As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_EMAIL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TB_PHONE_NUMBER As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TB_LAST_NAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LBL_FIRST_NAME As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TB_FIRST_NAME As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents TB_EMAIL As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_CAREER As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CB_CAREER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CB_INSTITUTE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_INSTITUTE As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_SEMESTER As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CB_SEMESTER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents PB_STUDENT As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
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
    Friend WithEvents DTP_DATE As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents B_ADD_PICTURE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CB_GENDER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TB_SEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents B_PRINT_STUDENT_LIST As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents lastName As DataGridViewTextBoxColumn
    Friend WithEvents firstName As DataGridViewTextBoxColumn
    Friend WithEvents picturePath As DataGridViewImageColumn
    Friend WithEvents phoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents birthDate As DataGridViewTextBoxColumn
    Friend WithEvents careerName As DataGridViewTextBoxColumn
    Friend WithEvents BT_UNSCRIBE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents BT_PRINT_STUDENT_REPORT As Guna.UI2.WinForms.Guna2Button
End Class
