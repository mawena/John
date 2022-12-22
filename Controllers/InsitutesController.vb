Public Class InsitutesController
    Public Shared Function getAll() As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Libelle", GetType(String))
        table.Columns.Add("Sigle", GetType(String))


        For Each institute As Institute In InstitutesManager.getAll()
            table.LoadDataRow(New Object() {institute.Id, institute.Libelle, institute.Sigle}, True)
        Next
        Return table
    End Function
End Class
