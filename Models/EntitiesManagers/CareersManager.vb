Imports MySql.Data.MySqlClient
Public Class CareersManager
    Inherits Manager
    Public Shared Function getGeneriqueList() As List(Of Career)
        Dim careerList As New List(Of Career)()
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            dataTable = New DataTable
            dataAdapater.Fill(dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                careerList.Add(New Career(CInt(row("id")), row("libelle"), row("sigle"), row("institute_id")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "CareersManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return careerList
    End Function
    Public Shared Function getAll() As List(Of Career)
        command = New MySqlCommand("SELECT * FROM Careers;", Manager.connection)
        Return getGeneriqueList()
    End Function
    Public Shared Function search(word As String) As List(Of Career)
        command = New MySqlCommand("SELECT * FROM Careers WHERE libelle LIKE @word OR sigle LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getGeneriqueList()
    End Function
    Public Shared Function getBySigle(sigle As String) As List(Of Career)
        command = New MySqlCommand("SELECT * FROM Careers WHERE sigle = @sigle;", Manager.connection)
        command.Parameters.AddWithValue("@sigle", sigle)
        Return getGeneriqueList()
    End Function
    Public Shared Function getByUEId(ueId As String) As List(Of Career)
        command = New MySqlCommand("SELECT Careers.id As id, Careers.libelle As libelle, Careers.sigle as sigle, Careers.institute_id As institute_id FROM Careers, CareersUEs WHERE CareersUEs.UE_id = @ueId AND  CareersUEs.Career_id = Careers.id;", Manager.connection)
        command.Parameters.AddWithValue("@ueId", ueId)
        Return getGeneriqueList()
    End Function
    Public Shared Function getByInstituteId(institute_id As Integer) As List(Of Career)
        command = New MySqlCommand("SELECT * FROM Careers WHERE institute_id = @institute_id;", Manager.connection)
        command.Parameters.AddWithValue("@institute_id", institute_id)
        Return getGeneriqueList()
    End Function


    Private Shared Function getGenerique() As Career
        Dim career As Career = New Career(Nothing, Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                career = New Career(CInt(row("id")), row("libelle"), row("sigle"), row("institute_id"))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "CareersManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return career
    End Function
    Public Shared Function getById(id As Integer) As Career
        command = New MySqlCommand("SELECT * FROM Careers WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getGenerique()
    End Function
    Public Shared Function getByName(name As String) As Career
        command = New MySqlCommand("SELECT * FROM Careers WHERE CONCAT(id, '-', sigle, ' - ', libelle) = @name;", Manager.connection)
        command.Parameters.AddWithValue("@name", name)
        Return getGenerique()
    End Function
    Public Shared Function getByLibelle(libelle As String) As Career
        command = New MySqlCommand("SELECT * FROM Careers WHERE libelle = @libelle;", Manager.connection)
        command.Parameters.AddWithValue("@libelle", libelle)
        Return getGenerique()
    End Function


    Public Shared Function store(career As Career) As Boolean
        Try
            command = New MySqlCommand("INSERT INTO Careers(libelle, sigle, institute_id) VALUES (@libelle, @sigle, @institute_id);", Manager.connection)
            command.Parameters.AddWithValue("@libelle", career.Libelle)
            command.Parameters.AddWithValue("@sigle", career.Sigle)
            command.Parameters.AddWithValue("@institute_id", career.InstituteId)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "CareersManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
    Public Shared Function update(career As Career, id As Integer) As Boolean
        Try
            command = New MySqlCommand("UPDATE Careers SET libelle = @libelle, sigle = @sigle, institute_id = @institute_id WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@libelle", career.Libelle)
            command.Parameters.AddWithValue("@sigle", career.Sigle)
            command.Parameters.AddWithValue("@institute_id", career.InstituteId)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "CareersManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function


    Public Overloads Shared Function delete(id As Integer) As Boolean
        Return Manager.delete("Careers", id)
    End Function
End Class
