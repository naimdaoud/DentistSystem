<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Patients")
        Me.treeViewMain = New System.Windows.Forms.TreeView()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.buttonAddPatient = New System.Windows.Forms.Button()
        Me.buttonAddVisit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'treeViewMain
        '
        Me.treeViewMain.Location = New System.Drawing.Point(9, 78)
        Me.treeViewMain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.treeViewMain.Name = "treeViewMain"
        TreeNode1.Name = "Patients"
        TreeNode1.Text = "Patients"
        Me.treeViewMain.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.treeViewMain.Size = New System.Drawing.Size(176, 348)
        Me.treeViewMain.TabIndex = 0
        '
        'panelMain
        '
        Me.panelMain.Location = New System.Drawing.Point(204, 52)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(614, 409)
        Me.panelMain.TabIndex = 1
        '
        'buttonAddPatient
        '
        Me.buttonAddPatient.Location = New System.Drawing.Point(9, 10)
        Me.buttonAddPatient.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.buttonAddPatient.Name = "buttonAddPatient"
        Me.buttonAddPatient.Size = New System.Drawing.Size(82, 19)
        Me.buttonAddPatient.TabIndex = 2
        Me.buttonAddPatient.Text = "Add Patient"
        Me.buttonAddPatient.UseVisualStyleBackColor = True
        '
        'buttonAddVisit
        '
        Me.buttonAddVisit.Location = New System.Drawing.Point(9, 45)
        Me.buttonAddVisit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.buttonAddVisit.Name = "buttonAddVisit"
        Me.buttonAddVisit.Size = New System.Drawing.Size(82, 19)
        Me.buttonAddVisit.TabIndex = 3
        Me.buttonAddVisit.Text = "Add Visit"
        Me.buttonAddVisit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 470)
        Me.Controls.Add(Me.buttonAddVisit)
        Me.Controls.Add(Me.buttonAddPatient)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.treeViewMain)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents treeViewMain As Windows.Forms.TreeView
    Friend WithEvents panelMain As Panel
    Friend WithEvents buttonAddPatient As Button
    Friend WithEvents buttonAddVisit As Button
End Class
