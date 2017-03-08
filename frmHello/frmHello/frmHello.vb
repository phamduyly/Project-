Option Explicit On
Option Strict On

' Name:        frmHello.vb
' Description: Form for displaying hello world
' Author:      Ly Pham 
' Date:        24/02/2017

Public Class frmHello

    Private Sub btnHello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHello.Click
        Debug.Print("Hello world!")
    End Sub

    Private Sub frmHello_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

