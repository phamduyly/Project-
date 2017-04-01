Option Strict On
Option Explicit On


Public Class Form1

    Private Sub findall_Click(sender As Object, e As EventArgs) Handles findall.Click
        Dim oController As ProductController = New ProductController
        Dim lsData = oController.findALl()

        Dim strMessage = oController.findALl()

        Dim sProductDetails As String
        For Each product In lsData
            sProductDetails = CStr(product("SKU"))
            sProductDetails = sProductDetails & "|" & CStr(product("ProductName"))
            sProductDetails = sProductDetails & "|" & CStr(product("ProductDescription"))
            sProductDetails = sProductDetails & "|" & CStr(product("Category"))
            sProductDetails = sProductDetails & "|" & CStr(product("ReorderLevel"))
            sProductDetails = sProductDetails & "|" & CStr(product("LeadTime"))
            sProductDetails = sProductDetails & "|" & CStr(product("Discontinued"))
            sProductDetails = sProductDetails & "|" & CStr(product("UnitPrice"))
            Debug.Print("ProductDetails :" & vbCrLf & sProductDetails)


        Next


    End Sub


End Class