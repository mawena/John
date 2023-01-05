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

    Private Sub UEsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
