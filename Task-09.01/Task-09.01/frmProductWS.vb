Option Explicit On
Option Strict On

'Name:          frmProduct.vb
'Description:   form product
'Author:        Ly Pham 
'Date:  3/03/2017

Imports System.Net.Http
Imports System.Text


'package tht help finding the package 

Public Class frmProductWS

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmFindAll.Click
        Dim oController As ProductController = New ProductController

        Dim sId = txtSKU.Text
        Dim lsData = oController.findById(sId)

        If lsData.Count = 1 Then

            populateFormFiels(lsData.Item(0))


        Else
            Debug.Print("No reccord were found")


        End If
    End Sub

    Private Sub populateFormFiels(ByVal htData As Hashtable)
        txtName.Text = CStr(htData("ProductName"))
        txtDescription.Text = CStr(htData("Description"))
        txtCategory.Text = CStr(htData("Category"))
        txtRecorderLevel.Text = CStr(htData("Reorderlevel"))
        txtLeadTime.Text = CStr(htData("LeadTime"))
        txtUnitPrice.Text = CStr(htData("UnitPrice"))
        If CInt(htData("Discontinued")) = 1 Then
            chkDiscontinued.Checked = True
        Else
            chkDiscontinued.Checked = False

        End If

    End Sub

    Private Sub frmProductWS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
