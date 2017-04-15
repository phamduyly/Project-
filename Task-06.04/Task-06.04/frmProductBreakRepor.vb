Option Strict On
Option Explicit On


Public Class frmProductBreakReport
   

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Items.Add("createReport01()")
        ComboBox1.Items.Add("createBreakReport()")
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        '1. combobox 


        Dim oController As ProductController = New ProductController

        'If ComboBox1.Text = "createReport01()" Then
        '    oController.createReport01()
        'ElseIf ComboBox1.Text = "createBreakReport()" Then
        '    oController.createBreakReport()
        'Else
        '    MsgBox("you have to choose a type of report")
        'End If

        '2.checked box 
        If chk1.Checked Then
            oController.createReport01()
        End If

        If chk2.Checked Then
            oController.createBreakReport()
        End If

        'Else
        '    MsgBox("Please choose one of report kind")

        'End If

        '3.Radio box 

        If RadBtnReport.Checked Then
            oController.createReport01()
        End If

        If RadBtnBreakReport.Checked Then
            oController.createBreakReport()
        End If

        'Section for doing all checked box 
        'Idea for checked bx for alll 


        '    If bAllFieldsValid Then
        '        MsgBox("all fields are valid")
        '    Else
        '        MsgBox("one of the fields was invalid")
        '    End If
        'End Sub





    End Sub



    Private Sub frmProductBreakReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadBtnReport_CheckedChanged(sender As Object, e As EventArgs) Handles RadBtnReport.CheckedChanged

    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        'Dim oController As New ProductController
        ''Adding text by checking box and radio box 

        If chk1.Checked Then
            txt1.Text = "Create report"
        End If

        If chk2.Checked Then
            txt1.Text = "Create break Report"
        End If

        If chk1.Checked And chk2.Checked Then
        End If




        'End If

        ''3.Radio box 

        'If RadBtnReport.Checked Then
        '    txt1.Text = "create report "
        'ElseIf RadBtnBreakReport.Checked Then
        '    txt1.Text = "create break report"
        'Else
        '    MsgBox("You can only choose one of report kind")
        'End If


        '    If chk1.Checked = True Then
        '        chk1.Text = "Testing"
        '        Debug.Print = chk1.Text
        '    End If
    End Sub


End Class
