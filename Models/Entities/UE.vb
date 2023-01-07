Public Class UE
    Private _id As Integer
    Private _libelle As String
    Private _semester As Integer
    Private _facultyId As Integer
    Private _faculty As Faculty

    Public Sub New(id As Integer, libelle As String, semester As Integer, facultyId As Integer)
        Me.Id = id
        Me.Libelle = libelle
        Me.Semester = semester
        Me.FacultyId = facultyId
    End Sub

    Public Sub New(libelle As String, semester As Integer, facultyId As Integer)
        Me.Libelle = libelle
        Me.Semester = semester
        Me.FacultyId = facultyId
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

    Public Property FacultyId As Integer
        Get
            Return _facultyId
        End Get
        Set(value As Integer)
            _facultyId = value
            If _facultyId = Nothing Then
                _faculty = New Faculty(Nothing, Nothing, Nothing, Nothing)
            Else
                _faculty = FacultiesManager.getById(_facultyId)
            End If
        End Set
    End Property

    Public ReadOnly Property Faculty
        Get
            Return _faculty
        End Get
    End Property

    Public ReadOnly Property FacultyName
        Get
            Return _facultyId & "-" & _faculty.Sigle & " - " & _faculty.Libelle
        End Get
    End Property
End Class
