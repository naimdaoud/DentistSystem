Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeViewPatient.AfterSelect
        Dim selectedNode = treeViewPatient.SelectedNode
        Dim regexPatientName As New Regex("patient\d")
        Dim regexVisit As New Regex("visit\d")
        Dim matchPatientName = regexPatientName.Match(selectedNode.Name)
        Dim matchVisit = regexVisit.Match(selectedNode.Name)
        If selectedNode.Name = "Patients" Then
            panelMain.Hide()
        ElseIf matchPatientName.Success Then
            ToggleForm(Patient)
            Patient.textBoxPatientName.Text = treeViewPatient.SelectedNode.Name
        ElseIf matchVisit.Success Then
            ToggleForm(Visit)
            Visit.textBoxVisitNumber.Text = treeViewPatient.SelectedNode.Name
        End If

    End Sub

    Sub ToggleForm(panel As Form)
        panelMain.Controls.Clear()
        panel.TopLevel = False
        panelMain.Controls.Add(panel)
        panel.Show()
        panelMain.Show()
    End Sub

End Class
