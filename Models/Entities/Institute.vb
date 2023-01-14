Public Class Institute
    Private _id As Integer
    Private _libelle As String
    Private _sigle As String

    Public Sub New(id As Integer, libelle As String, sigle As String)
        Me.Id = id
        Me.Libelle = libelle
        Me.Sigle = sigle
    End Sub

    Public Sub New(libelle As String, sigle As String)
        Me.Libelle = libelle
        Me.Sigle = sigle
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

    Public Property Sigle As String
        Get
            Return _sigle
        End Get
        Set(value As String)
            _sigle = value
        End Set
    End Property

    Public ReadOnly Property Name As String
        Get
            Return Id & "-" & Sigle & " - " & Libelle
        End Get
    End Property
End Class
