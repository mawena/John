Public Class ECUEsController
    Public Shared Function getGeneriqueList(ecuesList As List(Of ECUE)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("id", GetType(Integer))
        table.Columns.Add("libelle", GetType(String))
        table.Columns.Add("credit", GetType(Integer))
        table.Columns.Add("teacher", GetType(String))
        table.Columns.Add("ues", GetType(String))

        For Each ecue As ECUE In ecuesList
            table.LoadDataRow(New Object() {ecue.Id, ecue.Libelle, ecue.Credit, ecue.Employee.Name, ecue.UEListName}, True)
        Next
        Return table
    End Function
    Public Shared Function getAll() As DataTable
        Return getGeneriqueList(ECUEsManager.getAll())
    End Function
    Public Shared Function search(word As String) As DataTable
        If word <> Nothing Then
            Return getGeneriqueList(ECUEsManager.search(word))
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
    Public Shared Function store(libelle As String, credit As Integer, employeeName As String, ueNameList As List(Of String)) As Boolean
        If verify(libelle) Then
            Dim employee As Employee = EmployeesManager.getByName(employeeName)
            Dim ecueDB As ECUE = ECUEsManager.getByLibelle(libelle)
            If ecueDB.Libelle <> Nothing Then
                MessageBox.Show("La matière '" & libelle & "' existe déjà", "Matière déjà existante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim ueIdList As New List(Of Integer)()
            For Each ueName As String In ueNameList
                ueIdList.Add(CInt(ueName.Split("-")(0)))
            Next
            Return ECUEsManager.store(New ECUE(libelle, credit, employee.Id), ueIdList)
        Else
            Return False
        End If
    End Function
    Public Shared Function update(libelle As String, credit As Integer, employeeName As String, ueNameList As List(Of String), ecueId As Integer) As Boolean
        If verify(libelle) Then
            Dim employee As Employee = EmployeesManager.getByName(employeeName)
            Dim ecueDB As ECUE = ECUEsManager.getByLibelle(libelle)
            If ecueDB.Libelle = Nothing Then
                MessageBox.Show("La matière '" & libelle & "' n'existe déjà", "Matière inexistante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim ueIdList As New List(Of Integer)()
            For Each ueName As String In ueNameList
                ueIdList.Add(CInt(ueName.Split("-")(0)))
            Next
            Return ECUEsManager.update(New ECUE(libelle, credit, employee.Id), ueIdList, ecueId)
        Else
            Return False
        End If
    End Function



    Public Shared Function delete(idList) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) Matières(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            For Each id As Integer In idList
                If ECUEsManager.delete(id) Then
                    response = True
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class