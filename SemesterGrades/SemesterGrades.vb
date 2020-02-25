' Author:       Scott Alton
' Date:         February 9, 2020
' File Name:    SemesterGrades.vb
' Description:  This application takes in the grades for up to 7 courses as percentages from a user and
'               returns the corresponding letter grade for each course, calculates the semester average, 
'               and then outputs that semester average to the user. 
' References:   Many of the subprocedures and functions used in this program were adapted, and/or copied, from code developed by 
'               Professor Kyle Chapman of Durham College, and were supplied as part of "In-Class Exercise #2" for partial completion of the 
'               .NET Development I (NETD-2201) course at Durham College. The file referenced throughout the completion of the assignment was
'               "Temperature Tracker.vb", authored by Kyle Chapman starting on January 27, 2020, and last modified on February 6, 2020.  

Option Strict On

Public Class frmSemesterGrades

    ' Variable Declarations
    Dim inputTextboxList As TextBox()
    Dim outputLabelList As Label()

    Dim numberFilledTextboxes As Integer
    Dim totalPercent As Double = 0

    ' EVENT HANDLERS

    ''' <summary>
    ''' Event handler - when the form loads, insert input and output controls into respective arrays for increased efficiency within subprocedures 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmSemesterGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputTextboxList = {txtCourse1Percentage, txtCourse2Percentage, txtCourse3Percentage, txtCourse4Percentage, txtCourse5Percentage, txtCourse6Percentage, txtCourse7Percentage}
        outputLabelList = {lblCourse1Letter, lblCourse2Letter, lblCourse3Letter, lblCourse4Letter, lblCourse5Letter, lblCourse6Letter, lblCourse7Letter, lblSemesterAverageLetter, lblSemesterAveragePercent, lblMessageOutput}
    End Sub


    ''' <summary>
    ''' Event handler for Exit Button - close the application 
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    ''' <summary>
    ''' Event handler for Reset Button - clear all fields and set focus on Course 1 grade entry field
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
    End Sub

    ''' <summary>
    ''' Event handler for Calculate Button - calculate an average grade for all entered percentages, and return the 
    ''' semester average as both a percentage and as a letter grade upon click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Variable Declarations
        Dim semesterAveragePercent As Double

        ' Validate textboxes
        If ValidateTextboxes(inputTextboxList) Then

            lblMessageOutput.Text = String.Empty

            ' Once input passes validation, calculate and return the semesters average percent rounded to 2 decimal places
            ' This will consider only valid, and non-blank textboxes for the divisor's value
            semesterAveragePercent = Math.Round(totalPercent / numberFilledTextboxes, 2)

            ' Output Semester Average percentage and corresponding letter grade once calculated
            lblSemesterAveragePercent.Text = Convert.ToString(semesterAveragePercent)
            lblSemesterAverageLetter.Text = GetLetterGrade(semesterAveragePercent)

            ' Set input textboxes to ReadOnly status once calculate button has been pressed
            For Each textbox In inputTextboxList
                textbox.ReadOnly = True
            Next

            ' Disable Calculate button
            btnCalculate.Enabled = False

            ' Set focus on Reset button to enter another set of grades to process
            btnReset.Focus()

        End If

    End Sub


    ''' <summary>
    ''' When a textbox loses focus, validate entry as a number between 0 and 100, and then output letter grade classification using GetLetterGrade
    ''' function. If entries fail validation checks, return an error message to the user to correct input values specified. Otherwise, if textboxes
    ''' are left blank, do not display an error message, and also exclude the empty textboxes from any further processing. 
    ''' </summary>
    Private Sub TextboxLostFocus(sender As Object, e As EventArgs) Handles txtCourse1Percentage.LostFocus, txtCourse2Percentage.LostFocus,
        txtCourse3Percentage.LostFocus, txtCourse4Percentage.LostFocus, txtCourse5Percentage.LostFocus, txtCourse6Percentage.LostFocus,
        txtCourse1Percentage.LostFocus

        ' Loop through list of textboxes on the form
        For inputIndex As Integer = 0 To inputTextboxList.Length - 1

            Dim percent As Double = 0

            ' Check that textboxes content can be parsed as a double, or remain empty
            If Double.TryParse(inputTextboxList(inputIndex).Text, percent) Then

                ' If textbox has no inputted values, do not attempt to assign a letter grade or output an error message
                If inputTextboxList(inputIndex).ToString.Length = 0 Then
                    outputLabelList(inputIndex).Text = ""

                    ' Once inputted percentage is verified as a valid entry that is not an empty textbox, convert percentage to associated letter grade
                    ' and display this letter grade in the corresponding output field 
                Else
                    outputLabelList(inputIndex).Text = GetLetterGrade(percent)

                End If

            End If

        Next

    End Sub


    'PROCEDURES 

    ''' <summary>
    ''' This checks validity for all textboxes in the array that are passed in by ensuring only numeric entries between 0 - 100, or blank
    ''' fields are accepted. Only non-blank entries that are validated are used for processing percentages into letter grades
    ''' 
    ''' </summary>
    ''' <param name="textboxArray">Textbox to validate</param>
    Function ValidateTextboxes(textboxArray As TextBox()) As Boolean

        ' Variable declaration
        Dim isValid As Boolean = True

        ' For every textbox in textboxArray, use ValidateTextbox to check if it's valid
        For Each textboxToCheck As TextBox In textboxArray

            ' If they are ALL valid, return True, otherwise return false
            If ValidateTextbox(textboxToCheck) And textboxToCheck.Text.ToString.Length > 0 Then

                ' Add the number of textboxes filled with valid entries to the divisor variable that will be used to process an average percentage 
                numberFilledTextboxes += 1
                totalPercent += Convert.ToDouble(textboxToCheck.Text)

            End If

            isValid = isValid And ValidateTextbox(textboxToCheck)

        Next

        Return isValid

    End Function


    ''' <summary>
    ''' This function will validate a single textbox as being either a valid number between 0 and 100, or a blank field that will
    ''' also be deemed valid. If neither of these conditions are met, error messages will be displayed to the user to guide them towards
    ''' altering entries to be valid for processing
    ''' </summary>
    ''' <param name="txtInput"></param>
    ''' <returns></returns>
    Function ValidateTextbox(txtInput As TextBox) As Boolean

        ' Variable declaration
        Dim inputGrade As Double

        ' Check if textbox is empty, and if so return as valid 
        If Convert.ToString(txtInput.Text).Length = 0 Then
            Return True

        End If

        ' Check whether inputTextbox.text is a valid number
        If Double.TryParse(txtInput.Text, inputGrade) Then

            ' Check if inputGrade is within range of 0 - 100 
            If inputGrade >= 0 And inputGrade <= 100 Then
                Return True

            Else

                ' Display an error message requesting an entry between 0 and 100
                lblMessageOutput.Text = "Please enter a valid percentage between 0 and 100."
                txtInput.Focus()
                Return False

            End If

        Else

            ' Display an error message for the invalid entries and set focus to invalid fields for correction 
            lblMessageOutput.Text &= "The entered value of '" & txtInput.Text & "' is not valid. Please enter a numeric temperature." & vbCrLf
            txtInput.SelectAll()
            txtInput.Focus()

            ' If not valid, Return False
            Return False

        End If

    End Function


    ''' <summary>
    ''' Procedure that clears all input and output fields, as well as re-enables controls and counters to default state
    ''' </summary>
    Sub SetDefaults()

        ' Clear input and output fields
        ClearControls(inputTextboxList) ' Calls a procedure to empty all input textboxes
        ClearControls(outputLabelList) ' Calls a procedure to empty all output labels
        lblSemesterAverageOutput.Text = String.Empty
        lblMessageOutput.Text = String.Empty

        ' Return counter for validated input to be used in average calculation to 0
        numberFilledTextboxes = 0

        ' Reset total percent to 0
        totalPercent = 0

        ' Re-enable any controls that may be disabled
        SetTextboxesEnabled(inputTextboxList, True)
        btnCalculate.Enabled = True

        ' Set focus to Course 1 Percentage input field
        txtCourse1Percentage.Focus()

    End Sub

    ''' <summary>
    ''' Function LetterGrades - using Durham College's range of grades, loop through an array of grade thresholds to assign the corresponding letter
    ''' grade to a given percentage value. 
    ''' </summary>
    ''' <param name="percent"></param>
    ''' <returns></returns>
    Function GetLetterGrade(percent As Double) As String

        ' Variable Declarations
        Dim gradeThesholds As Double() = {0, 50, 55, 60, 65, 70, 75, 80, 85, 90}
        Dim gradeLetters As String() = {"F", "D", "D+", "C", "B-", "B", "B+", "A-", "A", "A+"}
        Dim gradeLetterOutput As String = String.Empty

        ' Loop through array of grade thesholds
        For gradeLevel As Integer = 0 To gradeThesholds.Length - 1

            ' When threshold is met, 
            If percent >= gradeThesholds(gradeLevel) Then
                gradeLetterOutput = gradeLetters(gradeLevel)

            End If

        Next

        Return gradeLetterOutput

    End Function

    ''' <summary>
    ''' Function ClearControls - This clears the text property of all controls in the array of controls that is passed in 
    ''' </summary>
    ''' <param name="controlArray">An array of controls with a text property to clear</param>
    Sub ClearControls(controlArray As Control())

        ' For every control in the list that is passed in, empty its Text property
        For Each controlToClear As Control In controlArray
            controlToClear.Text = String.Empty

        Next

    End Sub

    ''' <summary>
    ''' This enables all textboxes in the array that is passed in as an argument
    ''' </summary>
    ''' <param name="textboxArray">An array of textboxes to disable</param>
    ''' <param name="enabledStatus">Boolean: set textboxes to enabled?</param>
    Sub SetTextboxesEnabled(textboxArray As TextBox(), enabledStatus As Boolean)

        ' For every textbox in the list that is passed in, set its Enabled property to be true, and the Read only status to false 
        For Each textboxToSet As TextBox In textboxArray
            textboxToSet.Enabled = enabledStatus
            textboxToSet.ReadOnly = False
        Next

    End Sub

End Class
