Imports System.Collections.Generic

Namespace SpreadsheetControl_WPF_API_Part02
    Partial Public Class Groups
        Inherits List(Of Group)

        Public Shared Function InitData() As Groups
            Dim examples As New Groups()

'            #Region "GroupNodes"
            examples.Add(New Group("Shapes"))
            examples.Add(New Group("Custom Functions"))
            examples.Add(New Group("Tables"))
            examples.Add(New Group("Protection"))
            examples.Add(New Group("Search"))
            examples.Add(New Group("Sort"))
            examples.Add(New Group("Export"))
'            #End Region

'            #Region "ExampleNodes"
            ' Add nodes to the "Shapes" group of examples.
            examples(0).Items.Add(New SpreadsheetExample("Insert a picture", ShapeActions.InsertShapeAction))
            examples(0).Items.Add(New SpreadsheetExample("Insert a picture from URI", ShapeActions.InsertShapeFromUriAction))
            examples(0).Items.Add(New SpreadsheetExample("Modify a picture", ShapeActions.ModifyShapeAction))

            ' Add nodes to the "Custom Functions" group of examples.
            examples(1).Items.Add(New SpreadsheetExample("Add a SPHEREMASS function", CustomFunctionActions.SphereMassAction))

            ' Add nodes to the "Tables" group of examples.
            examples(2).Items.Add(New SpreadsheetExample("Create a table", TableActions.CreateTableAction))
            examples(2).Items.Add(New SpreadsheetExample("Apply a custom style", TableActions.CustomTableStyleAction))

            ' Add nodes to the "Protection" group of examples.
            examples(3).Items.Add(New SpreadsheetExample("Protect workbook", ProtectionActions.ProtectWorkbookAction))
            examples(3).Items.Add(New SpreadsheetExample("Protect worksheet", ProtectionActions.ProtectWorksheetAction))
            examples(3).Items.Add(New SpreadsheetExample("Protect range", ProtectionActions.ProtectRangeAction))


            ' Add nodes to the "Search" group of examples.
            examples(4).Items.Add(New SpreadsheetExample("Simple Search", SearchActions.SimpleSearchAction))
            examples(4).Items.Add(New SpreadsheetExample("Advanced Search", SearchActions.AdvancedSearchAction))

            ' Add nodes to the "Sort" group of examples.
            examples(5).Items.Add(New SpreadsheetExample("Simple sort", SortActions.SimpleSortAction))
            examples(5).Items.Add(New SpreadsheetExample("Sort in descending order", SortActions.DescendingOrderAction))
            examples(5).Items.Add(New SpreadsheetExample("Sort using custom comparer", SortActions.SelectComparerAction))
            examples(5).Items.Add(New SpreadsheetExample("Sort by column", SortActions.SortBySpecifiedColumnAction))
            examples(5).Items.Add(New SpreadsheetExample("Sort by multiple columns", SortActions.SortByMultipleColumnsAction))

            ' Add nodes to the "Export" group of examples.
            examples(6).Items.Add(New SpreadsheetExample("Export to HTML", ExportActions.ExportToHTMLAction))

            Return examples
'            #End Region
        End Function
    End Class
End Namespace
