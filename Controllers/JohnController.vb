Public Class JohnController
    Public Shared user As User
    Public Shared dashboard
    Public Shared Function Login(username As String, password As String) As Boolean
        If (UsersController.verifyUser(username, password, True)) Then
            user = UsersManager.getByUsername(username)
            If user.Username = Nothing Then
                MessageBox.Show("L'utilisateur '" & username & "' n'existe pas", "Utilisateur inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If user.PasswordField = password Then
                    If user.Employee.LastName = Nothing Then
                        AdminViewForm.Show()
                    Else
                        If user.Employee.FunctionField = Employee.Teacher Then
                            If ECUEsManager.getByEmployeeId(user.EmployeeId).Count > 0 Then
                                TeacherViewForm.Show()
                            Else
                                MessageBox.Show("L'utilisateur '" & username & "' est un enseignant, mais il n'a pas de matière", "Aucune matière pour cet enseignant", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        Else
                            TuititionServiceViewForm.Show()
                        End If
                    End If
                    Return True
                Else
                    MessageBox.Show("Le mot de passe est incorrect", "Mot de passe incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
        Return False
    End Function

    Public Shared Function Logout() As Boolean
        LoginViewForm.Show()
        user = New User(Nothing, Nothing, Nothing)
        AdminViewForm.Close()
        TeacherViewForm.Close()
        TuititionServiceViewForm.Close()
        Return True
    End Function
End Class
