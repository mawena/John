Public Class InstitutesController
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

    Public Shared Function searchInstitutes(world As String) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Libelle", GetType(String))
        table.Columns.Add("Sigle", GetType(String))

        If world <> Nothing Then
            For Each institute As Institute In InstitutesManager.searchInstitutes(world)
                table.LoadDataRow(New Object() {institute.Id, institute.Libelle, institute.Sigle}, True)
            Next
        Else
            Return getAll()
        End If
        Return table
    End Function

    Public Shared Function verifyInstitute(libelle As String, sigle As String) As Boolean
        If libelle = "" Then
            MessageBox.Show("Le libelle ne doit pas être vide", "Libelle vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf sigle = "" Then
            MessageBox.Show("Le sigle ne doit pas être vide", "Sigle vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Return True
        End If
        Return False
    End Function

    Public Shared Function store(libelle As String, sigle As String) As Boolean
        If verifyInstitute(libelle, sigle) Then
            Dim instituteDB As Institute = InstitutesManager.getByLibelle(libelle)
            If instituteDB.Libelle = Nothing Then
                Return InstitutesManager.store(New Institute(libelle, sigle))
            Else
                MessageBox.Show("L'institut " & libelle & " existe déjà", "Institut déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return False
    End Function

    Public Shared Function update(libelle As String, sigle As String, instituteId As Integer) As Boolean
        If verifyInstitute(libelle, sigle) Then
            Dim instituteDB = InstitutesManager.getByLibelle(libelle)
            If instituteDB.Libelle <> Nothing Then
                If instituteDB.Id <> instituteId Then
                    MessageBox.Show("Le libelle " & libelle & " est déjà utilisé", "Libellé déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        End If
        Return InstitutesManager.update(New Institute(libelle, sigle), instituteId)
    End Function

    Public Shared Function delete(idList) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) institut(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            For Each id As Integer In idList
                If InstitutesManager.delete(id) Then
                    response = True
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class
