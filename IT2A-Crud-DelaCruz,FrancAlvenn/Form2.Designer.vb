<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        cmbType = New ComboBox()
        txtData = New TextBox()
        btnFind = New Button()
        Label4 = New Label()
        dgvRecord = New DataGridView()
        btnBack = New Button()
        CType(dgvRecord, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbType
        ' 
        cmbType.FormattingEnabled = True
        cmbType.Location = New Point(44, 75)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(121, 23)
        cmbType.TabIndex = 0
        ' 
        ' txtData
        ' 
        txtData.Location = New Point(277, 72)
        txtData.Name = "txtData"
        txtData.Size = New Size(248, 23)
        txtData.TabIndex = 1
        ' 
        ' btnFind
        ' 
        btnFind.Location = New Point(541, 71)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(125, 24)
        btnFind.TabIndex = 3
        btnFind.Text = "SEARCH"
        btnFind.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(184, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 7
        Label4.Text = "Search"
        ' 
        ' dgvRecord
        ' 
        dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecord.Location = New Point(44, 128)
        dgvRecord.Name = "dgvRecord"
        dgvRecord.RowTemplate.Height = 25
        dgvRecord.Size = New Size(949, 416)
        dgvRecord.TabIndex = 8
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(833, 573)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(160, 38)
        btnBack.TabIndex = 9
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1045, 647)
        ControlBox = False
        Controls.Add(btnBack)
        Controls.Add(dgvRecord)
        Controls.Add(Label4)
        Controls.Add(btnFind)
        Controls.Add(txtData)
        Controls.Add(cmbType)
        Name = "Form2"
        Text = "Form2"
        CType(dgvRecord, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbType As ComboBox
    Friend WithEvents txtData As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvRecord As DataGridView
    Friend WithEvents btnBack As Button
End Class
