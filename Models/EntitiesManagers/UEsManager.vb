Public Class UEsManager
    Inherits Manager

    Private Shared Function getGeneriqueList() As List(Of UE)
        Dim uesList As List(Of UE) = New List(Of UE)()
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                uesList.Add(New UE(CInt(row("id")), row("libelle"), CInt(row("semester")), row("career_id")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "UEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return uesList
    End Function

    Private Shared Function getGenerique() As UE
        Dim ue As UE = New UE(Nothing, Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                ue = New UE(CInt(row("id")), row("libelle"), CInt(row("semester")), row("career_id"))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "UEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return ue
    End Function


    Public Shared Function getAll() As List(Of UE)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM UEs;", Manager.connection)
        Return getGeneriqueList()
    End Function

    Public Shared Function search(word As String) As List(Of UE)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM UEs WHERE libelle LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getGeneriqueList()
    End Function
    Public Shared Function getByLibelle(libelle As String) As List(Of UE)
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM UEs WHERE libelle = @libelle;", Manager.connection)
        command.Parameters.AddWithValue("@libelle", libelle)
        Return getGeneriqueList()
    End Function

    Public Shared Function getById(id As Integer) As UE
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM UEs WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getGenerique()
    End Function

    Public Shared Function getByCareerId(career_id As Integer) As UE
        command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM UEs WHERE career_id = @career_id;", Manager.connection)
        command.Parameters.AddWithValue("@career_id", career_id)
        Return getGenerique()
    End Function


    Public Shared Function store(ue As UE) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO UEs(libelle, semester, career_id) VALUES (@libelle, @semester, @career_id);", Manager.connection)
            command.Parameters.AddWithValue("@libelle", ue.Libelle)
            command.Parameters.AddWithValue("@semester", ue.Semester)
            command.Parameters.AddWithValue("@career_id", ue.CareerId)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "UEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Shared Function update(ue As UE, id As Integer) As Boolean
        Try
            command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE UEs SET libelle = @libelle, semester = @semester, career_id = @career_id WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@libelle", ue.Libelle)
            command.Parameters.AddWithValue("@semester", ue.Semester)
            command.Parameters.AddWithValue("@career_id", ue.CareerId)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "UEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Overloads Shared Function delete(id As Integer) As Boolean
        Return Manager.delete("UEs", id)
    End Function
End Class
