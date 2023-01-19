Imports System.IO

Public Class StudentsController
    Public Shared Function getGeneriqueList(studentsList As List(Of Student)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("picturePath", GetType(Image))
        table.Columns.Add("id", GetType(Integer))
        table.Columns.Add("lastName", GetType(String))
        table.Columns.Add("firstName", GetType(String))
        table.Columns.Add("birthDate", GetType(String))
        table.Columns.Add("gender", GetType(String))
        table.Columns.Add("email", GetType(String))
        table.Columns.Add("phoneNumber", GetType(String))
        table.Columns.Add("careerName", GetType(String))

        For Each student As Student In studentsList
            Dim img As Image
            Try
                img = Image.FromFile(student.PicturePath)

            Catch ex As Exception
                img = Image.FromFile(Student.PicturePathDefault)
            End Try
            'img.Dispose()
            table.LoadDataRow(New Object() {img, student.Id, student.LastName, student.FirstName, student.BirthDate, student.Gender, student.Email, student.PhoneNumber, student.Career.Name}, True)
        Next
        Return table
    End Function

    Public Shared Function getAllForReport() As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Id", GetType(Integer))
        table.Columns.Add("LastName", GetType(String))
        table.Columns.Add("FirstName", GetType(String))
        table.Columns.Add("BirthDate", GetType(String))
        table.Columns.Add("Gender", GetType(String))
        table.Columns.Add("Email", GetType(String))
        table.Columns.Add("PhoneNumber", GetType(String))
        table.Columns.Add("CareerName", GetType(String))

        For Each student As Student In StudentsManager.getAll()
            table.LoadDataRow(New Object() {student.Id, student.LastName, student.FirstName, student.BirthDate, student.Gender, student.Email, student.PhoneNumber, student.Career.Name}, True)
        Next
        Return table
    End Function

    Public Shared Function getAll() As DataTable
        Return getGeneriqueList(StudentsManager.getAll())
    End Function
    Public Shared Function getByCareerId(studentId As Integer) As DataTable
        Return getGeneriqueList(StudentsManager.getByCareerId(studentId))
    End Function
    Public Shared Function search(careerId As Integer, word As String) As DataTable
        If word <> Nothing Then
            Return getGeneriqueList(StudentsManager.search(word))
        Else
            Return getByCareerId(careerId)
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

    Public Shared Function store(lastName As String, firstName As String, birthDate As String, gender As String, email As String, phoneNumber As String, picturePath As String, careerId As Integer, semester As Integer) As Boolean
        If verify(lastName, firstName, gender, email, phoneNumber) Then
            Dim studentDB As Student = StudentsManager.getByLastNameAndFirtName(lastName, firstName)
            If (studentDB.LastName = Nothing) Then
                studentDB = StudentsManager.getByPhoneNumber(phoneNumber)
                If studentDB.LastName = Nothing Then
                    studentDB = StudentsManager.getByEmail(email)
                    If (studentDB.LastName = Nothing) Then
                        If StudentsManager.store(New Student(lastName, firstName, birthDate, gender, email, phoneNumber, picturePath, careerId)) Then
                            Dim student As Student = StudentsManager.getById(Manager.getLastId("Students"))
                            StudentsManager.deleteECUEsStudents(student.Id)
                            For Each ecue As ECUE In ECUEsManager.getByCareerIdAndSemester(careerId, semester)
                                StudentsManager.storeECUEsStudents(ecue.Id, student.Id, "2023-2024")
                            Next
                            student.PicturePath = Student.PictureDirectoryPath & student.Name & ".png"
                            File.Copy(picturePath, student.PicturePath, True)
                            StudentsManager.update(student, student.Id)
                            Return True
                        End If
                    Else
                        MessageBox.Show("L'email " & email & " est déjà utilisé", "Email déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Le numéro de téléphone " & phoneNumber & " est déjà utilisé", "Numéro de téléphone déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("L'étudiant " & firstName & " - " & lastName & " existe déjà", "Etudiant déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    MessageBox.Show("Le nom " & lastName & " - " & firstName & " est déjà utilisé", "Nom déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        End If
        If StudentsManager.update(New Student(lastName, firstName, birthDate, gender, email, phoneNumber, picturePath, careerId), studentId) Then
            Dim student As Student = StudentsManager.getById(studentId)
            StudentsManager.deleteECUEsStudents(student.Id)
            For Each ecue As ECUE In ECUEsManager.getByCareerIdAndSemester(careerId, semester)
                StudentsManager.storeECUEsStudents(ecue.Id, student.Id, "2023-2024")
            Next
            If (picturePath <> student.PicturePath) Then
                student.PicturePath = Student.PictureDirectoryPath & student.Name & ".png"
                File.Copy(picturePath, student.PicturePath, True)
            End If
            StudentsManager.update(student, student.Id)
            Return True
        End If
        Return True
    End Function



    Public Shared Function delete(idList) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) étudiants(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            For Each id As Integer In idList
                Dim student As Student = StudentsManager.getById(id)
                If StudentsManager.delete(id) Then
                    response = True
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class