Public Class FacultiesControl

    Private Sub ClearForm()
        TB_LIBELLE.Text = ""
        TB_SIGLE.Text = ""
        CB_INSTITUTE.SelectedIndex = 0
    End Sub

    Public Sub refreshCB_INSTITUTE()
        CB_INSTITUTE.Items.Clear()
        Dim institutesList As List(Of Institute) = InstitutesManager.getAll()
        For Each institute As Institute In institutesList
            CB_INSTITUTE.Items.Add(institute.Sigle & " - " & institute.Libelle)
        Next
        CB_INSTITUTE.SelectedIndex = 0
    End Sub

    Private Sub FacultiesControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshCB_INSTITUTE()
    End Sub
End Class
