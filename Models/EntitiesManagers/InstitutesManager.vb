Imports MySql.Data.MySqlClient
Public Class InstitutesManager
    Inherits Manager
    Public Shared Function getGeneriqueList() As List(Of Institute)
        Dim insituteList As New List(Of Institute)()
        Try

            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            dataTable = New DataTable
            dataAdapater.Fill(dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                insituteList.Add(New Institute(CInt(row("id")), row("libelle"), row("sigle")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "InstitutesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return insituteList
    End Function
    Public Shared Function getAll() As List(Of Institute)
        command = New MySqlCommand("SELECT * FROM Institutes;", Manager.connection)
        Return getGeneriqueList()
    End Function
    Public Shared Function search(word As String)
        command = New MySqlCommand("SELECT * FROM Institutes WHERE libelle LIKE @word OR sigle LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getGeneriqueList()
    End Function
    Public Shared Function getBySigle(sigle As String) As List(Of Institute)
        command = New MySqlCommand("SELECT * FROM Institutes WHERE sigle = @sigle;", Manager.connection)
        command.Parameters.AddWithValue("@sigle", sigle)
        Return getGeneriqueList()
    End Function


    Private Shared Function getGenerique() As Institute
        Dim insitute As Institute = New Institute(Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                insitute = New Institute(CInt(row("id")), row("libelle"), row("sigle"))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "InstitutesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return insitute
    End Function
    Public Shared Function getById(id As Integer) As Institute
        command = New MySqlCommand("SELECT * FROM Institutes WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getGenerique()
    End Function
    Public Shared Function getByLibelle(libelle As String) As Institute
        command = New MySqlCommand("SELECT * FROM Institutes WHERE libelle = @libelle;", Manager.connection)
        command.Parameters.AddWithValue("@libelle", libelle)
        Return getGenerique()
    End Function
    Public Shared Function getByName(name As String) As Institute
        command = New MySqlCommand("SELECT * FROM Institutes WHERE CONCAT(id, '-', sigle, ' - ', libelle) = @name;", Manager.connection)
        command.Parameters.AddWithValue("@name", name)
        Return getGenerique()
    End Function


    Public Shared Function store(institute As Institute) As Boolean
        Try
            command = New MySqlCommand("INSERT INTO Institutes(libelle, sigle) VALUES(@libelle, @sigle);", Manager.connection)
            command.Parameters.AddWithValue("@libelle", institute.Libelle)
            command.Parameters.AddWithValue("@sigle", institute.Sigle)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "InstitutesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function


    Public Shared Function update(institute As Institute, id As Integer) As Boolean
        Try
            command = New MySqlCommand("UPDATE Institutes SET libelle = @libelle, sigle = @sigle WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@libelle", institute.Libelle)
            command.Parameters.AddWithValue("@sigle", institute.Sigle)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "InstitutesManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function


    Public Overloads Shared Function delete(id As Integer) As Boolean
        Return Manager.delete("Institutes", id)
    End Function
End Class
