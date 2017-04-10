Option Explicit On
Option Strict On

Imports System.Data.OleDb

Public Class ProductController

    Public Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProcurementDB.accdb"

    'what is the meaning of public sub, what is byref, byval  
    'Insert method is sub routine 
    Public Function insert(ByVal htdata As Hashtable) As Integer
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            'need to be opened as soon as possible

            Dim oCommand As OleDbCommand = New OleDbCommand

            oCommand.Connection = oConnection



            oCommand.CommandText = "INSERT INTO product (product_name,product_description,category,reorder_level,lead_time,discontinued,unit_price) VALUES(?,?,?,?,?,?,?);"


            oCommand.Parameters.Add("ProductName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("ProductDescription", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Category", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("ReorderLevel", OleDbType.Integer, 4)
            oCommand.Parameters.Add("LeadTime", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Discontinued", OleDbType.Integer, 1)
            oCommand.Parameters.Add("UnitPrice", OleDbType.Double, 8)


            oCommand.Parameters("ProductName").Value = CStr(htdata("ProductName"))
            oCommand.Parameters("ProductDescription").Value = CStr(htdata("ProductDescription"))
            oCommand.Parameters("Category").Value = CStr(htdata("Category"))
            oCommand.Parameters("ReorderLevel").Value = CInt(htdata("ReorderLevel"))
            oCommand.Parameters("LeadTime").Value = CStr(htdata("LeadTime"))
            oCommand.Parameters("Discontinued").Value = CInt(htdata("Discontinued"))
            oCommand.Parameters("UnitPrice").Value = CInt(htdata("UnitPrice"))

            oCommand.Prepare()

            iNumRows = oCommand.ExecuteNonQuery()
            Debug.Print(CStr(iNumRows))

            Debug.Print("SQL:" & oCommand.CommandText)
            oCommand.ExecuteNonQuery()
            'line in order to import data to the database - therefore this is needed of oCommand.Open() and oCommand.Prepare()  and oCommand.Executive
            MsgBox("the data is imported")
        Catch ex As Exception
            MsgBox("fail")
        End Try

        Return iNumRows

    End Function
End Class
