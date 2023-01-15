<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherView))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.P_TOP = New Guna.UI2.WinForms.Guna2Panel()
        Me.BT_LOGOUT = New Guna.UI2.WinForms.Guna2Button()
        Me.COB_MAXIMAZE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.COB_MINIMIZE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.COB_CLOSE = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.LBL_DESCRIPTION = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.P_MAIN = New Guna.UI2.WinForms.Guna2Panel()
        Me.LBL_DATE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CB_WEIGHT = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_TYPE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CB_TYPE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_SEARCH = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TB_SEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TB_STUDENT_SEARCH = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LBL_WEIGHT = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_STUDENT = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DTP_DATE = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.CB_STUDENTS = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_ECUES = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CB_ECUES = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LBL_GRADE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CB_GRADE = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BT_REFRESH = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_ADD = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_DELETE = New Guna.UI2.WinForms.Guna2Button()
        Me.BT_UPDATE = New Guna.UI2.WinForms.Guna2Button()
        Me.DGV_EVALUATIONS = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ecueName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateField = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typeField = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.weightField = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_TOP.SuspendLayout()
        Me.P_MAIN.SuspendLayout()
        CType(Me.DGV_EVALUATIONS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.P_TOP.Controls.Add(Me.BT_LOGOUT)
        Me.P_TOP.Controls.Add(Me.COB_MAXIMAZE)
        Me.P_TOP.Controls.Add(Me.COB_MINIMIZE)
        Me.P_TOP.Controls.Add(Me.COB_CLOSE)
        Me.P_TOP.Controls.Add(Me.LBL_DESCRIPTION)
        Me.P_TOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_TOP.Location = New System.Drawing.Point(0, 0)
        Me.P_TOP.Name = "P_TOP"
        Me.P_TOP.Size = New System.Drawing.Size(1200, 31)
        Me.P_TOP.TabIndex = 105
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
        Me.LBL_DESCRIPTION.Text = "Notes"
        Me.LBL_DESCRIPTION.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_MAIN
        '
        Me.P_MAIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_MAIN.BackColor = System.Drawing.Color.White
        Me.P_MAIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P_MAIN.Controls.Add(Me.LBL_DATE)
        Me.P_MAIN.Controls.Add(Me.CB_WEIGHT)
        Me.P_MAIN.Controls.Add(Me.LBL_TYPE)
        Me.P_MAIN.Controls.Add(Me.CB_TYPE)
        Me.P_MAIN.Controls.Add(Me.LBL_SEARCH)
        Me.P_MAIN.Controls.Add(Me.TB_SEARCH)
        Me.P_MAIN.Controls.Add(Me.TB_STUDENT_SEARCH)
        Me.P_MAIN.Controls.Add(Me.LBL_WEIGHT)
        Me.P_MAIN.Controls.Add(Me.LBL_STUDENT)
        Me.P_MAIN.Controls.Add(Me.DTP_DATE)
        Me.P_MAIN.Controls.Add(Me.CB_STUDENTS)
        Me.P_MAIN.Controls.Add(Me.LBL_ECUES)
        Me.P_MAIN.Controls.Add(Me.CB_ECUES)
        Me.P_MAIN.Controls.Add(Me.LBL_GRADE)
        Me.P_MAIN.Controls.Add(Me.CB_GRADE)
        Me.P_MAIN.Controls.Add(Me.BT_REFRESH)
        Me.P_MAIN.Controls.Add(Me.BT_ADD)
        Me.P_MAIN.Controls.Add(Me.BT_DELETE)
        Me.P_MAIN.Controls.Add(Me.BT_UPDATE)
        Me.P_MAIN.Controls.Add(Me.DGV_EVALUATIONS)
        Me.P_MAIN.Location = New System.Drawing.Point(12, 37)
        Me.P_MAIN.Name = "P_MAIN"
        Me.P_MAIN.Size = New System.Drawing.Size(1176, 501)
        Me.P_MAIN.TabIndex = 106
        '
        'LBL_DATE
        '
        Me.LBL_DATE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_DATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DATE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_DATE.Location = New System.Drawing.Point(75, 87)
        Me.LBL_DATE.Name = "LBL_DATE"
        Me.LBL_DATE.Size = New System.Drawing.Size(52, 27)
        Me.LBL_DATE.TabIndex = 111
        Me.LBL_DATE.Text = "Date"
        '
        'CB_WEIGHT
        '
        Me.CB_WEIGHT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_WEIGHT.BackColor = System.Drawing.Color.Transparent
        Me.CB_WEIGHT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_WEIGHT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_WEIGHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_WEIGHT.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_WEIGHT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_WEIGHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CB_WEIGHT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_WEIGHT.ItemHeight = 30
        Me.CB_WEIGHT.Items.AddRange(New Object() {"05%", "10%", "15%", "20%", "25%", "30%", "35%", "40%", "45%", "50%", "55%", "60%", "65%", "70%", "75%", "80%", "85%", "90%", "95%", "100%"})
        Me.CB_WEIGHT.Location = New System.Drawing.Point(796, 87)
        Me.CB_WEIGHT.Name = "CB_WEIGHT"
        Me.CB_WEIGHT.Size = New System.Drawing.Size(95, 36)
        Me.CB_WEIGHT.StartIndex = 1
        Me.CB_WEIGHT.TabIndex = 110
        '
        'LBL_TYPE
        '
        Me.LBL_TYPE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_TYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_TYPE.Location = New System.Drawing.Point(383, 87)
        Me.LBL_TYPE.Name = "LBL_TYPE"
        Me.LBL_TYPE.Size = New System.Drawing.Size(55, 27)
        Me.LBL_TYPE.TabIndex = 109
        Me.LBL_TYPE.Text = "Type"
        '
        'CB_TYPE
        '
        Me.CB_TYPE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_TYPE.BackColor = System.Drawing.Color.Transparent
        Me.CB_TYPE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_TYPE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_TYPE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_TYPE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_TYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CB_TYPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_TYPE.ItemHeight = 30
        Me.CB_TYPE.Items.AddRange(New Object() {"Devoir", "Examen", "Rattrapage", "Session Spécial"})
        Me.CB_TYPE.Location = New System.Drawing.Point(444, 87)
        Me.CB_TYPE.Name = "CB_TYPE"
        Me.CB_TYPE.Size = New System.Drawing.Size(204, 36)
        Me.CB_TYPE.StartIndex = 0
        Me.CB_TYPE.TabIndex = 108
        '
        'LBL_SEARCH
        '
        Me.LBL_SEARCH.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_SEARCH.Location = New System.Drawing.Point(3, 129)
        Me.LBL_SEARCH.Name = "LBL_SEARCH"
        Me.LBL_SEARCH.Size = New System.Drawing.Size(124, 27)
        Me.LBL_SEARCH.TabIndex = 107
        Me.LBL_SEARCH.Text = "Rechercher"
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
        Me.TB_SEARCH.Location = New System.Drawing.Point(133, 129)
        Me.TB_SEARCH.Name = "TB_SEARCH"
        Me.TB_SEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_SEARCH.PlaceholderText = "Ex: Charles"
        Me.TB_SEARCH.SelectedText = ""
        Me.TB_SEARCH.Size = New System.Drawing.Size(884, 36)
        Me.TB_SEARCH.TabIndex = 106
        '
        'TB_STUDENT_SEARCH
        '
        Me.TB_STUDENT_SEARCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_STUDENT_SEARCH.DefaultText = ""
        Me.TB_STUDENT_SEARCH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TB_STUDENT_SEARCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TB_STUDENT_SEARCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_STUDENT_SEARCH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TB_STUDENT_SEARCH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_STUDENT_SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_STUDENT_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.TB_STUDENT_SEARCH.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TB_STUDENT_SEARCH.IconRight = CType(resources.GetObject("TB_STUDENT_SEARCH.IconRight"), System.Drawing.Image)
        Me.TB_STUDENT_SEARCH.Location = New System.Drawing.Point(133, 45)
        Me.TB_STUDENT_SEARCH.Name = "TB_STUDENT_SEARCH"
        Me.TB_STUDENT_SEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TB_STUDENT_SEARCH.PlaceholderText = "Ex: Char"
        Me.TB_STUDENT_SEARCH.SelectedText = ""
        Me.TB_STUDENT_SEARCH.Size = New System.Drawing.Size(244, 36)
        Me.TB_STUDENT_SEARCH.TabIndex = 105
        '
        'LBL_WEIGHT
        '
        Me.LBL_WEIGHT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_WEIGHT.BackColor = System.Drawing.Color.Transparent
        Me.LBL_WEIGHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_WEIGHT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_WEIGHT.Location = New System.Drawing.Point(654, 87)
        Me.LBL_WEIGHT.Name = "LBL_WEIGHT"
        Me.LBL_WEIGHT.Size = New System.Drawing.Size(136, 27)
        Me.LBL_WEIGHT.TabIndex = 104
        Me.LBL_WEIGHT.Text = "Pourcentage"
        '
        'LBL_STUDENT
        '
        Me.LBL_STUDENT.BackColor = System.Drawing.Color.Transparent
        Me.LBL_STUDENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_STUDENT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_STUDENT.Location = New System.Drawing.Point(37, 45)
        Me.LBL_STUDENT.Name = "LBL_STUDENT"
        Me.LBL_STUDENT.Size = New System.Drawing.Size(90, 27)
        Me.LBL_STUDENT.TabIndex = 102
        Me.LBL_STUDENT.Text = "Etudiant"
        '
        'DTP_DATE
        '
        Me.DTP_DATE.Checked = True
        Me.DTP_DATE.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DTP_DATE.FillColor = System.Drawing.Color.White
        Me.DTP_DATE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DTP_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DTP_DATE.Location = New System.Drawing.Point(133, 87)
        Me.DTP_DATE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTP_DATE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTP_DATE.Name = "DTP_DATE"
        Me.DTP_DATE.Size = New System.Drawing.Size(244, 36)
        Me.DTP_DATE.TabIndex = 101
        Me.DTP_DATE.Value = New Date(2023, 1, 17, 14, 25, 44, 323)
        '
        'CB_STUDENTS
        '
        Me.CB_STUDENTS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_STUDENTS.BackColor = System.Drawing.Color.Transparent
        Me.CB_STUDENTS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_STUDENTS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_STUDENTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_STUDENTS.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_STUDENTS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_STUDENTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_STUDENTS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_STUDENTS.ItemHeight = 30
        Me.CB_STUDENTS.Location = New System.Drawing.Point(383, 45)
        Me.CB_STUDENTS.Name = "CB_STUDENTS"
        Me.CB_STUDENTS.Size = New System.Drawing.Size(634, 36)
        Me.CB_STUDENTS.TabIndex = 100
        '
        'LBL_ECUES
        '
        Me.LBL_ECUES.BackColor = System.Drawing.Color.Transparent
        Me.LBL_ECUES.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ECUES.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_ECUES.Location = New System.Drawing.Point(59, 3)
        Me.LBL_ECUES.Name = "LBL_ECUES"
        Me.LBL_ECUES.Size = New System.Drawing.Size(68, 27)
        Me.LBL_ECUES.TabIndex = 99
        Me.LBL_ECUES.Text = "Ecues"
        '
        'CB_ECUES
        '
        Me.CB_ECUES.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_ECUES.BackColor = System.Drawing.Color.Transparent
        Me.CB_ECUES.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_ECUES.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_ECUES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ECUES.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_ECUES.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_ECUES.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ECUES.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_ECUES.ItemHeight = 30
        Me.CB_ECUES.Location = New System.Drawing.Point(133, 3)
        Me.CB_ECUES.Name = "CB_ECUES"
        Me.CB_ECUES.Size = New System.Drawing.Size(884, 36)
        Me.CB_ECUES.TabIndex = 98
        '
        'LBL_GRADE
        '
        Me.LBL_GRADE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_GRADE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_GRADE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_GRADE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LBL_GRADE.Location = New System.Drawing.Point(897, 87)
        Me.LBL_GRADE.Name = "LBL_GRADE"
        Me.LBL_GRADE.Size = New System.Drawing.Size(52, 27)
        Me.LBL_GRADE.TabIndex = 97
        Me.LBL_GRADE.Text = "Note"
        '
        'CB_GRADE
        '
        Me.CB_GRADE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_GRADE.BackColor = System.Drawing.Color.Transparent
        Me.CB_GRADE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_GRADE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_GRADE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_GRADE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GRADE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CB_GRADE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CB_GRADE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CB_GRADE.ItemHeight = 30
        Me.CB_GRADE.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.CB_GRADE.Location = New System.Drawing.Point(955, 87)
        Me.CB_GRADE.Name = "CB_GRADE"
        Me.CB_GRADE.Size = New System.Drawing.Size(62, 36)
        Me.CB_GRADE.StartIndex = 10
        Me.CB_GRADE.TabIndex = 96
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
        Me.BT_REFRESH.Location = New System.Drawing.Point(1023, 129)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(150, 36)
        Me.BT_REFRESH.TabIndex = 78
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
        Me.BT_ADD.Location = New System.Drawing.Point(1023, 87)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(150, 36)
        Me.BT_ADD.TabIndex = 75
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
        Me.BT_DELETE.Location = New System.Drawing.Point(1023, 3)
        Me.BT_DELETE.Name = "BT_DELETE"
        Me.BT_DELETE.Size = New System.Drawing.Size(150, 36)
        Me.BT_DELETE.TabIndex = 76
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
        Me.BT_UPDATE.Location = New System.Drawing.Point(1023, 45)
        Me.BT_UPDATE.Name = "BT_UPDATE"
        Me.BT_UPDATE.Size = New System.Drawing.Size(150, 36)
        Me.BT_UPDATE.TabIndex = 77
        Me.BT_UPDATE.Text = "Modifier"
        '
        'DGV_EVALUATIONS
        '
        Me.DGV_EVALUATIONS.AllowUserToAddRows = False
        Me.DGV_EVALUATIONS.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_EVALUATIONS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_EVALUATIONS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_EVALUATIONS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_EVALUATIONS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_EVALUATIONS.ColumnHeadersHeight = 30
        Me.DGV_EVALUATIONS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_EVALUATIONS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.studentName, Me.grade, Me.ecueName, Me.dateField, Me.typeField, Me.weightField})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_EVALUATIONS.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_EVALUATIONS.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_EVALUATIONS.Location = New System.Drawing.Point(3, 171)
        Me.DGV_EVALUATIONS.Name = "DGV_EVALUATIONS"
        Me.DGV_EVALUATIONS.ReadOnly = True
        Me.DGV_EVALUATIONS.RowHeadersVisible = False
        Me.DGV_EVALUATIONS.Size = New System.Drawing.Size(1170, 327)
        Me.DGV_EVALUATIONS.TabIndex = 73
        Me.DGV_EVALUATIONS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.DGV_EVALUATIONS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.DGV_EVALUATIONS.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_EVALUATIONS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_EVALUATIONS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_EVALUATIONS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_EVALUATIONS.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_EVALUATIONS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_EVALUATIONS.ThemeStyle.HeaderStyle.Height = 30
        Me.DGV_EVALUATIONS.ThemeStyle.ReadOnly = True
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.DGV_EVALUATIONS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.LBL_DESCRIPTION
        Me.Guna2DragControl1.TransparentWhileDrag = False
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
        'TeacherView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 550)
        Me.Controls.Add(Me.P_MAIN)
        Me.Controls.Add(Me.P_TOP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TeacherView"
        Me.Text = "TeacherView"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.P_TOP.ResumeLayout(False)
        Me.P_MAIN.ResumeLayout(False)
        Me.P_MAIN.PerformLayout()
        CType(Me.DGV_EVALUATIONS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents P_TOP As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents COB_MAXIMAZE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents COB_MINIMIZE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents COB_CLOSE As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents LBL_DESCRIPTION As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents P_MAIN As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGV_EVALUATIONS As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BT_REFRESH As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_ADD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_DELETE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BT_UPDATE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents CB_GRADE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_GRADE As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CB_ECUES As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_ECUES As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BT_LOGOUT As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DTP_DATE As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents CB_STUDENTS As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_STUDENT As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_WEIGHT As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TB_STUDENT_SEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LBL_SEARCH As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TB_SEARCH As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LBL_DATE As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CB_WEIGHT As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_TYPE As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CB_TYPE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents studentName As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents ecueName As DataGridViewTextBoxColumn
    Friend WithEvents dateField As DataGridViewTextBoxColumn
    Friend WithEvents typeField As DataGridViewTextBoxColumn
    Friend WithEvents weightField As DataGridViewTextBoxColumn
End Class
