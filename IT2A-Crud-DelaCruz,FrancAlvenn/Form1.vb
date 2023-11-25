Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Tls

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection.dbConnection()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtUserName.Enabled = False
        txtpassword.Enabled = False

        btnPrint.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsertInto()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dispose()
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dbConnection.SearchRec()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to update the record?", "CONFIRMATION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            updateRecord(txtUID.Text, txtUserName.Text, txtpassword.Text)
        Else
            MessageBox.Show("Update cancelled by the user")
            txtUID.Clear()
            txtUserName.Clear()
            txtPass.Clear()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to delete the record?", "CONFIRMATION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            deleteRecord(txtUID.Text)
        Else
            MessageBox.Show("Delete cancelled by the user")
            txtUID.Clear()
            txtUserName.Clear()
            txtPass.Clear()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Form5.Show()
    End Sub


End Class
