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
'			#Region "#AddField"
			richEditControl1.Document.Fields.Add(richEditControl1.Document.CaretPosition, "DATE")
'			#End Region ' #AddField
		End Sub

		Private Sub btnUpdateField_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdateField.Click
			richEditControl1.Document.Fields.Update()
		End Sub

		Private Sub btnShowFieldCode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowFieldCode.Click
'			#Region "#ShowCodes"
			For i As Integer = 0 To richEditControl1.Document.Fields.Count - 1
				richEditControl1.Document.Fields(i).ShowCodes = True
			Next i
'			#End Region ' #ShowCodes
		End Sub

		Private Sub btnShowFieldResult_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowFieldResult.Click
			For i As Integer = 0 To richEditControl1.Document.Fields.Count - 1
				richEditControl1.Document.Fields(i).ShowCodes = False
			Next i
		End Sub

		Private Sub btnModifyFieldCode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModifyFieldCode.Click
'			#Region "#coderange"
			Dim document As Document = richEditControl1.Document
			For i As Integer = 0 To document.Fields.Count - 1
				Dim fieldCode As String = document.GetText(document.Fields(i).CodeRange)
				If fieldCode = "DATE" Then
					Dim position As DocumentPosition = document.Fields(i).CodeRange.End
					document.InsertText(position, "\@ ""M/d/yyyy h:mm am/pm""")
				End If
			Next i
'			#End Region ' #coderange
			richEditControl1.Document.Fields(0).Update()
		End Sub

		Private Sub btnCreateFieldFromSelection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreateFieldFromSelection.Click
'			#Region "#FieldFromRange"
			richEditControl1.Document.Fields.Add(richEditControl1.Document.Selection)
'			#End Region ' #FieldFromRange
		End Sub
	End Class
End Namespace