Public Class ECUEsControl
    Private Sub ECUEsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BT_REFRESH_Click(Nothing, Nothing)
        ClearForm()
    End Sub
    Public Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        DGV_ECUES.DataSource = ECUEsController.getAll()
        Reload_CB_TEACHER()
        Reload_CLB_UES()
        ResizeDataGridViewRowHeight()
        CheckButtons()
    End Sub
    Private Sub DGV_ECUES_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ECUES.CellClick
        TB_LIBELLE.Text = DGV_ECUES.SelectedRows(0).Cells(1).Value
        CB_NB_CREDIT.SelectedItem = DGV_ECUES.SelectedRows(0).Cells(2).Value
        CB_TEACHER.SelectedItem = DGV_ECUES.SelectedRows(0).Cells(3).Value
        UnCheck_CLB_UES_Items()
        For i As Integer = 0 To CLB_UES.Items.Count - 1
            If DGV_ECUES.SelectedRows(0).Cells(4).Value.Contains(CLB_UES.Items(i)) Then
                CLB_UES.SetItemChecked(i, True)
            End If
        Next

    End Sub
    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        Dim ueNameSelectedList As New List(Of String)
        For Each selectedItem In CLB_UES.CheckedItems
            ueNameSelectedList.Add(selectedItem.ToString())
        Next

        If ECUEsController.store(TB_LIBELLE.Text, CInt(CB_NB_CREDIT.SelectedItem), CB_TEACHER.Text, ueNameSelectedList) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        Dim ueNameSelectedList As New List(Of String)
        For Each selectedItem In CLB_UES.CheckedItems
            ueNameSelectedList.Add(selectedItem.ToString())
        Next
        If ECUEsController.update(TB_LIBELLE.Text, CInt(CB_NB_CREDIT.SelectedItem), CB_TEACHER.Text, ueNameSelectedList, DGV_ECUES.SelectedRows(0).Cells(0).Value) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BT_DELETE_Click(sender As Object, e As EventArgs) Handles BT_DELETE.Click
        Dim ecueIdList As New List(Of Integer)()
        If DGV_ECUES.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In DGV_ECUES.SelectedRows
                Dim ecueId As Integer = selectedRow.Cells(0).Value
                ecueIdList.Add(ecueId)
            Next
            If (ECUEsController.delete(ecueIdList)) Then
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CheckButtons()
    End Sub
    Private Sub TB_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_SEARCH.TextChanged
        DGV_ECUES.DataSource = ECUEsController.search(TB_SEARCH.Text)
    End Sub



    Public Sub ClearForm()
        TB_LIBELLE.Text = ""
        Reload_CB_TEACHER()
        Reload_CLB_UES()
        CheckButtons()
    End Sub
    Public Sub CheckButtons()
        Dim nbRowSelected = DGV_ECUES.SelectedRows.Count
        If nbRowSelected > 0 Then
            BT_DELETE.Enabled = True
            BT_UPDATE.Enabled = True
        Else
            BT_DELETE.Enabled = False
            BT_UPDATE.Enabled = False
        End If
    End Sub
    Public Sub Reload_CB_TEACHER()
        CB_TEACHER.Items.Clear()
        For Each teacher In ECUEsController.getTeacherNameList()
            CB_TEACHER.Items.Add(teacher)
        Next

        Dim careerExist As Boolean = CB_TEACHER.Items.Count > 0
        BT_ADD.Enabled = careerExist
        BT_UPDATE.Enabled = careerExist
        BT_DELETE.Enabled = careerExist
        If careerExist Then
            CB_TEACHER.SelectedIndex = 0
        Else
            CB_TEACHER.SelectedIndex = -1
        End If
    End Sub
    Public Sub Reload_CLB_UES()
        CLB_UES.BeginUpdate()
        CLB_UES.Items.Clear()
        For Each ueName In ECUEsController.getEUNameList()
            CLB_UES.Items.Add(ueName)
        Next

        CLB_UES.EndUpdate()
    End Sub
    Public Sub ResizeDataGridViewRowHeight()
        DGV_ECUES.AutoSize = False
        DGV_ECUES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV_ECUES.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DGV_ECUES.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Public Sub UnCheck_CLB_UES_Items()
        For i As Integer = 0 To CLB_UES.Items.Count - 1
            CLB_UES.SetItemChecked(i, False)
        Next
    End Sub
End Class
