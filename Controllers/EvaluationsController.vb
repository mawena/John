Public Class EvaluationsController
    Public Shared Function getTmpLit(evaluationsList As List(Of Evaluation)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("id", GetType(Integer))
        table.Columns.Add("studentName", GetType(String))
        table.Columns.Add("weightField", GetType(String))
        table.Columns.Add("ecueName", GetType(String))
        table.Columns.Add("dateField", GetType(String))
        table.Columns.Add("typeField", GetType(String))
        table.Columns.Add("grade", GetType(Integer))

        For Each evaluation As Evaluation In evaluationsList
            table.LoadDataRow(New Object() {evaluation.Id, evaluation.Student.Name, evaluation.Weight & "%", evaluation.ECUE.Name, evaluation.DateField, evaluation.Type, evaluation.Grade}, True)
        Next
        Return table
    End Function

    Public Shared Function getAllForReport(ecueId As Integer) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Id", GetType(Integer))
        table.Columns.Add("StudentName", GetType(String))
        table.Columns.Add("Grade", GetType(Integer))
        table.Columns.Add("DateField", GetType(String))
        table.Columns.Add("Weight", GetType(Integer))
        table.Columns.Add("Type", GetType(String))

        For Each evaluation As Evaluation In EvaluationsManager.getByECUEId(ecueId)
            table.LoadDataRow(New Object() {evaluation.Id, evaluation.StudentName, evaluation.Grade, evaluation.DateField, evaluation.Weight, evaluation.Type}, True)
        Next
        Return table
    End Function

    Public Shared Function getForStudentReport(careerId As Integer, semester As Integer, studentId As Integer) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("ecueName", GetType(String))
        table.Columns.Add("ueName", GetType(String))
        table.Columns.Add("credit", GetType(Integer))
        table.Columns.Add("gradeSessionOne", GetType(String))
        table.Columns.Add("gradeSessionTwo", GetType(String))
        table.Columns.Add("CreditObtained", GetType(Integer))
        table.Columns.Add("Decision", GetType(String))

        For Each ecue As ECUE In ECUEsManager.getByCareerIdAndSemester(careerId, semester)
            Dim sum As Integer = 0
            Dim evaluationList = EvaluationsManager.getByECUEId_careerId_semester_studentId(ecue.Id, careerId, semester, studentId)
            For Each evaluation As Evaluation In evaluationList
                sum = sum + (evaluation.Grade * evaluation.Weight)
            Next
            If evaluationList.Count > 0 Then
                Dim decision As String
                Dim creditObtained As Integer
                Dim average As Integer = sum / 100
                If average >= 10 Then
                    decision = "Validé"
                    creditObtained = ecue.Credit
                Else
                    decision = "Non Validé"
                    creditObtained = 0
                End If
                Dim ue As UE = UEsManager.getByECUEId_CareerId(ecue.Id, careerId)
                table.LoadDataRow(New Object() {ecue.Libelle, ue.Libelle, ecue.Credit, CStr(average), "-", creditObtained, decision}, True)
            End If
        Next

        Return table
    End Function
    Public Shared Function getByECUEId(ecueId As String) As DataTable
        Return getTmpLit(EvaluationsManager.getByECUEId(ecueId))
    End Function
    Public Shared Function search(ecueId As String, word As String) As DataTable
        If word <> Nothing Then
            Return getTmpLit(EvaluationsManager.search(word))
        Else
            Return getByECUEId(ecueId)
        End If
    End Function
    Public Shared Function getTeacherNameList()
        Dim teacherNameList As New List(Of String)()
        For Each employee As Employee In EmployeesManager.getAll()
            If employee.FunctionField = Employee.Teacher Then
                teacherNameList.Add(employee.Name)
            End If
        Next
        Return teacherNameList
    End Function
    Public Shared Function getEUNameList() As List(Of String)
        Dim ueNameList As New List(Of String)()
        For Each ue As UE In UEsManager.getAll()
            ueNameList.Add(ue.Name)
        Next
        Return ueNameList
    End Function

    Public Shared Function insert(ecueId As Integer, studentId As Integer, dateField As String, typeField As String, percentage As Integer, grade As Integer) As Boolean
        Dim ecuesStudentsId As Integer = EvaluationsManager.getECUEsStudentsId(ecueId, studentId)
        For Each evaluationDB As Evaluation In EvaluationsManager.getByECUEsStudentsId(ecuesStudentsId)
            If evaluationDB.Type <> Nothing And evaluationDB.DateField = dateField And evaluationDB.Type = typeField Then
                MessageBox.Show("Une note de cet étudiant dans cette matière existe déjà à cette date et heure existe déjà", "Note déjà existante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return EvaluationsManager.insert(New Evaluation(grade, ecuesStudentsId, dateField, percentage, typeField))
    End Function
    Public Shared Function update(ecueId As Integer, studentId As Integer, dateField As String, typeField As String, percentage As Integer, grade As Integer, evaluationId As Integer) As Boolean
        Dim evaluationDB As Evaluation = EvaluationsManager.getById(evaluationId)
        If evaluationDB.Type = Nothing Then
            MessageBox.Show("Cette note de cet étudiant dans cette matière n'existe pas", "Note inexistante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return EvaluationsManager.update(New Evaluation(grade, evaluationDB.EcuesStudentsId, dateField, percentage, typeField), evaluationId)
        End If
    End Function



    Public Shared Function delete(idList) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) Notes(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            For Each id As Integer In idList
                If EvaluationsManager.delete(id) Then
                    response = True
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class
