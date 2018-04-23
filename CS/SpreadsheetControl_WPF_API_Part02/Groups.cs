using System.Collections.Generic;

namespace SpreadsheetControl_WPF_API_Part02
{
    public partial class Groups : List<Group>
    {
        public static Groups InitData()
        {
            Groups examples = new Groups();

            #region GroupNodes
            examples.Add(new Group("Shapes"));
            examples.Add(new Group("Custom Functions"));
            examples.Add(new Group("Tables"));
            examples.Add(new Group("Protection"));
            examples.Add(new Group("Search"));
            examples.Add(new Group("Sort"));
            examples.Add(new Group("Export"));
            #endregion

            #region ExampleNodes
            // Add nodes to the "Shapes" group of examples.
            examples[0].Items.Add(new SpreadsheetExample("Insert a picture", ShapeActions.InsertShapeAction));
            examples[0].Items.Add(new SpreadsheetExample("Insert a picture from URI", ShapeActions.InsertShapeFromUriAction));
            examples[0].Items.Add(new SpreadsheetExample("Modify a picture", ShapeActions.ModifyShapeAction));

            // Add nodes to the "Custom Functions" group of examples.
            examples[1].Items.Add(new SpreadsheetExample("Add a SPHEREMASS function", CustomFunctionActions.SphereMassAction));

            // Add nodes to the "Tables" group of examples.
            examples[2].Items.Add(new SpreadsheetExample("Create a table", TableActions.CreateTableAction));
            examples[2].Items.Add(new SpreadsheetExample("Apply a custom style", TableActions.CustomTableStyleAction));

            // Add nodes to the "Protection" group of examples.
            examples[3].Items.Add(new SpreadsheetExample("Protect workbook", ProtectionActions.ProtectWorkbookAction));
            examples[3].Items.Add(new SpreadsheetExample("Protect worksheet", ProtectionActions.ProtectWorksheetAction));
            examples[3].Items.Add(new SpreadsheetExample("Protect range", ProtectionActions.ProtectRangeAction));


            // Add nodes to the "Search" group of examples.
            examples[4].Items.Add(new SpreadsheetExample("Simple Search", SearchActions.SimpleSearchAction));
            examples[4].Items.Add(new SpreadsheetExample("Advanced Search", SearchActions.AdvancedSearchAction));

            // Add nodes to the "Sort" group of examples.
            examples[5].Items.Add(new SpreadsheetExample("Simple sort", SortActions.SimpleSortAction));
            examples[5].Items.Add(new SpreadsheetExample("Sort in descending order", SortActions.DescendingOrderAction));
            examples[5].Items.Add(new SpreadsheetExample("Sort using custom comparer", SortActions.SelectComparerAction));
            examples[5].Items.Add(new SpreadsheetExample("Sort by column", SortActions.SortBySpecifiedColumnAction));
            examples[5].Items.Add(new SpreadsheetExample("Sort by multiple columns", SortActions.SortByMultipleColumnsAction));

            // Add nodes to the "Export" group of examples.
            examples[6].Items.Add(new SpreadsheetExample("Export to HTML", ExportActions.ExportToHTMLAction));

            return examples;
            #endregion
        }
    }
}
