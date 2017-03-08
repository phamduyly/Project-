Option Explicit On
Option Strict On

' Name:        frmHashtable.vb
' Description: Form for Hashtable Manipulation
' Author:      Ly Pham 
' Date:        24/02/2017

Public Class frmHashtable

    Private Sub btnHashtableCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHashtableCreate.Click
        Dim htHashtable As Hashtable = New Hashtable()

        htHashtable.Add("CourseCode", "ISYS2047")
        htHashtable.Add("CourseTitle", "Information system development 1")
        htHashtable.Add("ProgramCode", "BP308")

        Dim sCourseCode = htHashtable("CourseCode")
        Debug.Print(CStr(sCourseCode))

    End Sub
End Class