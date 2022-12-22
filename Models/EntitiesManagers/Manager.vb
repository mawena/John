Imports MySql.Data.MySqlClient
Public Class Manager
    Protected Shared connection As MySqlConnection
    Protected Shared command As MySqlCommand
    Protected Shared dataAdapater As MySqlDataAdapter
    Protected Shared dataTable As DataTable

    Public Shared Function connect() As Boolean
        Manager.connection = Nothing
        Try
            Manager.connection = New MySqlConnection("Data Source=localhost;user id=test;password=root;port=3306;database=John")
            Manager.connection.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la connexion à la base de données: " & ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function close() As Boolean
        Try
            Manager.connection.Close()
            Manager.connection = Nothing
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la déconnexion à la base de données : " & ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function disposeManager() As Boolean
        Try
            command.Dispose()
            dataAdapater.Dispose()
            dataTable.Dispose()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant le fermeture du lecteur de la base de données." & ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
