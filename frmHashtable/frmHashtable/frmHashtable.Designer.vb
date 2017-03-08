<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHashtable
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
        Me.btnHashtableCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHashtableCreate
        '
        Me.btnHashtableCreate.Location = New System.Drawing.Point(71, 76)
        Me.btnHashtableCreate.Name = "btnHashtableCreate"
        Me.btnHashtableCreate.Size = New System.Drawing.Size(124, 81)
        Me.btnHashtableCreate.TabIndex = 0
        Me.btnHashtableCreate.Text = "Hashtable"
        Me.btnHashtableCreate.UseVisualStyleBackColor = True
        '
        'frmHashtable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnHashtableCreate)
        Me.Name = "frmHashtable"
        Me.Text = "Hashtable Manipulation"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHashtableCreate As System.Windows.Forms.Button
End Class
