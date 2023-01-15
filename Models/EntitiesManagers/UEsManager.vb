Imports MySql.Data.MySqlClient
Public Class UEsManager
    Inherits Manager

    Private Shared Function getGeneriqueList() As List(Of UE)
        Dim uesList As List(Of UE) = New List(Of UE)()
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                uesList.Add(New UE(CInt(row("id")), row("libelle"), CInt(row("semester"))))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "UEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return uesList
    End Function
    Public Shared Function getAll() As List(Of UE)
        command = New MySqlCommand("SELECT * FROM UEs ORDER BY id;", Manager.connection)
        Return getGeneriqueList()
    End Function
    Public Shared Function search(word As String) As List(Of UE)
        command = New MySqlCommand("SELECT * FROM UEs WHERE libelle LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getGeneriqueList()
    End Function
    Public Shared Function getByCareerId(careerid As Integer) As List(Of UE)
        command = New MySqlCommand("SELECT * FROM UEs WHERE career_id = @careerId;", Manager.connection)
        command.Parameters.AddWithValue("@careerId", careerid)
        Return getGeneriqueList()
    End Function
    Public Shared Function getByECUEId(ecueId As String) As List(Of UE)
        command = New MySqlCommand("SELECT UEs.id AS id, UEs.libelle AS libelle, UEs.semester AS semester FROM UEs, ECUEsUEs WHERE ECUEsUEs.ECUE_id = @ueId AND UEs.id = ECUEsUEs.UE_id;", Manager.connection)
        command.Parameters.AddWithValue("@ueId", ecueId)
        Return getGeneriqueList()
    End Function



    Private Shared Function getGenerique() As UE
        Dim ue As UE = New UE(Nothing, Nothing, New List(Of Career))
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                ue = New UE(CInt(row("id")), row("libelle"), CInt(row("semester")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "UEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return ue
    End Function
    Public Shared Function getById(id As Integer) As UE
        command = New MySqlCommand("SELECT * FROM UEs WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getGenerique()
    End Function
    Public Shared Function getByName(name As String) As UE
        command = New MySqlCommand("SELECT * FROM UEs WHERE CONCAT(id, '-', libelle) = @name;", Manager.connection)
        command.Parameters.AddWithValue("@name", name)
        Return getGenerique()
    End Function
    Public Shared Function getByLibelle(libelle As String) As UE
        command = New MySqlCommand("SELECT * FROM UEs WHERE libelle = @libelle;", Manager.connection)
        command.Parameters.AddWithValue("@libelle", libelle)
        Return getGenerique()
    End Function


    Public Shared Function store(ue As UE) As Boolean
        Try
            command = New MySqlCommand("INSERT INTO UEs(libelle, semester) VALUES (@libelle, @semester);", Manager.connection)
            command.Parameters.AddWithValue("@libelle", ue.Libelle)
            command.Parameters.AddWithValue("@semester", ue.Semester)
            command.ExecuteNonQuery()
            disposeManager()

            ue.Id = getLastId("UEs")
            deleteCareersUEs(ue.Id)
            storeCareersUEs(ue.Id, ue.CareerList)

            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "UEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
    Public Shared Function update(ue As UE, id As Integer) As Boolean
        Try
            command = New MySqlCommand("UPDATE UEs SET libelle = @libelle, semester = @semester WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@libelle", ue.Libelle)
            command.Parameters.AddWithValue("@semester", ue.Semester)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()

            deleteCareersUEs(id)
            storeCareersUEs(id, ue.CareerList)

            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "UEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
    Public Shared Function storeCareersUEs(ueId As Integer, careerList As List(Of Career)) As Boolean
        Try
            For Each career As Career In careerList
                command = New MySqlCommand("INSERT INTO CareersUEs(Career_id, UE_id) VALUES(@careerId, @ueId);", Manager.connection)
                command.Parameters.AddWithValue("@careerId", career.Id)
                command.Parameters.AddWithValue("@ueId", ueId)
                command.ExecuteNonQuery()
                disposeManager()
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour ou l'insertion : " & ex.Message, "UEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Public Shared Function deleteCareersUEs(ueId As Integer) As Boolean
        Try
            command = New MySqlCommand("DELETE FROM CareersUEs WHERE UE_id = @ueId;", Manager.connection)
            command.Parameters.AddWithValue("@ueId", ueId)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la supression des liaisons : " & ex.Message, "ECUESManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
    Public Overloads Shared Function delete(id As Integer) As Boolean
        If (deleteCareersUEs(id)) Then
            Return Manager.delete("UEs", id)
        End If
        Return False
    End Function
End Class
