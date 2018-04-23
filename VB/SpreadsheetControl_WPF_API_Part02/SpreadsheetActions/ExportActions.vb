Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Export
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SpreadsheetControl_WPF_API_Part02
    Friend Class ExportActions
        #Region "Actions"
        Public Shared ExportToHTMLAction As Action(Of IWorkbook) = AddressOf ExportToHTML
        #End Region

        Private Shared Sub ExportToHTML(ByVal workbook As IWorkbook)
'            #Region "#ExportToHTML"
            workbook.LoadDocument("Documents\ExpenseReport.xlsx")
            workbook.Calculate()
            Dim worksheet As Worksheet = workbook.Worksheets(0)

            ' Create an object containing HTML export options.
            Dim options As New HtmlDocumentExporterOptions()

            ' Set HTML-specific export options.
            options.CssPropertiesExportType = DevExpress.XtraSpreadsheet.Export.Html.CssPropertiesExportType.Style
            options.Encoding = Encoding.UTF8

            ' Specify the part of the document to be exported to HTML.
            options.SheetIndex = worksheet.Index
            options.Range = "B11:O28"

            ' Export a document to an HTML file with the specified options.
            workbook.ExportToHtml("OutputRange.html", options)

            ' Export the entire worksheet to a stream as HTML.
            Dim htmlStream As New FileStream("OutputWorksheet.html", FileMode.Create)
            workbook.ExportToHtml(htmlStream, worksheet.Index)
'            #End Region ' #ExportToHTML

            System.Diagnostics.Process.Start("OutputRange.html")
            System.Diagnostics.Process.Start("OutputWorksheet.html")
        End Sub
    End Class
End Namespace
