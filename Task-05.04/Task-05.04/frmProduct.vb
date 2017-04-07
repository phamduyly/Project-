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
        txtReorderLevel.Text = CStr(htData("ReorderLevel"))
        txtLeadTime.Text = CStr(htData("LeadTime"))
        txtUnitPrice.Text = CStr(htData("UnitPrice"))
        If CInt(htData("Discontinued")) = 1 Then
            chkDiscontinued.Checked = True
        Else
            chkDiscontinued.Checked = False

        End If

    End Sub



    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim oController As ProductController = New ProductController
        Dim sId = txtSKU.Text
        Dim iNumRows = oController.delete(sId)

        'This code is not operate ? - do not know the reason why 
        'REally need to trade back the meanings of iNumrows
        If iNumRows = 1 Then
            ClearForm()
            Debug.Print("The record was deleted. Use the find button to check")
        Else
            Debug.Print("The record was not deleted")
        End If
    End Sub

    Private Sub clearform()
        txtSKU.Clear()
        txtName.Clear()
        txtDescription.Clear()
        txtCategory.Clear()
        txtReorderLevel.Clear()
        txtLeadTime.Clear()
        txtUnitPrice.Clear()
        chkDiscontinued.Checked = False

    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
