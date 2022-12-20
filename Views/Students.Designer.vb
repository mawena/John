<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Students
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LBL_VIEW = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBL_VIEW
        '
        Me.LBL_VIEW.AutoSize = True
        Me.LBL_VIEW.Location = New System.Drawing.Point(12, 143)
        Me.LBL_VIEW.Name = "LBL_VIEW"
        Me.LBL_VIEW.Size = New System.Drawing.Size(39, 13)
        Me.LBL_VIEW.TabIndex = 0
        Me.LBL_VIEW.Text = "Label1"
        '
        'Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LBL_VIEW)
        Me.Name = "Students"
        Me.Text = "Students"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_VIEW As Label
End Class
