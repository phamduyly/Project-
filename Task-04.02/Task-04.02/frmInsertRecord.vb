Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

Public Class frmInsertRecord

    Public Const CONNECTION_STRING As String = _
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=procurementDB.accdb"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
      Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

        Try

            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()

            Dim oCommand As OleDbCommand = New OleDbCommand

            oCommand.Connection = oConnection


            Dim sProductName As String = "Folder"
            Dim sProductDescription As String = "50 pack of manila folders"
            Dim sCategory As String = "stationery"
            Dim iReorderLevel As Integer = 5
            Dim sLeadTime As String = "1"
            Dim iDiscontinued As Integer = 0
            Dim dUniPrice As Double = 4.95

            oCommand.CommandText = "INSERT INTO product (product_name,product_description,category,reorder_level,lead_time,discontinued,unit_price) VALUES(?,?,?,?,?,?,?);"


            oCommand.Parameters.Add("ProductName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("ProductDescription", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Category", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("ReorderLevel", OleDbType.Integer, 4)
            oCommand.Parameters.Add("LeadTime", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Discontinued", OleDbType.Integer, 1)
            oCommand.Parameters.Add("UnitPrice", OleDbType.Double, 8)


            oCommand.Parameters("ProductName").Value = sProductName
            oCommand.Parameters("ProductDescription").Value = sProductDescription
            oCommand.Parameters("Category").Value = sCategory
            oCommand.Parameters("ReorderLevel").Value = iReorderLevel
            oCommand.Parameters("LeadTime").Value = sLeadTime
            oCommand.Parameters("Discontinued").Value = iDiscontinued
            oCommand.Parameters("UnitPrice").Value = dUniPrice

            oCommand.Prepare()
            Debug.Print("SQL:" & oCommand.CommandText)
            oCommand.ExecuteNonQuery()
            'line in order to import data to the database - therefore this is needed of oCommand.Open() and oCommand.Prepare()  and oCommand.Executive
            MsgBox("The data is inserted")
        Catch ex As Exception
            MsgBox("The data is not imported")
        End Try



    End Sub
End Class
