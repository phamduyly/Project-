﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCmt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGuesNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCusId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicCmt = New System.Windows.Forms.PictureBox()
        Me.PicStayingDay = New System.Windows.Forms.PictureBox()
        Me.PicGuestNum = New System.Windows.Forms.PictureBox()
        Me.PicPrice = New System.Windows.Forms.PictureBox()
        Me.PicCusID = New System.Windows.Forms.PictureBox()
        Me.PicRoomID = New System.Windows.Forms.PictureBox()
        Me.PicBookID = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRoomFrm = New System.Windows.Forms.Button()
        Me.btnCusFrm = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtCheckinDate = New System.Windows.Forms.TextBox()
        Me.txtRoomID = New System.Windows.Forms.ComboBox()
        Me.PicDate = New System.Windows.Forms.PictureBox()
        Me.PicCkinDt = New System.Windows.Forms.PictureBox()
        CType(Me.PicCmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicStayingDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGuestNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCusID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRoomID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBookID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCkinDt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCmt
        '
        Me.txtCmt.Location = New System.Drawing.Point(142, 320)
        Me.txtCmt.Name = "txtCmt"
        Me.txtCmt.Size = New System.Drawing.Size(343, 20)
        Me.txtCmt.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Comments"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(142, 288)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(343, 20)
        Me.txtPrice.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Total Price "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Checkin Date"
        '
        'txtGuesNum
        '
        Me.txtGuesNum.Location = New System.Drawing.Point(142, 222)
        Me.txtGuesNum.Name = "txtGuesNum"
        Me.txtGuesNum.Size = New System.Drawing.Size(343, 20)
        Me.txtGuesNum.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Number of Guest"
        '
        'txtStay
        '
        Me.txtStay.Location = New System.Drawing.Point(143, 184)
        Me.txtStay.Name = "txtStay"
        Me.txtStay.Size = New System.Drawing.Size(343, 20)
        Me.txtStay.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Staying days"
        '
        'txtCusId
        '
        Me.txtCusId.Location = New System.Drawing.Point(142, 143)
        Me.txtCusId.Name = "txtCusId"
        Me.txtCusId.Size = New System.Drawing.Size(343, 20)
        Me.txtCusId.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Customer ID "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Room ID "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Date"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(142, 23)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(343, 20)
        Me.txtID.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Booking ID"
        '
        'PicCmt
        '
        Me.PicCmt.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicCmt.Location = New System.Drawing.Point(501, 324)
        Me.PicCmt.Name = "PicCmt"
        Me.PicCmt.Size = New System.Drawing.Size(20, 16)
        Me.PicCmt.TabIndex = 47
        Me.PicCmt.TabStop = False
        Me.PicCmt.Visible = False
        '
        'PicStayingDay
        '
        Me.PicStayingDay.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicStayingDay.Location = New System.Drawing.Point(501, 188)
        Me.PicStayingDay.Name = "PicStayingDay"
        Me.PicStayingDay.Size = New System.Drawing.Size(20, 16)
        Me.PicStayingDay.TabIndex = 46
        Me.PicStayingDay.TabStop = False
        Me.PicStayingDay.Visible = False
        '
        'PicGuestNum
        '
        Me.PicGuestNum.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicGuestNum.Location = New System.Drawing.Point(501, 222)
        Me.PicGuestNum.Name = "PicGuestNum"
        Me.PicGuestNum.Size = New System.Drawing.Size(20, 16)
        Me.PicGuestNum.TabIndex = 45
        Me.PicGuestNum.TabStop = False
        Me.PicGuestNum.Visible = False
        '
        'PicPrice
        '
        Me.PicPrice.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicPrice.Location = New System.Drawing.Point(501, 288)
        Me.PicPrice.Name = "PicPrice"
        Me.PicPrice.Size = New System.Drawing.Size(20, 16)
        Me.PicPrice.TabIndex = 43
        Me.PicPrice.TabStop = False
        Me.PicPrice.Visible = False
        '
        'PicCusID
        '
        Me.PicCusID.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicCusID.Location = New System.Drawing.Point(501, 147)
        Me.PicCusID.Name = "PicCusID"
        Me.PicCusID.Size = New System.Drawing.Size(20, 16)
        Me.PicCusID.TabIndex = 42
        Me.PicCusID.TabStop = False
        Me.PicCusID.Visible = False
        '
        'PicRoomID
        '
        Me.PicRoomID.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicRoomID.Location = New System.Drawing.Point(501, 107)
        Me.PicRoomID.Name = "PicRoomID"
        Me.PicRoomID.Size = New System.Drawing.Size(20, 16)
        Me.PicRoomID.TabIndex = 41
        Me.PicRoomID.TabStop = False
        Me.PicRoomID.Visible = False
        '
        'PicBookID
        '
        Me.PicBookID.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicBookID.Location = New System.Drawing.Point(501, 23)
        Me.PicBookID.Name = "PicBookID"
        Me.PicBookID.Size = New System.Drawing.Size(20, 16)
        Me.PicBookID.TabIndex = 39
        Me.PicBookID.TabStop = False
        Me.PicBookID.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(69, 355)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 23)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRoomFrm
        '
        Me.btnRoomFrm.Location = New System.Drawing.Point(544, 23)
        Me.btnRoomFrm.Name = "btnRoomFrm"
        Me.btnRoomFrm.Size = New System.Drawing.Size(123, 23)
        Me.btnRoomFrm.TabIndex = 48
        Me.btnRoomFrm.Text = "Room Form"
        Me.btnRoomFrm.UseVisualStyleBackColor = True
        '
        'btnCusFrm
        '
        Me.btnCusFrm.Location = New System.Drawing.Point(544, 61)
        Me.btnCusFrm.Name = "btnCusFrm"
        Me.btnCusFrm.Size = New System.Drawing.Size(123, 23)
        Me.btnCusFrm.TabIndex = 49
        Me.btnCusFrm.Text = "Customer  Form"
        Me.btnCusFrm.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(142, 64)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(343, 20)
        Me.txtDate.TabIndex = 51
        '
        'txtCheckinDate
        '
        Me.txtCheckinDate.Location = New System.Drawing.Point(142, 256)
        Me.txtCheckinDate.Name = "txtCheckinDate"
        Me.txtCheckinDate.Size = New System.Drawing.Size(343, 20)
        Me.txtCheckinDate.TabIndex = 52
        '
        'txtRoomID
        '
        Me.txtRoomID.AutoCompleteCustomSource.AddRange(New String() {"""1""", """2""", """3""", """4""", """5"""})
        Me.txtRoomID.FormattingEnabled = True
        Me.txtRoomID.Location = New System.Drawing.Point(142, 105)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.Size = New System.Drawing.Size(343, 21)
        Me.txtRoomID.TabIndex = 53
        '
        'PicDate
        '
        Me.PicDate.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicDate.Location = New System.Drawing.Point(501, 64)
        Me.PicDate.Name = "PicDate"
        Me.PicDate.Size = New System.Drawing.Size(20, 16)
        Me.PicDate.TabIndex = 54
        Me.PicDate.TabStop = False
        Me.PicDate.Visible = False
        '
        'PicCkinDt
        '
        Me.PicCkinDt.Image = Global.WindowsApplication1.My.Resources.Resources.Button_Close_icon
        Me.PicCkinDt.Location = New System.Drawing.Point(501, 256)
        Me.PicCkinDt.Name = "PicCkinDt"
        Me.PicCkinDt.Size = New System.Drawing.Size(20, 16)
        Me.PicCkinDt.TabIndex = 55
        Me.PicCkinDt.TabStop = False
        Me.PicCkinDt.Visible = False
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 450)
        Me.Controls.Add(Me.PicCkinDt)
        Me.Controls.Add(Me.PicDate)
        Me.Controls.Add(Me.txtRoomID)
        Me.Controls.Add(Me.txtCheckinDate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnCusFrm)
        Me.Controls.Add(Me.btnRoomFrm)
        Me.Controls.Add(Me.PicCmt)
        Me.Controls.Add(Me.PicStayingDay)
        Me.Controls.Add(Me.PicGuestNum)
        Me.Controls.Add(Me.PicPrice)
        Me.Controls.Add(Me.PicCusID)
        Me.Controls.Add(Me.PicRoomID)
        Me.Controls.Add(Me.PicBookID)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCmt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtGuesNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtStay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCusId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Booking"
        Me.Text = "Booking "
        CType(Me.PicCmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicStayingDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGuestNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCusID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRoomID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBookID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCkinDt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCmt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGuesNum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStay As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCusId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PicCmt As System.Windows.Forms.PictureBox
    Friend WithEvents PicStayingDay As System.Windows.Forms.PictureBox
    Friend WithEvents PicGuestNum As System.Windows.Forms.PictureBox
    Friend WithEvents PicPrice As System.Windows.Forms.PictureBox
    Friend WithEvents PicCusID As System.Windows.Forms.PictureBox
    Friend WithEvents PicRoomID As System.Windows.Forms.PictureBox
    Friend WithEvents PicBookID As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRoomFrm As System.Windows.Forms.Button
    Friend WithEvents btnCusFrm As System.Windows.Forms.Button
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtCheckinDate As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomID As System.Windows.Forms.ComboBox
    Friend WithEvents PicDate As System.Windows.Forms.PictureBox
    Friend WithEvents PicCkinDt As System.Windows.Forms.PictureBox
End Class
