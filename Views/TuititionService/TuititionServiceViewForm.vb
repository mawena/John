Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class TuititionServiceViewForm
    Private Sub TuititionServiceView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeDataGridViewRowHeight()
        PB_STUDENT.ImageLocation = Student.PicturePathDefault
        Recharge_CB_INSTITUTE()
        Recharge_CB_CAREER()
        DGV_STUDENTS.DataSource = StudentsController.getByCareerIdAndSemester(CInt(CB_CAREER.SelectedItem.Split("-")(0)), CInt(CB_SEMESTER.SelectedItem))
    End Sub
    Private Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click
        'ResizeDataGridViewRowHeight()
        If CB_CAREER.Items.Count > 0 Then
            DGV_STUDENTS.DataSource = StudentsController.getByCareerIdAndSemester(CInt(CB_CAREER.SelectedItem.Split("-")(0)), CInt(CB_SEMESTER.SelectedItem))
        End If
    End Sub
    Private Sub TB_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TB_SEARCH.TextChanged
        If CB_CAREER.Items.Count > 0 Then
            DGV_STUDENTS.DataSource = StudentsController.search(CInt(CB_CAREER.SelectedItem.Split("-")(0)), CInt(CB_SEMESTER.SelectedItem), TB_SEARCH.Text)
        End If
    End Sub
    Private Sub CB_SEMESTER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_SEMESTER.SelectedIndexChanged
        BT_REFRESH_Click(Nothing, Nothing)
    End Sub
    Private Sub CB_INSTITUTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INSTITUTE.SelectedIndexChanged
        Recharge_CB_CAREER()
    End Sub
    Private Sub DGV_STUDENTS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_STUDENTS.CellClick
        Dim student As Student = StudentsManager.getById(CInt(DGV_STUDENTS.SelectedRows(0).Cells(0).Value))
        PB_STUDENT.ImageLocation = student.PicturePath
        TB_LAST_NAME.Text = DGV_STUDENTS.SelectedRows(0).Cells(1).Value
        TB_FIRST_NAME.Text = DGV_STUDENTS.SelectedRows(0).Cells(2).Value
        TB_PHONE_NUMBER.Text = DGV_STUDENTS.SelectedRows(0).Cells(4).Value
        CB_GENDER.SelectedItem = DGV_STUDENTS.SelectedRows(0).Cells(5).Value
        TB_EMAIL.Text = DGV_STUDENTS.SelectedRows(0).Cells(6).Value
        DTP_DATE.Value = DGV_STUDENTS.SelectedRows(0).Cells(7).Value
        CB_CAREER.SelectedItem = DGV_STUDENTS.SelectedRows(0).Cells(8).Value
    End Sub
    Private Sub B_PRINT_Click(sender As Object, e As EventArgs) Handles B_PRINT_STUDENT_LIST.Click
        Dim report As New StudentsReport2()
        report.SetDataSource(StudentsController.getAllForReport(CInt(CB_CAREER.SelectedItem.Split("-")(0)), CInt(CB_SEMESTER.SelectedItem)))
        report.SetParameterValue("semester", CB_SEMESTER.SelectedItem)
        CrystalReportViewerForm.CRV.ReportSource = report
        CrystalReportViewerForm.Show()
    End Sub
    Private Sub BT_PRINT_STUDENT_REPORT_Click(sender As Object, e As EventArgs) Handles BT_PRINT_STUDENT_REPORT.Click
        Dim report As New StudentGradesReport()
        Dim student As Student = StudentsManager.getById(CInt(DGV_STUDENTS.SelectedRows(0).Cells(0).Value))
        Dim studentGradeDataTable As DataTable = EvaluationsController.getForStudentReport(CInt(CB_CAREER.SelectedItem.Split("-")(0)), CInt(CB_SEMESTER.SelectedItem), student.Id)
        If studentGradeDataTable.Rows.Count > 0 Then
            Dim sum = 0
            For Each row As DataRow In studentGradeDataTable.Rows
                sum = sum + CInt(row("GradeSessionOne"))
            Next

            report.SetDataSource(studentGradeDataTable)
            report.SetParameterValue("semester", CB_SEMESTER.SelectedItem)
            File.Copy(student.PicturePath, "..\..\Data\Pictures\Students\tmp.png")
            report.SetParameterValue("studentPicture", Path.GetFullPath("..\..\Data\Pictures\Students\tmp.png"))
            'report.SetParameterValue("studentPicture", "C:\Users\mawena\Downloads\amon.jpg")
            report.SetParameterValue("studentLastName", student.LastName)
            report.SetParameterValue("studentFirstName", student.FirstName)
            report.SetParameterValue("studentPhoneNumber", student.PhoneNumber)
            report.SetParameterValue("studentGender", student.Gender)
            report.SetParameterValue("studentEmail", student.Email)
            report.SetParameterValue("studentCareer", student.Career.Libelle)
            report.SetParameterValue("moy", sum / studentGradeDataTable.Rows.Count)


            CrystalReportViewerForm.CRV.ReportSource = report
            CrystalReportViewerForm.Show()

        Else
            MessageBox.Show("Cette étudiant n'a aucune note", "Aucune Note", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub CB_ADD_PICTURE_Click(sender As Object, e As EventArgs) Handles B_ADD_PICTURE.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = "."
        openFileDialog.Filter = "Images (*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF|" & "All files (*.*)|*.*"
        openFileDialog.Title = "Sélectionnez une image"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog.FileName
            Dim sourceFile As String = openFileDialog.FileName
            PB_STUDENT.ImageLocation = sourceFile
        End If
    End Sub
    Private Sub BT_ADD_Click(sender As Object, e As EventArgs) Handles BT_ADD.Click
        If StudentsController.insert(TB_LAST_NAME.Text, TB_FIRST_NAME.Text, DTP_DATE.Value, CB_GENDER.SelectedItem, TB_EMAIL.Text, TB_PHONE_NUMBER.Text, PB_STUDENT.ImageLocation, CB_CAREER.SelectedItem.Split("-")(0), CInt(CB_SEMESTER.SelectedItem)) Then
            ClearForm()
            BT_REFRESH_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        Dim nbRowSelected = DGV_STUDENTS.SelectedRows.Count
        If nbRowSelected > 0 Then
            If nbRowSelected = 1 Then
                Dim selectedRow As DataGridViewRow = DGV_STUDENTS.SelectedRows(0)
                Dim newImagePath As String = PB_STUDENT.ImageLocation
                PB_STUDENT.ImageLocation = "..\..\Data\Pictures\Students\default.png"
                Dim studentId As Integer = selectedRow.Cells(0).Value
                selectedRow.Cells(3).Value.Dispose()
                selectedRow.Cells(3).Value = Nothing
                If StudentsController.update(TB_LAST_NAME.Text, TB_FIRST_NAME.Text, DTP_DATE.Value, CB_GENDER.SelectedItem, TB_EMAIL.Text, TB_PHONE_NUMBER.Text, newImagePath, CB_CAREER.SelectedItem.Split("-")(0), CInt(CB_SEMESTER.SelectedItem), studentId) Then
                    ClearForm()
                    BT_REFRESH_Click(Nothing, Nothing)
                End If
            Else
                MessageBox.Show("Vous ne pouvez modifier qu'une ligne à la fois", "Modification multiple non permise", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Ligne non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub BT_UNSCRIBE_Click(sender As Object, e As EventArgs) Handles BT_UNSCRIBE.Click
        PB_STUDENT.ImageLocation = Student.PicturePathDefault
        Dim response As Boolean = False
        If DGV_STUDENTS.SelectedRows.Count > 0 Then
            If (MessageBox.Show("Etes vous sûr de vouloir désincrire cet(s) étudiants(s)?", "Confirmation de désinscripton", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                response = True
                For Each selectedRow As DataGridViewRow In DGV_STUDENTS.SelectedRows
                    Dim studentId As Integer = selectedRow.Cells(0).Value
                    If StudentsController.unscribeInSemester(CInt(CB_SEMESTER.SelectedItem), studentId) Then
                        BT_REFRESH_Click(Nothing, Nothing)
                    End If
                Next
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If response Then
            ClearForm()
        End If
    End Sub
    Private Sub BT_DELETE_Click(sender As Object, e As EventArgs) Handles BT_DELETE.Click
        PB_STUDENT.ImageLocation = Student.PicturePathDefault
        Dim response As Boolean = False
        If DGV_STUDENTS.SelectedRows.Count > 0 Then
            If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) étudiants(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                response = True
                For Each selectedRow As DataGridViewRow In DGV_STUDENTS.SelectedRows
                    Dim studentId As Integer = selectedRow.Cells(0).Value
                    Dim student As Student = StudentsManager.getById(studentId)
                    PB_STUDENT.ImageLocation = "..\..\Data\Pictures\Students\default.png"
                    selectedRow.Cells(3).Value.Dispose()
                    selectedRow.Cells(3).Value = Nothing
                    If StudentsController.delete(studentId) Then
                        File.Delete(student.PicturePath)
                        ClearForm()
                    Else
                        response = False
                    End If
                Next
            End If
        Else
            MessageBox.Show("Aucune ligne n'a été sélectionnée.", "Lignes non selectionné", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If response Then
            ClearForm()
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
    Public Sub Recharge_CB_INSTITUTE()
        CB_INSTITUTE.Items.Clear()
        For Each institute As Institute In InstitutesManager.getAll()
            CB_INSTITUTE.Items.Add(institute.Name)
        Next
        Dim institutesExist As Boolean = CB_INSTITUTE.Items.Count > 0
        EnableButtons(institutesExist)
        CB_INSTITUTE.SelectedIndex = selectGoodIndex(institutesExist)
    End Sub
    Public Sub Recharge_CB_CAREER()
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
    Public Sub ResizeDataGridViewRowHeight()
        DGV_STUDENTS.AutoSize = False
        DGV_STUDENTS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV_STUDENTS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DGV_STUDENTS.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub
End Class