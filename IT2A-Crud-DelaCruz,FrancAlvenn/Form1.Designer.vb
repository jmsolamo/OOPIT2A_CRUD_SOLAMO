<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        btnClose = New Button()
        btnSave = New Button()
        txtpassword = New TextBox()
        txtuname = New TextBox()
        Label2 = New Label()
        Username = New Label()
        GroupBox2 = New GroupBox()
        btnUpdate = New Button()
        txtUID = New TextBox()
        Label4 = New Label()
        btnDelete = New Button()
        btnSearch = New Button()
        txtPass = New TextBox()
        txtUserName = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        btnFilter = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(txtpassword)
        GroupBox1.Controls.Add(txtuname)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Username)
        GroupBox1.Location = New Point(34, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(315, 382)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Insert"
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.Location = New Point(24, 301)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(270, 43)
        btnClose.TabIndex = 5
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.Location = New Point(24, 235)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(270, 43)
        btnSave.TabIndex = 4
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(96, 155)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.Size = New Size(198, 23)
        txtpassword.TabIndex = 3
        ' 
        ' txtuname
        ' 
        txtuname.Location = New Point(96, 100)
        txtuname.Name = "txtuname"
        txtuname.Size = New Size(198, 23)
        txtuname.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.Location = New Point(23, 103)
        Username.Name = "Username"
        Username.Size = New Size(60, 15)
        Username.TabIndex = 0
        Username.Text = "Username"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnUpdate)
        GroupBox2.Controls.Add(txtUID)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(btnDelete)
        GroupBox2.Controls.Add(btnSearch)
        GroupBox2.Controls.Add(txtPass)
        GroupBox2.Controls.Add(txtUserName)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(414, 35)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(315, 390)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Search"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.Location = New Point(172, 301)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(122, 43)
        btnUpdate.TabIndex = 8
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' txtUID
        ' 
        txtUID.Location = New Point(96, 76)
        txtUID.Name = "txtUID"
        txtUID.Size = New Size(198, 23)
        txtUID.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 6
        Label4.Text = "UserID"
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.Location = New Point(24, 301)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(131, 43)
        btnDelete.TabIndex = 5
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnSearch.Location = New Point(24, 235)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(270, 43)
        btnSearch.TabIndex = 4
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtPass
        ' 
        txtPass.Enabled = False
        txtPass.Location = New Point(96, 183)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(198, 23)
        txtPass.TabIndex = 3
        ' 
        ' txtUserName
        ' 
        txtUserName.Enabled = False
        txtUserName.Location = New Point(96, 128)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(198, 23)
        txtUserName.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 186)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 1
        Label1.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 0
        Label3.Text = "Username"
        ' 
        ' btnFilter
        ' 
        btnFilter.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        btnFilter.Location = New Point(279, 475)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(218, 54)
        btnFilter.TabIndex = 7
        btnFilter.Text = "FILTER DATA"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(767, 621)
        Controls.Add(btnFilter)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Username As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtuname As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnUpdate As Button
End Class
