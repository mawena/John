Public Class Student
    Public Enum genders
        F
        M
    End Enum

    Private _id As Integer
    Private _lastName As String
    Private _firstName As String
    Private _birthDate As Date
    Private _gender As genders
    Private _email As String
    Private _phoneNumber As String
    Private _picturePath As String
    Private _facultyId As Integer

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

    Public Property Gender As genders
        Get
            Return _gender
        End Get
        Set(value As genders)
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

    Public Sub New(id As Integer, lastName As String, firstName As String, birthDate As Date, gender As genders, email As String, phoneNumber As String, picturePath As String, facultyId As Integer)
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

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim student = TryCast(obj, Student)
        Return student IsNot Nothing AndAlso
               _id = student._id AndAlso
               _lastName = student._lastName AndAlso
               _firstName = student._firstName AndAlso
               _birthDate = student._birthDate AndAlso
               _gender = student._gender AndAlso
               _email = student._email AndAlso
               _phoneNumber = student._phoneNumber AndAlso
               _picturePath = student._picturePath AndAlso
               _facultyId = student._facultyId
    End Function

    Public Function GetPropertiesName() As String()
        Return {"id", "last_name", "first_name", "birth_date", "gender", "email", "phone_number", "picture_path", "faculty_id"}
    End Function

    Public Function GetProperties() As String()
        Return {Id.ToString(), LastName.ToString(), FirstName.ToString(), BirthDate.ToShortDateString, Gender.ToString(), Email.ToString(), PhoneNumber.ToString(), PicturePath.ToString(), FacultyId.ToString()}
    End Function
    Public Overrides Function ToString() As String
        Dim str As String = "Student:"
        Dim comp As Integer = 0
        Dim propertiesName = GetPropertiesName()
        For Each prop As String In GetProperties()
            str += propertiesName(comp) + "= " + prop + ", "
            comp += 1
        Next

        Return str
    End Function
End Class
