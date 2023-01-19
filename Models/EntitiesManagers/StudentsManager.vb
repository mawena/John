Imports MySql.Data.MySqlClient

Public Class StudentsManager
    Inherits Manager
    Public Shared Function getGeneriqueList() As List(Of Student)
        Dim studentList As New List(Of Student)()
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            dataTable = New DataTable
            dataAdapater.Fill(dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                studentList.Add(New Student(CInt(row("id")), row("last_name"), row("first_name"), row("birth_date"), row("gender"), row("email"), row("phone_number"), row("picture_path"), row("career_id")))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant la selection des données : " & ex.Message, "StudentsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return studentList
    End Function
    Public Shared Function getAll() As List(Of Student)
        command = New MySqlCommand("SELECT * FROM Students;", Manager.connection)
        Return getGeneriqueList()
    End Function
    Public Shared Function search(word As String)
        command = New MySqlCommand("SELECT * FROM Students WHERE last_name LIKE @word OR first_name LIKE @word OR email LIKE @word;", Manager.connection)
        command.Parameters.AddWithValue("@word", "%" & word & "%")
        Return getGeneriqueList()
    End Function
    Public Shared Function getByCareerId(careerId As Integer)
        command = New MySqlCommand("SELECT * FROM Students WHERE career_id = @careerId;", Manager.connection)
        command.Parameters.AddWithValue("@careerId", careerId)
        Return getGeneriqueList()
    End Function
    Public Shared Function getByECUEId(ecueId As Integer)
        command = New MySqlCommand("SELECT Students.id As id, Students.last_name As last_name, Students.first_name As first_name, Students.birth_date As birth_date, Students.gender As gender, Students.email As email, Students.phone_number As phone_number, Students.picture_path As picture_path, Students.career_id As career_id FROM Students, ECUEsStudents WHERE ECUEsStudents.ECUE_id = @ecueId AND ECUEsStudents.Student_id = Students.id;", Manager.connection)
        command.Parameters.AddWithValue("@ecueId", ecueId)
        Return getGeneriqueList()
    End Function


    Private Shared Function getGenerique() As Student
        Dim student As Student = New Student(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Try
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)

            For Each row As DataRow In Manager.dataTable.Rows
                student = New Student(CInt(row("id")), row("last_name"), row("first_name"), row("birth_date"), row("gender"), row("email"), row("phone_number"), row("picture_path"), row("career_id"))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection de données : " & ex.Message, "StudentsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return student
    End Function
    Public Shared Function getById(id As Integer) As Student
        command = New MySqlCommand("SELECT * FROM Students WHERE id = @id;", Manager.connection)
        command.Parameters.AddWithValue("@id", id)
        Return getGenerique()
    End Function
    Public Shared Function getByPhoneNumber(phoneNumber As String) As Student
        command = New MySqlCommand("SELECT * FROM Students WHERE phone_number = @phone_number;", Manager.connection)
        command.Parameters.AddWithValue("@phone_number", phoneNumber)
        Return getGenerique()
    End Function
    Public Shared Function getByEmail(email As String) As Student
        command = New MySqlCommand("SELECT * FROM Students WHERE email = @email;", Manager.connection)
        command.Parameters.AddWithValue("@email", email)
        Return getGenerique()
    End Function
    Public Shared Function getByLastNameAndFirtName(lastName As String, firstName As String) As Student
        command = New MySqlCommand("SELECT * FROM Students WHERE last_name = @last_name AND first_name = @first_name;", Manager.connection)
        command.Parameters.AddWithValue("@last_name", lastName)
        command.Parameters.AddWithValue("@first_name", firstName)
        Return getGenerique()
    End Function
    Public Shared Function getByEvaluationId(evaluationId As Integer) As Student
        command = New MySqlCommand("SELECT Students.id As id, Students.last_name As last_name, Students.first_name As first_name, Students.birth_date As birth_date, Students.gender As gender, Students.email As email, Students.phone_number As phone_number, Students.picture_path As picture_path, Students.career_id As career_id FROM Students, Evaluations, ECUEsStudents WHERE Students.id = ECUEsStudents.student_id AND ECUEsStudents.id = Evaluations.ECUEsStudents_id AND Evaluations.id = @evaluationId;", Manager.connection)
        command.Parameters.AddWithValue("@evaluationId", evaluationId)
        Return getGenerique()
    End Function


    Public Shared Function store(student As Student) As Boolean
        Try
            command = New MySqlCommand("INSERT INTO Students(last_name, first_name, birth_date, gender, email, phone_number, picture_path, career_id) VALUES(@last_name, @first_name, @birth_date, @gender, @email, @phone_number, @picture_path, @career_id);", Manager.connection)
            command.Parameters.AddWithValue("@last_name", student.LastName)
            command.Parameters.AddWithValue("@first_name", student.FirstName)
            command.Parameters.AddWithValue("@birth_date", student.BirthDate)
            command.Parameters.AddWithValue("@gender", student.Gender)
            command.Parameters.AddWithValue("@email", student.Email)
            command.Parameters.AddWithValue("@phone_number", student.PhoneNumber)
            command.Parameters.AddWithValue("@picture_path", student.PicturePath)
            command.Parameters.AddWithValue("@career_id", student.CareerId)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion : " & ex.Message, "StudentsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
    Public Shared Function storeECUEsStudents(ecueId As Integer, studentId As Integer, scolarYear As String)
        Try
            command = New MySqlCommand("INSERT INTO ECUEsStudents(ECUE_id, student_id, scolar_year) VALUES(@ecueId, @studentId, @scolarYear);", Manager.connection)
            command.Parameters.AddWithValue("@ecueId", ecueId)
            command.Parameters.AddWithValue("@studentId", studentId)
            command.Parameters.AddWithValue("@scolarYear", scolarYear)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant l'insertion dans une matière : " & ex.Message, "StudentsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Shared Function update(student As Student, id As Integer) As Boolean
        Try
            command = New MySqlCommand("UPDATE Students SET last_name = @last_name, first_name = @first_name, birth_date = @birth_date, gender = @gender, email = @email, phone_number = @phone_number, picture_path = @picture_path, career_id = @career_id WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@last_name", student.LastName)
            command.Parameters.AddWithValue("@first_name", student.FirstName)
            command.Parameters.AddWithValue("@birth_date", student.BirthDate)
            command.Parameters.AddWithValue("@gender", student.Gender)
            command.Parameters.AddWithValue("@email", student.Email)
            command.Parameters.AddWithValue("@phone_number", student.PhoneNumber)
            command.Parameters.AddWithValue("@picture_path", student.PicturePath)
            command.Parameters.AddWithValue("@career_id", student.CareerId)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la mise à jour : " & ex.Message, "StudentsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Shared Function deleteECUEsStudents(studentId As Integer) As Boolean
        Try
            command = New MySqlCommand("DELETE FROM ECUEsStudents WHERE student_id = @studentId;", Manager.connection)
            command.Parameters.AddWithValue("@studentId", studentId)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la désinscription dans des matières : " & ex.Message, "StudentsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
    Public Overloads Shared Function delete(id As Integer) As Boolean
        If (deleteECUEsStudents(id)) Then
            Return Manager.delete("Students", id)
        End If
        Return False
    End Function
End Class
