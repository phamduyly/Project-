Option Explicit On
Option Strict On


Public Class frmProductReport

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim oControler As New ProductController
        oControler.createReport01()

    End Sub
End Class
