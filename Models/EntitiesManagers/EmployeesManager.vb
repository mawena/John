Imports MySql.Data.MySqlClient
Public Class EmployeesManager
    Inherits Manager
    Public Shared Function getGeneriqueList() As List(Of Employee)
        Dim employeeList As New List(Of Employee)()
        Try

            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            dataTable = New DataTable
            dataAdapater.Fill(dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                employeeList.Add(New Employee(CInt(row("id")), row("last_name"), row("first_name"), row("phone_number"), row("email"), row("gender"), row("function_field")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "EmployeesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return employeeList
    End Function
    Public Shared Function getAll() As List(Of Employee)
        command = New MySqlCommand("SELECT * FROM Employees;", Manager.connection)
        Return getGeneriqueList()
    End Function
    Public Shared Function search(word As String)
        command = New MySqlCommand("SELECT * FROM Employees WHERE last_name LIKE @word OR first_name LIKE @word OR email LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getGeneriqueList()
    End Function


    Private Shared Function getGenerique() As Employee
        Dim employee As Employee = New Employee(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                employee = New Employee(CInt(row("id")), row("last_name"), row("first_name"), row("phone_number"), row("email"), row("gender"), row("function_field"))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "EmployeesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return employee
    End Function
    Public Shared Function getById(id As Integer) As Employee
        command = New MySqlCommand("SELECT * FROM Employees WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getGenerique()
    End Function
    Public Shared Function getByPhoneNumber(phoneNumber As String) As Employee
        command = New MySqlCommand("SELECT * FROM Employees WHERE phone_number = @phone_number;", Manager.connection)
        command.Parameters.AddWithValue("@phone_number", phoneNumber)
        Return getGenerique()
    End Function
    Public Shared Function getByEmail(email As String) As Employee
        command = New MySqlCommand("SELECT * FROM Employees WHERE email = @email;", Manager.connection)
        command.Parameters.AddWithValue("@email", email)
        Return getGenerique()
    End Function
    Public Shared Function getByLastNameAndFirtName(lastName As String, firstName As String) As Employee
        command = New MySqlCommand("SELECT * FROM Employees WHERE last_name = @last_name AND first_name = @first_name;", Manager.connection)
        command.Parameters.AddWithValue("@last_name", lastName)
        command.Parameters.AddWithValue("@first_name", firstName)
        Return getGenerique()
    End Function
    Public Shared Function getByName(name As String) As Employee
        command = New MySqlCommand("SELECT * FROM Employees WHERE CONCAT(id, '-', first_name, ' - ', last_name) = @name;", Manager.connection)
        command.Parameters.AddWithValue("@name", name)
        Return getGenerique()
    End Function


    Public Shared Function store(employee As Employee) As Boolean
        Try
            command = New MySqlCommand("INSERT INTO Employees(last_name, first_name, phone_number, email, gender, function_field) VALUES(@last_name, @first_name, @phone_number, @email, @gender, @function_field);", Manager.connection)
            command.Parameters.AddWithValue("@last_name", employee.LastName)
            command.Parameters.AddWithValue("@first_name", employee.FirstName)
            command.Parameters.AddWithValue("@phone_number", employee.PhoneNumber)
            command.Parameters.AddWithValue("@email", employee.Email)
            command.Parameters.AddWithValue("@gender", employee.Gender)
            command.Parameters.AddWithValue("@function_field", employee.FunctionField)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "EmployeesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
    Public Shared Function update(employee As Employee, id As Integer) As Boolean
        Try
            command = New MySqlCommand("UPDATE Employees SET last_name = @last_name, first_name = @first_name, phone_number = @phone_number, email = @email, gender = @gender, function_field = @function_field WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@last_name", employee.LastName)
            command.Parameters.AddWithValue("@first_name", employee.FirstName)
            command.Parameters.AddWithValue("@phone_number", employee.PhoneNumber)
            command.Parameters.AddWithValue("@email", employee.Email)
            command.Parameters.AddWithValue("@gender", employee.Gender)
            command.Parameters.AddWithValue("@function_field", employee.FunctionField)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "EmployeesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function


    Public Overloads Shared Function delete(id As Integer) As Boolean
        Return Manager.delete("Employees", id)
    End Function
End Class
