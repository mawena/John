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

    Private Sub ECUEsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        checkButtons()
    End Sub
End Class
