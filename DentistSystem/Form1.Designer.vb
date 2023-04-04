<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Visit - 01/04/2023")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Visit - 04/04/2023")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Naim Daoud", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Patients", New System.Windows.Forms.TreeNode() {TreeNode7})
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.treeViewPatient = New System.Windows.Forms.TreeView()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.treeViewPatient)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 494)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Browser"
        '
        'treeViewPatient
        '
        Me.treeViewPatient.Location = New System.Drawing.Point(25, 40)
        Me.treeViewPatient.Name = "treeViewPatient"
        TreeNode5.Name = "visit1"
        TreeNode5.Text = "Visit - 01/04/2023"
        TreeNode6.Name = "visit2"
        TreeNode6.Text = "Visit - 04/04/2023"
        TreeNode7.Name = "patient1"
        TreeNode7.Text = "Naim Daoud"
        TreeNode8.Name = "Patients"
        TreeNode8.Text = "Patients"
        Me.treeViewPatient.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8})
        Me.treeViewPatient.Size = New System.Drawing.Size(291, 423)
        Me.treeViewPatient.TabIndex = 0
        '
        'panelMain
        '
        Me.panelMain.Location = New System.Drawing.Point(410, 21)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(635, 558)
        Me.panelMain.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 591)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Patient Management System"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents treeViewPatient As TreeView
    Friend WithEvents panelMain As Panel
End Class
