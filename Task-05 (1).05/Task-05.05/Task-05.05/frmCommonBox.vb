Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO




Public Class frmCommonBox

    Dim lsData As List(Of Hashtable)

    Private Sub frmCommonBox_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        cboProduct.DropDownStyle = ComboBoxStyle.DropDownList
        Dim oController As ProductController = New ProductController
        Dim lsData = oController.findALl()
        For Each product In lsData

            cboProduct.Items.Add(CStr(product("ProductName")))

        Next
    End Sub

    Private Sub cboProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduct.SelectedIndexChanged

        Dim selectedIndex As Integer = cboProduct.SelectedIndex
        Dim selectedItem As Object = cboProduct.SelectedItem

        Debug.Print("Selected product: " & selectedItem.ToString())
        Debug.Print("Selected product index: " & selectedIndex.ToString())

        'Dim htData = lsData.Item(selectedIndex)
        'Dim sProductDetails As String
        'sProductDetails = CStr(htData("SKU"))
        'sProductDetails = sProductDetails & "|" & CStr(htData("ProductName"))
        'sProductDetails = sProductDetails & "|" & CStr(htData("ProductDescription"))
        'sProductDetails = sProductDetails & "|" & CStr(htData("Category"))
        'sProductDetails = sProductDetails & "|" & CStr(htData("ReorderLevel"))
        'sProductDetails = sProductDetails & "|" & CStr(htData("LeadTime"))
        'sProductDetails = sProductDetails & "|" & CStr(htData("Discontinued"))
        'sProductDetails = sProductDetails & "|" & CStr(htData("UnitPrice"))
        'Debug.Print("ProductDetails :" & vbCrLf & sProductDetails)


    End Sub

End Class
