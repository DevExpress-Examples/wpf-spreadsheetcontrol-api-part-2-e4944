﻿Imports DevExpress.Spreadsheet
Imports System
Imports System.Collections.Generic


Namespace SpreadsheetControl_WPF_API_Part02
    Public Class Group
        Public Property Header() As String
        Public Property Items() As List(Of SpreadsheetExample)

        Public Sub New(ByVal name As String)
            Header = name
            Items = New List(Of SpreadsheetExample)()
        End Sub
    End Class

    Public Class SpreadsheetExample
        Public Property Header() As String
        Public Sub New(ByVal name As String, ByVal action As Action(Of IWorkbook))
            Header = name
            Me.Action = action
        End Sub
        Private privateAction As Action(Of IWorkbook)
        Public Property Action() As Action(Of IWorkbook)
            Get
                Return privateAction
            End Get
            Private Set(ByVal value As Action(Of IWorkbook))
                privateAction = value
            End Set
        End Property
    End Class
End Namespace
