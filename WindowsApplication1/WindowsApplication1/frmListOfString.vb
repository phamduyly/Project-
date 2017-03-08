Option Explicit On
Option Strict On

' Name:        frmHello.vb
' Description: Form for displaying hello world
' Author:      Ly Pham 
' Date:        24/02/2017

Public Class frmListOfString

    Private Sub frmListOfString_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lsListStrings As New List(Of String)

        lsListStrings.Add("France")
        lsListStrings.Add("Chris")
        lsListStrings.Add("Justin")

        Debug.Print("Printing lsListStrings")
        Debug.Print("item(0): " & lsListStrings.Item(0))
        Debug.Print("item(1): " & lsListStrings.Item(1))
        Debug.Print("item(2): " & lsListStrings.Item(2))
    End Sub

    Private Sub btnListCreate_Click(sender As Object, e As EventArgs) Handles btnListCreate.Click

    End Sub
End Class
