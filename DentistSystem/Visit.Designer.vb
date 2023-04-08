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
        Me.SuspendLayout()
        '
        'textBoxVisitNumber
        '
        Me.textBoxVisitNumber.Location = New System.Drawing.Point(205, 51)
        Me.textBoxVisitNumber.Name = "textBoxVisitNumber"
        Me.textBoxVisitNumber.Size = New System.Drawing.Size(100, 22)
        Me.textBoxVisitNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Visit Number"
        '
        'dateTimePickerVisitDate
        '
        Me.dateTimePickerVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTimePickerVisitDate.Location = New System.Drawing.Point(205, 126)
        Me.dateTimePickerVisitDate.Name = "dateTimePickerVisitDate"
        Me.dateTimePickerVisitDate.Size = New System.Drawing.Size(200, 22)
        Me.dateTimePickerVisitDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Visit Date"
        '
        'textBoxAmountPaid
        '
        Me.textBoxAmountPaid.Location = New System.Drawing.Point(205, 205)
        Me.textBoxAmountPaid.Name = "textBoxAmountPaid"
        Me.textBoxAmountPaid.Size = New System.Drawing.Size(100, 22)
        Me.textBoxAmountPaid.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Amount Paid"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Visit Type"
        '
        'textBoxVisitType
        '
        Me.textBoxVisitType.Location = New System.Drawing.Point(205, 268)
        Me.textBoxVisitType.Name = "textBoxVisitType"
        Me.textBoxVisitType.Size = New System.Drawing.Size(100, 22)
        Me.textBoxVisitType.TabIndex = 6
        '
        'richTextBoxNotes
        '
        Me.richTextBoxNotes.Location = New System.Drawing.Point(205, 314)
        Me.richTextBoxNotes.Name = "richTextBoxNotes"
        Me.richTextBoxNotes.Size = New System.Drawing.Size(200, 96)
        Me.richTextBoxNotes.TabIndex = 10
        Me.richTextBoxNotes.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Notes"
        '
        'Visit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
