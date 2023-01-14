Imports Mysqlx.XDevAPI.Relational

Public Class EmployeesController
    Public Shared Function getGeneriqueList(employeesList As List(Of Employee)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("id", GetType(Integer))
        table.Columns.Add("lastName", GetType(String))
        table.Columns.Add("firstName", GetType(String))
        table.Columns.Add("phoneNumber", GetType(String))
        table.Columns.Add("email", GetType(String))
        table.Columns.Add("gender", GetType(String))
        table.Columns.Add("functionField", GetType(String))


        For Each employee As Employee In employeesList
            table.LoadDataRow(New Object() {employee.Id, employee.LastName, employee.FirstName, employee.PhoneNumber, employee.Email, employee.GenderView, employee.FunctionFieldView}, True)
        Next
        Return table
    End Function

    Public Shared Function getAll() As DataTable
        Return getGeneriqueList(EmployeesManager.getAll())
    End Function

    Public Shared Function search(word As String) As DataTable
        If word <> Nothing Then
            Return getGeneriqueList(EmployeesManager.search(word))
        Else
            Return getAll()
        End If
    End Function

    Public Shared Function verifyEmployee(lastName As String, firstName As String, phoneNumber As String, email As String, gender As String, functionField As String)
        If lastName = "" Then
            MessageBox.Show("Le nom ne doit pas être vide", "Nom vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf firstName = "" Then
            MessageBox.Show("Le prénom ne doit pas être vide", "Prénom vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf phoneNumber = "" Then
            MessageBox.Show("Le numéro de téléphone ne doit pas être vide", "Numéro de téléphone vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf email = "" Then
            MessageBox.Show("L'email ne doit pas être vide", "Email vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf gender <> "Female" And gender <> "Male" Then
            MessageBox.Show("Le genre doit être 'Homme' ou 'Femme'", "Genre invalide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf functionField <> "TuititionService" And functionField <> "Teacher" Then
            MessageBox.Show("La fonction doit être 'Enseignant' ou 'Service Scolarité'", "Fonction invalide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Return True
        End If
        Return False
    End Function

    Public Shared Function store(lastName As String, firstName As String, phoneNumber As String, email As String, gender As String, functionField As String) As Boolean
        gender = Employee.Gender_view_to_gender(gender)
        functionField = Employee.Function_view_field_to_function_field(functionField)
        If (verifyEmployee(lastName, firstName, phoneNumber, email, gender, functionField)) Then
            Dim employeeDB As Employee = EmployeesManager.getByLastNameAndFirtName(lastName, firstName)
            If (employeeDB.LastName = Nothing) Then
                employeeDB = EmployeesManager.getByPhoneNumber(phoneNumber)
                If employeeDB.LastName = Nothing Then
                    employeeDB = EmployeesManager.getByEmail(email)
                    If (employeeDB.LastName = Nothing) Then
                        Return EmployeesManager.store(New Employee(lastName, firstName, phoneNumber, email, gender, functionField))
                    Else
                        MessageBox.Show("L'email " & email & " est déjà utilisé", "Email déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Le numéro de téléphone " & phoneNumber & " est déjà utilisé", "Numéro de téléphone déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("L'employé " & firstName & " - " & lastName & " existe déjà", "Employé déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return False
    End Function

    Public Shared Function update(lastName As String, firstName As String, phoneNumber As String, email As String, gender As String, functionField As String, employeeId As Integer) As Boolean
        gender = Employee.Gender_view_to_gender(gender)
        functionField = Employee.Function_view_field_to_function_field(functionField)
        If (verifyEmployee(lastName, firstName, phoneNumber, email, gender, functionField)) Then
            Dim employeeDB As Employee = EmployeesManager.getByLastNameAndFirtName(lastName, firstName)
            If employeeDB.LastName <> Nothing Then
                If employeeDB.Id = employeeId Then
                    employeeDB = EmployeesManager.getByPhoneNumber(phoneNumber)
                    If employeeDB.LastName <> Nothing Then
                        If employeeDB.Id = employeeId Then
                            employeeDB = EmployeesManager.getByEmail(email)
                            If employeeDB.LastName <> Nothing Then
                                If employeeDB.Id <> employeeId Then
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
        Return EmployeesManager.update(New Employee(lastName, firstName, phoneNumber, email, gender, functionField), employeeId)
    End Function

    Public Shared Function delete(idList As List(Of Integer)) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) employé(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            For Each id As Integer In idList
                If EmployeesManager.delete(id) Then
                    response = True
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class
