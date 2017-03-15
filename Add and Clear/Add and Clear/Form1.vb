Option Strict On
Option Explicit On

Imports System.Data.OleDb

Public Class Form1
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\DELL\Google Drive\ISYS2116 - Infor system design_\Projects\Add and Clear\testing2003.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim str As String
        str = "Insert into Items([InvoiceID],[Items],[Cost],[Quantity]) Values (?,?,?,?)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("InvoiceID", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Items", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Cost", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Quantity", CType(TextBox4.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class
