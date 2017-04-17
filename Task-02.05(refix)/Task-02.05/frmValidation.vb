Option Explicit On
Option Strict On

Imports System.Drawing
'author: pham duy ly 

Public Class frmValidation

    Private Sub frmValidation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnValidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidate.Click
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True
        Dim tt As New ToolTip()

        ' bIsValid = IsNumeric(txtField1.Text)
        'If bIsValid Then
        'picErrorField1.Visible = False
        'Else
        'picErrorField1.Visible = True
        'bAllFieldsValid = False
        'End If

        bIsValid = IsNumeric(txtField1.Text)


        If bIsValid Then
            picErrorField1.Visible = False
        Else
            picErrorField1.Visible = True
            tt.SetToolTip(picErrorField1, "Value is not numeric")
            'Me.ToolTip1.SetToolTip(picErrorField1, "this is bal bal")
            bAllFieldsValid = False
        End If

        'bAllFieldsValid = oValidation.isAlphaNumericVal(txtField2.Text)
        'If Not bIsValid Then
        ' Debug.Print("Value is not alphanumeric")
        ' bAllFieldsValid = False
        ' End If

        bIsValid = oValidation.isAlphaNumericVal(txtField2.Text)
        If bAllFieldsValid Then
            picErrorField2.Visible = False
        Else
            picErrorField2.Visible = True
            tt.SetToolTip(picErrorField2, "value is not alphanumeric")
            bAllFieldsValid = False
        End If

        If bAllFieldsValid Then
            MsgBox("all fields are valid")
        Else
            MsgBox("one of the fields was invalid")
        End If
    End Sub


End Class
