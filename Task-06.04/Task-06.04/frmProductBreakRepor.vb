Option Strict On
Option Explicit On


Public Class frmProductBreakReport

    
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim oController As ProductController = New ProductController
        oController.createBreakReport()

    End Sub
End Class
