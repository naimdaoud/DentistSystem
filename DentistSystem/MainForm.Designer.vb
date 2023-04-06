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
        Me.treeView = New System.Windows.Forms.TreeView()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'treeView
        '
        Me.treeView.Location = New System.Drawing.Point(12, 96)
        Me.treeView.Name = "treeView"
        TreeNode1.Name = "Patients"
        TreeNode1.Text = "Patients"
        Me.treeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.treeView.Size = New System.Drawing.Size(233, 427)
        Me.treeView.TabIndex = 0
        '
        'panelMain
        '
        Me.panelMain.Location = New System.Drawing.Point(272, 12)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(819, 555)
        Me.panelMain.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 579)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.treeView)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents treeView As Windows.Forms.TreeView
    Friend WithEvents panelMain As Panel
End Class
