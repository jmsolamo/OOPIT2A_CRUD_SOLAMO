<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.userIdViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.intParam1 = New IT2A_Crud_DelaCruz_FrancAlvenn.IntParam()
        Me.SuspendLayout()
        '
        'userIdViewer
        '
        Me.userIdViewer.ActiveViewIndex = -1
        Me.userIdViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userIdViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.userIdViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userIdViewer.Location = New System.Drawing.Point(0, 0)
        Me.userIdViewer.Name = "userIdViewer"
        Me.userIdViewer.Size = New System.Drawing.Size(795, 603)
        Me.userIdViewer.TabIndex = 0
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 603)
        Me.Controls.Add(Me.userIdViewer)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents userIdViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents intParam1 As IntParam
End Class
