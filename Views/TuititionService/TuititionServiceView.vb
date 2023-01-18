Public Class TuititionServiceView
    Private Sub TuititionServiceView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BT_REFRESH_Click(Nothing, Nothing)
    End Sub
    Private Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        Reload_CB_INSTITUTE()
        Reload_CB_CAREER()
    End Sub
    Private Sub CB_INSTITUTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INSTITUTE.SelectedIndexChanged
        Reload_CB_CAREER()
    End Sub

    Private Sub CB_ADD_PICTURE_Click(sender As Object, e As EventArgs) Handles CB_ADD_PICTURE.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "C:\"
        openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JEPG;*.PNG;*.GIF"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Code pour traiter l'image sélectionnée
        End If
    End Sub
    Private Sub BT_LOGOUT_Click(sender As Object, e As EventArgs) Handles BT_LOGOUT.Click
        JohnController.Logout()
    End Sub
    Private Sub COB_CLOSE_Click(sender As Object, e As EventArgs) Handles COB_CLOSE.Click
        Manager.Close()
        End
    End Sub



    Private Sub ClearForm()
        TB_LAST_NAME.Text = ""
        TB_FIRST_NAME.Text = ""
        TB_EMAIL.Text = ""
        TB_PHONE_NUMBER.Text = ""
    End Sub
    Private Sub EnableButtons(value As Boolean)
        BT_ADD.Enabled = value
        BT_UPDATE.Enabled = value
        BT_DELETE.Enabled = value
    End Sub
    Private Function selectGoodIndex(value As Boolean) As Integer
        If value Then
            Return 0
        Else
            Return -1
        End If
    End Function
    Public Sub Reload_CB_INSTITUTE()
        CB_INSTITUTE.Items.Clear()
        For Each institute As Institute In InstitutesManager.getAll()
            CB_INSTITUTE.Items.Add(institute.Name)
        Next
        Dim institutesExist As Boolean = CB_INSTITUTE.Items.Count > 0
        EnableButtons(institutesExist)
        CB_INSTITUTE.SelectedIndex = selectGoodIndex(institutesExist)
    End Sub

    Public Sub Reload_CB_CAREER()
        CB_CAREER.Items.Clear()
        If (CB_INSTITUTE.Items.Count > 0) Then
            For Each career As Career In CareersManager.getByInstituteId(CInt(CB_INSTITUTE.SelectedItem.Split("-")(0)))
                CB_CAREER.Items.Add(career.Name)
            Next
            Dim careersExist As Boolean = CB_CAREER.Items.Count > 0
            EnableButtons(careersExist)
            CB_CAREER.SelectedIndex = selectGoodIndex(careersExist)
        End If
    End Sub
End Class