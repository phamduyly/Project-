Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO


Public Class frmInsertFilling


    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        'the update for able to insert the data into the database. the old method is unusable. Do not know why. The last line of code in the tutorial oConnection_
        'do not have meaning, maybe that the old method and cannot be execute now.n 
        'this is the code for importing an execute data right now, 

        'Dim provider As String
        'Dim dataFile As String
        'Dim connString As String
        'Dim myConnection As OleDbConnection = New OleDbConnection

        'provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        'dataFile = "C:\Users\DELL\Google Drive\ISYS2116 - Infor system design_\Projects\Task-04.01\procurementDB.accdb"
        'connString = provider & dataFile
        'myConnection.ConnectionString = connString
        'myConnection.Open()

        'Dim bIsValid1 = validateFormData()

        'If bIsValid1 Then


        Dim htdata As Hashtable = New Hashtable
        htdata("SKU") = TextBox1.Text
        htdata("ProductName") = txtName.Text
        htdata("ProductDescription") = txtDescription.Text
        htdata("Category") = txtCategory.Text
        htdata("ReorderLevel") = txtReorderLevel.Text

        htdata("LeadTime") = txtLeadTime.Text
        'Put a if else here for double choices
        If chkDiscontinued.Checked = True Then
            htdata("Discontinued") = 1
        Else
            htdata("Discontinued") = 0
        End If
        htdata("UnitPrice") = txtUnitPrice.Text

        Dim oProductController As ProductController = New ProductController
        oProductController.insert(htdata)
        'End If



    End Sub

    Private Function validateFormData() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()

        bIsValid = IsNumeric(TextBox1.Text)
        If bIsValid Then
            PictureBox7.Visible = False
        Else
            PictureBox7.Visible = True
            tt.SetToolTip(PictureBox7, "Value is not aplhanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtName.Text)
        If bIsValid Then
            PictureBox1.Visible = False
        Else
            PictureBox1.Visible = True
            tt.SetToolTip(PictureBox1, "Value is not aplhanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtDescription.Text)
        If bIsValid Then
            PictureBox2.Visible = False
        Else
            PictureBox2.Visible = True
            tt.SetToolTip(PictureBox1, "Value is not aplhanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtCategory.Text)
        If bIsValid Then
            PictureBox3.Visible = False
        Else
            PictureBox3.Visible = True
            tt.SetToolTip(PictureBox1, "Value is not aplhanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtReorderLevel.Text)
        If bIsValid Then
            PictureBox4.Visible = False
        Else
            PictureBox4.Visible = True
            tt.SetToolTip(PictureBox1, "Value is not aplhanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtLeadTime.Text)
        If bIsValid Then
            PictureBox5.Visible = False
        Else
            PictureBox5.Visible = True
            tt.SetToolTip(PictureBox1, "Value is not aplhanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtUnitPrice.Text)
        If bIsValid Then
            PictureBox6.Visible = False
        Else
            PictureBox6.Visible = True
            tt.SetToolTip(PictureBox1, "Value is not aplhanumeric")
            bAllFieldsValid = False
        End If

        If bAllFieldsValid Then
            MsgBox("all fields are valid")
        Else
            MsgBox("Please recheck your at the error pop up")

        End If

    End Function

    Private Sub frmInsertFilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
