Imports MySql.Data.MySqlClient
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
    Public Shared Function getAll() As List(Of ECUE)
        command = New MySqlCommand("SELECT * FROM ECUEs;", Manager.connection)
        Return getGeneriqueList()
    End Function
    Public Shared Function search(word As String) As List(Of ECUE)
        command = New MySqlCommand("SELECT * FROM ECUEs WHERE libelle LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getGeneriqueList()
    End Function
    Public Shared Function getByEmployeeId(employeeId As Integer) As List(Of ECUE)
        command = New MySqlCommand("SELECT * FROM ECUEs WHERE employee_id = @employee_id;", Manager.connection)
        command.Parameters.AddWithValue("@employee_id", employeeId)
        Return getGeneriqueList()
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
    Public Shared Function getById(id As Integer) As ECUE
        command = New MySqlCommand("SELECT * FROM ECUEs WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getGenerique()
    End Function
    Public Shared Function getByLibelle(libelle As String) As ECUE
        command = New MySqlCommand("SELECT * FROM ECUEs WHERE libelle = @libelle;", Manager.connection)
        command.Parameters.AddWithValue("@libelle", libelle)
        Return getGenerique()
    End Function
    Public Shared Function getByName(name As String) As ECUE
        command = New MySqlCommand("SELECT * FROM ECUEs WHERE CONCAT(id, '-', libelle) = @name;", Manager.connection)
        command.Parameters.AddWithValue("@name", name)
        Return getGenerique()
    End Function
    Public Shared Function getByEvaluationId(evaluation As Integer) As ECUE
        command = New MySqlCommand("SELECT ECUES.id As id, ECUES.libelle As libelle, ECUES.credit As credit, ECUES.employee_id As employee_id FROM ECUEs, ECUEsStudents, Evaluations WHERE ECUEs.id = ECUEsStudents.ECUE_id AND ECUEsStudents.id = Evaluations.ECUEsStudents_id AND Evaluations.id = @evaluationId;", Manager.connection)
        command.Parameters.AddWithValue("@evaluationId", evaluation)
        Return getGenerique()
    End Function



    Public Shared Function store(ecue As ECUE, ueIdList As List(Of Integer)) As Boolean
        Try
            command = New MySqlCommand("INSERT INTO ECUEs(libelle, credit, employee_id) VALUES (@libelle, @credit, @employee_id);", Manager.connection)
            command.Parameters.AddWithValue("@libelle", ecue.Libelle)
            command.Parameters.AddWithValue("@credit", ecue.Credit)
            command.Parameters.AddWithValue("@employee_id", ecue.EmployeeId)
            command.ExecuteNonQuery()
            disposeManager()

            Dim ecueId As Integer = getLastId("ECUEs")
            deleteECUEUEs(ecueId)
            storeECUEsUEs(ecueId, ueIdList)
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "ECUEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Shared Function update(ecue As ECUE, ueIdList As List(Of Integer), id As Integer) As Boolean
        Try
            command = New MySqlCommand("UPDATE ECUEs SET libelle = @libelle, credit = @credit, employee_id = @employee_id WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@libelle", ecue.Libelle)
            command.Parameters.AddWithValue("@credit", ecue.Credit)
            command.Parameters.AddWithValue("@employee_id", ecue.EmployeeId)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()


            deleteECUEUEs(id)
            storeECUEsUEs(id, ueIdList)
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "ECUEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Shared Function storeECUEsUEs(ecueId As Integer, ueIdList As List(Of Integer)) As Boolean
        Try
            For Each ueId As Integer In ueIdList
                command = New MySqlCommand("INSERT INTO ECUEsUEs(ECUE_id, UE_id) VALUES(@ECUE_id, @UE_id);", Manager.connection)
                command.Parameters.AddWithValue("@ECUE_id", ecueId)
                command.Parameters.AddWithValue("@UE_id", ueId)
                command.ExecuteNonQuery()
                disposeManager()
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour ou l'insertion : " & ex.Message, "ECUEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Public Shared Function deleteECUEUEs(ecueId As Integer) As Boolean
        Try
            command = New MySqlCommand("DELETE FROM ECUEsUEs WHERE ECUE_id = @ecueId;", Manager.connection)
            command.Parameters.AddWithValue("@ecueId", ecueId)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la supression : " & ex.Message, "ECUESManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
    Public Overloads Shared Function delete(id As Integer) As Boolean
        deleteECUEUEs(id)
        Return Manager.delete("ECUEs", id)
    End Function
End Class
