Public Class TuititionServiceView
    Private Sub TuititionServiceView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BT_LOGOUT_Click(sender As Object, e As EventArgs) Handles BT_LOGOUT.Click
        JohnController.Logout()
    End Sub

    Private Sub COB_CLOSE_Click(sender As Object, e As EventArgs) Handles COB_CLOSE.Click
        Manager.Close()
        End
    End Sub
End Class