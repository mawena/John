Public Class EvaluationsController
    Public Shared Function getGeneriqueList(evaluationsList As List(Of Evaluation)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("id", GetType(Integer))
        table.Columns.Add("studentName", GetType(String))
        table.Columns.Add("grade", GetType(Integer))
        table.Columns.Add("ecueName", GetType(String))
        table.Columns.Add("dateField", GetType(String))
        table.Columns.Add("typeField", GetType(String))
        table.Columns.Add("weightField", GetType(String))

        For Each evaluation As Evaluation In evaluationsList
            table.LoadDataRow(New Object() {evaluation.Id, evaluation.Student.Name, evaluation.Grade, evaluation.ECUE.Name, evaluation.DateField, evaluation.Type, evaluation.Weight}, True)
        Next
        Return table
    End Function
    Public Shared Function getByECUEId(ecueId As String) As DataTable
        Return getGeneriqueList(EvaluationsManager.getByECUEId(ecueId))
    End Function
    Public Shared Function search(ecueId As String, word As String) As DataTable
        If word <> Nothing Then
            Return getGeneriqueList(EvaluationsManager.search(word))
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

    Public Shared Function store(ecueId As Integer, studentId As Integer, dateField As String, typeField As String, percentage As Integer, grade As Integer) As Boolean
        Dim ecuesStudentsId As Integer = EvaluationsManager.getECUEsStudentsId(ecueId, studentId)
        Dim evaluationDB As Evaluation = EvaluationsManager.getByECUEsStudentsId(ecuesStudentsId)
        If evaluationDB.Type = Nothing Then
            Return EvaluationsManager.store(New Evaluation(grade, ecuesStudentsId, dateField, percentage, typeField))
        Else
            MessageBox.Show("La note de cet étudiant dans cette matière existe déjà", "Note déjà existante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function
    Public Shared Function update(ecueId As Integer, studentId As Integer, dateField As String, typeField As String, percentage As Integer, grade As Integer, evaluationId As Integer) As Boolean
        MsgBox(evaluationId)
        Dim evaluationDB As Evaluation = EvaluationsManager.getById(evaluationId)
        If evaluationDB.Type = Nothing Then
            MessageBox.Show("La note de cet étudiant dans cette matière n'existe déjà", "Note inexistante", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
