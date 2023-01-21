Public Class UEsView
    Private Sub UEsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BT_REFRESH_Click(Nothing, Nothing)
        Recharge_CLB_CAREERS()
        ResizeDataGridViewRowHeight()
    End Sub
    Public Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        ReloadCB_INSTITUTE()
        DGV_UES.DataSource = UEsController.getAll()
        checkButtons()
    End Sub
    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If (UEsController.insert(TB_LIBELLE.Text, CB_SEMESTER.SelectedItem, getCareerSelectedIdList())) Then
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
                If (UEsController.update(TB_LIBELLE.Text, CB_SEMESTER.SelectedItem, getCareerSelectedIdList(), ueId)) Then
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
        UnCheckCLB_CAREERS()
        For i As Integer = 0 To CLB_CAREERS.Items.Count - 1
            If DGV_UES.SelectedRows(0).Cells(3).Value.Contains(CLB_CAREERS.Items(i).Split(" - ")(0).Split("-")(1)) Then
                CLB_CAREERS.SetItemChecked(i, True)
            End If
        Next
    End Sub


    Private Sub TB_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_SEARCH.TextChanged
        DGV_UES.DataSource = UEsController.search(TB_SEARCH.Text)
    End Sub

    Private Sub CB_INSTITUTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INSTITUTE.SelectedIndexChanged
        Recharge_CLB_CAREERS()
    End Sub




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
    Public Sub ResizeDataGridViewRowHeight()
        DGV_UES.AutoSize = False
        DGV_UES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV_UES.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DGV_UES.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub
    Public Sub ReloadCB_INSTITUTE()
        CB_INSTITUTE.Items.Clear()
        For Each institute As Institute In InstitutesManager.getAll()
            CB_INSTITUTE.Items.Add(institute.Id & "-" & institute.Sigle & " - " & institute.Libelle)
        Next

        Dim instituteExist As Boolean = CB_INSTITUTE.Items.Count > 0
        BT_ADD.Enabled = instituteExist
        BT_UPDATE.Enabled = instituteExist
        BT_DELETE.Enabled = instituteExist
        If instituteExist Then
            CB_INSTITUTE.SelectedIndex = 0
        Else
            CB_INSTITUTE.SelectedIndex = -1
        End If
    End Sub
    Private Sub Recharge_CLB_CAREERS()
        CLB_CAREERS.BeginUpdate()
        CLB_CAREERS.Items.Clear()
        For Each career In CareersManager.getByInstituteId(CInt(CB_INSTITUTE.SelectedItem().split("-")(0)))
            CLB_CAREERS.Items.Add(career.Name)
        Next

        CLB_CAREERS.EndUpdate()
    End Sub
    Private Sub UnCheckCLB_CAREERS()
        For i As Integer = 0 To CLB_CAREERS.Items.Count - 1
            CLB_CAREERS.SetItemChecked(i, False)
        Next
    End Sub
    Private Function getCareerSelectedIdList() As List(Of Integer)
        Dim careerIdList As New List(Of Integer)()
        For Each selectedItem In CLB_CAREERS.CheckedItems
            careerIdList.Add(CInt(selectedItem.ToString().Split("-")(0)))
        Next
        Return careerIdList
    End Function
End Class
