Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

'Name:          frmProduct.vb
'Description:   form product
'Author:        Ly Pham 
'Date:  3/03/2017

Public Class frmInsertFilling
    Public Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=procurementDB.accdb"



    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        Dim bIsValid = validateFormData()


        If bIsValid Then
            Dim htdata As Hashtable = New Hashtable

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

            Dim oProductController As New ProductController
            Dim iNumRows = oProductController.insert(htdata)

            Debug.Print(CStr(iNumRows))
        End If
        

    End Sub

    Public Function validateFormData() As Boolean
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean
        bAllFieldsValid = True
        Dim tt As New ToolTip()

        bIsValid = oValidation.isAlphaNumericVal(txtName.Text)
        If bIsValid Then
            PictureBox1.Visible = False
        Else
            PictureBox1.Visible = True
            tt.SetToolTip(PictureBox1, "Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtDescription.Text)
        If bIsValid Then
            PictureBox2.Visible = False
        Else
            PictureBox2.Visible = True
            tt.SetToolTip(PictureBox2, "Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtCategory.Text)
        If bIsValid Then
            PictureBox3.Visible = False
        Else
            PictureBox3.Visible = True
            tt.SetToolTip(PictureBox3, "Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtReorderLevel.Text)
        If bIsValid Then
            PictureBox4.Visible = False
        Else
            PictureBox4.Visible = True
            tt.SetToolTip(PictureBox4, "Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtLeadTime.Text)
        If bIsValid Then
            PictureBox5.Visible = False
        Else
            PictureBox5.Visible = True
            tt.SetToolTip(PictureBox5, "Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtUnitPrice.Text)
        If bIsValid Then
            PictureBox6.Visible = False
        Else
            PictureBox6.Visible = True
            tt.SetToolTip(PictureBox6, "Value is not alphanumeric")
            bAllFieldsValid = False
        End If

        If bAllFieldsValid Then
            Debug.Print("All fields are valid")
        Else
            MsgBox("one of the fields was invalid")

        End If


        Return bAllFieldsValid

    End Function

End Class
