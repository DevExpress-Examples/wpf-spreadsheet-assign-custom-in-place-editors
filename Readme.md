<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128612625/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T385458)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfSpreadsheet_CustomCellEditors/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfSpreadsheet_CustomCellEditors/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfSpreadsheet_CustomCellEditors/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfSpreadsheet_CustomCellEditors/MainWindow.xaml.vb))
<!-- default file list end -->
# How to assign custom in-place editors to worksheet cells (WPF Spreadsheet)


This example demonstrates how to use custom editors for in-place editing of cell content. Both predefined editors supported by the <strong>SpreadsheetControl</strong> for in-place editing (<a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfEditorsComboBoxEdittopic">ComboBoxEdit</a>, <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfEditorsDateEdittopic">DateEdit</a>, and <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfEditorsCheckEdittopic">CheckEdit</a>) and the custom editor (<a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfEditorsSpinEdittopic">SpinEdit</a>) are used to edit cells located in the specific columns of a worksheet table.<br>To assign an in-place editor of a predefined type to a specific cell range in a worksheet, use the <strong>Add</strong> method of the <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressSpreadsheetCustomCellInplaceEditorCollectiontopic">CustomCellInplaceEditorCollection</a> collection, which stores the custom cell editors specified in a worksheet.<br>To assign your own custom editor to a cell, handle the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfSpreadsheetSpreadsheetControl_CustomCellEdittopic">SpreadsheetControl.CustomCellEdit</a> event. This event fires when a user is about to start editing a cell and allows you to supply a custom in-place editor to the edited cell by setting a corresponding <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfEditorsSettingsBaseEditSettingstopic">BaseEditSettings</a> descendant to the event's <strong>EditSettings</strong> parameter.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-spreadsheet-assign-custom-in-place-editors&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-spreadsheet-assign-custom-in-place-editors&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
