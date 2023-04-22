<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visit
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
        Me.textBoxVisitNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateTimePickerVisitDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textBoxAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textBoxVisitType = New System.Windows.Forms.TextBox()
        Me.richTextBoxNotes = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textBoxPatientId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'textBoxVisitNumber
        '
        Me.textBoxVisitNumber.Location = New System.Drawing.Point(154, 41)
        Me.textBoxVisitNumber.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.textBoxVisitNumber.Name = "textBoxVisitNumber"
        Me.textBoxVisitNumber.Size = New System.Drawing.Size(76, 20)
        Me.textBoxVisitNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Visit Number"
        '
        'dateTimePickerVisitDate
        '
        Me.dateTimePickerVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTimePickerVisitDate.Location = New System.Drawing.Point(154, 102)
        Me.dateTimePickerVisitDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dateTimePickerVisitDate.Name = "dateTimePickerVisitDate"
        Me.dateTimePickerVisitDate.Size = New System.Drawing.Size(151, 20)
        Me.dateTimePickerVisitDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Visit Date"
        '
        'textBoxAmountPaid
        '
        Me.textBoxAmountPaid.Location = New System.Drawing.Point(154, 167)
        Me.textBoxAmountPaid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.textBoxAmountPaid.Name = "textBoxAmountPaid"
        Me.textBoxAmountPaid.Size = New System.Drawing.Size(76, 20)
        Me.textBoxAmountPaid.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Amount Paid"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Visit Type"
        '
        'textBoxVisitType
        '
        Me.textBoxVisitType.Location = New System.Drawing.Point(154, 218)
        Me.textBoxVisitType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.textBoxVisitType.Name = "textBoxVisitType"
        Me.textBoxVisitType.Size = New System.Drawing.Size(76, 20)
        Me.textBoxVisitType.TabIndex = 6
        '
        'richTextBoxNotes
        '
        Me.richTextBoxNotes.Location = New System.Drawing.Point(433, 102)
        Me.richTextBoxNotes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.richTextBoxNotes.Name = "richTextBoxNotes"
        Me.richTextBoxNotes.Size = New System.Drawing.Size(151, 79)
        Me.richTextBoxNotes.TabIndex = 10
        Me.richTextBoxNotes.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Notes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(326, 41)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Patient ID"
        '
        'textBoxPatientId
        '
        Me.textBoxPatientId.Location = New System.Drawing.Point(433, 41)
        Me.textBoxPatientId.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxPatientId.Name = "textBoxPatientId"
        Me.textBoxPatientId.Size = New System.Drawing.Size(76, 20)
        Me.textBoxPatientId.TabIndex = 11
        '
        'Visit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.textBoxPatientId)
        Me.Controls.Add(Me.richTextBoxNotes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.textBoxVisitType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textBoxAmountPaid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dateTimePickerVisitDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textBoxVisitNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Visit"
        Me.Text = "v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textBoxVisitNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dateTimePickerVisitDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents textBoxAmountPaid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents textBoxVisitType As TextBox
    Friend WithEvents richTextBoxNotes As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents textBoxPatientId As TextBox
End Class
