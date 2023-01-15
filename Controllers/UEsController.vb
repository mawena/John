Public Class UEsController
    Public Shared Function getGeneriqueList(uesList As List(Of UE)) As DataTable
        Dim table As DataTable = New DataTable
        table.Columns.Add("id", GetType(Integer))
        table.Columns.Add("libelle", GetType(String))
        table.Columns.Add("semester", GetType(Integer))
        table.Columns.Add("careers", GetType(String))


        For Each ue As UE In uesList
            table.LoadDataRow(New Object() {ue.Id, ue.Libelle, ue.Semester, ue.CareerListName}, True)
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

    Public Shared Function store(libelle As String, semester As Integer, careerIdList As List(Of Integer)) As Boolean
        If verify(libelle) Then
            Dim ueDB As UE = UEsManager.getByLibelle(libelle)
            If ueDB.Libelle = Nothing Then
                Dim careerList As New List(Of Career)()
                For Each careerId As Integer In careerIdList
                    careerList.Add(CareersManager.getById(careerId))
                Next
                Return UEsManager.store(New UE(libelle, semester, careerList))
            Else
                MessageBox.Show("L'UE '" & libelle & "' existe déjà", "UE déjà existant", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If
        Return False
    End Function
    Public Shared Function update(libelle As String, semester As Integer, careerIdList As List(Of Integer), ueId As Integer) As Boolean
        If verify(libelle) Then
            Dim ueDB As UE = UEsManager.getByLibelle(libelle)
            If ueDB.Libelle = Nothing Then
                MessageBox.Show("L'UE '" & libelle & "' n'existe déjà", "UE inexistant", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Dim careerList As New List(Of Career)()
                For Each careerId As Integer In careerIdList
                    careerList.Add(CareersManager.getById(careerId))
                Next
                Return UEsManager.update(New UE(libelle, semester, careerList), ueId)
            End If
        End If
        Return False
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
