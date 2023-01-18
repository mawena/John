Imports MySql.Data.MySqlClient
Public Class Manager
    Protected Shared connection As MySqlConnection
    Public Shared command As MySqlCommand
    Protected Shared dataAdapater As MySqlDataAdapter
    Protected Shared dataTable As DataTable

    Public Shared Function connect() As Boolean
        Manager.connection = Nothing
        Try
            Manager.connection = New MySqlConnection("Data Source=localhost;user id=test;password=root;port=3306;database=John;Convert Zero Datetime=True")
            Manager.connection.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la connexion à la base de données: " & ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function Close() As Boolean
        Try
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
            command.CommandText = Nothing
            dataAdapater.Dispose()
            dataTable.Dispose()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant le fermeture du lecteur de la base de données." & ex.Message, "manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function getLastId(tableName) As Integer
        Dim id As Integer
        Try
            command = New MySqlCommand("SELECT MAX(id) AS id FROM " & tableName & ";", Manager.connection)
            dataAdapater = New MySql.Data.MySqlClient.MySqlDataAdapter(command)

            dataTable = New DataTable
            Manager.dataAdapater.Fill(Manager.dataTable)
            For Each row As DataRow In Manager.dataTable.Rows
                id = CInt(row("id"))
            Next
            disposeManager()
        Catch ex As Exception
            MessageBox.Show("Erreur durant une selection du dernier id de la table '" & tableName & "' : " & ex.Message, "ECUEsManager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return id
    End Function

    Public Shared Function delete(tableName As String, id As Integer) As Boolean
        Try
            command = New MySqlCommand("DELETE FROM " & tableName & " WHERE id = @id;", Manager.connection)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()
            disposeManager()
            Return True
        Catch ex As Exception
            MessageBox.Show("Erreur durant la supression : " & ex.Message, tableName & "Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function
End Class
