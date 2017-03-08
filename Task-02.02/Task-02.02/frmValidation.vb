Option Explicit On
Option Strict On

Public Class frmValidation

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnValidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidate.Click
        If IsNumeric(txtField1.Text) Then
            Debug.Print("value  is numeric")
        Else
            Debug.Print("value is NOT numeric")
        End If
    End Sub
End Class
