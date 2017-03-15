Option Strict On
Option Explicit On

Imports System.Data.OleDb
Imports System.IO
'Autho"r"Ly duy pham

Public Class frmInserRecord

    Public Const CONNECTION_STRING As String = _
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProcurementDB.accdb"


    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)



        oConnection.Open()
        Debug.Print("Connection string: " & oConnection.ConnectionString)

        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection

        Dim sProductName As String = "Folder"
        Dim sProductDescription As String = "50 pack of manila folders"
        Dim sCategory As String = "Stationery"
        Dim iReorderLevel As Integer = 5
        Dim iLeadTime As Integer = 1
        Dim iDiscontinued As Integer = 0
        Dim dUnitPrice As Double = 4.95

        Dim sSQL = "INSERT INTO product (product_name, product_description, category, reorder_level, lead_time, discontinued, unit_price) VALUES (" _
                   


    End Sub
End Class
