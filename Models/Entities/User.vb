Public Class User
    Private _id As Integer
    Private _username As String
    Private _passwordField As String
    Private _employeeId As Integer
    Private _employee As Employee

    Const Teacher = "Teacher"
    Const TuititionService = "TuititionService"

    Public Sub New(id As Integer, username As String, passwordField As String, employeeId As Integer)
        Me.Id = id
        Me.Username = username
        Me.PasswordField = passwordField
        Me.EmployeeId = employeeId
    End Sub

    Public Sub New(username As String, passwordField As String, employeeId As Integer)
        Me.Username = username
        Me.PasswordField = passwordField
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

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property PasswordField As String
        Get
            Return _passwordField
        End Get
        Set(value As String)
            _passwordField = value
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
                _employee = EmployeesManager.getById(value)
            End If
        End Set
    End Property

    Public ReadOnly Property Employee As Employee
        Get
            Return _employee
        End Get
    End Property

    Public ReadOnly Property FunctionViewField As String
        Get
            If (_employeeId = Nothing) Then
                Return "Administrateur"
            End If
            Return FunctionFieldToFunctionViewField(_employee.FunctionField)
        End Get
    End Property

    Public Shared Function FunctionFieldToFunctionViewField(function_field As String) As String
        If function_field = "TuititionService" Then
            Return "Service Scolarité"
        Else
            Return "Enseignant"
        End If
    End Function

    Public Shared Function FunctionViewFieldToFunctionField(function_view_field As String) As String
        If function_view_field = "Service Scolarité" Then
            Return "TuititionService"
        Else
            Return "Teacher"
        End If
    End Function
End Class
