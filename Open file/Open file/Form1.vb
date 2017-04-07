Option Strict On
Option Explicit On


Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sParam As String = "C:\Users\s3594800\Desktop\Framework for Help, about, document\Blog Template for Bootstrap.html"
        ' the """"" can fix into the access to the file path
        MsgBox("sParam: " & sParam)

        Process.Start(sParam)
    End Sub
End Class
