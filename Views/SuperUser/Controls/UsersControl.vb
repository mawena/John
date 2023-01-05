Public Class UsersControl
    Private Sub ClearForm()
        TB_USERNAME.Text = ""
        TB_PASSWORD_FIELD.Text = ""
        TB_PASSWORD_FIELD.Text = ""
    End Sub

    Public Sub refreshCB_EMPLOYEE()
        CB_EMPLOYEE.Items.Clear()
        CB_EMPLOYEE.Items.Add("Administrateur")
        Dim employeesList As List(Of Employee) = EmployeesManager.getAll()
        Dim usersList As List(Of User) = UsersManager.getAll()
        For Each employee As Employee In employeesList
            If UsersManager.getByEmployeeId(employee.Id).Username = Nothing Then
                CB_EMPLOYEE.Items.Add(employee.FirstName & " - " & employee.LastName)
            End If
        Next
        If (CB_EMPLOYEE.Items.Count > 0) Then
            CB_EMPLOYEE.SelectedIndex = 0
        Else
            CB_EMPLOYEE.SelectedIndex = -1
        End If
        CB_EMPLOYEE.SelectedIndex = 0
    End Sub

    Public Sub checkButtons()
        Dim nbRowSelected = DGV_USERS.SelectedRows.Count
        If nbRowSelected > 0 Then
            BT_DELETE.Enabled = True
            BT_UPDATE.Enabled = True
        Else
            BT_DELETE.Enabled = False
            BT_UPDATE.Enabled = False
        End If
    End Sub

    Private Sub UsersControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshCB_EMPLOYEE()
        DGV_USERS.DataSource = UsersController.getAll()
        checkButtons()
    End Sub

    Public Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        DGV_USERS.DataSource = UsersController.getAll()
        checkButtons()
    End Sub

    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If (UsersController.store(TB_USERNAME.Text, TB_PASSWORD_FIELD.Text, CB_EMPLOYEE.SelectedItem.ToString())) Then
            ClearForm()
            refreshCB_EMPLOYEE()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
        checkButtons()
    End Sub

    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        Dim nbRowSelected = DGV_USERS.SelectedRows.Count
        If nbRowSelected > 0 Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = DGV_USERS.SelectedRows(0)
                Dim userId As Integer = selectedRow.Cells(0).Value
                If (UsersController.update(TB_USERNAME.Text, TB_PASSWORD_FIELD.Text, CB_EMPLOYEE.SelectedItem.ToString(), userId, CTS_UPDATE_PASSWORD.Checked)) Then
                    ClearForm()
                    refreshCB_EMPLOYEE()
                    BT_REFRESH_Click(Nothing, Nothing)
                End If
            Else
                MessageBox.Show("Vous ne pouvez modifier qu'une ligne à la fois", "Modification multiple non permise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Ligne non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        checkButtons()
    End Sub

    Private Sub BT_DELETE_Click(sender As Object, e As EventArgs) Handles BT_DELETE.Click
        Dim userIdList As New List(Of Integer)()
        If DGV_USERS.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In DGV_USERS.SelectedRows
                Dim userId As Integer = selectedRow.Cells(0).Value
                userIdList.Add(userId)
            Next
            If (UsersController.delete(userIdList)) Then
                refreshCB_EMPLOYEE()
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        checkButtons()
    End Sub

    Private Sub TB_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_SEARCH.TextChanged
        DGV_USERS.DataSource = UsersController.searchUsers(TB_SEARCH.Text)
    End Sub

    Private Sub DGV_USERS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_USERS.CellClick
        TB_USERNAME.Text = DGV_USERS.SelectedRows(0).Cells(1).Value
        refreshCB_EMPLOYEE()
        If DGV_USERS.SelectedRows(0).Cells(3).Value <> "Non employé" Then
            CB_EMPLOYEE.Items.Add(DGV_USERS.SelectedRows(0).Cells(3).Value)
            CB_EMPLOYEE.SelectedItem = DGV_USERS.SelectedRows(0).Cells(3).Value
        End If
    End Sub

    Private Sub CTS_DISPLAY_PASSWORD_CheckedChanged(sender As Object, e As EventArgs) Handles CTS_DISPLAY_PASSWORD.CheckedChanged
        If (CTS_DISPLAY_PASSWORD.Checked) Then
            TB_PASSWORD_FIELD.PasswordChar = ""
        Else
            TB_PASSWORD_FIELD.PasswordChar = "*"
        End If
    End Sub
End Class
