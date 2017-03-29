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
        Me.lstProduct = New System.Windows.Forms.ListBox()
        Me.btnList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstProduct
        '
        Me.lstProduct.FormattingEnabled = True
        Me.lstProduct.Location = New System.Drawing.Point(26, 40)
        Me.lstProduct.Name = "lstProduct"
        Me.lstProduct.Size = New System.Drawing.Size(211, 108)
        Me.lstProduct.TabIndex = 0
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(57, 177)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(111, 23)
        Me.btnList.TabIndex = 1
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.lstProduct)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstProduct As System.Windows.Forms.ListBox
    Friend WithEvents btnList As System.Windows.Forms.Button

End Class
