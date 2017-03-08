Option Explicit On
Option Strict On

'author: pham duy ly 

Public Class frmValidation

    Private Sub frmValidation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnValidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidate.Click
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True
        bIsValid = IsNumeric(txtField1.Text)
        If Not bIsValid Then
            MsgBox("Value is not numeric")
            bAllFieldsValid = False
        End If
        bAllFieldsValid = oValidation.isAlphaNumericVal(txtField2.Text)
        If Not bIsValid Then
            MsgBox("Value is not alphanumeric")
            bAllFieldsValid = False
        End If
        If bAllFieldsValid Then
            MsgBox("all fields are valid")
        Else
            MsgBox("one of the fields was invalid")
        End If
    End Sub


End Class
