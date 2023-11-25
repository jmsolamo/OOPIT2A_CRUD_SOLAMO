Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form5


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim crystalDoc As New ReportDocument
        crystalDoc.Load("C:\Users\ITLAB-16\source\repos\IT2A-Crud-DelaCruz,FrancAlvenn\IT2A-Crud-DelaCruz,FrancAlvenn\IntParam.rpt")
        Dim pfDefinition As ParameterFieldDefinition
        Dim pfDefinitions As ParameterFieldDefinitions

        Dim pVal As New ParameterValues
        Dim pDVal As New ParameterDiscreteValue

        pDVal.Value = Convert.ToInt32(Form1.txtUID.Text)

        pfDefinitions = crystalDoc.DataDefinition.ParameterFields
        pfDefinition = pfDefinitions.Item("userid")
        pVal = pfDefinition.CurrentValues
    End Sub
End Class