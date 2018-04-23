Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SpreadsheetControl_WPF_API_Part02
    Partial Public Class Groups
        Inherits List(Of Group)
        Public Shared Function InitData() As Groups
            Dim examples As New Groups()

            '			#Region "GroupNodes"
            examples.Add(New Group("Shapes"))
            examples.Add(New Group("Custom Functions"))
            examples.Add(New Group("Tables"))
            '			#End Region

            '			#Region "ExampleNodes"
            ' Add nodes to the "Shapes" group of examples.
            examples(0).Items.Add(New SpreadsheetExample("Insert a picture", ShapeActions.InsertShapeAction))
            examples(0).Items.Add(New SpreadsheetExample("Insert a picture from URI", ShapeActions.InsertShapeFromUriAction))
            examples(0).Items.Add(New SpreadsheetExample("Modify a picture", ShapeActions.ModifyShapeAction))

            ' Add nodes to the "Custom Functions" group of examples.
            examples(1).Items.Add(New SpreadsheetExample("Add a SPHEREMASS function", CustomFunctionActions.SphereMassAction))

            ' Add nodes to the "Tables" group of examples.
            examples(2).Items.Add(New SpreadsheetExample("Create a table", TableActions.CreateTableAction))
            examples(2).Items.Add(New SpreadsheetExample("Apply a custom style", TableActions.CustomTableStyleAction))
            Return examples
            '			#End Region
        End Function
    End Class
End Namespace
