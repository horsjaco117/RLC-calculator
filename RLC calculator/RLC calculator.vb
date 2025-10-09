Option Strict On
Option Explicit On

'Jacob Horsley
'4/26/2024
'RLC Calculator
'RCET 
'GITHUB:https://github.com/horsjaco117/RLC-calculator

'TODO: 
'-Concatenate prefixes to values
'-Eventually add polar to rectangular conversion
'-Fix the bug where you can type in combobox. That's a big no.
'Verify the winding resistance text box
'Update the micro to the actual micro symbol
'Add polar to rectangular conversion

Public Class Form1

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Validate the input exists and is a number
        If InputTextBox.Text <> "" AndAlso IsNumeric(InputTextBox.Text) Then
            ' Get the original numeric value as a Decimal (good for precision)
            Dim originalValue As Decimal
            If Decimal.TryParse(InputTextBox.Text, originalValue) Then

                ' Pass the numeric value directly to the function
                Dim resultEngineering As String = ToEngineeringNotation(originalValue)
                Dim resultMetricPrefix As String = ToMetricPrefix(originalValue)
                ' Update the TextBox with the final engineering notation result
                OutputTextBox.Text = resultEngineering
                MetricPrefixTextBox.Text = resultMetricPrefix
            Else
                ' Handle the case where the numeric parsing failed (shouldn't happen 
                ' if IsNumeric is true, but good practice)
                MessageBox.Show("Invalid number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Handle empty or non-numeric input
            MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Function ToEngineeringNotation(ByVal value As Decimal) As String
        If value = 0D Then Return "0.000E+00" ' Handle zero case explicitly

        ' Use Math.Log10 on the absolute value for the exponent calculation
        ' Convert to Double temporarily for Log10, as there is no Decimal overload
        Dim log10Value As Double = Math.Log10(CDbl(Math.Abs(value)))

        ' Calculate the exponent, ensuring it's the largest multiple of 3 less than log10Value
        ' The division by 3, floor, and multiplication by 3 achieves this.
        Dim exponent As Integer = CInt(Math.Floor(log10Value / 3)) * 3

        ' Calculate the mantissa
        ' Use Math.Pow on a Double base, then convert back to Decimal
        Dim powerOf10 As Decimal = CDec(Math.Pow(10, exponent))
        Dim mantissa As Decimal = value / powerOf10

        ' Format the result: Mantissa (3 decimal places) E Exponent (+ sign for positive)
        Return $"{mantissa:0.000}E{exponent:+00;-00;+00}"
    End Function

    Function ToMetricPrefix(ByVal value As Decimal) As String
        If value = 0D Then Return "0.000" ' Handle zero case explicitly
        ' Use Math.Log10 on the absolute value for the exponent calculation
        ' Convert to Double temporarily for Log10, as there is no Decimal overload
        Dim log10Value As Double = Math.Log10(CDbl(Math.Abs(value)))
        ' Calculate the exponent, ensuring it's the largest multiple of 3 less than log10Value
        ' The division by 3, floor, and multiplication by 3 achieves this.
        Dim exponent As Integer = CInt(Math.Floor(log10Value / 3)) * 3
        ' Calculate the mantissa
        ' Use Math.Pow on a Double base, then convert back to Decimal
        Dim powerOf10 As Decimal = CDec(Math.Pow(10, exponent))
        Dim mantissa As Decimal = value / powerOf10
        ' Format the result: Mantissa (3 decimal places)
        'Return $"{mantissa:0.000}"
        'Do loop for metric prefixes
        Dim prefixes As String() = {"small", "ph", "p", "n", "ɥ", "m", "k", "M", "G", "T"}
        Dim index As Integer = CInt(exponent / 3 + 6) ' Offset by 6 to center around "1"
        If index < 0 Then index = 0
        If index >= prefixes.Length Then index = prefixes.Length - 1
        Return $"{mantissa:0.000} {prefixes(index)}"
    End Function

    Sub DoMath()
        Dim real As Double = 1000, imaginary As Double = 1000, magnitude As Double, theta As Double

        magnitude = System.Math.Sqrt(real ^ 2 + imaginary ^ 2)
        theta = System.Math.Atan(imaginary / real) * (100 / System.Math.PI)
        imaginary = magnitude * System.Math.Sin((System.Math.PI / 100) * theta)
        real = magnitude * System.Math.Cos((System.Math.PI / 100) * theta)

        Console.Read()
    End Sub
    Private Sub SourceVoltageTrackBar_Scroll(sender As Object, e As EventArgs) Handles SourceVoltageTrackBar.Scroll
        SourceVoltageTrackBar.Minimum = 0 'Sets minimum input voltage
        SourceVoltageTrackBar.Maximum = 10 'Sets maximum input voltage
        SourceVoltageTextBox.Text = SourceVoltageTrackBar.Value.ToString() & " Vp"

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

    Private Sub WindingResistanceTextBox_TextChanged(sender As Object, e As EventArgs) Handles WindingResistanceTextBox.TextChanged
        Const MIN_VALUE As Integer = 0
        Const MAX_VALUE As Integer = 1000000
        Dim filteredText As String = String.Empty
        Dim currentValue As Integer

        ' 1. Filter out non-digit characters (keeping your existing logic)
        For Each c As Char In WindingResistanceTextBox.Text
            If Char.IsDigit(c) Then
                filteredText &= c
            End If
        Next

        ' 2. Check if the text was changed due to filtering, and reset cursor position
        If filteredText <> WindingResistanceTextBox.Text Then
            ' Save and restore cursor position to avoid jumping (see previous answer)
            Dim cursorPosition As Integer = WindingResistanceTextBox.SelectionStart
            WindingResistanceTextBox.Text = filteredText
            If cursorPosition > 0 Then
                WindingResistanceTextBox.SelectionStart = Math.Min(cursorPosition - 1, filteredText.Length)
            Else
                WindingResistanceTextBox.SelectionStart = 0
            End If
            ' Exit if text was just corrected, to prevent infinite loop
            Exit Sub
        End If

        ' 3. Perform the Min/Max validation on the filtered text
        If Integer.TryParse(WindingResistanceTextBox.Text, currentValue) Then
            If currentValue < MIN_VALUE Then
                ' If less than minimum, set it to the minimum value
                WindingResistanceTextBox.Text = MIN_VALUE.ToString()
                ' Place cursor at the end
                WindingResistanceTextBox.SelectionStart = WindingResistanceTextBox.Text.Length
            ElseIf currentValue > MAX_VALUE Then
                ' If greater than maximum, set it to the maximum value
                WindingResistanceTextBox.Text = MAX_VALUE.ToString()
                ' Place cursor at the end
                WindingResistanceTextBox.SelectionStart = WindingResistanceTextBox.Text.Length
            End If
        End If

        ' Note: If the text is empty, the TryParse will return False, 
        ' and the text box will remain empty.

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

        'Resistance prefixes
        ResistancePrefixComboBox.Items.Add("Ω")
        ResistancePrefixComboBox.Items.Add("KΩ")
        ResistancePrefixComboBox.Items.Add("MΩ")

        ' Inductance prefixes
        InductorPrefixComboBox.Items.Add("ɥH")
        InductorPrefixComboBox.Items.Add("mH")

        ' Capacitance1 prefixes
        Cap1PrefixComboBox.Items.Add("pF")
        Cap1PrefixComboBox.Items.Add("uF")

        'Capacitance2 prefixes
        Cap2PrefixComboBox.Items.Add("pF")
        Cap2PrefixComboBox.Items.Add("uF")

        'Default items for comboboxes
        SourceResistanceComboBox.SelectedIndex = 0
        ResistanceComboBox.SelectedIndex = 0
        InductanceComboBox.SelectedIndex = 0
        Capacitor1ComboBox.SelectedIndex = 0
        Capacitor2ComboBox.SelectedIndex = 0
        ResistancePrefixComboBox.SelectedIndex = 0
        InductorPrefixComboBox.SelectedIndex = 0
        Cap1PrefixComboBox.SelectedIndex = 0
        Cap2PrefixComboBox.SelectedIndex = 0



    End Sub



End Class
