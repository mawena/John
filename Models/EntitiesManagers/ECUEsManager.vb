Public Class ECUEsManager
    Inherits Manager
    Public Shared Function getGeneriqueList() As List(Of ECUE)
        Dim ecueList As New List(Of ECUE)()
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            dataTable = New DataTable
            dataAdapater.Fill(dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                ecueList.Add(New ECUE(CInt(row("id")), row("libelle"), CInt(row("credit")), CInt(row("employee_id"))))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "ECUEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ecueList
    End Function
    Private Shared Function getGenerique() As ECUE
        Dim ecue As ECUE = New ECUE(Nothing, Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                ecue = New ECUE(CInt(row("id")), row("libelle"), CInt(row("credit")), CInt(row("employee_id")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "ECUEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ecue
    End Function
    Public Shared Function getAll() As List(Of ECUE)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs;", Manager.connection)
        Return getGeneriqueList()
    End Function
    Public Shared Function search(word As String) As List(Of ECUE)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs WHERE libelle LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getGeneriqueList()
    End Function
    Public Shared Function getById(id As Integer) As ECUE
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getGenerique()
    End Function
    Public Shared Function getByEmployeeId(employeeId As Integer) As ECUE
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs WHERE employee_id = @employee_id;", Manager.connection)
        command.Parameters.AddWithValue("@employee_id", employeeId)
        Return getGenerique()
    End Function
    Public Shared Function getByName(name As String) As ECUE
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs WHERE CONCAT(id, '-', libelle) = @name;", Manager.connection)
        command.Parameters.AddWithValue("@name", name)
        Return getGenerique()
    End Function
    Public Shared Function getByLibelle(libelle As String) As ECUE
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM ECUEs WHERE libelle = @libelle;", Manager.connection)
        command.Parameters.AddWithValue("@libelle", libelle)
        Return getGenerique()
    End Function
    Public Shared Function store(ecue As ECUE) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO ECUEs(libelle, credit, employee_id) VALUES (@libelle, @credit, @employee_id);", Manager.connection)
            command.Parameters.AddWithValue("@libelle", ecue.Libelle)
            command.Parameters.AddWithValue("@credit", ecue.Credit)
            command.Parameters.AddWithValue("@employee_id", ecue.EmployeeId)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "ECUEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
    Public Shared Function update(ecue As ECUE, id As Integer) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE ECUEs SET libelle = @libelle, credit = @credit, employee_id = @employee_id WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@libelle", ecue.Libelle)
            command.Parameters.AddWithValue("@credit", ecue.Credit)
            command.Parameters.AddWithValue("@employee_id", ecue.EmployeeId)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "ECUEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
    Public Overloads Shared Function delete(id As Integer) As Boolean
        Return Manager.delete("ECUEs", id)
    End Function
End Class
