Imports System.IO

Public Class StudentsController
    Public Shared Function getTmpLit(studentsList As List(Of Student)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("id", GetType(Integer))
        table.Columns.Add("lastName", GetType(String))
        table.Columns.Add("firstName", GetType(String))
        table.Columns.Add("picturePath", GetType(Image))
        table.Columns.Add("phoneNumber", GetType(String))
        table.Columns.Add("gender", GetType(String))
        table.Columns.Add("email", GetType(String))
        table.Columns.Add("birthDate", GetType(String))
        table.Columns.Add("careerName", GetType(String))

        For Each student As Student In studentsList
            Dim img As Image
            Try
                img = Image.FromFile(student.PicturePath)

            Catch ex As Exception
                img = Image.FromFile(Student.PicturePathDefault)
            End Try
            'img.Dispose()
            table.LoadDataRow(New Object() {student.Id, student.LastName, student.FirstName, img, student.PhoneNumber, student.Gender, student.Email, student.BirthDate, student.Career.Name}, True)
        Next
        Return table
    End Function

    Public Shared Function getAllForReport(careerId As Integer, semester As Integer) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Id", GetType(Integer))
        table.Columns.Add("LastName", GetType(String))
        table.Columns.Add("FirstName", GetType(String))
        table.Columns.Add("BirthDate", GetType(String))
        table.Columns.Add("Gender", GetType(String))
        table.Columns.Add("Email", GetType(String))
        table.Columns.Add("PhoneNumber", GetType(String))
        table.Columns.Add("CareerName", GetType(String))

        For Each student As Student In StudentsManager.getByCareerIdAndSemester(semester, careerId)
            table.LoadDataRow(New Object() {student.Id, student.LastName, student.FirstName, student.BirthDate, student.Gender, student.Email, student.PhoneNumber, student.Career.Name}, True)
        Next
        Return table
    End Function
    Public Shared Function getByCareerIdAndSemester(careerId As Integer, semester As Integer) As DataTable
        Return getTmpLit(StudentsManager.getByCareerIdAndSemester(semester, careerId))
    End Function
    Public Shared Function search(careerId As Integer, semester As Integer, word As String) As DataTable
        If word <> Nothing Then
            Dim studentList As New List(Of Student)
            For Each student As Student In StudentsManager.getByCareerIdAndSemester(semester, careerId)
                If student.Name.ToLower().Contains(word.ToLower()) Then
                    studentList.Add(student)
                End If
            Next
            Return getTmpLit(studentList)
        Else
            Return getByCareerIdAndSemester(careerId, semester)
        End If
    End Function

    Public Shared Function verify(lastName As String, firstName As String, gender As String, email As String, phoneNumber As String)
        If lastName = "" Then
            MessageBox.Show("Le nom ne doit pas être vide", "Nom vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf firstName = "" Then
            MessageBox.Show("Le prénom ne doit pas être vide", "Prénom vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf phoneNumber = "" Then
            MessageBox.Show("Le numéro de téléphone ne doit pas être vide", "Numéro de téléphone vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf email = "" Then
            MessageBox.Show("L'email ne doit pas être vide", "Email vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf gender <> "Homme" And gender <> "Femme" Then
            MessageBox.Show("Le genre doit être 'Homme' ou 'Femme'", "Genre invalide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Return True
        End If
        Return False
    End Function

    Public Shared Sub copyCorrectlyPicture(student)
        If student.PicturePath <> student.PicturePathDefault Then
            Dim picturePathData = student.PicturePath.Split(".")
            Dim newPicturePath As String = student.PictureDirectoryPath & student.Name & "." & picturePathData(picturePathData.Length - 1)
            If (student.PicturePath <> newPicturePath) Then
                File.Copy(student.PicturePath, newPicturePath, True)
                student.PicturePath = newPicturePath
                StudentsManager.update(student, student.Id)
            End If
        End If
    End Sub

    Public Shared Function inscribeInCareerECUEs(student As Student, semester As Integer) As Boolean
        For Each ecue As ECUE In ECUEsManager.getByCareerIdAndSemester(student.CareerId, semester)
            If StudentsManager.countECUEsStudentId(ecue.Id, student.Id) > 0 Then
                StudentsManager.storeECUEsStudents(ecue.Id, student.Id, "2023-2024")
            End If
        Next
        copyCorrectlyPicture(student)
        Return True
    End Function
    Public Shared Function insert(lastName As String, firstName As String, birthDate As String, gender As String, email As String, phoneNumber As String, picturePath As String, careerId As Integer, semester As Integer) As Boolean
        If verify(lastName, firstName, gender, email, phoneNumber) Then
            Dim studentDB As Student = StudentsManager.getByLastNameAndFirtName(lastName, firstName)
            If (studentDB.LastName = Nothing) Then
                studentDB = StudentsManager.getByPhoneNumber(phoneNumber)
                If studentDB.LastName = Nothing Then
                    studentDB = StudentsManager.getByEmail(email)
                    If (studentDB.LastName = Nothing) Then
                        Dim studentToSave As Student = New Student(lastName, firstName, birthDate, gender, email, phoneNumber, picturePath, careerId)
                        If StudentsManager.insert(studentToSave) Then
                            Return inscribeInCareerECUEs(StudentsManager.getById(Manager.getLastId("Students")), semester)
                        End If

                    Else
                        MessageBox.Show("L'email " & email & " est déjà utilisé", "Email déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Le numéro de téléphone " & phoneNumber & " est déjà utilisé", "Numéro de téléphone déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf StudentsManager.getBySemesterAndCareerIdAndId(semester, careerId, studentDB.Id).LastName = Nothing Then
                studentDB.PicturePath = Student.PicturePathDefault
                Return inscribeInCareerECUEs(studentDB, semester)
            Else
                MessageBox.Show("L'étudiant " & firstName & " - " & lastName & " est déjà inscrit en semestre " & semester, "Etudiant déjà inscrit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return False
    End Function
    Public Shared Function update(lastName As String, firstName As String, birthDate As String, gender As String, email As String, phoneNumber As String, picturePath As String, careerId As Integer, semester As Integer, studentId As Integer) As Boolean
        If verify(lastName, firstName, gender, email, phoneNumber) Then
            Dim studentDB As Student = StudentsManager.getByLastNameAndFirtName(lastName, firstName)
            If studentDB.LastName <> Nothing Then
                If studentDB.Id = studentId Then
                    studentDB = StudentsManager.getByPhoneNumber(phoneNumber)
                    If studentDB.LastName <> Nothing Then
                        If studentDB.Id = studentId Then
                            studentDB = StudentsManager.getByEmail(email)
                            If studentDB.LastName <> Nothing Then
                                If studentDB.Id <> studentId Then
                                    MessageBox.Show("L'email " & email & " est déjà utilisé pas", "Email déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return False
                                End If
                            End If
                        Else
                            MessageBox.Show("Le numéro de téléphone " & phoneNumber & " est déjà utilisé", "Numéro de téléphone déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End If
                Else
                    MessageBox.Show("L'étudiant " & lastName & " - " & firstName & " est déjà inscrit", "Nom déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
            Dim student As Student = New Student(studentId, lastName, firstName, birthDate, gender, email, phoneNumber, picturePath, careerId)
            studentDB = StudentsManager.getBySemesterAndCareerIdAndId(semester, careerId, studentId)
            If studentDB.LastName = Nothing Then
                If StudentsManager.update(student, studentId) Then
                    inscribeInCareerECUEs(student, semester)
                    Return True
                End If
            Else
                copyCorrectlyPicture(student)
                Return StudentsManager.update(student, studentId)
            End If
        End If
        Return False
    End Function



    Public Shared Function unscribeInSemester(semester, studentId) As Boolean
        For Each ecue As ECUE In ECUEsManager.getByStudentIdAndSemester(studentId, semester)
            If StudentsManager.deleteInECUEsStudents(ecue.Id, studentId) = False Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Shared Function delete(id As Integer) As Boolean
        Dim student As Student = StudentsManager.getById(id)
        If student.LastName <> Nothing Then
            Dim response As Boolean = True
            For Each i As Integer In New List(Of Integer) From {1, 2, 3, 4, 5, 6}
                If unscribeInSemester(i, id) = False Then
                    response = False
                End If
            Next
            If response Then
                Return StudentsManager.delete(id)
            End If
        End If
        Return True
    End Function
End Class