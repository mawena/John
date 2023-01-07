Public Class FacultiesManager
    Inherits Manager

    Public Shared Function getGeneriqueList() As List(Of Faculty)
        Dim facultyList As New List(Of Faculty)()
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            dataTable = New DataTable
            dataAdapater.Fill(dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                facultyList.Add(New Faculty(CInt(row("id")), row("libelle"), row("sigle"), row("institute_id")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "FacultiesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return facultyList
    End Function

    Private Shared Function getGenerique() As Faculty
        Dim faculty As Faculty = New Faculty(Nothing, Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                faculty = New Faculty(CInt(row("id")), row("libelle"), row("sigle"), row("institute_id"))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "FacultiesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return faculty
    End Function

    Public Shared Function getAll() As List(Of Faculty)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Faculties;", Manager.connection)
        Return getGeneriqueList()
    End Function

    Public Shared Function getBySigle(sigle As String) As List(Of Faculty)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Faculties WHERE sigle = @sigle;", Manager.connection)
        command.Parameters.AddWithValue("@sigle", sigle)
        Return getGeneriqueList()
    End Function

    Public Shared Function search(word As String) As List(Of Faculty)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Faculties WHERE libelle LIKE @word OR sigle LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getGeneriqueList()
    End Function

    Public Shared Function getById(id As Integer) As Faculty
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Faculties WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getGenerique()
    End Function

    Public Shared Function getByIdAndName(idAndName As String) As Faculty
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Faculties WHERE CONCAT(id, '-', sigle, ' - ', libelle) = @idAndName;", Manager.connection)
        command.Parameters.AddWithValue("@idAndName", idAndName)
        Return getGenerique()
    End Function

    Public Shared Function getByInstituteId(institute_id As Integer) As Faculty
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Faculties WHERE employee_id = @institute_id;", Manager.connection)
        command.Parameters.AddWithValue("@institute_id", institute_id)
        Return getGenerique()
    End Function

    Public Shared Function getByLibelle(libelle As String) As Faculty
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM Faculties WHERE libelle = @libelle;", Manager.connection)
        command.Parameters.AddWithValue("@libelle", libelle)
        Return getGenerique()
    End Function

    Public Shared Function store(faculty As Faculty) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO Faculties(libelle, sigle, institute_id) VALUES (@libelle, @sigle, @institute_id);", Manager.connection)
            command.Parameters.AddWithValue("@libelle", faculty.Libelle)
            command.Parameters.AddWithValue("@sigle", faculty.Sigle)
            command.Parameters.AddWithValue("@institute_id", faculty.InstituteId)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "FacultiesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Shared Function update(faculty As Faculty, id As Integer) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE Faculties SET libelle = @libelle, sigle = @sigle, institute_id = @institute_id WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@libelle", faculty.Libelle)
            command.Parameters.AddWithValue("@sigle", faculty.Sigle)
            command.Parameters.AddWithValue("@institute_id", faculty.InstituteId)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "FacultiesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Overloads Shared Function delete(id As Integer) As Boolean
        Return Manager.delete("Faculties", id)
    End Function
End Class
