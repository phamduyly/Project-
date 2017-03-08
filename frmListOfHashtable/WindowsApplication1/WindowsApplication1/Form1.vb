Option Explicit On
Option Strict On

' Name:       frmListOfHashtables'
' Description: Form for list of hashtable manipulation'
' Author:       Pham Duy Ly '
' Date:          24/02/2017'

Public Class frmListOfHashtables

    Private Sub frmListOfHashtables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnListCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListCreate.Click
        Dim lsListHashtables As New List(Of Hashtable)

        Dim htDetails1 As Hashtable = New Hashtable()
        htDetails1.Add("Firstname", "France")
        htDetails1.Add("Lastname", "Cheong")
        htDetails1.Add("DOB", "24/02/2000")
        lsListHashtables.Add(htDetails1)

        Dim htDetails2 As Hashtable = New Hashtable()
        htDetails2.Add("Firstname", "Chirst")
        htDetails2.Add("Lastname", "cheoing")
        htDetails2.Add("DOB", "24/02/2001")
        lsListHashtables.Add(htDetails2)

        Dim htDetails As Hashtable = CType(lsListHashtables.Item(0), Hashtable)
        Debug.Print("Item(0)")
        Debug.Print("First name: " & CStr(htDetails1("Firstname")))
        Debug.Print("Last name: " & CStr(htDetails1("Lastname")))
        Debug.Print("DOB: " & CStr(htDetails1("DOB")))

        Dim htDetails3 As Hashtable = CType(lsListHashtables.Item(1), Hashtable)
        Debug.Print("Item(1)")
        Debug.Print("First name:" & CStr(htDetails2("Firstname")))
        Debug.Print("Last name:" & CStr(htDetails2("Lastname")))
        Debug.Print("DOB: " & CStr(htDetails2("DOB")))


    End Sub
End Class
