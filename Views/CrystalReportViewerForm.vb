Imports System.IO

Public Class CrystalReportViewerForm
    Private Sub CrystalReportViewerForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        File.Delete("..\..\Data\Pictures\Students\tmp.png")
    End Sub
End Class