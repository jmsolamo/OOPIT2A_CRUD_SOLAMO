Imports Microsoft.SqlServer
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Diagnostics.Eventing
Imports System.Security.Cryptography

Module dbConnection
    Dim connection As MySqlConnection = New MySqlConnection()
    Dim strQuery, query As String
    Dim reader As MySqlDataReader
    Dim dbname, server, user, password As String
    Dim cmd As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dataTable As DataTable

    Dim dataSet As DataSet
    Public Sub SearchRec()

        Dim uid As String = Form1.txtUID.Text
        query = "SELECT * FROM tbluser WHERE userid = @userid"

        cmd = New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@userid", uid)
        Try
            reader = cmd.ExecuteReader
            If reader.Read Then
                Form1.txtUserName.Text = reader("uname").ToString
                Form1.txtPass.Text = reader("pass").ToString

                Form1.btnUpdate.Enabled = True
                Form1.btnDelete.Enabled = True
                Form1.txtUserName.Enabled = True
                Form1.txtpassword.Enabled = True

                Form1.btnPrint.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("NO RECORD FOUND!" + ex.Message, vbOK, "ERROR!")
        Finally
            reader.Close()
        End Try


    End Sub

    Public Sub InsertInto()
        Dim uname As String = Form1.txtuname.Text
        Dim pass As String = Form1.txtpassword.Text

        query = "Insert into tbluser(uname, pass) values (@uname, @pass)"

        cmd = New MySqlCommand(query, connection)

        cmd.Parameters.AddWithValue("@uname", uname)
        cmd.Parameters.AddWithValue("@pass", pass)

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Inserted!")
        Catch ex As Exception
            MsgBox("Error!" + ex.Message)
        Finally
            ClearData()
        End Try
    End Sub

    Public Sub ClearData()
        Form1.txtuname.Clear()
        Form1.txtpassword.Clear()
    End Sub

    Public Sub dbConnection()
        dbname = "it2aoop"
        server = "127.0.0.1"
        user = "root"
        password = "password"


        If Not connection Is Nothing Then
            connection.Close()
            'establish connection
            connection.ConnectionString = "Server = " & server & ";" &
                                          "User ID = " & user & ";" &
                                          "Password = " & password & ";" &
                                          "Database = " & dbname & ";"
            Try
                connection.Open()
                MsgBox("Connetion Succesful!", vbOK, "CONNECTION STATUS!")

            Catch ex As Exception
                MsgBox("Connetion Error!" + ex.Message, vbOK, "CONNECTION STATUS!")
            End Try

        End If

    End Sub



    Public Sub LoadUserType()
        query = "SELECT usertype FROM tbluser"

        Try
            cmd = New MySqlCommand(query, connection)
            reader = cmd.ExecuteReader

            'load the user type 
            While reader.Read
                Form2.cmbType.Items.Add(reader("usertype").ToString())
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub FindRecord(searchData As String, utype As String)
        Form2.dgvRecord.DataSource = Nothing


        query = "SELECT * FROM tbluser WHERE userid = @uid or uname = @username and usertype = @utype"

        adapter = New MySqlDataAdapter(query, connection)

        adapter.SelectCommand.Parameters.AddWithValue("@uid", searchData)
        adapter.SelectCommand.Parameters.AddWithValue("@username", searchData)
        adapter.SelectCommand.Parameters.AddWithValue("@utype", utype)


        Try
            adapter.Fill(dataTable)

            'display the record in data grid view

            Form2.dgvRecord.DataSource = dataTable

            Form2.dgvRecord.AutoResizeColumn(
                DataGridViewAutoSizeColumnMode.AllCells)
        Catch ex As Exception
            MsgBox(("Error: ") & ex.Message)
        Finally
            Form2.txtData.Clear()
        End Try


    End Sub

    Public Sub updateRecord(uid As String, uname As String, pass As String)
        query = "UPDATE tbluser SET uname = @uname, pass = @pass WHERE userid = @uid;"
        Try
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@uname", uname)
                cmd.Parameters.AddWithValue("@pass", pass)
                cmd.Parameters.AddWithValue("uid", uid)

                cmd.ExecuteNonQuery()

                MessageBox.Show("INFO: " & "RECORD UPDATED SUCCESFULLY!")

            End Using



        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            Form1.txtPass.Clear()
            Form1.txtUserName.Clear()
            Form1.txtUID.Clear()
            Form1.txtPass.Enabled = False
            Form1.txtUserName.Enabled = False

        End Try

    End Sub

    Public Sub deleteRecord(uid As String)
        query = "DELETE FROM tbluser WHERE userid = @uid;"
        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@uid", uid)

            cmd.ExecuteNonQuery()

            MessageBox.Show("ACCOUNT DELETED!")
        End Using
        Try

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            Form1.txtPass.Clear()
            Form1.txtUserName.Clear()
            Form1.txtUID.Clear()
            Form1.txtPass.Enabled = False
            Form1.txtUserName.Enabled = False
        End Try
    End Sub

    Public Sub loadRecord()
        Form3.dgvRecord.DataSource = Nothing

        Try
            query = "SELECT * FROM tbluser"
            adapter = New MySqlDataAdapter(query, connection)
            dataSet = New DataSet
            adapter.Fill(dataSet, "tbluser")
            Form3.dgvRecord.DataSource = dataSet.Tables("tbluser")

            Dim updateButton As New DataGridViewButtonColumn()
            updateButton.Name = "UpdateButton"
            updateButton.Text = "Update"
            updateButton.UseColumnTextForButtonValue = True

            Form3.dgvRecord.Columns.Add(updateButton)

            Dim deleteButton As New DataGridViewButtonColumn()
            deleteButton.Name = "DeleteButton"
            deleteButton.Text = "Delete"
            deleteButton.UseColumnTextForButtonValue = True

            Form3.dgvRecord.Columns.Add(deleteButton)

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub RecordUpdate(rowIndex As Integer, uname As String, pass As String)
        If rowIndex >= 0 Then
            Dim seletedRow = Form3.dgvRecord.Rows(rowIndex)

            Dim id As Integer = CInt(seletedRow.Cells("userid").Value)

            query = "UPDATE tbluser SET uname = @uname, pass = @pass WHERE userid = @uid;"

            connection.Open()

            Try
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@uname", uname)
                cmd.Parameters.AddWithValue("@pass", pass)
                cmd.Parameters.AddWithValue("uid", id)

                cmd.ExecuteNonQuery()

                MessageBox.Show("INFO: " & "RECORD UPDATED SUCCESFULLY!")



            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            Finally
                connection.Close()
            End Try

        End If
    End Sub

    Public Sub RecordDelete(rowIndex As Integer)
        If rowIndex >= 0 Then
            Dim seletedRow = Form3.dgvRecord.Rows(rowIndex)

            Dim id As Integer = CInt(seletedRow.Cells("userid").Value)

            query = "DELETE FROM tbluser WHERE userid = @uid;"

            connection.Open()

            Try
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("uid", id)

                cmd.ExecuteNonQuery()

                MessageBox.Show("INFO: " & "RECORD DELETED SUCCESFULLY!")



            Catch ex As Exception
                MessageBox.Show("Error:" & ex.Message)
            Finally
                connection.Close()
            End Try

        End If
    End Sub

End Module
