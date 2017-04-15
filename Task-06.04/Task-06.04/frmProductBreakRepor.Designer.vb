<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductBreakReport
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
        Me.btnReport = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.RadBtnReport = New System.Windows.Forms.RadioButton()
        Me.RadBtnBreakReport = New System.Windows.Forms.RadioButton()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(56, 78)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(147, 23)
        Me.btnReport.TabIndex = 0
        Me.btnReport.Text = "Create Break Report "
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"creatReport01()", "createBreakReport()"})
        Me.ComboBox1.Location = New System.Drawing.Point(67, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(84, 126)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(58, 17)
        Me.chk1.TabIndex = 2
        Me.chk1.Text = "Report"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(84, 161)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(89, 17)
        Me.chk2.TabIndex = 3
        Me.chk2.Text = "Break Report"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'RadBtnReport
        '
        Me.RadBtnReport.AutoSize = True
        Me.RadBtnReport.Location = New System.Drawing.Point(84, 185)
        Me.RadBtnReport.Name = "RadBtnReport"
        Me.RadBtnReport.Size = New System.Drawing.Size(57, 17)
        Me.RadBtnReport.TabIndex = 4
        Me.RadBtnReport.TabStop = True
        Me.RadBtnReport.Text = "Report"
        Me.RadBtnReport.UseVisualStyleBackColor = True
        '
        'RadBtnBreakReport
        '
        Me.RadBtnBreakReport.AutoSize = True
        Me.RadBtnBreakReport.Location = New System.Drawing.Point(84, 208)
        Me.RadBtnBreakReport.Name = "RadBtnBreakReport"
        Me.RadBtnBreakReport.Size = New System.Drawing.Size(91, 17)
        Me.RadBtnBreakReport.TabIndex = 5
        Me.RadBtnBreakReport.TabStop = True
        Me.RadBtnBreakReport.Text = "Break Report "
        Me.RadBtnBreakReport.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(323, 51)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(332, 248)
        Me.txt1.TabIndex = 6
        '
        'bt2
        '
        Me.bt2.Location = New System.Drawing.Point(84, 267)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(147, 23)
        Me.bt2.TabIndex = 7
        Me.bt2.Text = "Create Break Report "
        Me.bt2.UseVisualStyleBackColor = True
        '
        'frmProductBreakReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 461)
        Me.Controls.Add(Me.bt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.RadBtnBreakReport)
        Me.Controls.Add(Me.RadBtnReport)
        Me.Controls.Add(Me.chk2)
        Me.Controls.Add(Me.chk1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnReport)
        Me.Name = "frmProductBreakReport"
        Me.Text = "Product Break Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents RadBtnReport As System.Windows.Forms.RadioButton
    Friend WithEvents RadBtnBreakReport As System.Windows.Forms.RadioButton
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents bt2 As System.Windows.Forms.Button

End Class
