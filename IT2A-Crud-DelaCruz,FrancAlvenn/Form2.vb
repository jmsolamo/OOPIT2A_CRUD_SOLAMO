Public Class Form2
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection.dbConnection()
        LoadUserType()
        With dgvRecord
            .AllowUserToDeleteRows = False
            .AllowUserToAddRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowsDefaultCellStyle.BackColor = Color.AliceBlue
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        End With

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'FindRecord(txtData.Text, cmbType.SelectedIndex)

        If cmbType.SelectedIndex = 0 Then
            FindRecord(txtData.Text, "Adviser")
        ElseIf cmbType.SelectedIndex = 1 Then
            FindRecord(txtData.Text, "Enlistment Officer")
        ElseIf cmbType.SelectedIndex = 2 Then
            FindRecord(txtData.Text, "Finance Officer")
        End If
    End Sub

    Private Sub dgvRecord_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRecord.CellFormatting
        If dgvRecord.Columns(e.ColumnIndex).Index = 2 Then
            If e.Value <> "" Then
                e.Value = ";-;"
                e.FormattingApplied = True
            End If
        End If
    End Sub
End Class