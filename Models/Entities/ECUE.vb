Public Class ECUE
    Private _id As Integer
    Private _libelle As String
    Private _credit As Integer
    Private _employeeId As Integer
    Private _employee As Employee

    Public Sub New(id As Integer, libelle As String, credit As Integer, employeeId As Integer)
        Me.Id = id
        Me.Libelle = libelle
        Me.Credit = credit
        Me.EmployeeId = employeeId
    End Sub

    Public Sub New(libelle As String, credit As Integer, employeeId As Integer)
        Me.Libelle = libelle
        Me.Credit = credit
        Me.EmployeeId = employeeId
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Libelle As String
        Get
            Return _libelle
        End Get
        Set(value As String)
            _libelle = value
        End Set
    End Property

    Public Property Credit As Integer
        Get
            Return _credit
        End Get
        Set(value As Integer)
            _credit = value
        End Set
    End Property

    Public Property EmployeeId As Integer
        Get
            Return _employeeId
        End Get
        Set(value As Integer)
            _employeeId = value
            If _employeeId = Nothing Then
                _employee = New Employee(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Else
                _employee = EmployeesManager.getById(_employeeId)
            End If
        End Set
    End Property
    Public ReadOnly Property Name
        Get
            Return _id & "-" & _libelle
        End Get
    End Property

    Public ReadOnly Property Employee
        Get
            Return _employee
        End Get
    End Property

    Public ReadOnly Property UEListName
        Get
            Dim UENameListTmp As New List(Of String)()
            For Each ue As UE In UEsManager.getByECUEId(_id)
                UENameListTmp.Add(ue.Name)
            Next
            If (UENameListTmp.Count = 0) Then
                Return "Aucune"
            End If
            Return String.Join(", ", UENameListTmp)
        End Get
    End Property
End Class
