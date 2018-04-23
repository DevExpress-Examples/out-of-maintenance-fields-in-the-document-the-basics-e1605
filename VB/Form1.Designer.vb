Imports Microsoft.VisualBasic
Imports System
Namespace FieldsExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.btnAddField = New System.Windows.Forms.Button()
			Me.btnUpdateField = New System.Windows.Forms.Button()
			Me.btnShowFieldCode = New System.Windows.Forms.Button()
			Me.btnShowFieldResult = New System.Windows.Forms.Button()
			Me.btnModifyFieldCode = New System.Windows.Forms.Button()
			Me.btnCreateFieldFromSelection = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.richEditControl1.Location = New System.Drawing.Point(12, 12)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(419, 334)
			Me.richEditControl1.TabIndex = 0
			' 
			' btnAddField
			' 
			Me.btnAddField.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnAddField.Location = New System.Drawing.Point(437, 12)
			Me.btnAddField.Name = "btnAddField"
			Me.btnAddField.Size = New System.Drawing.Size(153, 23)
			Me.btnAddField.TabIndex = 1
			Me.btnAddField.Text = "Add field"
			Me.btnAddField.UseVisualStyleBackColor = True
'			Me.btnAddField.Click += New System.EventHandler(Me.btnAddField_Click);
			' 
			' btnUpdateField
			' 
			Me.btnUpdateField.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnUpdateField.Location = New System.Drawing.Point(437, 42)
			Me.btnUpdateField.Name = "btnUpdateField"
			Me.btnUpdateField.Size = New System.Drawing.Size(153, 23)
			Me.btnUpdateField.TabIndex = 2
			Me.btnUpdateField.Text = "Update field"
			Me.btnUpdateField.UseVisualStyleBackColor = True
'			Me.btnUpdateField.Click += New System.EventHandler(Me.btnUpdateField_Click);
			' 
			' btnShowFieldCode
			' 
			Me.btnShowFieldCode.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnShowFieldCode.Location = New System.Drawing.Point(437, 72)
			Me.btnShowFieldCode.Name = "btnShowFieldCode"
			Me.btnShowFieldCode.Size = New System.Drawing.Size(153, 23)
			Me.btnShowFieldCode.TabIndex = 3
			Me.btnShowFieldCode.Text = "Show Field Code"
			Me.btnShowFieldCode.UseVisualStyleBackColor = True
'			Me.btnShowFieldCode.Click += New System.EventHandler(Me.btnShowFieldCode_Click);
			' 
			' btnShowFieldResult
			' 
			Me.btnShowFieldResult.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnShowFieldResult.Location = New System.Drawing.Point(437, 102)
			Me.btnShowFieldResult.Name = "btnShowFieldResult"
			Me.btnShowFieldResult.Size = New System.Drawing.Size(153, 23)
			Me.btnShowFieldResult.TabIndex = 4
			Me.btnShowFieldResult.Text = "Show Field Result"
			Me.btnShowFieldResult.UseVisualStyleBackColor = True
'			Me.btnShowFieldResult.Click += New System.EventHandler(Me.btnShowFieldResult_Click);
			' 
			' btnModifyFieldCode
			' 
			Me.btnModifyFieldCode.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnModifyFieldCode.Location = New System.Drawing.Point(437, 132)
			Me.btnModifyFieldCode.Name = "btnModifyFieldCode"
			Me.btnModifyFieldCode.Size = New System.Drawing.Size(153, 23)
			Me.btnModifyFieldCode.TabIndex = 5
			Me.btnModifyFieldCode.Text = "Modify field code"
			Me.btnModifyFieldCode.UseVisualStyleBackColor = True
'			Me.btnModifyFieldCode.Click += New System.EventHandler(Me.btnModifyFieldCode_Click);
			' 
			' btnCreateFieldFromSelection
			' 
			Me.btnCreateFieldFromSelection.Location = New System.Drawing.Point(437, 162)
			Me.btnCreateFieldFromSelection.Name = "btnCreateFieldFromSelection"
			Me.btnCreateFieldFromSelection.Size = New System.Drawing.Size(153, 23)
			Me.btnCreateFieldFromSelection.TabIndex = 6
			Me.btnCreateFieldFromSelection.Text = "Create field from selection"
			Me.btnCreateFieldFromSelection.UseVisualStyleBackColor = True
'			Me.btnCreateFieldFromSelection.Click += New System.EventHandler(Me.btnCreateFieldFromSelection_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(602, 358)
			Me.Controls.Add(Me.btnCreateFieldFromSelection)
			Me.Controls.Add(Me.btnModifyFieldCode)
			Me.Controls.Add(Me.btnShowFieldResult)
			Me.Controls.Add(Me.btnShowFieldCode)
			Me.Controls.Add(Me.btnUpdateField)
			Me.Controls.Add(Me.btnAddField)
			Me.Controls.Add(Me.richEditControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private WithEvents btnAddField As System.Windows.Forms.Button
		Private WithEvents btnUpdateField As System.Windows.Forms.Button
		Private WithEvents btnShowFieldCode As System.Windows.Forms.Button
		Private WithEvents btnShowFieldResult As System.Windows.Forms.Button
		Private WithEvents btnModifyFieldCode As System.Windows.Forms.Button
		Private WithEvents btnCreateFieldFromSelection As System.Windows.Forms.Button
	End Class
End Namespace

