Public Class UsersManager
    Inherits Manager
    Private Shared Function getEmployeeId(employee_id) As Integer
        If Convert.IsDBNull(employee_id) Then
            Return Nothing
        Else
            Return employee_id
        End If
    End Function
    Private Shared Function getUserGenerique() As User
        Dim user As User = New User(Nothing, Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                user = New User(CInt(row("id")), row("username"), row("password_field"), getEmployeeId(row("employee_id")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "UsersManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return user
    End Function

    Public Shared Function getById(id As Integer) As User
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Users WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getUserGenerique()
    End Function

    Public Shared Function getByEmployeeId(employee_id As Integer) As User
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Users WHERE employee_id = @employee_id;", Manager.connection)
        command.Parameters.AddWithValue("@employee_id", employee_id)
        Return getUserGenerique()
    End Function

    Public Shared Function getByUsername(username As String) As User
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Users WHERE username = @username;", Manager.connection)
        command.Parameters.AddWithValue("@username", username)
        Return getUserGenerique()
    End Function

    Public Shared Function getUsersGenerique() As List(Of User)
        Dim userList As New List(Of User)()
        Try

            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            dataTable = New DataTable
            dataAdapater.Fill(dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                userList.Add(New User(CInt(row("id")), row("username"), row("password_field"), getEmployeeId(row("employee_id"))))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "UsersManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return userList
    End Function

    Public Shared Function getAll() As List(Of User)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Users;", Manager.connection)
        Return getUsersGenerique()
    End Function

    Public Shared Function searchUsers(world As String)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Users WHERE username LIKE @world ;", Manager.connection)
        command.Parameters.AddWithValue("@world", "%" & world & "%")
        Return getUsersGenerique()
    End Function

    Public Shared Function GetEmployeeId(employeeId As Integer)
        If employeeId = -1 Then
            Return DBNull.Value
        Else
            Return employeeId
        End If
    End Function


    Public Shared Function store(user As User) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO Users(username, password_field, employee_id) VALUES (@username, @password_field, @employee_id);", Manager.connection)
            command.Parameters.AddWithValue("@username", user.Username)
            command.Parameters.AddWithValue("@password_field", user.PasswordField)
            command.Parameters.AddWithValue("@employee_id", GetEmployeeId(user.EmployeeId))
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "UsersManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Shared Function update(user As User, id As Integer, update_password_field As Boolean) As Boolean
        Try
            If (update_password_field) Then
                command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE Users SET username = @username, password_field = @password_field, employee_id = @employee_id WHERE id = @id;", Manager.connection)
                command.Parameters.AddWithValue("@username", user.Username)
                command.Parameters.AddWithValue("@password_field", user.PasswordField)
                command.Parameters.AddWithValue("@employee_id", GetEmployeeId(user.EmployeeId))
                command.Parameters.AddWithValue("@id", id)
            Else
                command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE Users SET username = @username, employee_id = @employee_id WHERE id = @id;", Manager.connection)
                command.Parameters.AddWithValue("@username", user.Username)
                command.Parameters.AddWithValue("@employee_id", GetEmployeeId(user.EmployeeId))
                command.Parameters.AddWithValue("@id", id)
            End If
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "UsersManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Shared Function delete(id As Integer) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM Users WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la supression : " & ex.Message, "UsersManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
End Class
