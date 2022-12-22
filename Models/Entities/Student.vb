Public Class Studen

    Private _id As Integer
    Private _lastName As String
    Private _firstName As String
    Private _birthDate As Date
    Private _gender As String
    Private _email As String
    Private _phoneNumber As String
    Private _picturePath As String
    Private _facultyId As Integer

    Public Sub New(id As Integer, lastName As String, firstName As String, birthDate As Date, gender As String, email As String, phoneNumber As String, picturePath As String, facultyId As Integer)
        Me.Id = id
        Me.LastName = lastName
        Me.FirstName = firstName
        Me.BirthDate = birthDate
        Me.Gender = gender
        Me.Email = email
        Me.PhoneNumber = phoneNumber
        Me.PicturePath = picturePath
        Me.FacultyId = facultyId
    End Sub

    Public Sub New(lastName As String, firstName As String, birthDate As Date, gender As String, email As String, phoneNumber As String, picturePath As String, facultyId As Integer)
        Me.LastName = lastName
        Me.FirstName = firstName
        Me.BirthDate = birthDate
        Me.Gender = gender
        Me.Email = email
        Me.PhoneNumber = phoneNumber
        Me.PicturePath = picturePath
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

    Public Property BirthDate As Date
        Get
            Return _birthDate
        End Get
        Set(value As Date)
            _birthDate = value
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

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
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

    Public Property PicturePath As String
        Get
            Return _picturePath
        End Get
        Set(value As String)
            _picturePath = value
        End Set
    End Property

    Public Property FacultyId As Integer
        Get
            Return _facultyId
        End Get
        Set(value As Integer)
            _facultyId = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim studen = TryCast(obj, Studen)
        Return studen IsNot Nothing AndAlso
               _id = studen._id AndAlso
               _lastName = studen._lastName AndAlso
               _firstName = studen._firstName AndAlso
               _birthDate = studen._birthDate AndAlso
               _gender = studen._gender AndAlso
               _email = studen._email AndAlso
               _phoneNumber = studen._phoneNumber AndAlso
               _picturePath = studen._picturePath AndAlso
               _facultyId = studen._facultyId
    End Function
End Class
