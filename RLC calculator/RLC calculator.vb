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
            MsgBox(InputTextBox.Text.ToString("c"))
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles AnswersLabel.Click

    End Sub
End Class
