Option Explicit On
Option Strict On

Imports System.Data.OleDb
Imports System.IO

Public Class ProductController

    Public Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProcurementDB.accdb"

    'what is the meaning of public sub, what is byref, byval  
    'Insert method is sub routine 

    'insert data into database sub 
    Public Sub insert(ByVal htdata As Hashtable)
       
        Dim myConnection As OleDbConnection = New OleDbConnection

       

        myConnection.Open()

        Try
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = myConnection

            oCommand.CommandText = "INSERT INTO product (SKU,product_name,product_description,category,reorder_level,lead_time,discontinued,unit_price) VALUES(?,?,?,?,?,?,?,?);"

            oCommand.Parameters.Add("SKU", OleDbType.Integer, 1)
            oCommand.Parameters.Add("ProductName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("ProductDescription", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Category", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("ReorderLevel", OleDbType.Integer, 4)
            oCommand.Parameters.Add("LeadTime", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Discontinued", OleDbType.Integer, 1)
            oCommand.Parameters.Add("UnitPrice", OleDbType.Double, 8)

            oCommand.Parameters("SKU").Value = CInt(htdata("SKU"))
            oCommand.Parameters("ProductName").Value = CStr(htdata("ProductName"))
            oCommand.Parameters("ProductDescription").Value = CStr(htdata("ProductDescription"))
            oCommand.Parameters("Category").Value = CStr(htdata("Category"))
            oCommand.Parameters("ReorderLevel").Value = CInt(htdata("ReorderLevel"))
            oCommand.Parameters("LeadTime").Value = CStr(htdata("LeadTime"))
            oCommand.Parameters("Discontinued").Value = CInt(htdata("Discontinued"))
            oCommand.Parameters("UnitPrice").Value = CInt(htdata("UnitPrice"))

            oCommand.Prepare()
            MsgBox("SQL:" & oCommand.CommandText)
            oCommand.ExecuteNonQuery()
            'line in order to import data to the database - therefore this is needed of oCommand.Open() and oCommand.Prepare()  and oCommand.Executive
            MsgBox("the data is imported")
        Catch ex As Exception
            MsgBox("fail")
        End Try
    End Sub
    'find all function lab5.1
    Public Function findAll() As List(Of Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        'Try
        Debug.Print("Connection String: " & oConnection.ConnectionString)

        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection

        'to do

        oCommand.CommandText = "SELECT * FROM product ORDER BY SKU;"

        oCommand.Prepare()
        Dim oDataReader = oCommand.ExecuteReader()

        Dim htTempData As Hashtable

        Do While oDataReader.Read() = True
            htTempData = New Hashtable
            htTempData("SKU") = CInt(oDataReader("SKU"))
            htTempData("ProductName") = CStr(oDataReader("product_name"))
            htTempData("ProductDescription") = CStr(oDataReader("product_description"))
            htTempData("Category") = CStr(oDataReader("category"))
            htTempData("ReorderLevel") = CInt(oDataReader("reorder_level"))
            htTempData("LeadTime") = CStr(oDataReader("lead_time"))
            htTempData("Discontinued") = CInt(oDataReader("discontinued"))
            htTempData("UnitPrice") = CDbl(oDataReader("unit_price"))
            lsData.Add(htTempData)
        Loop

        Debug.Print("the records were found")

        'Catch ex As Exception
        '    Debug.Print("ERROR: " & ex.Message)
        '    MsgBox("an error occured")

        'Finally
        '    oConnection.Close()
        'End Try

        Return lsData

    End Function

    'findbyID function Lab5.2
    Public Function findById(sId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection String: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand

            oCommand.Connection = oConnection
            oCommand.CommandText = "SELECT * FROM product WHERE SKU = ?;"
            oCommand.Parameters.Add("SKU", OleDbType.Integer, 8)
            oCommand.Parameters("SKU").Value = CInt(sId)
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("SKU") = CStr(oDataReader("SKU"))
                htTempData("ProductName") = CStr(oDataReader("product_name"))
                htTempData("ProductDescription") = CStr(oDataReader("product_description"))
                htTempData("Category") = CStr(oDataReader("category"))
                htTempData("ReorderLevel") = CStr(oDataReader("reorder_level"))
                htTempData("LeadTime") = CStr(oDataReader("lead_time"))
                htTempData("Discontinued") = CStr(oDataReader("discontinued"))
                htTempData("UnitPrice") = CStr(oDataReader("unit_price"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("the record was found.")
            


        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("an error occured. The record(s) could not be found")
        Finally
            oConnection.Close()

        End Try

        Return lsData
    End Function

    'updating record lab5.3
    Public Function update(ByVal htData As Hashtable) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'Todo 

            oCommand.CommandText = "UPDATE product SET product_name = ?, product_description = ?, category = ?, reorder_level = ?, lead_time = ?, discontinued = ?, unit_price = ? WHERE SKU = ?;"

            oCommand.Parameters.Add("ProductName", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("ProductDescription", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Category", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("ReorderLevel", OleDbType.Integer, 4)
            oCommand.Parameters.Add("LeadTime", OleDbType.VarChar, 255)
            oCommand.Parameters.Add("Discontinued", OleDbType.Integer, 1)
            oCommand.Parameters.Add("UnitPrice", OleDbType.Double, 8)
            oCommand.Parameters.Add("SKU", OleDbType.Integer, 1)


            oCommand.Parameters("ProductName").Value = CStr(htData("ProductName"))
            oCommand.Parameters("ProductDescription").Value = CStr(htData("ProductDescription"))
            oCommand.Parameters("Category").Value = CStr(htData("Category"))
            oCommand.Parameters("ReorderLevel").Value = CInt(htData("ReorderLevel"))
            oCommand.Parameters("LeadTime").Value = CStr(htData("LeadTime"))
            oCommand.Parameters("Discontinued").Value = CInt(htData("Discontinued"))
            oCommand.Parameters("UnitPrice").Value = CInt(htData("UnitPrice"))
            oCommand.Parameters("SKU").Value = CInt(htData("SKU"))

            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            Debug.Print("the record was updated.")



        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox(" an error occured. The record was not updated")

        Finally
            oConnection.Close()

        End Try

        Return iNumRows

    End Function

    'Delete a record lab 5.4

    Public Function delete(sId As String) As Integer

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim iNumRows As Integer

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            'todo
            oCommand.CommandText = "DELETE FROM product WHERE SKU = ?;"
            oCommand.Parameters.Add("SKU", OleDbType.Integer, 8)
            oCommand.Parameters("SKU").Value = CInt(sId)
            oCommand.Prepare()
            iNumRows = oCommand.ExecuteNonQuery()

            Debug.Print(CStr(iNumRows))
            Debug.Print("The record was deleted.")

        Catch ex As Exception
            Debug.Print(CStr(iNumRows))
            Debug.Print("an error occured. the record was not deleted")

        Finally
            oConnection.Close()
        End Try

        Return iNumRows

    End Function

    Public Sub createReport01()

        Debug.Print("Create Report ... ")

        Dim lsData = findAll()
        Dim sReportTitle = "Product Report by ..."
        Dim sReportContent = generateReport01(lsData, sReportTitle)
        Dim sReportFilename = "ProductReport-01.html"

        saveReport(sReportContent, sReportFilename)

        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

        'rm the code system.Diagnostics. 
    End Sub
    ' whyy this oone is private fucntion 
    Private Function generateReport01(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        Debug.Print("GenerateReport01 ...")

        Dim sReportContent As String

        '1.Generate the start of the HTML file

        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""eng"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        '2.Generate the product table and its rows 
        Dim sTable = generateTable(lsData)
        sReportContent &= sTable & vbCrLf

        '3.Generate the end of the HTML file 
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag



        Return sReportContent

    End Function

    Private Sub saveReport(ByVal sReportContent As String, ByVal sReportfilename As String)
        Debug.Print("SaveReport: " & sReportfilename)

        Dim oReportFile As StreamWriter = New StreamWriter(Application.StartupPath & "\" & sReportfilename)

        'Check if the file is open before starting to write to it 

        If Not (oReportFile Is Nothing) Then
            oReportFile.Write(sReportContent)
            oReportFile.Close()
        End If
    End Sub

    Private Function generateTable(ByVal lsData As List(Of Hashtable)) As String
        'Generate the start of the table
        'vbCrLf = down a line and going to the left or feed or st
        Dim sTable = "<table border""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("SKU")
        lsKeys.Add("ProductName")
        lsKeys.Add("ProductDescription")
        lsKeys.Add("Category")
        lsKeys.Add("ReorderLevel")
        lsKeys.Add("LeadTime")
        lsKeys.Add("Discontinued")
        lsKeys.Add("UnitPrice")



        ' Generate the header row
        Dim sHeadderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeadderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeadderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeadderRow)
        sTable &= sHeadderRow

        'Generate the table rows 
        For Each record In lsData
            Dim product As Hashtable = record
            Dim sTableRow = "<tr>" & vbCrLf

            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sTable &= sTableRow
        Next
        'Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable
    End Function


    'BREAK REPORT:
    'Need to summary all the funciton needed in order to run this function 
    '

    Public Sub createBreakReport()
        Debug.Print("CreatBreakReport...")

        Dim lsData = findAll()
        Dim sReportTitle = "Product Control Break Report "
        Dim sReportContent = generateBreakReport(lsData, sReportTitle)
        'lsData is ... sReporttiltle is 
        Dim sReportFilename = "ProductBreakReport.html"
        saveReport(sReportContent, sReportFilename)

        Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
        ' the """"" can fix into the access to the file path
        Debug.Print("sParam: " & sParam)

        System.Diagnostics.Process.Start(sParam)

    End Sub

    Private Function generateBreakReport(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        'This part seem like the code is going to take the value from 1.the lsDATA whihc was dimed before in the clas
        'and the sReportitle whihc is going to be printed in the things ]

        Debug.Print("GenerateBreakeReport ...")

        Dim sReportContent As String

        '1.Generate the start of the HTML file

        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""eng"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        '2.Generate the product table and its rows 
        Dim sTable = generateControlBreakeTale(lsData)
        sReportContent &= sTable & vbCrLf


        '3.Generate the end of the HTML file 
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag



        Return sReportContent

    End Function

    Private Function generateControlBreakeTale(ByVal lsData As List(Of Hashtable)) As String
        'byVal do not needed to be dimed again in the code 

        'Generate the start of the table
        'vbCrLf = down a line and going to the left or feed or st
        Dim sTable = "<table border""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("SKU")
        lsKeys.Add("ProductName")
        lsKeys.Add("ProductDescription")
        lsKeys.Add("Category")
        lsKeys.Add("ReorderLevel")
        lsKeys.Add("LeadTime")
        lsKeys.Add("Discontinued")
        lsKeys.Add("UnitPrice")



        ' Generate the header row
        Dim sHeadderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeadderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeadderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeadderRow)
        sTable &= sHeadderRow

        'Generate the table rows 
        sTable &= generateTableRows(lsData, lsKeys)

        'Generate the end of the table 
        sTable &= "</table>" & vbCrLf

        'What is the difference between the 2 code 
        'For Each record In lsData
        '    Dim product As Hashtable = record
        '    Dim sTableRow = "<tr>" & vbCrLf

        '    For Each key In lsKeys
        '        sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
        '    Next
        '    sTableRow &= "</tr>" & vbCrLf
        '    Debug.Print("sTableRow: " & sTableRow)
        '    sTable &= sTableRow
        'Next
        ''Generate the end of the table
        'sTable &= "</table>" & vbCrLf



        Return sTable
    End Function


    Private Function generateTableRows(ByVal lsData As List(Of Hashtable), ByVal lsKeys As List(Of String)) As String

        '1.Instalisation 
        Dim sRows As String = ""
        Dim sTableRow As String
        Dim iCountRecordsPerCategory As Integer = 0
        Dim bFirstTime As Boolean = True
        Dim sCurrentControlField As String = ""
        Dim sPreviousControlField As String = ""

        '2. Loop through the list of hashtables
        For Each record In lsData

            '2a. Get a product and set the current key
            Dim product As Hashtable = record
            sCurrentControlField = CStr(product("Category"))

            '2b. Do not check for control break on the first iteration of the loop
            If bFirstTime Then
                bFirstTime = False
            Else
                'Output total row if change in control field
                'And reset the total
                If sCurrentControlField <> sPreviousControlField Then
                    sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & " Total products in " & sPreviousControlField _
                        & " category: " & iCountRecordsPerCategory _
                        & "</td></tr>" _
                        & vbCrLf
                    sRows &= sTableRow
                    iCountRecordsPerCategory = 0
                End If
            End If

            ' 2c. Output a normal row for every pass thru' the list
            sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sRows &= sTableRow

            '2d. Update control field and increment total
            sPreviousControlField = sCurrentControlField
            iCountRecordsPerCategory += 1
        Next

        '3. After the loop, need to output the last total row
        sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & " Total products in " & sCurrentControlField _
                        & " category: " & iCountRecordsPerCategory _
                        & "</td></tr>" _
                        & vbCrLf
        sRows &= sTableRow

        Return sRows
    End Function
End Class
