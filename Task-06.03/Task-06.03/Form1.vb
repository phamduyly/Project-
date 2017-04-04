Public Class Form1

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim oControler As New ProductController
        oControler.createReport01()

    End Sub
End Class
