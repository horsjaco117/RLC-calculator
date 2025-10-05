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
        Me.SourceVoltageTrackBar = New System.Windows.Forms.TrackBar()
        Me.AnswersListBox = New System.Windows.Forms.ListBox()
        Me.SourceFrequencyTextBox = New System.Windows.Forms.TextBox()
        Me.SourceVoltageLabel = New System.Windows.Forms.Label()
        Me.SourceFrequencyLabel = New System.Windows.Forms.Label()
        Me.SourceResistanceComboBox = New System.Windows.Forms.ComboBox()
        Me.SourceResistanceLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.InputLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.R1Label = New System.Windows.Forms.Label()
        Me.C1Label = New System.Windows.Forms.Label()
        Me.C2Label = New System.Windows.Forms.Label()
        Me.L1Label = New System.Windows.Forms.Label()
        Me.ResistanceComboBox = New System.Windows.Forms.ComboBox()
        Me.ResistancePrefixComboBox = New System.Windows.Forms.ComboBox()
        Me.InductanceComboBox = New System.Windows.Forms.ComboBox()
        Me.InductorPrefixComboBox = New System.Windows.Forms.ComboBox()
        Me.Capacitor1ComboBox = New System.Windows.Forms.ComboBox()
        Me.Cap1PrefixComboBox = New System.Windows.Forms.ComboBox()
        Me.Cap2PrefixComboBox = New System.Windows.Forms.ComboBox()
        Me.Capacitor2ComboBox = New System.Windows.Forms.ComboBox()
        Me.AnswersLabel = New System.Windows.Forms.Label()
        Me.WindingResistanceTextBox = New System.Windows.Forms.TextBox()
        Me.WindingResistanceLabel = New System.Windows.Forms.Label()
        Me.FormatGroupBox = New System.Windows.Forms.GroupBox()
        Me.PolarRadioButton = New System.Windows.Forms.RadioButton()
        Me.RectangularRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.FormatLabel = New System.Windows.Forms.Label()
        Me.SourceVoltageTextBox = New System.Windows.Forms.TextBox()
        Me.TestTextBox = New System.Windows.Forms.TextBox()
        CType(Me.SourceVoltageTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FormatGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SourceVoltageTrackBar
        '
        Me.SourceVoltageTrackBar.Location = New System.Drawing.Point(16, 303)
        Me.SourceVoltageTrackBar.Name = "SourceVoltageTrackBar"
        Me.SourceVoltageTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.SourceVoltageTrackBar.Size = New System.Drawing.Size(69, 160)
        Me.SourceVoltageTrackBar.TabIndex = 0
        '
        'AnswersListBox
        '
        Me.AnswersListBox.FormattingEnabled = True
        Me.AnswersListBox.ItemHeight = 20
        Me.AnswersListBox.Location = New System.Drawing.Point(547, 41)
        Me.AnswersListBox.Name = "AnswersListBox"
        Me.AnswersListBox.Size = New System.Drawing.Size(243, 404)
        Me.AnswersListBox.TabIndex = 1
        '
        'SourceFrequencyTextBox
        '
        Me.SourceFrequencyTextBox.Location = New System.Drawing.Point(12, 41)
        Me.SourceFrequencyTextBox.Name = "SourceFrequencyTextBox"
        Me.SourceFrequencyTextBox.Size = New System.Drawing.Size(100, 26)
        Me.SourceFrequencyTextBox.TabIndex = 2
        Me.SourceFrequencyTextBox.Text = "1 Hz"
        '
        'SourceVoltageLabel
        '
        Me.SourceVoltageLabel.AutoSize = True
        Me.SourceVoltageLabel.Location = New System.Drawing.Point(12, 280)
        Me.SourceVoltageLabel.Name = "SourceVoltageLabel"
        Me.SourceVoltageLabel.Size = New System.Drawing.Size(119, 20)
        Me.SourceVoltageLabel.TabIndex = 3
        Me.SourceVoltageLabel.Text = "Source Voltage"
        '
        'SourceFrequencyLabel
        '
        Me.SourceFrequencyLabel.AutoSize = True
        Me.SourceFrequencyLabel.Location = New System.Drawing.Point(8, 18)
        Me.SourceFrequencyLabel.Name = "SourceFrequencyLabel"
        Me.SourceFrequencyLabel.Size = New System.Drawing.Size(139, 20)
        Me.SourceFrequencyLabel.TabIndex = 4
        Me.SourceFrequencyLabel.Text = "Source Frequency"
        '
        'SourceResistanceComboBox
        '
        Me.SourceResistanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SourceResistanceComboBox.FormattingEnabled = True
        Me.SourceResistanceComboBox.Location = New System.Drawing.Point(12, 93)
        Me.SourceResistanceComboBox.Name = "SourceResistanceComboBox"
        Me.SourceResistanceComboBox.Size = New System.Drawing.Size(121, 28)
        Me.SourceResistanceComboBox.TabIndex = 5
        '
        'SourceResistanceLabel
        '
        Me.SourceResistanceLabel.AutoSize = True
        Me.SourceResistanceLabel.Location = New System.Drawing.Point(12, 70)
        Me.SourceResistanceLabel.Name = "SourceResistanceLabel"
        Me.SourceResistanceLabel.Size = New System.Drawing.Size(48, 20)
        Me.SourceResistanceLabel.TabIndex = 6
        Me.SourceResistanceLabel.Text = "Rgen"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OutputLabel)
        Me.GroupBox1.Controls.Add(Me.InputLabel)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.InputTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 522)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 322)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(26, 123)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(58, 20)
        Me.OutputLabel.TabIndex = 3
        Me.OutputLabel.Text = "Output"
        '
        'InputLabel
        '
        Me.InputLabel.AutoSize = True
        Me.InputLabel.Location = New System.Drawing.Point(26, 22)
        Me.InputLabel.Name = "InputLabel"
        Me.InputLabel.Size = New System.Drawing.Size(46, 20)
        Me.InputLabel.TabIndex = 2
        Me.InputLabel.Text = "Input"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(30, 146)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(659, 26)
        Me.TextBox1.TabIndex = 1
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(30, 50)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(659, 26)
        Me.InputTextBox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ExitButton)
        Me.GroupBox2.Controls.Add(Me.CalculateButton)
        Me.GroupBox2.Location = New System.Drawing.Point(892, 534)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(654, 310)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(352, 39)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(270, 217)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(56, 37)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(244, 219)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'R1Label
        '
        Me.R1Label.AutoSize = True
        Me.R1Label.Location = New System.Drawing.Point(12, 138)
        Me.R1Label.Name = "R1Label"
        Me.R1Label.Size = New System.Drawing.Size(75, 20)
        Me.R1Label.TabIndex = 9
        Me.R1Label.Text = "R1 Value"
        '
        'C1Label
        '
        Me.C1Label.AutoSize = True
        Me.C1Label.Location = New System.Drawing.Point(279, 18)
        Me.C1Label.Name = "C1Label"
        Me.C1Label.Size = New System.Drawing.Size(74, 20)
        Me.C1Label.TabIndex = 10
        Me.C1Label.Text = "C1 Value"
        '
        'C2Label
        '
        Me.C2Label.AutoSize = True
        Me.C2Label.Location = New System.Drawing.Point(279, 96)
        Me.C2Label.Name = "C2Label"
        Me.C2Label.Size = New System.Drawing.Size(74, 20)
        Me.C2Label.TabIndex = 11
        Me.C2Label.Text = "C2 Value"
        '
        'L1Label
        '
        Me.L1Label.AutoSize = True
        Me.L1Label.Location = New System.Drawing.Point(12, 207)
        Me.L1Label.Name = "L1Label"
        Me.L1Label.Size = New System.Drawing.Size(72, 20)
        Me.L1Label.TabIndex = 12
        Me.L1Label.Text = "L1 Value"
        '
        'ResistanceComboBox
        '
        Me.ResistanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ResistanceComboBox.FormattingEnabled = True
        Me.ResistanceComboBox.Location = New System.Drawing.Point(12, 161)
        Me.ResistanceComboBox.Name = "ResistanceComboBox"
        Me.ResistanceComboBox.Size = New System.Drawing.Size(121, 28)
        Me.ResistanceComboBox.TabIndex = 13
        '
        'ResistancePrefixComboBox
        '
        Me.ResistancePrefixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ResistancePrefixComboBox.FormattingEnabled = True
        Me.ResistancePrefixComboBox.Location = New System.Drawing.Point(149, 161)
        Me.ResistancePrefixComboBox.Name = "ResistancePrefixComboBox"
        Me.ResistancePrefixComboBox.Size = New System.Drawing.Size(74, 28)
        Me.ResistancePrefixComboBox.TabIndex = 14
        '
        'InductanceComboBox
        '
        Me.InductanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InductanceComboBox.FormattingEnabled = True
        Me.InductanceComboBox.Location = New System.Drawing.Point(16, 230)
        Me.InductanceComboBox.Name = "InductanceComboBox"
        Me.InductanceComboBox.Size = New System.Drawing.Size(121, 28)
        Me.InductanceComboBox.TabIndex = 15
        '
        'InductorPrefixComboBox
        '
        Me.InductorPrefixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InductorPrefixComboBox.FormattingEnabled = True
        Me.InductorPrefixComboBox.Location = New System.Drawing.Point(149, 230)
        Me.InductorPrefixComboBox.Name = "InductorPrefixComboBox"
        Me.InductorPrefixComboBox.Size = New System.Drawing.Size(74, 28)
        Me.InductorPrefixComboBox.TabIndex = 16
        '
        'Capacitor1ComboBox
        '
        Me.Capacitor1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Capacitor1ComboBox.FormattingEnabled = True
        Me.Capacitor1ComboBox.Location = New System.Drawing.Point(283, 41)
        Me.Capacitor1ComboBox.Name = "Capacitor1ComboBox"
        Me.Capacitor1ComboBox.Size = New System.Drawing.Size(121, 28)
        Me.Capacitor1ComboBox.TabIndex = 17
        '
        'Cap1PrefixComboBox
        '
        Me.Cap1PrefixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cap1PrefixComboBox.FormattingEnabled = True
        Me.Cap1PrefixComboBox.Location = New System.Drawing.Point(440, 41)
        Me.Cap1PrefixComboBox.Name = "Cap1PrefixComboBox"
        Me.Cap1PrefixComboBox.Size = New System.Drawing.Size(64, 28)
        Me.Cap1PrefixComboBox.TabIndex = 18
        '
        'Cap2PrefixComboBox
        '
        Me.Cap2PrefixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cap2PrefixComboBox.FormattingEnabled = True
        Me.Cap2PrefixComboBox.Location = New System.Drawing.Point(440, 130)
        Me.Cap2PrefixComboBox.Name = "Cap2PrefixComboBox"
        Me.Cap2PrefixComboBox.Size = New System.Drawing.Size(64, 28)
        Me.Cap2PrefixComboBox.TabIndex = 19
        '
        'Capacitor2ComboBox
        '
        Me.Capacitor2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Capacitor2ComboBox.FormattingEnabled = True
        Me.Capacitor2ComboBox.Location = New System.Drawing.Point(283, 130)
        Me.Capacitor2ComboBox.Name = "Capacitor2ComboBox"
        Me.Capacitor2ComboBox.Size = New System.Drawing.Size(121, 28)
        Me.Capacitor2ComboBox.TabIndex = 20
        '
        'AnswersLabel
        '
        Me.AnswersLabel.AutoSize = True
        Me.AnswersLabel.Location = New System.Drawing.Point(555, 18)
        Me.AnswersLabel.Name = "AnswersLabel"
        Me.AnswersLabel.Size = New System.Drawing.Size(70, 20)
        Me.AnswersLabel.TabIndex = 21
        Me.AnswersLabel.Text = "Answers"
        '
        'WindingResistanceTextBox
        '
        Me.WindingResistanceTextBox.Location = New System.Drawing.Point(283, 230)
        Me.WindingResistanceTextBox.Name = "WindingResistanceTextBox"
        Me.WindingResistanceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.WindingResistanceTextBox.TabIndex = 22
        '
        'WindingResistanceLabel
        '
        Me.WindingResistanceLabel.AutoSize = True
        Me.WindingResistanceLabel.Location = New System.Drawing.Point(279, 198)
        Me.WindingResistanceLabel.Name = "WindingResistanceLabel"
        Me.WindingResistanceLabel.Size = New System.Drawing.Size(150, 20)
        Me.WindingResistanceLabel.TabIndex = 23
        Me.WindingResistanceLabel.Text = "Winding Resistance"
        '
        'FormatGroupBox
        '
        Me.FormatGroupBox.Controls.Add(Me.PolarRadioButton)
        Me.FormatGroupBox.Controls.Add(Me.RectangularRadioButton1)
        Me.FormatGroupBox.Location = New System.Drawing.Point(283, 298)
        Me.FormatGroupBox.Name = "FormatGroupBox"
        Me.FormatGroupBox.Size = New System.Drawing.Size(221, 165)
        Me.FormatGroupBox.TabIndex = 24
        Me.FormatGroupBox.TabStop = False
        '
        'PolarRadioButton
        '
        Me.PolarRadioButton.AutoSize = True
        Me.PolarRadioButton.Location = New System.Drawing.Point(6, 95)
        Me.PolarRadioButton.Name = "PolarRadioButton"
        Me.PolarRadioButton.Size = New System.Drawing.Size(111, 24)
        Me.PolarRadioButton.TabIndex = 1
        Me.PolarRadioButton.TabStop = True
        Me.PolarRadioButton.Text = "Polar Form"
        Me.PolarRadioButton.UseVisualStyleBackColor = True
        '
        'RectangularRadioButton1
        '
        Me.RectangularRadioButton1.AutoSize = True
        Me.RectangularRadioButton1.Location = New System.Drawing.Point(6, 25)
        Me.RectangularRadioButton1.Name = "RectangularRadioButton1"
        Me.RectangularRadioButton1.Size = New System.Drawing.Size(162, 24)
        Me.RectangularRadioButton1.TabIndex = 0
        Me.RectangularRadioButton1.TabStop = True
        Me.RectangularRadioButton1.Text = "Rectangular Form"
        Me.RectangularRadioButton1.UseVisualStyleBackColor = True
        '
        'FormatLabel
        '
        Me.FormatLabel.AutoSize = True
        Me.FormatLabel.Location = New System.Drawing.Point(279, 275)
        Me.FormatLabel.Name = "FormatLabel"
        Me.FormatLabel.Size = New System.Drawing.Size(113, 20)
        Me.FormatLabel.TabIndex = 25
        Me.FormatLabel.Text = "Output Format"
        '
        'SourceVoltageTextBox
        '
        Me.SourceVoltageTextBox.Location = New System.Drawing.Point(56, 303)
        Me.SourceVoltageTextBox.Name = "SourceVoltageTextBox"
        Me.SourceVoltageTextBox.Size = New System.Drawing.Size(100, 26)
        Me.SourceVoltageTextBox.TabIndex = 26
        Me.SourceVoltageTextBox.Text = "0 Vp"
        '
        'TestTextBox
        '
        Me.TestTextBox.Location = New System.Drawing.Point(149, 41)
        Me.TestTextBox.Name = "TestTextBox"
        Me.TestTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TestTextBox.TabIndex = 27
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1660, 1085)
        Me.Controls.Add(Me.TestTextBox)
        Me.Controls.Add(Me.SourceVoltageTextBox)
        Me.Controls.Add(Me.FormatLabel)
        Me.Controls.Add(Me.FormatGroupBox)
        Me.Controls.Add(Me.WindingResistanceLabel)
        Me.Controls.Add(Me.WindingResistanceTextBox)
        Me.Controls.Add(Me.AnswersLabel)
        Me.Controls.Add(Me.Capacitor2ComboBox)
        Me.Controls.Add(Me.Cap2PrefixComboBox)
        Me.Controls.Add(Me.Cap1PrefixComboBox)
        Me.Controls.Add(Me.Capacitor1ComboBox)
        Me.Controls.Add(Me.InductorPrefixComboBox)
        Me.Controls.Add(Me.InductanceComboBox)
        Me.Controls.Add(Me.ResistancePrefixComboBox)
        Me.Controls.Add(Me.ResistanceComboBox)
        Me.Controls.Add(Me.L1Label)
        Me.Controls.Add(Me.C2Label)
        Me.Controls.Add(Me.C1Label)
        Me.Controls.Add(Me.R1Label)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SourceResistanceLabel)
        Me.Controls.Add(Me.SourceResistanceComboBox)
        Me.Controls.Add(Me.SourceFrequencyLabel)
        Me.Controls.Add(Me.SourceVoltageLabel)
        Me.Controls.Add(Me.SourceFrequencyTextBox)
        Me.Controls.Add(Me.AnswersListBox)
        Me.Controls.Add(Me.SourceVoltageTrackBar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SourceVoltageTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.FormatGroupBox.ResumeLayout(False)
        Me.FormatGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SourceVoltageTrackBar As TrackBar
    Friend WithEvents AnswersListBox As ListBox
    Friend WithEvents SourceFrequencyTextBox As TextBox
    Friend WithEvents SourceVoltageLabel As Label
    Friend WithEvents SourceFrequencyLabel As Label
    Friend WithEvents SourceResistanceComboBox As ComboBox
    Friend WithEvents SourceResistanceLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents R1Label As Label
    Friend WithEvents C1Label As Label
    Friend WithEvents C2Label As Label
    Friend WithEvents L1Label As Label
    Friend WithEvents ResistanceComboBox As ComboBox
    Friend WithEvents ResistancePrefixComboBox As ComboBox
    Friend WithEvents InductanceComboBox As ComboBox
    Friend WithEvents InductorPrefixComboBox As ComboBox
    Friend WithEvents Capacitor1ComboBox As ComboBox
    Friend WithEvents Cap1PrefixComboBox As ComboBox
    Friend WithEvents Cap2PrefixComboBox As ComboBox
    Friend WithEvents Capacitor2ComboBox As ComboBox
    Friend WithEvents AnswersLabel As Label
    Friend WithEvents OutputLabel As Label
    Friend WithEvents InputLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents WindingResistanceTextBox As TextBox
    Friend WithEvents WindingResistanceLabel As Label
    Friend WithEvents FormatGroupBox As GroupBox
    Friend WithEvents FormatLabel As Label
    Friend WithEvents PolarRadioButton As RadioButton
    Friend WithEvents RectangularRadioButton1 As RadioButton
    Friend WithEvents SourceVoltageTextBox As TextBox
    Friend WithEvents TestTextBox As TextBox
End Class
