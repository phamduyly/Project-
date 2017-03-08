Option Explicit On
Option Strict On



Imports System.Text.RegularExpressions

Public Class frmValidation

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim pattern As Regex = New Regex("[^a-zA-Z0-9 -_]")
        If txtField1.Text.Length > 0 And Not pattern.IsMatch(txtField1.Text) Then
            MsgBox("Value is alphanumeric")
        Else
            MsgBox("Value is NOT alphanumeric")
        End If

    End Sub
End Class

