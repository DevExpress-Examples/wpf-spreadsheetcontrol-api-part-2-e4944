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
            examples.Add(New Group("Group Data"))
            examples.Add(New Group("Filter Data"))
            examples.Add(New Group("Document Properties"))

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

            ' Add nodes to the "Group Data" group of examples.
            examples(7).Items.Add(New SpreadsheetExample("Group Rows", GroupAndOutlineActions.GroupRowsAction))
            examples(7).Items.Add(New SpreadsheetExample("Group Columns", GroupAndOutlineActions.GroupColumnsAction))
            examples(7).Items.Add(New SpreadsheetExample("Unroup Rows", GroupAndOutlineActions.UngroupRowsAction))
            examples(7).Items.Add(New SpreadsheetExample("Unroup Columns", GroupAndOutlineActions.UngroupColumnsAction))
            examples(7).Items.Add(New SpreadsheetExample("Create an Auto Outline", GroupAndOutlineActions.AutoOutlineAction))
            examples(7).Items.Add(New SpreadsheetExample("Insert Subtotals", GroupAndOutlineActions.SubtotalAction))

            ' Add nodes to the "Filter Data" group of examples.
            examples(8).Items.Add(New SpreadsheetExample("Enable filtering", AutoFilterActions.ApplyFilterAction))
            examples(8).Items.Add(New SpreadsheetExample("Sort by single column", AutoFilterActions.FilterAndSortBySingleColumnAction))
            examples(8).Items.Add(New SpreadsheetExample("Sort by multiple columns", AutoFilterActions.FilterAndSortByMultipleColumnsAction))
            examples(8).Items.Add(New SpreadsheetExample("Custom number filter", AutoFilterActions.FilterNumericByConditionAction))
            examples(8).Items.Add(New SpreadsheetExample("Custom text filter", AutoFilterActions.FilterTextByConditionAction))
            examples(8).Items.Add(New SpreadsheetExample("Custom date filter", AutoFilterActions.FilterDatesByConditionAction))
            examples(8).Items.Add(New SpreadsheetExample("Filter by single value", AutoFilterActions.FilterByValuesAction))
            examples(8).Items.Add(New SpreadsheetExample("Filter by multiple values", AutoFilterActions.FilterByMultipleValuesAction))
            examples(8).Items.Add(New SpreadsheetExample("Filter mixed data types by values", AutoFilterActions.FilterMixedDataTypesByValuesAction))
            examples(8).Items.Add(New SpreadsheetExample("Apply Top 10 filter", AutoFilterActions.Top10FilterAction))
            examples(8).Items.Add(New SpreadsheetExample("Apply dynamic filter", AutoFilterActions.DynamicFilterAction))
            examples(8).Items.Add(New SpreadsheetExample("Reapply filter", AutoFilterActions.ReapplyFilterAction))
            examples(8).Items.Add(New SpreadsheetExample("Clear filter", AutoFilterActions.ClearFilterAction))
            examples(8).Items.Add(New SpreadsheetExample("Disable filtering", AutoFilterActions.DisableFilterAction))

            ' Add nodes to the "Document Properties" group of examples.
            examples(9).Items.Add(New SpreadsheetExample("Built-in properties", DocumentPropertiesActions.BuiltInPropertiesAction))
            examples(9).Items.Add(New SpreadsheetExample("Custom properties", DocumentPropertiesActions.CustomPropertiesAction))


            Return examples
'            #End Region
        End Function
    End Class
End Namespace
