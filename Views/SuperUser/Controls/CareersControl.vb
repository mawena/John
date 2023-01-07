Public Class CareersControl

    Private Sub ClearForm()
        TB_LIBELLE.Text = ""
        TB_SIGLE.Text = ""
        CB_INSTITUTE.SelectedIndex = 0
    End Sub

    Public Sub checkButtons()
        Dim nbRowSelected = DGV_CAREERS.SelectedRows.Count
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
        For Each institute As Institute In InstitutesManager.getAll()
            CB_INSTITUTE.Items.Add(institute.Id & "-" & institute.Sigle & " - " & institute.Libelle)
        Next
        Dim institutesExist As Boolean = CB_INSTITUTE.Items.Count > 0
        BT_ADD.Enabled = institutesExist
        BT_UPDATE.Enabled = institutesExist
        BT_DELETE.Enabled = institutesExist
        If institutesExist Then
            CB_INSTITUTE.SelectedIndex = 0
        Else
            CB_INSTITUTE.SelectedIndex = -1
        End If
    End Sub

    Private Sub CareersControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshCB_INSTITUTE()
        DGV_CAREERS.DataSource = CareersController.getAll()
        checkButtons()
    End Sub

    Public Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        DGV_CAREERS.DataSource = CareersController.getAll()
        checkButtons()
    End Sub

    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If (CareersController.store(TB_LIBELLE.Text, TB_SIGLE.Text, CB_INSTITUTE.SelectedItem.ToString())) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
        checkButtons()
    End Sub

    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        Dim nbRowSelected = DGV_CAREERS.SelectedRows.Count
        If nbRowSelected > 0 Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = DGV_CAREERS.SelectedRows(0)
                Dim careerId As Integer = selectedRow.Cells(0).Value
                If (CareersController.update(TB_LIBELLE.Text, TB_SIGLE.Text, CB_INSTITUTE.SelectedItem.ToString(), careerId)) Then
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
        Dim careersIdList As New List(Of Integer)()
        If DGV_CAREERS.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In DGV_CAREERS.SelectedRows
                Dim careerId As Integer = selectedRow.Cells(0).Value
                careersIdList.Add(careerId)
            Next
            If (CareersController.delete(careersIdList)) Then
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        checkButtons()
    End Sub
    Private Sub TB_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_SEARCH.TextChanged
        DGV_CAREERS.DataSource = CareersController.search(TB_SEARCH.Text)
    End Sub

    Private Sub DGV_CAREERS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CAREERS.CellClick
        TB_LIBELLE.Text = DGV_CAREERS.SelectedRows(0).Cells(1).Value
        TB_SIGLE.Text = DGV_CAREERS.SelectedRows(0).Cells(2).Value
        CB_INSTITUTE.SelectedItem = DGV_CAREERS.SelectedRows(0).Cells(3).Value
        checkButtons()
    End Sub
End Class
