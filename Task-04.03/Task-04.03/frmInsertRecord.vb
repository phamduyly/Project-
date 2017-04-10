Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO


'Insert data form

Public Class frmInsertRecord



    Public Const CONNECTION_STRING As String = _
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=procurementDB.accdb"

    Private Sub frmInsertRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)


            oConnection.Open()
            'need to be opened as soon as possible

            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            'oCommand.conneection = oconnection



            Dim htdata As Hashtable = New Hashtable

            htdata("ProductName") = "Folder"
            htdata("ProductDescription") = "50 packs of manila folders"
            htdata("Category") = "Stationery"
            htdata("ReorderLevel") = 5
            htdata("LeadTime") = 1
            htdata("Discontinued") = 4.95


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


            MsgBox("SQL:" & oCommand.CommandText)
            oCommand.ExecuteNonQuery()
            'line in order to import data to the database - therefore this is needed of oCommand.Open() and oCommand.Prepare()  and oCommand.Executive
            MsgBox("the data is imported")

        Catch ex As Exception
            MsgBox("fail")

        End Try




    End Sub


End Class
