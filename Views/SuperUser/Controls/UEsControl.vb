Public Class UEsControl

    Public Sub ClearForm()
        TB_LIBELLE.Text = ""
    End Sub

    Public Sub checkButtons()
        Dim nbRowSelected = DGV_UES.SelectedRows.Count
        If nbRowSelected > 0 Then
            BT_DELETE.Enabled = True
            BT_UPDATE.Enabled = True
        Else
            BT_DELETE.Enabled = False
            BT_UPDATE.Enabled = False
        End If
    End Sub

    Public Sub refreshCB_FACULTY()
        CB_FACULTY.Items.Clear()
        For Each faculty As Faculty In FacultiesManager.getAll()
            CB_FACULTY.Items.Add(faculty.Id & "-" & faculty.Sigle & " - " & faculty.Libelle)
        Next

        Dim facultyExist As Boolean = CB_FACULTY.Items.Count > 0
        BT_ADD.Enabled = facultyExist
        BT_UPDATE.Enabled = facultyExist
        BT_DELETE.Enabled = facultyExist
        If facultyExist Then
            CB_FACULTY.SelectedIndex = 0
        Else
            CB_FACULTY.SelectedIndex = -1
        End If
    End Sub

    Private Sub UEsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BT_REFRESH_Click(Nothing, Nothing)
    End Sub

    Public Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        refreshCB_FACULTY()
        DGV_UES.DataSource = UEsController.getAll()
        checkButtons()
    End Sub

    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If (UEsController.store(TB_LIBELLE.Text, CB_SEMESTER.SelectedItem, CB_FACULTY.SelectedItem.ToString())) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
        checkButtons()
    End Sub

    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        Dim nbRowSelected = DGV_UES.SelectedRows.Count
        If nbRowSelected > 0 Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = DGV_UES.SelectedRows(0)
                Dim ueId As Integer = selectedRow.Cells(0).Value
                If (UEsController.update(TB_LIBELLE.Text, CB_SEMESTER.SelectedItem, CB_FACULTY.SelectedItem.ToString(), ueId)) Then
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
        Dim uesIdList As New List(Of Integer)()
        If DGV_UES.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In DGV_UES.SelectedRows
                Dim ueId As Integer = selectedRow.Cells(0).Value
                uesIdList.Add(ueId)
            Next
            If (UEsController.delete(uesIdList)) Then
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        checkButtons()
    End Sub

    Private Sub DGV_UES_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_UES.CellClick
        TB_LIBELLE.Text = DGV_UES.SelectedRows(0).Cells(1).Value
        CB_SEMESTER.SelectedItem = DGV_UES.SelectedRows(0).Cells(2).Value
        CB_FACULTY.SelectedItem = DGV_UES.SelectedRows(0).Cells(3).Value
    End Sub

    Private Sub TB_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_SEARCH.TextChanged
        DGV_UES.DataSource = UEsController.search(TB_SEARCH.Text)
    End Sub
End Class
