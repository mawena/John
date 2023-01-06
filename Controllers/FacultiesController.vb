Public Class FacultiesController
    Public Shared Function getGeneriqueList(facultiesList As List(Of Faculty)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Libelle", GetType(String))
        table.Columns.Add("Sigle", GetType(String))
        table.Columns.Add("Institut", GetType(String))


        For Each faculty As Faculty In facultiesList
            table.LoadDataRow(New Object() {faculty.Id, faculty.Libelle, faculty.Sigle, faculty.InstituteName}, True)
        Next
        Return table
    End Function

    Public Shared Function getAll() As DataTable
        Return getGeneriqueList(FacultiesManager.getAll())
    End Function

    Public Shared Function searchFaculties(word As String) As DataTable
        If word <> Nothing Then
            Return getGeneriqueList(FacultiesManager.searchFaculties(word))
        Else
            Return getAll()
        End If
    End Function

    Public Shared Function verifyFaculty(libelle As String, sigle As String) As Boolean
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
        If verifyFaculty(libelle, sigle) Then
            Dim facultyDB As Faculty = FacultiesManager.getByLibelle(libelle)
            If facultyDB.Libelle = Nothing Then
                Return FacultiesManager.store(New Faculty(libelle, sigle, InstitutesManager.getByName(instituteName).Id))
            Else
                MessageBox.Show("L'institut " & libelle & " existe déjà", "Institut déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return False
    End Function
    Public Shared Function update(libelle As String, sigle As String, instituteName As String, facultyId As Integer) As Boolean
        If verifyFaculty(libelle, sigle) Then
            Dim facultyDB = FacultiesManager.getByLibelle(libelle)
            If facultyDB.Libelle <> Nothing Then
                If facultyDB.Id <> facultyId Then
                    MessageBox.Show("Le libelle " & libelle & " est déjà utilisé", "Libellé déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        End If
        Return FacultiesManager.update(New Faculty(libelle, sigle, InstitutesManager.getByName(instituteName).Id), facultyId)
    End Function

    Public Shared Function delete(idList) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) Faculté(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            For Each id As Integer In idList
                If FacultiesManager.delete(id) Then
                    response = True
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class
