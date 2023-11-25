﻿Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbConnection.dbConnection()
        loadRecord()

    End Sub

    Private Sub dgvRecord_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRecord.CellFormatting
        Dim values As New List(Of String)
        If dgvRecord.Columns(e.ColumnIndex).Index = 2 Then
            If e.Value <> "" Then
                e.Value = " ***** "
                e.FormattingApplied = True
            End If
        End If
    End Sub

    Private Sub dgvRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecord.CellContentClick
        Dim uname, pass, uid As String

        If e.RowIndex >= 0 Then
            If e.ColumnIndex = dgvRecord.Columns("UpdateButton").Index Then
                uid = dgvRecord.CurrentRow.Cells(0).Value.ToString()
                uname = dgvRecord.CurrentRow.Cells(1).Value.ToString()
                pass = dgvRecord.CurrentRow.Cells(2).Value.ToString()

                Dim result As DialogResult = MessageBox.Show("Do you really want to update the record?", "CONFIRMATION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    dbConnection.RecordUpdate(e.RowIndex, uname, pass)
                End If


            Else
                Dim result As DialogResult = MessageBox.Show("Do you really want to delete the record?", "CONFIRMATION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    dbConnection.RecordDelete(e.RowIndex)
                End If

            End If
        End If

    End Sub
End Class