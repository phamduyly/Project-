Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO


Public Class frmInsertFilling

 
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
       
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





            Dim htdata As Hashtable = New Hashtable
            htdata("SKU") = TextBox1.Text
            htdata("ProductName") = txtName.Text
            htdata("ProductDescription") = txtDescription.Text
            htdata("Category") = txtCategory.Text
        htdata("ReorderLevel") = txtReorderLevel.Text

            htdata("LeadTime") = txtLeadTime.Text
            'Put a if else here for double choices
            If chkDiscontinued.Checked = True Then
                htdata("Discontinued") = 1
            Else
                htdata("Discontinued") = 0
            End If
            htdata("UnitPrice") = txtUnitPrice.Text

            Dim oProductController As ProductController = New ProductController
            oProductController.insert(htdata)


    End Sub

    Private Sub frmInsertFilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
