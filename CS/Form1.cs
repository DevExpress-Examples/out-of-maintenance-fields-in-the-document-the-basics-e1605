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

        private void btnAddField_Click(object sender, EventArgs e) {
            Document document = richEditControl1.Document;
            document.Fields.Add(document.CaretPosition, "DATE");
        }

        private void btnUpdateField_Click(object sender, EventArgs e) {
            richEditControl1.Document.Fields[0].Update();
        }

        private void btnShowFieldCode_Click(object sender, EventArgs e) {
            richEditControl1.Document.Fields[0].ShowCodes = true;            
        }

        private void btnShowFieldResult_Click(object sender, EventArgs e) {
            richEditControl1.Document.Fields[0].ShowCodes = false;            

        }

        private void btnModifyFieldCode_Click(object sender, EventArgs e) {
#region #coderange            
Document document = richEditControl1.Document;
string fieldCode = document.GetText(document.Fields[0].CodeRange);
if(!fieldCode.Contains("\\@")) {
    DocumentPosition position = document.Fields[0].CodeRange.End;
    document.InsertText(position, @"\@ ""MMMM""");
}
#endregion #coderange
        }

        private void btnCreateFieldFromSelection_Click(object sender, EventArgs e) {
            Document document = richEditControl1.Document;
            document.Fields.Add(document.Selection);
        }
    }
}