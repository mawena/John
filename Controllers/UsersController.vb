Public Class UsersController
    Public Shared Function getGeneriqueList(usersList As List(Of User)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("id", GetType(Integer))
        table.Columns.Add("username", GetType(String))
        table.Columns.Add("functionField", GetType(String))
        table.Columns.Add("employee", GetType(String))

        For Each user As User In usersList
            table.LoadDataRow(New Object() {user.Id, user.Username, user.FunctionViewField, user.Employee.Name}, True)
        Next
        Return table
    End Function
    Public Shared Function getAll()
        Return getGeneriqueList(UsersManager.getAll())
    End Function
    Public Shared Function search(word As String) As DataTable
        If word <> Nothing Then
            Return getGeneriqueList(UsersManager.search(word))
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
                Dim employeeId As Integer = getEmployeeIdByName(employeeName)
                userDB = UsersManager.getByEmployeeId(employeeId)
                If userDB.Username = Nothing Then
                    Return UsersManager.store(New User(username, password_field, employeeId))
                Else
                    MessageBox.Show("L'employée " & employeeName & " a déjà un compte utilisateur, Voulez vous le mettre à jour?", "Utilisateur déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
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
