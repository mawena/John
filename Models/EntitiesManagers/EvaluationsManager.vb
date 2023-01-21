Imports MySql.Data.MySqlClient

Public Class EvaluationsManager
    Inherits Manager
    Public Shared Function getTmpLit() As List(Of Evaluation)
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
        Return getTmpLit()
    End Function
    Public Shared Function search(word As String)
        command = New MySqlCommand("SELECT * FROM Evaluations WHERE last_name LIKE @word OR first_name LIKE @word OR email LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getTmpLit()
    End Function
    Public Shared Function getByStudentId(studentId As Integer) As List(Of Evaluation)
        command = New MySqlCommand("SELECT * FROM Evaluations WHERE student_id = studentId;", Manager.connection)
        command.Parameters.AddWithValue("studentId", studentId)
        Return getTmpLit()
    End Function
    Public Shared Function getByECUEId(ecueId As Integer) As List(Of Evaluation)
        command = New MySqlCommand("SELECT Evaluations.id As id, Evaluations.grade As grade, Evaluations.ECUEsStudents_id As ECUEsStudents_id, Evaluations.date_field As date_field, Evaluations.weight_field As weight_field, Evaluations.type_field As type_field FROM Evaluations, ECUEsStudents WHERE ECUEsStudents.id = Evaluations.ECUEsStudents_id AND ECUEsStudents.ECUE_id = @ecueId;", Manager.connection)
        command.Parameters.AddWithValue("ecueId", ecueId)
        Return getTmpLit()
    End Function
    Public Shared Function getByECUEsStudentsId(ecuesStudentsId As Integer) As List(Of Evaluation)
        command = New MySqlCommand("SELECT * FROM Evaluations WHERE ECUEsStudents_id = @ecuesStudentsId;", Manager.connection)
        command.Parameters.AddWithValue("@ecuesStudentsId", ecuesStudentsId)
        Return getTmpLit()
    End Function

    Public Shared Function getByStudentIdAndECUEIdAndSemester(ecuesStudentsId As Integer) As List(Of Evaluation)
        command = New MySqlCommand("SELECT * FROM Evaluations WHERE ECUEsStudents_id = @ecuesStudentsId;", Manager.connection)
        command.Parameters.AddWithValue("@ecuesStudentsId", ecuesStudentsId)
        Return getTmpLit()
    End Function

    Public Shared Function getByECUEId_careerId_semester_studentId(ecueId As Integer, careerId As Integer, semester As Integer, studentId As Integer) As List(Of Evaluation)
        command = New MySqlCommand("SELECT evaluations.* FROM evaluations, ecuesstudents, ecues, students, ecuesues, careersues, ues WHERE evaluations.ECUEsStudents_id = ecuesstudents.id AND ecuesstudents.ECUE_id = ecues.id AND ecuesstudents.student_id = students.id AND ecuesues.ECUE_id = ecuesstudents.ECUE_id AND ecuesues.UE_id = ues.id AND careersues.Career_id = students.career_id AND careersues.UE_id = ues.id AND ecues.id = @ecueId AND students.career_id = @careerId AND ues.semester = @semester AND students.id = @studentId;", Manager.connection)
        command.Parameters.AddWithValue("@ecueId", ecueId)
        command.Parameters.AddWithValue("@careerId", careerId)
        command.Parameters.AddWithValue("@semester", semester)
        command.Parameters.AddWithValue("@studentId", studentId)
        Return getTmpLit()
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

    Public Shared Function getECUEsStudentsId(ecueId As Integer, StudentId As Integer)
        command = New MySqlCommand("SELECT id FROM ECUEsStudents WHERE ECUE_id = @ecueId AND Student_id = @studentId;", Manager.connection)
        command.Parameters.AddWithValue("@ecueId", ecueId)
        command.Parameters.AddWithValue("@studentId", StudentId)
        Dim id As Integer
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                id = CInt(row("id"))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la sélection de données : " & ex.Message, "EvaluationsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return id
    End Function

    Public Shared Function insert(evaluation As Evaluation) As Boolean
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
