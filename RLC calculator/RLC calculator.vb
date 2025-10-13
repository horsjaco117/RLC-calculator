Option Strict On
Option Explicit On
Imports System.Xml.Schema
Imports System.Numerics

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
    Private UsePolarFormat As Boolean = True

    'Math functions-------------------------------------------------------------------------------------------
    Sub DoMath()
        Dim real As Double = 1000, imaginary As Double = 1000, magnitude As Double, theta As Double

        magnitude = System.Math.Sqrt(real ^ 2 + imaginary ^ 2)
        theta = System.Math.Atan(imaginary / real) * (100 / System.Math.PI)
        imaginary = magnitude * System.Math.Sin((System.Math.PI / 100) * theta)
        real = magnitude * System.Math.Cos((System.Math.PI / 100) * theta)

        Console.Read()
    End Sub

    Function CalculateComplexPower(ByVal V As Complex, ByVal I As Complex) As Complex
        ' S = |V| * |I| ∠ (Phase_V - Phase_I)

        Dim V_Mag As Double = V.Magnitude
        Dim I_Mag As Double = I.Magnitude
        Dim V_Phase As Double = V.Phase ' Angle in radians
        Dim I_Phase As Double = I.Phase ' Angle in radians

        Dim S_Mag As Double = V_Mag * I_Mag
        Dim S_Phase As Double = V_Phase - I_Phase

        ' Convert the polar result back to a Complex number (Rectangular form S = P + jQ)
        Dim RealPartP As Double = S_Mag * Math.Cos(S_Phase)
        Dim ImaginaryPartQ As Double = S_Mag * Math.Sin(S_Phase)

        Return New Complex(RealPartP, ImaginaryPartQ)
    End Function
    Function toCapacitiveReactance1(ByRef frequency As Decimal, ByRef capacitance As Decimal) As Decimal
        If capacitance <> 0D Then
            'calculate equation 1/((2
            Return 1 / (2D * CDec(Math.PI) * frequency * (capacitance * MetricToDecimal(Cap1PrefixComboBox.Text)))
        Else
            Return Decimal.MaxValue ' Handle division by zero if capacitance is zero
        End If
    End Function
    Function ToResistance(ByRef resistance As Decimal, ByRef prefix As String) As Decimal
        ' Convert the resistance value based on the selected prefix
        Return resistance * JustForResistance(prefix)
    End Function

    Function toCapacitiveReactance2(ByRef frequency As Decimal, ByRef capacitance As Decimal) As Decimal
        If capacitance <> 0D Then
            'calculate equation 1/((2
            Return 1 / (2D * CDec(Math.PI) * frequency * (capacitance * MetricToDecimal(Cap2PrefixComboBox.Text)))
        Else
            Return Decimal.MaxValue ' Handle division by zero if capacitance is zero
        End If
    End Function
    Function toInductiveReactance(ByRef frequency As Decimal, ByRef inductance As Decimal) As Decimal
        If inductance <> 0D Then
            'calculate equation 2 * pi * f * L
            Return 2D * CDec(Math.PI) * frequency * (inductance * JustForInductance(InductorPrefixComboBox.Text))
        Else
            Return Decimal.MaxValue ' Handle division by zero if capacitance is zero
        End If
    End Function

    Function JustForInductance(ByVal prefix As String) As Decimal 'Because the inductance is being weird
        Dim cleanPrefix As String = prefix.ToLower().Trim()
        Debug.WriteLine("Inductance Prefix: " & cleanPrefix) ' Debug output to verify prefix
        Select Case cleanPrefix
            Case "µh" : Return 1D / 1000000D ' 10^-6 (Micro)
            Case "mh" : Return 1D / 1000D ' 10^-3 (Milli)
            Case Else ' Default to H (Henry) for no prefix or an unknown one
                Debug.WriteLine("Unknown prefix, defaulting to H")
                Return 1D
        End Select
    End Function

    Function JustForResistance(ByVal prefix As String) As Decimal 'Because the inductance is being weird
        Dim cleanPrefix As String = prefix.ToLower().Trim()
        Debug.WriteLine("Resistance Prefix: " & prefix) ' Debug output to verify prefix
        Select Case prefix
            Case "Ω" : Return 1D * 1D ' 10^0 (Ohm)
            Case "KΩ" : Return 1D * 1000D ' 10^3 (Kilo)
            Case "MΩ" : Return 1D * 1000000D ' 10^6 (Mega)
            Case Else ' Default to H (Henry) for no prefix or an unknown one
                Debug.WriteLine("Unknown prefix, defaulting to H")
                Return 1D
        End Select
    End Function

    Function MetricToDecimal(ByVal prefix As String) As Decimal
        Select Case prefix.ToLower().Trim()
            Case "pf" : Return 1D / 1000000000000D ' 10^-12 (Pico)
            Case "nf" : Return 1D / 1000000000D ' 10^-9 (Nano)
            Case "µf" : Return 1D / 1000000D ' 10^-6 (Micro, note: you have "uF" in your code)
            Case "µh" : Return 1D / 1000000D ' 10^-6 
            Case "mf" : Return 1D / 1000D ' 10^-3 (Milli)
            Case "mh" : Return 1D / 1000D ' 10^-3 
            Case "Ω" : Return 1D * 1D ' 10^0 (Ohm)
            Case "kΩ" : Return 1D * 1000D ' 10^3 (Kilo)
            Case "mΩ" : Return 1D * 1000000D ' 10^6 (Mega)
            Case Else
                Return 1D
        End Select
    End Function
    Function ReplaceSymbol(ByVal text As String) As Decimal
        ' Remove common unit suffixes and leading/trailing spaces
        Dim cleanText As String = text.Replace(" Ω", "").Replace("Ω", "").Trim()

        Dim value As Decimal = 0D
        Decimal.TryParse(cleanText, value) ' Safely try to parse the numeric part
        Return value
    End Function
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
        Dim prefixes As String() = {"small", "ph", "p", "n", "ɥ", "m", "", "k", "M", "G", "T"}
        Dim index As Integer = CInt(exponent / 3 + 6) ' Offset by 6 to center around "1"
        If index < 0 Then index = 0
        If index >= prefixes.Length Then index = prefixes.Length - 1
        Return $"{mantissa:0.000} {prefixes(index)}"
    End Function

    'Event Handlers-------------------------------------------------------------------------------------------
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        ' --- 1. GET MAGNITUDE INPUTS ---
        Dim frequency As Decimal = CDec(SourceFrequencyTextBox.Text)
        Dim Vsource_Mag As Double = CDbl(SourceVoltageTrackBar.Value)

        Dim R1_Mag As Decimal = ToResistance(CDec(ResistanceComboBox.Text), ResistancePrefixComboBox.Text)
        Dim XC1_Mag As Decimal = toCapacitiveReactance1(CDec(SourceFrequencyTextBox.Text), CDec(Capacitor1ComboBox.Text))
        Dim XC2_Mag As Decimal = toCapacitiveReactance2(CDec(SourceFrequencyTextBox.Text), CDec(Capacitor2ComboBox.Text))
        Dim XL1_Mag As Decimal = toInductiveReactance(CDec(SourceFrequencyTextBox.Text), CDec(InductanceComboBox.Text))

        ' NEW: Get Rgen (Source Resistance) and R_Winding values. Added too late :(
        Dim R_Gen_Mag As Decimal = ReplaceSymbol(SourceResistanceComboBox.Text)
        Dim R_Winding_Mag As Double = 0.0 ' Default to zero

        If Not Double.TryParse(WindingResistanceTextBox.Text, R_Winding_Mag) Then
            R_Winding_Mag = 0.0 ' Ensure a valid numeric value
        End If

        ' --- 2. COMPLEX IMPEDANCE CONVERSION ---

        ' Source/Generator Impedance (Rgen is in series with R1)
        Dim Z_Gen As Complex = New Complex(CDbl(R_Gen_Mag), 0)

        Dim Z_Source As Complex = New Complex(Vsource_Mag, 0)

        Dim Z_R1 As Complex = New Complex(CDbl(R1_Mag), 0)
        Dim Z_C1 As Complex = New Complex(0, -CDbl(XC1_Mag))
        Dim Z_C2 As Complex = New Complex(0, -CDbl(XC2_Mag))

        ' L1 IMPEDANCE: Includes the Winding Resistance (R_Winding)
        Dim Z_L1 As Complex = New Complex(R_Winding_Mag, CDbl(XL1_Mag))

        ' --- 3. LOAD IMPEDANCE (Z_Load) ---

        ' Zp = 1 / (1/Zc2 + 1/Zl1)
        Dim Z_Parallel_C2L1 As Complex = 1.0 / (1.0 / Z_C2 + 1.0 / Z_L1)

        ' Z_Load = Z_R1 + Z_C1 + Z_Parallel_C2L1 (All components EXCEPT Rgen)
        Dim Z_Load As Complex = Z_R1 + Z_C1 + Z_Parallel_C2L1

        ' --- 4. TOTAL CIRCUIT IMPEDANCE (ZTotal) ---

        ' ZTotal = Z_Gen + Z_Load (Rgen is in series with the whole load)
        Dim ZTotal As Complex = Z_Gen + Z_Load

        ' --- 5. TOTAL CURRENT (I_Total) ---
        ' I_Total = V_Source / ZTotal
        Dim I_Total As Complex = Z_Source / ZTotal

        ' --- 6. INDIVIDUAL VOLTAGES (V = I * Z) ---

        ' Voltage dropped across the source resistor
        Dim V_Gen As Complex = I_Total * Z_Gen

        ' Voltages across load components
        Dim V_R1 As Complex = I_Total * Z_R1
        Dim V_C1 As Complex = I_Total * Z_C1
        Dim V_Parallel As Complex = I_Total * Z_Parallel_C2L1

        ' Note: V_Parallel + V_C1 + V_R1 + V_Gen should equal Z_Source (Kirchhoff's Voltage Law)

        ' --- 7. INDIVIDUAL CURRENTS (Current Divider Rule) ---
        Dim I_R1 As Complex = I_Total
        Dim I_C1 As Complex = I_Total
        Dim I_C2 As Complex = I_Total * (Z_L1 / (Z_C2 + Z_L1))
        Dim I_L1 As Complex = I_Total * (Z_C2 / (Z_C2 + Z_L1))

        ' --- 8. POWER CALCULATIONS (S = V * I*) ---

        ' Total Power (Power supplied by the source)
        Dim S_Total As Complex = CalculateComplexPower(Z_Source, I_Total)

        ' Component Power
        Dim S_Gen As Complex = CalculateComplexPower(V_Gen, I_Total)
        Dim S_R1 As Complex = CalculateComplexPower(V_R1, I_R1)
        Dim S_C1 As Complex = CalculateComplexPower(V_C1, I_C1)
        Dim S_Parallel As Complex = CalculateComplexPower(V_Parallel, I_Total)

        ' Individual L1 Power (Note: This includes the winding resistance power)
        Dim V_L1 As Complex = V_Parallel ' L1 is in parallel with C2, so voltage is V_Parallel
        Dim S_L1 As Complex = CalculateComplexPower(V_L1, I_L1)


        ' Helper function to format complex numbers as Polar (Mag < Angle)
        Dim FormatPolar = Function(z As Complex) As String
                              Return $"{z.Magnitude.ToString("F3")} ∠ {(z.Phase * (180 / Math.PI)).ToString("F3")}°"
                          End Function

        ' Helper function to format complex numbers as Rectangular (Real + j Imaginary)
        Dim FormatRectangular = Function(z As Complex) As String
                                    Return $"{z.Real.ToString("F3")} + j{z.Imaginary.ToString("F3")}"
                                End Function

        ' NEW: Function to return the correct format based on the radio button state
        Dim FormatComplex = Function(z As Complex) As String
                                If UsePolarFormat Then
                                    Return FormatPolar(z)
                                Else
                                    Return FormatRectangular(z)
                                End If
                            End Function
        ' --------------------------------------------------------------------------
        ' LIST BOX OUTPUT

        AnswersListBox.Items.Clear()

        ' --- Fixed Order ---
        AnswersListBox.Items.Add("--- TOTAL CIRCUIT VALUES ---")
        AnswersListBox.Items.Add("Z_Total: " & FormatComplex(ZTotal) & " Ω") ' Using Z_Circuit as Z_Total
        AnswersListBox.Items.Add("I_Total (Source Current): " & FormatComplex(I_Total) & " A")
        AnswersListBox.Items.Add("Z_Parallel (C2/L1): " & FormatComplex(Z_Parallel_C2L1) & " Ω")

        '--- Component Values (Inputs) ---
        AnswersListBox.Items.Add("=================================")
        AnswersListBox.Items.Add("--- COMPONENT INPUTS ---")
        AnswersListBox.Items.Add("Source R (Rgen): " & SourceResistanceComboBox.Text)
        AnswersListBox.Items.Add("R1: " & ResistanceComboBox.Text & ResistancePrefixComboBox.Text)
        AnswersListBox.Items.Add("C1: " & Capacitor1ComboBox.Text & Cap1PrefixComboBox.Text)
        AnswersListBox.Items.Add("C2: " & Capacitor2ComboBox.Text & Cap2PrefixComboBox.Text)
        AnswersListBox.Items.Add("L1: " & InductanceComboBox.Text & InductorPrefixComboBox.Text)
        AnswersListBox.Items.Add("L1 Winding R: " & R_Winding_Mag.ToString("F3") & " Ω")

        AnswersListBox.Items.Add("=================================")
        AnswersListBox.Items.Add("R1 (Mag): " & R1_Mag.ToString("F3") & " Ω")
        AnswersListBox.Items.Add("XC1 (Mag): " & XC1_Mag.ToString("F3") & " Ω")
        AnswersListBox.Items.Add("XL1 (Mag): " & XL1_Mag.ToString("F3") & " Ω")

        ' --- VOLTAGES ---
        AnswersListBox.Items.Add("----------------Voltages-----------------")
        AnswersListBox.Items.Add("V_Source (Total): " & Vsource_Mag.ToString("F3") & " Vp @ 0°")
        AnswersListBox.Items.Add("Vgen (Source Drop): " & FormatComplex(V_Gen) & " V")
        AnswersListBox.Items.Add("VR1: " & FormatComplex(V_R1) & " V")
        AnswersListBox.Items.Add("VC1: " & FormatComplex(V_C1) & " V")
        AnswersListBox.Items.Add("V_Parallel (C2/L1): " & FormatComplex(V_Parallel) & " V")

        ' --- CURRENTS ---
        AnswersListBox.Items.Add("----------------Currents-----------------")
        AnswersListBox.Items.Add("IR1: " & FormatComplex(I_R1) & " A")
        AnswersListBox.Items.Add("IC1: " & FormatComplex(I_C1) & " A")
        AnswersListBox.Items.Add("IC2 (Branch): " & FormatComplex(I_C2) & " A")
        AnswersListBox.Items.Add("IL1 (Branch): " & FormatComplex(I_L1) & " A")

        ' --- POWER ---
        AnswersListBox.Items.Add("----------------Powers------------------")
        AnswersListBox.Items.Add("TOTAL SOURCE POWER (S_Total)")
        AnswersListBox.Items.Add($"  Apparent Power (S): {S_Total.Magnitude.ToString("F3")} VA")
        AnswersListBox.Items.Add($"  Real Power (P): {S_Total.Real.ToString("F3")} W")
        AnswersListBox.Items.Add($"  Reactive Power (Q): {S_Total.Imaginary.ToString("F3")} VAR")

        AnswersListBox.Items.Add("----------------Component Powers-----------------")
        AnswersListBox.Items.Add($"Rgen (P): {CalculateComplexPower(V_Gen, I_Total).Real.ToString("F3")} W")
        AnswersListBox.Items.Add($"R1 (P): {S_R1.Real.ToString("F3")} W")
        AnswersListBox.Items.Add($"C1 (Q): {S_C1.Imaginary.ToString("F3")} VAR")

        ' Parallel branch power (S_Parallel is the S for the entire parallel block)
        AnswersListBox.Items.Add($"Parallel Block (S): {S_Parallel.Magnitude.ToString("F3")} VA")
        AnswersListBox.Items.Add($"Parallel Block (P): {S_Parallel.Real.ToString("F3")} W")
        AnswersListBox.Items.Add($"Parallel Block (Q): {S_Parallel.Imaginary.ToString("F3")} VAR")
        AnswersListBox.Items.Add($"L1 Winding Loss (P): {S_L1.Real.ToString("F3")} W") ' P dissipated by L1's winding resistance
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

                ' Just in case: Clear the textbox or revert to a valid value after the warning
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear any design-time items first, if necessary
        'SourceResistanceComboBox.Items.Clear()
        AnswersListBox.Items.Clear()

        ' Add the required source resistance values
        SourceResistanceComboBox.Items.Add("50 Ω")
        SourceResistanceComboBox.Items.Add("400 Ω")

        ' Combo box For standard/common values (e.g., 1, 2.2, 4.7, 10, 22, 47, 100).

        'R1 values
        ResistanceComboBox.Items.Add("1")
        ResistanceComboBox.Items.Add("2.2")
        ResistanceComboBox.Items.Add("4.7")
        ResistanceComboBox.Items.Add("10")
        ResistanceComboBox.Items.Add("22")
        ResistanceComboBox.Items.Add("47")
        ResistanceComboBox.Items.Add("100")

        'L1 values
        InductanceComboBox.Items.Add("1")
        InductanceComboBox.Items.Add("2.2")
        InductanceComboBox.Items.Add("4.7")
        InductanceComboBox.Items.Add("10")
        InductanceComboBox.Items.Add("22")
        InductanceComboBox.Items.Add("47")
        InductanceComboBox.Items.Add("100")

        'C1 values
        Capacitor1ComboBox.Items.Add("1")
        Capacitor1ComboBox.Items.Add("2.2")
        Capacitor1ComboBox.Items.Add("4.7")
        Capacitor1ComboBox.Items.Add("10")
        Capacitor1ComboBox.Items.Add("22")
        Capacitor1ComboBox.Items.Add("47")
        Capacitor1ComboBox.Items.Add("100")

        'C2 values
        Capacitor2ComboBox.Items.Add("1")
        Capacitor2ComboBox.Items.Add("2.2")
        Capacitor2ComboBox.Items.Add("4.7")
        Capacitor2ComboBox.Items.Add("10")
        Capacitor2ComboBox.Items.Add("22")
        Capacitor2ComboBox.Items.Add("47")
        Capacitor2ComboBox.Items.Add("100")

        'Resistance prefixes
        ResistancePrefixComboBox.Items.Add("Ω")
        ResistancePrefixComboBox.Items.Add("KΩ")
        ResistancePrefixComboBox.Items.Add("MΩ")

        ' Inductance prefixes
        InductorPrefixComboBox.Items.Add("µH")
        InductorPrefixComboBox.Items.Add("mH")

        ' Capacitance1 prefixes
        Cap1PrefixComboBox.Items.Add("pF")
        Cap1PrefixComboBox.Items.Add("µF")

        'Capacitance2 prefixes
        Cap2PrefixComboBox.Items.Add("pF")
        Cap2PrefixComboBox.Items.Add("µF")

        'Default items for comboboxes
        SourceResistanceComboBox.SelectedIndex = 0
        ResistanceComboBox.SelectedIndex = 6
        InductanceComboBox.SelectedIndex = 3
        Capacitor1ComboBox.SelectedIndex = 0
        Capacitor2ComboBox.SelectedIndex = 0
        ResistancePrefixComboBox.SelectedIndex = 0
        InductorPrefixComboBox.SelectedIndex = 0
        Cap1PrefixComboBox.SelectedIndex = 1
        Cap2PrefixComboBox.SelectedIndex = 1



    End Sub

    Private Sub RectangularRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RectangularRadioButton1.CheckedChanged
        If RectangularRadioButton1.Checked Then
            UsePolarFormat = False
            ' Recalculate and update the output immediately when the format changes
            'CalculateButton_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub PolarRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PolarRadioButton.CheckedChanged
        If PolarRadioButton.Checked Then
            UsePolarFormat = True
            ' Recalculate and update the output immediately when the format changes
            'CalculateButton_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
