Public Class TeacherView
    Private Sub TeacherView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BT_REFRESH_Click(Nothing, Nothing)
    End Sub


    Private Sub CB_ECUES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ECUES.SelectedIndexChanged
        Reload_CB_Students("")
    End Sub
    Private Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        Reload_CB_ECUES()
        Reload_CB_Students("")
        DGV_EVALUATIONS.DataSource = EvaluationsController.getAll()
    End Sub
    Private Sub TB_STUDENT_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_STUDENT_SEARCH.TextChanged
        Reload_CB_Students(TB_STUDENT_SEARCH.Text)
    End Sub


    Private Sub EnableButton(value As Boolean)
        BT_ADD.Enabled = value
        BT_UPDATE.Enabled = value
        BT_DELETE.Enabled = value
    End Sub
    Public Sub Reload_CB_ECUES()
        CB_ECUES.Items.Clear()
        For Each ecue As ECUE In ECUEsManager.getByEmployeeId(JohnController.user.Employee.Id)
            CB_ECUES.Items.Add(ecue.Name)
        Next

        Dim institutesExist As Boolean = CB_ECUES.Items.Count > 0
        EnableButton(institutesExist)
        If institutesExist Then
            CB_ECUES.SelectedIndex = 0
        Else
            CB_ECUES.SelectedIndex = -1
        End If
    End Sub

    Public Sub Reload_CB_Students(word As String)
        If CB_ECUES.Items.Count > 0 Then
            CB_STUDENTS.Items.Clear()
            Dim studentsList As List(Of Student) = StudentsManager.getByECUEId(CInt(CB_ECUES.SelectedItem.Split("-")(0)))
            For Each student As Student In studentsList
                If word <> Nothing Or word = "" Then
                    If student.Name.ToLower().Contains(word.ToLower()) Or word = "" Then
                        CB_STUDENTS.Items.Add(student.Name)
                    End If
                End If
            Next

            Dim studentsExist As Boolean = CB_STUDENTS.Items.Count > 0
            EnableButton(studentsExist)
            If studentsExist Then
                CB_STUDENTS.SelectedIndex = 0
            Else
                CB_STUDENTS.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub BT_LOGOUT_Click(sender As Object, e As EventArgs) Handles BT_LOGOUT.Click
        JohnController.Logout()
    End Sub


    Private Sub COB_CLOSE_Click(sender As Object, e As EventArgs) Handles COB_CLOSE.Click
        Manager.Close()
        End
    End Sub
End Class