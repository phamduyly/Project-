Option Explicit On
Option Strict On

Public Class Validation

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True
        '1.create a object oValidation from class validation
        '2. declare 2 boolean(T or F) and bAllFieldsValid is true at the start of the program)
        bIsValid = IsNumeric(txtField1.Text)
        If Not bIsValid Then
            Debug.Print("value is not numeric")
            bAllFieldsValid = False

        End If
        bIsValid = oValidation.isAlphaNumericVal(txtField2.Text)
        If Not bIsValid Then
            Debug.Print("Value is nto alphanumeric")
            bAllFieldsValid = False
        End If
        If bAllFieldsValid Then
            Debug.Print("ALl fields are valid")
        Else
            MsgBox("One of the fields was invalid")
        End If

    End Sub
End Class
