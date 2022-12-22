Public Class UsersControl
    Dim employeesList As List(Of Employee)
    Private Sub ClearForm()
        TB_USERNAME.Text = ""
        TB_PASSWORD_FIELD.Text = ""
        CB_FUNCTION_FIELD.SelectedIndex = 0
    End Sub

    Public Sub refreshCB_EMPLOYEE()
        CB_EMPLOYEE.Items.Clear()
        CB_EMPLOYEE.Items.Add("Administrateur")
        employeesList = EmployeesManager.getAll()
        For Each employee As Employee In employeesList
            CB_EMPLOYEE.Items.Add(employee.FirstName & " - " & employee.LastName)
        Next
        CB_EMPLOYEE.SelectedIndex = 0
    End Sub

    Private Sub UsersControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshCB_EMPLOYEE()
        DGV_USERS.DataSource = UsersController.getAll()
    End Sub

    Private Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        DGV_USERS.DataSource = UsersController.getAll()
    End Sub

    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If (UsersController.store(TB_USERNAME.Text, CB_FUNCTION_FIELD.SelectedItem.ToString(), TB_PASSWORD_FIELD.Text)) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        Dim nbRowSelected = DGV_USERS.SelectedRows.Count
        If nbRowSelected > 0 Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = DGV_USERS.SelectedRows(0)
                Dim userId As Integer = selectedRow.Cells(0).Value
                If (UsersController.update(TB_USERNAME.Text, CB_FUNCTION_FIELD.SelectedItem.ToString(), TB_PASSWORD_FIELD.Text, userId, CHB_UPDATE_PASSWORD.Checked)) Then
                    ClearForm()
                    BT_REFRESH_Click(Nothing, Nothing)
                End If
            Else
                MsgBox("Vous ne pouvez modifier qu'une ligne à la fois")
            End If
        Else
            MsgBox("Aucune ligne n'a été sélectionnée.")
        End If
    End Sub

    Private Sub BT_DELETE_Click(sender As Object, e As EventArgs) Handles BT_DELETE.Click
        Dim userIdList As New List(Of Integer)()
        If DGV_USERS.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In DGV_USERS.SelectedRows
                Dim userId As Integer = selectedRow.Cells(0).Value
                userIdList.Add(userId)
            Next
            If (UsersController.delete(userIdList)) Then
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MsgBox("Aucune ligne n'a été sélectionnée.")
        End If
    End Sub

    Private Sub DGV_USERS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_USERS.CellClick
        TB_USERNAME.Text = DGV_USERS.SelectedRows(0).Cells(1).Value
        CB_FUNCTION_FIELD.SelectedItem = DGV_USERS.SelectedRows(0).Cells(2).Value
    End Sub

    Private Sub TB_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_SEARCH.TextChanged
        DGV_USERS.DataSource = UsersController.searchUsers(TB_SEARCH.Text)
    End Sub
End Class
