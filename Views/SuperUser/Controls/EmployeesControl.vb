Public Class EmployeesControl
    Private Sub ClearForm()
        TB_LAST_NAME.Text = ""
        TB_FIRST_NAME.Text = ""
        TB_PHONE_NUMBER.Text = ""
        TB_EMAIL.Text = ""
        CB_GENDER.SelectedIndex = 0
        CB_FUNCTION.SelectedIndex = 0
    End Sub

    Public Sub checkButtons()
        Dim nbRowSelected = DGV_EMPLOYEES.SelectedRows.Count
        If nbRowSelected > 0 Then
            BT_DELETE.Enabled = True
            BT_UPDATE.Enabled = True
        Else
            BT_DELETE.Enabled = False
            BT_UPDATE.Enabled = False
        End If
    End Sub

    Private Sub EmployeesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_EMPLOYEES.DataSource = EmployeesController.getAll()
        checkButtons()
    End Sub

    Public Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        DGV_EMPLOYEES.DataSource = EmployeesController.getAll()
        checkButtons()
    End Sub

    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If EmployeesController.store(TB_LAST_NAME.Text, TB_FIRST_NAME.Text, TB_PHONE_NUMBER.Text, TB_EMAIL.Text, CB_GENDER.SelectedItem.ToString(), CB_FUNCTION.SelectedItem.ToString()) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
        checkButtons()
    End Sub

    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        Dim nbRowSelected = DGV_EMPLOYEES.SelectedRows.Count
        If nbRowSelected > 0 Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = DGV_EMPLOYEES.SelectedRows(0)
                Dim employeeId As Integer = selectedRow.Cells(0).Value
                If EmployeesController.update(TB_LAST_NAME.Text, TB_FIRST_NAME.Text, TB_PHONE_NUMBER.Text, TB_EMAIL.Text, CB_GENDER.SelectedItem.ToString(), CB_FUNCTION.SelectedItem.ToString(), employeeId) Then
                    ClearForm()
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
        Dim employeeIdList As New List(Of Integer)()
        If DGV_EMPLOYEES.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In DGV_EMPLOYEES.SelectedRows
                Dim employeeId As Integer = selectedRow.Cells(0).Value
                employeeIdList.Add(employeeId)
            Next
            If (EmployeesController.delete(employeeIdList)) Then
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        checkButtons()
    End Sub

    Private Sub DGV_EMPLOYEES_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_EMPLOYEES.CellClick
        TB_LAST_NAME.Text = DGV_EMPLOYEES.SelectedRows(0).Cells(1).Value
        TB_FIRST_NAME.Text = DGV_EMPLOYEES.SelectedRows(0).Cells(2).Value
        TB_PHONE_NUMBER.Text = DGV_EMPLOYEES.SelectedRows(0).Cells(3).Value
        TB_EMAIL.Text = DGV_EMPLOYEES.SelectedRows(0).Cells(4).Value
        CB_GENDER.SelectedItem = DGV_EMPLOYEES.SelectedRows(0).Cells(5).Value
        CB_FUNCTION.SelectedItem = DGV_EMPLOYEES.SelectedRows(0).Cells(6).Value
    End Sub

    Private Sub TB_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_SEARCH.TextChanged
        DGV_EMPLOYEES.DataSource = EmployeesController.search(TB_SEARCH.Text)
    End Sub
End Class
