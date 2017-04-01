Option Explicit On
Option Strict On

Imports System.Data.OleDb

Public Class ProductController

    Public Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProcurementDB.accdb"

    'what is the meaning of public sub, what is byref, byval  
    'Insert method is sub routine 
    Public Sub insert(ByVal htdata As Hashtable)
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Google Drive\ISYS2116 - Infor system design_\Projects\Task-04.06\Taks-04.05\bin\Debug\procurementDB.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        'Try
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = myConnection

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
        '    MsgBox("data input fail")
        'End Try
    End Sub
End Class
