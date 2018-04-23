﻿Imports DevExpress.Spreadsheet
Imports System
Imports System.Collections.Generic
Imports System.Drawing

Namespace SpreadsheetControl_WPF_API_Part02
    Public NotInheritable Class DocumentPropertiesActions
#Region "DocumentProperties"
        Public Shared BuiltInPropertiesAction As Action(Of IWorkbook) = AddressOf BuiltInPropertiesValue
        Public Shared CustomPropertiesAction As Action(Of IWorkbook) = AddressOf CustomPropertiesValue
#End Region

        Private Shared Sub BuiltInPropertiesValue(ByVal workbook As IWorkbook)
            workbook.BeginUpdate()
            Try
                Dim worksheet As Worksheet = workbook.Worksheets(0)
                worksheet.Columns(0).WidthInCharacters = 2

                Dim header As Range = worksheet.Range("B2:C2")
                header(0).Value = "Property Name"
                header(1).Value = "Value"
                header.Style = workbook.Styles(BuiltInStyleId.Accent2)

                '				#Region "#Built-inProperties"
                ' Set the built-in document properties.
                workbook.DocumentProperties.Title = "Spreadsheet API: document properties example"
                workbook.DocumentProperties.Description = "How to manage document properties using the Spreadsheet API"
                workbook.DocumentProperties.Keywords = "Spreadsheet, API, properties, OLEProps"
                workbook.DocumentProperties.Company = "Developer Express Inc."

                ' Display the specified built-in properties in a worksheet.
                worksheet("B3").Value = "Title"
                worksheet("C3").Value = workbook.DocumentProperties.Title
                worksheet("B4").Value = "Description"
                worksheet("C4").Value = workbook.DocumentProperties.Description
                worksheet("B5").Value = "Keywords"
                worksheet("C5").Value = workbook.DocumentProperties.Keywords
                worksheet("B6").Value = "Company"
                worksheet("C6").Value = workbook.DocumentProperties.Company
                '				#End Region ' #Built-inProperties

                worksheet.Columns.AutoFit(1, 2)
            Finally
                workbook.EndUpdate()
            End Try
        End Sub

        Private Shared Sub CustomPropertiesValue(ByVal workbook As IWorkbook)
            workbook.BeginUpdate()
            Try
                Dim worksheet As Worksheet = workbook.Worksheets(0)
                worksheet.Columns(0).WidthInCharacters = 2

                Dim header As Range = worksheet.Range("B2:C2")
                header(0).Value = "Property Name"
                header(1).Value = "Value"
                header.Style = workbook.Styles(BuiltInStyleId.Accent2)
                header.ColumnWidthInCharacters = 20

                '				#Region "#CustomProperties"
                ' Set the custom document properties.
                workbook.DocumentProperties.Custom("Checked by") = "Mike Hamilton"
                workbook.DocumentProperties.Custom("Revision") = 3
                workbook.DocumentProperties.Custom("Completed") = True
                workbook.DocumentProperties.Custom("Published") = DateTime.Now

                ' Display the specified custom properties in a worksheet.
                Dim customPropertiesNames As IEnumerable(Of String) = workbook.DocumentProperties.Custom.Names
                Dim rowIndex As Integer = 2
                For Each propertyName As String In customPropertiesNames
                    worksheet(rowIndex, 1).Value = propertyName
                    worksheet(rowIndex, 2).Value = workbook.DocumentProperties.Custom(propertyName)
                    If worksheet(rowIndex, 2).Value.IsDateTime Then
                        worksheet(rowIndex, 2).NumberFormat = "[$-409]m/d/yyyy h:mm AM/PM"
                    End If
                    rowIndex += 1
                Next propertyName
                '				#End Region ' #CustomProperties

                '				#Region "#RemoveCustomProperty"
                ' Remove an individual custom document property.
                workbook.DocumentProperties.Custom("Published") = Nothing
                '				#End Region ' #RemoveCustomProperty

                '				#Region "#ClearCustomProperties"
                ' Remove all custom document properties.
                workbook.DocumentProperties.Custom.Clear()
                '				#End Region ' #ClearCustomProperties
            Finally
                workbook.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
