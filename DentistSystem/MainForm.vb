Imports System.Text.RegularExpressions

Public Class MainForm
    Private Sub treeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeView.AfterSelect
        Dim selectedNode = treeView.SelectedNode
        Dim regexPatientName As New Regex("patient\d")
        Dim regexVisit As New Regex("visit\d")
        Dim matchPatientName = regexPatientName.Match(selectedNode.Name)
        Dim matchVisit = regexVisit.Match(selectedNode.Name)
        If selectedNode.Name = "Patients" Then
            panelMain.Hide()
        ElseIf matchPatientName.Success Then
            ToggleForm(Patient)
            Patient.textBoxPatientName.Text = treeView.SelectedNode.Name
        ElseIf matchVisit.Success Then
            ToggleForm(Visit)
            Visit.textBoxVisitNumber.Text = treeView.SelectedNode.Name
        End If

    End Sub
    Sub ToggleForm(panel As Form)
        panelMain.Controls.Clear()
        panel.TopLevel = False
        panelMain.Controls.Add(panel)
        panel.Show()
        panelMain.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim database = MongoDB.MongoConnect("mongodb://localhost", "PMS")
        Dim patients = MongoDB.getPatients(database, "Patients")
        Dim visits = MongoDB.getVisits(database, "Visits")
        Modules.FillTreeNode(patients, visits)
    End Sub
End Class