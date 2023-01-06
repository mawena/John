Public Class FacultiesControl

    Private Sub ClearForm()
        TB_LIBELLE.Text = ""
        TB_SIGLE.Text = ""
        CB_INSTITUTE.SelectedIndex = 0
    End Sub

    Public Sub checkButtons()
        Dim nbRowSelected = DGV_FACULTIES.SelectedRows.Count
        If nbRowSelected > 0 Then
            BT_DELETE.Enabled = True
            BT_UPDATE.Enabled = True
        Else
            BT_DELETE.Enabled = False
            BT_UPDATE.Enabled = False
        End If
    End Sub

    Public Sub refreshCB_INSTITUTE()
        CB_INSTITUTE.Items.Clear()
        Dim institutesList As List(Of Institute) = InstitutesManager.getAll()
        For Each institute As Institute In institutesList
            CB_INSTITUTE.Items.Add(institute.Sigle & " - " & institute.Libelle)
        Next
        If (CB_INSTITUTE.Items.Count > 0) Then
            CB_INSTITUTE.SelectedIndex = 0
            BT_ADD.Enabled = True
            BT_UPDATE.Enabled = True
            BT_DELETE.Enabled = True
        Else
            CB_INSTITUTE.SelectedIndex = -1
            BT_ADD.Enabled = False
            BT_UPDATE.Enabled = False
            BT_DELETE.Enabled = False
        End If
    End Sub

    Private Sub FacultiesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshCB_INSTITUTE()
        DGV_FACULTIES.DataSource = FacultiesController.getAll()
        checkButtons()
    End Sub

    Public Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        DGV_FACULTIES.DataSource = FacultiesController.getAll()
        checkButtons()
    End Sub

    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If (FacultiesController.store(TB_LIBELLE.Text, TB_SIGLE.Text, CB_INSTITUTE.SelectedItem.ToString())) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
        checkButtons()
    End Sub

    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        checkButtons()
        Dim nbRowSelected = DGV_FACULTIES.SelectedRows.Count
        If nbRowSelected > 0 Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = DGV_FACULTIES.SelectedRows(0)
                Dim facultyId As Integer = selectedRow.Cells(0).Value
                If (FacultiesController.update(TB_LIBELLE.Text, TB_SIGLE.Text, CB_INSTITUTE.SelectedItem.ToString(), facultyId)) Then
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
        Dim facultiesIdList As New List(Of Integer)()
        If DGV_FACULTIES.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In DGV_FACULTIES.SelectedRows
                Dim facultyId As Integer = selectedRow.Cells(0).Value
                facultiesIdList.Add(facultyId)
            Next
            If (FacultiesController.delete(facultiesIdList)) Then
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        checkButtons()
    End Sub
    Private Sub TB_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_SEARCH.TextChanged
        DGV_FACULTIES.DataSource = FacultiesController.search(TB_SEARCH.Text)
    End Sub

    Private Sub DGV_FACULTIES_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_FACULTIES.CellClick
        TB_LIBELLE.Text = DGV_FACULTIES.SelectedRows(0).Cells(1).Value
        TB_SIGLE.Text = DGV_FACULTIES.SelectedRows(0).Cells(2).Value
        CB_INSTITUTE.SelectedItem = DGV_FACULTIES.SelectedRows(0).Cells(3).Value
        checkButtons()
    End Sub
End Class
