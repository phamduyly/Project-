Option Explicit On
Option Strict On


Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim lsTesting As New List(Of Hashtable)

        Dim TestList1 As Hashtable = New Hashtable
        TestList1.Add("input1", TextBox1.Text)
        TestList1.Add("input2", TextBox2.Text)
        lsTesting.Add(TestList1)

        Dim TestList2 As Hashtable = CType(lsTesting.Item(0), Hashtable)
        MessageBox.Show(CStr(TestList1("input1")))
        MessageBox.Show(CStr(TestList1("input2")))



    End Sub
End Class
