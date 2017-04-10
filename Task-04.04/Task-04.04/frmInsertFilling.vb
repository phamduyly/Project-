Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

'Name:          frmProduct.vb
'Description:   form product
'Author:        Ly Pham 
'Date:  3/03/2017

Public Class frmInsertFilling
    Public Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=procurementDB.accdb"
    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        'Try
        Debug.Print("Connection string: " & oConnection.ConnectionString)


        oConnection.Open()
        'need to be opened as soon as possible

        Dim oCommand As OleDbCommand = New OleDbCommand

        oCommand.Connection = oConnection

        Dim htdata As Hashtable = New Hashtable
        htdata("SKU") = TextBox1.Text
        htdata("ProductName") = txtName.Text
        htdata("ProductDescription") = txtDescription.Text
        htdata("Category") = txtCategory.Text
        htdata("ReorderLevel") = txtRecorderLevel.Text
        htdata("LeadTime") = txtLeadTime.Text
        'Put a if else here for double choices
        If chkDiscontinued.Checked = True Then
            htdata("Discontinued") = 1
        Else
            htdata("Discontinued") = 0
        End If
        htdata("UnitPrice") = txtUnitPrice.Text

        oCommand.CommandText = "INSERT INTO product (SKU,product_name,product_description,category,reorder_level,lead_time,discontinued,unit_price) VALUES(?,?,?,?,?,?,?,?);"

        oCommand.Parameters.Add("SKU", OleDbType.Integer, 1)
        oCommand.Parameters.Add("ProductName", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("ProductDescription", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("Category", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("ReorderLevel", OleDbType.Integer, 4)
        oCommand.Parameters.Add("LeadTime", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("Discontinued", OleDbType.Integer, 1)
        oCommand.Parameters.Add("UnitPrice", OleDbType.Double, 8)

        oCommand.Parameters("SKU").Value = CInt(htdata("SKU"))
        oCommand.Parameters("ProductName").Value = CStr(htdata("ProductName"))
        oCommand.Parameters("ProductDescription").Value = CStr(htdata("ProductDescription"))
        oCommand.Parameters("Category").Value = CStr(htdata("Category"))
        oCommand.Parameters("ReorderLevel").Value = CInt(htdata("ReorderLevel"))
        oCommand.Parameters("LeadTime").Value = CStr(htdata("LeadTime"))
        oCommand.Parameters("Discontinued").Value = CInt(htdata("Discontinued"))
        oCommand.Parameters("UnitPrice").Value = CInt(htdata("UnitPrice"))

        oCommand.Prepare()
        MsgBox("SQL:" & oCommand.CommandText)
        oCommand.ExecuteNonQuery()
        'line in order to import data to the database - therefore this is needed of oCommand.Open() and oCommand.Prepare()  and oCommand.Executive
        MsgBox("the data is imported")

        'Catch ex As Exception
        '    MsgBox("the data was not imported")
        'End Try





    End Sub
End Class
