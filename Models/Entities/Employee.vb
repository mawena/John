Public Class Employee
    Private _id As Integer
    Private _lastName As String
    Private _firstName As String
    Private _phoneNumber As String
    Private _email As String
    Private _gender As String
    Private _functionField As String

    Public Const Teacher As String = "Teacher"
    Public Const TuititionService As String = "TuititionService"
    Public Sub New(id As Integer, lastName As String, firstName As String, phoneNumber As String, email As String, gender As String, functionField As String)
        Me.Id = id
        Me.LastName = lastName
        Me.FirstName = firstName
        Me.PhoneNumber = phoneNumber
        Me.Email = email
        Me.Gender = gender
        Me.FunctionField = functionField
    End Sub

    Public Sub New(lastName As String, firstName As String, phoneNumber As String, email As String, gender As String, functionField As String)
        Me.LastName = lastName
        Me.FirstName = firstName
        Me.PhoneNumber = phoneNumber
        Me.Email = email
        Me.Gender = gender
        Me.FunctionField = functionField
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property PhoneNumber As String
        Get
            Return _phoneNumber
        End Get
        Set(value As String)
            _phoneNumber = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property

    Public Property FunctionField As String
        Get
            Return _functionField
        End Get
        Set(value As String)
            _functionField = value
        End Set
    End Property

    Public ReadOnly Property FunctionFieldView As String
        Get
            Return Function_field_to_function_view_field(_functionField)
        End Get
    End Property

    Public ReadOnly Property GenderView As String
        Get
            Return Gender_to_gender_view(_gender)
        End Get
    End Property

    Public ReadOnly Property Name() As String
        Get
            If LastName = Nothing Then
                Return "Non Employé"
            Else
                Return Id & "-" & FirstName & " - " & LastName
            End If
        End Get
    End Property

    Public Shared Function Function_field_to_function_view_field(function_field As String) As String
        If function_field = TuititionService Then
            Return "Service Scolarité"
        Else
            Return "Enseignant"
        End If
    End Function

    Public Shared Function Function_view_field_to_function_field(function_view_field As String) As String
        If function_view_field = "Service Scolarité" Then
            Return TuititionService
        Else
            Return Teacher
        End If
    End Function

    Public Shared Function Gender_to_gender_view(gender As String) As String
        If gender = "Female" Then
            Return "Femme"
        Else
            Return "Homme"
        End If
    End Function

    Public Shared Function Gender_view_to_gender(gender_view As String) As String
        If gender_view = "Femme" Then
            Return "Female"
        Else
            Return "Male"
        End If
    End Function
End Class
