Public Class Evaluation
    Private _id As Integer
    Private _grade As Integer
    Private _ecuesStudentsId As Integer
    Private _ecue As ECUE
    Private _student As Student
    Private _dateField As String
    Private _weight As Integer
    Private _type As String

    Public Sub New(id As Integer, grade As Integer, ecuesStudentsId As Integer, dateField As String, weight As Integer, type As String)
        Me.Id = id
        Me.Grade = grade
        Me.EcuesStudentsId = ecuesStudentsId
        Me.DateField = dateField
        Me.Weight = weight
        Me.Type = type
    End Sub
    Public Sub New(grade As Integer, ecuesStudentsId As Integer, dateField As String, weight As Integer, type As String)
        Me.Grade = grade
        Me.EcuesStudentsId = ecuesStudentsId
        Me.DateField = dateField
        Me.Weight = weight
        Me.Type = type
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
            If _id <> Nothing Then
                _ecue = ECUEsManager.getByEvaluationId(_id)
                _student = StudentsManager.getByEvaluationId(_id)
            End If
        End Set
    End Property

    Public Property Grade As Integer
        Get
            Return _grade
        End Get
        Set(value As Integer)
            _grade = value
        End Set
    End Property

    Public Property EcuesStudentsId As Integer
        Get
            Return _ecuesStudentsId
        End Get
        Set(value As Integer)
            _ecuesStudentsId = value
        End Set
    End Property

    Public Property DateField As String
        Get
            Return _dateField
        End Get
        Set(value As String)
            _dateField = value
        End Set
    End Property

    Public Property Weight As Integer
        Get
            Return _weight
        End Get
        Set(value As Integer)
            _weight = value
        End Set
    End Property

    Public Property Type As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property

    Public ReadOnly Property ECUE As ECUE
        Get
            Return _ecue
        End Get
    End Property

    Public ReadOnly Property Student As Student
        Get
            Return _student
        End Get
    End Property
End Class
