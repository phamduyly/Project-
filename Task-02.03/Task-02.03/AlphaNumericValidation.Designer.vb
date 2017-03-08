<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidation
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
        Me.lblField1 = New System.Windows.Forms.Label()
        Me.txtField1 = New System.Windows.Forms.TextBox()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblField1
        '
        Me.lblField1.AutoSize = True
        Me.lblField1.Location = New System.Drawing.Point(22, 55)
        Me.lblField1.Name = "lblField1"
        Me.lblField1.Size = New System.Drawing.Size(143, 13)
        Me.lblField1.TabIndex = 0
        Me.lblField1.Text = "Enter an alphanumeric Value"
        '
        'txtField1
        '
        Me.txtField1.Location = New System.Drawing.Point(242, 55)
        Me.txtField1.Name = "txtField1"
        Me.txtField1.Size = New System.Drawing.Size(212, 20)
        Me.txtField1.TabIndex = 1
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(176, 159)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(102, 29)
        Me.btnValidate.TabIndex = 2
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'AlphaNumericValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 297)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.txtField1)
        Me.Controls.Add(Me.lblField1)
        Me.Name = "AlphaNumericValidation"
        Me.Text = "AlphaNumeric Validation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblField1 As System.Windows.Forms.Label
    Friend WithEvents txtField1 As System.Windows.Forms.TextBox
    Friend WithEvents btnValidate As System.Windows.Forms.Button

End Class
