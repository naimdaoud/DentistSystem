<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBoxPatientName = New System.Windows.Forms.TextBox()
        Me.textBoxPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateTimePickerDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.richTextBoxCaseDescription = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Name"
        '
        'textBoxPatientName
        '
        Me.textBoxPatientName.Location = New System.Drawing.Point(217, 57)
        Me.textBoxPatientName.Name = "textBoxPatientName"
        Me.textBoxPatientName.Size = New System.Drawing.Size(100, 22)
        Me.textBoxPatientName.TabIndex = 1
        '
        'textBoxPhoneNumber
        '
        Me.textBoxPhoneNumber.Location = New System.Drawing.Point(217, 128)
        Me.textBoxPhoneNumber.Name = "textBoxPhoneNumber"
        Me.textBoxPhoneNumber.Size = New System.Drawing.Size(100, 22)
        Me.textBoxPhoneNumber.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Phone Number"
        '
        'dateTimePickerDateOfBirth
        '
        Me.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTimePickerDateOfBirth.Location = New System.Drawing.Point(217, 190)
        Me.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth"
        Me.dateTimePickerDateOfBirth.Size = New System.Drawing.Size(200, 22)
        Me.dateTimePickerDateOfBirth.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Case Description"
        '
        'richTextBoxCaseDescription
        '
        Me.richTextBoxCaseDescription.Location = New System.Drawing.Point(217, 267)
        Me.richTextBoxCaseDescription.Name = "richTextBoxCaseDescription"
        Me.richTextBoxCaseDescription.Size = New System.Drawing.Size(200, 96)
        Me.richTextBoxCaseDescription.TabIndex = 8
        Me.richTextBoxCaseDescription.Text = ""
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.richTextBoxCaseDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dateTimePickerDateOfBirth)
        Me.Controls.Add(Me.textBoxPhoneNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textBoxPatientName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Patient"
        Me.Text = "Patient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textBoxPatientName As TextBox
    Friend WithEvents textBoxPhoneNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dateTimePickerDateOfBirth As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents richTextBoxCaseDescription As RichTextBox
End Class
