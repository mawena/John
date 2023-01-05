﻿Public Class UsersController
    Public Shared Function getUsersGenerique(usersList As List(Of User)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Utilisateur", GetType(String))
        table.Columns.Add("Fonction", GetType(String))
        table.Columns.Add("Employé", GetType(String))

        For Each user As User In UsersManager.getAll()
            table.LoadDataRow(New Object() {user.Id, user.Username, user.FunctionViewField, user.EmployeeName}, True)
        Next
        Return table
    End Function

    Public Shared Function getAll()
        Return getUsersGenerique(UsersManager.getAll())
    End Function

    Public Shared Function searchUsers(word As String) As DataTable
        If word <> Nothing Then
            Return getUsersGenerique(UsersManager.searchUsers(word))
        Else
            Return getAll()
        End If
    End Function

    Public Shared Function verifyUser(username As String, password_field As String, update_password_field As Boolean)
        If (username = "") Then
            MessageBox.Show("Le nom d'utilisateur ne doit pas être vide", "Utilisateur vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf update_password_field And (password_field = "") Then
            MessageBox.Show("Le mot de passe ne doit pas être vide", "Mot de passe vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Return True
        End If
        Return False
    End Function

    Public Shared Function getEmployeeIdByName(name As String) As Integer
        If (name = "Administrateur") Then
            Return -1
        Else
            Return EmployeesManager.getByName(name).Id
        End If
    End Function
    Public Shared Function store(username As String, password_field As String, employeeName As String) As Boolean
        If (verifyUser(username, password_field, True)) Then
            Dim userDB As User = UsersManager.getByUsername(username)
            If (userDB.Username = Nothing) Then
                Dim userToSave As User = New User(username, password_field, getEmployeeIdByName(employeeName))
                Return UsersManager.store(userToSave)
            Else
                MessageBox.Show("L'utilisateur " & username & " existe déjà", "Utilisateur déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return False
    End Function

    Public Shared Function update(username As String, password_field As String, employeeName As String, userId As Integer, update_password_field As Boolean) As Boolean
        If (verifyUser(username, password_field, update_password_field)) Then
            Dim userDB As User = UsersManager.getByUsername(username)
            If userDB.Username <> Nothing Then
                If userDB.Id <> userId Then
                    MessageBox.Show("L'utilisateur " & username & " est déjà utilisé", "Utilisateur déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        Else
            Return False
        End If
        Return UsersManager.update(New User(username, password_field, getEmployeeIdByName(employeeName)), userId, update_password_field)
    End Function

    Public Shared Function delete(idList As List(Of Integer)) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) utilisateur(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            For Each id As Integer In idList
                If UsersManager.delete(id) Then
                    response = True
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class
