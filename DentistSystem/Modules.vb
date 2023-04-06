Imports MongoDB.Bson
Imports MongoDB.Driver
Module Modules
    Public Sub FillTreeNode(ByVal patients As List(Of BsonDocument), ByVal visits As List(Of BsonDocument))
        ' Loop through the documents and add them to a TreeView control
        Dim nodePatient As TreeNode = Nothing
        Dim nodeVisit As TreeNode = Nothing
        For Each patient In patients
            nodePatient = New TreeNode(patient("name").ToString)
            For Each visit In visits
                If visit("patient") = patient("name") Then
                    nodeVisit = New TreeNode(visit("date").ToString)
                    nodePatient.Nodes.Add(nodeVisit)
                End If
            Next
            MainForm.treeView.TopNode.Nodes.Add(nodePatient)
        Next
    End Sub

End Module
