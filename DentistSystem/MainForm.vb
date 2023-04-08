Imports MongoDB.Driver

Public Class MainForm
    Dim database As IMongoDatabase = MongoConnect("mongodb://localhost", "PMS")
    Private Sub treeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeView.AfterSelect
        Dim selectedNode = treeView.SelectedNode
        If selectedNode.Name = "Patients" Then
            panelMain.Hide()
        ElseIf selectedNode.ToString.Contains("Visit") = False Then
            ToggleForm(Patient)
            AddVisitToTreeNode(selectedNode, database)
            FillPatientInformation(selectedNode, database)
            selectedNode.Expand()
        ElseIf selectedNode.ToString.Contains("Visit") Then
            ToggleForm(Visit)
            FillVisitInformation(selectedNode, database)
        End If

    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim patients = MongoDB.getCollection(database, "Patients")
        Modules.FillTreeNode(patients)
    End Sub

    Private Sub buttonAddPatient_Click(sender As Object, e As EventArgs) Handles buttonAddPatient.Click
        ShowAddForm(Patient)
    End Sub
End Class