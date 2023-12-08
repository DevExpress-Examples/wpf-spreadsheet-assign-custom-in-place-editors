Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.Editors.Settings
Imports DevExpress.Xpf.Spreadsheet
Imports System

Namespace WpfSpreadsheet_CustomCellEditors

    Public Partial Class MainWindow
        Inherits DevExpress.Xpf.Ribbon.DXRibbonWindow

        Public Sub New()
            Me.InitializeComponent()
            Me.spreadsheetControl.LoadDocument("Documents\Document.xlsx", DocumentFormat.Xlsx)
            AddHandler Me.spreadsheetControl.DocumentLoaded, AddressOf Me.spreadsheetControl1_DocumentLoaded
#Region "#CustomCellEdit"
            AddHandler Me.spreadsheetControl.CustomCellEdit, AddressOf Me.spreadsheetControl1_CustomCellEdit
        ' ...
#End Region  ' #CustomCellEdit
        End Sub

        Private Sub spreadsheetControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            BindCustomEditors()
        End Sub

        Private Sub BindCustomEditors()
            Dim worksheet As Worksheet = Me.spreadsheetControl.Document.Worksheets("Sales report")
#Region "#PredefinedEditors"
            ' Use a date editor as the in-place editor for cells located in the "Order Date" column of the worksheet table.
            Dim dateEditRange As Range = worksheet("Table[Order Date]")
            worksheet.CustomCellInplaceEditors.Add(dateEditRange, CustomCellInplaceEditorType.DateEdit)
            ' Use a combo box editor as the in-place editor for cells located in the "Category" column of the worksheet table.
            ' The editor's items are obtained from a cell range in the current worksheet.
            Dim comboBoxRange As Range = worksheet("Table[Category]")
            worksheet.CustomCellInplaceEditors.Add(comboBoxRange, CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(worksheet("J3:J9")))
            ' Use a check editor as the in-place editor for cells located in the "Discount" column of the worksheet table.
            Dim checkBoxRange As Range = worksheet("Table[Discount]")
            worksheet.CustomCellInplaceEditors.Add(checkBoxRange, CustomCellInplaceEditorType.CheckBox)
            ' Use the custom control (SpinEdit) as the in-place editor for cells located in the "Quantity" column of the worksheet table.
            ' To provide the required editor, handle the CustomCellEdit event. 
            Dim customRange As Range = worksheet("Table[Qty]")
            worksheet.CustomCellInplaceEditors.Add(customRange, CustomCellInplaceEditorType.Custom, "MySpinEdit")
#End Region  ' #PredefinedEditors
        End Sub

#Region "#CustomCellEdit"
        Private Sub spreadsheetControl1_CustomCellEdit(ByVal sender As Object, ByVal e As SpreadsheetCustomCellEditEventArgs)
            ' Specify a type of the custom editor assigned to cells of the "Quantity" table column.
            ' To identify the custom editor, use a value of ValueObject associated with it. 
            If e.ValueObject.IsText AndAlso Equals(e.ValueObject.TextValue, "MySpinEdit") Then
                ' Create a SpinEdit in-place editor and assign it to a cell. 
                Dim settings As SpinEditSettings = New SpinEditSettings()
                settings.MinValue = 1
                settings.MaxValue = 1000
                settings.IsFloatValue = False
                e.EditSettings = settings
            End If
        End Sub
#End Region  ' #CustomCellEdit
    End Class
End Namespace
