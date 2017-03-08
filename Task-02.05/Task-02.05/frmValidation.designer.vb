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
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.lblField1 = New System.Windows.Forms.Label()
        Me.txtField1 = New System.Windows.Forms.TextBox()
        Me.txtField2 = New System.Windows.Forms.TextBox()
        Me.lblField2 = New System.Windows.Forms.Label()
        Me.picErrorField1 = New System.Windows.Forms.PictureBox()
        Me.picErrorField2 = New System.Windows.Forms.PictureBox()
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(131, 137)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(75, 23)
        Me.btnValidate.TabIndex = 0
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'lblField1
        '
        Me.lblField1.AutoSize = True
        Me.lblField1.Location = New System.Drawing.Point(33, 42)
        Me.lblField1.Name = "lblField1"
        Me.lblField1.Size = New System.Drawing.Size(113, 13)
        Me.lblField1.TabIndex = 1
        Me.lblField1.Text = "Enter a numeric value "
        '
        'txtField1
        '
        Me.txtField1.Location = New System.Drawing.Point(185, 42)
        Me.txtField1.Name = "txtField1"
        Me.txtField1.Size = New System.Drawing.Size(100, 20)
        Me.txtField1.TabIndex = 2
        '
        'txtField2
        '
        Me.txtField2.Location = New System.Drawing.Point(185, 81)
        Me.txtField2.Name = "txtField2"
        Me.txtField2.Size = New System.Drawing.Size(100, 20)
        Me.txtField2.TabIndex = 4
        '
        'lblField2
        '
        Me.lblField2.AutoSize = True
        Me.lblField2.Location = New System.Drawing.Point(33, 84)
        Me.lblField2.Name = "lblField2"
        Me.lblField2.Size = New System.Drawing.Size(142, 13)
        Me.lblField2.TabIndex = 3
        Me.lblField2.Text = "Enter an alphanumeric value"
        '
        'picErrorField1
        '
        Me.picErrorField1.Image = Global.Task_02._05.My.Resources.Resources.Button_Close_icon
        Me.picErrorField1.Location = New System.Drawing.Point(291, 48)
        Me.picErrorField1.Name = "picErrorField1"
        Me.picErrorField1.Size = New System.Drawing.Size(20, 20)
        Me.picErrorField1.TabIndex = 5
        Me.picErrorField1.TabStop = False
        '
        'picErrorField2
        '
        Me.picErrorField2.Image = Global.Task_02._05.My.Resources.Resources.Button_Close_icon
        Me.picErrorField2.Location = New System.Drawing.Point(291, 87)
        Me.picErrorField2.Name = "picErrorField2"
        Me.picErrorField2.Size = New System.Drawing.Size(20, 14)
        Me.picErrorField2.TabIndex = 6
        Me.picErrorField2.TabStop = False
        '
        'frmValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 261)
        Me.Controls.Add(Me.picErrorField2)
        Me.Controls.Add(Me.picErrorField1)
        Me.Controls.Add(Me.txtField2)
        Me.Controls.Add(Me.lblField2)
        Me.Controls.Add(Me.txtField1)
        Me.Controls.Add(Me.lblField1)
        Me.Controls.Add(Me.btnValidate)
        Me.Name = "frmValidation"
        Me.Text = "Valiadate"
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnValidate As System.Windows.Forms.Button
    Friend WithEvents lblField1 As System.Windows.Forms.Label
    Friend WithEvents txtField1 As System.Windows.Forms.TextBox
    Friend WithEvents txtField2 As System.Windows.Forms.TextBox
    Friend WithEvents lblField2 As System.Windows.Forms.Label
    Friend WithEvents picErrorField1 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField2 As System.Windows.Forms.PictureBox

End Class
