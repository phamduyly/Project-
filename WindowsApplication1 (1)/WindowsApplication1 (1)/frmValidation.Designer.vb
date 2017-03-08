<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Validation
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
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.lblField1 = New System.Windows.Forms.Label()
        Me.lblField2 = New System.Windows.Forms.Label()
        Me.txtField1 = New System.Windows.Forms.TextBox()
        Me.txtField2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(152, 125)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(75, 23)
        Me.btnValidate.TabIndex = 0
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'lblField1
        '
        Me.lblField1.AutoSize = True
        Me.lblField1.Location = New System.Drawing.Point(24, 30)
        Me.lblField1.Name = "lblField1"
        Me.lblField1.Size = New System.Drawing.Size(110, 13)
        Me.lblField1.TabIndex = 1
        Me.lblField1.Text = "Enter a numeric value"
        '
        'lblField2
        '
        Me.lblField2.AutoSize = True
        Me.lblField2.Location = New System.Drawing.Point(24, 76)
        Me.lblField2.Name = "lblField2"
        Me.lblField2.Size = New System.Drawing.Size(143, 13)
        Me.lblField2.TabIndex = 2
        Me.lblField2.Text = "Enter an Alphanumeric value"
        '
        'txtField1
        '
        Me.txtField1.Location = New System.Drawing.Point(190, 30)
        Me.txtField1.Name = "txtField1"
        Me.txtField1.Size = New System.Drawing.Size(100, 20)
        Me.txtField1.TabIndex = 3
        '
        'txtField2
        '
        Me.txtField2.Location = New System.Drawing.Point(190, 76)
        Me.txtField2.Name = "txtField2"
        Me.txtField2.Size = New System.Drawing.Size(100, 20)
        Me.txtField2.TabIndex = 4
        '
        'frmValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 262)
        Me.Controls.Add(Me.txtField2)
        Me.Controls.Add(Me.txtField1)
        Me.Controls.Add(Me.lblField2)
        Me.Controls.Add(Me.lblField1)
        Me.Controls.Add(Me.btnValidate)
        Me.Name = "frmValidation"
        Me.Text = "Validation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnValidate As System.Windows.Forms.Button
    Friend WithEvents lblField1 As System.Windows.Forms.Label
    Friend WithEvents lblField2 As System.Windows.Forms.Label
    Friend WithEvents txtField1 As System.Windows.Forms.TextBox
    Friend WithEvents txtField2 As System.Windows.Forms.TextBox

End Class
