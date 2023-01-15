Public Class UE
    Private _id As Integer
    Private _libelle As String
    Private _semester As Integer
    Private _careerList As List(Of Career)

    Public Sub New(id As Integer, libelle As String, semester As Integer)
        Me.Id = id
        Me.Libelle = libelle
        Me.Semester = semester
        CareerList = CareersManager.getByUEId(id)
    End Sub

    Public Sub New(libelle As String, semester As Integer, listOfCareer As List(Of Career))
        Me.Libelle = libelle
        Me.Semester = semester
        CareerList = listOfCareer
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
    Public Property CareerList As List(Of Career)
        Get
            Return _careerList
        End Get
        Set(value As List(Of Career))
            _careerList = value
        End Set
    End Property
    Public ReadOnly Property Name
        Get
            Return _id & "-" & _libelle & "[" & CareerListName & "]"
        End Get
    End Property

    Public ReadOnly Property CareerListName
        Get
            Dim careerNameList As New List(Of String)()
            For Each career As Career In _careerList
                careerNameList.Add(career.Sigle)
            Next
            Return String.Join(", ", careerNameList)
        End Get
    End Property
End Class
