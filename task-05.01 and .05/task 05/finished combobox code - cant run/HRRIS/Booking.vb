Option Strict On
Option Explicit On

Imports System.Data.OleDb
Imports System.IO

'Name: booking input and validation form for HRRI systems
'Date: 11 March 2017
'Author: Ly Pham Duy 

Public Class Booking
    Dim lsData As List(Of Hashtable)

    Private Sub Booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRoomID.DropDownStyle = ComboBoxStyle.DropDownList

        'put these line into form 
        Dim oController As DataController = New DataController
        Dim lsData = oController.findALl()

        For Each room_id In lsData
            'cboRoom.Items.Add(CStr(room("room_id")))

            txtRoomID.Items.Add(CStr(room_id("room_number")))

            'think that these part could be changed in order to display room number but input room ID
            'form line
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim bIsValid = BookValid()

        If bIsValid = True Then

            Dim bookingData As Hashtable = New Hashtable

            bookingData("customer_id") = txtCusId.Text
            bookingData("booking_date") = txtDate.Text
            bookingData("room_id") = txtRoomID.Text
            bookingData("num_days") = txtStay.Text
            bookingData("num_guests") = txtGuesNum.Text
            bookingData("checkin_date") = txtCheckinDate.Text
            bookingData("total_price") = txtPrice.Text
            bookingData("comments") = txtCmt.Text

            Dim bookingimport As DataController = New DataController
            bookingimport.BookingInsert(bookingData)


        End If

    End Sub


    'Navigation to Room form and Customer form: However cannot turnback
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomFrm.Click
        Try
            Dim room2 As New Room
            room2.ShowDialog()

        Catch ex As Exception
            MsgBox("You have already opened Room Form")
        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCusFrm.Click
        Try
            Dim customer2 As New Customer
            customer2.ShowDialog()

        Catch ex As Exception
            MsgBox("You have already opened Customer Form")
        End Try

    End Sub
    'validate private function

    Private Function BookValid() As Boolean

        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True

        bIsValid = IsNumeric(txtCusId.Text)
        If bIsValid Then
            PicCusID.Visible = False
        Else
            PicCusID.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtRoomID.Text)
        If bIsValid Then
            PicRoomID.Visible = False
        Else
            PicRoomID.Visible() = True
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtStay.Text)
        If bIsValid Then
            PicStayingDay.Visible = False

        Else
            PicStayingDay.Visible = True
            bAllFieldsValid = False
        End If

        'Date section
        bIsValid = IsDate(txtDate.Text)
        If bIsValid Then
            PicDate.Visible = False
        Else
            PicDate.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = IsDate(txtCheckinDate.Text)
        If bIsValid Then
            PicCkinDt.Visible = False
        Else
            PicCkinDt.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtGuesNum.Text)
        If bIsValid Then
            PicGuestNum.Visible = False
        Else
            PicGuestNum.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = IsNumeric(txtPrice.Text)
        If bIsValid Then
            PicPrice.Visible = False
        Else
            PicPrice.Visible = True
            bAllFieldsValid = False
        End If

        bIsValid = oValidation.isAlphaNumericVal(txtCmt.Text)
        If bIsValid Then
            PicCmt.Visible = False
        Else
            PicCmt.Visible = True
            bAllFieldsValid = False
        End If

        If bAllFieldsValid Then
            MsgBox("Click OK to import data")
        Else
            MsgBox("Please recheck data where the error pop-up appear")
        End If

        Return True

    End Function

    Private Sub txtRoomID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtRoomID.SelectedIndexChanged

        Dim selectedIndex As Integer = txtRoomID.SelectedIndex

        Debug.Print("Selected room: " & selectedIndex.ToString)

        Dim bookingData = lsData.Item(selectedIndex)


    End Sub
End Class
