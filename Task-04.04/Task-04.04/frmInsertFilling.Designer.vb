﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertFilling
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SKU = New System.Windows.Forms.Label()
        Me.chkDiscontinued = New System.Windows.Forms.CheckBox()
        Me.lblHeadingDescription = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtLeadTime = New System.Windows.Forms.TextBox()
        Me.txtRecorderLevel = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.lblHeadingDiscontinued = New System.Windows.Forms.Label()
        Me.lblHeadingUnitPrice = New System.Windows.Forms.Label()
        Me.lblHeadingLeadTime = New System.Windows.Forms.Label()
        Me.lblHeadingRecorderLevel = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblHeadingCategory = New System.Windows.Forms.Label()
        Me.lblHeadingName = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.gbxInputFields.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxInputFields
        '
        Me.gbxInputFields.Controls.Add(Me.TextBox1)
        Me.gbxInputFields.Controls.Add(Me.SKU)
        Me.gbxInputFields.Controls.Add(Me.chkDiscontinued)
        Me.gbxInputFields.Controls.Add(Me.lblHeadingDescription)
        Me.gbxInputFields.Controls.Add(Me.txtUnitPrice)
        Me.gbxInputFields.Controls.Add(Me.txtLeadTime)
        Me.gbxInputFields.Controls.Add(Me.txtRecorderLevel)
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
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(165, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 20)
        Me.TextBox1.TabIndex = 17
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
        'txtRecorderLevel
        '
        Me.txtRecorderLevel.Location = New System.Drawing.Point(165, 149)
        Me.txtRecorderLevel.Name = "txtRecorderLevel"
        Me.txtRecorderLevel.Size = New System.Drawing.Size(215, 20)
        Me.txtRecorderLevel.TabIndex = 11
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
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(398, 80)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(215, 20)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'frmInsertFilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 312)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.gbxInputFields)
        Me.Name = "frmInsertFilling"
        Me.Text = "Product"
        Me.gbxInputFields.ResumeLayout(False)
        Me.gbxInputFields.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxInputFields As System.Windows.Forms.GroupBox
    Friend WithEvents lblHeadingDescription As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtLeadTime As System.Windows.Forms.TextBox
    Friend WithEvents txtRecorderLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents lblHeadingDiscontinued As System.Windows.Forms.Label
    Friend WithEvents lblHeadingUnitPrice As System.Windows.Forms.Label
    Friend WithEvents lblHeadingLeadTime As System.Windows.Forms.Label
    Friend WithEvents lblHeadingRecorderLevel As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblHeadingCategory As System.Windows.Forms.Label
    Friend WithEvents lblHeadingName As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SKU As System.Windows.Forms.Label
    Friend WithEvents chkDiscontinued As System.Windows.Forms.CheckBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button

End Class
