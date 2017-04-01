Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO


Public Class frmInsertFilling


    Public Const CONNECTION_STRING As String = _
       "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=procurementDB.accdb"

 
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Google Drive\ISYS2116 - Infor system design_\Projects\Task-04.04\Taks-04.04\bin\Debug\procurementDB.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        'the update for able to insert the data into the database. the old method is unusable. Do not know why. The last line of code in the tutorial oConnection_
        'do not have meaning, maybe that the old method and cannot be execute now.n 
        'this is the code for importing an execute data right now, 

        'Dim provider As String
        'Dim dataFile As String
        'Dim connString As String
        'Dim myConnection As OleDbConnection = New OleDbConnection

        'provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        'dataFile = "C:\Users\DELL\Google Drive\ISYS2116 - Infor system design_\Projects\Task-04.01\procurementDB.accdb"
        'connString = provider & dataFile
        'myConnection.ConnectionString = connString
        'myConnection.Open()

        Debug.Print("Connection String: " & myConnection.ConnectionString)



        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = myConnection

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



    End Sub

    Private Sub frmInsertFilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
