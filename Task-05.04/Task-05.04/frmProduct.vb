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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

    End Sub
End Class
