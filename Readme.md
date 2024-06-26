<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128612625/19.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T385458)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Spreadsheet Control for WPF - Assign Custom In-place Editors to Worksheet Cells

This example demonstrates how to use custom editors for in-place editing of cell content. Both predefined editors supported by the <strong>SpreadsheetControl</strong> for in-place editing ([ComboBoxEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.ComboBoxEdit), [DateEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.DateEdit), and [CheckEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.CheckEdit)) and the custom editor ([SpinEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.SpinEdit)) are used to edit cells located in the specific columns of a worksheet table.

## Implementation Details

To assign an in-place editor of a predefined type to a specific cell range in a worksheet, use the `Add` method of the [CustomCellInplaceEditorCollection](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.CustomCellInplaceEditorCollection) collection, which stores the custom cell editors specified in a worksheet.

To assign your own custom editor to a cell, handle the [SpreadsheetControl.CustomCellEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Spreadsheet.SpreadsheetControl.CustomCellEdit) event. This event fires when a user is about to start editing a cell and allows you to supply a custom in-place editor to the edited cell by setting a corresponding [BaseEditSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.BaseEditSettings) descendant to the event's `EditSettings` parameter.

## Files to Review

* [MainWindow.xaml](./CS/WpfSpreadsheet_CustomCellEditors/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfSpreadsheet_CustomCellEditors/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfSpreadsheet_CustomCellEditors/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfSpreadsheet_CustomCellEditors/MainWindow.xaml.vb))

## Documentation

* [Custom Cell In-place Editors](https://docs.devexpress.com/WPF/116399/controls-and-libraries/spreadsheet/cell-basics/custom-cell-in-place-editors)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-spreadsheet-assign-custom-in-place-editors&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-spreadsheet-assign-custom-in-place-editors&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
