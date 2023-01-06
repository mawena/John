Public Class UEsController
    Public Shared Function getGeneriqueList(uesList As List(Of UE)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Libelle", GetType(String))
        table.Columns.Add("Semestre", GetType(Integer))
        table.Columns.Add("Faculté", GetType(String))


        For Each ue As UE In uesList
            table.LoadDataRow(New Object() {ue.Id, ue.Libelle, ue.Semester, ue.FacultyName}, True)
        Next
        Return table
    End Function

    Public Shared Function getAll() As DataTable
        Return getGeneriqueList(UEsManager.getAll())
    End Function

    Public Shared Function search(word As String) As DataTable
        If word <> Nothing Then
            Return getGeneriqueList(UEsManager.search(word))
        Else
            Return getAll()
        End If
    End Function

    Public Shared Function verify(libelle As String) As Boolean
        If libelle = "" Then
            MessageBox.Show("Le libelle ne doit pas être vide", "Libelle vide", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Return True
        End If
        Return False
    End Function

    Public Shared Function store(libelle As String, semester As Integer, facultyIdAndName As String) As Boolean
        If verify(libelle) Then
            Dim ueDB As UE = UEsManager.getByLibelle(libelle)
            If ueDB.Libelle = Nothing Then
                Return UEsManager.store(New UE(libelle, semester, FacultiesManager.getByIdAndName(facultyIdAndName).Id))
            Else
                MessageBox.Show("L'UE " & libelle & " existe déjà", "UE déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return False
    End Function
    Public Shared Function update(libelle As String, semester As Integer, facultyIdAndName As String, ueId As Integer) As Boolean
        If verify(libelle) Then
            Dim ueDB = UEsManager.getByLibelle(libelle)
            If ueDB.Libelle <> Nothing Then
                If ueDB.Id <> ueId Then
                    MessageBox.Show("Le libelle " & libelle & " est déjà utilisé", "Libellé déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If
        End If
        Return UEsManager.update(New UE(libelle, semester, FacultiesManager.getByIdAndName(facultyIdAndName).Id), ueId)
    End Function

    Public Shared Function delete(idList) As Boolean
        Dim response As Boolean = False
        If (MessageBox.Show("Etes vous sûr de vouloir supprimer cet(s) UE(s)?", "Confirmation de supression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            For Each id As Integer In idList
                If UEsManager.delete(id) Then
                    response = True
                End If
            Next
        Else
            Return False
        End If
        Return response
    End Function
End Class
