Imports Mysqlx.XDevAPI.Relational

Public Class EmployeesController
    Public Shared Function getAll() As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Nom", GetType(String))
        table.Columns.Add("Prénoms", GetType(String))
        table.Columns.Add("Téléphone", GetType(String))
        table.Columns.Add("Email", GetType(String))
        table.Columns.Add("Genre", GetType(String))
        table.Columns.Add("Fonction", GetType(String))


        For Each employee As Employee In EmployeesManager.getAll()
            table.LoadDataRow(New Object() {employee.Id, employee.LastName, employee.FirstName, employee.PhoneNumber, employee.Email, employee.GenderView, employee.FunctionFieldView}, True)
        Next
        Return table
    End Function

    Public Shared Function searchEmployees(word As String) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Nom", GetType(String))
        table.Columns.Add("Prénoms", GetType(String))
        table.Columns.Add("Téléphone", GetType(String))
        table.Columns.Add("Email", GetType(String))
        table.Columns.Add("Genre", GetType(String))
        table.Columns.Add("Fonction", GetType(String))

        If word <> Nothing Then
            For Each employee As Employee In EmployeesManager.searchEmployees(word)
                table.LoadDataRow(New Object() {employee.Id, employee.LastName, employee.FirstName, employee.PhoneNumber, employee.Email, employee.Gender, employee.FunctionField}, True)
            Next
        Else
            Return getAll()
        End If
        Return table
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
            Dim employeeDB As Employee = EmployeesManager.getById(employeeId)
            If (employeeDB.LastName = Nothing) Then
                MessageBox.Show("L'employé " & employeeId & " n'existe pas", "Employé inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Return EmployeesManager.update(New Employee(lastName, firstName, phoneNumber, email, gender, functionField), employeeId)
            End If
        End If
        Return False
    End Function

    Public Shared Function delete(idList As List(Of Integer)) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) employé(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            For Each id As Integer In idList
                If EmployeesManager.getById(id).LastName = Nothing Then
                    MessageBox.Show("L'employé " & id & " n'existe pas.", "Employé inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit For
                Else
                    If EmployeesManager.delete(id) Then
                        response = True
                    End If
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class
