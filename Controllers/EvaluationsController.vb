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
    Public Shared Function getAll() As DataTable
        Return getGeneriqueList(EvaluationsManager.getAll())
    End Function
    Public Shared Function search(word As String) As DataTable
        If word <> Nothing Then
            Return getGeneriqueList(EvaluationsManager.search(word))
        Else
            Return getAll()
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



    Public Shared Function verify(libelle As String) As Boolean
        If libelle = "" Then
            MessageBox.Show("Le libelle ne doit pas être vide", "Libelle vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Return True
        End If
        Return False
    End Function
    'Public Shared Function store(libelle As String, credit As Integer, employeeName As String, ueNameList As List(Of String)) As Boolean
    '    If verify(libelle) Then
    '        Dim employee As Employee = EmployeesManager.getByName(employeeName)
    '        Dim evaluationDB As Evaluation = EvaluationsManager.getByLibelle(libelle)
    '        If evaluationDB.Libelle <> Nothing Then
    '            MessageBox.Show("La matière '" & libelle & "' existe déjà", "Matière déjà existante", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Return False
    '        End If

    '        Dim ueIdList As New List(Of Integer)()
    '        For Each ueName As String In ueNameList
    '            ueIdList.Add(CInt(ueName.Split("-")(0)))
    '        Next
    '        Return EvaluationsManager.store(New Evaluation(libelle, credit, employee.Id), ueIdList)
    '    Else
    '        Return False
    '    End If
    'End Function
    'Public Shared Function update(libelle As String, credit As Integer, employeeName As String, ueNameList As List(Of String), evaluationId As Integer) As Boolean
    '    If verify(libelle) Then
    '        Dim employee As Employee = EmployeesManager.getByName(employeeName)
    '        Dim evaluationDB As Evaluation = EvaluationsManager.getByLibelle(libelle)
    '        If evaluationDB.Libelle = Nothing Then
    '            MessageBox.Show("La matière '" & libelle & "' n'existe déjà", "Matière inexistante", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Return False
    '        End If

    '        Dim ueIdList As New List(Of Integer)()
    '        For Each ueName As String In ueNameList
    '            ueIdList.Add(CInt(ueName.Split("-")(0)))
    '        Next
    '        Return EvaluationsManager.update(New Evaluation(libelle, credit, employee.Id), ueIdList, evaluationId)
    '    Else
    '        Return False
    '    End If
    'End Function



    Public Shared Function delete(idList) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) Matières(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
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
