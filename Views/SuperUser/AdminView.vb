Public Class AdminView
    Dim employeesControl As EmployeesControl
    Dim institutesControl As InstitutesControl
    Dim careersControl As CareersControl
    Dim uesControl As UEsControl
    Dim ecuesControl As ECUEsControl
    Dim usersControl As UsersControl


    Const employeesIllustrationPath As String = "..\..\assets\Pictures\Illustrations\AdminView\employees_illustration.png"
    Const institutesIllustrationPath As String = "..\..\assets\Pictures\Illustrations\AdminView\insitute_illustration.png"
    Const careersIllustrationPath As String = "..\..\assets\Pictures\Illustrations\AdminView\careers_illustration.png"
    Const uesIllustrationPath As String = "..\..\assets\Pictures\Illustrations\AdminView\ues_illustration.png"
    Const ecuesIllustrationPath As String = "..\..\assets\Pictures\Illustrations\AdminView\ecues_illustration.png"
    Const usersIllustrationPath As String = "..\..\assets\Pictures\Illustrations\AdminView\users_illustration.png"

    Private Sub AdminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.connect()
        employeesControl = New EmployeesControl
        institutesControl = New InstitutesControl
        careersControl = New CareersControl
        uesControl = New UEsControl
        ecuesControl = New ECUEsControl
        usersControl = New UsersControl

        institutesControl.Dock = DockStyle.Fill
        employeesControl.Dock = DockStyle.Fill
        careersControl.Dock = DockStyle.Fill
        uesControl.Dock = DockStyle.Fill
        ecuesControl.Dock = DockStyle.Fill
        usersControl.Dock = DockStyle.Fill

        P_MAIN.Controls.Add(institutesControl)
        P_MAIN.Controls.Add(employeesControl)
        P_MAIN.Controls.Add(careersControl)
        P_MAIN.Controls.Add(uesControl)
        P_MAIN.Controls.Add(ecuesControl)
        P_MAIN.Controls.Add(usersControl)

        BT_ECUES_MENU_Click(Nothing, Nothing)
    End Sub
    Private Sub HideControls()
        employeesControl.Hide()
        institutesControl.Hide()
        careersControl.Hide()
        uesControl.Hide()
        ecuesControl.Hide()
        usersControl.Hide()
    End Sub

    Private Sub DefaultBTColors()
        BT_EMPLOYEES_MENU.FillColor = Color.DimGray
        BT_EMPLOYEES_MENU.ImageAlign = HorizontalAlignment.Left

        BT_INSTITUTES_MENU.FillColor = Color.DimGray
        BT_INSTITUTES_MENU.ImageAlign = HorizontalAlignment.Left

        BT_CAREERS_MENU.FillColor = Color.DimGray
        BT_CAREERS_MENU.ImageAlign = HorizontalAlignment.Left

        BT_UES_MENU.FillColor = Color.DimGray
        BT_UES_MENU.ImageAlign = HorizontalAlignment.Left

        BT_ECUES_MENU.FillColor = Color.DimGray
        BT_ECUES_MENU.ImageAlign = HorizontalAlignment.Left

        BT_USERS_MENU.FillColor = Color.DimGray
        BT_USERS_MENU.ImageAlign = HorizontalAlignment.Left
    End Sub

    Private Sub BT_EMPLOYEES_MENU_Click(sender As Object, e As EventArgs) Handles BT_EMPLOYEES_MENU.Click
        HideControls()
        DefaultBTColors()
        BT_EMPLOYEES_MENU.FillColor = Color.FromArgb(0, 120, 215)
        BT_EMPLOYEES_MENU.ImageAlign = HorizontalAlignment.Right
        LBL_DESCRIPTION.Text = "EMPLOYEES"
        PB_GESTION_ILLUSTRATION.ImageLocation = employeesIllustrationPath
        employeesControl.BT_REFRESH_Click(Nothing, Nothing)
        employeesControl.Show()
    End Sub

    Private Sub BT_INSTITUTES_MENU_Click(sender As Object, e As EventArgs) Handles BT_INSTITUTES_MENU.Click
        HideControls()
        DefaultBTColors()
        BT_INSTITUTES_MENU.FillColor = Color.FromArgb(0, 120, 215)
        BT_INSTITUTES_MENU.ImageAlign = HorizontalAlignment.Right
        LBL_DESCRIPTION.Text = "INSITUTS"
        PB_GESTION_ILLUSTRATION.ImageLocation = institutesIllustrationPath
        institutesControl.BT_REFRESH_Click(Nothing, Nothing)
        institutesControl.Show()
    End Sub

    Private Sub BT_CAREERS_MENU_Click(sender As Object, e As EventArgs) Handles BT_CAREERS_MENU.Click
        HideControls()
        DefaultBTColors()
        BT_CAREERS_MENU.FillColor = Color.FromArgb(0, 120, 215)
        BT_CAREERS_MENU.ImageAlign = HorizontalAlignment.Right
        LBL_DESCRIPTION.Text = "PARCOURS"
        PB_GESTION_ILLUSTRATION.ImageLocation = careersIllustrationPath
        careersControl.refreshCB_INSTITUTE()
        careersControl.BT_REFRESH_Click(Nothing, Nothing)
        careersControl.Show()
    End Sub

    Private Sub BT_UES_MENU_Click(sender As Object, e As EventArgs) Handles BT_UES_MENU.Click
        HideControls()
        DefaultBTColors()
        BT_UES_MENU.FillColor = Color.FromArgb(0, 120, 215)
        BT_UES_MENU.ImageAlign = HorizontalAlignment.Right
        LBL_DESCRIPTION.Text = "UES"
        PB_GESTION_ILLUSTRATION.ImageLocation = uesIllustrationPath
        uesControl.refreshCB_CAREER()
        uesControl.BT_REFRESH_Click(Nothing, Nothing)
        uesControl.Show()
    End Sub

    Private Sub BT_ECUES_MENU_Click(sender As Object, e As EventArgs) Handles BT_ECUES_MENU.Click
        HideControls()
        DefaultBTColors()
        BT_ECUES_MENU.FillColor = Color.FromArgb(0, 120, 215)
        BT_ECUES_MENU.ImageAlign = HorizontalAlignment.Right
        LBL_DESCRIPTION.Text = "ECUES"
        PB_GESTION_ILLUSTRATION.ImageLocation = ecuesIllustrationPath
        ecuesControl.Show()
    End Sub

    Private Sub BT_USERS_MENU_Click(sender As Object, e As EventArgs) Handles BT_USERS_MENU.Click
        HideControls()
        DefaultBTColors()
        BT_USERS_MENU.FillColor = Color.FromArgb(0, 120, 215)
        BT_USERS_MENU.ImageAlign = HorizontalAlignment.Right
        LBL_DESCRIPTION.Text = "UTILISATEURS"
        PB_GESTION_ILLUSTRATION.ImageLocation = usersIllustrationPath
        usersControl.refreshCB_EMPLOYEE()
        usersControl.BT_REFRESH_Click(Nothing, Nothing)
        usersControl.Show()
    End Sub

    Private Sub AdminView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Manager.close()
    End Sub
End Class