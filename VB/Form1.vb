Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit.API.Native
#End Region ' #usings

Namespace FieldsExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnAddField_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddField.Click
			Dim document As Document = richEditControl1.Document
			document.Fields.Add(document.CaretPosition, "DATE")
		End Sub

		Private Sub btnUpdateField_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdateField.Click
			richEditControl1.Document.Fields(0).Update()
		End Sub

		Private Sub btnShowFieldCode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowFieldCode.Click
			richEditControl1.Document.Fields(0).ShowCodes = True
		End Sub

		Private Sub btnShowFieldResult_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowFieldResult.Click
			richEditControl1.Document.Fields(0).ShowCodes = False

		End Sub

		Private Sub btnModifyFieldCode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModifyFieldCode.Click
'#Region "#coderange            "
Dim document As Document = richEditControl1.Document
Dim fieldCode As String = document.GetText(document.Fields(0).CodeRange)
If (Not fieldCode.Contains("\@")) Then
	Dim position As DocumentPosition = document.Fields(0).CodeRange.End
	document.InsertText(position, "\@ ""MMMM""")
End If
'#End Region ' #coderange
		End Sub

		Private Sub btnCreateFieldFromSelection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreateFieldFromSelection.Click
			Dim document As Document = richEditControl1.Document
			document.Fields.Add(document.Selection)
		End Sub
	End Class
End Namespace