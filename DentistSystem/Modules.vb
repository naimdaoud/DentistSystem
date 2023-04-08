Imports MongoDB.Bson
Imports MongoDB.Driver
Module Modules
    Public Sub ToggleForm(panel As Form)
        MainForm.panelMain.Controls.Clear()
        panel.TopLevel = False
        MainForm.panelMain.Controls.Add(panel)
        panel.Show()
        MainForm.panelMain.Show()
    End Sub
    Public Sub ShowAddForm(panel As Form)
        Dim saveButton As New Button()
        Dim cancel As New Button()
        saveButton.Text = "Save"
        saveButton.Name = "Save"
        saveButton.Left = 200
        saveButton.Top = 300
        cancel.Text = "Cancel"
        cancel.Name = "Cancel"
        cancel.Left = 350
        cancel.Top = 300
        MainForm.panelMain.Controls.Clear()
        panel.TopLevel = False
        MainForm.panelMain.Controls.Add(panel)
        panel.Controls.Add(saveButton)
        panel.Controls.Add(cancel)
        panel.Show()
        MainForm.panelMain.Show()
    End Sub
    Public Sub FillTreeNode(ByVal patients As List(Of BsonDocument))
        ' Loop through the documents and add them to a TreeView control
        Dim nodePatient As TreeNode = Nothing
        Dim nodeVisit As TreeNode = Nothing
        For Each patient In patients
            nodePatient = New TreeNode(patient("name").ToString)
            nodePatient.Name = patient("_id").ToString
            MainForm.treeView.TopNode.Nodes.Add(nodePatient)
        Next
    End Sub
    Public Sub AddVisitToTreeNode(ByVal node As TreeNode, ByVal database As IMongoDatabase)
        Dim nodeVisit As TreeNode = Nothing
        Dim visits = getPatientVisits(database, node.Name)
        For Each visit In visits
            If node.Nodes.Count() < visits.Count() Then
                nodeVisit = New TreeNode("Visit" + visit("number").ToString + " - " + visit("date").ToString)
                nodeVisit.Name = visit("_id").ToString
                node.Nodes.Add(nodeVisit)
            End If
        Next
    End Sub
    Public Sub FillPatientInformation(ByVal node As TreeNode, ByVal database As IMongoDatabase)
        Dim patientInfo = getPatientInformation(node.Name, database)
        Patient.textBoxPatientName.Text = patientInfo("name").ToString
        Patient.textBoxPhoneNumber.Text = patientInfo("mobileNumber").ToString
        Patient.dateTimePickerDateOfBirth.Text = patientInfo("dateOfBirth")
        Patient.richTextBoxCaseDescription.Text = patientInfo("caseDescription").ToString
    End Sub
    Public Sub FillVisitInformation(ByVal node As TreeNode, ByVal database As IMongoDatabase)
        Dim visitInfo = getVisitInformation(node.Name, database)
        Visit.textBoxAmountPaid.Text = visitInfo("amountPaid").ToString
        Visit.textBoxVisitNumber.Text = visitInfo("number").ToString
        Visit.dateTimePickerVisitDate.Text = visitInfo("date")
        Visit.richTextBoxNotes.Text = visitInfo("notes").ToString
        Visit.textBoxVisitType.Text = visitInfo("visitType").ToString
    End Sub
End Module
