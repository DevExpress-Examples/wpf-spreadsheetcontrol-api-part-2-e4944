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

            return examples;
            #endregion
        }
    }
}
