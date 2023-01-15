Public Class Student

    Private _id As Integer
    Private _lastName As String
    Private _firstName As String
    Private _birthDate As String
    Private _gender As String
    Private _email As String
    Private _phoneNumber As String
    Private _picturePath As String
    Private _careerId As Integer

    Public Sub New(id As Integer, lastName As String, firstName As String, birthDate As String, gender As String, email As String, phoneNumber As String, picturePath As String, careerId As Integer)
        Me.Id = id
        Me.LastName = lastName
        Me.FirstName = firstName
        Me.BirthDate = birthDate
        Me.Gender = gender
        Me.Email = email
        Me.PhoneNumber = phoneNumber
        Me.PicturePath = picturePath
        Me.CareerId = careerId
    End Sub

    Public Sub New(lastName As String, firstName As String, birthDate As String, gender As String, email As String, phoneNumber As String, picturePath As String, careerId As Integer)
        Me.LastName = lastName
        Me.FirstName = firstName
        Me.BirthDate = birthDate
        Me.Gender = gender
        Me.Email = email
        Me.PhoneNumber = phoneNumber
        Me.PicturePath = picturePath
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

    Public Property BirthDate As String
        Get
            Return _birthDate
        End Get
        Set(value As String)
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

    Public Property CareerId As Integer
        Get
            Return _careerId
        End Get
        Set(value As Integer)
            _careerId = value
        End Set
    End Property

    Public ReadOnly Property Career
        Get
            Return CareersManager.getById(_careerId)
        End Get
    End Property

    Public ReadOnly Property Name
        Get
            Return _id & "-" & _lastName & " - " & _firstName
        End Get
    End Property
End Class
