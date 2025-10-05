Public Class Form1
    Private Sub SourceVoltageTrackBar_Scroll(sender As Object, e As EventArgs) Handles SourceVoltageTrackBar.Scroll
        SourceVoltageTrackBar.Minimum = 0 'Sets minimum input voltage
        SourceVoltageTrackBar.Maximum = 10 'Sets maximum input voltage
        SourceVoltageTextBox.Text = SourceVoltageTrackBar.Value.ToString() & " Vp"

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

    Private Sub SourceFrequencyTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SourceFrequencyTextBox.KeyPress
        ' Allow only digits (0-9) and control characters (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Suppress the key press
        End If
    End Sub

    Private Sub SourceFrequencyTextBox_TextChanged(sender As Object, e As EventArgs) Handles SourceFrequencyTextBox.TextChanged
        Dim filteredText As String = String.Empty
        For Each c As Char In SourceFrequencyTextBox.Text
            If Char.IsDigit(c) Then
                filteredText += c
            End If
        Next

        ' Update the TextBox only if non-digits were present
        If filteredText <> SourceFrequencyTextBox.Text Then
            SourceFrequencyTextBox.Text = filteredText
        End If

        ' Mirror the filtered text to the test TextBox
        TestTextBox.Text = SourceFrequencyTextBox.Text

        ' Validate the numeric range
        Dim frequencyValue As Integer
        Const MIN_VALUE As Integer = 1
        Const MAX_VALUE As Integer = 1000000

        ' Only check the range if the textbox is not empty
        If Integer.TryParse(SourceFrequencyTextBox.Text, frequencyValue) Then
            If frequencyValue < MIN_VALUE Or frequencyValue > MAX_VALUE Then
                ' Show a warning message to the user
                MessageBox.Show($"The input value must be between {MIN_VALUE} and {MAX_VALUE}.{vbCrLf}Please correct your entry.",
                                "Input Out of Range",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)

                ' Optional: Clear the textbox or revert to a valid value after the warning
                ' SourceFrequencyTextBox.Text = "" 
            End If
        End If
    End Sub



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear any design-time items first, if necessary
        SourceResistanceComboBox.Items.Clear()

        ' Add the required source resistance values
        SourceResistanceComboBox.Items.Add("50 Ω")
        SourceResistanceComboBox.Items.Add("400 Ω")

        ' Combo box For standard/common values (e.g., 1, 2.2, 4.7, 10, 22, 47, 100).

        'R1 values
        ResistanceComboBox.Items.Add("1 Ω")
        ResistanceComboBox.Items.Add("2.2 Ω")
        ResistanceComboBox.Items.Add("4.7 Ω")
        ResistanceComboBox.Items.Add("10 Ω")
        ResistanceComboBox.Items.Add("22 Ω")
        ResistanceComboBox.Items.Add("47 Ω")
        ResistanceComboBox.Items.Add("100 Ω")

        'L1 values
        InductanceComboBox.Items.Add("1 H")
        InductanceComboBox.Items.Add("2.2 H")
        InductanceComboBox.Items.Add("4.7 H")
        InductanceComboBox.Items.Add("10 H")
        InductanceComboBox.Items.Add("22 H")
        InductanceComboBox.Items.Add("47 H")
        InductanceComboBox.Items.Add("100 H")

        'C1 values
        Capacitor1ComboBox.Items.Add("1 F")
        Capacitor1ComboBox.Items.Add("2.2 F")
        Capacitor1ComboBox.Items.Add("4.7 F")
        Capacitor1ComboBox.Items.Add("10 F")
        Capacitor1ComboBox.Items.Add("22 F")
        Capacitor1ComboBox.Items.Add("47 F")
        Capacitor1ComboBox.Items.Add("100 F")

        'C2 values
        Capacitor2ComboBox.Items.Add("1 F")
        Capacitor2ComboBox.Items.Add("2.2 F")
        Capacitor2ComboBox.Items.Add("4.7 F")
        Capacitor2ComboBox.Items.Add("10 F")
        Capacitor2ComboBox.Items.Add("22 F")
        Capacitor2ComboBox.Items.Add("47 F")
        Capacitor2ComboBox.Items.Add("100 F")

        ' Optional: Select a default item
        SourceResistanceComboBox.SelectedIndex = 0
        ResistanceComboBox.SelectedIndex = 0
        InductanceComboBox.SelectedIndex = 0
        Capacitor1ComboBox.SelectedIndex = 0
        Capacitor2ComboBox.SelectedIndex = 0
    End Sub

    Private Sub ResistanceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ResistanceComboBox.SelectedIndexChanged

    End Sub

    Private Sub SourceResistanceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SourceResistanceComboBox.SelectedIndexChanged

    End Sub
End Class
