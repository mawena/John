Public Class UE
    Private _id As Integer
    Private _libelle As String
    Private _semester As Integer
    Private _careerId As Integer
    Private _career As Career

    Public Sub New(id As Integer, libelle As String, semester As Integer, careerId As Integer)
        Me.Id = id
        Me.Libelle = libelle
        Me.Semester = semester
        Me.CareerId = careerId
    End Sub

    Public Sub New(libelle As String, semester As Integer, careerId As Integer)
        Me.Libelle = libelle
        Me.Semester = semester
        Me.CareerId = careerId
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

    Public Property Semester As Integer
        Get
            Return _semester
        End Get
        Set(value As Integer)
            _semester = value
        End Set
    End Property

    Public Property CareerId As Integer
        Get
            Return _careerId
        End Get
        Set(value As Integer)
            _careerId = value
            If _careerId = Nothing Then
                _career = New Career(Nothing, Nothing, Nothing, Nothing)
            Else
                _career = CareersManager.getById(_careerId)
            End If
        End Set
    End Property

    Public ReadOnly Property Career
        Get
            Return _career
        End Get
    End Property

    Public ReadOnly Property CareerName
        Get
            Return _careerId & "-" & _career.Sigle & " - " & _career.Libelle
        End Get
    End Property
End Class
