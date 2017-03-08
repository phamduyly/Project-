Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions

Public Class Validation
    'creating class and name it Validation
    Public Function isNumericval(ByVal strVal As String) As Boolean
        'public function it can be access from outside of validation.vb 
        'accepts a single parameter (strVal) which is defined as string, \
        'the strVal is cannot be change the value, returning value. 
        Try
            Return IsNumeric(strVal)

        Catch ex As Exception
            Debug.Print("Error:" & ex.Message)
            Return False

        End Try
    End Function

    Public Function isAlphaNumericVal(ByVal strVal As String) As Boolean

        Dim pattern As Regex = New Regex("[^a-zA-Z0-9 -_]")

        If strVal.Length > 0 Then
            Return Not pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    Private Sub Validation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Validation
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "Validation"
        Me.ResumeLayout(False)

    End Sub
End Class
