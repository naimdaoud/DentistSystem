Imports MongoDB.Driver

Public Class MainForm
    Dim database As IMongoDatabase = MongoConnect("mongodb://localhost", "PMS")
    Private Sub treeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeViewMain.AfterSelect
        Dim selectedNode = treeViewMain.SelectedNode
        If selectedNode.Name = "Patients" Then
            buttonDelete.Enabled = False
            panelMain.Hide()
            buttonAddVisit.Enabled = False
        ElseIf selectedNode.ToString.Contains("Visit") = False Then
            buttonDelete.Enabled = True
            buttonAddVisit.Enabled = True
            ToggleForm(Patient)
            AddVisitToTreeNode(selectedNode, database)
            FillPatientInformation(selectedNode, database)
            selectedNode.Expand()
        ElseIf selectedNode.ToString.Contains("Visit") Then
            buttonDelete.Enabled = True
            buttonAddVisit.Enabled = False
            ToggleForm(Visit)
            FillVisitInformation(selectedNode, database)
        End If

    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim patients = MongoDB.getCollection(database, "Patients")
        Modules.FillTreeNode(patients)
    End Sub

    Private Sub buttonAddPatient_Click(sender As Object, e As EventArgs) Handles buttonAddPatient.Click
        ShowAddPatientForm()
    End Sub

    Private Sub buttonAddVisit_Click(sender As Object, e As EventArgs) Handles buttonAddVisit.Click
        Dim selectedNode = treeViewMain.SelectedNode
        If selectedNode Is Nothing Or selectedNode.ToString.Contains("Visit") Or selectedNode.ToString.Contains("Patients") Then
            MsgBox("Please select a patient to add visit!")
        Else
            ShowAddVisitForm(selectedNode.Name)
        End If
    End Sub

    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        Dim selectedNode = treeViewMain.SelectedNode
        If selectedNode.Name = "Patients" Then
            MsgBox("Cannot delete root")
        ElseIf selectedNode.ToString.Contains("Visit") = False Then
            deletePatient(database, selectedNode.Name)
            For Each node In selectedNode.Nodes
                deleteVisit(database, node.Name)
            Next
            selectedNode.Remove()
        ElseIf selectedNode.ToString.Contains("Visit") Then
            deleteVisit(database, selectedNode.Name)
            selectedNode.Remove()
        End If
    End Sub
End Class