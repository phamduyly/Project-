<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Me.gbxInputFields = New System.Windows.Forms.GroupBox()
        Me.txtSKU = New System.Windows.Forms.TextBox()
        Me.SKU = New System.Windows.Forms.Label()
        Me.chkDiscontinued = New System.Windows.Forms.CheckBox()
        Me.lblHeadingDescription = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtLeadTime = New System.Windows.Forms.TextBox()
        Me.txtReorderLevel = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.lblHeadingDiscontinued = New System.Windows.Forms.Label()
        Me.lblHeadingUnitPrice = New System.Windows.Forms.Label()
        Me.lblHeadingLeadTime = New System.Windows.Forms.Label()
        Me.lblHeadingRecorderLevel = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblHeadingCategory = New System.Windows.Forms.Label()
        Me.lblHeadingName = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.gbxInputFields.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxInputFields
        '
        Me.gbxInputFields.Controls.Add(Me.txtSKU)
        Me.gbxInputFields.Controls.Add(Me.SKU)
        Me.gbxInputFields.Controls.Add(Me.chkDiscontinued)
        Me.gbxInputFields.Controls.Add(Me.lblHeadingDescription)
        Me.gbxInputFields.Controls.Add(Me.txtUnitPrice)
        Me.gbxInputFields.Controls.Add(Me.txtLeadTime)
        Me.gbxInputFields.Controls.Add(Me.txtReorderLevel)
        Me.gbxInputFields.Controls.Add(Me.txtCategory)
        Me.gbxInputFields.Controls.Add(Me.lblHeadingDiscontinued)
        Me.gbxInputFields.Controls.Add(Me.lblHeadingUnitPrice)
        Me.gbxInputFields.Controls.Add(Me.lblHeadingLeadTime)
        Me.gbxInputFields.Controls.Add(Me.lblHeadingRecorderLevel)
        Me.gbxInputFields.Controls.Add(Me.txtName)
        Me.gbxInputFields.Controls.Add(Me.txtDescription)
        Me.gbxInputFields.Controls.Add(Me.lblHeadingCategory)
        Me.gbxInputFields.Controls.Add(Me.lblHeadingName)
        Me.gbxInputFields.Location = New System.Drawing.Point(12, 12)
        Me.gbxInputFields.Name = "gbxInputFields"
        Me.gbxInputFields.Size = New System.Drawing.Size(380, 275)
        Me.gbxInputFields.TabIndex = 0
        Me.gbxInputFields.TabStop = False
        Me.gbxInputFields.Text = "Product Details"
        '
        'txtSKU
        '
        Me.txtSKU.Location = New System.Drawing.Point(165, 36)
        Me.txtSKU.Name = "txtSKU"
        Me.txtSKU.Size = New System.Drawing.Size(215, 20)
        Me.txtSKU.TabIndex = 17
        '
        'SKU
        '
        Me.SKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SKU.Location = New System.Drawing.Point(18, 36)
        Me.SKU.Name = "SKU"
        Me.SKU.Size = New System.Drawing.Size(138, 20)
        Me.SKU.TabIndex = 16
        Me.SKU.Text = "SKU"
        Me.SKU.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkDiscontinued
        '
        Me.chkDiscontinued.AutoSize = True
        Me.chkDiscontinued.Location = New System.Drawing.Point(165, 242)
        Me.chkDiscontinued.Name = "chkDiscontinued"
        Me.chkDiscontinued.Size = New System.Drawing.Size(15, 14)
        Me.chkDiscontinued.TabIndex = 15
        Me.chkDiscontinued.UseVisualStyleBackColor = True
        '
        'lblHeadingDescription
        '
        Me.lblHeadingDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeadingDescription.Location = New System.Drawing.Point(18, 92)
        Me.lblHeadingDescription.Name = "lblHeadingDescription"
        Me.lblHeadingDescription.Size = New System.Drawing.Size(138, 20)
        Me.lblHeadingDescription.TabIndex = 14
        Me.lblHeadingDescription.Text = "Product Desciption"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(165, 209)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(215, 20)
        Me.txtUnitPrice.TabIndex = 13
        '
        'txtLeadTime
        '
        Me.txtLeadTime.Location = New System.Drawing.Point(165, 178)
        Me.txtLeadTime.Name = "txtLeadTime"
        Me.txtLeadTime.Size = New System.Drawing.Size(215, 20)
        Me.txtLeadTime.TabIndex = 12
        '
        'txtReorderLevel
        '
        Me.txtReorderLevel.Location = New System.Drawing.Point(165, 149)
        Me.txtReorderLevel.Name = "txtReorderLevel"
        Me.txtReorderLevel.Size = New System.Drawing.Size(215, 20)
        Me.txtReorderLevel.TabIndex = 11
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(162, 119)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(215, 20)
        Me.txtCategory.TabIndex = 10
        '
        'lblHeadingDiscontinued
        '
        Me.lblHeadingDiscontinued.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeadingDiscontinued.Location = New System.Drawing.Point(18, 240)
        Me.lblHeadingDiscontinued.Name = "lblHeadingDiscontinued"
        Me.lblHeadingDiscontinued.Size = New System.Drawing.Size(138, 20)
        Me.lblHeadingDiscontinued.TabIndex = 9
        Me.lblHeadingDiscontinued.Text = "Discontinued"
        '
        'lblHeadingUnitPrice
        '
        Me.lblHeadingUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeadingUnitPrice.Location = New System.Drawing.Point(18, 208)
        Me.lblHeadingUnitPrice.Name = "lblHeadingUnitPrice"
        Me.lblHeadingUnitPrice.Size = New System.Drawing.Size(138, 20)
        Me.lblHeadingUnitPrice.TabIndex = 8
        Me.lblHeadingUnitPrice.Text = "Unit Price"
        '
        'lblHeadingLeadTime
        '
        Me.lblHeadingLeadTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeadingLeadTime.Location = New System.Drawing.Point(18, 179)
        Me.lblHeadingLeadTime.Name = "lblHeadingLeadTime"
        Me.lblHeadingLeadTime.Size = New System.Drawing.Size(138, 20)
        Me.lblHeadingLeadTime.TabIndex = 7
        Me.lblHeadingLeadTime.Text = "Lead Time"
        '
        'lblHeadingRecorderLevel
        '
        Me.lblHeadingRecorderLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeadingRecorderLevel.Location = New System.Drawing.Point(18, 150)
        Me.lblHeadingRecorderLevel.Name = "lblHeadingRecorderLevel"
        Me.lblHeadingRecorderLevel.Size = New System.Drawing.Size(138, 20)
        Me.lblHeadingRecorderLevel.TabIndex = 6
        Me.lblHeadingRecorderLevel.Text = "Recorder Level"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(165, 66)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(215, 20)
        Me.txtName.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(165, 92)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(215, 20)
        Me.txtDescription.TabIndex = 4
        '
        'lblHeadingCategory
        '
        Me.lblHeadingCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeadingCategory.Location = New System.Drawing.Point(18, 119)
        Me.lblHeadingCategory.Name = "lblHeadingCategory"
        Me.lblHeadingCategory.Size = New System.Drawing.Size(138, 20)
        Me.lblHeadingCategory.TabIndex = 3
        Me.lblHeadingCategory.Text = "Category"
        '
        'lblHeadingName
        '
        Me.lblHeadingName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeadingName.Location = New System.Drawing.Point(18, 68)
        Me.lblHeadingName.Name = "lblHeadingName"
        Me.lblHeadingName.Size = New System.Drawing.Size(138, 20)
        Me.lblHeadingName.TabIndex = 2
        Me.lblHeadingName.Text = "Product Name"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(398, 48)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(215, 20)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(398, 80)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(215, 20)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(397, 106)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(215, 20)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(397, 252)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(215, 20)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(397, 132)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(215, 20)
        Me.btnFind.TabIndex = 5
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(397, 161)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(215, 20)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 312)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.gbxInputFields)
        Me.Name = "frmProduct"
        Me.Text = "Product"
        Me.gbxInputFields.ResumeLayout(False)
        Me.gbxInputFields.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxInputFields As System.Windows.Forms.GroupBox
    Friend WithEvents lblHeadingDescription As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtLeadTime As System.Windows.Forms.TextBox
    Friend WithEvents txtReorderLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents lblHeadingDiscontinued As System.Windows.Forms.Label
    Friend WithEvents lblHeadingUnitPrice As System.Windows.Forms.Label
    Friend WithEvents lblHeadingLeadTime As System.Windows.Forms.Label
    Friend WithEvents lblHeadingRecorderLevel As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblHeadingCategory As System.Windows.Forms.Label
    Friend WithEvents lblHeadingName As System.Windows.Forms.Label
    Friend WithEvents txtSKU As System.Windows.Forms.TextBox
    Friend WithEvents SKU As System.Windows.Forms.Label
    Friend WithEvents chkDiscontinued As System.Windows.Forms.CheckBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button

End Class
