Imports System.Math

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For index = 10 To 35 Step 0.5
            lengthInput.Items.Add(index.ToString())
            widthInput.Items.Add(index.ToString())
            heightInput.Items.Add(index.ToString())
        Next
        For index = 40 To 50 Step 0.5
            coverageInput.Items.Add(index.ToString())
        Next
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim length = Int(lengthInput.SelectedItem)
        Dim width = Int(widthInput.SelectedItem)
        Dim height = Int(heightInput.SelectedItem)
        Dim coverage = Int(coverageInput.SelectedItem)
        rollOutput.Text = calculateRolls(length, width, height, coverage).ToString()
    End Sub

    Private Function calculateRolls(length As Int32, width As Int32, height As Int32, coverage As Int32) As Int32
        Return Math.Ceiling((2 * (length * height) + 2 * (width * height)) / coverage)
    End Function

    Private Sub lengthInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lengthInput.SelectedIndexChanged
        rollOutput.Text = String.Empty
    End Sub

    Private Sub widthInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles widthInput.SelectedIndexChanged
        rollOutput.Text = String.Empty
    End Sub

    Private Sub heightInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles heightInput.SelectedIndexChanged
        rollOutput.Text = String.Empty
    End Sub

    Private Sub coverageInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coverageInput.SelectedIndexChanged
        rollOutput.Text = String.Empty
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        lengthInput.SelectedIndex = -1
        widthInput.SelectedIndex = -1
        heightInput.SelectedIndex = -1
        coverageInput.SelectedIndex = -1
        rollOutput.Text = String.Empty
    End Sub
End Class
