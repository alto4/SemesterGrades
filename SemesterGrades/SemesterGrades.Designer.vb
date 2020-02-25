<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterGrades
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
        Me.components = New System.ComponentModel.Container()
        Me.txtCourse1Percentage = New System.Windows.Forms.TextBox()
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.txtCourse2Percentage = New System.Windows.Forms.TextBox()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.txtCourse3Percentage = New System.Windows.Forms.TextBox()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.txtCourse4Percentage = New System.Windows.Forms.TextBox()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.txtCourse5Percentage = New System.Windows.Forms.TextBox()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.txtCourse6Percentage = New System.Windows.Forms.TextBox()
        Me.lblCourse7 = New System.Windows.Forms.Label()
        Me.txtCourse7Percentage = New System.Windows.Forms.TextBox()
        Me.ttpSemesterGrades = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblSemesterAverageOutput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCourse1Letter = New System.Windows.Forms.Label()
        Me.lblCourse2Letter = New System.Windows.Forms.Label()
        Me.lblCourse5Letter = New System.Windows.Forms.Label()
        Me.lblCourse4Letter = New System.Windows.Forms.Label()
        Me.lblCourse3Letter = New System.Windows.Forms.Label()
        Me.lblCourse6Letter = New System.Windows.Forms.Label()
        Me.lblCourse7Letter = New System.Windows.Forms.Label()
        Me.lblSemesterAverageLetter = New System.Windows.Forms.Label()
        Me.lblSemesterAveragePercent = New System.Windows.Forms.Label()
        Me.lblMessageOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCourse1Percentage
        '
        Me.txtCourse1Percentage.Location = New System.Drawing.Point(93, 13)
        Me.txtCourse1Percentage.Name = "txtCourse1Percentage"
        Me.txtCourse1Percentage.Size = New System.Drawing.Size(80, 20)
        Me.txtCourse1Percentage.TabIndex = 1
        Me.txtCourse1Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpSemesterGrades.SetToolTip(Me.txtCourse1Percentage, "Enter a percentage between 0 and 100 in this field to be converted to a letter gr" &
        "ade")
        '
        'lblCourse1
        '
        Me.lblCourse1.AutoSize = True
        Me.lblCourse1.Location = New System.Drawing.Point(18, 17)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse1.TabIndex = 0
        Me.lblCourse1.Text = "Course &1:"
        '
        'lblCourse2
        '
        Me.lblCourse2.AutoSize = True
        Me.lblCourse2.Location = New System.Drawing.Point(18, 49)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse2.TabIndex = 3
        Me.lblCourse2.Text = "Course &2:"
        '
        'txtCourse2Percentage
        '
        Me.txtCourse2Percentage.Location = New System.Drawing.Point(93, 45)
        Me.txtCourse2Percentage.Name = "txtCourse2Percentage"
        Me.txtCourse2Percentage.Size = New System.Drawing.Size(80, 20)
        Me.txtCourse2Percentage.TabIndex = 4
        Me.txtCourse2Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpSemesterGrades.SetToolTip(Me.txtCourse2Percentage, "Enter a percentage between 0 and 100 in this field to be converted to a letter gr" &
        "ade")
        '
        'lblCourse3
        '
        Me.lblCourse3.AutoSize = True
        Me.lblCourse3.Location = New System.Drawing.Point(18, 82)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse3.TabIndex = 6
        Me.lblCourse3.Text = "Course &3:"
        '
        'txtCourse3Percentage
        '
        Me.txtCourse3Percentage.Location = New System.Drawing.Point(93, 78)
        Me.txtCourse3Percentage.Name = "txtCourse3Percentage"
        Me.txtCourse3Percentage.Size = New System.Drawing.Size(80, 20)
        Me.txtCourse3Percentage.TabIndex = 7
        Me.txtCourse3Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpSemesterGrades.SetToolTip(Me.txtCourse3Percentage, "Enter a percentage between 0 and 100 in this field to be converted to a letter gr" &
        "ade")
        '
        'lblCourse4
        '
        Me.lblCourse4.AutoSize = True
        Me.lblCourse4.Location = New System.Drawing.Point(18, 115)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse4.TabIndex = 9
        Me.lblCourse4.Text = "Course &4:"
        '
        'txtCourse4Percentage
        '
        Me.txtCourse4Percentage.Location = New System.Drawing.Point(93, 111)
        Me.txtCourse4Percentage.Name = "txtCourse4Percentage"
        Me.txtCourse4Percentage.Size = New System.Drawing.Size(80, 20)
        Me.txtCourse4Percentage.TabIndex = 10
        Me.txtCourse4Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpSemesterGrades.SetToolTip(Me.txtCourse4Percentage, "Enter a percentage between 0 and 100 in this field to be converted to a letter gr" &
        "ade")
        '
        'lblCourse5
        '
        Me.lblCourse5.AutoSize = True
        Me.lblCourse5.Location = New System.Drawing.Point(18, 146)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse5.TabIndex = 12
        Me.lblCourse5.Text = "Course &5:"
        '
        'txtCourse5Percentage
        '
        Me.txtCourse5Percentage.Location = New System.Drawing.Point(93, 142)
        Me.txtCourse5Percentage.Name = "txtCourse5Percentage"
        Me.txtCourse5Percentage.Size = New System.Drawing.Size(80, 20)
        Me.txtCourse5Percentage.TabIndex = 13
        Me.txtCourse5Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpSemesterGrades.SetToolTip(Me.txtCourse5Percentage, "Enter a percentage between 0 and 100 in this field to be converted to a letter gr" &
        "ade")
        '
        'lblCourse6
        '
        Me.lblCourse6.AutoSize = True
        Me.lblCourse6.Location = New System.Drawing.Point(18, 177)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse6.TabIndex = 15
        Me.lblCourse6.Text = "Course &6:"
        '
        'txtCourse6Percentage
        '
        Me.txtCourse6Percentage.Location = New System.Drawing.Point(93, 173)
        Me.txtCourse6Percentage.Name = "txtCourse6Percentage"
        Me.txtCourse6Percentage.Size = New System.Drawing.Size(80, 20)
        Me.txtCourse6Percentage.TabIndex = 16
        Me.txtCourse6Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpSemesterGrades.SetToolTip(Me.txtCourse6Percentage, "Enter a percentage between 0 and 100 in this field to be converted to a letter gr" &
        "ade")
        '
        'lblCourse7
        '
        Me.lblCourse7.AutoSize = True
        Me.lblCourse7.Location = New System.Drawing.Point(18, 207)
        Me.lblCourse7.Name = "lblCourse7"
        Me.lblCourse7.Size = New System.Drawing.Size(52, 13)
        Me.lblCourse7.TabIndex = 18
        Me.lblCourse7.Text = "Course &7:"
        '
        'txtCourse7Percentage
        '
        Me.txtCourse7Percentage.Location = New System.Drawing.Point(93, 203)
        Me.txtCourse7Percentage.Name = "txtCourse7Percentage"
        Me.txtCourse7Percentage.Size = New System.Drawing.Size(80, 20)
        Me.txtCourse7Percentage.TabIndex = 19
        Me.txtCourse7Percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpSemesterGrades.SetToolTip(Me.txtCourse7Percentage, "Enter a percentage between 0 and 100 in this field to be converted to a letter gr" &
        "ade")
        '
        'lblSemesterAverageOutput
        '
        Me.lblSemesterAverageOutput.AutoSize = True
        Me.lblSemesterAverageOutput.Location = New System.Drawing.Point(18, 237)
        Me.lblSemesterAverageOutput.Name = "lblSemesterAverageOutput"
        Me.lblSemesterAverageOutput.Size = New System.Drawing.Size(54, 13)
        Me.lblSemesterAverageOutput.TabIndex = 21
        Me.lblSemesterAverageOutput.Text = "Semester:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(21, 421)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(79, 23)
        Me.btnCalculate.TabIndex = 25
        Me.btnCalculate.Text = "&Calculate"
        Me.ttpSemesterGrades.SetToolTip(Me.btnCalculate, "Click this button to calculate your semester grade based on all entries, which wi" &
        "ll be displayed as both a percentage, as well as a corresponding letter grade.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(108, 421)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(79, 23)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "&Reset"
        Me.ttpSemesterGrades.SetToolTip(Me.btnReset, "Click this button to reset all fields to their default state and clear any curren" &
        "t input. ")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(195, 421)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 23)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "E&xit"
        Me.ttpSemesterGrades.SetToolTip(Me.btnExit, "Click this button to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCourse1Letter
        '
        Me.lblCourse1Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse1Letter.Location = New System.Drawing.Point(196, 13)
        Me.lblCourse1Letter.Name = "lblCourse1Letter"
        Me.lblCourse1Letter.Size = New System.Drawing.Size(78, 20)
        Me.lblCourse1Letter.TabIndex = 2
        Me.lblCourse1Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpSemesterGrades.SetToolTip(Me.lblCourse1Letter, "This represents the letter grade level that you earned for this course, based on " &
        "your percent entry.")
        '
        'lblCourse2Letter
        '
        Me.lblCourse2Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse2Letter.Location = New System.Drawing.Point(196, 42)
        Me.lblCourse2Letter.Name = "lblCourse2Letter"
        Me.lblCourse2Letter.Size = New System.Drawing.Size(78, 20)
        Me.lblCourse2Letter.TabIndex = 5
        Me.lblCourse2Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpSemesterGrades.SetToolTip(Me.lblCourse2Letter, "This represents the letter grade level that you earned for this course, based on " &
        "your percent entry.")
        '
        'lblCourse5Letter
        '
        Me.lblCourse5Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse5Letter.Location = New System.Drawing.Point(195, 142)
        Me.lblCourse5Letter.Name = "lblCourse5Letter"
        Me.lblCourse5Letter.Size = New System.Drawing.Size(78, 20)
        Me.lblCourse5Letter.TabIndex = 14
        Me.lblCourse5Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpSemesterGrades.SetToolTip(Me.lblCourse5Letter, "This represents the letter grade level that you earned for this course, based on " &
        "your percent entry.")
        '
        'lblCourse4Letter
        '
        Me.lblCourse4Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse4Letter.Location = New System.Drawing.Point(195, 108)
        Me.lblCourse4Letter.Name = "lblCourse4Letter"
        Me.lblCourse4Letter.Size = New System.Drawing.Size(78, 20)
        Me.lblCourse4Letter.TabIndex = 11
        Me.lblCourse4Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpSemesterGrades.SetToolTip(Me.lblCourse4Letter, "This represents the letter grade level that you earned for this course, based on " &
        "your percent entry.")
        '
        'lblCourse3Letter
        '
        Me.lblCourse3Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse3Letter.Location = New System.Drawing.Point(195, 78)
        Me.lblCourse3Letter.Name = "lblCourse3Letter"
        Me.lblCourse3Letter.Size = New System.Drawing.Size(78, 20)
        Me.lblCourse3Letter.TabIndex = 8
        Me.lblCourse3Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpSemesterGrades.SetToolTip(Me.lblCourse3Letter, "This represents the letter grade level that you earned for this course, based on " &
        "your percent entry.")
        '
        'lblCourse6Letter
        '
        Me.lblCourse6Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse6Letter.Location = New System.Drawing.Point(195, 176)
        Me.lblCourse6Letter.Name = "lblCourse6Letter"
        Me.lblCourse6Letter.Size = New System.Drawing.Size(78, 20)
        Me.lblCourse6Letter.TabIndex = 17
        Me.lblCourse6Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpSemesterGrades.SetToolTip(Me.lblCourse6Letter, "This represents the letter grade level that you earned for this course, based on " &
        "your percent entry.")
        '
        'lblCourse7Letter
        '
        Me.lblCourse7Letter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse7Letter.Location = New System.Drawing.Point(195, 203)
        Me.lblCourse7Letter.Name = "lblCourse7Letter"
        Me.lblCourse7Letter.Size = New System.Drawing.Size(78, 20)
        Me.lblCourse7Letter.TabIndex = 20
        Me.lblCourse7Letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpSemesterGrades.SetToolTip(Me.lblCourse7Letter, "This represents the letter grade level that you earned for this course, based on " &
        "your percent entry.")
        '
        'lblSemesterAverageLetter
        '
        Me.lblSemesterAverageLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterAverageLetter.Location = New System.Drawing.Point(195, 233)
        Me.lblSemesterAverageLetter.Name = "lblSemesterAverageLetter"
        Me.lblSemesterAverageLetter.Size = New System.Drawing.Size(78, 20)
        Me.lblSemesterAverageLetter.TabIndex = 23
        Me.lblSemesterAverageLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpSemesterGrades.SetToolTip(Me.lblSemesterAverageLetter, "Upon pressing Calculate, or press Enter on your keyboard, this field will display" &
        " your semester average as a letter grade.")
        '
        'lblSemesterAveragePercent
        '
        Me.lblSemesterAveragePercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterAveragePercent.Location = New System.Drawing.Point(93, 230)
        Me.lblSemesterAveragePercent.Name = "lblSemesterAveragePercent"
        Me.lblSemesterAveragePercent.Size = New System.Drawing.Size(78, 20)
        Me.lblSemesterAveragePercent.TabIndex = 22
        Me.lblSemesterAveragePercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpSemesterGrades.SetToolTip(Me.lblSemesterAveragePercent, "Upon pressing Calculate, or press Enter on your keyboard, this field will display" &
        " your semester average as a percentage.")
        '
        'lblMessageOutput
        '
        Me.lblMessageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessageOutput.Location = New System.Drawing.Point(21, 267)
        Me.lblMessageOutput.Name = "lblMessageOutput"
        Me.lblMessageOutput.Size = New System.Drawing.Size(252, 140)
        Me.lblMessageOutput.TabIndex = 24
        Me.lblMessageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpSemesterGrades.SetToolTip(Me.lblMessageOutput, "This field will output error messages related to the values you entered above. ")
        '
        'frmSemesterGrades
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(299, 469)
        Me.Controls.Add(Me.lblMessageOutput)
        Me.Controls.Add(Me.lblSemesterAveragePercent)
        Me.Controls.Add(Me.lblSemesterAverageLetter)
        Me.Controls.Add(Me.lblCourse7Letter)
        Me.Controls.Add(Me.lblCourse6Letter)
        Me.Controls.Add(Me.lblCourse3Letter)
        Me.Controls.Add(Me.lblCourse4Letter)
        Me.Controls.Add(Me.lblCourse5Letter)
        Me.Controls.Add(Me.lblCourse2Letter)
        Me.Controls.Add(Me.lblCourse1Letter)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSemesterAverageOutput)
        Me.Controls.Add(Me.lblCourse7)
        Me.Controls.Add(Me.txtCourse7Percentage)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.txtCourse6Percentage)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.txtCourse5Percentage)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.txtCourse4Percentage)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.txtCourse3Percentage)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.txtCourse2Percentage)
        Me.Controls.Add(Me.lblCourse1)
        Me.Controls.Add(Me.txtCourse1Percentage)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ttpSemesterGrades.SetToolTip(Me, "This represents the letter grade level that you earned for this course, based on " &
        "your percent entry.")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCourse1Percentage As TextBox
    Friend WithEvents lblCourse1 As Label
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents txtCourse2Percentage As TextBox
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents txtCourse3Percentage As TextBox
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents txtCourse4Percentage As TextBox
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents txtCourse5Percentage As TextBox
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents txtCourse6Percentage As TextBox
    Friend WithEvents lblCourse7 As Label
    Friend WithEvents txtCourse7Percentage As TextBox
    Friend WithEvents ttpSemesterGrades As ToolTip
    Friend WithEvents lblSemesterAverageOutput As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCourse1Letter As Label
    Friend WithEvents lblCourse2Letter As Label
    Friend WithEvents lblCourse5Letter As Label
    Friend WithEvents lblCourse4Letter As Label
    Friend WithEvents lblCourse3Letter As Label
    Friend WithEvents lblCourse6Letter As Label
    Friend WithEvents lblCourse7Letter As Label
    Friend WithEvents lblSemesterAverageLetter As Label
    Friend WithEvents lblSemesterAveragePercent As Label
    Friend WithEvents lblMessageOutput As Label
End Class
