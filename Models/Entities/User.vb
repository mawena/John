Public Class User
    Private _id As Integer
    Private _username As String
    Private _function_field As String
    Private _password_field As String

    Public Sub New(id As Integer, username As String, function_field As String, password_field As String)
        Me.Id = id
        Me.Username = username
        Me.Function_field = function_field
        Me.Password_field = password_field
    End Sub

    Public Sub New(username As String, function_field As String, password_field As String)
        Me.Username = username
        Me.Function_field = function_field
        Me.Password_field = password_field
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

    Public Property Function_field As String
        Get
            Return _function_field
        End Get
        Set(value As String)
            _function_field = value
        End Set
    End Property

    Public Property Password_field As String
        Get
            Return _password_field
        End Get
        Set(value As String)
            _password_field = value
        End Set
    End Property

    Public Function Function_view_field() As String
        Return Function_field_to_function_view_field(_function_field)
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim user = TryCast(obj, User)
        Return user IsNot Nothing AndAlso
               _id = user._id AndAlso
               _username = user._username AndAlso
               _function_field = user._function_field AndAlso
               _password_field = user._password_field
    End Function

    Public Shared Function Function_field_to_function_view_field(function_field As String) As String
        If function_field = "TuititionService" Then
            Return "Service Scolarité"
        ElseIf function_field = "Teacher" Then
            Return "Enseignant"
        Else
            Return "Administrateur"
        End If
    End Function

    Public Shared Function Function_view_field_to_function_field(function_view_field As String) As String
        If function_view_field = "Service Scolarité" Then
            Return "TuititionService"
        ElseIf function_view_field = "Enseignant" Then
            Return "Teacher"
        Else
            Return "Administrateur"
        End If
    End Function
End Class
