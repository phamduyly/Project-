option strict on
option explicit on

'name: task 05-06 


Public Class Form1
  
  dim lsData as new list(of  Hashtable) 

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Dim oController As ProductController = New ProductController

        lsData = oController.findALl()

        'button
        Dim sProductDetails As String
        For Each product In lsData
            sProductDetails = CStr(product("SKU"))
            sProductDetails = sProductDetails & " | " & CStr(product("ProductName"))
            sProductDetails = sProductDetails & " | " & CStr(product("ProductDescription"))
            sProductDetails = sProductDetails & " | " & CStr(product("Category"))
            sProductDetails = sProductDetails & " | " & CInt(product("ReorderLevel"))
            sProductDetails = sProductDetails & " | " & CInt(product("LeadTime"))
            sProductDetails = sProductDetails & " | " & CInt(product("Discontinued"))
            sProductDetails = sProductDetails & " | " & CDbl(product("UnitPrice"))

            lstProduct.Items.Add(sProductDetails)

            'Debug.Print(sProductDetails)
        Next

    End Sub

    Private Sub lstProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProduct.SelectedIndexChanged
        'List box 
        Dim selectedIndex As Integer = lstProduct.SelectedIndex
        Dim selectedItem As Object = lstProduct.SelectedItem

        Debug.Print("Selected product : " & selectedItem.ToString())
        Debug.Print("Selected product index :" & selectedIndex.ToString())

        Dim htData = lsData.Item(selectedIndex)
        Dim sProductDetails As String
        sProductDetails = CStr(htData("SKU"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ProductName"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ProductDescription"))
        sProductDetails = sProductDetails & " | " & CStr(htData("Category"))
        sProductDetails = sProductDetails & " | " & CInt(htData("ReorderLevel"))
        sProductDetails = sProductDetails & " | " & CInt(htData("LeadTime"))
        sProductDetails = sProductDetails & " | " & CInt(htData("Discontinued"))
        sProductDetails = sProductDetails & " | " & CDbl(htData("UnitPrice"))
        Debug.Print("product details: " & vbCrLf & sProductDetails)



    End Sub
End Class



  

