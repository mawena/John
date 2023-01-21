Imports System.Security.Cryptography

Public Class StudentGrade
    Private _id As Integer
    Private _ecueName As String
    Private _ueName As String
    Private _credit As Integer
    Private _gradeSessionOne As Integer
    Private _gradeSessionTwo As String
    Private _creditObtained As Integer
    Private _decision As String

    Public Sub New(ecueName As String, ueName As String, credit As Integer, gradeSessionOne As Integer, gradeSessionTwo As String, creditObtained As Integer, decision As String)
        Me.EcueName = ecueName
        Me.UeName = ueName
        Me.Credit = credit
        Me.GradeSessionOne = gradeSessionOne
        Me.GradeSessionTwo = gradeSessionTwo
        Me.CreditObtained = creditObtained
        Me.Decision = decision
    End Sub
    Public Property EcueName As String
        Get
            Return _ecueName
        End Get
        Set(value As String)
            _ecueName = value
        End Set
    End Property

    Public Property UeName As String
        Get
            Return _ueName
        End Get
        Set(value As String)
            _ueName = value
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

    Public Property GradeSessionOne As Integer
        Get
            Return _gradeSessionOne
        End Get
        Set(value As Integer)
            _gradeSessionOne = value
        End Set
    End Property

    Public Property GradeSessionTwo As String
        Get
            Return _gradeSessionTwo
        End Get
        Set(value As String)
            _gradeSessionTwo = value
        End Set
    End Property

    Public Property CreditObtained As Integer
        Get
            Return _creditObtained
        End Get
        Set(value As Integer)
            _creditObtained = value
        End Set
    End Property

    Public Property Decision As String
        Get
            Return _decision
        End Get
        Set(value As String)
            _decision = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
End Class
