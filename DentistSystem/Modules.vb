Imports MongoDB.Bson
Imports MongoDB.Driver
Module Modules
    Dim database As IMongoDatabase = MongoConnect("mongodb://localhost", "PMS")
    Public Sub ToggleForm(panel As Form)
        MainForm.panelMain.Controls.Clear()
        panel.TopLevel = False
        MainForm.panelMain.Controls.Add(panel)
        panel.Show()
        MainForm.panelMain.Show()
    End Sub
    Sub EventHandlerAddPatient()
        MongoDB.addPatient(database, Patient.textBoxPatientName.Text, Patient.textBoxPhoneNumber.Text, Patient.dateTimePickerDateOfBirth.Text, Patient.richTextBoxCaseDescription.Text)
        Dim patients = getCollection(database, "Patients")
        RefreshTreeNode(patients)
        MainForm.panelMain.Hide()
    End Sub
    Sub EventHandlerCancelAddPatient()
        Patient.Hide()
    End Sub
    Sub EventHandlerAddVisit()
        MongoDB.addVisit(database, Visit.textBoxVisitNumber.Text, Visit.dateTimePickerVisitDate.Text, Visit.textBoxVisitType.Text, Visit.textBoxPatientId.Text, Visit.textBoxAmountPaid.Text, Visit.richTextBoxNotes.Text)
        Dim nodeVisit = New TreeNode("Visit" + Visit.textBoxVisitNumber.Text + " - " + Visit.dateTimePickerVisitDate.Text)
        nodeVisit.Name = Visit.textBoxPatientId.Text
        MainForm.treeViewMain.SelectedNode.Nodes.Add(nodeVisit)
        MainForm.panelMain.Hide()
    End Sub
    Sub EventHandlerCancelAddVisit()
        Visit.Hide()
    End Sub
    Public Sub ShowAddPatientForm()
        Dim saveButton As New Button()
        Dim cancelButton As New Button()
        saveButton.Text = "Save"
        saveButton.Name = "Save"
        saveButton.Left = 200
        saveButton.Top = 300
        cancelButton.Text = "Cancel"
        cancelButton.Name = "Cancel"
        cancelButton.Left = 350
        cancelButton.Top = 300
        AddHandler saveButton.Click, AddressOf EventHandlerAddPatient
        AddHandler cancelButton.Click, AddressOf EventHandlerCancelAddPatient
        'AddHandler cancelButton.Click,
        MainForm.panelMain.Controls.Clear()
        Patient.TopLevel = False
        MainForm.panelMain.Controls.Add(Patient)
        Patient.Controls.Add(saveButton)
        Patient.Controls.Add(cancelButton)
        Patient.textBoxPatientName.Clear()
        Patient.textBoxPhoneNumber.Clear()
        Patient.richTextBoxCaseDescription.Clear()
        Patient.Show()
        MainForm.panelMain.Show()
    End Sub
    Public Sub ShowAddVisitForm(ByVal patientId As String)
        Dim saveButton As New Button()
        Dim cancelButton As New Button()
        saveButton.Text = "Save"
        saveButton.Name = "Save"
        saveButton.Left = 200
        saveButton.Top = 300
        cancelButton.Text = "Cancel"
        cancelButton.Name = "Cancel"
        cancelButton.Left = 350
        cancelButton.Top = 300
        AddHandler saveButton.Click, AddressOf EventHandlerAddVisit
        AddHandler cancelButton.Click, AddressOf EventHandlerCancelAddVisit
        'AddHandler cancelButton.Click,
        MainForm.panelMain.Controls.Clear()
        Visit.TopLevel = False
        MainForm.panelMain.Controls.Add(Visit)
        Visit.Controls.Add(saveButton)
        Visit.Controls.Add(cancelButton)
        Visit.textBoxPatientId.Text = patientId
        Visit.textBoxAmountPaid.Clear()
        Visit.textBoxVisitNumber.Clear()
        Visit.textBoxVisitType.Clear()
        Visit.richTextBoxNotes.Clear()
        Visit.Show()
        MainForm.panelMain.Show()
    End Sub
    Public Sub FillTreeNode(ByVal patients As List(Of BsonDocument))
        ' Loop through the documents and add them to a TreeView control
        Dim nodePatient As TreeNode = Nothing
        Dim nodeVisit As TreeNode = Nothing
        For Each patient In patients
            nodePatient = New TreeNode(patient("name").ToString)
            nodePatient.Name = patient("_id").ToString
            MainForm.treeViewMain.TopNode.Nodes.Add(nodePatient)
        Next
    End Sub
    Public Sub RefreshTreeNode(ByVal patients As List(Of BsonDocument))
        MainForm.treeViewMain.TopNode.Nodes.Clear()
        FillTreeNode(patients)
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
        Visit.textBoxPatientId.Text = visitInfo("patientId").ToString
    End Sub
End Module
