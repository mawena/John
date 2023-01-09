Public Class ECUEsControl
    Public Sub ClearForm()
        TB_LIBELLE.Text = ""
    End Sub

    Public Sub checkButtons()
        Dim nbRowSelected = DGV_ECUES.SelectedRows.Count
        If nbRowSelected > 0 Then
            BT_DELETE.Enabled = True
            BT_UPDATE.Enabled = True
        Else
            BT_DELETE.Enabled = False
            BT_UPDATE.Enabled = False
        End If
    End Sub

    Public Sub RefreshUEList()
        CLB_UES.BeginUpdate()
        CLB_UES.Items.Clear()

        For Each ueName In ECUEsController.getEUsList()
            CLB_UES.Items.Add(ueName)
        Next

        CLB_UES.EndUpdate()
    End Sub

    Public Sub ResizeDataGridViewRowHeight()
        DGV_ECUES.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        For i As Integer = 0 To DGV_ECUES.RowCount - 1
            DGV_ECUES.Rows(i).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub


    Private Sub ECUEsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_ECUES.DataSource = ECUEsController.getAll()
        RefreshUEList()
        ResizeDataGridViewRowHeight()
        checkButtons()
    End Sub

End Class
