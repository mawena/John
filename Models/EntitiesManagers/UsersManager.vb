Imports MySql.Data.MySqlClient
Public Class UsersManager
    Inherits Manager
    Private Shared Function getEmployeeIdToGet(employee_id) As Integer
        If Convert.IsDBNull(employee_id) Then
            Return Nothing
        Else
            Return employee_id
        End If
    End Function

    Public Shared Function getGeneriqueList() As List(Of User)
        Dim userList As New List(Of User)()
        Try

            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            dataTable = New DataTable
            dataAdapater.Fill(dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                userList.Add(New User(CInt(row("id")), row("username"), row("password_field"), getEmployeeIdToGet(row("employee_id"))))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "UsersManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return userList
    End Function
    Public Shared Function getAll() As List(Of User)
        command = New MySqlCommand("SELECT * FROM Users;", Manager.connection)
        Return getGeneriqueList()
    End Function
    Public Shared Function search(word As String)
        command = New MySqlCommand("SELECT * FROM Users WHERE username LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getGeneriqueList()
    End Function


    Private Shared Function getGenerique() As User
        Dim user As User = New User(Nothing, Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                user = New User(CInt(row("id")), row("username"), row("password_field"), getEmployeeIdToGet(row("employee_id")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "UsersManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return user
    End Function
    Public Shared Function getById(id As Integer) As User
        command = New MySqlCommand("SELECT * FROM Users WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getGenerique()
    End Function
    Public Shared Function getByEmployeeId(employee_id As Integer) As User
        command = New MySqlCommand("SELECT * FROM Users WHERE employee_id = @employee_id;", Manager.connection)
        command.Parameters.AddWithValue("@employee_id", employee_id)
        Return getGenerique()
    End Function
    Public Shared Function getByUsername(username As String) As User
        command = New MySqlCommand("SELECT * FROM Users WHERE username = @username;", Manager.connection)
        command.Parameters.AddWithValue("@username", username)
        Return getGenerique()
    End Function


    Public Shared Function getEmployeeIdToSave(employeeId As Integer)
        If employeeId = -1 Then
            Return DBNull.Value
        Else
            Return employeeId
        End If
    End Function
    Public Shared Function store(user As User) As Boolean
        Try
            command = New MySqlCommand("INSERT INTO Users(username, password_field, employee_id) VALUES (@username, @password_field, @employee_id);", Manager.connection)
            command.Parameters.AddWithValue("@username", user.Username)
            command.Parameters.AddWithValue("@password_field", user.PasswordField)
            command.Parameters.AddWithValue("@employee_id", getEmployeeIdToSave(user.EmployeeId))
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
                command = New MySqlCommand("UPDATE Users SET username = @username, password_field = @password_field, employee_id = @employee_id WHERE id = @id;", Manager.connection)
                command.Parameters.AddWithValue("@username", user.Username)
                command.Parameters.AddWithValue("@password_field", user.PasswordField)
                command.Parameters.AddWithValue("@employee_id", getEmployeeIdToSave(user.EmployeeId))
                command.Parameters.AddWithValue("@id", id)
            Else
                command = New MySqlCommand("UPDATE Users SET username = @username, employee_id = @employee_id WHERE id = @id;", Manager.connection)
                command.Parameters.AddWithValue("@username", user.Username)
                command.Parameters.AddWithValue("@employee_id", getEmployeeIdToSave(user.EmployeeId))
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


    Public Overloads Shared Function delete(id As Integer) As Boolean
        Return Manager.delete("Users", id)
    End Function
End Class
