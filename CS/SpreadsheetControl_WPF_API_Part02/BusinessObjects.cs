using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;


namespace SpreadsheetControl_WPF_API_Part02
{
    public class Group
    {
        public string Header { get; set; }
        public List<SpreadsheetExample> Items { get; set; }

        public Group(string name)
        {
            Header = name;
            Items = new List<SpreadsheetExample>();
        }        
    }

    public class SpreadsheetExample
    {
        public string Header { get; set; }
        public SpreadsheetExample(string name, Action<IWorkbook> action)
        {
            Header = name;
            Action = action;
        }
        public Action<IWorkbook> Action { get; private set; }
    }
}
