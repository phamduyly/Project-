Option Strict Off
Option Explicit On

Imports System.Data.OleDb
Imports System.IO

'

Public Class Form1

    Private Sub btnFindAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindAll.Click
        Dim oController As ProductController = New ProductController

        Dim lsData = oController.findAll()

        Dim sProductDetails As String

        For Each product In lsData
sProductDetails = CStr(product(&quot;SKU&quot;))

sProductDetails = sProductDetails &amp; &quot; | &quot; &amp; CStr(product(&quot;ProductName&quot;))

sProductDetails = sProductDetails &amp; &quot; | &quot; &amp; CStr(product(&quot;ProductDescription&quot;))

sProductDetails = sProductDetails &amp; &quot; | &quot; &amp; CStr(product(&quot;Category&quot;))

sProductDetails = sProductDetails &amp; &quot; | &quot; &amp; CInt(product(&quot;ReorderLevel&quot;))

sProductDetails = sProductDetails &amp; &quot; | &quot; &amp; CInt(product(&quot;LeadTime&quot;))

sProductDetails = sProductDetails &amp; &quot; | &quot; &amp; CInt(product(&quot;Discontinued&quot;))

sProductDetails = sProductDetails &amp; &quot; | &quot; &amp; CDbl(product(&quot;UnitPrice&quot;))

            Debug.Print(sProductDetails)

        Next
    End Sub
End Class
