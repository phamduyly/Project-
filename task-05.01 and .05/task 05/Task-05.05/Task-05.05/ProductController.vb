Option Explicit On
Option Strict On

Imports System.Data.OleDb

Public Class ProductController

    Public Const CONNECTION_STRING As String = _
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProcurementDB.accdb"

    Public Sub save(ByVal htData As Hashtable)

    End Sub
    'Public Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProcurementDB.accdb"

    ''what is the meaning of public sub, what is byref, byval  
    ''Insert method is sub routine 
    'Public Sub insert(ByVal htdata As Hashtable)

    '    Dim myConnection As OleDbConnection = New OleDbConnection



    '    myConnection.Open()

    '    Try
    '        Dim oCommand As OleDbCommand = New OleDbCommand
    '        oCommand.Connection = myConnection

    '        oCommand.CommandText = "INSERT INTO product (SKU,product_name,product_description,category,reorder_level,lead_time,discontinued,unit_price) VALUES(?,?,?,?,?,?,?,?);"

    '        oCommand.Parameters.Add("SKU", OleDbType.Integer, 1)
    '        oCommand.Parameters.Add("ProductName", OleDbType.VarChar, 255)
    '        oCommand.Parameters.Add("ProductDescription", OleDbType.VarChar, 255)
    '        oCommand.Parameters.Add("Category", OleDbType.VarChar, 255)
    '        oCommand.Parameters.Add("ReorderLevel", OleDbType.Integer, 4)
    '        oCommand.Parameters.Add("LeadTime", OleDbType.VarChar, 255)
    '        oCommand.Parameters.Add("Discontinued", OleDbType.Integer, 1)
    '        oCommand.Parameters.Add("UnitPrice", OleDbType.Double, 8)

    '        oCommand.Parameters("SKU").Value = CInt(htdata("SKU"))
    '        oCommand.Parameters("ProductName").Value = CStr(htdata("ProductName"))
    '        oCommand.Parameters("ProductDescription").Value = CStr(htdata("ProductDescription"))
    '        oCommand.Parameters("Category").Value = CStr(htdata("Category"))
    '        oCommand.Parameters("ReorderLevel").Value = CInt(htdata("ReorderLevel"))
    '        oCommand.Parameters("LeadTime").Value = CStr(htdata("LeadTime"))
    '        oCommand.Parameters("Discontinued").Value = CInt(htdata("Discontinued"))
    '        oCommand.Parameters("UnitPrice").Value = CInt(htdata("UnitPrice"))

    '        oCommand.Prepare()
    '        MsgBox("SQL:" & oCommand.CommandText)
    '        oCommand.ExecuteNonQuery()
    '        'line in order to import data to the database - therefore this is needed of oCommand.Open() and oCommand.Prepare()  and oCommand.Executive
    '        MsgBox("the data is imported")
    '    Catch ex As Exception
    '        MsgBox("fail")
    '    End Try
    'End Sub

    Public Function findALl() As List(Of Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        'Try
        Debug.Print("Connection String: " & oConnection.ConnectionString)

        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection

        'to do

        oCommand.CommandText = "SELECT * FROM product ORDER BY SKU;"

        oCommand.Prepare()
        Dim oDataReader = oCommand.ExecuteReader()

        Dim htTempData As Hashtable

        Do While oDataReader.Read() = True
            htTempData = New Hashtable
            htTempData("SKU") = CInt(oDataReader("SKU"))
            htTempData("ProductName") = CStr(oDataReader("product_name"))
            htTempData("ProductDescription") = CStr(oDataReader("product_description"))
            htTempData("Category") = CStr(oDataReader("category"))
            htTempData("ReorderLevel") = CInt(oDataReader("reorder_level"))
            htTempData("LeadTime") = CStr(oDataReader("lead_time"))
            htTempData("Discontinued") = CInt(oDataReader("discontinued"))
            htTempData("UnitPrice") = CDbl(oDataReader("unit_price"))
            lsData.Add(htTempData)
        Loop

        Debug.Print("the records were found")

        'Catch ex As Exception
        '    Debug.Print("ERROR: " & ex.Message)
        '    MsgBox("an error occured")

        'Finally
        '    oConnection.Close()
        'End Try

        Return lsData

    End Function

End Class
