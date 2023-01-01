﻿Public Class Faculty
    Private _id As Integer
    Private _libelle As String
    Private _sigle As String
    Private _instituteId As Integer
    Private _institute As Institute

    Public Sub New(id As Integer, libelle As String, sigle As String, instituteId As Integer)
        Me.Id = id
        Me.Libelle = libelle
        Me.Sigle = sigle
        Me.InstituteId = instituteId
    End Sub

    Public Sub New(libelle As String, sigle As String, instituteId As Integer)
        Me.Libelle = libelle
        Me.Sigle = sigle
        Me.InstituteId = instituteId
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

    Public Property InstituteId As Integer
        Get
            Return _instituteId
        End Get
        Set(value As Integer)
            _institute = InstitutesManager.getById(_instituteId)
            _instituteId = value
        End Set
    End Property

    Public ReadOnly Property Institute As Institute
        Get
            Return _institute
        End Get
    End Property

    Public ReadOnly Property InstituteName As String
        Get
            Return Institute.Sigle & " - " & Institute.Libelle
        End Get
    End Property
End Class
