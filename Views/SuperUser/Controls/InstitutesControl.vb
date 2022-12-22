Public Class InstitutesControl
    Private Sub clearForm()
        TB_LIBELLE.Text = ""
        TB_SIGLE.Text = ""
    End Sub

    Private Sub InstitutesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_INSITUTES.DataSource = InsitutesController.getAll()
    End Sub

    Private Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        DGV_INSITUTES.DataSource = InsitutesController.getAll()
    End Sub
End Class
