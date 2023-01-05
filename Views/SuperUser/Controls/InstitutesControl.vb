Public Class InstitutesControl
    Private Sub ClearForm()
        TB_LIBELLE.Text = ""
        TB_SIGLE.Text = ""
    End Sub

    Private Sub CheckButtons()
        Dim nbRowSelected = DGV_INSTITUTES.SelectedRows.Count
        If nbRowSelected > 0 Then
            BT_DELETE.Enabled = True
            BT_UPDATE.Enabled = True
        Else
            BT_DELETE.Enabled = False
            BT_UPDATE.Enabled = False
        End If
    End Sub

    Private Sub InstitutesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_INSTITUTES.DataSource = InstitutesController.getAll()
        CheckButtons()
    End Sub

    Public Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        DGV_INSTITUTES.DataSource = InstitutesController.getAll()
        CheckButtons()
    End Sub

    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If InstitutesController.store(TB_LIBELLE.Text, TB_SIGLE.Text) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
        CheckButtons()
    End Sub

    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        Dim nbRowSelected = DGV_INSTITUTES.SelectedRows.Count
        If nbRowSelected > 0 Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = DGV_INSTITUTES.SelectedRows(0)
                Dim instituteId As Integer = selectedRow.Cells(0).Value
                If InstitutesController.update(TB_LIBELLE.Text, TB_SIGLE.Text, instituteId) Then
                    ClearForm()
                    BT_REFRESH_Click(Nothing, Nothing)
                End If
            Else
                MessageBox.Show("Vous ne pouvez modifier qu'une ligne à la fois", "Modification multiple non permise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Ligne non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CheckButtons()
    End Sub

    Private Sub BT_DELETE_Click(sender As Object, e As EventArgs) Handles BT_DELETE.Click
        Dim instituteIdList As New List(Of Integer)()
        If DGV_INSTITUTES.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In DGV_INSTITUTES.SelectedRows
                Dim instituteId As Integer = selectedRow.Cells(0).Value
                instituteIdList.Add(instituteId)
            Next
            If (InstitutesController.delete(instituteIdList)) Then
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CheckButtons()
    End Sub

    Private Sub TB_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_SEARCH.TextChanged
        DGV_INSTITUTES.DataSource = InstitutesController.searchInstitutes(TB_SEARCH.Text)
    End Sub

    Private Sub DGV_INSTITUTES_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_INSTITUTES.CellClick
        TB_LIBELLE.Text = DGV_INSTITUTES.SelectedRows(0).Cells(1).Value
        TB_SIGLE.Text = DGV_INSTITUTES.SelectedRows(0).Cells(2).Value
    End Sub
End Class
