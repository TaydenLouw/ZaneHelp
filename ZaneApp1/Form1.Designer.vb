<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lengthInput = New System.Windows.Forms.ComboBox()
        Me.widthInput = New System.Windows.Forms.ComboBox()
        Me.heightInput = New System.Windows.Forms.ComboBox()
        Me.coverageInput = New System.Windows.Forms.ComboBox()
        Me.rollOutput = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lengthInput
        '
        Me.lengthInput.FormattingEnabled = True
        Me.lengthInput.Location = New System.Drawing.Point(132, 9)
        Me.lengthInput.Name = "lengthInput"
        Me.lengthInput.Size = New System.Drawing.Size(121, 21)
        Me.lengthInput.TabIndex = 0
        '
        'widthInput
        '
        Me.widthInput.FormattingEnabled = True
        Me.widthInput.Location = New System.Drawing.Point(132, 47)
        Me.widthInput.Name = "widthInput"
        Me.widthInput.Size = New System.Drawing.Size(121, 21)
        Me.widthInput.TabIndex = 1
        '
        'heightInput
        '
        Me.heightInput.FormattingEnabled = True
        Me.heightInput.Location = New System.Drawing.Point(132, 85)
        Me.heightInput.Name = "heightInput"
        Me.heightInput.Size = New System.Drawing.Size(121, 21)
        Me.heightInput.TabIndex = 2
        '
        'coverageInput
        '
        Me.coverageInput.FormattingEnabled = True
        Me.coverageInput.Location = New System.Drawing.Point(132, 123)
        Me.coverageInput.Name = "coverageInput"
        Me.coverageInput.Size = New System.Drawing.Size(121, 21)
        Me.coverageInput.TabIndex = 3
        '
        'rollOutput
        '
        Me.rollOutput.Location = New System.Drawing.Point(294, 25)
        Me.rollOutput.Name = "rollOutput"
        Me.rollOutput.Size = New System.Drawing.Size(156, 20)
        Me.rollOutput.TabIndex = 4
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(294, 47)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 5
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(375, 47)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 6
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Lenght (feet):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Width (feet):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Height (feet):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Roll coverage (sqrFt):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(291, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Single Roll"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 160)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.rollOutput)
        Me.Controls.Add(Me.coverageInput)
        Me.Controls.Add(Me.heightInput)
        Me.Controls.Add(Me.widthInput)
        Me.Controls.Add(Me.lengthInput)
        Me.Name = "Form1"
        Me.Text = "Wallpaper App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lengthInput As ComboBox
    Friend WithEvents widthInput As ComboBox
    Friend WithEvents heightInput As ComboBox
    Friend WithEvents coverageInput As ComboBox
    Friend WithEvents rollOutput As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
