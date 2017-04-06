Option Strict On
Option Explicit On


Public Class frmProductBreakReport


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Items.Add("createReport01()")
        ComboBox1.Items.Add("createBreakReport()")
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim oController As ProductController = New ProductController

        If ComboBox1.Text = "createReport01()" Then
            oController.createReport01()
        ElseIf ComboBox1.Text = "createBreakReport()" Then
            oController.createBreakReport()
        Else
            MsgBox("you have to choose a type of report")
        End If


    End Sub



End Class
