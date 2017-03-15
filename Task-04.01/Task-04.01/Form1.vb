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

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Google Drive\ISYS2116 - Infor system design_\Projects\Task-04.01\procurementDB.accdb"
        connString = provider & dataFile



        Dim oConnection As OleDbConnection = New OleDbConnection()
        oConnection.ConnectionString = connString

        Try
            oConnection.Open()

            Debug.Print("Connection String: " & oConnection.ConnectionString)


            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            Dim sProductName As String = "Folder"
            Dim sProductDescription As String = "50 pack of manila folders"
            Dim sCategory As String = "strationery"
            Dim iRecorderLevel As Integer = 5
            Dim iLeadTime As Integer = 1
            Dim iDiscontinued As Integer = 0
            Dim dUniPrice As Double = 4.95

            Dim sSQL = "INSERT INTO product (product_name, product_description, category, reorder_level, lead_time, discontinued, unit_price) VALUES (" _
                       & "'" & sProductName & "'," _
                       & "'" & sProductDescription & "'," _
                       & "'" & sCategory & "'," _
                       & iRecorderLevel & ", " _
                       & iLeadTime & ", " _
                       & iDiscontinued & ", " _
                       & dUniPrice & ");"

            Debug.Print("sSQL: " & sSQL)

            oCommand.CommandText = sSQL
            oCommand.ExecuteNonQuery()

            Debug.Print("The record was inserted.")

        Catch ex As Exception
            Debug.Print("ERORR: " & ex.Message)
            MsgBox("An error occured. The record wasn't inserted")
        Finally
            oConnection.Close()
        End Try

    End Sub

   
End Class
