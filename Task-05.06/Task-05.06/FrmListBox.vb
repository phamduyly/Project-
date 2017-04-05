'Note for assignemtn: create a all this for the HRRIS
'Moreover, add this list box feature in order to display all the data which is added into the database
Option Strict On
Option Explicit On


Public Class frmListBox
    Dim lsData As New List(Of Hashtable)


    Private Sub btnList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click
        Dim oController As ProductController = New ProductController

        lsData = oController.findAll()

        Dim sProductDetails As String
        For Each product In lsData
            sProductDetails = CStr(product("SKU"))
            sProductDetails = sProductDetails & " | " & CStr(product("ProductName"))
            sProductDetails = sProductDetails & " | " & CStr(product("ProductDescription"))
            sProductDetails = sProductDetails & " | " & CStr(product("Category"))
            sProductDetails = sProductDetails & " | " & CStr(product("ReorderLevel"))
            sProductDetails = sProductDetails & " | " & CStr(product("LeadTime"))
            sProductDetails = sProductDetails & " | " & CStr(product("Discontinued"))
            sProductDetails = sProductDetails & " | " & CStr(product("UnitPrice"))

            lstProduct.Items.Add(sProductDetails)


            'Debug.Print(sProductDetails) 

        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProduct.SelectedIndexChanged
        Dim selectedIndex As Integer = lstProduct.SelectedIndex
        Dim selectedItem As Object = lstProduct.SelectedItem

        Debug.Print("selected Product: " & selectedItem.ToString())
        Debug.Print("Selected product index: " & selectedIndex.ToString())

        Dim htData = lsData.Item(selectedIndex)
        Dim sProductDetails As String
        sProductDetails = CStr(htData("SKU"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ProductName"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ProductDescription"))
        sProductDetails = sProductDetails & " | " & CStr(htData("Category"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ReorderLevel"))
        sProductDetails = sProductDetails & " | " & CStr(htData("LeadTime"))
        sProductDetails = sProductDetails & " | " & CStr(htData("Discontinued"))
        sProductDetails = sProductDetails & " | " & CStr(htData("UnitPrice"))
        Debug.Print("ProductDetails: " & vbCrLf & sProductDetails)

    End Sub
End Class
