Public Class TeacherViewForm
    Private Sub TeacherView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Recharge_CB_ECUES()
        BT_REFRESH_Click(Nothing, Nothing)
    End Sub
    Private Sub CB_ECUES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ECUES.SelectedIndexChanged
        Recharge_CB_Students("")
        DGV_EVALUATIONS.DataSource = EvaluationsController.getByECUEId(CInt(CB_ECUES.SelectedItem().Split("-")(0)))
    End Sub
    Private Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        Recharge_CB_Students("")
        DGV_EVALUATIONS.DataSource = EvaluationsController.getByECUEId(CInt(CB_ECUES.SelectedItem().Split("-")(0)))
    End Sub
    Private Sub TB_STUDENT_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_STUDENT_SEARCH.TextChanged
        Recharge_CB_Students(TB_STUDENT_SEARCH.Text)
    End Sub
    Private Sub DGV_EVALUATIONS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_EVALUATIONS.CellClick
        CB_STUDENTS.SelectedItem = DGV_EVALUATIONS.SelectedRows(0).Cells(1).Value
        CB_WEIGHT.SelectedItem = DGV_EVALUATIONS.SelectedRows(0).Cells(2).Value.ToString() & "%"
        CB_ECUES.SelectedItem = DGV_EVALUATIONS.SelectedRows(0).Cells(3).Value
        DTP_DATE.Value = DGV_EVALUATIONS.SelectedRows(0).Cells(4).Value
        CB_TYPE.SelectedItem = DGV_EVALUATIONS.SelectedRows(0).Cells(5).Value
        TB_GRADE.Text = DGV_EVALUATIONS.SelectedRows(0).Cells(6).Value
    End Sub
    Private Sub B_PRINT_Click(sender As Object, e As EventArgs) Handles B_PRINT.Click
        Dim report As New EvaluationReport()
        report.SetDataSource(EvaluationsController.getAllForReport(CInt(CB_ECUES.SelectedItem().Split("-")(0))))
        CrystalReportViewerForm.CRV.ReportSource = report
        CrystalReportViewerForm.Show()
    End Sub
    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_INSCRIBE.Click
        If EvaluationsController.insert(CInt(CB_ECUES.SelectedItem().Split("-")(0)), CInt(CB_STUDENTS.SelectedItem().Split("-")(0)), DTP_DATE.Value, CB_TYPE.SelectedItem, CInt(CB_WEIGHT.SelectedItem.Split("%")(0)), CInt(TB_GRADE.Text)) Then
            BT_REFRESH_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        If EvaluationsController.update(CInt(CB_ECUES.SelectedItem().Split("-")(0)), CInt(CB_STUDENTS.SelectedItem().Split("-")(0)), DTP_DATE.Value, CB_TYPE.SelectedItem, CInt(CB_WEIGHT.SelectedItem.Split("%")(0)), CInt(TB_GRADE.Text), CInt(DGV_EVALUATIONS.SelectedRows(0).Cells(0).Value)) Then
            BT_REFRESH_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BT_DELETE_Click(sender As Object, e As EventArgs) Handles BT_DELETE.Click
        Dim uesIdList As New List(Of Integer)()
        If DGV_EVALUATIONS.SelectedRows.Count > 0 Then
            For Each selectedRow As DataGridViewRow In DGV_EVALUATIONS.SelectedRows
                Dim ueId As Integer = selectedRow.Cells(0).Value
                uesIdList.Add(ueId)
            Next
            If (EvaluationsController.delete(uesIdList)) Then
                BT_REFRESH_Click(Nothing, Nothing)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub BT_LOGOUT_Click(sender As Object, e As EventArgs) Handles BT_LOGOUT.Click
        JohnController.Logout()
    End Sub
    Private Sub COB_CLOSE_Click(sender As Object, e As EventArgs) Handles COB_CLOSE.Click
        Manager.Close()
        End
    End Sub





    Private Sub EnableButton(value As Boolean)
        BT_INSCRIBE.Enabled = value
        BT_UPDATE.Enabled = value
        BT_DELETE.Enabled = value
    End Sub
    Public Sub Recharge_CB_ECUES()
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

    Public Sub Recharge_CB_Students(word As String)
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
End Class