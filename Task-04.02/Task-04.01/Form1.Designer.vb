<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertRecord
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
        Me.components = New System.ComponentModel.Container()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me._procurementDB_2003_DataSet = New WindowsApplication1._procurementDB_2003_DataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New WindowsApplication1._procurementDB_2003_DataSetTableAdapters.employeeTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1._procurementDB_2003_DataSetTableAdapters.TableAdapterManager()
        Me.Purchase_orderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Purchase_orderTableAdapter = New WindowsApplication1._procurementDB_2003_DataSetTableAdapters.purchase_orderTableAdapter()
        CType(Me._procurementDB_2003_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Purchase_orderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(105, 105)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 0
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        '_procurementDB_2003_DataSet
        '
        Me._procurementDB_2003_DataSet.DataSetName = "_procurementDB_2003_DataSet"
        Me._procurementDB_2003_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me._procurementDB_2003_DataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.employeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.productTableAdapter = Nothing
        Me.TableAdapterManager.purchase_order_itemTableAdapter = Nothing
        Me.TableAdapterManager.purchase_orderTableAdapter = Me.Purchase_orderTableAdapter
        Me.TableAdapterManager.supplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1._procurementDB_2003_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Purchase_orderBindingSource
        '
        Me.Purchase_orderBindingSource.DataMember = "purchase_order"
        Me.Purchase_orderBindingSource.DataSource = Me._procurementDB_2003_DataSet
        '
        'Purchase_orderTableAdapter
        '
        Me.Purchase_orderTableAdapter.ClearBeforeFill = True
        '
        'frmInsertRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 467)
        Me.Controls.Add(Me.btnInsert)
        Me.Name = "frmInsertRecord"
        Me.Text = "Insert record"
        CType(Me._procurementDB_2003_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Purchase_orderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents _procurementDB_2003_DataSet As WindowsApplication1._procurementDB_2003_DataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As WindowsApplication1._procurementDB_2003_DataSetTableAdapters.employeeTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1._procurementDB_2003_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Purchase_orderTableAdapter As WindowsApplication1._procurementDB_2003_DataSetTableAdapters.purchase_orderTableAdapter
    Friend WithEvents Purchase_orderBindingSource As System.Windows.Forms.BindingSource

End Class
