Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO


'Insert data form

Public Class frmInsertRecord
  


    Public Const CONNECTION_STRING As String = _
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=procurementDB.accdb"

    Private Sub frmInsertRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_procurementDB_2003_DataSet.purchase_order' table. You can move, or remove it, as needed.
        Me.Purchase_orderTableAdapter.Fill(Me._procurementDB_2003_DataSet.purchase_order)
        'TODO: This line of code loads data into the '_procurementDB_2003_DataSet.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me._procurementDB_2003_DataSet.employee)

    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Google Drive\ISYS2116 - Infor system design_\Projects\Task-04.02\procurementDB.accdb"
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

        Dim iSKU As Integer = 9
        Dim sProductName As String = "Folder"
        Dim sProductDescription As String = "50 pack of manila folders"
        Dim sCategory As String = "stationery"
        Dim iReorderLevel As Integer = 5
        Dim sLeadTime As String = "1"
        Dim iDiscontinued As Integer = 0
        Dim dUniPrice As Double = 4.95

        oCommand.CommandText = "INSERT INTO product (SKU,product_name,product_description,category,reorder_level,lead_time,discontinued,unit_price) VALUES(?,?,?,?,?,?,?,?);"

        oCommand.Parameters.Add("SKU", OleDbType.Integer, 1)
        oCommand.Parameters.Add("ProductName", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("ProductDescription", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("Category", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("ReorderLevel", OleDbType.Integer, 4)
        oCommand.Parameters.Add("LeadTime", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("Discontinued", OleDbType.Integer, 1)
        oCommand.Parameters.Add("UnitPrice", OleDbType.Double, 8)

        oCommand.Parameters("SKU").Value = iSKU
        oCommand.Parameters("ProductName").Value = sProductName
        oCommand.Parameters("ProductDescription").Value = sProductDescription
        oCommand.Parameters("Category").Value = sCategory
        oCommand.Parameters("ReorderLevel").Value = iReorderLevel
        oCommand.Parameters("LeadTime").Value = sLeadTime
        oCommand.Parameters("Discontinued").Value = iDiscontinued
        oCommand.Parameters("UnitPrice").Value = dUniPrice

        oCommand.Prepare()
        MsgBox("SQL:" & oCommand.CommandText)
        oCommand.ExecuteNonQuery()

    End Sub

   
End Class
