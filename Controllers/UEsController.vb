Public Class UEsController
    Public Shared Function getGeneriqueList(uesList As List(Of UE)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("Identifiant", GetType(Integer))
        table.Columns.Add("Libelle", GetType(String))
        table.Columns.Add("Semestre", GetType(Integer))
        table.Columns.Add("Parcours", GetType(String))


        For Each ue As UE In uesList
            table.LoadDataRow(New Object() {ue.Id, ue.Libelle, ue.Semester, ue.Career.Name}, True)
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

    Public Shared Function store(libelle As String, semester As Integer, careerIdAndName As String) As Boolean
        If verify(libelle) Then
            For Each ueDB As UE In UEsManager.getByLibelle(libelle)
                If ueDB.Career.Name = careerIdAndName Then
                    MessageBox.Show("L'UE '" & libelle & "' dans le parcour '" & careerIdAndName & "' existe déjà", "UE déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Next
        End If
        Return UEsManager.store(New UE(libelle, semester, CareersManager.getByName(careerIdAndName).Id))
    End Function
    Public Shared Function update(libelle As String, semester As Integer, careerIdAndName As String, ueId As Integer) As Boolean
        If verify(libelle) Then
            For Each ueDB As UE In UEsManager.getByLibelle(libelle)
                If ueDB.Id <> ueId Then
                    If ueDB.Career.Name = careerIdAndName Then
                        MessageBox.Show("L'UE '" & libelle & "' dans le parcour '" & careerIdAndName & "' existe déjà", "UE déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                End If
            Next
        End If
        Return UEsManager.update(New UE(libelle, semester, CareersManager.getByName(careerIdAndName).Id), ueId)
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
