using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit.API.Native;
#endregion #usings

namespace FieldsExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            #region #AddField
            richEditControl1.Document.Fields.Add(richEditControl1.Document.CaretPosition, "DATE");
            #endregion #AddField
        }

        private void btnUpdateField_Click(object sender, EventArgs e) {
            richEditControl1.Document.Fields.Update();
        }

        private void btnShowFieldCode_Click(object sender, EventArgs e)
        {
            #region #ShowCodes
            for (int i = 0; i < richEditControl1.Document.Fields.Count; i++)
            {
                richEditControl1.Document.Fields[i].ShowCodes = true;
            }
            #endregion #ShowCodes
        }

        private void btnShowFieldResult_Click(object sender, EventArgs e) {
            for (int i = 0; i < richEditControl1.Document.Fields.Count; i++)
            {
                richEditControl1.Document.Fields[i].ShowCodes = false;
            } 
        }

        private void btnModifyFieldCode_Click(object sender, EventArgs e) {
            #region #coderange
            Document document = richEditControl1.Document;
            for (int i = 0; i < document.Fields.Count; i++)
            {
                string fieldCode = document.GetText(document.Fields[i].CodeRange);
                if (fieldCode == "DATE")
                {
                    DocumentPosition position = document.Fields[i].CodeRange.End;
                    document.InsertText(position, @"\@ ""M/d/yyyy h:mm am/pm""");
                } 
            }
            #endregion #coderange
            richEditControl1.Document.Fields[0].Update();
        }

        private void btnCreateFieldFromSelection_Click(object sender, EventArgs e)
        {
            #region #FieldFromRange
            richEditControl1.Document.Fields.Add(richEditControl1.Document.Selection);
            #endregion #FieldFromRange
        }
    }
}