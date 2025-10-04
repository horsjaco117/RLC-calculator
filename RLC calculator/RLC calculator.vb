Public Class Form1
    Private Sub SourceVoltageTrackBar_Scroll(sender As Object, e As EventArgs) Handles SourceVoltageTrackBar.Scroll

    End Sub

    Private Sub R1Label_Click(sender As Object, e As EventArgs) Handles R1Label.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If InputTextBox.Text <> "" And IsNumeric(InputTextBox.Text) Then
            'get text from textbox1 and format as scientific notation using ToString method
            InputTextBox.Text = CDec(InputTextBox.Text).ToString("0.00E+00")
            'split this text and then turn them into engineering notation
            'test if the exponent thing is divisible by 3
            'ensure that there are only a couple decimals doing things


        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles AnswersLabel.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles FormatLabel.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles PolarRadioButton.CheckedChanged

    End Sub
End Class
