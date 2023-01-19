<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrystalReportViewerForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CRV_STUDENTS = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRV_STUDENTS
        '
        Me.CRV_STUDENTS.ActiveViewIndex = -1
        Me.CRV_STUDENTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_STUDENTS.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_STUDENTS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_STUDENTS.Location = New System.Drawing.Point(0, 0)
        Me.CRV_STUDENTS.Name = "CRV_STUDENTS"
        Me.CRV_STUDENTS.Size = New System.Drawing.Size(800, 450)
        Me.CRV_STUDENTS.TabIndex = 0
        '
        'CrystalReportViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CRV_STUDENTS)
        Me.Name = "CrystalReportViewerForm"
        Me.Text = "CrystalReportViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents CRV_STUDENTS As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
