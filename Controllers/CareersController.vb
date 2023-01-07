Public Class CareersController
    Public Shared Function getGeneriqueList(careersList As List(Of Career)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Libelle", GetType(String))
        table.Columns.Add("Sigle", GetType(String))
        table.Columns.Add("Institut", GetType(String))


        For Each career As Career In careersList
            table.LoadDataRow(New Object() {career.Id, career.Libelle, career.Sigle, career.InstituteName}, True)
        Next
        Return table
    End Function

    Public Shared Function getAll() As DataTable
        Return getGeneriqueList(CareersManager.getAll())
    End Function

    Public Shared Function search(word As String) As DataTable
        If word <> Nothing Then
            Return getGeneriqueList(CareersManager.search(word))
        Else
            Return getAll()
        End If
    End Function

    Public Shared Function verify(libelle As String, sigle As String) As Boolean
        If libelle = "" Then
            MessageBox.Show("Le libelle ne doit pas être vide", "Libelle vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf sigle = "" Then
            MessageBox.Show("Le sigle ne doit pas être vide", "Sigle vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Return True
        End If
        Return False
    End Function

    Public Shared Function store(libelle As String, sigle As String, instituteName As String) As Boolean
        If verify(libelle, sigle) Then
            Dim careerDB As Career = CareersManager.getByLibelle(libelle)
            If careerDB.Libelle = Nothing Then
                Return CareersManager.store(New Career(libelle, sigle, InstitutesManager.getByName(instituteName).Id))
            Else
                MessageBox.Show("Le parcours '" & libelle & "' existe déjà", "Parcours déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return False
    End Function
    Public Shared Function update(libelle As String, sigle As String, instituteName As String, careerId As Integer) As Boolean
        If verify(libelle, sigle) Then
            Dim careerDB = CareersManager.getByLibelle(libelle)
            If careerDB.Libelle <> Nothing Then
                If careerDB.Id <> careerId Then
                    MessageBox.Show("Le libelle '" & libelle & "' est déjà utilisé", "Libellé déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        End If
        Return CareersManager.update(New Career(libelle, sigle, InstitutesManager.getByName(instituteName).Id), careerId)
    End Function

    Public Shared Function delete(idList) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) Parcours(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            For Each id As Integer In idList
                If CareersManager.delete(id) Then
                    response = True
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class
