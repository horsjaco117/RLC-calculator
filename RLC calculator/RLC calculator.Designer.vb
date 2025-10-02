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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        CType(Me.SourceVoltageTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SourceVoltageTrackBar
        '
        Me.SourceVoltageTrackBar.Location = New System.Drawing.Point(12, 278)
        Me.SourceVoltageTrackBar.Name = "SourceVoltageTrackBar"
        Me.SourceVoltageTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.SourceVoltageTrackBar.Size = New System.Drawing.Size(69, 160)
        Me.SourceVoltageTrackBar.TabIndex = 0
        '
        'AnswersListBox
        '
        Me.AnswersListBox.FormattingEnabled = True
        Me.AnswersListBox.ItemHeight = 20
        Me.AnswersListBox.Location = New System.Drawing.Point(545, 12)
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
        '
        'SourceVoltageLabel
        '
        Me.SourceVoltageLabel.AutoSize = True
        Me.SourceVoltageLabel.Location = New System.Drawing.Point(8, 255)
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
        Me.SourceResistanceLabel.Size = New System.Drawing.Size(144, 20)
        Me.SourceResistanceLabel.TabIndex = 6
        Me.SourceResistanceLabel.Text = "Source Resistance"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.InputTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 522)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 322)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
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
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(56, 37)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(244, 219)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
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
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(30, 50)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(659, 26)
        Me.InputTextBox.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1660, 1085)
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
End Class
