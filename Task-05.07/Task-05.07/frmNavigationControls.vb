Option Strict On
Option Explicit On


Public Class frmNavigationControl
    'public in this area can be used across the code section
    Dim lsData As New List(Of Hashtable)
    Dim iCurrentIndex As Integer

    Private Sub frmNavigationControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oController As ProductController = New ProductController
        'dim lsData = oController.FindAll() 
        lsData = oController.findAll()
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iIndex = 0
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)

        Dim sProductDetails As String
        sProductDetails = CStr(htData("SKU"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ProductName"))

        '* somehow this mean that double - really need to rs about this, seeming intersesting 

        sProductDetails = sProductDetails & " | " & CStr(htData("ProductDescription"))
        sProductDetails = sProductDetails & " | " & CStr(htData("Category"))
        sProductDetails = sProductDetails & " | " & CInt(htData("ReorderLevel"))
        sProductDetails = sProductDetails & " | " & CInt(htData("LeadTime"))
        sProductDetails = sProductDetails & " | " & CInt(htData("Disconinued"))
        sProductDetails = sProductDetails & " | " & CDbl(htData("UnitPrice"))
        Debug.Print("ProductDetails: " & vbCrLf & sProductDetails)


    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iCurrentIndex = iIndex
        'error cannot really next and prev
        htData = lsData.Item(iCurrentIndex)

        Dim sProductDetails As String
        sProductDetails = CStr(htData("SKU"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ProductName"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ProductDescription"))
        sProductDetails = sProductDetails & " | " & CStr(htData("Category"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ReorderLevel"))
        sProductDetails = sProductDetails & " | " & CStr(htData("LeadTime"))
        sProductDetails = sProductDetails & " | " & CStr(htData("Disconinued"))
        sProductDetails = sProductDetails & " | " & CStr(htData("UnitPrice"))
        Debug.Print("ProductDetails: " & vbCrLf & sProductDetails)
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iCurrentIndex = iIndex
        htData = lsData.Item(iCurrentIndex - 1)

        Dim sProductDetails As String
        sProductDetails = CStr(htData("SKU"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ProductName"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ProductDescription"))
        sProductDetails = sProductDetails & " | " & CStr(htData("Category"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ReorderLevel"))
        sProductDetails = sProductDetails & " | " & CStr(htData("LeadTime"))
        sProductDetails = sProductDetails & " | " & CStr(htData("Disconinued"))
        sProductDetails = sProductDetails & " | " & CStr(htData("UnitPrice"))
        Debug.Print("ProductDetails: " & vbCrLf & sProductDetails)
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Dim htData As Hashtable
        Dim iIndex As Integer
        iCurrentIndex = iIndex
        htData = lsData.Item(iIndex)

        Dim sProductDetails As String
        sProductDetails = CStr(htData("SKU"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ProductName"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ProductDescription"))
        sProductDetails = sProductDetails & " | " & CStr(htData("Category"))
        sProductDetails = sProductDetails & " | " & CStr(htData("ReorderLevel"))
        sProductDetails = sProductDetails & " | " & CStr(htData("LeadTime"))
        sProductDetails = sProductDetails & " | " & CStr(htData("Disconinued"))
        sProductDetails = sProductDetails & " | " & CStr(htData("UnitPrice"))
        Debug.Print("ProductDetails: " & vbCrLf & sProductDetails)
    End Sub
End Class
