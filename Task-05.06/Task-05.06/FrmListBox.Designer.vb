<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListBox
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
        Me.lstProduct.Location = New System.Drawing.Point(43, 48)
        Me.lstProduct.Name = "lstProduct"
        Me.lstProduct.Size = New System.Drawing.Size(464, 355)
        Me.lstProduct.TabIndex = 0
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(188, 431)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(99, 34)
        Me.btnList.TabIndex = 1
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'frmListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 520)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.lstProduct)
        Me.Name = "frmListBox"
        Me.Text = "Product List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstProduct As System.Windows.Forms.ListBox
    Friend WithEvents btnList As System.Windows.Forms.Button

End Class
