Option Explicit On
Option Strict On

'Name:          frmProduct.vb
'Description:   form product
'Author:        Ly Pham 
'Date:  3/03/2017

Public Class frmProduct

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
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
        txtDescription.Text = CStr(htData("ProductDescription"))
        txtCategory.Text = CStr(htData("Category"))
        txtRecorderLevel.Text = CStr(htData("ReorderLevel"))
        txtLeadTime.Text = CStr(htData("LeadTime"))
        txtUnitPrice.Text = CStr(htData("UnitPrice"))
        If CInt(htData("Discontinued")) = 1 Then
            chkDiscontinued.Checked = True
        Else
            chkDiscontinued.Checked = False

        End If

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim oController As ProductController = New ProductController
        Dim iNumRows = oController.update(getFormData)


        If iNumRows = 1 Then
            Debug.Print("The record was updated.Use the find button to check..")

        Else
            Debug.Print("the record was not updated")
        End If
    End Sub

    Private Function getFormData() As Hashtable
        Dim htData As Hashtable = New Hashtable

        htData("SKU") = txtSKU.Text
        htData("ProductName") = txtName.Text
        htData("ProductDescription") = txtDescription.Text
        htData("Category") = txtCategory.Text
        htData("ReorderLevel") = txtRecorderLevel.Text
        htData("LeadTime") = txtLeadTime.Text
        htData("UnitPrice") = txtUnitPrice.Text
        If chkDiscontinued.Checked = True Then
            htData("Discontinued") = 1
        Else
            htData("Discontinued") = 0
        End If

        Return htData

    End Function

End Class
