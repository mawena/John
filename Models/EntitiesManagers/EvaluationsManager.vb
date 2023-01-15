Imports MySql.Data.MySqlClient

Public Class EvaluationsManager
    Inherits Manager
    Public Shared Function getGeneriqueList() As List(Of Evaluation)
        Dim evaluationList As New List(Of Evaluation)()
        Try

            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            dataTable = New DataTable
            dataAdapater.Fill(dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                evaluationList.Add(New Evaluation(CInt(row("id")), row("grade"), row("ECUEsStudents_id"), row("date_field"), row("weight_field"), row("type_field")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "EvaluationsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return evaluationList
    End Function
    Public Shared Function getAll() As List(Of Evaluation)
        command = New MySqlCommand("SELECT * FROM Evaluations;", Manager.connection)
        Return getGeneriqueList()
    End Function
    Public Shared Function search(word As String)
        command = New MySqlCommand("SELECT * FROM Evaluations WHERE last_name LIKE @word OR first_name LIKE @word OR email LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getGeneriqueList()
    End Function
    Public Shared Function getByStudentId(studentId As Integer) As List(Of Evaluation)
        command = New MySqlCommand("SELECT * FROM Evaluations WHERE student_id = studentId;", Manager.connection)
        command.Parameters.AddWithValue("studentId", studentId)
        Return getGeneriqueList()
    End Function
    Public Shared Function getECUEId(ecueId As Integer) As List(Of Evaluation)
        command = New MySqlCommand("SELECT * FROM Evaluations WHERE ECUE_id = ecueId;", Manager.connection)
        command.Parameters.AddWithValue("ecueId", ecueId)
        Return getGeneriqueList()
    End Function

    Private Shared Function getGenerique() As Evaluation
        Dim evaluation As Evaluation = New Evaluation(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                evaluation = New Evaluation(CInt(row("id")), row("grade"), row("ECUEsStudents_id"), row("date_field"), row("weight_field"), row("type_field"))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "EvaluationsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return evaluation
    End Function
    Public Shared Function getById(id As Integer) As Evaluation
        command = New MySqlCommand("SELECT * FROM Evaluations WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getGenerique()
    End Function



    Public Shared Function store(evaluation As Evaluation) As Boolean
        Try
            command = New MySqlCommand("INSERT INTO Evaluations(grade, ECUEsStudents_id, date_field, weight_field, type_field) VALUES(@grade, @ecuesStudentsId, @dateField, @weightField, @typeField);", Manager.connection)
            command.Parameters.AddWithValue("@grade", evaluation.Grade)
            command.Parameters.AddWithValue("@ecuesStudentsId", evaluation.EcuesStudentsId)
            command.Parameters.AddWithValue("@dateField", evaluation.DateField)
            command.Parameters.AddWithValue("@weightField", evaluation.Weight)
            command.Parameters.AddWithValue("@typeField", evaluation.Type)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "EvaluationsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
    Public Shared Function update(evaluation As Evaluation, id As Integer) As Boolean
        Try
            command = New MySqlCommand("UPDATE Evaluations SET grade = @grade, ECUEsStudents_id = @ecuesStudentsId, date_field = @dateField, weight_field = @weightField, type_field = @typeField WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@grade", evaluation.Grade)
            command.Parameters.AddWithValue("@ecuesStudentsId", evaluation.EcuesStudentsId)
            command.Parameters.AddWithValue("@dateField", evaluation.DateField)
            command.Parameters.AddWithValue("@weightField", evaluation.Weight)
            command.Parameters.AddWithValue("@typeField", evaluation.Type)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "EvaluationsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function


    Public Overloads Shared Function delete(id As Integer) As Boolean
        Return Manager.delete("Evaluations", id)
    End Function
End Class
