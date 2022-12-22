Public Class UsersController
    Public Shared Function getAll() As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Utilisateur", GetType(String))
        table.Columns.Add("Fonction", GetType(String))

        For Each user As User In UsersManager.getAll()
            table.LoadDataRow(New Object() {user.Id, user.Username, user.Function_view_field()}, True)
        Next
        Return table
    End Function

    Public Shared Function searchUsers(word As String) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Utilisateur", GetType(String))
        table.Columns.Add("Fonction", GetType(String))
        If word <> Nothing Then
            For Each user As User In UsersManager.searchUsers(word)
                table.LoadDataRow(New Object() {user.Id, user.Username, user.Function_view_field()}, True)
            Next
        Else
            Return getAll()
        End If
        Return table
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
    Public Shared Function store(username As String, function_field As String, password_field As String) As Boolean
        If (verifyUser(username, password_field, True)) Then
            Dim userDB As User = UsersManager.getByUsername(username)
            If (userDB.Username = Nothing) Then
                Return UsersManager.store(New User(username, User.Function_view_field_to_function_field(function_field), password_field))
            Else
                MessageBox.Show("L'utilisateur " & username & " existe déjà", "Utilisateur déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return False
    End Function

    Public Shared Function update(username As String, function_field As String, password_field As String, userId As Integer, update_password_field As Boolean) As Boolean
        If (verifyUser(username, password_field, update_password_field)) Then
            Dim userDB As User = UsersManager.getById(userId)
            If (userDB.Username = Nothing) Then
                MessageBox.Show("L'utilisateur " & username & " n'existe pas", "Utilisateur déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Return UsersManager.update(New User(username, User.Function_view_field_to_function_field(function_field), password_field), userId, update_password_field)
            End If
        End If
        Return False
    End Function

    Public Shared Function delete(idList As List(Of Integer)) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) utilisateur(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            For Each id As Integer In idList
                If UsersManager.getById(id).Username = Nothing Then
                    MessageBox.Show("L'utilisateur " & id & " n'existe pas.", "Utilisateur inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit For
                Else
                    If UsersManager.delete(id) Then
                        response = True
                    End If
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class
